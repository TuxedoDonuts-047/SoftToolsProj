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

            string email = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                retryCount -= 1;
                MessageBox.Show("Please re-enter Username\n\nYou have " + retryCount + " left", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                retryCount -= 1;
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
                using (OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb)) //Enter Database name here
                {
                    conn.Open();

                    string checkLoginQuery = "SELECT COUNT(*) FROM StaffAccount WHERE EmailAddress = :email AND StaffPassword = :password";

                    using (OracleCommand checkCmd = new OracleCommand(checkLoginQuery, conn))
                    {
                        checkCmd.Parameters.Add(":email", email);
                        checkCmd.Parameters.Add(":password", password);
                        int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (exists == 0)
                        {
                            MessageBox.Show("This username does not exist in the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUsername.Focus();
                            return;
                        }
                        if (txtUsername.Text != email)
                        {
                            retryCount -= 1;
                            MessageBox.Show("Please re-enter Username\n\nYou have " + retryCount + " left", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtUsername.Focus();
                            return;
                        }
                        if (txtPassword.Text != password)
                        {
                            retryCount -= 1;
                            MessageBox.Show("Please re-enter Password\n\nYou have " + retryCount + " left", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtPassword.Focus();
                            return;
                        }
                        if (retryCount == 0)
                        {
                            MessageBox.Show("Sorry you have used all retry's", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                        }
                        else
                        {
                            Session.LoadStaffSession(email);
                            Session.LoggedInStaffUser = email;
                            MessageBox.Show("Welcome " + email, "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
                            CustomerDashBoard mainMenu = new CustomerDashBoard();
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
    }
}
