using CourseCenterBusinessLayer;
using Guna.UI2.WinForms;
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
    public partial class frmAddUpdateCourse : Form
    {
        
        private enum enMode { AddNew = 0, Update = 1 }

        private enMode _Mode = enMode.AddNew;

        private clsCourse _Course;

        private int _CourseID;

        private clsInstructor _Instructor = null;

        private Action<Action, int> _CheckIfUserAccess;



        private bool _ValidateInstructorField()
        {
            if (_Instructor == null)
            {
                errorProvider1.SetError(txtFindByID, "Instructor field cannot be empty");
                return false;
            }
            return true;
        }

        private bool _ValidateNameField()
        {
            if (string.IsNullOrWhiteSpace(txtCourseName.Text))
            {
                errorProvider1.SetError(txtCourseName, $"Course name cannot be empty");
                return false;
            }
            return true;
        }

        private bool _ValidateAllRequiredFields()
        {
            //Clear error
            errorProvider1.Clear();

            bool IsValid = true;

            if (!_ValidateInstructorField())
            {
                IsValid = false;
            }

            if (!_ValidateNameField())
            {
                IsValid = false;
            }

            return IsValid;
        }

        private void _DisplayInstructorInfo()
        {
            lblInstructorID.Text = _Instructor.ID.ToString();
            lblPersonID.Text = _Instructor.PersonID.ToString();
            if (clsSpecialization.IsExist(_Instructor.SpecializationID))
                lblSpecialization.Text = clsSpecialization.Find(_Instructor.SpecializationID).Name;
            else
                lblSpecialization.Text = "N/A";
            if (_Instructor.Salary != -1)
                lblSalary.Text = _Instructor.Salary.ToString();
            else
                lblSalary.Text = "N/A";
            if (_Instructor.Certificates != string.Empty)
                lblCertificates.Text = _Instructor.Certificates;
            else
                lblCertificates.Text = "N/A";
        }

        private void _DisplayCourseInfo()
        {
            lblCourseID.Text = _Course.ID.ToString();
            txtCourseName.Text = _Course.Name;
            if (_Course.CourseFee != -1)
                txtCourseFee.Text = _Course.CourseFee.ToString();
            else
                txtCourseFee.Text = string.Empty;
            if (_Course.CreditHours != -1)
                txtCreditHours.Text = _Course.CreditHours.ToString();
            else
                txtCreditHours.Text = string.Empty;
        }
              

        private void _LoadInstructorInfo()
        {
            if (_Instructor != null)
            {
                _DisplayInstructorInfo();

                //Enable edit Instructor info link label
                llblEditInstructorInfo.Enabled = true;
            }
            else
                MessageBox.Show("Instuctor Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _LoadCourseInfo()
        {
            if (_Mode == enMode.AddNew)
            {
                //Change Title To Add new
                lblAddUpdateCourse.Text = "Add New Course";

                _Course = new clsCourse();
            }
            else
            {
                //Change Title To Update
                lblAddUpdateCourse.Text = "Update Course";

                //Retrieve course and instructor info 
                _Course = clsCourse.Find(_CourseID);
                _Instructor = clsInstructor.Find(_Course.InstructorID);

                _DisplayCourseInfo();
                _LoadInstructorInfo();
            }
        }


        private void _AddNewInstructor()
        {
            frmAddUpdateInstructor frm = new frmAddUpdateInstructor(-1, _CheckIfUserAccess);
            frm.ShowDialog();
        }
       
        private void _UpdateInstructorInfo()
        {
            if (clsInstructor.IsExist(_Instructor.ID))
            {
                frmAddUpdateInstructor frm = new frmAddUpdateInstructor(_Instructor.ID, _CheckIfUserAccess);
                frm.ShowDialog();

                //Retrieve and display Instructor info
                _Instructor = clsInstructor.Find(_Instructor.ID);
                _LoadInstructorInfo();
            }
            else
                MessageBox.Show("Instructor ID not found!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void _SearchInstructor()
        {
            if (!string.IsNullOrWhiteSpace(txtFindByID.Text))
            {
                int InstructorID = Convert.ToInt32(txtFindByID.Text);

                if (clsInstructor.IsExist(InstructorID))
                {
                    //Retrieve and display Instructor info
                    _Instructor = clsInstructor.Find(InstructorID);
                    _LoadInstructorInfo();
                }
                else
                    MessageBox.Show($"Instructor With ID = {InstructorID} Does Not Exist!", "Not Exist"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show($"You might br not enter Instructor ID!", "Attention!"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
        } 

        private void _SetCourseDetails()
        {
            //Fill Course with Info
            _Course.Name = txtCourseName.Text;
            _Course.InstructorID = Convert.ToInt32(lblInstructorID.Text);

            if (txtCreditHours.Text != string.Empty)
                _Course.CreditHours = Convert.ToInt16(txtCreditHours.Text);
            else
                _Course.CreditHours = -1;

            if (txtCourseFee.Text != string.Empty)
                _Course.CourseFee = Convert.ToDecimal(txtCourseFee.Text);
            else
                _Course.CourseFee = -1;
        }

        private void _Save()
        {
            
            _SetCourseDetails();

            if (_Course.Save())
            {
                MessageBox.Show("Course Saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblAddUpdateCourse.Text = "Update Course";
                lblCourseID.Text = _Course.ID.ToString();
                
                _Mode = enMode.Update;
            }
            else
                MessageBox.Show("Course Save Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public frmAddUpdateCourse(int CourseID, Action <Action, int> CheckIfUserAccess, int InstructorID = -1)
        {
            InitializeComponent();

            _CourseID = CourseID;
            _CheckIfUserAccess = CheckIfUserAccess;

            if (CourseID != -1)
                _Mode = enMode.Update;
            else
                _Mode = enMode.AddNew;

            if (InstructorID != -1)
            {
                //Retrieve and display Instructor info
                _Instructor = clsInstructor.Find(InstructorID);
                _LoadInstructorInfo();
            }
        }

        private void frmAddUpdateCourse_Load(object sender, EventArgs e)
        {
            _LoadCourseInfo();
        }
      
        
        //Manage instructors
        private void btnAddInstructor_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewInstructor, (int)clsSettings.enInstructorsPermissions.Add);
        }

        private void llblEditInstructorInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _CheckIfUserAccess(_UpdateInstructorInfo, (int)clsSettings.enInstructorsPermissions.Update);
        }


        //Setting and saving course
        private void btnSearchInstructor_Click(object sender, EventArgs e)
        {
            _SearchInstructor();
        }    
    
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_ValidateAllRequiredFields())
            {
                if (MessageBox.Show("Do you want to save Course info?", "Save?"
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


        //Sub
        private void txtFindByID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Press enter ==> Search 
                e.SuppressKeyPress = true;
                _SearchInstructor();
            }
        }

        private void txtCreditHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;//Ensure only digits allow
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCourseFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;//Ensure only digits allow
        }

        private void txtFindByID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;//Ensure only digits allow
        }


    }
}
