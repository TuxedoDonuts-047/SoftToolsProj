namespace LogibForm
{
    partial class CustomerRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRegistrationForm));
            this.label2 = new System.Windows.Forms.Label();
            this.lblLoginHere = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassword = new LogibForm.loginTextBox();
            this.txtConfirmPassword = new LogibForm.loginTextBox();
            this.txtUsername = new LogibForm.loginTextBox();
            this.txtEmail = new LogibForm.loginTextBox();
            this.txtFirstName = new LogibForm.loginTextBox();
            this.txtLastName = new LogibForm.loginTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Label();
            this.gradientPanel1 = new LogibForm.gradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerRegistrationsataEllipseControl1 = new SATAUiFramework.Controls.SATAEllipseControl();
            this.cstRegBack = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cstRegBack)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(448, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Register For An Account";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblLoginHere
            // 
            this.lblLoginHere.AutoSize = true;
            this.lblLoginHere.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginHere.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblLoginHere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.lblLoginHere.Location = new System.Drawing.Point(662, 517);
            this.lblLoginHere.Name = "lblLoginHere";
            this.lblLoginHere.Size = new System.Drawing.Size(80, 19);
            this.lblLoginHere.TabIndex = 12;
            this.lblLoginHere.Text = "Login here";
            this.lblLoginHere.Click += new System.EventHandler(this.label5_Click);
            this.lblLoginHere.MouseHover += new System.EventHandler(this.lblLoginHere_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtConfirmPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Location = new System.Drawing.Point(423, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 425);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.txtPassword.isPassword = true;
            this.txtPassword.label = "Password";
            this.txtPassword.Location = new System.Drawing.Point(31, 285);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtPassword.Size = new System.Drawing.Size(335, 61);
            this.txtPassword.TabIndex = 11;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.txtConfirmPassword.isPassword = true;
            this.txtConfirmPassword.label = "Conform Password";
            this.txtConfirmPassword.Location = new System.Drawing.Point(31, 355);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtConfirmPassword.Size = new System.Drawing.Size(335, 61);
            this.txtConfirmPassword.TabIndex = 12;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.txtUsername.isPassword = false;
            this.txtUsername.label = "Username";
            this.txtUsername.Location = new System.Drawing.Point(31, 145);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtUsername.Size = new System.Drawing.Size(335, 61);
            this.txtUsername.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.txtEmail.isPassword = false;
            this.txtEmail.label = "Email";
            this.txtEmail.Location = new System.Drawing.Point(31, 215);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtEmail.Size = new System.Drawing.Size(335, 61);
            this.txtEmail.TabIndex = 10;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.txtFirstName.isPassword = false;
            this.txtFirstName.label = "First Name";
            this.txtFirstName.Location = new System.Drawing.Point(31, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtFirstName.Size = new System.Drawing.Size(335, 61);
            this.txtFirstName.TabIndex = 7;
            this.txtFirstName.Load += new System.EventHandler(this.loginTextBox1_Load);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.txtLastName.isPassword = false;
            this.txtLastName.label = "Last Name";
            this.txtLastName.Location = new System.Drawing.Point(31, 75);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtLastName.Size = new System.Drawing.Size(335, 61);
            this.txtLastName.TabIndex = 8;
            this.txtLastName.Load += new System.EventHandler(this.loginTextBox2_Load);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(471, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Do you have an account?";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(466, 553);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(279, 43);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Sign Up";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            this.btnRegister.MouseHover += new System.EventHandler(this.btnRegister_MouseHover);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Controls.Add(this.pictureBox2);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.gradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.gradientPanel1.gradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(74)))), ((int)(((byte)(158)))));
            this.gradientPanel1.Location = new System.Drawing.Point(-8, -3);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(419, 645);
            this.gradientPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LogibForm.Properties.Resources.cloud;
            this.pictureBox1.Location = new System.Drawing.Point(241, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 646);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME to";
            // 
            // CustomerRegistrationsataEllipseControl1
            // 
            this.CustomerRegistrationsataEllipseControl1.CornerRadius = 40;
            this.CustomerRegistrationsataEllipseControl1.TargetControl = this;
            // 
            // cstRegBack
            // 
            this.cstRegBack.Image = ((System.Drawing.Image)(resources.GetObject("cstRegBack.Image")));
            this.cstRegBack.Location = new System.Drawing.Point(395, 26);
            this.cstRegBack.Name = "cstRegBack";
            this.cstRegBack.Size = new System.Drawing.Size(37, 23);
            this.cstRegBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cstRegBack.TabIndex = 16;
            this.cstRegBack.TabStop = false;
            this.cstRegBack.Click += new System.EventHandler(this.cstRegBack_Click);
            // 
            // CustomerRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 643);
            this.Controls.Add(this.cstRegBack);
            this.Controls.Add(this.lblLoginHere);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Registration Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cstRegBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private gradientPanel gradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btnRegister;
        private System.Windows.Forms.Label label4;
        private loginTextBox txtFirstName;
        private loginTextBox txtLastName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLoginHere;
        private System.Windows.Forms.PictureBox pictureBox1;
        private loginTextBox txtUsername;
        private loginTextBox txtEmail;
        private loginTextBox txtPassword;
        private loginTextBox txtConfirmPassword;
        private SATAUiFramework.Controls.SATAEllipseControl CustomerRegistrationsataEllipseControl1;
        private System.Windows.Forms.PictureBox cstRegBack;
    }
}

