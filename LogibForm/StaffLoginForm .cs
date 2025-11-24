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
        private int retryCount = 3;

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
            string username = txtUsername.TextValue.Trim();
            string password = txtPassword.TextValue.Trim();

            if (string.IsNullOrWhiteSpace(username))
            {
                retryCount--;
                MessageBox.Show($"Please re-enter Username\n\nYou have {retryCount} left", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                retryCount--;
                MessageBox.Show($"Please re-enter Password\n\nYou have {retryCount} left", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (retryCount == 0)
            {
                MessageBox.Show("Sorry you have used all retries", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            try
            {
                using (OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb))
                {
                    conn.Open();

                    string loginQuery = "SELECT StaffPassword FROM StaffAccount WHERE Username = :username";

                    using (OracleCommand cmd = new OracleCommand(loginQuery, conn))
                    {
                        cmd.Parameters.Add(":username", username);
                        object result = cmd.ExecuteScalar();

                        if (result == null)
                        {
                            retryCount--;
                            MessageBox.Show($"This username does not exist\n\nYou have {retryCount} left",
                                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUsername.Focus();
                            return;
                        }

                        string encryptedPassword = PasswordEncryptDecrypt.staffGetEncryptedPassword(username);
                        string decryptedPassword = PasswordEncryptDecrypt.DecryptPassword(encryptedPassword);

                        if (password != decryptedPassword)
                        {
                            retryCount--;
                            MessageBox.Show($"Incorrect password\n\nYou have {retryCount} left",
                                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtPassword.Focus();
                            return;
                        }

                        Session.LoadStaffSession(username);
                        Session.LoggedInStaffUser = username;

                        this.Hide();
                        StaffDashBoard dashboard = new StaffDashBoard(username);
                        dashboard.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void staffLogBack_Click(object sender, EventArgs e)
        {
            Session.LoggedInStaffUser = "";
            Session.LoggedInStaffID = 0;
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
