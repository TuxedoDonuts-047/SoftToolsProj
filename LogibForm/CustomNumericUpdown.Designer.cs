namespace LogibForm
{
    partial class CustomNumericUpdown
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnMinus = new FrameworkTest.SATAButton();
            this.btnPlus = new FrameworkTest.SATAButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnPlus, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMinus, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtValue, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(96, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtValue
            // 
            this.txtValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.ForeColor = System.Drawing.Color.Black;
            this.txtValue.Location = new System.Drawing.Point(38, 7);
            this.txtValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(19, 20);
            this.txtValue.TabIndex = 3;
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMinus
            // 
            this.btnMinus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnMinus.ButtonText = "-";
            this.btnMinus.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnMinus.CheckedForeColor = System.Drawing.Color.White;
            this.btnMinus.CheckedImageTint = System.Drawing.Color.White;
            this.btnMinus.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnMinus.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinus.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnMinus.HoverForeColor = System.Drawing.Color.White;
            this.btnMinus.HoverImage = null;
            this.btnMinus.HoverImageTint = System.Drawing.Color.White;
            this.btnMinus.HoverOutline = System.Drawing.Color.Empty;
            this.btnMinus.Image = null;
            this.btnMinus.ImageAutoCenter = true;
            this.btnMinus.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnMinus.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMinus.ImageTint = System.Drawing.Color.White;
            this.btnMinus.IsToggleButton = false;
            this.btnMinus.IsToggled = false;
            this.btnMinus.Location = new System.Drawing.Point(4, 3);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.btnMinus.NormalForeColor = System.Drawing.Color.White;
            this.btnMinus.NormalOutline = System.Drawing.Color.Empty;
            this.btnMinus.OutlineThickness = 2F;
            this.btnMinus.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.btnMinus.PressedForeColor = System.Drawing.Color.White;
            this.btnMinus.PressedImageTint = System.Drawing.Color.White;
            this.btnMinus.PressedOutline = System.Drawing.Color.Empty;
            this.btnMinus.Rounding = new System.Windows.Forms.Padding(0);
            this.btnMinus.Size = new System.Drawing.Size(24, 29);
            this.btnMinus.TabIndex = 0;
            this.btnMinus.TextAutoCenter = true;
            this.btnMinus.TextOffset = new System.Drawing.Point(0, 0);
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnPlus.ButtonText = "+";
            this.btnPlus.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnPlus.CheckedForeColor = System.Drawing.Color.White;
            this.btnPlus.CheckedImageTint = System.Drawing.Color.White;
            this.btnPlus.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnPlus.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPlus.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnPlus.HoverForeColor = System.Drawing.Color.White;
            this.btnPlus.HoverImage = null;
            this.btnPlus.HoverImageTint = System.Drawing.Color.White;
            this.btnPlus.HoverOutline = System.Drawing.Color.Empty;
            this.btnPlus.Image = null;
            this.btnPlus.ImageAutoCenter = true;
            this.btnPlus.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnPlus.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPlus.ImageTint = System.Drawing.Color.White;
            this.btnPlus.IsToggleButton = false;
            this.btnPlus.IsToggled = false;
            this.btnPlus.Location = new System.Drawing.Point(68, 3);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.btnPlus.NormalForeColor = System.Drawing.Color.White;
            this.btnPlus.NormalOutline = System.Drawing.Color.Empty;
            this.btnPlus.OutlineThickness = 2F;
            this.btnPlus.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.btnPlus.PressedForeColor = System.Drawing.Color.White;
            this.btnPlus.PressedImageTint = System.Drawing.Color.White;
            this.btnPlus.PressedOutline = System.Drawing.Color.Empty;
            this.btnPlus.Rounding = new System.Windows.Forms.Padding(0);
            this.btnPlus.Size = new System.Drawing.Size(24, 29);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.TextAutoCenter = true;
            this.btnPlus.TextOffset = new System.Drawing.Point(0, 0);
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // CustomNumericUpdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomNumericUpdown";
            this.Size = new System.Drawing.Size(96, 35);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtValue;
        private FrameworkTest.SATAButton btnPlus;
        private FrameworkTest.SATAButton btnMinus;
    }
}
