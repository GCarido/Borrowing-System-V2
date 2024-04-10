namespace BorrowingSystemV2
{
    partial class StaffInventory
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
            this.staffInventoryData = new System.Windows.Forms.DataGridView();
            this.equipmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condition_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentIDTxtbx = new System.Windows.Forms.TextBox();
            this.equipmentNameTxtbx = new System.Windows.Forms.TextBox();
            this.equipmentDescriptionTxtbx = new System.Windows.Forms.TextBox();
            this.conditionTxtbx = new System.Windows.Forms.TextBox();
            this.quantityTxtbx = new System.Windows.Forms.TextBox();
            this.searchData = new System.Windows.Forms.TextBox();
            this.searchBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.staffInventoryData)).BeginInit();
            this.SuspendLayout();
            // 
            // staffInventoryData
            // 
            this.staffInventoryData.AllowUserToAddRows = false;
            this.staffInventoryData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffInventoryData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.staffInventoryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffInventoryData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipmentID,
            this.equipmentName,
            this.equipmentDescription,
            this.quantity,
            this.condition_});
            this.staffInventoryData.Location = new System.Drawing.Point(533, 117);
            this.staffInventoryData.Name = "staffInventoryData";
            this.staffInventoryData.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffInventoryData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.staffInventoryData.RowHeadersVisible = false;
            this.staffInventoryData.Size = new System.Drawing.Size(939, 445);
            this.staffInventoryData.TabIndex = 7;
            this.staffInventoryData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffInventoryData_CellClick);
            // 
            // equipmentID
            // 
            this.equipmentID.DataPropertyName = "equipmentID";
            this.equipmentID.HeaderText = "Equipment ID";
            this.equipmentID.Name = "equipmentID";
            this.equipmentID.ReadOnly = true;
            this.equipmentID.Width = 139;
            // 
            // equipmentName
            // 
            this.equipmentName.DataPropertyName = "equipmentName";
            this.equipmentName.HeaderText = "Equipment Name";
            this.equipmentName.Name = "equipmentName";
            this.equipmentName.ReadOnly = true;
            this.equipmentName.Width = 200;
            // 
            // equipmentDescription
            // 
            this.equipmentDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.equipmentDescription.DataPropertyName = "equipmentDescription";
            this.equipmentDescription.HeaderText = "Equipment Description";
            this.equipmentDescription.Name = "equipmentDescription";
            this.equipmentDescription.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 80;
            // 
            // condition_
            // 
            this.condition_.DataPropertyName = "condition_";
            this.condition_.HeaderText = "Condition";
            this.condition_.Name = "condition_";
            this.condition_.ReadOnly = true;
            this.condition_.Width = 90;
            // 
            // equipmentIDTxtbx
            // 
            this.equipmentIDTxtbx.BackColor = System.Drawing.Color.White;
            this.equipmentIDTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.equipmentIDTxtbx.Location = new System.Drawing.Point(33, 279);
            this.equipmentIDTxtbx.Multiline = true;
            this.equipmentIDTxtbx.Name = "equipmentIDTxtbx";
            this.equipmentIDTxtbx.ReadOnly = true;
            this.equipmentIDTxtbx.Size = new System.Drawing.Size(137, 36);
            this.equipmentIDTxtbx.TabIndex = 0;
            // 
            // equipmentNameTxtbx
            // 
            this.equipmentNameTxtbx.BackColor = System.Drawing.Color.White;
            this.equipmentNameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.equipmentNameTxtbx.Location = new System.Drawing.Point(211, 279);
            this.equipmentNameTxtbx.Multiline = true;
            this.equipmentNameTxtbx.Name = "equipmentNameTxtbx";
            this.equipmentNameTxtbx.ReadOnly = true;
            this.equipmentNameTxtbx.Size = new System.Drawing.Size(217, 36);
            this.equipmentNameTxtbx.TabIndex = 1;
            // 
            // equipmentDescriptionTxtbx
            // 
            this.equipmentDescriptionTxtbx.BackColor = System.Drawing.Color.White;
            this.equipmentDescriptionTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.equipmentDescriptionTxtbx.Location = new System.Drawing.Point(33, 368);
            this.equipmentDescriptionTxtbx.Multiline = true;
            this.equipmentDescriptionTxtbx.Name = "equipmentDescriptionTxtbx";
            this.equipmentDescriptionTxtbx.ReadOnly = true;
            this.equipmentDescriptionTxtbx.Size = new System.Drawing.Size(395, 95);
            this.equipmentDescriptionTxtbx.TabIndex = 2;
            // 
            // conditionTxtbx
            // 
            this.conditionTxtbx.BackColor = System.Drawing.Color.White;
            this.conditionTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conditionTxtbx.Location = new System.Drawing.Point(221, 516);
            this.conditionTxtbx.Multiline = true;
            this.conditionTxtbx.Name = "conditionTxtbx";
            this.conditionTxtbx.ReadOnly = true;
            this.conditionTxtbx.Size = new System.Drawing.Size(207, 36);
            this.conditionTxtbx.TabIndex = 4;
            // 
            // quantityTxtbx
            // 
            this.quantityTxtbx.BackColor = System.Drawing.Color.White;
            this.quantityTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityTxtbx.Location = new System.Drawing.Point(33, 519);
            this.quantityTxtbx.Multiline = true;
            this.quantityTxtbx.Name = "quantityTxtbx";
            this.quantityTxtbx.ReadOnly = true;
            this.quantityTxtbx.Size = new System.Drawing.Size(127, 36);
            this.quantityTxtbx.TabIndex = 3;
            // 
            // searchData
            // 
            this.searchData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchData.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchData.Location = new System.Drawing.Point(757, 52);
            this.searchData.Name = "searchData";
            this.searchData.Size = new System.Drawing.Size(400, 26);
            this.searchData.TabIndex = 5;
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
            this.searchBTN.Location = new System.Drawing.Point(1124, 47);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(33, 36);
            this.searchBTN.TabIndex = 6;
            this.searchBTN.UseVisualStyleBackColor = false;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // StaffInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BorrowingSystemV2.Properties.Resources.inventory_ui_v2;
            this.ClientSize = new System.Drawing.Size(1532, 650);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.searchData);
            this.Controls.Add(this.quantityTxtbx);
            this.Controls.Add(this.conditionTxtbx);
            this.Controls.Add(this.equipmentDescriptionTxtbx);
            this.Controls.Add(this.equipmentNameTxtbx);
            this.Controls.Add(this.equipmentIDTxtbx);
            this.Controls.Add(this.staffInventoryData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffInventory";
            this.Text = "StaffInventory";
            this.Load += new System.EventHandler(this.StaffInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffInventoryData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView staffInventoryData;
        private System.Windows.Forms.TextBox equipmentIDTxtbx;
        private System.Windows.Forms.TextBox equipmentNameTxtbx;
        private System.Windows.Forms.TextBox equipmentDescriptionTxtbx;
        private System.Windows.Forms.TextBox conditionTxtbx;
        private System.Windows.Forms.TextBox quantityTxtbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn condition_;
        private System.Windows.Forms.TextBox searchData;
        private System.Windows.Forms.Button searchBTN;
    }
}