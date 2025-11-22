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
            if (txtFirstName.Equals(""))
            {
                MessageBox.Show("First name must be entered, Please re-enter", "No input entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }
            if (txtLastName.Equals(""))
            {
                MessageBox.Show("Last name must be entered, Please re-enter", "No input entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }
            if (txtUsername.Equals(""))
            {
                MessageBox.Show("Username must be entered, Please re-enter", "No input entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }
            if (txtEmail.Equals(""))
            {
                MessageBox.Show("Email address must be entered, Please re-enter", "No input entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }
            if (txtPassword.Equals(""))
            {
                MessageBox.Show("Password must be entered, Please re-enter", "No input entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }
            if (txtConfirmPassword.Equals(""))
            {
                MessageBox.Show("The same password above must be entered, Please re-enter", "No input entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }
            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                MessageBox.Show("Password entered above must be the same, Please re-enter", "No input entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }

            string encryptPassword = PasswordEncryptDecrypt.EncryptPassword(txtPassword.Text);

            Staff aStaff= new Staff(Staff.getNextStaffID(), txtFirstName.Text, txtLastName.Text, txtEmail.Text, encryptPassword);
            aStaff.addStaff();

            MessageBox.Show("Staff account has been created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            StaffLoginForm newForm = new StaffLoginForm();
            newForm.Show();
        }

        private void staffRegBack_Click(object sender, EventArgs e)
        {
            this.Close();
            StaffLoginForm staffLoginForm = new StaffLoginForm();
            staffLoginForm.Show();
        }
    }
}
