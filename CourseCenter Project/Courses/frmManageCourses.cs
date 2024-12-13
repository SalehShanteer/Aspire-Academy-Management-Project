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
    public partial class frmManageCourses : Form
    {

        private DataView _dvCoursesList = new DataView();

        private int _CurrentUserPermissions;

        private Action<Action, int> _CheckIfUserAccess;


        private void _DisplaySummaryList()
        {
            lblNumberOfStudentsAttend.Text = clsEnrollment.CountActiveStudent().ToString();
            lblNumberOfInstructorsTeach.Text = clsCourse.CountInstructors().ToString();
        }

        private void _SearchByName()
        {
            //Set filter for Courses List 
            if (!string.IsNullOrWhiteSpace(txtSearchByName.Text))
                _dvCoursesList.RowFilter = $"Name like '{txtSearchByName.Text}%'";
            else
                _dvCoursesList.RowFilter = string.Empty;   
        }
        
        private void _CoursesSort()
        {
            string Sort = Convert.ToString(cbxCoursesSort.SelectedItem);
            string Order = " Asc";
            if (rbDescending.Checked)
                Order = " Desc";
            _dvCoursesList.Sort = Sort + Order;
        }

        
        private void _PrepareCoursesList()
        {
            //Adjust columns widths
            dgvCoursesList.Columns["CourseID"].Width = 80;
            dgvCoursesList.Columns["InstructorID"].Width = 80;
            dgvCoursesList.Columns["Name"].Width = 133;
            dgvCoursesList.Columns["CourseFee"].Width = 70;
        }

        private void _RefreshCoursesList()
        {
            _dvCoursesList = clsCourse.GetCoursesList().DefaultView;
            dgvCoursesList.DataSource = _dvCoursesList;

            //Display number of courses
            lblNumberOfCourses.Text = clsCourse.Count().ToString();
        }

        private void _Refresh()
        {
            timer1.Enabled = true;
            lblTimeDate.Text = clsUtility.DateTimeString();

            _DisplaySummaryList();
            _RefreshCoursesList();

            _PrepareCoursesList();
        }


        private void _ShowActiveStudentsList()
        {
            frmActiveStudentsInCoursesList frm = new frmActiveStudentsInCoursesList();
            frm.ShowDialog();
        }

        private void _ShowStudentsEnrolledInCourse()
        {
            if (dgvCoursesList.SelectedCells.Count > 0)
            {
                int CourseID = Convert.ToInt32(dgvCoursesList.CurrentRow.Cells["CourseID"].Value);
                string CourseName = Convert.ToString(dgvCoursesList.CurrentRow.Cells["Name"].Value);

                if (clsCourse.IsExist(CourseID))
                {
                    frmStudentsEnrolledInCourse frm = new frmStudentsEnrolledInCourse(CourseID, CourseName, _CheckIfUserAccess);
                    frm.ShowDialog();
                }
                else
                    MessageBox.Show("Course ID not found!!", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("There is no Course selected!!", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void _AddNewCourse()
        {
            frmAddUpdateCourse frm = new frmAddUpdateCourse(-1, _CheckIfUserAccess);
            frm.ShowDialog();

            _Refresh();
        }

        private void _UpdataCourse()
        {
            if (dgvCoursesList.SelectedCells.Count > 0)
            {
                int CourseID = (int)dgvCoursesList.CurrentRow.Cells["CourseID"].Value;

                if (clsCourse.IsExist(CourseID))
                {
                    frmAddUpdateCourse frm = new frmAddUpdateCourse(CourseID, _CheckIfUserAccess);
                    frm.ShowDialog();

                    _Refresh();
                }
                else
                    MessageBox.Show("Course ID not found!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("There is no Course selected!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _DeleteCourse()
        {
            if (dgvCoursesList.SelectedCells.Count > 0)
            {
                int CourseID = (int)dgvCoursesList.CurrentRow.Cells["CourseID"].Value;

                //Confirm deletion with the user
                if (MessageBox.Show($"Are you sure you want to delete this Course With ID = {CourseID} ?", "Delete"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsCourse.IsExist(CourseID))
                    {
                        clsCourse.Delete(CourseID);

                        _RefreshCoursesList();
                    }
                    else
                        MessageBox.Show("Course ID not found!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("There is no Course selected!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public frmManageCourses(int currentUserPermissions, Action<Action, int> CheckIfUserAccess)
        {
            InitializeComponent();

            _CurrentUserPermissions = currentUserPermissions;
            _CheckIfUserAccess = CheckIfUserAccess;
        }

        private void frmManageCourses_Load(object sender, EventArgs e)
        {
            _Refresh();
            cbxCoursesSort.SelectedIndex = 0;//Set it as a default index           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimeDate.Text = clsUtility.DateTimeString();
        }

        private void frmManageCourses_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
        }

        //Sorting and search
        private void cbxCoursesSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            _CoursesSort();
        }

        private void rbAscending_CheckedChanged(object sender, EventArgs e)
        {
            _CoursesSort();
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            _SearchByName();
        }


        //Manage courses buttons
        private void btnAddNewCourse_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewCourse, (int)clsSettings.enCoursesPermissions.Add);
        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_UpdataCourse, (int)clsSettings.enCoursesPermissions.Update);
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_DeleteCourse, (int)clsSettings.enCoursesPermissions.Delete);
        }


        //Manage courses strip menu
        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewCourse, (int)clsSettings.enCoursesPermissions.Add);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_UpdataCourse, (int)clsSettings.enCoursesPermissions.Update);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_DeleteCourse, (int)clsSettings.enCoursesPermissions.Delete);
        }


        //Show active students list 
        private void btnActiveStudentsList_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_ShowActiveStudentsList, (int)clsSettings.enStudentsPermissions.Read);
        }

        private void ShowActiveStudentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_ShowActiveStudentsList, (int)clsSettings.enStudentsPermissions.Read);
        }


        //Show students enrolled in course
        private void btnStudentsEnrolledInCourse_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_ShowStudentsEnrolledInCourse, (int)clsSettings.enEnrollmentsPermissions.Read);
        }
       
        private void showStudentsEnrolledInCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_ShowStudentsEnrolledInCourse, (int)clsSettings.enEnrollmentsPermissions.Read);
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
    