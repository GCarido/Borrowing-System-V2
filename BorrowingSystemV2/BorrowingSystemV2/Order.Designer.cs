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
            this.quantityTxtbx = new System.Windows.Forms.TextBox();
            this.equipmentNameTxtbx = new System.Windows.Forms.TextBox();
            this.instructorNameTxtbx = new System.Windows.Forms.TextBox();
            this.subjectCodeTxtbx = new System.Windows.Forms.TextBox();
            this.yearTxtbx = new System.Windows.Forms.TextBox();
            this.courseTxtbx = new System.Windows.Forms.TextBox();
            this.studentNameTxtbx = new System.Windows.Forms.TextBox();
            this.studentIDTxtbx = new System.Windows.Forms.TextBox();
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
            this.clearpanel.Controls.Add(this.quantityTxtbx);
            this.clearpanel.Controls.Add(this.equipmentNameTxtbx);
            this.clearpanel.Controls.Add(this.instructorNameTxtbx);
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
            // quantityTxtbx
            // 
            this.quantityTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTxtbx.Location = new System.Drawing.Point(473, 380);
            this.quantityTxtbx.Multiline = true;
            this.quantityTxtbx.Name = "quantityTxtbx";
            this.quantityTxtbx.Size = new System.Drawing.Size(290, 36);
            this.quantityTxtbx.TabIndex = 17;
            // 
            // equipmentNameTxtbx
            // 
            this.equipmentNameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.equipmentNameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentNameTxtbx.Location = new System.Drawing.Point(473, 283);
            this.equipmentNameTxtbx.Multiline = true;
            this.equipmentNameTxtbx.Name = "equipmentNameTxtbx";
            this.equipmentNameTxtbx.Size = new System.Drawing.Size(290, 36);
            this.equipmentNameTxtbx.TabIndex = 16;
            // 
            // instructorNameTxtbx
            // 
            this.instructorNameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instructorNameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorNameTxtbx.Location = new System.Drawing.Point(473, 186);
            this.instructorNameTxtbx.Multiline = true;
            this.instructorNameTxtbx.Name = "instructorNameTxtbx";
            this.instructorNameTxtbx.Size = new System.Drawing.Size(290, 36);
            this.instructorNameTxtbx.TabIndex = 15;
            // 
            // subjectCodeTxtbx
            // 
            this.subjectCodeTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subjectCodeTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectCodeTxtbx.Location = new System.Drawing.Point(473, 89);
            this.subjectCodeTxtbx.Multiline = true;
            this.subjectCodeTxtbx.Name = "subjectCodeTxtbx";
            this.subjectCodeTxtbx.Size = new System.Drawing.Size(290, 36);
            this.subjectCodeTxtbx.TabIndex = 14;
            // 
            // yearTxtbx
            // 
            this.yearTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearTxtbx.Location = new System.Drawing.Point(71, 380);
            this.yearTxtbx.Multiline = true;
            this.yearTxtbx.Name = "yearTxtbx";
            this.yearTxtbx.Size = new System.Drawing.Size(290, 36);
            this.yearTxtbx.TabIndex = 13;
            // 
            // courseTxtbx
            // 
            this.courseTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTxtbx.Location = new System.Drawing.Point(71, 283);
            this.courseTxtbx.Multiline = true;
            this.courseTxtbx.Name = "courseTxtbx";
            this.courseTxtbx.Size = new System.Drawing.Size(290, 36);
            this.courseTxtbx.TabIndex = 12;
            // 
            // studentNameTxtbx
            // 
            this.studentNameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentNameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameTxtbx.Location = new System.Drawing.Point(71, 186);
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
            this.studentIDTxtbx.Location = new System.Drawing.Point(71, 89);
            this.studentIDTxtbx.Multiline = true;
            this.studentIDTxtbx.Name = "studentIDTxtbx";
            this.studentIDTxtbx.Size = new System.Drawing.Size(290, 36);
            this.studentIDTxtbx.TabIndex = 10;
            this.studentIDTxtbx.TextChanged += new System.EventHandler(this.studentIDTxtbx_TextChanged);
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
            this.clearpanel.ResumeLayout(false);
            this.clearpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clearOrderBTN;
        private System.Windows.Forms.Button submitOrderBTN;
        private System.Windows.Forms.Panel clearpanel;
        private System.Windows.Forms.TextBox quantityTxtbx;
        private System.Windows.Forms.TextBox equipmentNameTxtbx;
        private System.Windows.Forms.TextBox instructorNameTxtbx;
        private System.Windows.Forms.TextBox subjectCodeTxtbx;
        private System.Windows.Forms.TextBox yearTxtbx;
        private System.Windows.Forms.TextBox courseTxtbx;
        private System.Windows.Forms.TextBox studentNameTxtbx;
        private System.Windows.Forms.TextBox studentIDTxtbx;
    }
}