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
            this.dashboardTable.MouseWheel += new MouseEventHandler(dashboardTable_MouseWheel);
        }

        private void dashboardTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
            connection.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT orders.orderID, orders.subject_code, " +
                "orders.instructor_name, inventory.equipmentName, students.studentName, " +
                "CONCAT(employee_admin.firstname, ' ', employee_admin.lastname) AS adminFullname, " +
                "CONCAT(employee_staff.firstname, ' ', employee_staff.lastname) AS staffFullname, " +
                "orders.order_DATE, orders.order_TIME, orders.status_ FROM orders " +
                "INNER JOIN inventory ON orders.equipment_ID = inventory.equipmentID " +
                "INNER JOIN students ON orders.student_ID = students.studentID " +
                "LEFT JOIN employee_admin ON orders.admin_ID = employee_admin.adminID " +
                "LEFT JOIN employee_staff on orders.staff_ID = employee_staff.staffID " +
                "WHERE orders.status_ IS NULL", connection);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dashboardTable.DataSource = dt;
            connection.Close();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int visibleRows = dashboardTable.DisplayedRowCount(false);
            int maxFirstRow = Math.Max(0, dashboardTable.Rows.Count - visibleRows);
            int desiredFirstRow = Math.Max(0, Math.Min(maxFirstRow, e.NewValue));

            dashboardTable.FirstDisplayedScrollingRowIndex = desiredFirstRow;
        }

        private void dashboardTable_MouseWheel(object sender, MouseEventArgs e)
        {

            try
            {
                int currentIndex = this.dashboardTable.FirstDisplayedScrollingRowIndex;
                int scrollLines = SystemInformation.MouseWheelScrollLines;

                if (e.Delta > 0)
                {
                    this.dashboardTable.FirstDisplayedScrollingRowIndex
                        = Math.Max(0, currentIndex - scrollLines);
                }
                else if (e.Delta < 0)
                {
                    this.dashboardTable.FirstDisplayedScrollingRowIndex
                        = currentIndex + scrollLines;
                }
            }
            catch (Exception)
            {
                return;
            }

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
                    //CODE FOR INSERT
                    MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO sql6696982.logs_ (order_ID, return_DATE, return_TIME) VALUES (" + dashboardTable.Rows[e.RowIndex].Cells[0].Value.ToString() + ", CURDATE(), CURTIME())", connection);
                    cmd.ExecuteNonQuery();

                    //Code to Update the status of the order into "Returned"
                    MySqlCommand cmd2 = new MySqlCommand("UPDATE sql6696982.orders SET status_ = 'Returned' WHERE orderID = " + dashboardTable.Rows[e.RowIndex].Cells[0].Value.ToString(), connection);
                    cmd2.ExecuteNonQuery();
                    connection.Close();

                    //REFRESH DATAGRIDVIEW
                    connection.Open();
                    MySqlCommand cmd1 = new MySqlCommand("SELECT orders.orderID, orders.subject_code, " +
                        "orders.instructor_name, inventory.equipmentName, students.studentName, " +
                        "CONCAT(employee_admin.firstname, ' ', employee_admin.lastname) AS adminFullname, " +
                        "CONCAT(employee_staff.firstname, ' ', employee_staff.lastname) AS staffFullname, " +
                        "orders.order_DATE, orders.order_TIME, orders.status_ FROM orders " +
                        "INNER JOIN inventory ON orders.equipment_ID = inventory.equipmentID " +
                        "INNER JOIN students ON orders.student_ID = students.studentID " +
                        "LEFT JOIN employee_admin ON orders.admin_ID = employee_admin.adminID " +
                        "LEFT JOIN employee_staff on orders.staff_ID = employee_staff.staffID " +
                        "WHERE orders.status_ IS NULL", connection);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd1);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    dashboardTable.DataSource = dt;
                    connection.Close();
                }
                else
                {
                    // If the user clicked "No", set selectedCell to null and refresh the DataGridView
                    selectedCell = null;
                    dashboardTable.Refresh();
                }
            }
        }
    }
}
