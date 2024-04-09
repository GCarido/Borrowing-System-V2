using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorrowingSystemV2.AdminAccManagementPanels
{
    public partial class AdminList : UserControl
    {
        public AdminList()
        {
            InitializeComponent();
        }
        public void UpdateAdminInfo()
        {
            adminIDTxtbx.Text = AdminAccountManangement.adminID;
            AfirstnameTxtbx.Text = AdminAccountManangement.adminFName;
            AlastnameTxtbx.Text = AdminAccountManangement.adminLName;
            AusernameTxtbx.Text = AdminAccountManangement.adminUserName;
            ApasswordTxtbx.Text = AdminAccountManangement.adminPassword;
            ApositionTxtbx.Text = AdminAccountManangement.adminPosition;

        }
    }
}
