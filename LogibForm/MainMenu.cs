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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        
        private void lblRegisterHere_Click(object sender, EventArgs e)
        {
            CustomerRegistrationForm register = new CustomerRegistrationForm();
            register.Show();
            this.Hide();
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnCustomer.Cursor = Cursors.Hand;
        }
    }
}
