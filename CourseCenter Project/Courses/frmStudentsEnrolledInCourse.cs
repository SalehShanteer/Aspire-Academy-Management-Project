using CourseCenterBusinessLayer;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CourseCenter_Project
{
    public partial class frmStudentsEnrolledInCourse : Form
    {
       
        private DataView _dvStudentsEnrolledInCourse = new DataView();

        private int _CourseID;

        private string _CourseName;

        private clsEnrollment _Enrollment;

        private Action<Action, int> _CheckIfUserAccess;


        private void _Refresh()
        {
            //Set title with course ID and name 
            lblCourseName.Text = $"{_CourseName} ({_CourseID})";

            _RefreshStudentsEnrolledInCourse(); 
        }

        private void _RefreshStudentsEnrolledInCourse()
        {
            _dvStudentsEnrolledInCourse = clsEnrollment.GetStudentsListForCourse(_CourseID).DefaultView;
            dgvStudentsEnrolledInCourse.DataSource = _dvStudentsEnrolledInCourse;

            //Display number of students
            lblNumberOfStudents.Text = clsEnrollment.CountStudentsEnrolledInCourse(_CourseID).ToString();
        }


        private void _EnrollStudentToCourse()
        {
            frmAddUpdateEnrollment frm = new frmAddUpdateEnrollment(-1, _CheckIfUserAccess, _CourseID);
            frm.ShowDialog();

            _RefreshStudentsEnrolledInCourse();
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

        private void _UnenrollStudentFromCourse()
        {
            if (dgvStudentsEnrolledInCourse.SelectedCells.Count > 0)
            {
                int EnrollmentID = (int)dgvStudentsEnrolledInCourse.CurrentRow.Cells["EnrollmentID"].Value;

                //Check if payment needs to be refunded
                if (!_CheckIfRefund(EnrollmentID))
                    return;

                int SelectedStudentID = (int)dgvStudentsEnrolledInCourse.CurrentRow.Cells["StudentID"].Value;

                if (MessageBox.Show($"Are you sure you want to Remove this student with ID = ({SelectedStudentID}) from this course?", "Delete"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    //Delete payment before enrollment as payment depends on enrollment
                    if (_DeletePayment(EnrollmentID) && clsEnrollment.Delete(EnrollmentID))
                    {
                        MessageBox.Show("Enrollment Deleted Successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefreshStudentsEnrolledInCourse();
                    }
                    else
                        MessageBox.Show("Enrollment Delete Operation Failed!"
                    , "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
                MessageBox.Show("There is no Student Selected to Delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void UpdateStudentInfo()
        {
            if (dgvStudentsEnrolledInCourse.SelectedCells.Count > 0)
            {
                int SelectedStudentID = (int)dgvStudentsEnrolledInCourse.CurrentRow.Cells["StudentID"].Value;

                if (clsStudent.IsExist(SelectedStudentID))
                {
                    frmAddUpdateStudent frm = new frmAddUpdateStudent(SelectedStudentID, _CheckIfUserAccess);
                    frm.ShowDialog();

                    _RefreshStudentsEnrolledInCourse();
                }
                else
                    MessageBox.Show("Student ID Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("There is no Student Selected to Edit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

       
        private void _DisplayGrade()
        {
            if (_Enrollment.Grade != 101)
            {
                //If student has a grade
                txtGrade.Text = _Enrollment.Grade.ToString();
                ckbNoGrade.Checked = false;
            }
            else
            {
                //If student does not have a grade
                ckbNoGrade.Checked = true;
            }
        }

        private void _EditGrade()
        {

            if (dgvStudentsEnrolledInCourse.SelectedCells.Count > 0)
            {

                int EnrollmentID = (int)dgvStudentsEnrolledInCourse.CurrentRow.Cells["EnrollmentID"].Value;

                _Enrollment = clsEnrollment.Find(EnrollmentID);

                if (_Enrollment != null)
                {
                    //Show Edit Grade Control
                    gbEditGrade.Visible = true;

                    //Set Student ID in student grade label
                    lblStudentGrade.Text = $"Student ({_Enrollment.StudentID}) Grade";

                    _DisplayGrade();
                }
                else
                    MessageBox.Show("Enrollment not found!", "Error!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("There is no student selected!", "Attention"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private bool _IsValidGrade(short Grade)
        {
            return Grade <= 100;
        }

        private bool _SetGrade()
        {
            if (ckbNoGrade.Checked)
            {
                //Remove Grade
                _Enrollment.Grade = (byte)101;
                return true;
            }
            else
            {
                //Set Grade
                short Grade = Convert.ToInt16(txtGrade.Text);
                if (_IsValidGrade(Grade))
                {
                    //Valid grade from 0 to 100
                    _Enrollment.Grade = (byte)Grade;
                    return true;
                }
                else
                {
                    //invalid grade over 100
                    return false;
                }
            }
        }

        private void _SaveGrade()
        {
            if (_Enrollment != null)
            {                         
                if (_SetGrade())
                {
                    if (_Enrollment.Save())
                    {
                        MessageBox.Show("Grade saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefreshStudentsEnrolledInCourse();
                    }
                    else
                    {
                        MessageBox.Show("Grade save failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The Grade is not valid!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

      
        private void _SaveCompleteEndDate()
        {
            if (_Enrollment != null)
            {
                if (MessageBox.Show($"Are you sure you want to make student with Enrollment ID = {_Enrollment.ID} " +
                    $"complete this course {_Enrollment.CourseID}!", "Complete?"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Set EndDate for Enrollment
                    _Enrollment.EndDate = DateTime.Now;

                    if (_Enrollment.Save())
                    {
                        MessageBox.Show("Course complete saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefreshStudentsEnrolledInCourse();
                    }
                    else
                    {
                        MessageBox.Show("Course complete save failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Enrollment not found!", "Error!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _CompleteCourse()
        {
            if (dgvStudentsEnrolledInCourse.SelectedCells.Count > 0)
            {
                int EnrollmentID = (int)dgvStudentsEnrolledInCourse.CurrentRow.Cells["EnrollmentID"].Value;

                if (clsPayment.IsEnrolmentPaidFullAmount(EnrollmentID))
                {
                    //Retrieve Enrollment Details for getting set end date
                    _Enrollment = clsEnrollment.Find(EnrollmentID);

                    //check if student have a grade (101 means NULL)
                    if (_Enrollment.Grade != 101)
                    {
                        _SaveCompleteEndDate();
                    }
                    else
                        MessageBox.Show("The Student does not have grade yet!", "Attention"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                    MessageBox.Show("The Student does not paid full course price!", "Attention"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                MessageBox.Show("There is no student selected!", "Attention"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public frmStudentsEnrolledInCourse(int CourseID, string CourseName, Action<Action, int> checkIfUserAccess)
        {
            InitializeComponent();

            _CourseID = CourseID;
            _CourseName = CourseName;
            _CheckIfUserAccess = checkIfUserAccess;
        }     

        private void ShowStudentsEnrolledInCourse_Load(object sender, EventArgs e)
        {
            _Refresh();
        }
       

        //Manage students enrollment to course 
        private void btnEnrollStudent_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_EnrollStudentToCourse, (int)clsSettings.enEnrollmentsPermissions.Add);
        }

        private void btnUnenrollStudent_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_UnenrollStudentFromCourse, (int)clsSettings.enEnrollmentsPermissions.Delete);
        }

        private void editStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(UpdateStudentInfo, (int)clsSettings.enStudentsPermissions.Update);
        }


        //Manage students enrollment to course strip menu
        private void enrollStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_EnrollStudentToCourse, (int)clsSettings.enEnrollmentsPermissions.Add);
        }  

        private void deleteStudentEnrollmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_UnenrollStudentFromCourse, (int)clsSettings.enEnrollmentsPermissions.Delete);
        }


        //Edit grade
        private void btnEditEditGrade_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_EditGrade, (int)clsSettings.enEnrollmentsPermissions.Add);
        }

        private void editGradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_EditGrade, (int)clsSettings.enEnrollmentsPermissions.Add);
        }


        //Finish course (complete)
        private void btnComplete_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_CompleteCourse, (int)clsSettings.enEnrollmentsPermissions.Add);
        }

        private void completeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_CompleteCourse, (int)clsSettings.enEnrollmentsPermissions.Add);
        }


        //Sub buttons
        private void btnCloseEditGrade_Click(object sender, EventArgs e)
        {
            gbEditGrade.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGrade.Text) || ckbNoGrade.Checked)
            {
                _SaveGrade();
            }
            else
                MessageBox.Show("Grade field is empty!", "Attention!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ckbNoGrade_CheckedChanged(object sender, EventArgs e)
        {
            //If checked clear and disable grade textBox
            if (ckbNoGrade.Checked)
            {
                txtGrade.Text = string.Empty;
                txtGrade.Enabled = false;
            }

            //If unchecked enable grade textBox
            else
            {
                txtGrade.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;//Ensure only digits allowed
        }

   
    }
}
