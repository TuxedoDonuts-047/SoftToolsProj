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
    public partial class StaffRegistrationForm : Form
    {
        public StaffRegistrationForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            StaffLoginForm login = new StaffLoginForm();
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.TextValue))
            {
                MessageBox.Show("First name must be entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.TextValue))
            {
                MessageBox.Show("Last name must be entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.TextValue))
            {
                MessageBox.Show("Username must be entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.TextValue))
            {
                MessageBox.Show("Email address must be entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.TextValue))
            {
                MessageBox.Show("Password must be entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtConfirmPassword.TextValue))
            {
                MessageBox.Show("Please confirm your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
                return;
            }

            if (txtConfirmPassword.TextValue != txtPassword.TextValue)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
                return;
            }

            string encryptedPassword = PasswordEncryptDecrypt.EncryptPassword(txtPassword.TextValue);

            Staff aStaff = new Staff(
                Staff.getNextStaffID(),
                txtFirstName.TextValue,
                txtLastName.TextValue,
                txtUsername.TextValue,
                txtEmail.TextValue,
                encryptedPassword);

            try
            {
                aStaff.addStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Account creation failed.\n\n" + ex.Message,
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            this.Hide();
            new StaffLoginForm().Show();
        }

        private void staffRegBack_Click(object sender, EventArgs e)
        {
            this.Close();
            StaffLoginForm staffLoginForm = new StaffLoginForm();
            staffLoginForm.Show();
        }

        private void staffRegBack_MouseHover(object sender, EventArgs e)
        {
            staffRegBack.Cursor = Cursors.Hand;            
        }
    }
}
