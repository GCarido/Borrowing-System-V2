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
    public partial class Settings : Form
    {
        public string mySqlServerName = "sql6.freemysqlhosting.net";
        public string mySqlServerUserId = "sql6696982";
        public string mySqlServerPassword = "DJyeU2QQMU";
        public string mySqlDatabaseName = "sql6696982";
        public Settings()
        {
            InitializeComponent();
           
        }


        private void Settings_Load(object sender, EventArgs e)
        {
            AccountInfo();
        }

        public void AccountInfo()
        {
            try
            {
                if(StaffLogin.Position == "Staff")
                {
                    positioncmbx.Enabled = false;
                    MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee_staff WHERE staffID = @staffID", connection);
                    cmd.Parameters.AddWithValue("@staffID", StaffLogin.EmployeeID);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        employeeIDTxtbx.Text = reader["staffID"].ToString();
                        firstnameTxtbx.Text = reader["firstname"].ToString();
                        lastnameTxtbx.Text = reader["lastname"].ToString();
                        positioncmbx.Text = reader["position"].ToString();
                        usernameTxtbx.Text = reader["username"].ToString();
                        passwordTxtbx.Text = reader["password_"].ToString();
                    }
                    connection.Close();
                }
                else
                {
                    MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee_admin WHERE adminID = @adminID", connection);
                    cmd.Parameters.AddWithValue("@adminID", AdminLogin.EmployeeID);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        employeeIDTxtbx.Text = reader["adminID"].ToString();
                        firstnameTxtbx.Text = reader["firstname"].ToString();
                        lastnameTxtbx.Text = reader["lastname"].ToString();
                        positioncmbx.Text = reader["position"].ToString();
                        usernameTxtbx.Text = reader["username"].ToString();
                        passwordTxtbx.Text = reader["password_"].ToString();
                    }
                    connection.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void logBTN_Click(object sender, EventArgs e)
        {
            if(StaffLogin.Position == "Staff")
            {
                this.Close();
                LoginPage loginPage = new LoginPage();
                loginPage.Show();
                StaffForm staffForm = (StaffForm)Application.OpenForms["StaffForm"];
                staffForm.Close();
            }
            else
            {
                this.Close();
                LoginPage loginPage = new LoginPage();
                loginPage.Show();
                AdminForm adminForm = (AdminForm)Application.OpenForms["AdminForm"];
                adminForm.Close();
            }
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Are you sure you want to edit your information?", "Edit Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(StaffLogin.Position == "Staff")
                {
                    updateStaff();
                }
                else
                {
                    updateAdmin();
                }
            }
        }

        public void updateStaff()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE employee_staff SET firstname = @firstname, lastname = @lastname, username = @username, password_ = @password WHERE staffID = @staffID", connection);
                cmd.Parameters.AddWithValue("@staffID", employeeIDTxtbx.Text);
                cmd.Parameters.AddWithValue("@firstname", firstnameTxtbx.Text);
                cmd.Parameters.AddWithValue("@lastname", lastnameTxtbx.Text);
                cmd.Parameters.AddWithValue("@username", usernameTxtbx.Text);
                cmd.Parameters.AddWithValue("@password", passwordTxtbx.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Information updated successfully!", "Information Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AccountInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void updateAdmin()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE employee_admin SET firstname = @firstname, lastname = @lastname, username = @username, password_ = @password WHERE adminID = @adminID", connection);
                cmd.Parameters.AddWithValue("@adminID", employeeIDTxtbx.Text);
                cmd.Parameters.AddWithValue("@firstname", firstnameTxtbx.Text);
                cmd.Parameters.AddWithValue("@lastname", lastnameTxtbx.Text);
                cmd.Parameters.AddWithValue("@username", usernameTxtbx.Text);
                cmd.Parameters.AddWithValue("@password", passwordTxtbx.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Information updated successfully!", "Information Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AccountInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
