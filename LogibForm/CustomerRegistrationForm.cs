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
    public partial class CustomerRegistrationForm : Form
    {
        public CustomerRegistrationForm()
        {
            InitializeComponent();
        }
        
        private void label5_Click(object sender, EventArgs e)
        {
            CustomerLoginForm login = new CustomerLoginForm();
            login.Show();
            this.Hide();
        }

        private void lblLoginHere_MouseHover(object sender, EventArgs e)
        {
            lblLoginHere.Cursor = Cursors.Hand;
        }

        private void btnRegister_MouseHover(object sender, EventArgs e)
        {
            btnRegister.Cursor = Cursors.Hand;
        }

        private void cstRegBack_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerLoginForm form = new CustomerLoginForm();
            form.Show();
        }

        private void cstRegBack_MouseHover(object sender, EventArgs e)
        {
            cstRegBack.Cursor = Cursors.Hand;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.TextValue))
                {
                    MessageBox.Show("First name must be entered", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFirstName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtLastName.TextValue))
                {
                    MessageBox.Show("Last name must be entered", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLastName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtUsername.TextValue))
                {
                    MessageBox.Show("Username must be entered", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEmail.TextValue))
                {
                    MessageBox.Show("Email address must be entered", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPassword.TextValue))
                {
                    MessageBox.Show("Password must be entered", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    return;
                }

                if (txtPassword.TextValue != txtConfirmPassword.TextValue)
                {
                    MessageBox.Show("Passwords do not match", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirmPassword.Focus();
                    return;
                }

                string encryptedPassword = PasswordEncryptDecrypt.EncryptPassword(txtPassword.TextValue);

                Customer newCustomer = new Customer(
                    Customer.getNextAccountID(),
                    txtFirstName.TextValue.Trim(),
                    txtLastName.TextValue.Trim(),
                    txtUsername.TextValue.Trim(),
                    txtEmail.TextValue.Trim(),
                    encryptedPassword,
                    0.00m,
                    2000.00m
                );

                newCustomer.addCustomer();

                MessageBox.Show("Customer account has been created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                CustomerLoginForm loginForm = new CustomerLoginForm();
                loginForm.Show();
            }
            catch (Oracle.ManagedDataAccess.Client.OracleException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
