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
    public partial class frmInstructorCourses : Form
    {
       
        private DataView _dvInstructorCourses = new DataView();

        private int _InstructorID;

        private Action<Action, int> _CheckIfUserAccess;


        private void _RefreshInstructorCourses()
        {
            _dvInstructorCourses = clsCourse.GetInstructorCourses(_InstructorID).DefaultView;
            dgvInstructorCourses.DataSource = _dvInstructorCourses;
        }

        private void _Refresh()
        {
           _RefreshInstructorCourses();

            //Display Instructor ID and number of courses
            lblInstructorID.Text = _InstructorID.ToString();
            lblNumberOfCourses.Text = clsCourse.CountInstructorCourses(_InstructorID).ToString();
        }
        

        private void _AddNewCourse()
        {
            frmAddUpdateCourse frm = new frmAddUpdateCourse(-1, _CheckIfUserAccess, _InstructorID);
            frm.ShowDialog();

            _Refresh();
        }

        private void _UpdateCourse()
        {
            if (dgvInstructorCourses.SelectedCells.Count > 0)
            {
                int CourseID = (int)dgvInstructorCourses.CurrentRow.Cells["CourseID"].Value;

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
            if (dgvInstructorCourses.SelectedCells.Count > 0)
            {
                int CourseID = (int)dgvInstructorCourses.CurrentRow.Cells["CourseID"].Value;

                //Confirm deletion with the user
                if (MessageBox.Show($"Are you sure you want to delete this course with ID = {CourseID} ?", "Warning"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (clsCourse.IsExist(CourseID))
                    {
                        clsCourse.Delete(CourseID);
                        _Refresh();
                    }
                    else
                        MessageBox.Show("Course ID not found!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("There is no Course selected!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        public frmInstructorCourses(int InstructorID, Action<Action, int> checkIfUserAccess)
        {
            InitializeComponent();
            _InstructorID = InstructorID;
            _CheckIfUserAccess = checkIfUserAccess;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInstructorCourses_Load(object sender, EventArgs e)
        {
            _Refresh();
        }


        //Manage instructor courses button
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewCourse, (int)clsSettings.enCoursesPermissions.Add);
        }


        //Manage instructor courses strip menu
        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewCourse, (int)clsSettings.enCoursesPermissions.Add);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_UpdateCourse, (int)clsSettings.enCoursesPermissions.Update);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_DeleteCourse, (int)clsSettings.enCoursesPermissions.Delete);
        }
    }
}
