namespace BorrowingSystemV2
{
    partial class Logs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.logsTable = new System.Windows.Forms.DataGridView();
            this.logID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructor_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.return_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.return_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBTN = new System.Windows.Forms.Button();
            this.searchData = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // logsTable
            // 
            this.logsTable.AllowUserToAddRows = false;
            this.logsTable.AllowUserToDeleteRows = false;
            this.logsTable.AllowUserToOrderColumns = true;
            this.logsTable.AllowUserToResizeColumns = false;
            this.logsTable.AllowUserToResizeRows = false;
            this.logsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.logsTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.logsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.logsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.logsTable.ColumnHeadersHeight = 50;
            this.logsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.logsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logID,
            this.orderID,
            this.studentName,
            this.subject_code,
            this.instructor_name,
            this.equipmentName,
            this.quantity,
            this.fullName,
            this.order_DATE,
            this.order_TIME,
            this.return_DATE,
            this.return_TIME,
            this.notes});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.logsTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.logsTable.EnableHeadersVisualStyles = false;
            this.logsTable.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.logsTable.Location = new System.Drawing.Point(12, 112);
            this.logsTable.Name = "logsTable";
            this.logsTable.ReadOnly = true;
            this.logsTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.logsTable.RowHeadersVisible = false;
            this.logsTable.RowHeadersWidth = 50;
            this.logsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.logsTable.Size = new System.Drawing.Size(1471, 485);
            this.logsTable.TabIndex = 3;
            // 
            // logID
            // 
            this.logID.DataPropertyName = "logID";
            this.logID.FillWeight = 77.9696F;
            this.logID.HeaderText = "Log ID";
            this.logID.Name = "logID";
            this.logID.ReadOnly = true;
            // 
            // orderID
            // 
            this.orderID.DataPropertyName = "orderID";
            this.orderID.FillWeight = 76.69086F;
            this.orderID.HeaderText = "Order ID";
            this.orderID.Name = "orderID";
            this.orderID.ReadOnly = true;
            // 
            // studentName
            // 
            this.studentName.DataPropertyName = "studentName";
            this.studentName.FillWeight = 147.8824F;
            this.studentName.HeaderText = "Student Name";
            this.studentName.Name = "studentName";
            this.studentName.ReadOnly = true;
            // 
            // subject_code
            // 
            this.subject_code.DataPropertyName = "subject_code";
            this.subject_code.FillWeight = 86.87071F;
            this.subject_code.HeaderText = "Subject Code";
            this.subject_code.Name = "subject_code";
            this.subject_code.ReadOnly = true;
            // 
            // instructor_name
            // 
            this.instructor_name.DataPropertyName = "instructor_name";
            this.instructor_name.FillWeight = 158.3756F;
            this.instructor_name.HeaderText = "Instructor Name";
            this.instructor_name.Name = "instructor_name";
            this.instructor_name.ReadOnly = true;
            // 
            // equipmentName
            // 
            this.equipmentName.DataPropertyName = "equipmentName";
            this.equipmentName.FillWeight = 117.3844F;
            this.equipmentName.HeaderText = "Equipment Name";
            this.equipmentName.Name = "equipmentName";
            this.equipmentName.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.FillWeight = 72.8822F;
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // fullName
            // 
            this.fullName.DataPropertyName = "fullName";
            this.fullName.FillWeight = 117.3844F;
            this.fullName.HeaderText = "Employee Name";
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            // 
            // order_DATE
            // 
            this.order_DATE.DataPropertyName = "order_DATE";
            this.order_DATE.FillWeight = 84.94601F;
            this.order_DATE.HeaderText = "Order Date";
            this.order_DATE.Name = "order_DATE";
            this.order_DATE.ReadOnly = true;
            // 
            // order_TIME
            // 
            this.order_TIME.DataPropertyName = "order_TIME";
            this.order_TIME.FillWeight = 82.8419F;
            this.order_TIME.HeaderText = "Order Time";
            this.order_TIME.Name = "order_TIME";
            this.order_TIME.ReadOnly = true;
            // 
            // return_DATE
            // 
            this.return_DATE.DataPropertyName = "return_DATE";
            this.return_DATE.FillWeight = 80.60132F;
            this.return_DATE.HeaderText = "Return Date";
            this.return_DATE.Name = "return_DATE";
            this.return_DATE.ReadOnly = true;
            // 
            // return_TIME
            // 
            this.return_TIME.DataPropertyName = "return_TIME";
            this.return_TIME.FillWeight = 78.78584F;
            this.return_TIME.HeaderText = "Return Time";
            this.return_TIME.Name = "return_TIME";
            this.return_TIME.ReadOnly = true;
            // 
            // notes
            // 
            this.notes.DataPropertyName = "notes";
            this.notes.FillWeight = 117.3844F;
            this.notes.HeaderText = "Notes";
            this.notes.Name = "notes";
            this.notes.ReadOnly = true;
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
            this.searchBTN.Location = new System.Drawing.Point(956, 45);
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
            this.searchData.Location = new System.Drawing.Point(514, 50);
            this.searchData.Name = "searchData";
            this.searchData.Size = new System.Drawing.Size(476, 26);
            this.searchData.TabIndex = 7;
            this.searchData.TextChanged += new System.EventHandler(this.searchData_TextChanged);
            // 
            // Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BorrowingSystemV2.Properties.Resources.Staff_Logs;
            this.ClientSize = new System.Drawing.Size(1532, 650);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.searchData);
            this.Controls.Add(this.logsTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Logs";
            this.Text = "StaffLogs";
            this.Load += new System.EventHandler(this.StaffLogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView logsTable;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.TextBox searchData;
        private System.Windows.Forms.DataGridViewTextBoxColumn logID;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructor_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn return_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn return_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
    }
}