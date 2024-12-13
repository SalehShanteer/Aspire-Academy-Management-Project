using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using CourseCenterBusinessLayer;

namespace CourseCenter_Project
{
    public partial class frmMain : Form
    {

        private clsUser _CurrentUser;

        private int _CurrentUserPermissions; 
        
        private void _DisplaySummaryList()
        {
            lblStudentsNumber.Text = clsStudent.Count().ToString();
            lblInstructorsNumber.Text = clsInstructor.Count().ToString();
            lblCoursesNumber.Text = clsCourse.Count().ToString();
            lblEnrollmentsNumber.Text = clsEnrollment.Count().ToString();
            lblUnpaidPayments.Text = clsPayment.CountUnPaid().ToString();
        }

        private void _Refresh()
        {
            timer1.Enabled = true;
            lblTimeDate.Text = clsUtility.DateTimeString();

            _DisplaySummaryList();
        }

        private void _CheckIfUserAccess(Action action, int Permissions)
        {
            if (clsSettings.CheckPermission(_CurrentUserPermissions, Permissions))
            {
                action();
            }
            else
                MessageBox.Show(clsSettings.NoAccessMessage, clsSettings.NoAccessTitle
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Showing screens functions
        private void _ShowManagePeopleScreen()
        {
            frmManagePeople frm = new frmManagePeople(_CurrentUserPermissions, _CheckIfUserAccess);
            frm.ShowDialog();
        }   

        private void _ShowManageStudentsScreen()
        {
            frmManageStudents frm = new frmManageStudents(_CurrentUserPermissions, _CheckIfUserAccess);
            frm.ShowDialog();

            _Refresh();
        }

        private void _ShowManageInstructorsScreen()
        {
            frmManageInstructors frm = new frmManageInstructors(_CurrentUserPermissions, _CheckIfUserAccess);
            frm.ShowDialog();

            _Refresh();
        }

        private void _ShowManageUsersScreen()
        {
            frmManageUsers frm = new frmManageUsers(_CurrentUserPermissions, _CheckIfUserAccess);
            frm.ShowDialog();

            _Refresh();
        }

        private void _ShowManageCoursesScreen()
        {
            frmManageCourses frm = new frmManageCourses(_CurrentUserPermissions, _CheckIfUserAccess);
            frm.ShowDialog();

            _Refresh();
        }

        private void _ShowManageEnrollmentsScreen()
        {
            frmManageEnrollments frm = new frmManageEnrollments(_CurrentUserPermissions, _CheckIfUserAccess);
            frm.ShowDialog();

            _Refresh();
        }

        private void _ShowManagePaymentsScreen()
        {
            frmManagePayments frm = new frmManagePayments(_CurrentUserPermissions, _CheckIfUserAccess);
            frm.ShowDialog();

            _Refresh();
        }

        
        public frmMain(clsUser User)
        {
            InitializeComponent();
            
            _CurrentUser = User;

            _CurrentUserPermissions = clsRole.Find(_CurrentUser.RoleID).Permissions;
        }

        //Main buttons for managing
        private void btnManagePeople_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_ShowManagePeopleScreen, (int)clsSettings.enPeoplePermissions.Read);
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_ShowManageStudentsScreen, (int)clsSettings.enStudentsPermissions.Read);
        }

        private void ManageInstructors_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_ShowManageInstructorsScreen, (int)clsSettings.enInstructorsPermissions.Read);
        }

        private void btnManageCourses_Click(object sender, EventArgs e)
        {
           _CheckIfUserAccess(_ShowManageCoursesScreen, (int)clsSettings.enCoursesPermissions.Read);
        }

        private void btnManageEnrollments_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_ShowManageEnrollmentsScreen, (int)clsSettings.enEnrollmentsPermissions.Read);
        }

        private void btnManagePayments_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_ShowManagePaymentsScreen, (int)clsSettings.enPaymentsPermissions.Read);
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_ShowManageUsersScreen, (int)clsSettings.enUsersPermissions.Read);
        }

        //Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimeDate.Text = clsUtility.DateTimeString();
        }

        //Form
        private void frmMain_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
        }

        //Sub buttons
        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This App made by Saleh Shanteer\n" +
                            "Using C# in .Net framework and\n" +
                            "DataBase using Sql server", "About"
                            , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        { 
            this.Close();
        }
    }
}
