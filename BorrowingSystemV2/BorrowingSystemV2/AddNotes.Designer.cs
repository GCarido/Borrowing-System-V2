namespace BorrowingSystemV2
{
    partial class AddNotes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.notesTxt = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.quantityTxt = new System.Windows.Forms.NumericUpDown();
            this.clearBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Additional Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input Quantity to Return";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Add Notes";
            // 
            // notesTxt
            // 
            this.notesTxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTxt.Location = new System.Drawing.Point(12, 271);
            this.notesTxt.MaxLength = 255;
            this.notesTxt.Multiline = true;
            this.notesTxt.Name = "notesTxt";
            this.notesTxt.Size = new System.Drawing.Size(352, 127);
            this.notesTxt.TabIndex = 4;
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.SystemColors.Control;
            this.submitBtn.FlatAppearance.BorderSize = 0;
            this.submitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(168)))), ((int)(((byte)(115)))));
            this.submitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(168)))), ((int)(((byte)(115)))));
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(12, 442);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(107, 43);
            this.submitBtn.TabIndex = 5;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(199)))), ((int)(((byte)(137)))));
            this.panel1.Controls.Add(this.quantityTxt);
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.notesTxt);
            this.panel1.Controls.Add(this.submitBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 521);
            this.panel1.TabIndex = 6;
            // 
            // quantityTxt
            // 
            this.quantityTxt.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.quantityTxt.Location = new System.Drawing.Point(12, 165);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(120, 35);
            this.quantityTxt.TabIndex = 7;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.Control;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(168)))), ((int)(((byte)(115)))));
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(168)))), ((int)(((byte)(115)))));
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(133, 442);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(107, 43);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // AddNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(380, 521);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNotes";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNotes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTxt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox notesTxt;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.NumericUpDown quantityTxt;
    }
}