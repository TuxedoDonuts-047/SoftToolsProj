using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using Oracle.ManagedDataAccess.Client;

namespace LogibForm
{
    public partial class CustomerLoginForm : Form
    {
        public CustomerLoginForm()
        {
            InitializeComponent();
        }
        
        private void lblRegisterHere_Click(object sender, EventArgs e)
        {
            CustomerRegistrationForm register = new CustomerRegistrationForm();
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

            string username = txtUsername.TextValue.Trim();
            string password = txtPassword.TextValue.Trim();

            if (string.IsNullOrWhiteSpace(username))
            {
                retryCount--;
                MessageBox.Show("Please re-enter Username\n\nYou have " + retryCount + " left", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                retryCount--;
                MessageBox.Show("Please re-enter Password\n\nYou have " + retryCount + " left", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    string checkLoginQuery = "SELECT CustPassword FROM CustomerAccount WHERE Username = :username";

                    using (OracleCommand checkCmd = new OracleCommand(checkLoginQuery, conn))
                    {
                        checkCmd.Parameters.Add(":username", username);
                        object result = checkCmd.ExecuteScalar();

                        if (result == null)
                        {
                            retryCount--;
                            MessageBox.Show("This username does not exist in the system\n\nYou have " + retryCount + " left", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUsername.Focus();
                            return;
                        }

                        string encryptedPassword = PasswordEncryptDecrypt.getEncryptedPassword(username);
                        string decryptedPassword = PasswordEncryptDecrypt.DecryptPassword(encryptedPassword);

                        if (password != decryptedPassword)
                        {
                            retryCount--;
                            MessageBox.Show("Incorrect password\n\nYou have " + retryCount + " left", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtPassword.Focus();
                            return;
                        }

                        Session.LoadCustomerSession(username);
                        Session.LoggedInUser = username;
                        MessageBox.Show("Welcome " + username, "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                        CustomerDashBoard mainMenu = new CustomerDashBoard();
                        mainMenu.Show();
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void custLogBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void custLogBack_MouseHover(object sender, EventArgs e)
        {
            custLogBack.Cursor = Cursors.Hand;
        }
    }
}
