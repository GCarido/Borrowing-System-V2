using MySql.Data.MySqlClient;
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
    public partial class Order : Form
    {
        public string mySqlServerName = "sql6.freemysqlhosting.net";
        public string mySqlServerUserId = "sql6696982";
        public string mySqlServerPassword = "DJyeU2QQMU";
        public string mySqlDatabaseName = "sql6696982";

        public Order()
        {
            InitializeComponent();
        }

        public bool CheckTextboxes()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    if (string.IsNullOrEmpty(((TextBox)control).Text))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void submitOrderBTN_Click(object sender, EventArgs e)
        {
            if (studentIDTxtbx.Text != "")
            {
                MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");

                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT studentName, course, yearLevel FROM sql6696982.students where studentId = @studentID", connection);
                cmd.Parameters.AddWithValue("@studentID", (studentIDTxtbx.Text));
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    studentNameTxtbx.Text = reader["studentName"].ToString();
                    courseTxtbx.Text = reader["course"].ToString();
                    yearTxtbx.Text = reader["yearLevel"].ToString();
                }
                else
                {
                    MessageBox.Show("No student found with the given id");
                }

                reader.Close();
                connection.Close();
            }

            if(subjectCodeTxtbx.Text =="" || instructorNameTxtbx.Text == "" || equipmentNameTxtbx.Text == "" || quantityTxtbx.Text == "" )
            {
                MessageBox.Show("Please provide all necessary information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Are you sure you want to borrow this equipment?", "Borrow Equipment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO sql6696982.orders(student_ID, subject_code, equipment_ID, staff_ID, order_DATE, order_TIME)" +
                   "VALUES(studentID, @subject_code, @equipment_ID, @staff_ID, @order_DATE, @rder_TIME");

                if (!CheckTextboxes())
                {
                    MessageBox.Show("Please fill-in all required info!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime order_DATE = DateTime.Now;
                DateTime order_TIME = DateTime.Now;
                cmd.Parameters.AddWithValue("@studentID", studentIDTxtbx.Text);
                cmd.Parameters.AddWithValue("@@subject_code", subjectCodeTxtbx.Text);
                //cmd.Parameters.AddWithValue("",instructorNameTxtbx.Text);
               // cmd.Parameters.AddWithValue("",equipmentNameTxtbx.Text);
                cmd.Parameters.AddWithValue("",quantityTxtbx.Text);
                    
                cmd.Parameters.AddWithValue("@borrowed_date", order_DATE.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@borrowed_time", order_TIME.ToString("hh:mm:ss:tt"));

                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Successfully Borrowed Equipment!", "Borrowed Equipment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data Not Inserted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                    foreach (Control c in clearpanel.Controls)
                    {
                        if (c is TextBox)
                        {
                            ((TextBox)c).Clear();
                        }

                    }
                }
            }
        }

        private void clearOrderBTN_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure you want to clear all fields?", "Clear Fields", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (Control c in clearpanel.Controls)
                    {
                        if (c is TextBox)
                        {
                            ((TextBox)c).Clear();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void studentIDTxtbx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
