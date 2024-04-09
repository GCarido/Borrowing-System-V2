namespace BorrowingSystemV2
{
    partial class AdminLogin
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
            this.loginpanel = new System.Windows.Forms.Panel();
            this.unhideButton = new System.Windows.Forms.Button();
            this.linkStaff = new System.Windows.Forms.LinkLabel();
            this.loginAdmin = new System.Windows.Forms.Button();
            this.adminpasstxtbox = new System.Windows.Forms.TextBox();
            this.adminusertxtbox = new System.Windows.Forms.TextBox();
            this.hideButton = new System.Windows.Forms.Button();
            this.loginpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginpanel
            // 
            this.loginpanel.BackgroundImage = global::BorrowingSystemV2.Properties.Resources._403_4__2_;
            this.loginpanel.Controls.Add(this.unhideButton);
            this.loginpanel.Controls.Add(this.linkStaff);
            this.loginpanel.Controls.Add(this.loginAdmin);
            this.loginpanel.Controls.Add(this.adminpasstxtbox);
            this.loginpanel.Controls.Add(this.adminusertxtbox);
            this.loginpanel.Controls.Add(this.hideButton);
            this.loginpanel.Location = new System.Drawing.Point(0, 0);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(411, 481);
            this.loginpanel.TabIndex = 1;
            // 
            // unhideButton
            // 
            this.unhideButton.BackgroundImage = global::BorrowingSystemV2.Properties.Resources.eye1;
            this.unhideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.unhideButton.FlatAppearance.BorderSize = 0;
            this.unhideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unhideButton.Location = new System.Drawing.Point(302, 247);
            this.unhideButton.Name = "unhideButton";
            this.unhideButton.Size = new System.Drawing.Size(46, 34);
            this.unhideButton.TabIndex = 6;
            this.unhideButton.UseVisualStyleBackColor = true;
            this.unhideButton.Click += new System.EventHandler(this.unhideButton_Click);
            // 
            // linkStaff
            // 
            this.linkStaff.AutoSize = true;
            this.linkStaff.BackColor = System.Drawing.Color.Transparent;
            this.linkStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkStaff.LinkColor = System.Drawing.Color.Blue;
            this.linkStaff.Location = new System.Drawing.Point(124, 392);
            this.linkStaff.Name = "linkStaff";
            this.linkStaff.Size = new System.Drawing.Size(156, 25);
            this.linkStaff.TabIndex = 3;
            this.linkStaff.TabStop = true;
            this.linkStaff.Text = "Login as Staff?";
            this.linkStaff.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkStaff_LinkClicked);
            // 
            // loginAdmin
            // 
            this.loginAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(208)))), ((int)(((byte)(155)))));
            this.loginAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(208)))), ((int)(((byte)(155)))));
            this.loginAdmin.FlatAppearance.BorderSize = 0;
            this.loginAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(208)))), ((int)(((byte)(155)))));
            this.loginAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(208)))), ((int)(((byte)(155)))));
            this.loginAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAdmin.Location = new System.Drawing.Point(127, 328);
            this.loginAdmin.Name = "loginAdmin";
            this.loginAdmin.Size = new System.Drawing.Size(154, 38);
            this.loginAdmin.TabIndex = 2;
            this.loginAdmin.Text = "LOGIN";
            this.loginAdmin.UseVisualStyleBackColor = false;
            this.loginAdmin.Click += new System.EventHandler(this.loginAdmin_Click);
            // 
            // adminpasstxtbox
            // 
            this.adminpasstxtbox.AcceptsReturn = true;
            this.adminpasstxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.adminpasstxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminpasstxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminpasstxtbox.Location = new System.Drawing.Point(110, 252);
            this.adminpasstxtbox.Name = "adminpasstxtbox";
            this.adminpasstxtbox.Size = new System.Drawing.Size(238, 28);
            this.adminpasstxtbox.TabIndex = 1;
            this.adminpasstxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.adminpasstxtbox_KeyDown);
            // 
            // adminusertxtbox
            // 
            this.adminusertxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.adminusertxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminusertxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminusertxtbox.Location = new System.Drawing.Point(110, 182);
            this.adminusertxtbox.Name = "adminusertxtbox";
            this.adminusertxtbox.Size = new System.Drawing.Size(238, 28);
            this.adminusertxtbox.TabIndex = 0;
            this.adminusertxtbox.TextChanged += new System.EventHandler(this.adminusertxtbox_TextChanged);
            this.adminusertxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.adminusertxtbox_KeyDown);
            // 
            // hideButton
            // 
            this.hideButton.BackgroundImage = global::BorrowingSystemV2.Properties.Resources.eye2;
            this.hideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hideButton.FlatAppearance.BorderSize = 0;
            this.hideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideButton.Location = new System.Drawing.Point(300, 246);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(51, 39);
            this.hideButton.TabIndex = 9;
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 481);
            this.Controls.Add(this.loginpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLogin";
            this.ShowInTaskbar = false;
            this.Text = "AdminLogin";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.Button unhideButton;
        private System.Windows.Forms.LinkLabel linkStaff;
        private System.Windows.Forms.Button loginAdmin;
        private System.Windows.Forms.TextBox adminpasstxtbox;
        private System.Windows.Forms.TextBox adminusertxtbox;
        private System.Windows.Forms.Button hideButton;
    }
}