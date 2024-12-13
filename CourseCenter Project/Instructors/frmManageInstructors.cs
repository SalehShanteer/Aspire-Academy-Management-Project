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
    public partial class frmManageInstructors : Form
    {
        
        private DataView _dvInstructorsList = new DataView();

        private DataView _dvSpecializations = new DataView();

        private Action<Action, int> _CheckIfUserAccess;

        private int _CurrentUserPermissions;


        private void _PrepareSortComboBoxes()
        {
            cbxInstructorsSort.SelectedIndex = 0;
            cbxSpecializationsSort.SelectedIndex = 0;
        }
        
        private void _InstructorSort()
        {
            string Filter = Convert.ToString(cbxInstructorsSort.SelectedItem);
            string Order = "Asc";
            if (rbDescending.Checked)
                Order = "Desc";
            _dvInstructorsList.Sort = Filter + " " + Order;
        }

        private void _SpecializationSort()
        {
            string Filter = Convert.ToString(cbxSpecializationsSort.SelectedItem);
            _dvSpecializations.Sort = Filter + " Asc";
        }

        
        private void _PrepareInstructorsList()
        {
            //Adjust columns widths
            dgvInstructorsList.Columns["InstructorID"].Width = 70;
            dgvInstructorsList.Columns["PersonID"].Width = 63;
            dgvInstructorsList.Columns["SpecializationID"].Width = 88;
            dgvInstructorsList.Columns["Salary"].Width = 67;
        }

        private void _RefreshInstructorsList()
        {
            _dvInstructorsList = clsInstructor.GetInstructorsList().DefaultView;
            dgvInstructorsList.DataSource = _dvInstructorsList;
        }

        private void _PerepareSpecializationsList()
        {
            //Adjust columns widths
            dgvSpecializationsList.Columns["SpecializationID"].Width = 88;
            dgvSpecializationsList.Columns["Description"].Width = 130;
        }

        private void _RefreshSpecializationsList()
        {
            _dvSpecializations = clsSpecialization.GetAllSpecializations().DefaultView;
            dgvSpecializationsList.DataSource = _dvSpecializations;
        }

        private void _Refresh()
        {
            timer1.Enabled = true;
            lblTimeDate.Text = clsUtility.DateTimeString();

            _RefreshInstructorsList();
            _RefreshSpecializationsList();

            _PrepareInstructorsList();
            _PerepareSpecializationsList();
        }

        
        private void _AddNewInstructor()
        {
            frmAddUpdateInstructor frm = new frmAddUpdateInstructor(-1, _CheckIfUserAccess);
            frm.ShowDialog();

            _RefreshInstructorsList();
        }

        private void _UpdateInstructor()
        {
            if (dgvInstructorsList.SelectedCells.Count > 0)
            {
                int InstructorID = (int)dgvInstructorsList.CurrentRow.Cells["InstructorID"].Value;

                if (clsInstructor.IsExist(InstructorID))
                {
                    frmAddUpdateInstructor frm = new frmAddUpdateInstructor(InstructorID, _CheckIfUserAccess);
                    frm.ShowDialog();

                    _Refresh();
                }
                else
                    MessageBox.Show("Instructor ID not found!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("There is no Instructor selected!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _DeleteInstructor()
        {
            if (dgvInstructorsList.SelectedCells.Count > 0)
            {
                int InstructorID = (int)dgvInstructorsList.CurrentRow.Cells["InstructorID"].Value;

                //Confirm deletion with the user
                if (MessageBox.Show($"Are you sure you want to delete this Instructor with ID = {InstructorID} ?", "Delete"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsInstructor.IsExist(InstructorID))
                    {
                        clsInstructor.Delete(InstructorID);

                        _RefreshInstructorsList();
                    }
                    else
                        MessageBox.Show("Instructor ID not found!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("There is no Instructor selected!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void _AddNewSpecialization()
        {
            frmAddUpdateSpecialization frm = new frmAddUpdateSpecialization(-1);
            frm.ShowDialog();

            _RefreshSpecializationsList();
        }

        private void _UpdateSpecialization()
        {
            if (dgvSpecializationsList.SelectedCells.Count > 0)
            {
                int SpecializationID = (int)dgvSpecializationsList.CurrentRow.Cells["SpecializationID"].Value;

                if (clsSpecialization.IsExist(SpecializationID))
                {
                    frmAddUpdateSpecialization frm = new frmAddUpdateSpecialization(SpecializationID);
                    frm.ShowDialog();

                    _RefreshSpecializationsList();
                }
                else
                    MessageBox.Show("Specialization ID not found!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("There is no Specialization selected!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _DeleteSpecialization()
        {
            if (dgvSpecializationsList.SelectedCells.Count > 0)
            {
                int SpecializationID = (int)dgvSpecializationsList.CurrentRow.Cells["SpecializationID"].Value;

                //Confirm deletion with the user
                if (MessageBox.Show($"Are you sure you want to delete this Specialization With ID = {SpecializationID}", "Delete"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsSpecialization.IsExist(SpecializationID))
                    {
                        clsSpecialization.Delete(SpecializationID);

                        _RefreshSpecializationsList();
                    }
                    else
                        MessageBox.Show("Specialization ID not found!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("There is no Specialization selected!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void _ShowInstructorCourses()
        {
            if (dgvInstructorsList.SelectedCells.Count > 0)
            {
                int InstructorID = (int)dgvInstructorsList.CurrentRow.Cells["InstructorID"].Value;

                if (clsInstructor.IsExist(InstructorID))
                {
                    frmInstructorCourses frm = new frmInstructorCourses(InstructorID, _CheckIfUserAccess);
                    frm.ShowDialog();
                }
                else
                    MessageBox.Show("Instructor ID not found!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("There is no Instructor selected!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

       
        public frmManageInstructors(int CurrentUserPermissions, Action<Action, int> CheckIfUserAccess)
        {
            InitializeComponent();

            _CurrentUserPermissions = CurrentUserPermissions;
            _CheckIfUserAccess = CheckIfUserAccess;
        }

        private void frmManageInstructors_Load(object sender, EventArgs e)
        {
            _Refresh();
            _PrepareSortComboBoxes();
        }

        private void frmManageInstructors_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimeDate.Text = clsUtility.DateTimeString();
        }


        //Manage instructors buttons
        private void btnAddNewInstructor_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewInstructor, (int)clsSettings.enInstructorsPermissions.Add);
        }

        private void btnUpdateInstructor_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_UpdateInstructor, (int)clsSettings.enInstructorsPermissions.Update);
        }


        //Manage specializations buttons
        private void btnAddNewSpecialization_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewSpecialization, (int)clsSettings.enInstructorsPermissions.Add);
        }

        private void btnUpdateSpecialization_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_UpdateSpecialization, (int)clsSettings.enInstructorsPermissions.Update);
        }


        //Manage Instructors strip menu
        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewInstructor, (int)clsSettings.enInstructorsPermissions.Add);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_UpdateInstructor, (int)clsSettings.enInstructorsPermissions.Update);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_DeleteInstructor, (int)clsSettings.enInstructorsPermissions.Delete);
        }


        //Manage specializations strip menu
        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewSpecialization, (int)clsSettings.enInstructorsPermissions.Add);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_UpdateSpecialization, (int)clsSettings.enInstructorsPermissions.Update);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_DeleteSpecialization, (int)clsSettings.enInstructorsPermissions.Delete);
        }


        //Manage instructor courses
        private void btnInstructorCourses_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_ShowInstructorCourses, (int)clsSettings.enCoursesPermissions.Read);
        }

        private void showInstructorCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_ShowInstructorCourses, (int)clsSettings.enCoursesPermissions.Read);
        }


        //Sorting
        private void cbxInstructorsSort_SelectedValueChanged(object sender, EventArgs e)
        {
            _InstructorSort();
        }

        private void cbxSpecializationsSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SpecializationSort();
        }

        private void rbAscending_CheckedChanged(object sender, EventArgs e)
        {
            _InstructorSort();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
