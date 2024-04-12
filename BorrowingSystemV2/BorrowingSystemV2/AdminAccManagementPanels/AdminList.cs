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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BorrowingSystemV2.AdminAccManagementPanels
{
    public partial class AdminList : UserControl
    {
        public string mySqlServerName = "sql6.freemysqlhosting.net";
        public string mySqlServerUserId = "sql6696982";
        public string mySqlServerPassword = "DJyeU2QQMU";
        public string mySqlDatabaseName = "sql6696982";
        public AdminList()
        {
            InitializeComponent();
        }

        private void AdminList_Load(object sender, EventArgs e)
        {

        }
        public void UpdateAdminInfo()
        {
            adminIDTxtbx.Text = AdminAccountManangement.adminID;
            AfirstnameTxtbx.Text = AdminAccountManangement.adminFName;
            AlastnameTxtbx.Text = AdminAccountManangement.adminLName;
            AusernameTxtbx.Text = AdminAccountManangement.adminUserName;
            ApasswordTxtbx.Text = AdminAccountManangement.adminPassword;
            ApositionTxtbx.Text = AdminAccountManangement.adminPosition; 
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection($"datasource={mySqlServerName};port=3306;username={mySqlServerUserId};password={mySqlServerPassword};database={mySqlDatabaseName}");
            conn.Open();
            string queryCheck = "SELECT * FROM sql6696982.employee_admin WHERE adminID = @admin_ID";
            MySqlCommand commandCheck = new MySqlCommand(queryCheck, conn);
            commandCheck.Parameters.AddWithValue("@admin_ID", adminIDTxtbx.Text);
            MySqlDataAdapter adapter = new MySqlDataAdapter(commandCheck);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (adminIDTxtbx.Text == "" || AfirstnameTxtbx.Text == "" || AlastnameTxtbx.Text == "" || AusernameTxtbx.Text == "" || ApasswordTxtbx.Text == "" || ApositionTxtbx.Text == "")
            {
                MessageBox.Show("Please provide all necessary information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Admin ID does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    MySqlConnection connection = new MySqlConnection($"datasource={mySqlServerName};port=3306;username={mySqlServerUserId};password={mySqlServerPassword};database={mySqlDatabaseName}");
                    connection.Open();
                    string query = "DELETE FROM employee_admin WHERE adminID = @adminID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@adminID", adminIDTxtbx.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Admin information deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    adminIDTxtbx.Text = "";
                    AfirstnameTxtbx.Text = "";
                    AlastnameTxtbx.Text = "";
                    AusernameTxtbx.Text = "";
                    ApasswordTxtbx.Text = "";
                    ApositionTxtbx.SelectedIndex = -1;
                    AdminAccountManangement.instance.refreshData();

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
                MySqlConnection conn = new MySqlConnection($"datasource={mySqlServerName};port=3306;username={mySqlServerUserId};password={mySqlServerPassword};database={mySqlDatabaseName}");
                conn.Open();
                string queryCheck = "SELECT * FROM sql6696982.employee_admin WHERE adminID = @admin_ID";
                MySqlCommand commandCheck = new MySqlCommand(queryCheck, conn);
                commandCheck.Parameters.AddWithValue("@admin_ID", adminIDTxtbx.Text);
                MySqlDataAdapter adapter = new MySqlDataAdapter(commandCheck);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (adminIDTxtbx.Text == "" || AfirstnameTxtbx.Text == "" || AlastnameTxtbx.Text == "" || AusernameTxtbx.Text == "" || ApasswordTxtbx.Text == "" || ApositionTxtbx.Text == "")
                {
                    MessageBox.Show("Please provide all necessary information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Admin ID does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to update this record?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    MySqlConnection connection = new MySqlConnection($"datasource={mySqlServerName};port=3306;username={mySqlServerUserId};password={mySqlServerPassword};database={mySqlDatabaseName}");
                    connection.Open();
                    string query = "UPDATE sql6696982.employee_admin SET firstname = @adminFName, lastname = @adminLName, username = @adminUserName, password_ = @adminPassword, position = @adminPosition WHERE adminID = @adminID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@adminFName", AfirstnameTxtbx.Text);
                    command.Parameters.AddWithValue("@adminLName", AlastnameTxtbx.Text);
                    command.Parameters.AddWithValue("@adminUserName", AusernameTxtbx.Text);
                    command.Parameters.AddWithValue("@adminPassword", ApasswordTxtbx.Text);
                    command.Parameters.AddWithValue("@adminPosition", ApositionTxtbx.Text);
                    command.Parameters.AddWithValue("@adminID", adminIDTxtbx.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Admin information updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    adminIDTxtbx.Text = "";
                    AfirstnameTxtbx.Text = "";
                    AlastnameTxtbx.Text = "";
                    AusernameTxtbx.Text = "";
                    ApasswordTxtbx.Text = "";
                    ApositionTxtbx.SelectedIndex = -1;
                    AdminAccountManangement.instance.refreshData();
                }

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
                if (adminIDTxtbx.Text == "" || AfirstnameTxtbx.Text == "" || AlastnameTxtbx.Text == "" || AusernameTxtbx.Text == "" || ApasswordTxtbx.Text == "" || ApositionTxtbx.Text == "")
                {
                    MessageBox.Show("Please provide all necessary information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MySqlConnection conn = new MySqlConnection($"datasource={mySqlServerName};port=3306;username={mySqlServerUserId};password={mySqlServerPassword};database={mySqlDatabaseName}");
                conn.Open();
                string queryCheck = "SELECT * FROM sql6696982.employee_admin WHERE adminID = @admin_ID";
                MySqlCommand commandCheck = new MySqlCommand(queryCheck, conn);
                commandCheck.Parameters.AddWithValue("@admin_ID", adminIDTxtbx.Text);
                MySqlDataAdapter adapter = new MySqlDataAdapter(commandCheck);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Admin ID already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to create this account?", "Create Account", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    { 
                        MySqlConnection connection = new MySqlConnection($"datasource={mySqlServerName};port=3306;username={mySqlServerUserId};password={mySqlServerPassword};database={mySqlDatabaseName}");
                        connection.Open();
                        string query = "INSERT into sql6696982.employee_admin (adminID, firstname, lastname, username, password_, position) VALUES (@adminID, @adminFName, @adminLName, @adminUserName, @adminPassword, @adminPosition)";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@adminID", adminIDTxtbx.Text); ;
                        command.Parameters.AddWithValue("@adminFName", AfirstnameTxtbx.Text);
                        command.Parameters.AddWithValue("@adminLName", AlastnameTxtbx.Text);
                        command.Parameters.AddWithValue("@adminUserName", AusernameTxtbx.Text);
                        command.Parameters.AddWithValue("@adminPassword", ApasswordTxtbx.Text);
                        command.Parameters.AddWithValue("@adminPosition", ApositionTxtbx.Text);

                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            adminIDTxtbx.Text = "";
                            AfirstnameTxtbx.Text = "";
                            AlastnameTxtbx.Text = "";
                            AusernameTxtbx.Text = "";
                            ApasswordTxtbx.Text = "";
                            ApositionTxtbx.SelectedIndex = -1;
                            AdminAccountManangement.instance.refreshData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to create account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
