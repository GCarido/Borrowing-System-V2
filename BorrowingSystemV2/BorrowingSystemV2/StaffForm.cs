using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorrowingSystemV2
{
    public partial class StaffForm : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(1, 0);
        public StaffForm()
        {
            InitializeComponent();
          
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            idlbl.Text = StaffLogin.EmployeeID;
            poslbl.Text = StaffLogin.Position;
        }

        public void loadform(object Form)
        {
            if (this.staffFormPanel.Controls.Count > 1)
            {
                this.staffFormPanel.Controls.RemoveAt(1);
            }

            Form f = Form as Form;
            f.TopLevel = false;
            this.staffFormPanel.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.BringToFront();
            this.staffFormPanel.Tag = f;
            f.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void homeBTN_Click(object sender, EventArgs e)
        {
            staffFormPanel.Visible = false;
            homeBTN.BackColor = Color.FromArgb(252, 168, 115);
            homeBTN.ForeColor = Color.Black;
            dashboardBTN.BackColor = Color.FromArgb(233, 215, 174);
            dashboardBTN.ForeColor = Color.FromArgb(84, 84, 84);
            orderBTN.BackColor = Color.FromArgb(233, 215, 174);
            orderBTN.ForeColor = Color.FromArgb(84, 84, 84);
            inventoryBTN.BackColor = Color.FromArgb(233, 215, 174);
            inventoryBTN.ForeColor = Color.FromArgb(84, 84, 84);
            logsBTN.BackColor = Color.FromArgb(233, 215, 174);
            logsBTN.ForeColor = Color.FromArgb(84, 84, 84);
            settingsBTN.BackColor = Color.FromArgb(233, 215, 174);
            settingsBTN.ForeColor = Color.FromArgb(84, 84, 84);
        }

        private void dashboardBTN_Click(object sender, EventArgs e)
        { 
            loadform(new Dashboard());
            staffFormPanel.Visible = true;
            homeBTN.BackColor = Color.FromArgb(233, 215, 174);
            homeBTN.ForeColor = Color.FromArgb(84, 84, 84);
            dashboardBTN.BackColor = Color.FromArgb(252, 168, 115);
            dashboardBTN.ForeColor = Color.Black;
            orderBTN.BackColor = Color.FromArgb(233, 215, 174);
            orderBTN.ForeColor = Color.FromArgb(84, 84, 84);
            inventoryBTN.BackColor = Color.FromArgb(233, 215, 174);
            inventoryBTN.ForeColor = Color.FromArgb(84, 84, 84);
            logsBTN.BackColor = Color.FromArgb(233, 215, 174);
            logsBTN.ForeColor = Color.FromArgb(84, 84, 84);
            settingsBTN.BackColor = Color.FromArgb(233, 215, 174);
            settingsBTN.ForeColor = Color.FromArgb(84, 84, 84);
        }

        private void orderBTN_Click(object sender, EventArgs e)
        {
            loadform(new Order());
            staffFormPanel.Visible = true;
            homeBTN.BackColor = Color.FromArgb(233, 215, 174);
            homeBTN.ForeColor = Color.FromArgb(84, 84, 84);
            orderBTN.BackColor = Color.FromArgb(252, 168, 115);
            orderBTN.ForeColor = Color.Black;
            dashboardBTN.BackColor = Color.FromArgb(233, 215, 174);
            dashboardBTN.ForeColor = Color.FromArgb(84, 84, 84);
            inventoryBTN.BackColor = Color.FromArgb(233, 215, 174);
            inventoryBTN.ForeColor = Color.FromArgb(84, 84, 84);
            logsBTN.BackColor = Color.FromArgb(233, 215, 174);
            logsBTN.ForeColor = Color.FromArgb(84, 84, 84);
            settingsBTN.BackColor = Color.FromArgb(233, 215, 174);
            settingsBTN.ForeColor = Color.FromArgb(84, 84, 84);
        }

        private void inventoryBTN_Click(object sender, EventArgs e)
        {
            staffFormPanel.Visible = true;
            homeBTN.BackColor = Color.FromArgb(233, 215, 174);
            homeBTN.ForeColor = Color.FromArgb(84, 84, 84);
            inventoryBTN.BackColor = Color.FromArgb(252, 168, 115);
            inventoryBTN.ForeColor = Color.Black;
            dashboardBTN.BackColor = Color.FromArgb(233, 215, 174);
            dashboardBTN.ForeColor = Color.FromArgb(84, 84, 84);
            orderBTN.BackColor = Color.FromArgb(233, 215, 174);
            orderBTN.ForeColor = Color.FromArgb(84, 84, 84);
            logsBTN.BackColor = Color.FromArgb(233, 215, 174);
            logsBTN.ForeColor = Color.FromArgb(84, 84, 84);
            settingsBTN.BackColor = Color.FromArgb(233, 215, 174);
            settingsBTN.ForeColor = Color.FromArgb(84, 84, 84);
        }

        private void logsBTN_Click(object sender, EventArgs e)
        {
            staffFormPanel.Visible = true;
            homeBTN.BackColor = Color.FromArgb(233, 215, 174);
            homeBTN.ForeColor = Color.FromArgb(84, 84, 84);
            logsBTN.BackColor = Color.FromArgb(252, 168, 115);
            logsBTN.ForeColor = Color.Black;
            dashboardBTN.BackColor = Color.FromArgb(233, 215, 174);
            dashboardBTN.ForeColor = Color.FromArgb(84, 84, 84);
            orderBTN.BackColor = Color.FromArgb(233, 215, 174);
            orderBTN.ForeColor = Color.FromArgb(84, 84, 84);
            inventoryBTN.BackColor = Color.FromArgb(233, 215, 174);
            inventoryBTN.ForeColor = Color.FromArgb(84, 84, 84);
            settingsBTN.BackColor = Color.FromArgb(233, 215, 174);
            settingsBTN.ForeColor = Color.FromArgb(84, 84, 84);
        }

        private void settingsBTN_Click(object sender, EventArgs e)
        {
            staffFormPanel.Visible = true;
            settingsBTN.BackColor = Color.FromArgb(252, 168, 115);
            settingsBTN.ForeColor = Color.Black;
            homeBTN.BackColor = Color.FromArgb(233, 215, 174);
            homeBTN.ForeColor = Color.FromArgb(84, 84, 84);
            dashboardBTN.BackColor = Color.FromArgb(233, 215, 174);
            dashboardBTN.ForeColor = Color.FromArgb(84, 84, 84);
            orderBTN.BackColor = Color.FromArgb(233, 215, 174);
            orderBTN.ForeColor = Color.FromArgb(84, 84, 84);
            inventoryBTN.BackColor = Color.FromArgb(233, 215, 174);
            inventoryBTN.ForeColor = Color.FromArgb(84, 84, 84);
            logsBTN.BackColor = Color.FromArgb(233, 215, 174);
            logsBTN.ForeColor = Color.FromArgb(84, 84, 84);
        }

        private void StaffForm_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void StaffForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void StaffForm_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
    }
}
