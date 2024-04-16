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
                MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee_staff WHERE staffID = @staffID", connection);
                cmd.Parameters.AddWithValue("@staffID", employeeIDTxtbx);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    employeeIDTxtbx.Text = reader["staffID"].ToString();
                    firstnameTxtbx.Text = reader["firstname"].ToString();
                    lastnameTxtbx.Text = reader["lastname"].ToString();
                    positionTxtbx.Text = reader["position"].ToString();
                    usernameTxtbx.Text = reader["username"].ToString();
                    passwordTxtbx.Text = reader["password_"].ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void logBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            StaffForm staffForm = (StaffForm)Application.OpenForms["StaffForm"];
            staffForm.Close();
        }
    }
}
