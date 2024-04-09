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
    public partial class LoginPage : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(1, 0);
        public static LoginPage instance;
        public LoginPage()
        {
            InitializeComponent();
            instance = this;
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        public void loadform(object Form)
        {
            if (this.loginpanel.Controls.Count > 1)
            {
                this.loginpanel.Controls.RemoveAt(1);
            }

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.loginpanel.Controls.Add(f);
            this.loginpanel.Tag = f;
            f.Show();
        }

        private void loginpanel_Paint(object sender, PaintEventArgs e)
        {
            loadform(new StaffLogin());
        }

        private void LoginPage_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void LoginPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void LoginPage_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
