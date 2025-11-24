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

            btnLogout.CheckedBackground = Color.Transparent;
            btnLogout.NormalBackground = Color.Transparent;

            btnInventory.CheckedBackground = Color.Transparent;
            btnInventory.NormalBackground = Color.Transparent;
        }

        private void StaffDashBoard_Load(object sender, EventArgs e)
        {
            showPanel(overviewPanel);

        }
        
        private void btnOverView_MouseHover(object sender, EventArgs e)
        {
            btnOverView.Cursor = Cursors.Hand;

        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            btnLogout.Cursor= Cursors.Hand;
        }

        private void showPanel(Panel panelToShow)
        {
            overviewPanel.Visible = false;
            inventoryPanel.Visible = false;

            panelToShow.Visible = true;
            panelToShow.BringToFront();
        }

        private void btnOverView_Click(object sender, EventArgs e)
        {
            showPanel(overviewPanel);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            showPanel(inventoryPanel);
        }

        private void loadInventoryGrid()
        {
            dgvInventory.Rows.Clear();
            dgvInventory.Columns.Clear();

            // Create Columns
            dgvInventory.Columns.Add("GameID", "Game ID");
            dgvInventory.Columns.Add("GameName", "Name");
            dgvInventory.Columns.Add("GameGenre", "Genre");
            dgvInventory.Columns.Add("GameDescription", "Description");
            dgvInventory.Columns.Add("GameStorage", "Storage (GB)");
            dgvInventory.Columns.Add("GameBuyPrice", "Price (€)");
            dgvInventory.Columns.Add("GameInventory", "Stock");

            // Get all inventory items from DB
            List<Inventory> items = Inventory.getAllInventory();

            // Populate Grid
            foreach (Inventory item in items)
            {
                dgvInventory.Rows.Add(
                    item.getGameID(),
                    item.getGameName(),
                    item.getGameGenre(),
                    item.getGameDescription(),
                    item.getGameStorage(),
                    item.getGameBuyPrice(),
                    item.getGameInventory()
                );
            }

            // Make ID uneditable
            dgvInventory.Columns["GameID"].ReadOnly = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.LoggedInStaffUser = "";
            Session.LoggedInStaffID = 0;
            StaffLoginForm form = new StaffLoginForm();
            form.Show();
            this.Close();
        }
    }
}
