using CourseCenterBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseCenter_Project
{
    public partial class frmManageEnrollments : Form
    {
        
        private DataView _dvEnrollmentsList = new DataView();

        private int _CurrentUserPermissions;

        private Action<Action, int> _CheckIfUserAccess;


        private void _EnrollmentSort()
        {
            if (dgvEnrollmentsList.Rows.Count > 0)
            {
                string Sort = Convert.ToString(cbxEnrollmentSort.SelectedItem);
                string Order = " Asc";
                if (rbDescending.Checked)
                    Order = " Desc";
                _dvEnrollmentsList.Sort = Sort + Order;
            }
        }


        private void _PrepareEnrollmentList()
        {
            //Adjust columns widths
            dgvEnrollmentsList.Columns["StartDate"].Width = 130;
            dgvEnrollmentsList.Columns["EndDate"].Width = 130;
        }

        private void _RefreshEnrollmentsList()
        {
            _dvEnrollmentsList = clsEnrollment.GetEnrollmentsList().DefaultView;
            dgvEnrollmentsList.DataSource = _dvEnrollmentsList;
        }

        private void _Refresh()
        {
            lblTimeDate.Text = clsUtility.DateTimeString();
            timer1.Enabled = true;

            _RefreshEnrollmentsList();

            _PrepareEnrollmentList();

            cbxEnrollmentSort.SelectedIndex = 0;//Set the default sort index for the ComboBox
        }
        

        private void _AddNewEnrollment()
        {
            frmAddUpdateEnrollment frm = new frmAddUpdateEnrollment(-1, _CheckIfUserAccess);
            frm.ShowDialog();

            _RefreshEnrollmentsList();
        }

        private void _UpdateEnrollment()
        {
            if (dgvEnrollmentsList.SelectedCells.Count > 0)
            {
                int SelectedEnrollmentID = (int)dgvEnrollmentsList.CurrentRow.Cells["EnrollmentID"].Value;

                if (clsEnrollment.IsExist(SelectedEnrollmentID))
                {
                    frmAddUpdateEnrollment frm = new frmAddUpdateEnrollment(SelectedEnrollmentID, _CheckIfUserAccess);
                    frm.ShowDialog();

                    _RefreshEnrollmentsList();
                }
                else
                    MessageBox.Show($"Enrollment with ID = {SelectedEnrollmentID} not found!", "No Result!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show($"There is no Enrollment selected!", "Error!"
                           , MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void _DeleteEnrollment()
        {
            if (dgvEnrollmentsList.SelectedCells.Count > 0)
            {
                int SelectedEnrollmentID = (int)dgvEnrollmentsList.CurrentRow.Cells["EnrollmentID"].Value;

                //Check if payment needs to be refunded
                if (!_CheckIfRefund(SelectedEnrollmentID))
                    return;

                //Confirm deletion with the user
                if (MessageBox.Show($"Are you sure you want to delete this Enrollment With ID = {SelectedEnrollmentID} ?", "Delete"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsEnrollment.IsExist(SelectedEnrollmentID))
                    {
                        
                        //Delete payment before enrollment as payment depends on enrollment
                        if (_DeletePayment(SelectedEnrollmentID) && clsEnrollment.Delete(SelectedEnrollmentID))
                        {
                            MessageBox.Show("Enrollment Deleted Successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            _RefreshEnrollmentsList();
                        }
                        else
                            MessageBox.Show("Enrollment Delete Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                        MessageBox.Show("Enrollment ID not found!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("There is no Enrollment selected!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        public frmManageEnrollments(int currentUserPermissions, Action <Action, int> CheckIfUserAccess)
        {
            InitializeComponent();

            _CurrentUserPermissions = currentUserPermissions;
            _CheckIfUserAccess = CheckIfUserAccess;
        }

    

        private void frmManageEnrollments_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void frmManageEnrollments_FormClosed (object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimeDate.Text = clsUtility.DateTimeString();
        }


        //Manage enrollments buttons
        private void btnAddNewEnrollment_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewEnrollment, (int)clsSettings.enEnrollmentsPermissions.Add);
        }

        private void btnUpdateEnrollment_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_UpdateEnrollment, (int)clsSettings.enEnrollmentsPermissions.Update);
        }

        private void btnDeleteEnrollment_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_DeleteEnrollment, (int)clsSettings.enEnrollmentsPermissions.Delete);
        }


        //Manage enrollments strip menu
        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewEnrollment, (int)clsSettings.enEnrollmentsPermissions.Add);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_UpdateEnrollment, (int)clsSettings.enEnrollmentsPermissions.Update);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_DeleteEnrollment, (int)clsSettings.enEnrollmentsPermissions.Delete);
        }


        //Sorting
        private void cbxEnrollmentSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            _EnrollmentSort();
        }
        
        private void rbAscending_CheckedChanged(object sender, EventArgs e)
        {
            _EnrollmentSort();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
