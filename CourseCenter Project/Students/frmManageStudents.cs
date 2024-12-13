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
    public partial class frmManageStudents : Form
    {
       
        private DataView _dvStudentsList = new DataView();

        private DataView _dvLevelsList = new DataView();

        private int _CurrentUserPermissions;

        private Action<Action, int> _CheckIfUserAccess;


        private void _StudentsSort()
        {
            string Filter = Convert.ToString(cbxStudentsSort.SelectedItem);
            _dvStudentsList.Sort = Filter + " Asc";
        }

        private void _LevelsSort()
        {
            string Filter = Convert.ToString(cbxLevelsSort.SelectedItem);
            _dvLevelsList.Sort = Filter + " Asc";
        }
        
        private void _PrepareSortComboBoxes()
        {
            //Set Default Index for ComboBoxes
            cbxStudentsSort.SelectedIndex = 0;
            cbxLevelsSort.SelectedIndex = 0;
        }
        
   

        private void _RefreshStudentsList()
        {
            _dvStudentsList = clsStudent.GetStudentsList().DefaultView;
            dgvStudentsList.DataSource = _dvStudentsList;
        }

        private void _PrepareLevelsList()
        {
            //Adjust columns widths
            dgvLevelsList.Columns["Description"].Width = 215;
        }

        private void _RefreshLevelsList()
        {
            _dvLevelsList = clsLevel.GetAllLevels().DefaultView;
            dgvLevelsList.DataSource = _dvLevelsList;
        }
        
        private void _Refresh()
        { 
            timer1.Enabled = true;
            lblTimeDate.Text = clsUtility.DateTimeString();

            _RefreshStudentsList();
            _RefreshLevelsList();

            _PrepareLevelsList();
        }

       
        private void _AddNewStudent()
        {
            frmAddUpdateStudent frm = new frmAddUpdateStudent(-1, _CheckIfUserAccess);
            frm.ShowDialog();

            _RefreshStudentsList();
        }

        private void _UpdateStudent()
        {
            if (dgvStudentsList.SelectedCells.Count > 0)
            {
                int SelectedStudentID = (int)dgvStudentsList.CurrentRow.Cells["StudentID"].Value;

                if (clsStudent.IsExist(SelectedStudentID))
                {
                    frmAddUpdateStudent frm = new frmAddUpdateStudent(SelectedStudentID, _CheckIfUserAccess);
                    frm.ShowDialog();

                    _RefreshStudentsList();
                }
                else
                    MessageBox.Show("Student ID Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("There is no Student Selected to Update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _DeleteStudent()
        {         
            if (dgvStudentsList.SelectedCells.Count > 0)
            {
                int SelectedStudentID = (int)dgvStudentsList.CurrentRow.Cells["StudentID"].Value;

                //Confirm deletion with the user
                if (MessageBox.Show($"Are you sure you want to delete Student with ID = {SelectedStudentID} ?", "Warning"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (clsStudent.Delete(SelectedStudentID))
                    {
                        MessageBox.Show("Student deleted successfully!", "Deleted", MessageBoxButtons.OK);

                        _RefreshStudentsList();
                    }
                    else
                        MessageBox.Show("Delete Operation Failed!, because the student has enrollments"
                        , "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("There is no Student Selected to Delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

       
        private void _AddNewLevel()
        {
            frmAddUpdateLevel frm = new frmAddUpdateLevel(-1);
            frm.ShowDialog();

            _RefreshLevelsList();
        }

        private void _UpdateLevel()
        {

            if (dgvLevelsList.SelectedCells.Count > 0)
            {
                int SelectedLevelID = (int)dgvLevelsList.CurrentRow.Cells["LevelID"].Value;

                if (clsLevel.IsExist(SelectedLevelID))
                {
                    frmAddUpdateLevel frm = new frmAddUpdateLevel(SelectedLevelID);
                    frm.ShowDialog();

                    _RefreshLevelsList();
                }
                else
                    MessageBox.Show($"Level ID = {SelectedLevelID} not found!", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("There is no Level selected!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void _DeleteLevel()
        {
            if (dgvLevelsList.SelectedCells.Count > 0)
            {
                int SelectedLevelID = (int)dgvLevelsList.CurrentRow.Cells["LevelID"].Value;

                //Confirm deletion with the user
                if (MessageBox.Show($"Are you sure you want to delete this level with ID = {SelectedLevelID}?", "Delete?"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsLevel.Delete(SelectedLevelID))
                    {
                        MessageBox.Show("Level deleted successfully!", "Deleted", MessageBoxButtons.OK);

                        _RefreshLevelsList();
                    }
                    else
                        MessageBox.Show($"Delete Level Operation failed!", "Error"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("There is no Level selected!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _ShowStudentEnrollments()
        {
            if (dgvStudentsList.SelectedCells.Count > 0)
            {
                int SelectedStudentID = (int)dgvStudentsList.CurrentRow.Cells["StudentID"].Value;

                if (clsStudent.IsExist(SelectedStudentID))
                {
                    frmStudentEnrollments frm = new frmStudentEnrollments(SelectedStudentID, _CheckIfUserAccess);
                    frm.ShowDialog();
                }
                else
                    MessageBox.Show("Student ID Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("There is no Student Selected to Show his/her Enrollments!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public frmManageStudents(int CurrentUserPermissions, Action<Action, int> CheckIfUserAccess)
        {
            InitializeComponent();
            
            _CurrentUserPermissions = CurrentUserPermissions;
            _CheckIfUserAccess = CheckIfUserAccess;
        }

        private void frmManageStudents_Load(object sender, EventArgs e)
        {
            _Refresh();
            _PrepareSortComboBoxes();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimeDate.Text = clsUtility.DateTimeString();
        }

        private void frmManageStudents_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
        }


        //Sorting checkBoxes
        private void cbxStudentsSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            _StudentsSort();
        }

        private void cbxLevelsSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            _LevelsSort();
        }


        //Manage students buttons
        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewStudent, (int)clsSettings.enStudentsPermissions.Add);
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_UpdateStudent, (int)clsSettings.enStudentsPermissions.Update);
        }


        //Manage Levels buttons
        private void btnAddNewLevel_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewLevel, (int)clsSettings.enStudentsPermissions.Add);
        }

        private void btnUpdateLevel_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_UpdateLevel, (int)clsSettings.enStudentsPermissions.Update);
        }


        //Manage students strip menu 
        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewStudent, (int)clsSettings.enStudentsPermissions.Add);
        }     

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_UpdateStudent, (int)clsSettings.enStudentsPermissions.Update);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_DeleteStudent, (int)clsSettings.enStudentsPermissions.Delete);
        }


        //Manage Levels strip menu 
        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewLevel, (int)clsSettings.enStudentsPermissions.Add);
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_UpdateLevel, (int)clsSettings.enStudentsPermissions.Update);
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_DeleteLevel, (int)clsSettings.enStudentsPermissions.Delete);
        }


        //Show student enrollments
        private void btnStudentEnrollments_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_ShowStudentEnrollments, (int)clsSettings.enEnrollmentsPermissions.Read);
        }

        private void showStudentEnrollmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_ShowStudentEnrollments, (int)clsSettings.enEnrollmentsPermissions.Read);
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
