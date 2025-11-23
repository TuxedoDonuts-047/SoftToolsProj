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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Equals(""))
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

            string encrypted = PasswordEncryptDecrypt.EncryptPassword(txtPassword.Text);

            Customer aCustomer = new Customer(Customer.getNextAccountID(), txtFirstName.Text, txtLastName.Text, txtEmail.Text, encrypted, 0.00m, 2000.00m);
            aCustomer.addCustomer();

            MessageBox.Show("Customer account has been created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            CustomerLoginForm newForm = new CustomerLoginForm();
            newForm.Show();
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
    }
}
