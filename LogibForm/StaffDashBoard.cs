using FrameworkTest;
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
    public partial class StaffDashBoard : Form
    {
        public StaffDashBoard()
        {
            InitializeComponent();
            // Makes the SATA UI Button transparent to match the gradient panel
            btnOverView.CheckedBackground = Color.Transparent;
            btnOverView.NormalBackground = Color.Transparent;

            btnGenre.CheckedBackground = Color.Transparent;
            btnGenre.NormalBackground = Color.Transparent;

            btnWishlist.CheckedBackground = Color.Transparent;
            btnWishlist.NormalBackground = Color.Transparent;

            btnLibrary.CheckedBackground = Color.Transparent;
            btnLibrary.NormalBackground = Color.Transparent;

            btnCart.CheckedBackground = Color.Transparent;
            btnCart.NormalBackground = Color.Transparent;

            btnLogout.CheckedBackground = Color.Transparent;
            btnLogout.NormalBackground = Color.Transparent;
        }

        private void StaffDashBoard_Load(object sender, EventArgs e)
        {

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

        private void btnWishlist_MouseHover(object sender, EventArgs e)
        {
            btnWishlist.Cursor= Cursors.Hand;
        }

        private void btnLibrary_MouseHover(object sender, EventArgs e)
        {
            btnLibrary.Cursor = Cursors.Hand;
        }

        private void btnGenre_MouseHover(object sender, EventArgs e)
        {
            btnGenre.Cursor= Cursors.Hand;
        }

        private void btnOverView_MouseEnter(object sender, EventArgs e)
        {
            overViewPanel.Visible = true;
        }

        private void btnOverView_MouseLeave(object sender, EventArgs e)
        {
            if (!overViewPanel.Bounds.Contains(PointToClient(Cursor.Position)))
                overViewPanel.Visible = false;

        }

        private void btnGenre_MouseEnter(object sender, EventArgs e)
        {
            SelectedGamePanel.Visible = true;
        }

        private void btnGenre_MouseLeave(object sender, EventArgs e)
        {
            SelectedGamePanel.Visible = false;

        }

        private void btnWishlist_MouseEnter(object sender, EventArgs e)
        {
            WishListPanel.Visible = true;
        }

        private void btnWishlist_MouseLeave(object sender, EventArgs e)
        {
            WishListPanel.Visible = false;

        }

        private void btnLibrary_MouseEnter(object sender, EventArgs e)
        {
            LibraryPanel.Visible = true;
        }

        private void btnLibrary_MouseLeave(object sender, EventArgs e)
        {
            LibraryPanel.Visible = false;

        }

        private void btnCart_MouseEnter(object sender, EventArgs e)
        {
            CartPanel.Visible = true;
        }

        private void btnCart_MouseLeave(object sender, EventArgs e)
        {
            CartPanel.Visible = false;

        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            LogoutPanel.Visible = true;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            LogoutPanel.Visible = false;
        }
    }
}
