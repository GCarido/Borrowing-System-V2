namespace BorrowingSystemV2
{
    partial class AdminAccountManangement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAccountManangement));
            this.adminListBTN = new System.Windows.Forms.Button();
            this.staffListBTN = new System.Windows.Forms.Button();
            this.studentListBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentData = new System.Windows.Forms.DataGridView();
            this.staffData = new System.Windows.Forms.DataGridView();
            this.adminData = new System.Windows.Forms.DataGridView();
            this.searchData = new System.Windows.Forms.TextBox();
            this.searchBTN = new System.Windows.Forms.Button();
            this.studentList1 = new BorrowingSystemV2.AdminAccManagementPanels.StudentList();
            this.staffList1 = new BorrowingSystemV2.AdminAccManagementPanels.StaffList();
            this.adminList1 = new BorrowingSystemV2.AdminAccManagementPanels.AdminList();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminData)).BeginInit();
            this.SuspendLayout();
            // 
            // adminListBTN
            // 
            this.adminListBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.adminListBTN.FlatAppearance.BorderSize = 0;
            this.adminListBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminListBTN.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold);
            this.adminListBTN.Location = new System.Drawing.Point(421, 3);
            this.adminListBTN.Name = "adminListBTN";
            this.adminListBTN.Size = new System.Drawing.Size(203, 53);
            this.adminListBTN.TabIndex = 6;
            this.adminListBTN.Text = "Admin List";
            this.adminListBTN.UseVisualStyleBackColor = false;
            this.adminListBTN.Click += new System.EventHandler(this.adminListBTN_Click);
            // 
            // staffListBTN
            // 
            this.staffListBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.staffListBTN.FlatAppearance.BorderSize = 0;
            this.staffListBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffListBTN.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold);
            this.staffListBTN.Location = new System.Drawing.Point(212, 1);
            this.staffListBTN.Name = "staffListBTN";
            this.staffListBTN.Size = new System.Drawing.Size(203, 53);
            this.staffListBTN.TabIndex = 5;
            this.staffListBTN.Text = "Staff List";
            this.staffListBTN.UseVisualStyleBackColor = false;
            this.staffListBTN.Click += new System.EventHandler(this.staffListBTN_Click);
            // 
            // studentListBTN
            // 
            this.studentListBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(168)))), ((int)(((byte)(115)))));
            this.studentListBTN.FlatAppearance.BorderSize = 0;
            this.studentListBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentListBTN.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold);
            this.studentListBTN.Location = new System.Drawing.Point(3, 1);
            this.studentListBTN.Name = "studentListBTN";
            this.studentListBTN.Size = new System.Drawing.Size(203, 53);
            this.studentListBTN.TabIndex = 4;
            this.studentListBTN.Text = "Student List";
            this.studentListBTN.UseVisualStyleBackColor = false;
            this.studentListBTN.Click += new System.EventHandler(this.studentListBTN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.adminListBTN);
            this.panel1.Controls.Add(this.studentListBTN);
            this.panel1.Controls.Add(this.staffListBTN);
            this.panel1.Location = new System.Drawing.Point(691, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 57);
            this.panel1.TabIndex = 13;
            // 
            // studentData
            // 
            this.studentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentData.Location = new System.Drawing.Point(613, 151);
            this.studentData.Name = "studentData";
            this.studentData.RowHeadersWidth = 51;
            this.studentData.Size = new System.Drawing.Size(799, 477);
            this.studentData.TabIndex = 14;
            this.studentData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentData_CellClick);
            this.studentData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentData_CellContentClick);
            // 
            // staffData
            // 
            this.staffData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffData.Location = new System.Drawing.Point(613, 151);
            this.staffData.Name = "staffData";
            this.staffData.RowHeadersWidth = 51;
            this.staffData.Size = new System.Drawing.Size(799, 477);
            this.staffData.TabIndex = 15;
            this.staffData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffData_CellClick);
            this.staffData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffData_CellContentClick);
            // 
            // adminData
            // 
            this.adminData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminData.Location = new System.Drawing.Point(613, 151);
            this.adminData.Name = "adminData";
            this.adminData.RowHeadersWidth = 51;
            this.adminData.Size = new System.Drawing.Size(799, 477);
            this.adminData.TabIndex = 16;
            this.adminData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminData_CellClick);
            this.adminData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminData_CellContentClick);
            // 
            // searchData
            // 
            this.searchData.Location = new System.Drawing.Point(794, 99);
            this.searchData.Multiline = true;
            this.searchData.Name = "searchData";
            this.searchData.Size = new System.Drawing.Size(303, 46);
            this.searchData.TabIndex = 20;
            this.searchData.TextChanged += new System.EventHandler(this.searchData_TextChanged);
            // 
            // searchBTN
            // 
            this.searchBTN.BackColor = System.Drawing.Color.Transparent;
            this.searchBTN.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold);
            this.searchBTN.ForeColor = System.Drawing.Color.Transparent;
            this.searchBTN.Image = global::BorrowingSystemV2.Properties.Resources.Logo__1_;
            this.searchBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBTN.Location = new System.Drawing.Point(1100, 99);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(53, 46);
            this.searchBTN.TabIndex = 21;
            this.searchBTN.UseVisualStyleBackColor = false;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // studentList1
            // 
            this.studentList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.studentList1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("studentList1.BackgroundImage")));
            this.studentList1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.studentList1.Location = new System.Drawing.Point(9, 114);
            this.studentList1.Name = "studentList1";
            this.studentList1.Size = new System.Drawing.Size(508, 450);
            this.studentList1.TabIndex = 17;
            // 
            // staffList1
            // 
            this.staffList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.staffList1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("staffList1.BackgroundImage")));
            this.staffList1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.staffList1.Location = new System.Drawing.Point(9, 114);
            this.staffList1.Name = "staffList1";
            this.staffList1.Size = new System.Drawing.Size(508, 450);
            this.staffList1.TabIndex = 18;
            // 
            // adminList1
            // 
            this.adminList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.adminList1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminList1.BackgroundImage")));
            this.adminList1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adminList1.Location = new System.Drawing.Point(9, 114);
            this.adminList1.Name = "adminList1";
            this.adminList1.Size = new System.Drawing.Size(508, 450);
            this.adminList1.TabIndex = 19;
            // 
            // AdminAccountManangement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BorrowingSystemV2.Properties.Resources.accmng_icon;
            this.ClientSize = new System.Drawing.Size(1532, 650);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.searchData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.studentList1);
            this.Controls.Add(this.staffList1);
            this.Controls.Add(this.adminList1);
            this.Controls.Add(this.studentData);
            this.Controls.Add(this.staffData);
            this.Controls.Add(this.adminData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminAccountManangement";
            this.Text = "AdminAccountManangement";
            this.Load += new System.EventHandler(this.AdminAccountManangement_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button adminListBTN;
        private System.Windows.Forms.Button staffListBTN;
        private System.Windows.Forms.Button studentListBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView studentData;
        private System.Windows.Forms.DataGridView staffData;
        private System.Windows.Forms.DataGridView adminData;
        private AdminAccManagementPanels.StudentList studentList1;
        private AdminAccManagementPanels.StaffList staffList1;
        private AdminAccManagementPanels.AdminList adminList1;
        private System.Windows.Forms.TextBox searchData;
        private System.Windows.Forms.Button searchBTN;
    }
}