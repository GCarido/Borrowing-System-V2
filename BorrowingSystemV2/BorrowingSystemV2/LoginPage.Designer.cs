namespace BorrowingSystemV2
{
    partial class LoginPage
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
            this.loginPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.adminPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.staffPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.Transparent;
            this.loginPanel.Location = new System.Drawing.Point(1002, 163);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(410, 457);
            this.loginPanel.TabIndex = 2;
            // 
            // adminPanel
            // 
            this.adminPanel.BackColor = System.Drawing.Color.Transparent;
            this.adminPanel.Location = new System.Drawing.Point(501, 80);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(410, 457);
            this.adminPanel.TabIndex = 3;
            // 
            // staffPanel
            // 
            this.staffPanel.BackColor = System.Drawing.Color.Transparent;
            this.staffPanel.Location = new System.Drawing.Point(306, 284);
            this.staffPanel.Name = "staffPanel";
            this.staffPanel.Size = new System.Drawing.Size(410, 457);
            this.staffPanel.TabIndex = 4;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BorrowingSystemV2.Properties.Resources.Login;
            this.ClientSize = new System.Drawing.Size(1556, 850);
            this.Controls.Add(this.staffPanel);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.loginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginPage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginPage_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginPage_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel loginPanel;
        private System.Windows.Forms.FlowLayoutPanel adminPanel;
        private System.Windows.Forms.FlowLayoutPanel staffPanel;
    }
}

