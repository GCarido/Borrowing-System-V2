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

namespace BorrowingSystemV2
{
    public partial class AdminLogin : Form
    {
        public string mySqlServerName = "sql6.freemysqlhosting.net";
        public string mySqlServerUserId = "sql6690575";
        public string mySqlServerPassword = "WzrG9YgeeE";
        public string mySqlDatabaseName = "sql6690575";

        public static AdminLogin instance;
        public Button login;

        public static string Username { get; set; }
        public static string EmployeeID { get; set; }
        public static string Position { get; set; }
        public AdminLogin()
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

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void adminusertxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginAdmin.PerformClick();
            }
        }

        private void adminpasstxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginAdmin.PerformClick();
            }
        }

        private void unhideButton_Click(object sender, EventArgs e)
        {
            if (adminpasstxtbox.UseSystemPasswordChar == true)
            {
                unhideButton.Visible = false;
                hideButton.Visible = true;
                hideButton.BringToFront();
                adminpasstxtbox.UseSystemPasswordChar = false;
            }
            else
                adminpasstxtbox.UseSystemPasswordChar = true;
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            if (adminpasstxtbox.UseSystemPasswordChar == false)
            {
                hideButton.Visible = false;
                unhideButton.Visible = true;
                unhideButton.BringToFront();
                adminpasstxtbox.UseSystemPasswordChar = true;
            }
            else
                adminpasstxtbox.UseSystemPasswordChar = false;
        }

        private void loginAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                if (adminusertxtbox.Text == "" || adminpasstxtbox.Text == "")
                {
                    MessageBox.Show("Please input Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MySqlConnection connection = new MySqlConnection($"datasource={mySqlServerName};port=3306;username={mySqlServerUserId};password={mySqlServerPassword};database={mySqlDatabaseName}");
                string query = $"SELECT * FROM sql6696982.employee_admin WHERE username = '{adminusertxtbox.Text}' AND password_ = '{adminpasstxtbox.Text}'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count <= 0)
                {
                    MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (table.Rows[0]["position"].ToString() != "Admin")
                    {
                        MessageBox.Show("The account you tried to login is an staff account. Please proceed to the staff section to sign in.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    Username = table.Rows[0]["username"].ToString();
                    EmployeeID = table.Rows[0]["adminID"].ToString();
                    Position = table.Rows[0]["position"].ToString();
                    LoginPage.instance.Hide();
                    AdminForm form2 = new AdminForm();
                    form2.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkStaff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadform(new StaffLogin());
        }
    }
}
