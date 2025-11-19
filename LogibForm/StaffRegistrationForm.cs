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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginTextBox2_Load(object sender, EventArgs e)
        {

        }

        private void loginTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

            Staff aStaff= new Staff();
            aStaff.addStaff();

            this.Close();
            StaffLoginForm newForm = new StaffLoginForm();
            newForm.Show();
        }
    }
}
