using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorrowingSystemV2
{
    public partial class StaffInventory : Form
    {
        public string mySqlServerName = "sql6.freemysqlhosting.net";
        public string mySqlServerUserId = "sql6696982";
        public string mySqlServerPassword = "DJyeU2QQMU";
        public string mySqlDatabaseName = "sql6696982";
        public StaffInventory()
        {
            InitializeComponent();
        }

        private void StaffInventory_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
            connection.Open();
            MySqlCommand cmd = new MySqlCommand ("SELECT  equipmentID, equipmentName, equipmentDescription, quantity, condition_ FROM sql6696982.inventory", connection);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            staffInventoryData.DataSource = dt;

            staffInventoryData.RowTemplate.Height = 80;
            staffInventoryData.AllowUserToAddRows = false;

            searchDatas("");
            connection.Close();
        }

        private void staffInventoryData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = staffInventoryData.Rows[e.RowIndex];

                if (row.Cells["image"].Value != DBNull.Value)
                {
                    // Check if the cell value is a byte array
                    if (row.Cells["image"].Value is byte[])
                    {
                        byte[] img = (Byte[])row.Cells["image"].Value;
                        using (MemoryStream ms = new MemoryStream(img))
                        {
                            equipmentImage.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        // Handle the case where the cell value is not a byte array
                        MessageBox.Show("Invalid image format.");
                    }
                }

                equipmentIDTxtbx.Text = row.Cells["equipmentID"].Value.ToString();
                equipmentNameTxtbx.Text = row.Cells["equipmentName"].Value.ToString();
                equipmentDescriptionTxtbx.Text = row.Cells["equipmentDescription"].Value.ToString();
                quantityTxtbx.Text = row.Cells["quantity"].Value.ToString();
                conditionTxtbx.Text = row.Cells["condition_"].Value.ToString();
            }
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
            string searchQuery = "SELECT * FROM sql6696982.inventory WHERE CONCAT(`equipmentID`, `equipmentName`, `equipmentDescription`, `quantity`, `condition_`) like '%" + searchData.Text + "%'";
            MySqlCommand cmd = new MySqlCommand(searchQuery, connection);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                staffInventoryData.DataSource = dt;
            }
           else
           {
                MessageBox.Show("Data not found.");
           }
        }
    }
}
