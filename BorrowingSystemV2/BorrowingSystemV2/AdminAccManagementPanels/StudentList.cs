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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BorrowingSystemV2.AdminAccManagementPanels
{
    public partial class StudentList : UserControl
    {
        public string mySqlServerName = "sql6.freemysqlhosting.net";
        public string mySqlServerUserId = "sql6696982";
        public string mySqlServerPassword = "DJyeU2QQMU";
        public string mySqlDatabaseName = "sql6696982";

        public StudentList()
        {
            InitializeComponent();

        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            
        }

        public void UpdateStudentInfo()
        {
            studentIDTxtbx.Text = AdminAccountManangement.studentID;
            studentnameTxtbx.Text = AdminAccountManangement.studentName;
            courseTxtbx.Text = AdminAccountManangement.studentCourse;
            yearTxtbx.Text = AdminAccountManangement.studentYear;

        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    MySqlConnection connection = new MySqlConnection($"datasource={mySqlServerName};port=3306;username={mySqlServerUserId};password={mySqlServerPassword};database={mySqlDatabaseName}");
                    connection.Open();
                    string query = "DELETE FROM sql6696982.students WHERE studentID = @studentID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@studentID", studentIDTxtbx.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data has been deleted successfully.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection($"datasource={mySqlServerName};port=3306;username={mySqlServerUserId};password={mySqlServerPassword};database={mySqlDatabaseName}");
                connection.Open();
                string query = "UPDATE sql6696982.students SET  studentName = @studentName, course = @studentCourse, yearLevel = @studentYear WHERE studentID = @studentID";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@studentName", studentnameTxtbx.Text);
                command.Parameters.AddWithValue("@studentCourse", courseTxtbx.Text);
                command.Parameters.AddWithValue("@studentYear", yearTxtbx.Text);
                command.Parameters.AddWithValue("@studentID", studentIDTxtbx.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Data updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (studentIDTxtbx.Text == "" || studentnameTxtbx.Text == "" || courseTxtbx.Text == "" || yearTxtbx.Text == "")
                {
                    MessageBox.Show("Please provide all necessary information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MySqlConnection connection = new MySqlConnection($"datasource={mySqlServerName};port=3306;username={mySqlServerUserId};password={mySqlServerPassword};database={mySqlDatabaseName}");
                connection.Open();
                string query = "INSERT into sql6696982.students (studentID, studentName, course, yearLevel) VALUES (@studentID, @studentName, @studentCourse, @studentYear)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@studentName", studentnameTxtbx.Text);
                command.Parameters.AddWithValue("@studentCourse", courseTxtbx.Text);
                command.Parameters.AddWithValue("@studentYear", yearTxtbx.Text);
                command.Parameters.AddWithValue("@studentID", studentIDTxtbx.Text);

                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Account created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to create account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
