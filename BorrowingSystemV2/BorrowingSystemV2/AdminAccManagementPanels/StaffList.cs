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

namespace BorrowingSystemV2.AdminAccManagementPanels
{
    public partial class StaffList : UserControl
    {
        public string mySqlServerName = "sql6.freemysqlhosting.net";
        public string mySqlServerUserId = "sql6696982";
        public string mySqlServerPassword = "DJyeU2QQMU";
        public string mySqlDatabaseName = "sql6696982";
        public StaffList()
        {
            InitializeComponent();
        }
        public void UpdateStaffInfo()
        {
            staffIDTxtbx.Text = AdminAccountManangement.staffID;
            firstnameTxtbx.Text = AdminAccountManangement.staffFName;
            lastnameTxtbx.Text = AdminAccountManangement.staffLName;
            usernameTxtbx.Text = AdminAccountManangement.staffUserName;
            passwordTxtbx.Text = AdminAccountManangement.staffPassword;
            positionTxtbx.Text = AdminAccountManangement.staffPosition;

        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    MySqlConnection connection = new MySqlConnection($"datasource={mySqlServerName};port=3306;username={mySqlServerUserId};password={mySqlServerPassword};database={mySqlDatabaseName}");
                    connection.Open();
                    string query = "DELETE FROM sql6696982.employee_staff WHERE staffID = @staffID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@staffID", staffIDTxtbx.Text);
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
                string query = "UPDATE sql6696982.employee_staff SET firstname = @staffFName, lastname = @staffLName, username = @staffUserName, password_ = @staffPassword, position = @staffPosition WHERE staffID = @staffID";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@staffFName", firstnameTxtbx.Text);
                command.Parameters.AddWithValue("@staffLName", lastnameTxtbx.Text);
                command.Parameters.AddWithValue("@staffUserName", usernameTxtbx.Text);
                command.Parameters.AddWithValue("@staffPassword", passwordTxtbx.Text);
                command.Parameters.AddWithValue("@staffPosition", positionTxtbx.Text);
                command.Parameters.AddWithValue("@staffID", staffIDTxtbx.Text);
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
                if (staffIDTxtbx.Text == "" || firstnameTxtbx.Text == "" || lastnameTxtbx.Text =="" || usernameTxtbx.Text =="" || passwordTxtbx.Text==""|| positionTxtbx.Text == "")
                {
                    MessageBox.Show("Please provide all necessary information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MySqlConnection connection = new MySqlConnection($"datasource={mySqlServerName};port=3306;username={mySqlServerUserId};password={mySqlServerPassword};database={mySqlDatabaseName}");
                connection.Open();
                string query = "INSERT into sql6696982.employee_staff (staffID, firstname, lastname, username, password_, position) VALUES (@staffID, @staffFName, @staffLName, @staffUserName, @staffPassword, @staffPosition)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@staffID", staffIDTxtbx.Text); ;
                command.Parameters.AddWithValue("@staffFName", firstnameTxtbx.Text);
                command.Parameters.AddWithValue("@staffLName", lastnameTxtbx.Text);
                command.Parameters.AddWithValue("@staffUserName", usernameTxtbx.Text);
                command.Parameters.AddWithValue("@staffPassword", passwordTxtbx.Text);
                command.Parameters.AddWithValue("@staffPosition", positionTxtbx.Text);

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
