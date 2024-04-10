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
    public partial class StaffList : UserControl
    {
        public StaffList()
        {
            InitializeComponent();
        }
        public void UpdateStaffInfo()
        {
            staffIDTxtbx.Text = AdminAccountManangement.staffID;
            firstnameTxtbx.Text = AdminAccountManangement.staffFName;
            lastnameTxtbx.Text = AdminAccountManangement.staffLName;
            usernameTxtbx.Text = AdminAccountManangement.staffUserName;
            passwordTxtbx.Text = AdminAccountManangement.staffPassword;
            positionTxtbx.Text = AdminAccountManangement.staffPosition;

        }
    }
}
