namespace BorrowingSystemV2
{
    partial class Order
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
            this.clearOrderBTN = new System.Windows.Forms.Button();
            this.submitOrderBTN = new System.Windows.Forms.Button();
            this.clearpanel = new System.Windows.Forms.Panel();
            this.availableLabel = new System.Windows.Forms.Label();
            this.equipmentName = new System.Windows.Forms.ComboBox();
            this.instructorName = new System.Windows.Forms.ComboBox();
            this.quantityTxtbx = new System.Windows.Forms.TextBox();
            this.subjectCodeTxtbx = new System.Windows.Forms.TextBox();
            this.yearTxtbx = new System.Windows.Forms.TextBox();
            this.courseTxtbx = new System.Windows.Forms.TextBox();
            this.studentNameTxtbx = new System.Windows.Forms.TextBox();
            this.studentIDTxtbx = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.clearpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearOrderBTN
            // 
            this.clearOrderBTN.FlatAppearance.BorderSize = 0;
            this.clearOrderBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(168)))), ((int)(((byte)(115)))));
            this.clearOrderBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(168)))), ((int)(((byte)(115)))));
            this.clearOrderBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearOrderBTN.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold);
            this.clearOrderBTN.Location = new System.Drawing.Point(909, 502);
            this.clearOrderBTN.Name = "clearOrderBTN";
            this.clearOrderBTN.Size = new System.Drawing.Size(168, 54);
            this.clearOrderBTN.TabIndex = 2;
            this.clearOrderBTN.Text = "Clear";
            this.clearOrderBTN.UseVisualStyleBackColor = true;
            this.clearOrderBTN.Click += new System.EventHandler(this.clearOrderBTN_Click);
            // 
            // submitOrderBTN
            // 
            this.submitOrderBTN.FlatAppearance.BorderSize = 0;
            this.submitOrderBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(168)))), ((int)(((byte)(115)))));
            this.submitOrderBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(168)))), ((int)(((byte)(115)))));
            this.submitOrderBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitOrderBTN.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold);
            this.submitOrderBTN.Location = new System.Drawing.Point(1128, 502);
            this.submitOrderBTN.Name = "submitOrderBTN";
            this.submitOrderBTN.Size = new System.Drawing.Size(168, 54);
            this.submitOrderBTN.TabIndex = 0;
            this.submitOrderBTN.Text = "Submit";
            this.submitOrderBTN.UseVisualStyleBackColor = true;
            this.submitOrderBTN.Click += new System.EventHandler(this.submitOrderBTN_Click);
            // 
            // clearpanel
            // 
            this.clearpanel.BackColor = System.Drawing.Color.Transparent;
            this.clearpanel.Controls.Add(this.quantityLabel);
            this.clearpanel.Controls.Add(this.availableLabel);
            this.clearpanel.Controls.Add(this.equipmentName);
            this.clearpanel.Controls.Add(this.instructorName);
            this.clearpanel.Controls.Add(this.quantityTxtbx);
            this.clearpanel.Controls.Add(this.subjectCodeTxtbx);
            this.clearpanel.Controls.Add(this.yearTxtbx);
            this.clearpanel.Controls.Add(this.courseTxtbx);
            this.clearpanel.Controls.Add(this.studentNameTxtbx);
            this.clearpanel.Controls.Add(this.studentIDTxtbx);
            this.clearpanel.Location = new System.Drawing.Point(682, 26);
            this.clearpanel.Name = "clearpanel";
            this.clearpanel.Size = new System.Drawing.Size(813, 582);
            this.clearpanel.TabIndex = 1;
            // 
            // availableLabel
            // 
            this.availableLabel.AutoSize = true;
            this.availableLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableLabel.ForeColor = System.Drawing.Color.Blue;
            this.availableLabel.Location = new System.Drawing.Point(715, 438);
            this.availableLabel.Name = "availableLabel";
            this.availableLabel.Size = new System.Drawing.Size(106, 17);
            this.availableLabel.TabIndex = 19;
            this.availableLabel.Text = "{availableLabel}";
            // 
            // equipmentName
            // 
            this.equipmentName.BackColor = System.Drawing.Color.White;
            this.equipmentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmentName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equipmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.equipmentName.FormattingEnabled = true;
            this.equipmentName.ItemHeight = 24;
            this.equipmentName.Location = new System.Drawing.Point(467, 285);
            this.equipmentName.Name = "equipmentName";
            this.equipmentName.Size = new System.Drawing.Size(300, 32);
            this.equipmentName.TabIndex = 18;
            this.equipmentName.SelectedIndexChanged += new System.EventHandler(this.equipmentName_SelectedIndexChanged);
            // 
            // instructorName
            // 
            this.instructorName.BackColor = System.Drawing.Color.White;
            this.instructorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instructorName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.instructorName.FormattingEnabled = true;
            this.instructorName.ItemHeight = 24;
            this.instructorName.Items.AddRange(new object[] {
            "Engr. Roel B. Lauron",
            "Engr. Johnalyn Figueras",
            "Engr. Jundith D. Alterado",
            "Engr. Stephanie Grace F. Villarubia",
            "Engr. Julian N. Semblante",
            "Engr. Mervin Tampus",
            "Engr. Nikko D Alferez",
            "Engr. Nash Uriel A. Tapayan"});
            this.instructorName.Location = new System.Drawing.Point(467, 187);
            this.instructorName.Name = "instructorName";
            this.instructorName.Size = new System.Drawing.Size(300, 32);
            this.instructorName.TabIndex = 3;
            // 
            // quantityTxtbx
            // 
            this.quantityTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTxtbx.Location = new System.Drawing.Point(473, 381);
            this.quantityTxtbx.Multiline = true;
            this.quantityTxtbx.Name = "quantityTxtbx";
            this.quantityTxtbx.Size = new System.Drawing.Size(290, 36);
            this.quantityTxtbx.TabIndex = 17;
            // 
            // subjectCodeTxtbx
            // 
            this.subjectCodeTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subjectCodeTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectCodeTxtbx.Location = new System.Drawing.Point(473, 90);
            this.subjectCodeTxtbx.Multiline = true;
            this.subjectCodeTxtbx.Name = "subjectCodeTxtbx";
            this.subjectCodeTxtbx.Size = new System.Drawing.Size(290, 36);
            this.subjectCodeTxtbx.TabIndex = 14;
            // 
            // yearTxtbx
            // 
            this.yearTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearTxtbx.Location = new System.Drawing.Point(71, 381);
            this.yearTxtbx.Multiline = true;
            this.yearTxtbx.Name = "yearTxtbx";
            this.yearTxtbx.Size = new System.Drawing.Size(290, 36);
            this.yearTxtbx.TabIndex = 13;
            // 
            // courseTxtbx
            // 
            this.courseTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTxtbx.Location = new System.Drawing.Point(71, 284);
            this.courseTxtbx.Multiline = true;
            this.courseTxtbx.Name = "courseTxtbx";
            this.courseTxtbx.Size = new System.Drawing.Size(290, 36);
            this.courseTxtbx.TabIndex = 12;
            // 
            // studentNameTxtbx
            // 
            this.studentNameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentNameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameTxtbx.Location = new System.Drawing.Point(71, 187);
            this.studentNameTxtbx.Multiline = true;
            this.studentNameTxtbx.Name = "studentNameTxtbx";
            this.studentNameTxtbx.Size = new System.Drawing.Size(290, 36);
            this.studentNameTxtbx.TabIndex = 11;
            // 
            // studentIDTxtbx
            // 
            this.studentIDTxtbx.BackColor = System.Drawing.Color.White;
            this.studentIDTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentIDTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDTxtbx.Location = new System.Drawing.Point(71, 91);
            this.studentIDTxtbx.Multiline = true;
            this.studentIDTxtbx.Name = "studentIDTxtbx";
            this.studentIDTxtbx.Size = new System.Drawing.Size(290, 36);
            this.studentIDTxtbx.TabIndex = 10;
            this.studentIDTxtbx.TextChanged += new System.EventHandler(this.studentIDTxtbx_TextChanged);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.quantityLabel.Location = new System.Drawing.Point(464, 438);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(254, 17);
            this.quantityLabel.TabIndex = 20;
            this.quantityLabel.Text = "The available quantity of the equipment is:";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BorrowingSystemV2.Properties.Resources.orderform3;
            this.ClientSize = new System.Drawing.Size(1532, 650);
            this.Controls.Add(this.submitOrderBTN);
            this.Controls.Add(this.clearOrderBTN);
            this.Controls.Add(this.clearpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.clearpanel.ResumeLayout(false);
            this.clearpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clearOrderBTN;
        private System.Windows.Forms.Button submitOrderBTN;
        private System.Windows.Forms.Panel clearpanel;
        private System.Windows.Forms.TextBox quantityTxtbx;
        private System.Windows.Forms.TextBox subjectCodeTxtbx;
        private System.Windows.Forms.TextBox yearTxtbx;
        private System.Windows.Forms.TextBox courseTxtbx;
        private System.Windows.Forms.TextBox studentNameTxtbx;
        private System.Windows.Forms.TextBox studentIDTxtbx;
        private System.Windows.Forms.ComboBox instructorName;
        private System.Windows.Forms.ComboBox equipmentName;
        private System.Windows.Forms.Label availableLabel;
        private System.Windows.Forms.Label quantityLabel;
    }
}