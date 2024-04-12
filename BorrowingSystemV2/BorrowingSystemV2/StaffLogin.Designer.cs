namespace BorrowingSystemV2
{
    partial class StaffLogin
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
            this.loginStaff = new System.Windows.Forms.Button();
            this.linkAdmin = new System.Windows.Forms.LinkLabel();
            this.staffusertxtbox = new System.Windows.Forms.TextBox();
            this.unhideButton = new System.Windows.Forms.Button();
            this.staffpasstxtbox = new System.Windows.Forms.TextBox();
            this.hideButton = new System.Windows.Forms.Button();
            this.loginpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginpanel
            // 
            this.loginpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(188)))), ((int)(((byte)(228)))));
            this.loginpanel.BackgroundImage = global::BorrowingSystemV2.Properties.Resources._403_4__1_;
            this.loginpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginpanel.Controls.Add(this.loginStaff);
            this.loginpanel.Controls.Add(this.linkAdmin);
            this.loginpanel.Controls.Add(this.staffusertxtbox);
            this.loginpanel.Controls.Add(this.unhideButton);
            this.loginpanel.Controls.Add(this.staffpasstxtbox);
            this.loginpanel.Controls.Add(this.hideButton);
            this.loginpanel.Location = new System.Drawing.Point(0, 0);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(411, 481);
            this.loginpanel.TabIndex = 1;
            this.loginpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginpanel_Paint);
            // 
            // loginStaff
            // 
            this.loginStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(208)))), ((int)(((byte)(155)))));
            this.loginStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginStaff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(208)))), ((int)(((byte)(155)))));
            this.loginStaff.FlatAppearance.BorderSize = 0;
            this.loginStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(208)))), ((int)(((byte)(155)))));
            this.loginStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(208)))), ((int)(((byte)(155)))));
            this.loginStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginStaff.ForeColor = System.Drawing.Color.Black;
            this.loginStaff.Location = new System.Drawing.Point(127, 328);
            this.loginStaff.Name = "loginStaff";
            this.loginStaff.Size = new System.Drawing.Size(154, 38);
            this.loginStaff.TabIndex = 3;
            this.loginStaff.Text = "LOGIN";
            this.loginStaff.UseVisualStyleBackColor = false;
            this.loginStaff.Click += new System.EventHandler(this.loginStaff_Click);
            // 
            // linkAdmin
            // 
            this.linkAdmin.AutoSize = true;
            this.linkAdmin.BackColor = System.Drawing.Color.Transparent;
            this.linkAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAdmin.LinkColor = System.Drawing.Color.Blue;
            this.linkAdmin.Location = new System.Drawing.Point(120, 393);
            this.linkAdmin.Name = "linkAdmin";
            this.linkAdmin.Size = new System.Drawing.Size(172, 25);
            this.linkAdmin.TabIndex = 3;
            this.linkAdmin.TabStop = true;
            this.linkAdmin.Text = "Login as Admin?";
            this.linkAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAdmin_LinkClicked_1);
            // 
            // staffusertxtbox
            // 
            this.staffusertxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.staffusertxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffusertxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffusertxtbox.Location = new System.Drawing.Point(110, 182);
            this.staffusertxtbox.Name = "staffusertxtbox";
            this.staffusertxtbox.Size = new System.Drawing.Size(238, 28);
            this.staffusertxtbox.TabIndex = 0;
            this.staffusertxtbox.TextChanged += new System.EventHandler(this.staffusertxtbox_TextChanged);
            this.staffusertxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.staffusertxtbox_KeyDown);
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
            this.unhideButton.TabIndex = 5;
            this.unhideButton.UseVisualStyleBackColor = true;
            this.unhideButton.Click += new System.EventHandler(this.unhideButton_Click);
            // 
            // staffpasstxtbox
            // 
            this.staffpasstxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.staffpasstxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffpasstxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffpasstxtbox.Location = new System.Drawing.Point(110, 252);
            this.staffpasstxtbox.Name = "staffpasstxtbox";
            this.staffpasstxtbox.Size = new System.Drawing.Size(238, 28);
            this.staffpasstxtbox.TabIndex = 1;
            this.staffpasstxtbox.TextChanged += new System.EventHandler(this.staffpasstxtbox_TextChanged);
            this.staffpasstxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.staffpasstxtbox_KeyDown);
            // 
            // hideButton
            // 
            this.hideButton.BackgroundImage = global::BorrowingSystemV2.Properties.Resources.eye2;
            this.hideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hideButton.FlatAppearance.BorderSize = 0;
            this.hideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideButton.Location = new System.Drawing.Point(301, 247);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(51, 39);
            this.hideButton.TabIndex = 8;
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // StaffLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 481);
            this.Controls.Add(this.loginpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffLogin";
            this.Text = "StaffLogin";
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.Button unhideButton;
        private System.Windows.Forms.Button loginStaff;
        private System.Windows.Forms.LinkLabel linkAdmin;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.TextBox staffusertxtbox;
        private System.Windows.Forms.TextBox staffpasstxtbox;
    }
}