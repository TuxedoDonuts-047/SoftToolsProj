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
    public partial class loginTextBox : UserControl
    {
        public loginTextBox()
        {
            InitializeComponent();
        }

        //Create a private field to store the default text value
        private string _label = "defalut value";
        private bool _isPassword = false;


        //Create a public property to get or set the label text
        public string label
        {
            get { return _label; }
            set
            {
                _label = value;
                label1.Text = _label;
            }
        }

        //public properties to  get or set whether the textbox should act as a password field
        public bool isPassword
        {
            get { return _isPassword; }
            set { 
                _isPassword = value;
                textBox1.UseSystemPasswordChar = _isPassword;
            }
        }

        public string TextValue
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        private void loginTextBox_Paint(object sender, PaintEventArgs e)
        {
            // Updates the label text with the value from the property
            label1.Text = label;
            //check the textbox should act as a password field
            if (isPassword)
            {
                textBox1.UseSystemPasswordChar = true;
            }
            else
            {
                textBox1.UseSystemPasswordChar = false;
            }
        }
    }
}
