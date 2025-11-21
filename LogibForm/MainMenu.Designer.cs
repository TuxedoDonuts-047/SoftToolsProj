namespace LogibForm
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.CustomerLoginsataEllipseControl = new SATAUiFramework.Controls.SATAEllipseControl();
            this.gradientPanel1 = new LogibForm.gradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStaff = new FrameworkTest.SATAButton();
            this.btnCustomer = new FrameworkTest.SATAButton();
            this.sataPictureBox1 = new SATAUiFramework.Controls.SATAPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sataPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerLoginsataEllipseControl
            // 
            this.CustomerLoginsataEllipseControl.CornerRadius = 40;
            this.CustomerLoginsataEllipseControl.TargetControl = this;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.pictureBox2);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.gradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.gradientPanel1.gradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(74)))), ((int)(((byte)(158)))));
            this.gradientPanel1.Location = new System.Drawing.Point(-1, -5);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(298, 257);
            this.gradientPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME to";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::LogibForm.Properties.Resources.primal_direct_high_resolution_logo_transparent;
            this.pictureBox2.Location = new System.Drawing.Point(72, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LogibForm.Properties.Resources.cloud;
            this.pictureBox1.Location = new System.Drawing.Point(197, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.sataPictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(285, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 254);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnStaff);
            this.panel2.Controls.Add(this.btnCustomer);
            this.panel2.Location = new System.Drawing.Point(7, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 37);
            this.panel2.TabIndex = 21;
            // 
            // btnStaff
            // 
            this.btnStaff.ButtonText = "Staff";
            this.btnStaff.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnStaff.CheckedForeColor = System.Drawing.Color.White;
            this.btnStaff.CheckedImageTint = System.Drawing.Color.White;
            this.btnStaff.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnStaff.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStaff.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.HoverBackground = System.Drawing.Color.DodgerBlue;
            this.btnStaff.HoverForeColor = System.Drawing.Color.White;
            this.btnStaff.HoverImage = null;
            this.btnStaff.HoverImageTint = System.Drawing.Color.White;
            this.btnStaff.HoverOutline = System.Drawing.Color.Empty;
            this.btnStaff.Image = null;
            this.btnStaff.ImageAutoCenter = true;
            this.btnStaff.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnStaff.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnStaff.ImageTint = System.Drawing.Color.White;
            this.btnStaff.IsToggleButton = false;
            this.btnStaff.IsToggled = false;
            this.btnStaff.Location = new System.Drawing.Point(111, 0);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.btnStaff.NormalForeColor = System.Drawing.Color.White;
            this.btnStaff.NormalOutline = System.Drawing.Color.Empty;
            this.btnStaff.OutlineThickness = 2F;
            this.btnStaff.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.btnStaff.PressedForeColor = System.Drawing.Color.White;
            this.btnStaff.PressedImageTint = System.Drawing.Color.White;
            this.btnStaff.PressedOutline = System.Drawing.Color.Empty;
            this.btnStaff.Rounding = new System.Windows.Forms.Padding(5);
            this.btnStaff.Size = new System.Drawing.Size(87, 35);
            this.btnStaff.TabIndex = 14;
            this.btnStaff.TextAutoCenter = true;
            this.btnStaff.TextOffset = new System.Drawing.Point(0, 0);
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.ButtonText = "Customer";
            this.btnCustomer.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnCustomer.CheckedForeColor = System.Drawing.Color.White;
            this.btnCustomer.CheckedImageTint = System.Drawing.Color.White;
            this.btnCustomer.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnCustomer.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCustomer.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.HoverBackground = System.Drawing.Color.DodgerBlue;
            this.btnCustomer.HoverForeColor = System.Drawing.Color.White;
            this.btnCustomer.HoverImage = null;
            this.btnCustomer.HoverImageTint = System.Drawing.Color.White;
            this.btnCustomer.HoverOutline = System.Drawing.Color.Empty;
            this.btnCustomer.Image = null;
            this.btnCustomer.ImageAutoCenter = true;
            this.btnCustomer.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnCustomer.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCustomer.ImageTint = System.Drawing.Color.White;
            this.btnCustomer.IsToggleButton = false;
            this.btnCustomer.IsToggled = false;
            this.btnCustomer.Location = new System.Drawing.Point(1, 0);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.btnCustomer.NormalForeColor = System.Drawing.Color.White;
            this.btnCustomer.NormalOutline = System.Drawing.Color.Empty;
            this.btnCustomer.OutlineThickness = 2F;
            this.btnCustomer.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.btnCustomer.PressedForeColor = System.Drawing.Color.White;
            this.btnCustomer.PressedImageTint = System.Drawing.Color.White;
            this.btnCustomer.PressedOutline = System.Drawing.Color.Empty;
            this.btnCustomer.Rounding = new System.Windows.Forms.Padding(5);
            this.btnCustomer.Size = new System.Drawing.Size(98, 35);
            this.btnCustomer.TabIndex = 12;
            this.btnCustomer.TextAutoCenter = true;
            this.btnCustomer.TextOffset = new System.Drawing.Point(0, 0);
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // sataPictureBox1
            // 
            this.sataPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.sataPictureBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
            this.sataPictureBox1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(68)))), ((int)(((byte)(142)))));
            this.sataPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.sataPictureBox1.BorderSize = 0;
            this.sataPictureBox1.GradientAngle = 50F;
            this.sataPictureBox1.Image = global::LogibForm.Properties.Resources.user;
            this.sataPictureBox1.Location = new System.Drawing.Point(59, 9);
            this.sataPictureBox1.Name = "sataPictureBox1";
            this.sataPictureBox1.Size = new System.Drawing.Size(95, 95);
            this.sataPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sataPictureBox1.TabIndex = 20;
            this.sataPictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 33);
            this.label2.TabIndex = 19;
            this.label2.Text = "Role";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(521, 253);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Login Form";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sataPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private gradientPanel gradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SATAUiFramework.Controls.SATAEllipseControl CustomerLoginsataEllipseControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FrameworkTest.SATAButton btnStaff;
        private FrameworkTest.SATAButton btnCustomer;
        private SATAUiFramework.Controls.SATAPictureBox sataPictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

