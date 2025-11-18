using System;
using System.Drawing;
using System.Windows.Forms;

namespace LogibForm
{
    public partial class CustomerDashBoard : Form
    {
        public CustomerDashBoard()
        {
            InitializeComponent();
            // Makes the SATA UI Button transparent to match the gradient panel
            btnOverView.CheckedBackground = Color.Transparent;
            btnOverView.NormalBackground = Color.Transparent;

            btnGenre.CheckedBackground = Color.Transparent;
            btnGenre.NormalBackground = Color.Transparent;

            btnLibrary.CheckedBackground = Color.Transparent;
            btnLibrary.NormalBackground = Color.Transparent;

            btnCart.CheckedBackground = Color.Transparent;
            btnCart.NormalBackground = Color.Transparent;

            btnLogout.CheckedBackground = Color.Transparent;
            btnLogout.NormalBackground = Color.Transparent;
        }

        private void StaffDashBoard_Load(object sender, EventArgs e)
        {
            showPanel(overviewPanel);

        }
        
        private void btnOverView_MouseHover(object sender, EventArgs e)
        {
            btnOverView.Cursor = Cursors.Hand;

        }

        private void btnCart_MouseHover(object sender, EventArgs e)
        {
            btnCart.Cursor = Cursors.Hand;
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            btnLogout.Cursor= Cursors.Hand;
        }

        private void btnLibrary_MouseHover(object sender, EventArgs e)
        {
            btnLibrary.Cursor = Cursors.Hand;
        }

        private void btnGenre_MouseHover(object sender, EventArgs e)
        {
            btnGenre.Cursor= Cursors.Hand;
        }
        private void showPanel(Panel panelToShow)
        {
            overviewPanel.Visible = false;
            selectGenrePanel.Visible = false;
            libraryPanel.Visible = false;
            cartPanel.Visible = false;

            panelToShow.Visible = true;
            panelToShow.BringToFront();
        }

        private void btnOverView_Click(object sender, EventArgs e)
        {
            showPanel(overviewPanel);
        }
        private void btnGenre_Click(object sender, EventArgs e)
        {
            showPanel(selectGenrePanel);
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            showPanel(libraryPanel);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            showPanel(cartPanel);
        }
    }
}
