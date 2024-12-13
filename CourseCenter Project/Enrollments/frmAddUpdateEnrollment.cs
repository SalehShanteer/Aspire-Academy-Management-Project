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
    public partial class frmAddUpdateEnrollment : Form
    {

        private enum enMode { AddNew = 0, Update = 1}

        private enMode _Mode = enMode.AddNew;
        
        private int _EnrollmentID;
        
        private clsEnrollment _Enrollment;

        private clsStudent _Student = null;

        private clsCourse _Course = null;

        private clsPayment _Payment = new clsPayment();

        private Action<Action, int> _CheckIfUserAccess;



        private bool _ValidateStudentField()
        {
            if (_Student == null)
            {
                errorProvider1.SetError(txtFindByID, "Instructor field cannot be empty");
                return false;
            }

            return true;
        }

        private bool _ValidateCourseField()
        {
            if (_Course == null)
            {
                errorProvider1.SetError(cbxCourses, "Instructor field cannot be empty");
                return false;
            }

            return true;
        }

        private bool _ValidateAllRequiredFields()
        {
            bool IsValid = true;

            //Clear error
            errorProvider1.Clear();

            if (!_ValidateStudentField())
            {
                IsValid = false;
            }

            if (!_ValidateCourseField())
            {
                IsValid = false;
            }

            return IsValid;
        }


        private void _DisplayStudentInfo()
        {
            if (_Student != null)
            {
                //Display Student Info
                lblStudentID.Text = _Student.ID.ToString();
                lblPersonID.Text = _Student.PersonID.ToString();

                //Display Person for Getting Student Person info
                clsPerson _Person = clsPerson.Find(_Student.PersonID);
                lblStudentName.Text = _Person.FullName;
                lblGender.Text = _Person.Gender == "M" ? "Male" : "Female";
            
                //Display Level name
                lblLevel.Text = clsLevel.Find(_Student.LevelID).Name;

                //Enable edit student info link label
                llblEditStudentInfo.Enabled = true;
            }
        }
        
        private void _DisplayCourseInfo()
        {
            //Get Course Index and select it
            cbxCourses.SelectedIndex = cbxCourses.FindString(_Course.Name);

            lblCourseID.Text = _Course.ID.ToString();
            lblCourseName.Text = _Course.Name.ToString();
            lblInstructorID.Text = _Course.InstructorID.ToString();
            lblCreditHours.Text = _Course.CreditHours.ToString();
            lblCourseFee.Text = _Course.CourseFee.ToString();

            //Enable edit course info link label
            llblEditCourseInfo.Enabled = true;
        }
        
        private void _DisplayDiscountInfo()
        {
            tbarDiscount.Enabled = true;
            tbarDiscount.Value = 0;
            lblCostAfter.Text = lblCourseFee.Text;
        }

        private void _DisplayCourseAndDiscountInfo()
        {
            if (_Course != null)
            {
                _DisplayCourseInfo();
                _DisplayDiscountInfo();           
            }
            else
                MessageBox.Show("Course does not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        
        private void _LoadEnrollmentInfo()
        {
            _LoadCoursesComboBox();

            if (_Mode == enMode.AddNew)
            {
                lblAddUpdateEnrollment.Text = "Add New Enrollment";
                _Enrollment = new clsEnrollment();
            }
            else
            {
                lblAddUpdateEnrollment.Text = "Update Enrollment";
                
                //Retrieve Enrollment and related (Course, Student, Payment)
                _Enrollment = clsEnrollment.Find(_EnrollmentID);
                _Course = clsCourse.Find(_Enrollment.CourseID);
                _Student = clsStudent.Find(_Enrollment.StudentID);
                _Payment = clsPayment.FindByEnrollmentID(_Enrollment.ID);

                //Display Enrollment ID
                lblEnrollmentID.Text = _Enrollment.ID.ToString();
                 
                _DisplayStudentInfo();
                _DisplayCourseAndDiscountInfo();
            }
        }

        private void _LoadCoursesComboBox()
        {
            //Fill ComboBox from courses
            DataTable dtCourses = clsCourse.GetCompletedCourses();
            foreach (DataRow row in dtCourses.Rows)
            {
                string Course = row["Name"].ToString() + "/(" + row["CourseID"] + ")";
                cbxCourses.Items.Add(Course);
            }
        }


        private void _AddNewStudent()
        {
            frmAddUpdateStudent frm = new frmAddUpdateStudent(-1, _CheckIfUserAccess);
            frm.ShowDialog();
        }

        private void _UpdateStudent()
        {
            frmAddUpdateStudent frm = new frmAddUpdateStudent(_Student.ID, _CheckIfUserAccess);
            frm.ShowDialog();

            _Student = clsStudent.Find(_Student.ID);
            _DisplayStudentInfo();
        }


        private void _AddNewCourse()
        {
            frmAddUpdateCourse frm = new frmAddUpdateCourse(-1, _CheckIfUserAccess);
            frm.ShowDialog();
        }

        private void _UpdateCourse()
        {
            frmAddUpdateCourse frm = new frmAddUpdateCourse(_Course.ID, _CheckIfUserAccess);
            frm.ShowDialog();

            //Retrieve and load course info
            _Course = clsCourse.Find(_Course.ID);
            _DisplayCourseAndDiscountInfo();
        }


        private void _SearchStudent()
        {
            int StudentID = Convert.ToInt32(txtFindByID.Text);

            if (clsStudent.IsExist(StudentID))
            {
                //Retrieve and load student info
                _Student = clsStudent.Find(StudentID);
                _DisplayStudentInfo();
            }
            else
                MessageBox.Show($"There is no student exist with this ID = {StudentID}", "Error"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _SavePayment()
        {
            //Fill Payment with information
            _Payment.StudentID = _Enrollment.StudentID;
            _Payment.EnrollmentID = _Enrollment.ID;
            _Payment.OriginalCost = _Course.CourseFee;
            _Payment.DiscountPercentage = (byte)tbarDiscount.Value;

            if (_Payment.Save())
            {
                //If payment saved successfully this will send notification
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipTitle = "Payments";
                notifyIcon1.BalloonTipText = "Payment Record Saved Successfully";
                notifyIcon1.ShowBalloonTip(2000);
            }
            else
            {
                //If payment save failed this will send notification
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                notifyIcon1.BalloonTipTitle = "Payments";
                notifyIcon1.BalloonTipText = "Payment Record Save Failed";
                notifyIcon1.ShowBalloonTip(2000);
            }
        }

        private void _SaveEnrollment()
        {
            if (_Enrollment.Save())
            {
                MessageBox.Show("Enrollment Saved successfully!", "Saved"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Should save payment after enrollment
                _SavePayment();

                //Display update title and Enrollment ID 
                lblAddUpdateEnrollment.Text = "Update Enrollment";
                lblEnrollmentID.Text = _Enrollment.ID.ToString();

                _Mode = enMode.Update;
            }
            else
                MessageBox.Show("Enrollment Save Failed!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private bool _IsStudentSameAsInstructor()
        {
            return _Student.PersonID == clsInstructor.GetPersonID(_Course.InstructorID);
        }

        private bool _IsStudentAndCourseSelected()
        {
            return _Student.ID != -1 && _Course.ID != -1;
        }

        private void _SetEnrollmentDetails()
        {
            _Enrollment.StudentID = _Student.ID;
            _Enrollment.CourseID = _Course.ID;
        }

        private void _Save()
        {

            if (_IsStudentAndCourseSelected())
            {
                if (_IsStudentSameAsInstructor())
                {
                    MessageBox.Show("Student and Instructor of the course is the same person!", "Attention"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _SetEnrollmentDetails();

                if (_Mode == enMode.AddNew)
                {
                    _Enrollment.StartDate = DateTime.Now;
                }

                _SaveEnrollment();
            }
            else
                MessageBox.Show("Student Or Course not selected, please choose them to complete this operation."
                    , "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public frmAddUpdateEnrollment(int EnrollmentID, Action <Action, int> CheckIfUserAccess, int CourseID = -1, int StudentID = -1)
        {
            InitializeComponent();

            _EnrollmentID = EnrollmentID;
            _CheckIfUserAccess = CheckIfUserAccess;

            if (_EnrollmentID != -1)
                _Mode = enMode.Update;
            else
            {
                _Mode = enMode.AddNew;
               
                if (CourseID != -1)
                {
                    //Retrieve and display course info
                    _Course = clsCourse.Find(CourseID);
                    _DisplayCourseAndDiscountInfo();
                }
                if (StudentID != -1)
                {
                    //Retrieve and display course info
                    _Student = clsStudent.Find(StudentID);
                    _DisplayStudentInfo();
                }
            }
            
        }

        private void frmAddUpdateEnrollment_Load(object sender, EventArgs e)
        {
            _LoadEnrollmentInfo();
        }


        //Manage courses
        private void btnAddNewCourse_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewCourse, (int)clsSettings.enCoursesPermissions.Add);
        }

        private void llblEditCourseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _CheckIfUserAccess(_UpdateCourse, (int)clsSettings.enCoursesPermissions.Update);
        }


        //Manage students
        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewStudent, (int)clsSettings.enStudentsPermissions.Add);
        }

        private void llblEditStudentInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _CheckIfUserAccess(_UpdateStudent, (int)clsSettings.enStudentsPermissions.Add);
        }


        //Save enrollment
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (_ValidateAllRequiredFields())
            {
                if (MessageBox.Show("Do you want to save Enrollment info?", "Save?"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _Save();
                }
            }
            else
            {
                MessageBox.Show(clsSettings.InvalidErrorMessage, "Attention"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            _SearchStudent();
        }


        //Sub
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tcEnrollment.SelectedIndex = 1;//Go next to course page 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcEnrollment.SelectedIndex = 0;//Go back to Student page
        }

        private void tcEnrollment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Enable and disable navigation and save buttons
            if (tcEnrollment.SelectedIndex == 0)
            {
                //Student page
                btnNext.Enabled = true;
                btnBack.Enabled = false;
                btnSave.Enabled = false;
            }
            else
            {
                //Course page
                btnNext.Enabled = false;
                btnBack.Enabled = true;
                btnSave.Enabled = true;
            }
        }
     
        private void txtFindByID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;//Ensure only digits allowed
            }
        }
     
        private void txtFindByID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Press enter ==> search
                e.SuppressKeyPress = true;
                _SearchStudent();
            }
        }

        private void cbxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCourses.SelectedIndex != -1)
            {
                string[] Course = cbxCourses.SelectedItem.ToString().Split('/');//split to get courseID
                //Retrieve course info
                _Course = clsCourse.Find(Course[0]);
                _DisplayCourseAndDiscountInfo();
            }
        }
      
        private void tbarDiscount_ValueChanged(object sender, EventArgs e)
        {
            //Display discount and cost after 
            lblDiscountValue.Text = tbarDiscount.Value.ToString() + "%";
            float CostAfter = Convert.ToSingle(_Course.CourseFee) * (1 - (Convert.ToSingle(tbarDiscount.Value) / 100.0f));
            lblCostAfter.Text = CostAfter.ToString();
        }

       
    }
}
