using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorrowingSystemV2
{
    public partial class AddNotes : Form
    {
        public static string Notes { get; set; }
        public static string Quantity { get; set; }

        public AddNotes()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            notesTxt.Clear();
            quantityTxt.Value = 0;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (quantityTxt.Value == 0)
            {   
                MessageBox.Show("Please input a value more than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (notesTxt.Text == "")
                {
                    if (MessageBox.Show("You have not added a note. Do you want to proceed?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Notes = "No Notes Added";
                        Quantity = quantityTxt.Value.ToString();
                        this.Hide();
                    }
                }
                else
                { 
                    if (MessageBox.Show("Are you sure you want to submit this note?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Notes = notesTxt.Text;
                        Quantity = quantityTxt.Value.ToString();
                        this.Hide();
                    }
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
