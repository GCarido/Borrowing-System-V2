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
    public partial class StudentList : UserControl
    {

        public StudentList()
        {
            InitializeComponent();

        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            
        }

        public void UpdateStudentInfo()
        {
            studentIDTxtbx.Text = AdminAccountManangement.studentID;
            studentnameTxtbx.Text = AdminAccountManangement.studentName;
            courseTxtbx.Text = AdminAccountManangement.studentCourse;
            yearTxtbx.Text = AdminAccountManangement.studentYear;

        }
    }
}
