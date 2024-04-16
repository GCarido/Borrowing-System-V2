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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.staffInventoryData = new System.Windows.Forms.DataGridView();
            this.equipmentIDTxtbx = new System.Windows.Forms.TextBox();
            this.equipmentNameTxtbx = new System.Windows.Forms.TextBox();
            this.equipmentDescriptionTxtbx = new System.Windows.Forms.TextBox();
            this.conditionTxtbx = new System.Windows.Forms.TextBox();
            this.quantityTxtbx = new System.Windows.Forms.TextBox();
            this.searchData = new System.Windows.Forms.TextBox();
            this.searchBTN = new System.Windows.Forms.Button();
            this.equipmentImage = new System.Windows.Forms.PictureBox();
            this.equipmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condition_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.staffInventoryData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // staffInventoryData
            // 
            this.staffInventoryData.AllowUserToAddRows = false;
            this.staffInventoryData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Gadugi", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffInventoryData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.staffInventoryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffInventoryData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipmentID,
            this.equipmentName,
            this.equipmentDescription,
            this.quantity,
            this.condition_,
            this.image});
            this.staffInventoryData.Location = new System.Drawing.Point(533, 117);
            this.staffInventoryData.Name = "staffInventoryData";
            this.staffInventoryData.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffInventoryData.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.staffInventoryData.RowHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffInventoryData.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.staffInventoryData.Size = new System.Drawing.Size(939, 445);
            this.staffInventoryData.TabIndex = 7;
            this.staffInventoryData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffInventoryData_CellClick);
            // 
            // equipmentIDTxtbx
            // 
            this.equipmentIDTxtbx.BackColor = System.Drawing.Color.White;
            this.equipmentIDTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.equipmentIDTxtbx.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentIDTxtbx.Location = new System.Drawing.Point(27, 285);
            this.equipmentIDTxtbx.Name = "equipmentIDTxtbx";
            this.equipmentIDTxtbx.ReadOnly = true;
            this.equipmentIDTxtbx.Size = new System.Drawing.Size(144, 22);
            this.equipmentIDTxtbx.TabIndex = 0;
            this.equipmentIDTxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // equipmentNameTxtbx
            // 
            this.equipmentNameTxtbx.BackColor = System.Drawing.Color.White;
            this.equipmentNameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.equipmentNameTxtbx.Font = new System.Drawing.Font("Gadugi", 12F);
            this.equipmentNameTxtbx.Location = new System.Drawing.Point(204, 285);
            this.equipmentNameTxtbx.Name = "equipmentNameTxtbx";
            this.equipmentNameTxtbx.ReadOnly = true;
            this.equipmentNameTxtbx.Size = new System.Drawing.Size(233, 22);
            this.equipmentNameTxtbx.TabIndex = 1;
            this.equipmentNameTxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // equipmentDescriptionTxtbx
            // 
            this.equipmentDescriptionTxtbx.BackColor = System.Drawing.Color.White;
            this.equipmentDescriptionTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.equipmentDescriptionTxtbx.Font = new System.Drawing.Font("Gadugi", 12F);
            this.equipmentDescriptionTxtbx.Location = new System.Drawing.Point(33, 370);
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
            this.conditionTxtbx.Font = new System.Drawing.Font("Gadugi", 12F);
            this.conditionTxtbx.Location = new System.Drawing.Point(215, 524);
            this.conditionTxtbx.Name = "conditionTxtbx";
            this.conditionTxtbx.ReadOnly = true;
            this.conditionTxtbx.Size = new System.Drawing.Size(222, 22);
            this.conditionTxtbx.TabIndex = 4;
            this.conditionTxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // quantityTxtbx
            // 
            this.quantityTxtbx.BackColor = System.Drawing.Color.White;
            this.quantityTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityTxtbx.Font = new System.Drawing.Font("Gadugi", 12F);
            this.quantityTxtbx.Location = new System.Drawing.Point(26, 526);
            this.quantityTxtbx.Name = "quantityTxtbx";
            this.quantityTxtbx.ReadOnly = true;
            this.quantityTxtbx.Size = new System.Drawing.Size(144, 22);
            this.quantityTxtbx.TabIndex = 3;
            this.quantityTxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // equipmentImage
            // 
            this.equipmentImage.BackColor = System.Drawing.Color.Transparent;
            this.equipmentImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.equipmentImage.Location = new System.Drawing.Point(50, 33);
            this.equipmentImage.Name = "equipmentImage";
            this.equipmentImage.Size = new System.Drawing.Size(364, 182);
            this.equipmentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.equipmentImage.TabIndex = 23;
            this.equipmentImage.TabStop = false;
            // 
            // equipmentID
            // 
            this.equipmentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.equipmentID.DataPropertyName = "equipmentID";
            this.equipmentID.HeaderText = "Equipment ID";
            this.equipmentID.Name = "equipmentID";
            this.equipmentID.ReadOnly = true;
            // 
            // equipmentName
            // 
            this.equipmentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.equipmentName.DataPropertyName = "equipmentName";
            this.equipmentName.HeaderText = "Equipment Name";
            this.equipmentName.Name = "equipmentName";
            this.equipmentName.ReadOnly = true;
            this.equipmentName.Width = 160;
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
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
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
            this.condition_.Width = 85;
            // 
            // image
            // 
            this.image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.image.DataPropertyName = "image";
            this.image.HeaderText = "Image";
            this.image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Width = 150;
            // 
            // StaffInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BorrowingSystemV2.Properties.Resources.inventory_ui_v2;
            this.ClientSize = new System.Drawing.Size(1532, 650);
            this.Controls.Add(this.equipmentImage);
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
            ((System.ComponentModel.ISupportInitialize)(this.equipmentImage)).EndInit();
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
        private System.Windows.Forms.TextBox searchData;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.PictureBox equipmentImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn condition_;
        private System.Windows.Forms.DataGridViewImageColumn image;
    }
}