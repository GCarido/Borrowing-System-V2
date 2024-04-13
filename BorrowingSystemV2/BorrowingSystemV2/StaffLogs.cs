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
    public partial class StaffLogs : Form
    {
        public string mySqlServerName = "sql6.freemysqlhosting.net";
        public string mySqlServerUserId = "sql6696982";
        public string mySqlServerPassword = "DJyeU2QQMU";
        public string mySqlDatabaseName = "sql6696982";

        public StaffLogs()
        {
            InitializeComponent();
        }

        private void StaffLogs_Load(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
            connection.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT logs_.logID," + 
            "orders.orderID, students.studentName, orders.subject_code, inventory.equipmentName,  orders.quantity, orders.instructor_name, " +
            "orders.order_DATE, orders.order_TIME, logs_.return_DATE, logs_.return_TIME, logs_.notes FROM logs_ " +
            "INNER JOIN orders ON logs_.order_ID = orders.orderID " +
            "INNER JOIN students ON orders.student_ID = students.studentID " +
            "INNER JOIN inventory ON orders.equipment_ID = inventory.equipmentID", connection);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            staffLogsTable.DataSource = dt;
            searchDatas("");
            connection.Close();
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            string Search = searchData.Text.ToString();
            searchDatas(Search);
        }
        public void searchDatas(string Search)
        {
            MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
            connection.Open();
            string searchQuery = "SELECT logs_.logID, orders.orderID, students.studentName, " +
                 "orders.subject_code, inventory.equipmentName, orders.quantity, orders.instructor_name, " +
                 "orders.order_DATE, orders.order_TIME, logs_.return_DATE, logs_.return_TIME, " +
                 "logs_.notes FROM sql6696982.logs_ " +
                 "INNER JOIN orders ON logs_.order_ID = orders.orderID " +
                 "INNER JOIN students ON orders.student_ID = students.studentID " +
                 "INNER JOIN inventory ON orders.equipment_ID = inventory.equipmentID " +
                 "WHERE CONCAT(inventory.equipmentID, inventory.equipmentName, inventory.equipmentDescription, students.studentName,orders.instructor_name, orders.quantity, inventory.condition_) " +
                 "LIKE '%" + searchData.Text + "%'";
            MySqlCommand cmd = new MySqlCommand(searchQuery, connection);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                staffLogsTable.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Data not found.");
            }

        }
    }
}
