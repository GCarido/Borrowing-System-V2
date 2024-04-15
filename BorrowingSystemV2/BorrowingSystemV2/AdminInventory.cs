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
using System.Collections;


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
            MySqlCommand cmd = new MySqlCommand("SELECT  equipmentID, equipmentName, equipmentDescription, quantity, condition_, image FROM sql6696982.inventory", connection);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            adminInventoryData.DataSource = dt;

            adminInventoryData.RowTemplate.Height = 80;
            adminInventoryData.AllowUserToAddRows = false;

            adminInventoryData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    


            searchDatas("");
            connection.Close();
        }

        private void insertimageBTN_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Choose Image(*.jpg; *.png; *.gif) | *.jpg; *.png; *.gif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                equipmentImage.Image = Image.FromFile(openFileDialog1.FileName);
                equipmentImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void createBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(equipmentIDTxtbx.Text) || string.IsNullOrWhiteSpace(equipmentNameTxtbx.Text) ||
                    string.IsNullOrWhiteSpace(equipmentDescriptionTxtbx.Text) || string.IsNullOrWhiteSpace(quantityTxtbx.Text) ||
                    string.IsNullOrWhiteSpace(conditionTxtbx.Text))
                {
                    MessageBox.Show("Please provide all necessary information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MySqlConnection conn = new MySqlConnection($"datasource={mySqlServerName};port=3306;username={mySqlServerUserId};password={mySqlServerPassword};database={mySqlDatabaseName}");
                conn.Open();
                string queryCheck = "SELECT * FROM sql6696982.inventory WHERE equipmentID = @equipmentID";
                MySqlCommand commandCheck = new MySqlCommand(queryCheck, conn);
                commandCheck.Parameters.AddWithValue("@equipmentID", equipmentIDTxtbx.Text);
                MySqlDataAdapter adapter = new MySqlDataAdapter(commandCheck);
                DataTable table = new DataTable();
                adapter.Fill(table);
                    
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Equipment ID already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to create this new equipment?", "New Equipment", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (!string.IsNullOrEmpty(openFileDialog1.FileName))
                    {
                        // Read the image file into a byte array
                        byte[] imageData;
                        FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        imageData = br.ReadBytes((int)fs.Length);

                        MySqlConnection connection = new MySqlConnection($"datasource={mySqlServerName};port=3306;username={mySqlServerUserId};password={mySqlServerPassword};database={mySqlDatabaseName}");
                        MySqlCommand command = connection.CreateCommand();
                        
                        command.CommandText = "INSERT INTO inventory (equipmentID, equipmentName, equipmentDescription, quantity, condition_, image) " +
                                                  "VALUES (@equipmentID, @equipmentName, @equipmentDescription, @quantity, @condition_, @image)";
                        command.Parameters.AddWithValue("@equipmentID", equipmentIDTxtbx.Text);
                        command.Parameters.AddWithValue("@equipmentName", equipmentNameTxtbx.Text);
                        command.Parameters.AddWithValue("@equipmentDescription", equipmentDescriptionTxtbx.Text);
                        command.Parameters.AddWithValue("@quantity", quantityTxtbx.Text);
                        command.Parameters.AddWithValue("@condition_", conditionTxtbx.Text);
                        command.Parameters.AddWithValue("@image", imageData);

                        connection.Open();
                        command.ExecuteNonQuery();

                        MessageBox.Show("New Equipment Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReloadDataGridView();  
                    }
                    else
                    {
                        MessageBox.Show("Please select an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(equipmentIDTxtbx.Text) || string.IsNullOrWhiteSpace(equipmentNameTxtbx.Text) ||
                    string.IsNullOrWhiteSpace(equipmentDescriptionTxtbx.Text) || string.IsNullOrWhiteSpace(quantityTxtbx.Text) ||
                    string.IsNullOrWhiteSpace(conditionTxtbx.Text))
                {
                    MessageBox.Show("Please provide all necessary information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MySqlConnection conn = new MySqlConnection($"datasource={mySqlServerName};port=3306;username={mySqlServerUserId};password={mySqlServerPassword};database={mySqlDatabaseName}");
                conn.Open();
                string queryCheck = "SELECT * FROM sql6696982.inventory WHERE equipmentID = @equipmentID";
                MySqlCommand commandCheck = new MySqlCommand(queryCheck, conn);
                commandCheck.Parameters.AddWithValue("@equipmentID", equipmentIDTxtbx.Text);
                MySqlDataAdapter adapter = new MySqlDataAdapter(commandCheck);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Equipment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to update this equipment?", "Update Equipment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlConnection connection = new MySqlConnection($"datasource={mySqlServerName};port=3306;username={mySqlServerUserId};password={mySqlServerPassword};database={mySqlDatabaseName}");
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();

                    command.CommandText = "UPDATE inventory SET equipmentName = @equipmentName, equipmentDescription = @equipmentDescription, quantity = @quantity, condition_ = @condition_ WHERE equipmentID = @equipmentID";
                    command.Parameters.AddWithValue("@equipmentID", equipmentIDTxtbx.Text);
                    command.Parameters.AddWithValue("@equipmentName", equipmentNameTxtbx.Text);
                    command.Parameters.AddWithValue("@equipmentDescription", equipmentDescriptionTxtbx.Text);
                    command.Parameters.AddWithValue("@quantity", quantityTxtbx.Text);
                    command.Parameters.AddWithValue("@condition_", conditionTxtbx.Text);
                    
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Equipment updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReloadDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update equipment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            string equipmentID = equipmentIDTxtbx.Text;
            MySqlConnection conn = new MySqlConnection($"datasource={mySqlServerName};port=3306;username={mySqlServerUserId};password={mySqlServerPassword};database={mySqlDatabaseName}");
            conn.Open();
            string queryCheck = "SELECT * FROM sql6696982.inventory WHERE equipmentID = @equipmentID";
            MySqlCommand commandCheck = new MySqlCommand(queryCheck, conn);
           commandCheck.Parameters.AddWithValue("@equipmentID", equipmentID);

            MySqlDataReader reader = commandCheck.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("Equipment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    MySqlConnection connection = new MySqlConnection($"datasource={mySqlServerName};port=3306;username={mySqlServerUserId};password={mySqlServerPassword};database={mySqlDatabaseName}");
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "DELETE FROM inventory WHERE equipmentID = @equipmentID";
                    command.Parameters.AddWithValue("@equipmentID", equipmentID);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Equipment deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        equipmentIDTxtbx.Text = "";
                        equipmentNameTxtbx.Text = "";
                        equipmentDescriptionTxtbx.Text = "";
                        quantityTxtbx.Text = "";
                        conditionTxtbx.Text = "";
                        
                        ReloadDataGridView();
                     }
                     else
                     {
                        MessageBox.Show("Failed to delete equipment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ReloadDataGridView()
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM inventory", connection);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(dt);
                adminInventoryData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reloading DataGridView: " + ex.Message);
            }
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

                if(row.Cells["image"].Value != DBNull.Value)
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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        
    }
}
