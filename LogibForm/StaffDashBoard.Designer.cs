namespace LogibForm
{
    partial class StaffDashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDashBoard));
            this.sataEllipseControl1 = new SATAUiFramework.Controls.SATAEllipseControl();
            this.StaffGradienrPanel = new LogibForm.gradientPanel();
            this.btnGenre = new FrameworkTest.SATAButton();
            this.btnLogout = new FrameworkTest.SATAButton();
            this.btnCart = new FrameworkTest.SATAButton();
            this.btnLibrary = new FrameworkTest.SATAButton();
            this.btnWishlist = new FrameworkTest.SATAButton();
            this.btnOverView = new FrameworkTest.SATAButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.overViewPanel = new System.Windows.Forms.Panel();
            this.SelectedGamePanel = new System.Windows.Forms.Panel();
            this.WishListPanel = new System.Windows.Forms.Panel();
            this.LibraryPanel = new System.Windows.Forms.Panel();
            this.CartPanel = new System.Windows.Forms.Panel();
            this.LogoutPanel = new System.Windows.Forms.Panel();
            this.StaffGradienrPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sataEllipseControl1
            // 
            this.sataEllipseControl1.CornerRadius = 36;
            this.sataEllipseControl1.TargetControl = this;
            // 
            // StaffGradienrPanel
            // 
            this.StaffGradienrPanel.BackColor = System.Drawing.Color.Transparent;
            this.StaffGradienrPanel.Controls.Add(this.LogoutPanel);
            this.StaffGradienrPanel.Controls.Add(this.CartPanel);
            this.StaffGradienrPanel.Controls.Add(this.LibraryPanel);
            this.StaffGradienrPanel.Controls.Add(this.WishListPanel);
            this.StaffGradienrPanel.Controls.Add(this.SelectedGamePanel);
            this.StaffGradienrPanel.Controls.Add(this.btnGenre);
            this.StaffGradienrPanel.Controls.Add(this.btnLogout);
            this.StaffGradienrPanel.Controls.Add(this.btnCart);
            this.StaffGradienrPanel.Controls.Add(this.btnLibrary);
            this.StaffGradienrPanel.Controls.Add(this.btnWishlist);
            this.StaffGradienrPanel.Controls.Add(this.btnOverView);
            this.StaffGradienrPanel.Controls.Add(this.pictureBox1);
            this.StaffGradienrPanel.Controls.Add(this.overViewPanel);
            this.StaffGradienrPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.StaffGradienrPanel.gradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.StaffGradienrPanel.gradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(74)))), ((int)(((byte)(158)))));
            this.StaffGradienrPanel.Location = new System.Drawing.Point(0, 0);
            this.StaffGradienrPanel.Name = "StaffGradienrPanel";
            this.StaffGradienrPanel.Size = new System.Drawing.Size(229, 842);
            this.StaffGradienrPanel.TabIndex = 0;
            this.StaffGradienrPanel.MouseHover += new System.EventHandler(this.btnCart_MouseHover);
            // 
            // btnGenre
            // 
            this.btnGenre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGenre.ButtonText = "Select Genre";
            this.btnGenre.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.btnGenre.CheckedForeColor = System.Drawing.Color.White;
            this.btnGenre.CheckedImageTint = System.Drawing.Color.White;
            this.btnGenre.CheckedOutline = System.Drawing.Color.Goldenrod;
            this.btnGenre.CustomDialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnGenre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenre.HoverBackground = System.Drawing.Color.DodgerBlue;
            this.btnGenre.HoverForeColor = System.Drawing.Color.White;
            this.btnGenre.HoverImage = null;
            this.btnGenre.HoverImageTint = System.Drawing.Color.White;
            this.btnGenre.HoverOutline = System.Drawing.Color.Empty;
            this.btnGenre.Image = global::LogibForm.Properties.Resources.target;
            this.btnGenre.ImageAutoCenter = false;
            this.btnGenre.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnGenre.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnGenre.ImageTint = System.Drawing.Color.White;
            this.btnGenre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGenre.IsToggleButton = false;
            this.btnGenre.IsToggled = false;
            this.btnGenre.Location = new System.Drawing.Point(28, 270);
            this.btnGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenre.Name = "btnGenre";
            this.btnGenre.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.btnGenre.NormalForeColor = System.Drawing.Color.White;
            this.btnGenre.NormalOutline = System.Drawing.Color.Empty;
            this.btnGenre.OutlineThickness = 2F;
            this.btnGenre.PressedBackground = System.Drawing.Color.RosyBrown;
            this.btnGenre.PressedForeColor = System.Drawing.Color.White;
            this.btnGenre.PressedImageTint = System.Drawing.Color.White;
            this.btnGenre.PressedOutline = System.Drawing.Color.Empty;
            this.btnGenre.Rounding = new System.Windows.Forms.Padding(0);
            this.btnGenre.Size = new System.Drawing.Size(201, 48);
            this.btnGenre.TabIndex = 7;
            this.btnGenre.TextAutoCenter = false;
            this.btnGenre.TextOffset = new System.Drawing.Point(15, 0);
            this.btnGenre.MouseEnter += new System.EventHandler(this.btnGenre_MouseEnter);
            this.btnGenre.MouseLeave += new System.EventHandler(this.btnGenre_MouseLeave);
            this.btnGenre.MouseHover += new System.EventHandler(this.btnGenre_MouseHover);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogout.ButtonText = "Log out";
            this.btnLogout.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.btnLogout.CheckedForeColor = System.Drawing.Color.White;
            this.btnLogout.CheckedImageTint = System.Drawing.Color.White;
            this.btnLogout.CheckedOutline = System.Drawing.Color.Goldenrod;
            this.btnLogout.CustomDialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.HoverBackground = System.Drawing.Color.DodgerBlue;
            this.btnLogout.HoverForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverImage = null;
            this.btnLogout.HoverImageTint = System.Drawing.Color.White;
            this.btnLogout.HoverOutline = System.Drawing.Color.Empty;
            this.btnLogout.Image = global::LogibForm.Properties.Resources.logout_2;
            this.btnLogout.ImageAutoCenter = false;
            this.btnLogout.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnLogout.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnLogout.ImageTint = System.Drawing.Color.White;
            this.btnLogout.IsToggleButton = false;
            this.btnLogout.IsToggled = false;
            this.btnLogout.Location = new System.Drawing.Point(28, 679);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.btnLogout.NormalForeColor = System.Drawing.Color.White;
            this.btnLogout.NormalOutline = System.Drawing.Color.Empty;
            this.btnLogout.OutlineThickness = 2F;
            this.btnLogout.PressedBackground = System.Drawing.Color.RosyBrown;
            this.btnLogout.PressedForeColor = System.Drawing.Color.White;
            this.btnLogout.PressedImageTint = System.Drawing.Color.White;
            this.btnLogout.PressedOutline = System.Drawing.Color.Empty;
            this.btnLogout.Rounding = new System.Windows.Forms.Padding(0);
            this.btnLogout.Size = new System.Drawing.Size(201, 48);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.TextAutoCenter = false;
            this.btnLogout.TextOffset = new System.Drawing.Point(15, 0);
            this.btnLogout.MouseEnter += new System.EventHandler(this.btnLogout_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            this.btnLogout.MouseHover += new System.EventHandler(this.btnLogout_MouseHover);
            // 
            // btnCart
            // 
            this.btnCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCart.ButtonText = "Cart";
            this.btnCart.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.btnCart.CheckedForeColor = System.Drawing.Color.White;
            this.btnCart.CheckedImageTint = System.Drawing.Color.White;
            this.btnCart.CheckedOutline = System.Drawing.Color.Goldenrod;
            this.btnCart.CustomDialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnCart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.HoverBackground = System.Drawing.Color.DodgerBlue;
            this.btnCart.HoverForeColor = System.Drawing.Color.White;
            this.btnCart.HoverImage = null;
            this.btnCart.HoverImageTint = System.Drawing.Color.White;
            this.btnCart.HoverOutline = System.Drawing.Color.Empty;
            this.btnCart.Image = global::LogibForm.Properties.Resources.logout_4;
            this.btnCart.ImageAutoCenter = false;
            this.btnCart.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnCart.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnCart.ImageTint = System.Drawing.Color.White;
            this.btnCart.IsToggleButton = false;
            this.btnCart.IsToggled = false;
            this.btnCart.Location = new System.Drawing.Point(28, 450);
            this.btnCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCart.Name = "btnCart";
            this.btnCart.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.btnCart.NormalForeColor = System.Drawing.Color.White;
            this.btnCart.NormalOutline = System.Drawing.Color.Empty;
            this.btnCart.OutlineThickness = 2F;
            this.btnCart.PressedBackground = System.Drawing.Color.RosyBrown;
            this.btnCart.PressedForeColor = System.Drawing.Color.White;
            this.btnCart.PressedImageTint = System.Drawing.Color.White;
            this.btnCart.PressedOutline = System.Drawing.Color.Empty;
            this.btnCart.Rounding = new System.Windows.Forms.Padding(0);
            this.btnCart.Size = new System.Drawing.Size(201, 48);
            this.btnCart.TabIndex = 5;
            this.btnCart.TextAutoCenter = false;
            this.btnCart.TextOffset = new System.Drawing.Point(15, 0);
            this.btnCart.MouseEnter += new System.EventHandler(this.btnCart_MouseEnter);
            this.btnCart.MouseLeave += new System.EventHandler(this.btnCart_MouseLeave);
            this.btnCart.MouseHover += new System.EventHandler(this.btnLogout_MouseHover);
            // 
            // btnLibrary
            // 
            this.btnLibrary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLibrary.ButtonText = "Library";
            this.btnLibrary.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.btnLibrary.CheckedForeColor = System.Drawing.Color.White;
            this.btnLibrary.CheckedImageTint = System.Drawing.Color.White;
            this.btnLibrary.CheckedOutline = System.Drawing.Color.Goldenrod;
            this.btnLibrary.CustomDialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnLibrary.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrary.HoverBackground = System.Drawing.Color.DodgerBlue;
            this.btnLibrary.HoverForeColor = System.Drawing.Color.White;
            this.btnLibrary.HoverImage = null;
            this.btnLibrary.HoverImageTint = System.Drawing.Color.White;
            this.btnLibrary.HoverOutline = System.Drawing.Color.Empty;
            this.btnLibrary.Image = global::LogibForm.Properties.Resources.bookPainted;
            this.btnLibrary.ImageAutoCenter = false;
            this.btnLibrary.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnLibrary.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnLibrary.ImageTint = System.Drawing.Color.White;
            this.btnLibrary.IsToggleButton = false;
            this.btnLibrary.IsToggled = false;
            this.btnLibrary.Location = new System.Drawing.Point(28, 390);
            this.btnLibrary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.btnLibrary.NormalForeColor = System.Drawing.Color.White;
            this.btnLibrary.NormalOutline = System.Drawing.Color.Empty;
            this.btnLibrary.OutlineThickness = 2F;
            this.btnLibrary.PressedBackground = System.Drawing.Color.RosyBrown;
            this.btnLibrary.PressedForeColor = System.Drawing.Color.White;
            this.btnLibrary.PressedImageTint = System.Drawing.Color.White;
            this.btnLibrary.PressedOutline = System.Drawing.Color.Empty;
            this.btnLibrary.Rounding = new System.Windows.Forms.Padding(0);
            this.btnLibrary.Size = new System.Drawing.Size(201, 48);
            this.btnLibrary.TabIndex = 4;
            this.btnLibrary.TextAutoCenter = false;
            this.btnLibrary.TextOffset = new System.Drawing.Point(15, 0);
            this.btnLibrary.MouseEnter += new System.EventHandler(this.btnLibrary_MouseEnter);
            this.btnLibrary.MouseLeave += new System.EventHandler(this.btnLibrary_MouseLeave);
            this.btnLibrary.MouseHover += new System.EventHandler(this.btnLibrary_MouseHover);
            // 
            // btnWishlist
            // 
            this.btnWishlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnWishlist.ButtonText = "Wishlist";
            this.btnWishlist.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.btnWishlist.CheckedForeColor = System.Drawing.Color.White;
            this.btnWishlist.CheckedImageTint = System.Drawing.Color.White;
            this.btnWishlist.CheckedOutline = System.Drawing.Color.Goldenrod;
            this.btnWishlist.CustomDialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnWishlist.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWishlist.HoverBackground = System.Drawing.Color.DodgerBlue;
            this.btnWishlist.HoverForeColor = System.Drawing.Color.White;
            this.btnWishlist.HoverImage = null;
            this.btnWishlist.HoverImageTint = System.Drawing.Color.White;
            this.btnWishlist.HoverOutline = System.Drawing.Color.Empty;
            this.btnWishlist.Image = ((System.Drawing.Image)(resources.GetObject("btnWishlist.Image")));
            this.btnWishlist.ImageAutoCenter = false;
            this.btnWishlist.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnWishlist.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnWishlist.ImageTint = System.Drawing.Color.White;
            this.btnWishlist.IsToggleButton = false;
            this.btnWishlist.IsToggled = false;
            this.btnWishlist.Location = new System.Drawing.Point(28, 330);
            this.btnWishlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWishlist.Name = "btnWishlist";
            this.btnWishlist.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.btnWishlist.NormalForeColor = System.Drawing.Color.White;
            this.btnWishlist.NormalOutline = System.Drawing.Color.Empty;
            this.btnWishlist.OutlineThickness = 2F;
            this.btnWishlist.PressedBackground = System.Drawing.Color.RosyBrown;
            this.btnWishlist.PressedForeColor = System.Drawing.Color.White;
            this.btnWishlist.PressedImageTint = System.Drawing.Color.White;
            this.btnWishlist.PressedOutline = System.Drawing.Color.Empty;
            this.btnWishlist.Rounding = new System.Windows.Forms.Padding(0);
            this.btnWishlist.Size = new System.Drawing.Size(201, 48);
            this.btnWishlist.TabIndex = 3;
            this.btnWishlist.TextAutoCenter = false;
            this.btnWishlist.TextOffset = new System.Drawing.Point(15, 0);
            this.btnWishlist.MouseEnter += new System.EventHandler(this.btnWishlist_MouseEnter);
            this.btnWishlist.MouseLeave += new System.EventHandler(this.btnWishlist_MouseLeave);
            this.btnWishlist.MouseHover += new System.EventHandler(this.btnWishlist_MouseHover);
            // 
            // btnOverView
            // 
            this.btnOverView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOverView.ButtonText = "Overview";
            this.btnOverView.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.btnOverView.CheckedForeColor = System.Drawing.Color.White;
            this.btnOverView.CheckedImageTint = System.Drawing.Color.White;
            this.btnOverView.CheckedOutline = System.Drawing.Color.Goldenrod;
            this.btnOverView.CustomDialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnOverView.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverView.HoverBackground = System.Drawing.Color.DodgerBlue;
            this.btnOverView.HoverForeColor = System.Drawing.Color.White;
            this.btnOverView.HoverImage = null;
            this.btnOverView.HoverImageTint = System.Drawing.Color.White;
            this.btnOverView.HoverOutline = System.Drawing.Color.Empty;
            this.btnOverView.Image = ((System.Drawing.Image)(resources.GetObject("btnOverView.Image")));
            this.btnOverView.ImageAutoCenter = false;
            this.btnOverView.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnOverView.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnOverView.ImageTint = System.Drawing.Color.White;
            this.btnOverView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOverView.IsToggleButton = false;
            this.btnOverView.IsToggled = false;
            this.btnOverView.Location = new System.Drawing.Point(28, 210);
            this.btnOverView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOverView.Name = "btnOverView";
            this.btnOverView.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.btnOverView.NormalForeColor = System.Drawing.Color.White;
            this.btnOverView.NormalOutline = System.Drawing.Color.Empty;
            this.btnOverView.OutlineThickness = 2F;
            this.btnOverView.PressedBackground = System.Drawing.Color.RosyBrown;
            this.btnOverView.PressedForeColor = System.Drawing.Color.White;
            this.btnOverView.PressedImageTint = System.Drawing.Color.White;
            this.btnOverView.PressedOutline = System.Drawing.Color.Empty;
            this.btnOverView.Rounding = new System.Windows.Forms.Padding(0);
            this.btnOverView.Size = new System.Drawing.Size(201, 48);
            this.btnOverView.TabIndex = 1;
            this.btnOverView.TextAutoCenter = false;
            this.btnOverView.TextOffset = new System.Drawing.Point(15, 0);
            this.btnOverView.MouseEnter += new System.EventHandler(this.btnOverView_MouseEnter);
            this.btnOverView.MouseLeave += new System.EventHandler(this.btnOverView_MouseLeave);
            this.btnOverView.MouseHover += new System.EventHandler(this.btnOverView_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LogibForm.Properties.Resources.primal_direct_high_resolution_logo_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(40, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // overViewPanel
            // 
            this.overViewPanel.BackColor = System.Drawing.Color.White;
            this.overViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.overViewPanel.Location = new System.Drawing.Point(24, 225);
            this.overViewPanel.Name = "overViewPanel";
            this.overViewPanel.Size = new System.Drawing.Size(5, 25);
            this.overViewPanel.TabIndex = 8;
            // 
            // SelectedGamePanel
            // 
            this.SelectedGamePanel.BackColor = System.Drawing.Color.White;
            this.SelectedGamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedGamePanel.Location = new System.Drawing.Point(24, 283);
            this.SelectedGamePanel.Name = "SelectedGamePanel";
            this.SelectedGamePanel.Size = new System.Drawing.Size(5, 25);
            this.SelectedGamePanel.TabIndex = 9;
            // 
            // WishListPanel
            // 
            this.WishListPanel.BackColor = System.Drawing.Color.White;
            this.WishListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WishListPanel.Location = new System.Drawing.Point(24, 345);
            this.WishListPanel.Name = "WishListPanel";
            this.WishListPanel.Size = new System.Drawing.Size(5, 25);
            this.WishListPanel.TabIndex = 10;
            // 
            // LibraryPanel
            // 
            this.LibraryPanel.BackColor = System.Drawing.Color.White;
            this.LibraryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LibraryPanel.Location = new System.Drawing.Point(24, 403);
            this.LibraryPanel.Name = "LibraryPanel";
            this.LibraryPanel.Size = new System.Drawing.Size(5, 25);
            this.LibraryPanel.TabIndex = 11;
            // 
            // CartPanel
            // 
            this.CartPanel.BackColor = System.Drawing.Color.White;
            this.CartPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CartPanel.Location = new System.Drawing.Point(24, 461);
            this.CartPanel.Name = "CartPanel";
            this.CartPanel.Size = new System.Drawing.Size(5, 25);
            this.CartPanel.TabIndex = 12;
            // 
            // LogoutPanel
            // 
            this.LogoutPanel.BackColor = System.Drawing.Color.White;
            this.LogoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogoutPanel.Location = new System.Drawing.Point(24, 692);
            this.LogoutPanel.Name = "LogoutPanel";
            this.LogoutPanel.Size = new System.Drawing.Size(5, 25);
            this.LogoutPanel.TabIndex = 13;
            // 
            // StaffDashBoard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1324, 842);
            this.Controls.Add(this.StaffGradienrPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            this.Load += new System.EventHandler(this.StaffDashBoard_Load);
            this.StaffGradienrPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SATAUiFramework.Controls.SATAEllipseControl sataEllipseControl1;
        private gradientPanel StaffGradienrPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FrameworkTest.SATAButton btnCart;
        private FrameworkTest.SATAButton btnLibrary;
        private FrameworkTest.SATAButton btnWishlist;
        private FrameworkTest.SATAButton btnLogout;
        private FrameworkTest.SATAButton btnGenre;
        private FrameworkTest.SATAButton btnOverView;
        private System.Windows.Forms.Panel overViewPanel;
        private System.Windows.Forms.Panel CartPanel;
        private System.Windows.Forms.Panel LibraryPanel;
        private System.Windows.Forms.Panel WishListPanel;
        private System.Windows.Forms.Panel SelectedGamePanel;
        private System.Windows.Forms.Panel LogoutPanel;
    }
}