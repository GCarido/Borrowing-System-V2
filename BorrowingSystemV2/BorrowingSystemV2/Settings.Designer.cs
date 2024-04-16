namespace BorrowingSystemV2
{
    partial class Settings
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
            this.profiteBTN = new System.Windows.Forms.Button();
            this.aboutBTN = new System.Windows.Forms.Button();
            this.logBTN = new System.Windows.Forms.Button();
            this.accountInfo = new System.Windows.Forms.Panel();
            this.employeeIDTxtbx = new System.Windows.Forms.TextBox();
            this.firstnameTxtbx = new System.Windows.Forms.TextBox();
            this.positionTxtbx = new System.Windows.Forms.TextBox();
            this.lastnameTxtbx = new System.Windows.Forms.TextBox();
            this.usernameTxtbx = new System.Windows.Forms.TextBox();
            this.passwordTxtbx = new System.Windows.Forms.TextBox();
            this.editBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.accountInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // profiteBTN
            // 
            this.profiteBTN.Location = new System.Drawing.Point(129, 358);
            this.profiteBTN.Name = "profiteBTN";
            this.profiteBTN.Size = new System.Drawing.Size(107, 51);
            this.profiteBTN.TabIndex = 0;
            this.profiteBTN.Text = "Profile";
            this.profiteBTN.UseVisualStyleBackColor = true;
            // 
            // aboutBTN
            // 
            this.aboutBTN.Location = new System.Drawing.Point(117, 439);
            this.aboutBTN.Name = "aboutBTN";
            this.aboutBTN.Size = new System.Drawing.Size(123, 63);
            this.aboutBTN.TabIndex = 1;
            this.aboutBTN.Text = "About";
            this.aboutBTN.UseVisualStyleBackColor = true;
            // 
            // logBTN
            // 
            this.logBTN.Location = new System.Drawing.Point(129, 523);
            this.logBTN.Name = "logBTN";
            this.logBTN.Size = new System.Drawing.Size(111, 47);
            this.logBTN.TabIndex = 2;
            this.logBTN.Text = "LOG OUT";
            this.logBTN.UseVisualStyleBackColor = true;
            this.logBTN.Click += new System.EventHandler(this.logBTN_Click);
            // 
            // accountInfo
            // 
            this.accountInfo.BackColor = System.Drawing.Color.Transparent;
            this.accountInfo.BackgroundImage = global::BorrowingSystemV2.Properties.Resources.Settings__1_;
            this.accountInfo.Controls.Add(this.editBTN);
            this.accountInfo.Controls.Add(this.passwordTxtbx);
            this.accountInfo.Controls.Add(this.usernameTxtbx);
            this.accountInfo.Controls.Add(this.lastnameTxtbx);
            this.accountInfo.Controls.Add(this.positionTxtbx);
            this.accountInfo.Controls.Add(this.firstnameTxtbx);
            this.accountInfo.Controls.Add(this.employeeIDTxtbx);
            this.accountInfo.Controls.Add(this.updateBTN);
            this.accountInfo.Location = new System.Drawing.Point(507, 33);
            this.accountInfo.Name = "accountInfo";
            this.accountInfo.Size = new System.Drawing.Size(974, 565);
            this.accountInfo.TabIndex = 3;
            // 
            // employeeIDTxtbx
            // 
            this.employeeIDTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDTxtbx.Location = new System.Drawing.Point(180, 189);
            this.employeeIDTxtbx.Name = "employeeIDTxtbx";
            this.employeeIDTxtbx.Size = new System.Drawing.Size(245, 35);
            this.employeeIDTxtbx.TabIndex = 0;
            // 
            // firstnameTxtbx
            // 
            this.firstnameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameTxtbx.Location = new System.Drawing.Point(180, 296);
            this.firstnameTxtbx.Name = "firstnameTxtbx";
            this.firstnameTxtbx.Size = new System.Drawing.Size(245, 35);
            this.firstnameTxtbx.TabIndex = 1;
            // 
            // positionTxtbx
            // 
            this.positionTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionTxtbx.Location = new System.Drawing.Point(561, 189);
            this.positionTxtbx.Name = "positionTxtbx";
            this.positionTxtbx.Size = new System.Drawing.Size(245, 35);
            this.positionTxtbx.TabIndex = 2;
            // 
            // lastnameTxtbx
            // 
            this.lastnameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameTxtbx.Location = new System.Drawing.Point(561, 296);
            this.lastnameTxtbx.Name = "lastnameTxtbx";
            this.lastnameTxtbx.Size = new System.Drawing.Size(245, 35);
            this.lastnameTxtbx.TabIndex = 3;
            // 
            // usernameTxtbx
            // 
            this.usernameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtbx.Location = new System.Drawing.Point(180, 403);
            this.usernameTxtbx.Name = "usernameTxtbx";
            this.usernameTxtbx.Size = new System.Drawing.Size(245, 35);
            this.usernameTxtbx.TabIndex = 4;
            // 
            // passwordTxtbx
            // 
            this.passwordTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtbx.Location = new System.Drawing.Point(561, 403);
            this.passwordTxtbx.Name = "passwordTxtbx";
            this.passwordTxtbx.Size = new System.Drawing.Size(245, 35);
            this.passwordTxtbx.TabIndex = 5;
            // 
            // editBTN
            // 
            this.editBTN.Location = new System.Drawing.Point(389, 503);
            this.editBTN.Name = "editBTN";
            this.editBTN.Size = new System.Drawing.Size(238, 47);
            this.editBTN.TabIndex = 6;
            this.editBTN.Text = "Edit";
            this.editBTN.UseVisualStyleBackColor = true;
            // 
            // updateBTN
            // 
            this.updateBTN.Location = new System.Drawing.Point(389, 504);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(238, 47);
            this.updateBTN.TabIndex = 7;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BorrowingSystemV2.Properties.Resources.Settings;
            this.ClientSize = new System.Drawing.Size(1532, 650);
            this.Controls.Add(this.accountInfo);
            this.Controls.Add(this.logBTN);
            this.Controls.Add(this.aboutBTN);
            this.Controls.Add(this.profiteBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.accountInfo.ResumeLayout(false);
            this.accountInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button profiteBTN;
        private System.Windows.Forms.Button aboutBTN;
        private System.Windows.Forms.Button logBTN;
        private System.Windows.Forms.Panel accountInfo;
        private System.Windows.Forms.TextBox passwordTxtbx;
        private System.Windows.Forms.TextBox usernameTxtbx;
        private System.Windows.Forms.TextBox lastnameTxtbx;
        private System.Windows.Forms.TextBox positionTxtbx;
        private System.Windows.Forms.TextBox firstnameTxtbx;
        private System.Windows.Forms.TextBox employeeIDTxtbx;
        private System.Windows.Forms.Button editBTN;
        private System.Windows.Forms.Button updateBTN;
    }
}