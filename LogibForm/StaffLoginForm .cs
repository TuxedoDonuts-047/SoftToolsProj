using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogibForm
{
    public partial class StaffLoginForm: Form
    {
        public StaffLoginForm()
        {
            InitializeComponent();
        }

        private void lblRegisterHere_Click(object sender, EventArgs e)
        {
            StaffRegistrationForm register = new StaffRegistrationForm();
            register.Show();
            this.Hide();
        }

        private void lblRegisterHere_MouseHover(object sender, EventArgs e)
        {
            lblRegisterHere.Cursor = Cursors.Hand;
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.Cursor = Cursors.Hand;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int retryCount = 3;

            string user = txtUsername.TextValue.Trim();
            string password = txtPassword.TextValue.Trim();

            if (string.IsNullOrWhiteSpace(txtUsername.TextValue))
            {
                retryCount--;
                MessageBox.Show("Please re-enter Username\n\nYou have " + retryCount + " left", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.TextValue))
            {
                retryCount--;
                MessageBox.Show("Please re-enter Password\n\nYou have " + retryCount + " left", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            if (retryCount == 0)
            {
                MessageBox.Show("Sorry you have used all retry's", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            try
            {
                using (OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb))
                {
                    conn.Open();

                    string checkLoginQuery = "SELECT COUNT(*) FROM StaffAccount WHERE Username = :suser AND StaffPassword = :password";

                    using (OracleCommand checkCmd = new OracleCommand(checkLoginQuery, conn))
                    {
                        checkCmd.Parameters.Add(":suser", OracleDbType.Varchar2).Value = user;
                        checkCmd.Parameters.Add(":password", OracleDbType.Varchar2).Value = password;

                        object results = checkCmd.ExecuteScalar();


                        if (results == null)
                        {
                            MessageBox.Show("This username does not exist in the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUsername.Focus();
                            return;
                        }
                        if (txtUsername.TextValue != user)
                        {
                            retryCount -= 1;
                            MessageBox.Show("Please re-enter Username\n\nYou have " + retryCount + " left", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtUsername.Focus();
                            return;
                        }

                        string encryptedPassword = PasswordEncryptDecrypt.staffGetEncryptedPassword(user);
                        string decryptedPassword = PasswordEncryptDecrypt.DecryptPassword(encryptedPassword);

                        if (password != decryptedPassword)
                        {
                            retryCount--;
                            MessageBox.Show("Please re-enter Password\n\nYou have " + retryCount + " left", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtPassword.Focus();
                            return;
                        }
                        if (retryCount == 0)
                        {
                            MessageBox.Show("Sorry you have used all retry's", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Application.Exit();
                        }
                        else
                        {
                            Session.LoadStaffSession(user);
                            Session.LoggedInStaffUser = user;
                            MessageBox.Show("Welcome " + user, "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
                            StaffDashBoard mainMenu = new StaffDashBoard();
                            mainMenu.Show();
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void staffLogBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void staffLogBack_MouseHover(object sender, EventArgs e)
        {
            staffLogBack.Cursor = Cursors.Hand;
        }
    }
}
