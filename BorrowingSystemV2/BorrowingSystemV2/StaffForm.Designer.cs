namespace BorrowingSystemV2
{
    partial class StaffForm
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
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.settingsBTN = new System.Windows.Forms.Button();
            this.homeBTN = new System.Windows.Forms.Button();
            this.logsBTN = new System.Windows.Forms.Button();
            this.inventoryBTN = new System.Windows.Forms.Button();
            this.dashboardBTN = new System.Windows.Forms.Button();
            this.orderBTN = new System.Windows.Forms.Button();
            this.staffFormPanel = new System.Windows.Forms.Panel();
            this.employeeITxt = new System.Windows.Forms.Label();
            this.poslbl = new System.Windows.Forms.Label();
            this.positionTxt = new System.Windows.Forms.Label();
            this.idlbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.DarkRed;
            this.MinimizeButton.BackgroundImage = global::BorrowingSystemV2.Properties.Resources._1;
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(1490, 7);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(22, 22);
            this.MinimizeButton.TabIndex = 11;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.DarkRed;
            this.CloseButton.BackgroundImage = global::BorrowingSystemV2.Properties.Resources._2;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(1526, 6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(22, 22);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.settingsBTN);
            this.panel1.Controls.Add(this.homeBTN);
            this.panel1.Controls.Add(this.logsBTN);
            this.panel1.Controls.Add(this.inventoryBTN);
            this.panel1.Controls.Add(this.dashboardBTN);
            this.panel1.Controls.Add(this.orderBTN);
            this.panel1.Location = new System.Drawing.Point(130, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1289, 57);
            this.panel1.TabIndex = 12;
            // 
            // settingsBTN
            // 
            this.settingsBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsBTN.FlatAppearance.BorderSize = 0;
            this.settingsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBTN.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold);
            this.settingsBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.settingsBTN.Image = global::BorrowingSystemV2.Properties.Resources.settings_icon;
            this.settingsBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsBTN.Location = new System.Drawing.Point(1118, 1);
            this.settingsBTN.Name = "settingsBTN";
            this.settingsBTN.Size = new System.Drawing.Size(168, 55);
            this.settingsBTN.TabIndex = 20;
            this.settingsBTN.Text = "      Settings";
            this.settingsBTN.UseVisualStyleBackColor = true;
            this.settingsBTN.Click += new System.EventHandler(this.settingsBTN_Click);
            // 
            // homeBTN
            // 
            this.homeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(168)))), ((int)(((byte)(115)))));
            this.homeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBTN.FlatAppearance.BorderSize = 0;
            this.homeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBTN.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold);
            this.homeBTN.ForeColor = System.Drawing.Color.Black;
            this.homeBTN.Image = global::BorrowingSystemV2.Properties.Resources.home_icon;
            this.homeBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBTN.Location = new System.Drawing.Point(1, 1);
            this.homeBTN.Name = "homeBTN";
            this.homeBTN.Size = new System.Drawing.Size(168, 55);
            this.homeBTN.TabIndex = 18;
            this.homeBTN.Text = "      Home";
            this.homeBTN.UseVisualStyleBackColor = false;
            this.homeBTN.Click += new System.EventHandler(this.homeBTN_Click);
            // 
            // logsBTN
            // 
            this.logsBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logsBTN.FlatAppearance.BorderSize = 0;
            this.logsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logsBTN.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold);
            this.logsBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.logsBTN.Image = global::BorrowingSystemV2.Properties.Resources.logs_icon;
            this.logsBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logsBTN.Location = new System.Drawing.Point(733, 1);
            this.logsBTN.Name = "logsBTN";
            this.logsBTN.Size = new System.Drawing.Size(168, 55);
            this.logsBTN.TabIndex = 17;
            this.logsBTN.Text = "      Logs";
            this.logsBTN.UseVisualStyleBackColor = true;
            this.logsBTN.Click += new System.EventHandler(this.logsBTN_Click);
            // 
            // inventoryBTN
            // 
            this.inventoryBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryBTN.FlatAppearance.BorderSize = 0;
            this.inventoryBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryBTN.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold);
            this.inventoryBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.inventoryBTN.Image = global::BorrowingSystemV2.Properties.Resources.inventory_icon;
            this.inventoryBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventoryBTN.Location = new System.Drawing.Point(542, 1);
            this.inventoryBTN.Name = "inventoryBTN";
            this.inventoryBTN.Size = new System.Drawing.Size(185, 55);
            this.inventoryBTN.TabIndex = 16;
            this.inventoryBTN.Text = "      Inventory";
            this.inventoryBTN.UseVisualStyleBackColor = true;
            this.inventoryBTN.Click += new System.EventHandler(this.inventoryBTN_Click);
            // 
            // dashboardBTN
            // 
            this.dashboardBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardBTN.FlatAppearance.BorderSize = 0;
            this.dashboardBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBTN.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.dashboardBTN.Image = global::BorrowingSystemV2.Properties.Resources.dashboard_icon;
            this.dashboardBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBTN.Location = new System.Drawing.Point(175, 1);
            this.dashboardBTN.Name = "dashboardBTN";
            this.dashboardBTN.Size = new System.Drawing.Size(187, 55);
            this.dashboardBTN.TabIndex = 14;
            this.dashboardBTN.Text = "      Dashboard";
            this.dashboardBTN.UseVisualStyleBackColor = true;
            this.dashboardBTN.Click += new System.EventHandler(this.dashboardBTN_Click);
            // 
            // orderBTN
            // 
            this.orderBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderBTN.FlatAppearance.BorderSize = 0;
            this.orderBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderBTN.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold);
            this.orderBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.orderBTN.Image = global::BorrowingSystemV2.Properties.Resources.order_icon;
            this.orderBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderBTN.Location = new System.Drawing.Point(368, 1);
            this.orderBTN.Name = "orderBTN";
            this.orderBTN.Size = new System.Drawing.Size(168, 55);
            this.orderBTN.TabIndex = 15;
            this.orderBTN.Text = "      Order";
            this.orderBTN.UseVisualStyleBackColor = true;
            this.orderBTN.Click += new System.EventHandler(this.orderBTN_Click);
            // 
            // staffFormPanel
            // 
            this.staffFormPanel.BackColor = System.Drawing.Color.Transparent;
            this.staffFormPanel.Location = new System.Drawing.Point(12, 188);
            this.staffFormPanel.Name = "staffFormPanel";
            this.staffFormPanel.Size = new System.Drawing.Size(1532, 650);
            this.staffFormPanel.TabIndex = 13;
            // 
            // employeeITxt
            // 
            this.employeeITxt.AutoSize = true;
            this.employeeITxt.BackColor = System.Drawing.Color.Transparent;
            this.employeeITxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeITxt.ForeColor = System.Drawing.Color.Yellow;
            this.employeeITxt.Location = new System.Drawing.Point(1352, 79);
            this.employeeITxt.Name = "employeeITxt";
            this.employeeITxt.Size = new System.Drawing.Size(96, 18);
            this.employeeITxt.TabIndex = 19;
            this.employeeITxt.Text = "Employee ID:";
            // 
            // poslbl
            // 
            this.poslbl.AutoSize = true;
            this.poslbl.BackColor = System.Drawing.Color.Transparent;
            this.poslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poslbl.ForeColor = System.Drawing.Color.Cyan;
            this.poslbl.Location = new System.Drawing.Point(1418, 48);
            this.poslbl.Name = "poslbl";
            this.poslbl.Size = new System.Drawing.Size(80, 18);
            this.poslbl.TabIndex = 17;
            this.poslbl.Text = "{position}";
            // 
            // positionTxt
            // 
            this.positionTxt.AutoSize = true;
            this.positionTxt.BackColor = System.Drawing.Color.Transparent;
            this.positionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionTxt.ForeColor = System.Drawing.Color.Yellow;
            this.positionTxt.Location = new System.Drawing.Point(1353, 48);
            this.positionTxt.Name = "positionTxt";
            this.positionTxt.Size = new System.Drawing.Size(66, 18);
            this.positionTxt.TabIndex = 15;
            this.positionTxt.Text = "Position:";
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.BackColor = System.Drawing.Color.Transparent;
            this.idlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlbl.ForeColor = System.Drawing.Color.Cyan;
            this.idlbl.Location = new System.Drawing.Point(1446, 79);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(33, 18);
            this.idlbl.TabIndex = 16;
            this.idlbl.Text = "{id}";
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BorrowingSystemV2.Properties.Resources.Login_layer_1__4_;
            this.ClientSize = new System.Drawing.Size(1556, 850);
            this.Controls.Add(this.employeeITxt);
            this.Controls.Add(this.poslbl);
            this.Controls.Add(this.positionTxt);
            this.Controls.Add(this.idlbl);
            this.Controls.Add(this.staffFormPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.CloseButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StaffForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StaffForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StaffForm_MouseUp);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dashboardBTN;
        private System.Windows.Forms.Button orderBTN;
        private System.Windows.Forms.Button inventoryBTN;
        private System.Windows.Forms.Button logsBTN;
        private System.Windows.Forms.Button settingsBTN;
        private System.Windows.Forms.Button homeBTN;
        private System.Windows.Forms.Panel staffFormPanel;
        private System.Windows.Forms.Label employeeITxt;
        private System.Windows.Forms.Label poslbl;
        private System.Windows.Forms.Label positionTxt;
        private System.Windows.Forms.Label idlbl;
    }
}