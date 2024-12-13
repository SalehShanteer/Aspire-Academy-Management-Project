using CourseCenterBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseCenter_Project
{
    public partial class frmStudentEnrollments : Form
    {
        private DataView _dvStudentEnrollments = new DataView();

        private int _StudentID;

        private Action<Action, int> _CheckIfUserAccess;


        private void _RefreshStudentEnrollmentsList()
        {
            _dvStudentEnrollments = clsEnrollment.GetStudentEnrollmentsList(_StudentID).DefaultView;
            dgvStudentEnrollments.DataSource = _dvStudentEnrollments;
        }

        private void _Refresh()
        {
            //Set Title with student ID and display number of enrollments
            lblStudentEnrollments.Text = $"Student ({_StudentID}) Enrollments";
            lblNumberOfEnrollments.Text = clsEnrollment.CountStudentEnrollments(_StudentID).ToString();

            _RefreshStudentEnrollmentsList();
        }


        private bool _CheckIfRefund(int EnrollmentID)
        {
            //If you don't want refund you can't delete enrollment and payment
            if (clsPayment.IsPaidAnyAmount(EnrollmentID))
            {
                if (MessageBox.Show("You can not delete this enrollment because it is already paid" +
                    ", if you want make a refund for Student Press yes.", "Attention", MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question) == DialogResult.Yes)
                    return true;
                return false;
            }
            return true;
        }

        private bool _DeletePayment(int EnrollmentID)
        {
            if (clsPayment.DeleteByEnrollmentID(EnrollmentID))
            {
                //If payment deleted successfully this will send notification
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipTitle = "Payments";
                notifyIcon1.BalloonTipText = "Payment Record Deleted Successfully";
                notifyIcon1.ShowBalloonTip(2000);
                return true;
            }
            else
            {
                //If payment delete failed this will send notification
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                notifyIcon1.BalloonTipTitle = "Payments";
                notifyIcon1.BalloonTipText = "Payment Record Delete Failed";
                notifyIcon1.ShowBalloonTip(2000);
                return false;
            }
        }


        private void _Enroll()
        {
            frmAddUpdateEnrollment frm = new frmAddUpdateEnrollment(-1, _CheckIfUserAccess, -1, _StudentID);
            frm.ShowDialog();

            _Refresh();
        }

        private void _UpdateStudentEnrollment()
        {
            if (dgvStudentEnrollments.SelectedCells.Count > 0)
            {
                int SelectedEnrollmentID = (int)dgvStudentEnrollments.CurrentRow.Cells["EnrollmentID"].Value;

                if (clsEnrollment.IsExist(SelectedEnrollmentID))
                {
                    frmAddUpdateEnrollment frm = new frmAddUpdateEnrollment(SelectedEnrollmentID, _CheckIfUserAccess);
                    frm.ShowDialog();

                    _Refresh();
                }
                else
                    MessageBox.Show("Enrollment ID not found!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("There is no Student Selected to Update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _Unenroll()
        {
            if (dgvStudentEnrollments.SelectedCells.Count > 0)
            {
                int SelectedEnrollmentID = (int)dgvStudentEnrollments.CurrentRow.Cells["EnrollmentID"].Value;

                //Check if payment needs to be refunded
                if (!_CheckIfRefund(SelectedEnrollmentID))
                    return;

                if (MessageBox.Show($"Are you sure you want to delete Enrollment with ID = {SelectedEnrollmentID} ?", "Warning"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    
                    //Delete payment before enrollment as payment depends on enrollment
                    if (_DeletePayment(SelectedEnrollmentID) && clsEnrollment.Delete(SelectedEnrollmentID))
                    {
                        MessageBox.Show("Enrollment Deleted Successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _Refresh();
                    }
                    else
                        MessageBox.Show("Enrollment Delete Operation Failed!"
                        , "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
                MessageBox.Show("There is no Student Selected to Delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        public frmStudentEnrollments(int StudentID, Action <Action, int> CheckIfUserAccess)
        {
            InitializeComponent();
            _StudentID = StudentID;

            _CheckIfUserAccess = CheckIfUserAccess;
        }

        private void frmStudentEnrollments_Load(object sender, EventArgs e)
        {
            _Refresh();
        }
      

        //Manage student enrollments buttons
        private void btnEnroll_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_Enroll, (int)clsSettings.enEnrollmentsPermissions.Add);
        }

        private void btnUnenroll_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_Unenroll, (int)clsSettings.enEnrollmentsPermissions.Delete);
        }


        //Manage student enrollments strip menu
        private void enrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_Enroll, (int)clsSettings.enEnrollmentsPermissions.Add);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_UpdateStudentEnrollment, (int)clsSettings.enEnrollmentsPermissions.Update);
        }

        private void unEnrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_Unenroll, (int)clsSettings.enEnrollmentsPermissions.Delete);
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
