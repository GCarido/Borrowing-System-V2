using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace BorrowingSystemV2
{
    public partial class AdminInventory : Form
    {
        public string mySqlServerName = "sql6.freemysqlhosting.net";
        public string mySqlServerUserId = "sql6696982";
        public string mySqlServerPassword = "DJyeU2QQMU";
        public string mySqlDatabaseName = "sql6696982";

        public AdminInventory()
        {
            InitializeComponent();
        }

        private void AdminInventory_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT  equipmentID, equipmentName, equipmentDescription, quantity, condition_ FROM sql6696982.inventory", connection);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            adminInventoryData.DataSource = dt;
            searchDatas("");
            connection.Close();
        }

        private void searchBTN_Click_1(object sender, EventArgs e)
        {
            string Search = searchData.Text.ToString();
            searchDatas(Search);
        }
       
        public void searchDatas(string Search)
        {
            MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
            connection.Open();
            string searchQuery = "SELECT * FROM sql6696982.inventory WHERE CONCAT(`equipmentID`, `equipmentName`, `equipmentDescription`, `quantity`, `condition_`) like '%" + searchData.Text + "%'";
            MySqlCommand cmd = new MySqlCommand(searchQuery, connection);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                adminInventoryData.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Data not found.");
            }
        }

        private void adminInventoryData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = adminInventoryData.Rows[e.RowIndex];

                equipmentIDTxtbx.Text = row.Cells["equipmentID"].Value.ToString();
                equipmentNameTxtbx.Text = row.Cells["equipmentName"].Value.ToString();
                equipmentDescriptionTxtbx.Text = row.Cells["equipmentDescription"].Value.ToString();
                quantityTxtbx.Text = row.Cells["quantity"].Value.ToString();
                conditionTxtbx.Text = row.Cells["condition_"].Value.ToString();
            }
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            createBTN.Visible = true;
            updateBTN.Visible = true;
            deleteBTN.Visible = true;
            doneBTN.Visible = true;
            insertimageBTN.Visible = true;
            editBTN.Visible = false;
            equipmentIDTxtbx.ReadOnly = false;
            equipmentDescriptionTxtbx.ReadOnly = false;
            equipmentNameTxtbx.ReadOnly = false;
            quantityTxtbx.ReadOnly = false;
            conditionTxtbx.ReadOnly = false;
        }

        private void doneBTN_Click(object sender, EventArgs e)
        {
            createBTN.Visible=false;
            updateBTN.Visible=false;
            deleteBTN.Visible=false;
            doneBTN.Visible=false;
            insertimageBTN.Visible=false;
            editBTN.Visible=true;
            equipmentIDTxtbx.ReadOnly = true;
            equipmentDescriptionTxtbx.ReadOnly = true;
            equipmentNameTxtbx.ReadOnly = true;
            quantityTxtbx.ReadOnly = true;
            conditionTxtbx.ReadOnly = true;
        }

       
    }
}
