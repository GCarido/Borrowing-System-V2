using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace BorrowingSystemV2
{
    public partial class StaffLogin : Form
    {
        public string mySqlServerName = "sql6.freemysqlhosting.net";
        public string mySqlServerUserId = "sql6696982";
        public string mySqlServerPassword = "DJyeU2QQMU";
        public string mySqlDatabaseName = "sql6696982";

        public static StaffLogin instance;

        public static string Username { get; set; }
        public static string EmployeeID { get; set; }
        public static string Position { get; set; }
        public StaffLogin()
        {
            InitializeComponent();
            instance = this;
        }

        public void loadform(object Form)
        {
            if (this.loginpanel.Controls.Count > 1)
            {
                this.loginpanel.Controls.RemoveAt(1);
            }

            Form f = Form as Form;
            f.TopLevel = false;
            this.loginpanel.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.BringToFront();
            f.Show();
        }

        private void unhideButton_Click(object sender, EventArgs e)
        {
            if (staffpasstxtbox.UseSystemPasswordChar == true)
            {
                unhideButton.Visible = false;
                hideButton.Visible = true;
                hideButton.BringToFront();
                staffpasstxtbox.UseSystemPasswordChar = false;
            }
            else
                staffpasstxtbox.UseSystemPasswordChar = true;
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            if (staffpasstxtbox.UseSystemPasswordChar == false)
            {
                hideButton.Visible = false;
                unhideButton.Visible = true;
                unhideButton.BringToFront();
                staffpasstxtbox.UseSystemPasswordChar = true;
            }
            else
                staffpasstxtbox.UseSystemPasswordChar = false;
        }

        private void staffusertxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginStaff.PerformClick();
            }
        }

        private void staffpasstxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginStaff.PerformClick();
            }
        }

        private void loginStaff_Click(object sender, EventArgs e)
        {
            try
            {
                if (staffusertxtbox.Text == "" || staffpasstxtbox.Text == "")
                {
                    MessageBox.Show("Please input Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MySqlConnection connection = new MySqlConnection($"datasource={mySqlServerName};port=3306;username={mySqlServerUserId};password={mySqlServerPassword};database={mySqlDatabaseName}");
                string query = $"SELECT * FROM sql6696982.employee_staff WHERE username = '{staffusertxtbox.Text}' AND password_ = '{staffpasstxtbox.Text}'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);



                if (table.Rows.Count <= 0)
                {
                    MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (table.Rows[0]["position"].ToString() != "Staff")
                    {
                        MessageBox.Show("The account you tried to login is an admin account. Please proceed to the admin section to sign in.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    Username = table.Rows[0]["username"].ToString();
                    EmployeeID = table.Rows[0]["staffID"].ToString();
                    Position = table.Rows[0]["position"].ToString();
                    LoginPage.instance.Hide();
                    StaffForm form2 = new StaffForm();
                    form2.Show();
                    AdminLogin.Position = null;
                    AdminLogin.Username = null;
                    AdminLogin.EmployeeID = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkAdmin_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadform(new AdminLogin());
        }

        private void staffusertxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void staffpasstxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
