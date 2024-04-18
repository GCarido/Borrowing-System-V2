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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.adminInventoryData = new System.Windows.Forms.DataGridView();
            this.equipmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condition_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.equipmentImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.adminInventoryData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // adminInventoryData
            // 
            this.adminInventoryData.AllowUserToAddRows = false;
            this.adminInventoryData.AllowUserToDeleteRows = false;
            this.adminInventoryData.AllowUserToResizeColumns = false;
            this.adminInventoryData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminInventoryData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.adminInventoryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminInventoryData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipmentID,
            this.equipmentName,
            this.equipmentDescription,
            this.quantity,
            this.condition_,
            this.image});
            this.adminInventoryData.Location = new System.Drawing.Point(545, 114);
            this.adminInventoryData.Name = "adminInventoryData";
            this.adminInventoryData.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 15F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminInventoryData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.adminInventoryData.RowHeadersVisible = false;
            this.adminInventoryData.Size = new System.Drawing.Size(881, 457);
            this.adminInventoryData.TabIndex = 15;
            this.adminInventoryData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminInventoryData_CellClick);
            // 
            // equipmentID
            // 
            this.equipmentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.equipmentID.DataPropertyName = "equipmentID";
            this.equipmentID.FillWeight = 66.29907F;
            this.equipmentID.HeaderText = "Equipment ID";
            this.equipmentID.Name = "equipmentID";
            this.equipmentID.ReadOnly = true;
            // 
            // equipmentName
            // 
            this.equipmentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.equipmentName.DataPropertyName = "equipmentName";
            this.equipmentName.FillWeight = 111.2814F;
            this.equipmentName.HeaderText = "Equipment Name";
            this.equipmentName.Name = "equipmentName";
            this.equipmentName.ReadOnly = true;
            // 
            // equipmentDescription
            // 
            this.equipmentDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.equipmentDescription.DataPropertyName = "equipmentDescription";
            this.equipmentDescription.FillWeight = 201.4457F;
            this.equipmentDescription.HeaderText = "Equipment Description";
            this.equipmentDescription.Name = "equipmentDescription";
            this.equipmentDescription.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantity.DataPropertyName = "quantity";
            this.quantity.FillWeight = 54.09601F;
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // condition_
            // 
            this.condition_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.condition_.DataPropertyName = "condition_";
            this.condition_.FillWeight = 60.9137F;
            this.condition_.HeaderText = "Condition";
            this.condition_.Name = "condition_";
            this.condition_.ReadOnly = true;
            // 
            // image
            // 
            this.image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.image.DataPropertyName = "image";
            this.image.FillWeight = 105.964F;
            this.image.HeaderText = "Image";
            this.image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.image.Name = "image";
            this.image.ReadOnly = true;
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
            this.searchData.TextChanged += new System.EventHandler(this.searchData_TextChanged);
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
            this.createBTN.Click += new System.EventHandler(this.createBTN_Click);
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
            this.insertimageBTN.Click += new System.EventHandler(this.insertimageBTN_Click);
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
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
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
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
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
            // equipmentImage
            // 
            this.equipmentImage.BackColor = System.Drawing.Color.Transparent;
            this.equipmentImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.equipmentImage.Location = new System.Drawing.Point(54, 34);
            this.equipmentImage.Name = "equipmentImage";
            this.equipmentImage.Size = new System.Drawing.Size(364, 153);
            this.equipmentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.equipmentImage.TabIndex = 22;
            this.equipmentImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // AdminInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BorrowingSystemV2.Properties.Resources.Admin_invenotry__1_;
            this.ClientSize = new System.Drawing.Size(1532, 650);
            this.Controls.Add(this.equipmentImage);
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
            ((System.ComponentModel.ISupportInitialize)(this.equipmentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView adminInventoryData;
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
        private System.Windows.Forms.PictureBox equipmentImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn condition_;
        private System.Windows.Forms.DataGridViewImageColumn image;
    }
}