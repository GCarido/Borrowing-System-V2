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
    public partial class AdminAccountManangement : Form
    {
        public string mySqlServerName = "sql6.freemysqlhosting.net";
        public string mySqlServerUserId = "sql6696982";
        public string mySqlServerPassword = "DJyeU2QQMU";
        public string mySqlDatabaseName = "sql6696982";

        public AdminAccountManangement()
        {
            InitializeComponent();
        }

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

            connection.Close();

        }

        private void studentListBTN_Click(object sender, EventArgs e)
        {
            studentData.Visible = true;
            staffData.Visible = false;
            adminData.Visible = false;

            studentinfoPanel.Visible = true;
            staffinfoPanel.Visible = false;
            admininfoPanel.Visible = false;

            studentListBTN.BackColor = Color.FromArgb(252, 168, 115);
            studentListBTN.ForeColor = Color.Black;
            staffListBTN.BackColor = Color.FromArgb(233, 215, 174);
            staffListBTN.ForeColor = Color.FromArgb(84, 84, 84);
            adminListBTN.BackColor = Color.FromArgb(233, 215, 174);
            adminListBTN.ForeColor = Color.FromArgb(84, 84, 84);
        }

        private void staffListBTN_Click(object sender, EventArgs e)
        {
            studentData.Visible = false;
            staffData.Visible = true;
            adminData.Visible = false;


            studentinfoPanel.Visible = false;
            staffinfoPanel.Visible = true;
            admininfoPanel.Visible = false;


            staffListBTN.BackColor = Color.FromArgb(252, 168, 115);
            staffListBTN.ForeColor = Color.Black;
            studentListBTN.BackColor = Color.FromArgb(233, 215, 174);
            studentListBTN.ForeColor = Color.FromArgb(84, 84, 84);
            adminListBTN.BackColor = Color.FromArgb(233, 215, 174);
            adminListBTN.ForeColor = Color.FromArgb(84, 84, 84);
        }

        private void adminListBTN_Click(object sender, EventArgs e)
        {
            studentData.Visible = false;
            staffData.Visible = false;
            adminData.Visible = true;

            studentinfoPanel.Visible = false;
            staffinfoPanel.Visible = false;
            admininfoPanel.Visible = true;

            adminListBTN.BackColor = Color.FromArgb(252, 168, 115);
            adminListBTN.ForeColor = Color.Black;
            studentListBTN.BackColor = Color.FromArgb(233, 215, 174);
            studentListBTN.ForeColor = Color.FromArgb(84, 84, 84);
            staffListBTN.BackColor = Color.FromArgb(233, 215, 174);
            staffListBTN.ForeColor = Color.FromArgb(84, 84, 84);
        }

        private void studentData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = studentData.Rows[e.RowIndex];

                studentIDTxtbx.Text = row.Cells["studentID"].Value.ToString();
                studentnameTxtbx.Text = row.Cells["studentName"].Value.ToString();
                courseTxtbx.Text = row.Cells["course"].Value.ToString();
                yearTxtbx.Text = row.Cells["yearLevel"].Value.ToString();
            }
        }

        private void staffData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = staffData.Rows[e.RowIndex];

                staffIDTxtbx.Text = row.Cells["staffID"].Value.ToString();
                firstnameTxtbx.Text = row.Cells["firstName"].Value.ToString();
                lastnameTxtbx.Text = row.Cells["lastName"].Value.ToString(); 
                usernameTxtbx.Text = row.Cells["username"].Value.ToString();
                passwordTxtbx.Text = row.Cells["password_"].Value.ToString();
                positionTxtbx.Text = row.Cells["position"].Value.ToString(); 
            }
        }

        private void adminData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = adminData.Rows[e.RowIndex];

                adminIDTxtbx.Text = row.Cells["adminID"].Value.ToString();
                AfirstnameTxtbx.Text = row.Cells["firstName"].Value.ToString();
                AlastnameTxtbx.Text = row.Cells["lastName"].Value.ToString();
                AusernameTxtbx.Text = row.Cells["username"].Value.ToString();
                ApasswordTxtbx.Text = row.Cells["password_"].Value.ToString();
                ApositionTxtbx.Text = row.Cells["position"].Value.ToString();
            }
        }

        private void admininfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
