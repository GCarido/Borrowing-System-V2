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
    public partial class Logs : Form
    {
        public string mySqlServerName = "sql6.freemysqlhosting.net";
        public string mySqlServerUserId = "sql6696982";
        public string mySqlServerPassword = "DJyeU2QQMU";
        public string mySqlDatabaseName = "sql6696982";

        public Logs()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
                connection.Open();
                if (StaffLogin.Position == "Staff")
                {
                    logsTable.Columns["fullName"].Visible = false;
                }

                string username = StaffLogin.Position == "Staff" ? StaffLogin.Username : AdminLogin.Username;
                string position = StaffLogin.Position == "Staff" ? StaffLogin.Position : AdminLogin.Position;

                MySqlCommand cmd;
                if (position == "Admin")
                {
                    cmd = new MySqlCommand("SELECT logs_.logID," +
                    "orders.orderID, students.studentName, orders.subject_code, inventory.equipmentName,  orders.quantity, " +
                    "CONCAT(IFNULL(employee_staff.firstname, ''), ' ', IFNULL(employee_staff.lastname, ''), '', IFNULL(employee_admin.firstname, ''), ' ', IFNULL(employee_admin.lastname, '')) AS fullName, " +
                    "orders.instructor_name, orders.order_DATE, orders.order_TIME, logs_.return_DATE, logs_.return_TIME, logs_.notes FROM logs_ " +
                    "INNER JOIN orders ON logs_.order_ID = orders.orderID " +
                    "LEFT JOIN employee_staff ON orders.staff_ID = employee_staff.staffID " +
                    "LEFT JOIN employee_admin ON orders.admin_ID = employee_admin.adminID " +
                    "INNER JOIN students ON orders.student_ID = students.studentID " +
                    "INNER JOIN inventory ON orders.equipment_ID = inventory.equipmentID", connection);
                }
                else
                {
                    cmd = new MySqlCommand("SELECT logs_.logID," +
                    "orders.orderID, students.studentName, orders.subject_code, orders.instructor_Name, " +
                    "inventory.equipmentName,  orders.quantity, " +
                    "orders.order_DATE, orders.order_TIME, logs_.return_DATE, logs_.return_TIME, logs_.notes FROM logs_ " +
                    "INNER JOIN orders ON logs_.order_ID = orders.orderID " +
                    "LEFT JOIN employee_staff ON orders.staff_ID = employee_staff.staffID " +
                    "INNER JOIN students ON orders.student_ID = students.studentID " +
                    "INNER JOIN inventory ON orders.equipment_ID = inventory.equipmentID " +
                    "WHERE employee_staff.username = @username OR employee_staff.username = @username", connection);

                    cmd.Parameters.AddWithValue("@username", username);
                }
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                logsTable.DataSource = dt;
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void StaffLogs_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            string Search = searchData.Text.ToString();
            searchDatas(Search);
        }
        public void searchDatas(string Search)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
                connection.Open();

                if (StaffLogin.Position == "Staff")
                {
                    logsTable.Columns["fullName"].Visible = false;
                }

                string username = StaffLogin.Position == "Staff" ? StaffLogin.Username : AdminLogin.Username;
                string position = StaffLogin.Position == "Staff" ? StaffLogin.Position : AdminLogin.Position;
                if(position == "Admin")
                {
                    string baseQuery = "SELECT logs_.logID, orders.orderID, students.studentName, " +
                    "orders.subject_code, inventory.equipmentName, orders.quantity, " +
                    "CONCAT(IFNULL(employee_staff.firstname, ''), ' ', IFNULL(employee_staff.lastname, ''), '', IFNULL(employee_admin.firstname, ''), ' ', IFNULL(employee_admin.lastname, '')) AS fullName, " +
                    "orders.instructor_name, " +
                    "orders.order_DATE, orders.order_TIME, logs_.return_DATE, logs_.return_TIME, " +
                    "logs_.notes FROM sql6696982.logs_ " +
                    "INNER JOIN orders ON logs_.order_ID = orders.orderID " +
                    "LEFT JOIN employee_staff ON orders.staff_ID = employee_staff.staffID " +
                    "LEFT JOIN employee_admin ON orders.admin_ID = employee_admin.adminID " +
                    "INNER JOIN students ON orders.student_ID = students.studentID " +
                    "INNER JOIN inventory ON orders.equipment_ID = inventory.equipmentID " +
                    "WHERE CONCAT(inventory.equipmentID, inventory.equipmentName, inventory.equipmentDescription, students.studentName,orders.instructor_name, orders.quantity, inventory.condition_) " +
                    "LIKE @searchData";

                    MySqlCommand cmd = new MySqlCommand(baseQuery, connection);
                    cmd.Parameters.AddWithValue("@searchData", "%" + searchData.Text + "%");
                    cmd.Parameters.AddWithValue("@username", username);

                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        logsTable.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Data not found.");
                    }
                }
                else
                {
                    string baseQuery = "SELECT logs_.logID, orders.orderID, students.studentName, " +
                    "orders.subject_code, inventory.equipmentName, orders.quantity, " +
                    "orders.instructor_name, " +
                    "orders.order_DATE, orders.order_TIME, logs_.return_DATE, logs_.return_TIME, " +
                    "logs_.notes FROM sql6696982.logs_ " +
                    "INNER JOIN orders ON logs_.order_ID = orders.orderID " +
                    "LEFT JOIN employee_staff ON orders.staff_ID = employee_staff.staffID " +
                    "LEFT JOIN employee_admin ON orders.admin_ID = employee_admin.adminID " +
                    "INNER JOIN students ON orders.student_ID = students.studentID " +
                    "INNER JOIN inventory ON orders.equipment_ID = inventory.equipmentID " +
                    "WHERE CONCAT(inventory.equipmentID, inventory.equipmentName, inventory.equipmentDescription, students.studentName,orders.instructor_name, orders.quantity, inventory.condition_) " +
                    "LIKE @searchData AND employee_staff.username = @username";

                    MySqlCommand cmd = new MySqlCommand(baseQuery, connection);
                    cmd.Parameters.AddWithValue("@searchData", "%" + searchData.Text + "%");
                    cmd.Parameters.AddWithValue("@username", username);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        logsTable.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Data not found.");
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchData_TextChanged(object sender, EventArgs e)
        {
            if(searchData.Text == "")
            {
                loadData();
            }
        }
    }
}
