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
    public partial class AdminForm : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(1, 0);
        public AdminForm()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.adminFormPanel.Controls.Count > 1)
            {
                this.adminFormPanel.Controls.RemoveAt(1);
            }

            Form f = Form as Form;
            f.TopLevel = false;
            this.adminFormPanel.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.BringToFront();
            this.adminFormPanel.Tag = f;
            f.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            idlbl.Text = AdminLogin.EmployeeID;
            poslbl.Text = AdminLogin.Position;
        }

       

        private void homeBTN_Click(object sender, EventArgs e)
        {
            adminFormPanel.Visible = false;
            homeBTN.BackColor = Color.FromArgb(252, 168, 115);
            homeBTN.ForeColor = Color.Black;

            dashboardBTN.BackColor = Color.FromArgb(233, 215, 174);
            dashboardBTN.ForeColor = Color.FromArgb(84, 84, 84);
            orderBTN.BackColor = Color.FromArgb(233, 215, 174);
            orderBTN.ForeColor = Color.FromArgb(84, 84, 84);
            adminInventoryBTN.BackColor = Color.FromArgb(233, 215, 174);
            adminInventoryBTN.ForeColor = Color.FromArgb(84, 84, 84);
            adminLogsBTN.BackColor = Color.FromArgb(233, 215, 174);
            adminLogsBTN.ForeColor = Color.FromArgb(84, 84, 84);
            accMngmtBTN.BackColor = Color.FromArgb(233, 215, 174);
            accMngmtBTN.ForeColor = Color.FromArgb(84, 84, 84);
            settingsBTN.BackColor = Color.FromArgb(233, 215, 174);
            settingsBTN.ForeColor = Color.FromArgb(84, 84, 84);
        }

        private void dashboardBTN_Click(object sender, EventArgs e)
        {
            loadform(new Dashboard());
            adminFormPanel.Visible = true;
            homeBTN.BackColor = Color.FromArgb(233, 215, 174);
            homeBTN.ForeColor = Color.FromArgb(84, 84, 84);
            dashboardBTN.BackColor = Color.FromArgb(252, 168, 115);
            dashboardBTN.ForeColor = Color.Black;
            orderBTN.BackColor = Color.FromArgb(233, 215, 174);
            orderBTN.ForeColor = Color.FromArgb(84, 84, 84);
            adminInventoryBTN.BackColor = Color.FromArgb(233, 215, 174);
            adminInventoryBTN.ForeColor = Color.FromArgb(84, 84, 84);
            adminLogsBTN.BackColor = Color.FromArgb(233, 215, 174);
            adminLogsBTN.ForeColor = Color.FromArgb(84, 84, 84);
            accMngmtBTN.BackColor = Color.FromArgb(233, 215, 174);
            accMngmtBTN.ForeColor = Color.FromArgb(84, 84, 84);
            settingsBTN.BackColor = Color.FromArgb(233, 215, 174);
            settingsBTN.ForeColor = Color.FromArgb(84, 84, 84);
        }

        private void orderBTN_Click(object sender, EventArgs e)
        {
            loadform(new Order());
            adminFormPanel.Visible = true;
            homeBTN.BackColor = Color.FromArgb(233, 215, 174);
            homeBTN.ForeColor = Color.FromArgb(84, 84, 84);
            orderBTN.BackColor = Color.FromArgb(252, 168, 115);
            orderBTN.ForeColor = Color.Black;
            dashboardBTN.BackColor = Color.FromArgb(233, 215, 174);
            dashboardBTN.ForeColor = Color.FromArgb(84, 84, 84);
            adminInventoryBTN.BackColor = Color.FromArgb(233, 215, 174);
            adminInventoryBTN.ForeColor = Color.FromArgb(84, 84, 84);
            adminLogsBTN.BackColor = Color.FromArgb(233, 215, 174);
            adminLogsBTN.ForeColor = Color.FromArgb(84, 84, 84);
            accMngmtBTN.BackColor = Color.FromArgb(233, 215, 174);
            accMngmtBTN.ForeColor = Color.FromArgb(84, 84, 84);
            settingsBTN.BackColor = Color.FromArgb(233, 215, 174);
            settingsBTN.ForeColor = Color.FromArgb(84, 84, 84);
        }

        private void adminInventoryBTN_Click(object sender, EventArgs e)
        {
            loadform(new AdminInventory());
            adminFormPanel.Visible = true;
            homeBTN.BackColor = Color.FromArgb(233, 215, 174);
            homeBTN.ForeColor = Color.FromArgb(84, 84, 84);
            adminInventoryBTN.BackColor = Color.FromArgb(252, 168, 115);
            adminInventoryBTN.ForeColor = Color.Black;
            dashboardBTN.BackColor = Color.FromArgb(233, 215, 174);
            dashboardBTN.ForeColor = Color.FromArgb(84, 84, 84);
            orderBTN.BackColor = Color.FromArgb(233, 215, 174);
            orderBTN.ForeColor = Color.FromArgb(84, 84, 84);
            adminLogsBTN.BackColor = Color.FromArgb(233, 215, 174);
            adminLogsBTN.ForeColor = Color.FromArgb(84, 84, 84);
            accMngmtBTN.BackColor = Color.FromArgb(233, 215, 174);
            accMngmtBTN.ForeColor = Color.FromArgb(84, 84, 84);
            settingsBTN.BackColor = Color.FromArgb(233, 215, 174);
            settingsBTN.ForeColor = Color.FromArgb(84, 84, 84);
        }

        private void adminLogsBTN_Click(object sender, EventArgs e)
        {
            loadform(new Logs());
        }

        private void accMngmtBTN_Click(object sender, EventArgs e)
        {
            loadform(new AdminAccountManangement());
            adminFormPanel.Visible = true;
            accMngmtBTN.BackColor = Color.FromArgb(252, 168, 115);
            accMngmtBTN.ForeColor = Color.Black;

            homeBTN.BackColor = Color.FromArgb(233, 215, 174);
            homeBTN.ForeColor = Color.FromArgb(84, 84, 84);
            adminInventoryBTN.BackColor = Color.FromArgb(233, 215, 174);
            adminInventoryBTN.ForeColor = Color.FromArgb(84, 84, 84);
            dashboardBTN.BackColor = Color.FromArgb(233, 215, 174);
            dashboardBTN.ForeColor = Color.FromArgb(84, 84, 84);
            orderBTN.BackColor = Color.FromArgb(233, 215, 174);
            orderBTN.ForeColor = Color.FromArgb(84, 84, 84);
            adminLogsBTN.BackColor = Color.FromArgb(233, 215, 174);
            adminLogsBTN.ForeColor = Color.FromArgb(84, 84, 84);
            settingsBTN.BackColor = Color.FromArgb(233, 215, 174);
            settingsBTN.ForeColor = Color.FromArgb(84, 84, 84);
        }

        private void settingsBTN_Click(object sender, EventArgs e)
        {

        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminFormPanel_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void adminFormPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void adminFormPanel_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
