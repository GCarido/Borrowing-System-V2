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
    public partial class Dashboard : Form
    {
        public string mySqlServerName = "sql6.freemysqlhosting.net";
        public string mySqlServerUserId = "sql6696982";
        public string mySqlServerPassword = "DJyeU2QQMU";
        public string mySqlDatabaseName = "sql6696982";

        private DataGridViewCell selectedCell = null;

        Image normalImage = Properties.Resources.return3;
        Image hoverImage = Properties.Resources.return2;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void dashboardTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
            connection.Open();

            if (StaffLogin.Position == "Staff")
            {
                dashboardTable.Columns["fullName"].Visible = false;
            }

            string username = StaffLogin.Position == "Staff" ? StaffLogin.Username : AdminLogin.Username;
            string position = StaffLogin.Position == "Staff" ? StaffLogin.Position : AdminLogin.Position;

            MySqlCommand cmd;
            if (position == "Admin")
            {
                cmd = new MySqlCommand("SELECT orders.orderID, orders.subject_code, " +
                    "orders.instructor_name, inventory.equipmentName, students.studentName, orders.quantity, " +
                    "CONCAT(IFNULL(employee_staff.firstname, ''), ' ', IFNULL(employee_staff.lastname, ''), '', IFNULL(employee_admin.firstname, ''), ' ', IFNULL(employee_admin.lastname, '')) AS fullName, " +
                    "orders.order_DATE, orders.order_TIME, orders.status_ FROM orders " +
                    "INNER JOIN inventory ON orders.equipment_ID = inventory.equipmentID " +
                    "INNER JOIN students ON orders.student_ID = students.studentID " +
                    "LEFT JOIN employee_admin ON orders.admin_ID = employee_admin.adminID " +
                    "LEFT JOIN employee_staff on orders.staff_ID = employee_staff.staffID " +
                    "WHERE orders.status_ IS NULL", connection);
               
            }
            else
            {
                cmd = new MySqlCommand("SELECT orders.orderID, orders.subject_code, " +
                    "orders.instructor_name, inventory.equipmentName, students.studentName, orders.quantity, " +
                    "orders.order_DATE, orders.order_TIME, orders.status_ FROM orders " +
                    "INNER JOIN inventory ON orders.equipment_ID = inventory.equipmentID " +
                    "INNER JOIN students ON orders.student_ID = students.studentID " +
                    "LEFT JOIN employee_admin ON orders.admin_ID = employee_admin.adminID " +
                    "LEFT JOIN employee_staff on orders.staff_ID = employee_staff.staffID " +
                    "WHERE orders.status_ IS NULL AND (employee_admin.username = @username OR employee_staff.username = @username)", connection);
                cmd.Parameters.AddWithValue("@username", username);
                
            }

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dashboardTable.DataSource = dt;
            
            connection.Close();
        }


        public void searchDatas(string Search)
        {
            MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
            connection.Open();

            string username = StaffLogin.Position == "Staff" ? StaffLogin.Username : AdminLogin.Username;
            string position = StaffLogin.Position == "Staff" ? StaffLogin.Position : AdminLogin.Position;

            MySqlCommand cmd;
            if (position == "Admin")
            {
                cmd = new MySqlCommand("SELECT orders.orderID, orders.subject_code, " +
                    "orders.instructor_name, inventory.equipmentName, students.studentName, orders.quantity, " +
                    "CONCAT(IFNULL(employee_staff.firstname, ''), ' ', IFNULL(employee_staff.lastname, ''), '', IFNULL(employee_admin.firstname, ''), ' ', IFNULL(employee_admin.lastname, '')) AS fullName, " +
                    "orders.order_DATE, orders.order_TIME, orders.status_ FROM orders " +
                    "INNER JOIN inventory ON orders.equipment_ID = inventory.equipmentID " +
                    "INNER JOIN students ON orders.student_ID = students.studentID " +
                    "LEFT JOIN employee_admin ON orders.admin_ID = employee_admin.adminID " +
                    "LEFT JOIN employee_staff on orders.staff_ID = employee_staff.staffID " +
                    "WHERE orders.status_ IS NULL AND (orders.subject_code LIKE @search OR orders.instructor_name LIKE @search OR inventory.equipmentName LIKE @search OR students.studentName LIKE @search)", connection);
            }
            else
            {
                cmd = new MySqlCommand("SELECT orders.orderID, orders.subject_code, " +
                    "orders.instructor_name, inventory.equipmentName, students.studentName, orders.quantity, " +
                    "orders.order_DATE, orders.order_TIME, orders.status_ FROM orders " +
                    "INNER JOIN inventory ON orders.equipment_ID = inventory.equipmentID " +
                    "INNER JOIN students ON orders.student_ID = students.studentID " +
                    "LEFT JOIN employee_admin ON orders.admin_ID = employee_admin.adminID " +
                    "LEFT JOIN employee_staff on orders.staff_ID = employee_staff.staffID " +
                    "WHERE orders.status_ IS NULL AND (employee_admin.username = @username OR employee_staff.username = @username) AND (orders.subject_code LIKE @search OR orders.instructor_name LIKE @search OR inventory.equipmentName LIKE @search OR students.studentName LIKE @search)", connection);
                cmd.Parameters.AddWithValue("@username", username);
            }

            cmd.Parameters.AddWithValue("@search", "%" + Search + "%");

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dashboardTable.DataSource = dt;

            connection.Close();
        }

        private void dashboardTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                dashboardTable.Cursor = Cursors.Hand;
            }
        }

        private void dashboardTable_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                dashboardTable.Cursor = Cursors.Default;
            }
        }

        private void dashboardTable_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 9)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var image = normalImage;
                if (selectedCell != null && selectedCell.RowIndex == e.RowIndex && selectedCell.ColumnIndex == e.ColumnIndex)
                {
                    image = hoverImage;
                }

                var w = image.Width;
                var h = image.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(image, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dashboardTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 9)
            {

                //Change Image when selected
                selectedCell = dashboardTable[e.ColumnIndex, e.RowIndex];
                dashboardTable.InvalidateCell(e.ColumnIndex, e.RowIndex);
                dashboardTable.Refresh();

                if (MessageBox.Show("Are you sure you want to return the item?", "Return Item", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //SHOW NOTES FORM
                    AddNotes addnote = new AddNotes();
                    addnote.ShowDialog();

                    //CODE FOR INSERT
                    DateTime return_DATE = DateTime.Now;
                    DateTime return_TIME = DateTime.Now;

                    //Check if quantity for AddNotes.Notes is less than to the quantity of item borrowed
                    MySqlConnection connection1 = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
                    connection1.Open();
                    MySqlCommand cmd4 = new MySqlCommand($"SELECT quantity FROM orders WHERE orderID = {dashboardTable.Rows[e.RowIndex].Cells["orderID"].Value.ToString()}", connection1);
                    MySqlDataReader reader = cmd4.ExecuteReader();
                    reader.Read();
                    int quantity = reader.GetInt32("quantity");
                    if (Convert.ToInt32(AddNotes.Quantity) > quantity)
                    {
                        MessageBox.Show("Quantity to be returned is greater than the quantity borrowed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        selectedCell = null;
                        dashboardTable.Refresh();
                        return;
                    }
                    connection1.Close();

                    MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand($"INSERT INTO sql6696982.logs_ (order_ID, notes, return_DATE, return_TIME) VALUES ({dashboardTable.Rows[e.RowIndex].Cells["orderID"].Value.ToString()}, '{AddNotes.Notes}', @returnDate, @returnTime)", connection);
                    cmd.Parameters.AddWithValue("@returnDate", return_DATE);
                    cmd.Parameters.AddWithValue("@returnTime", return_TIME);
                    cmd.ExecuteNonQuery();

                    //Code to Update the status of the order into "Returned"
                    string orderID = dashboardTable.Rows[e.RowIndex].Cells["orderID"].Value.ToString();
                    MySqlCommand cmd2 = new MySqlCommand($"UPDATE sql6696982.orders SET status_ = 'Returned' WHERE orderID = {orderID}", connection);
                    cmd2.ExecuteNonQuery();

                    //Code to Update the inventory based on the equipmentID borrowed
                    string equipmentName = dashboardTable.Rows[e.RowIndex].Cells["equipmentName"].Value.ToString();
                    MySqlCommand cmd3 = new MySqlCommand($"UPDATE sql6696982.inventory SET quantity = quantity + {AddNotes.Quantity} WHERE equipmentName = '{equipmentName}'", connection);
                    cmd3.ExecuteNonQuery();

                    connection.Close();

                    //REFRESH DATAGRIDVIEW
                    connection.Open();

                    if (StaffLogin.Position == "Staff")
                    {
                        dashboardTable.Columns["fullName"].Visible = false;
                    }

                    string username = StaffLogin.Position == "Staff" ? StaffLogin.Username : AdminLogin.Username;
                    string position = StaffLogin.Position == "Staff" ? StaffLogin.Position : AdminLogin.Position;

                    if (position == "Admin")
                    {
                        cmd = new MySqlCommand("SELECT orders.orderID, orders.subject_code, " +
                            "orders.instructor_name, inventory.equipmentName, students.studentName, orders.quantity, " +
                            "CONCAT(IFNULL(employee_staff.firstname, ''), ' ', IFNULL(employee_staff.lastname, ''), '', IFNULL(employee_admin.firstname, ''), ' ', IFNULL(employee_admin.lastname, '')) AS fullName, " +
                            "orders.order_DATE, orders.order_TIME, orders.status_ FROM orders " +
                            "INNER JOIN inventory ON orders.equipment_ID = inventory.equipmentID " +
                            "INNER JOIN students ON orders.student_ID = students.studentID " +
                            "LEFT JOIN employee_admin ON orders.admin_ID = employee_admin.adminID " +
                            "LEFT JOIN employee_staff on orders.staff_ID = employee_staff.staffID " +
                            "WHERE orders.status_ IS NULL", connection);
                    }
                    else
                    {
                        cmd = new MySqlCommand("SELECT orders.orderID, orders.subject_code, " +
                            "orders.instructor_name, inventory.equipmentName, students.studentName, orders.quantity, " +
                            "orders.order_DATE, orders.order_TIME, orders.status_ FROM orders " +
                            "INNER JOIN inventory ON orders.equipment_ID = inventory.equipmentID " +
                            "INNER JOIN students ON orders.student_ID = students.studentID " +
                            "LEFT JOIN employee_admin ON orders.admin_ID = employee_admin.adminID " +
                            "LEFT JOIN employee_staff on orders.staff_ID = employee_staff.staffID " +
                            "WHERE orders.status_ IS NULL AND (employee_admin.username = @username OR employee_staff.username = @username)", connection);
                        cmd.Parameters.AddWithValue("@username", username);
                    }

                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    dashboardTable.DataSource = dt;
                    connection.Close();
                    MessageBox.Show("Item has been returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // If the user clicked "No", set selectedCell to null and refresh the DataGridView
                    selectedCell = null;
                    dashboardTable.Refresh();
                }
            }
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            string searchText = searchData.Text.Trim();
            searchDatas(searchText);
        }

        private void searchData_TextChanged(object sender, EventArgs e)
        {
            if(searchData.Text == "")
            {
                Dashboard_Load(sender, e);
            }
        }
    }
}
