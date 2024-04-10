namespace BorrowingSystemV2
{
    partial class AdminInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.adminInventoryData = new System.Windows.Forms.DataGridView();
            this.equipmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condition_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBTN = new System.Windows.Forms.Button();
            this.searchData = new System.Windows.Forms.TextBox();
            this.quantityTxtbx = new System.Windows.Forms.TextBox();
            this.conditionTxtbx = new System.Windows.Forms.TextBox();
            this.equipmentDescriptionTxtbx = new System.Windows.Forms.TextBox();
            this.equipmentNameTxtbx = new System.Windows.Forms.TextBox();
            this.equipmentIDTxtbx = new System.Windows.Forms.TextBox();
            this.createBTN = new System.Windows.Forms.Button();
            this.insertimageBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.doneBTN = new System.Windows.Forms.Button();
            this.editBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.adminInventoryData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminInventoryData
            // 
            this.adminInventoryData.AllowUserToAddRows = false;
            this.adminInventoryData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gadugi", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminInventoryData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.adminInventoryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminInventoryData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipmentID,
            this.equipmentName,
            this.equipmentDescription,
            this.quantity,
            this.condition_});
            this.adminInventoryData.Location = new System.Drawing.Point(545, 114);
            this.adminInventoryData.Name = "adminInventoryData";
            this.adminInventoryData.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminInventoryData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.adminInventoryData.RowHeadersVisible = false;
            this.adminInventoryData.Size = new System.Drawing.Size(881, 457);
            this.adminInventoryData.TabIndex = 15;
            this.adminInventoryData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminInventoryData_CellClick);
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
            this.searchBTN.Location = new System.Drawing.Point(1115, 46);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(33, 36);
            this.searchBTN.TabIndex = 14;
            this.searchBTN.UseVisualStyleBackColor = false;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click_1);
            // 
            // searchData
            // 
            this.searchData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchData.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchData.Location = new System.Drawing.Point(757, 52);
            this.searchData.Name = "searchData";
            this.searchData.Size = new System.Drawing.Size(400, 26);
            this.searchData.TabIndex = 13;
            // 
            // quantityTxtbx
            // 
            this.quantityTxtbx.BackColor = System.Drawing.Color.White;
            this.quantityTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityTxtbx.Location = new System.Drawing.Point(33, 527);
            this.quantityTxtbx.Multiline = true;
            this.quantityTxtbx.Name = "quantityTxtbx";
            this.quantityTxtbx.ReadOnly = true;
            this.quantityTxtbx.Size = new System.Drawing.Size(127, 36);
            this.quantityTxtbx.TabIndex = 11;
            // 
            // conditionTxtbx
            // 
            this.conditionTxtbx.BackColor = System.Drawing.Color.White;
            this.conditionTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conditionTxtbx.Location = new System.Drawing.Point(221, 524);
            this.conditionTxtbx.Multiline = true;
            this.conditionTxtbx.Name = "conditionTxtbx";
            this.conditionTxtbx.ReadOnly = true;
            this.conditionTxtbx.Size = new System.Drawing.Size(207, 36);
            this.conditionTxtbx.TabIndex = 12;
            // 
            // equipmentDescriptionTxtbx
            // 
            this.equipmentDescriptionTxtbx.BackColor = System.Drawing.Color.White;
            this.equipmentDescriptionTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.equipmentDescriptionTxtbx.Location = new System.Drawing.Point(33, 376);
            this.equipmentDescriptionTxtbx.Multiline = true;
            this.equipmentDescriptionTxtbx.Name = "equipmentDescriptionTxtbx";
            this.equipmentDescriptionTxtbx.ReadOnly = true;
            this.equipmentDescriptionTxtbx.Size = new System.Drawing.Size(395, 95);
            this.equipmentDescriptionTxtbx.TabIndex = 10;
            // 
            // equipmentNameTxtbx
            // 
            this.equipmentNameTxtbx.BackColor = System.Drawing.Color.White;
            this.equipmentNameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.equipmentNameTxtbx.Location = new System.Drawing.Point(211, 287);
            this.equipmentNameTxtbx.Multiline = true;
            this.equipmentNameTxtbx.Name = "equipmentNameTxtbx";
            this.equipmentNameTxtbx.ReadOnly = true;
            this.equipmentNameTxtbx.Size = new System.Drawing.Size(217, 36);
            this.equipmentNameTxtbx.TabIndex = 9;
            // 
            // equipmentIDTxtbx
            // 
            this.equipmentIDTxtbx.BackColor = System.Drawing.Color.White;
            this.equipmentIDTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.equipmentIDTxtbx.Location = new System.Drawing.Point(33, 287);
            this.equipmentIDTxtbx.Multiline = true;
            this.equipmentIDTxtbx.Name = "equipmentIDTxtbx";
            this.equipmentIDTxtbx.ReadOnly = true;
            this.equipmentIDTxtbx.Size = new System.Drawing.Size(137, 36);
            this.equipmentIDTxtbx.TabIndex = 8;
            // 
            // createBTN
            // 
            this.createBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.createBTN.FlatAppearance.BorderSize = 0;
            this.createBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBTN.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.createBTN.Location = new System.Drawing.Point(40, 580);
            this.createBTN.Name = "createBTN";
            this.createBTN.Size = new System.Drawing.Size(90, 40);
            this.createBTN.TabIndex = 16;
            this.createBTN.Text = "Create";
            this.createBTN.UseVisualStyleBackColor = false;
            this.createBTN.Visible = false;
            // 
            // insertimageBTN
            // 
            this.insertimageBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.insertimageBTN.FlatAppearance.BorderSize = 0;
            this.insertimageBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertimageBTN.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.insertimageBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.insertimageBTN.Location = new System.Drawing.Point(159, 201);
            this.insertimageBTN.Name = "insertimageBTN";
            this.insertimageBTN.Size = new System.Drawing.Size(143, 39);
            this.insertimageBTN.TabIndex = 17;
            this.insertimageBTN.Text = "Insert Image";
            this.insertimageBTN.UseVisualStyleBackColor = false;
            this.insertimageBTN.Visible = false;
            // 
            // updateBTN
            // 
            this.updateBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.updateBTN.FlatAppearance.BorderSize = 0;
            this.updateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBTN.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.updateBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.updateBTN.Location = new System.Drawing.Point(136, 580);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(90, 40);
            this.updateBTN.TabIndex = 18;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = false;
            this.updateBTN.Visible = false;
            // 
            // deleteBTN
            // 
            this.deleteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.deleteBTN.FlatAppearance.BorderSize = 0;
            this.deleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBTN.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.deleteBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.deleteBTN.Location = new System.Drawing.Point(232, 580);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(90, 40);
            this.deleteBTN.TabIndex = 19;
            this.deleteBTN.Text = "Delete";
            this.deleteBTN.UseVisualStyleBackColor = false;
            this.deleteBTN.Visible = false;
            // 
            // doneBTN
            // 
            this.doneBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.doneBTN.FlatAppearance.BorderSize = 0;
            this.doneBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneBTN.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.doneBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.doneBTN.Location = new System.Drawing.Point(328, 580);
            this.doneBTN.Name = "doneBTN";
            this.doneBTN.Size = new System.Drawing.Size(90, 40);
            this.doneBTN.TabIndex = 20;
            this.doneBTN.Text = "Done";
            this.doneBTN.UseVisualStyleBackColor = false;
            this.doneBTN.Visible = false;
            this.doneBTN.Click += new System.EventHandler(this.doneBTN_Click);
            // 
            // editBTN
            // 
            this.editBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.editBTN.FlatAppearance.BorderSize = 0;
            this.editBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBTN.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.editBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.editBTN.Location = new System.Drawing.Point(178, 580);
            this.editBTN.Name = "editBTN";
            this.editBTN.Size = new System.Drawing.Size(90, 40);
            this.editBTN.TabIndex = 21;
            this.editBTN.Text = "Edit";
            this.editBTN.UseVisualStyleBackColor = false;
            this.editBTN.Click += new System.EventHandler(this.editBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(54, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 142);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // AdminInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BorrowingSystemV2.Properties.Resources.Admin_invenotry__1_;
            this.ClientSize = new System.Drawing.Size(1532, 650);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.editBTN);
            this.Controls.Add(this.doneBTN);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.insertimageBTN);
            this.Controls.Add(this.createBTN);
            this.Controls.Add(this.adminInventoryData);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.searchData);
            this.Controls.Add(this.quantityTxtbx);
            this.Controls.Add(this.conditionTxtbx);
            this.Controls.Add(this.equipmentDescriptionTxtbx);
            this.Controls.Add(this.equipmentNameTxtbx);
            this.Controls.Add(this.equipmentIDTxtbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminInventory";
            this.Text = "AdminInventory";
            this.Load += new System.EventHandler(this.AdminInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminInventoryData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView adminInventoryData;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn condition_;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.TextBox searchData;
        private System.Windows.Forms.TextBox quantityTxtbx;
        private System.Windows.Forms.TextBox conditionTxtbx;
        private System.Windows.Forms.TextBox equipmentDescriptionTxtbx;
        private System.Windows.Forms.TextBox equipmentNameTxtbx;
        private System.Windows.Forms.TextBox equipmentIDTxtbx;
        private System.Windows.Forms.Button createBTN;
        private System.Windows.Forms.Button insertimageBTN;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button doneBTN;
        private System.Windows.Forms.Button editBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}