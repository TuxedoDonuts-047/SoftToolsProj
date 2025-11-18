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
    }
}
