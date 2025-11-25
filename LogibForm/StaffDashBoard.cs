using FrameworkTest;
using Oracle.ManagedDataAccess.Client;
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
        private string _username;
        public StaffDashBoard(string username)
        {
            InitializeComponent();
            _username = username;
            lblInventoryUser.Text = _username;
            lblOverviewUser.Text = _username;
            
            // Makes the SATA UI Button transparent to match the gradient panel
            btnOverView.CheckedBackground = Color.Transparent;
            btnOverView.NormalBackground = Color.Transparent;

            btnLogout.CheckedBackground = Color.Transparent;
            btnLogout.NormalBackground = Color.Transparent;

            btnInventory.CheckedBackground = Color.Transparent;
            btnInventory.NormalBackground = Color.Transparent;
            loadInventoryGrid();
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

            dgvInventory.BackgroundColor = Color.White;
            dgvInventory.DefaultCellStyle.BackColor = Color.White;
            dgvInventory.DefaultCellStyle.ForeColor = Color.Black;
            dgvInventory.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 145, 245);
            dgvInventory.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvInventory.DefaultCellStyle.Font = new Font("Century Gothic", 12);
            dgvInventory.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 14, FontStyle.Bold);

            dgvInventory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 145, 245);
            dgvInventory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvInventory.EnableHeadersVisualStyles = false;

            // Create Columns
            dgvInventory.Columns.Add("GameID", "Game ID");
            dgvInventory.Columns.Add("GameName", "Name");
            dgvInventory.Columns.Add("GameGenre", "Genre");
            dgvInventory.Columns.Add("GameDescription", "Description");
            dgvInventory.Columns.Add("GameStorage", "Storage (GB)");
            dgvInventory.Columns.Add("GameBuyPrice", "Price (€)");
            dgvInventory.Columns.Add("GameInventory", "Stock");

            // Auto size columns for better display
            dgvInventory.Columns["GameID"].Width = 50;
            dgvInventory.Columns["GameName"].Width = 200;
            dgvInventory.Columns["GameGenre"].Width = 180;
            dgvInventory.Columns["GameDescription"].Width = 400;
            dgvInventory.Columns["GameStorage"].Width = 85;
            dgvInventory.Columns["GameBuyPrice"].Width = 85;
            dgvInventory.Columns["GameInventory"].Width = 70;

            // Wrap text in Description column
            dgvInventory.Columns["GameDescription"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvInventory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

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

            dgvInventory.Columns["GameID"].ReadOnly = true;

            dgvInventory.RowsDefaultCellStyle.BackColor = Color.White;
            dgvInventory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.LoggedInStaffUser = "";
            Session.LoggedInStaffID = 0;
            lblOverviewUser.Text = "user_1";
            lblInventory.Text = "user_1";
            StaffLoginForm form = new StaffLoginForm();
            form.Show();
            this.Close();
        }

        private void btnUpdateInventory_Click(object sender, EventArgs e)
        {
            int rowsUpdatedCount = 0;

            if (MessageBox.Show("Are you sure you want to update the inventory in the DB?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                using (OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb))
                {
                    conn.Open();

                    using (OracleTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            foreach (DataGridViewRow row in dgvInventory.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    try
                                    {
                                        Inventory item = new Inventory(
                                            Convert.ToInt32(row.Cells["GameID"].Value),
                                            row.Cells["GameName"].Value?.ToString(),
                                            row.Cells["GameGenre"].Value?.ToString(),
                                            row.Cells["GameDescription"].Value?.ToString(),
                                            Convert.ToDecimal(row.Cells["GameStorage"].Value),
                                            Convert.ToDecimal(row.Cells["GameBuyPrice"].Value),
                                            Convert.ToInt32(row.Cells["GameInventory"].Value)
                                        );

                                        bool updated = item.updateGame(conn, transaction);
                                        if (updated) rowsUpdatedCount++;
                                    }
                                    catch (Exception exRow)
                                    {
                                        MessageBox.Show($"Error processing row {row.Index}: {exRow.Message}", "Row Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }

                            transaction.Commit();
                            MessageBox.Show($"Inventory update finished.\nRows successfully updated: {rowsUpdatedCount}", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception exTransaction)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Transaction failed and was rolled back: {exTransaction.Message}", "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                loadInventoryGrid();
            }
            catch (Exception exConnection)
            {
                MessageBox.Show($"Database connection failed: {exConnection.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
