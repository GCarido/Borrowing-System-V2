using BorrowingSystemV2.AdminAccManagementPanels;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Bcpg.OpenPgp;
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
    public partial class AdminAccountManangement : Form
    {

        public static AdminAccountManangement instance;
        public static string studentID { get; set; }
        public static string studentName { get; set; }
        public static string studentCourse { get; set; }
        public static string studentYear { get; set; }

        public static string staffID { get; set; }
        public static string staffFName { get; set; }
        public static string staffLName { get; set; }
        public static string staffUserName { get; set; }
        public static string staffPassword { get; set; }
        public static string staffPosition { get; set; }

        public static string adminID { get; set; }
        public static string adminFName { get; set; }
        public static string adminLName { get; set; }
        public static string adminUserName { get; set; }
        public static string adminPassword { get; set; }
        public static string adminPosition { get; set; }
        
        public static string adminDatagrid { get; set; }

        public AdminAccountManangement()
        {
            InitializeComponent();
            studentList1.BringToFront();
            instance = this;
        }

        public string mySqlServerName = "sql6.freemysqlhosting.net";
        public string mySqlServerUserId = "sql6696982";
        public string mySqlServerPassword = "DJyeU2QQMU";
        public string mySqlDatabaseName = "sql6696982";
       
        private void AdminAccountManangement_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM sql6696982.students", connection);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            studentData.DataSource = dt;

            cmd = new MySqlCommand("SELECT * FROM sql6696982.employee_staff", connection);
            adp = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adp.Fill(dt);
            staffData.DataSource = dt;

            cmd = new MySqlCommand("SELECT * FROM sql6696982.employee_admin", connection);
            adp = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adp.Fill(dt);
            adminData.DataSource = dt;

            searchDatas("");

            connection.Close();

        }

        public void refreshData()
        {
            MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM sql6696982.students", connection);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            studentData.DataSource = dt;

            cmd = new MySqlCommand("SELECT * FROM sql6696982.employee_staff", connection);
            adp = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adp.Fill(dt);
            staffData.DataSource = dt;

            cmd = new MySqlCommand("SELECT * FROM sql6696982.employee_admin", connection);
            adp = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adp.Fill(dt);
            adminData.DataSource = dt;

            connection.Close();
        }

        public void searchDatas(string Search)
        {

            if (studentListBTN.BackColor == Color.FromArgb(252, 168, 115))
            {
                 MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
                 connection.Open();
                 string searchQuery = "SELECT * FROM sql6696982.students WHERE CONCAT(`studentID`, `studentName`, `course`, `yearLevel`) like '%" + searchData.Text + "%'";
                 MySqlCommand cmd = new MySqlCommand(searchQuery, connection);
                 MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                 DataTable dt = new DataTable();
                 adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    studentData.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Data not found.");
                }
            }
            else if (staffListBTN.BackColor == Color.FromArgb(252, 168, 115))
            {
                MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
                connection.Open();
                string searchQuery = "SELECT * FROM sql6696982.employee_staff WHERE CONCAT(`staffID`, `firstname`, `lastname`, `username`, `password_`, `position`) like '%" + searchData.Text + "%'";
                MySqlCommand cmd = new MySqlCommand(searchQuery, connection);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                   staffData.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Data not found.");
                }
            }
            else
            {
                MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
                connection.Open();
                string searchQuery = "SELECT * FROM sql6696982.employee_admin WHERE CONCAT(`adminID`, `firstname`, `lastname`, `username`, `password_`, `position`) like '%" + searchData.Text + "%'";
                MySqlCommand cmd = new MySqlCommand(searchQuery, connection);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    adminData.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Data not found.");
                }
            }
            
        }
        private void searchBTN_Click(object sender, EventArgs e)
        {
            string Search = searchData.Text.ToString();
            searchDatas(Search);
        }

        private void studentListBTN_Click(object sender, EventArgs e)
        {
            studentList1.BringToFront();
            staffListBTN.BackColor = Color.FromArgb(233, 215, 174);
            studentListBTN.BackColor = Color.FromArgb(252, 168, 115);
            adminListBTN.BackColor = Color.FromArgb(233, 215, 174);
            studentData.BringToFront();
        }

        private void staffListBTN_Click(object sender, EventArgs e)
        {
            staffList1.BringToFront();
            staffListBTN.BackColor = Color.FromArgb(252, 168, 115);
            studentListBTN.BackColor = Color.FromArgb(233, 215, 174);
            adminListBTN.BackColor = Color.FromArgb(233, 215, 174);
            staffData.BringToFront();
        }

        private void adminListBTN_Click(object sender, EventArgs e)
        {
            adminList1.BringToFront();
            staffListBTN.BackColor = Color.FromArgb(233, 215, 174);
            studentListBTN.BackColor = Color.FromArgb(233, 215, 174);
            adminListBTN.BackColor = Color.FromArgb(252, 168, 115);
            adminData.BringToFront();
        }

        private void studentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                studentID = studentData.Rows[e.RowIndex].Cells[0].Value.ToString();
                studentName = studentData.Rows[e.RowIndex].Cells[1].Value.ToString();
                studentCourse = studentData.Rows[e.RowIndex].Cells[2].Value.ToString();
                studentYear = studentData.Rows[e.RowIndex].Cells[3].Value.ToString();
                studentList1.UpdateStudentInfo();
            }
        }

        private void staffData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                staffID = staffData.Rows[e.RowIndex].Cells[0].Value.ToString();
                staffFName = staffData.Rows[e.RowIndex].Cells[1].Value.ToString();
                staffLName = staffData.Rows[e.RowIndex].Cells[2].Value.ToString();
                staffUserName = staffData.Rows[e.RowIndex].Cells[3].Value.ToString();
                staffPassword = staffData.Rows[e.RowIndex].Cells[4].Value.ToString();
                staffPosition = staffData.Rows[e.RowIndex].Cells[5].Value.ToString();
                staffList1.UpdateStaffInfo();
            }
        }

        private void adminData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                adminID = adminData.Rows[e.RowIndex].Cells[0].Value.ToString();
                adminFName = adminData.Rows[e.RowIndex].Cells[1].Value.ToString();
                adminLName = adminData.Rows[e.RowIndex].Cells[2].Value.ToString();
                adminUserName = adminData.Rows[e.RowIndex].Cells[3].Value.ToString();
                adminPassword = adminData.Rows[e.RowIndex].Cells[4].Value.ToString();
                adminPosition = adminData.Rows[e.RowIndex].Cells[5].Value.ToString();
                adminList1.UpdateAdminInfo();
            }

            
        }

        private void studentData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void staffData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adminData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchData_TextChanged(object sender, EventArgs e)
        {
            if(searchData.Text == "")
            {
                MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM sql6696982.students", connection);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                studentData.DataSource = dt;

                cmd = new MySqlCommand("SELECT * FROM sql6696982.employee_staff", connection);
                adp = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                adp.Fill(dt);
                staffData.DataSource = dt;

                cmd = new MySqlCommand("SELECT * FROM sql6696982.employee_admin", connection);
                adp = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                adp.Fill(dt);
                adminData.DataSource = dt;

                searchDatas("");

                connection.Close();
            }
        }
    }
}