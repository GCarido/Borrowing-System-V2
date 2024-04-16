namespace BorrowingSystemV2
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dashboardTable = new System.Windows.Forms.DataGridView();
            this.orderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructor_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBTN = new System.Windows.Forms.Button();
            this.searchData = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboardTable
            // 
            this.dashboardTable.AllowUserToAddRows = false;
            this.dashboardTable.AllowUserToDeleteRows = false;
            this.dashboardTable.AllowUserToOrderColumns = true;
            this.dashboardTable.AllowUserToResizeColumns = false;
            this.dashboardTable.AllowUserToResizeRows = false;
            this.dashboardTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dashboardTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.dashboardTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dashboardTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dashboardTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dashboardTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dashboardTable.ColumnHeadersHeight = 50;
            this.dashboardTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dashboardTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderID,
            this.studentName,
            this.subject_code,
            this.instructor_name,
            this.equipmentName,
            this.quantity,
            this.fullName,
            this.order_DATE,
            this.order_TIME,
            this.status_});
            this.dashboardTable.EnableHeadersVisualStyles = false;
            this.dashboardTable.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dashboardTable.Location = new System.Drawing.Point(13, 115);
            this.dashboardTable.Margin = new System.Windows.Forms.Padding(2);
            this.dashboardTable.Name = "dashboardTable";
            this.dashboardTable.ReadOnly = true;
            this.dashboardTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dashboardTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dashboardTable.RowHeadersVisible = false;
            this.dashboardTable.RowHeadersWidth = 50;
            this.dashboardTable.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dashboardTable.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(140)))), ((int)(((byte)(217)))));
            this.dashboardTable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardTable.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dashboardTable.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.dashboardTable.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dashboardTable.RowTemplate.Height = 30;
            this.dashboardTable.RowTemplate.ReadOnly = true;
            this.dashboardTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dashboardTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dashboardTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dashboardTable.Size = new System.Drawing.Size(1479, 492);
            this.dashboardTable.TabIndex = 2;
            this.dashboardTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dashboardTable_CellClick);
            this.dashboardTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dashboardTable_CellContentClick);
            this.dashboardTable.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dashboardTable_CellMouseEnter);
            this.dashboardTable.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dashboardTable_CellMouseLeave);
            this.dashboardTable.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dashboardTable_CellPainting);
            // 
            // orderID
            // 
            this.orderID.DataPropertyName = "orderID";
            this.orderID.HeaderText = "Order ID";
            this.orderID.MinimumWidth = 6;
            this.orderID.Name = "orderID";
            this.orderID.ReadOnly = true;
            // 
            // studentName
            // 
            this.studentName.DataPropertyName = "studentName";
            this.studentName.HeaderText = "Student Name";
            this.studentName.MinimumWidth = 6;
            this.studentName.Name = "studentName";
            this.studentName.ReadOnly = true;
            // 
            // subject_code
            // 
            this.subject_code.DataPropertyName = "subject_code";
            this.subject_code.HeaderText = "Subject Code";
            this.subject_code.MinimumWidth = 6;
            this.subject_code.Name = "subject_code";
            this.subject_code.ReadOnly = true;
            // 
            // instructor_name
            // 
            this.instructor_name.DataPropertyName = "instructor_name";
            this.instructor_name.HeaderText = "Instructor Name";
            this.instructor_name.MinimumWidth = 6;
            this.instructor_name.Name = "instructor_name";
            this.instructor_name.ReadOnly = true;
            // 
            // equipmentName
            // 
            this.equipmentName.DataPropertyName = "equipmentName";
            this.equipmentName.HeaderText = "Equipment Name";
            this.equipmentName.MinimumWidth = 6;
            this.equipmentName.Name = "equipmentName";
            this.equipmentName.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // fullName
            // 
            this.fullName.DataPropertyName = "fullName";
            this.fullName.HeaderText = "Employee Name";
            this.fullName.MinimumWidth = 6;
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            // 
            // order_DATE
            // 
            this.order_DATE.DataPropertyName = "order_DATE";
            dataGridViewCellStyle14.Format = "d";
            dataGridViewCellStyle14.NullValue = null;
            this.order_DATE.DefaultCellStyle = dataGridViewCellStyle14;
            this.order_DATE.HeaderText = "Order Date";
            this.order_DATE.MinimumWidth = 6;
            this.order_DATE.Name = "order_DATE";
            this.order_DATE.ReadOnly = true;
            // 
            // order_TIME
            // 
            this.order_TIME.DataPropertyName = "order_TIME";
            dataGridViewCellStyle15.Format = "T";
            dataGridViewCellStyle15.NullValue = null;
            this.order_TIME.DefaultCellStyle = dataGridViewCellStyle15;
            this.order_TIME.HeaderText = "Order Time";
            this.order_TIME.MinimumWidth = 6;
            this.order_TIME.Name = "order_TIME";
            this.order_TIME.ReadOnly = true;
            // 
            // status_
            // 
            this.status_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.status_.DataPropertyName = "status_";
            this.status_.HeaderText = "Status";
            this.status_.MinimumWidth = 6;
            this.status_.Name = "status_";
            this.status_.ReadOnly = true;
            this.status_.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status_.Width = 79;
            // 
            // searchBTN
            // 
            this.searchBTN.BackColor = System.Drawing.Color.White;
            this.searchBTN.BackgroundImage = global::BorrowingSystemV2.Properties.Resources.Logo__1_1;
            this.searchBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.searchBTN.FlatAppearance.BorderSize = 0;
            this.searchBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.searchBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.searchBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBTN.ForeColor = System.Drawing.Color.White;
            this.searchBTN.Location = new System.Drawing.Point(949, 46);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(33, 36);
            this.searchBTN.TabIndex = 8;
            this.searchBTN.UseVisualStyleBackColor = false;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // searchData
            // 
            this.searchData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchData.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchData.Location = new System.Drawing.Point(514, 51);
            this.searchData.Name = "searchData";
            this.searchData.Size = new System.Drawing.Size(429, 26);
            this.searchData.TabIndex = 7;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BorrowingSystemV2.Properties.Resources.dashboard;
            this.ClientSize = new System.Drawing.Size(1534, 666);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.searchData);
            this.Controls.Add(this.dashboardTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dashboardTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructor_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.TextBox searchData;
    }
}