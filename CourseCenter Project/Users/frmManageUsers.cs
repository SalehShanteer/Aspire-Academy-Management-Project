using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseCenterBusinessLayer;

namespace CourseCenter_Project
{
    public partial class frmManageUsers : Form
    {
              
        private DataView _dvUsersList = new DataView();

        private DataView _dvRolesList = new DataView();

        private int _CurrentUserPermissions;

        private Action <Action, int> _CheckIfUserAccess;
       


        private void _PrepareUserList()
        {
            //Adjust columns widths
            dgvUsersList.Columns["UserID"].Width = 65;
            dgvUsersList.Columns["PersonID"].Width = 70;
            dgvUsersList.Columns["RoleID"].Width = 70;
            dgvUsersList.Columns["Password"].Width = 150;
            dgvUsersList.Columns["DateCreated"].Width = 120;
            dgvUsersList.Columns["LastLogin"].Width = 120;
            dgvUsersList.Columns["IsActive"].Width = 60;
        }

        private void _RefreshUsersList()
        {
            _dvUsersList = clsUser.GetUsersList().DefaultView;
            dgvUsersList.DataSource = _dvUsersList;
        }

        private void _PrepareRolesList()
        {
            //Adjust columns widths
            dgvRolesList.Columns["Description"].Width = 200;
        }

        private void _RefreshRolesList()
        {
            _dvRolesList = clsRole.GetAllRoles().DefaultView;
            dgvRolesList.DataSource = _dvRolesList;
        }

        private void _Refresh()
        {
            timer1.Enabled = true;
            lblTimeDate.Text = clsUtility.DateTimeString();

            cbxSearchFilter.SelectedIndex = 0;//Set default index for comboBox

            _RefreshUsersList();
            _RefreshRolesList();

            _PrepareUserList();
            _PrepareRolesList();
        }


        private void _Filter()
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                string SelectedFilter = cbxSearchFilter.Text;
                string SearchedText = txtSearch.Text;

                if (SelectedFilter != "Username")
                {
                    _dvUsersList.RowFilter = $"{SelectedFilter} = {SearchedText}";
                }
                else
                {
                    _dvUsersList.RowFilter = $"{SelectedFilter} like '{SearchedText}%'";
                }

            }
            else
            {
                _dvUsersList.RowFilter = string.Empty;
            }
        }


        private void _AddNewUser()
        {
            frmAddUpdateUser frm = new frmAddUpdateUser(-1, _CheckIfUserAccess);
            frm.ShowDialog();

            _RefreshUsersList();
        }

        private void _UpdateUser()
        {
            if (dgvUsersList.SelectedCells.Count > 0)
            {
                int SelectedUserID = (int)dgvUsersList.CurrentRow.Cells["UserID"].Value;

                if (clsUser.IsExist(SelectedUserID))
                {
                    frmAddUpdateUser frm = new frmAddUpdateUser(SelectedUserID, _CheckIfUserAccess);
                    frm.ShowDialog();
                    _RefreshUsersList();
                }
                else
                {
                    MessageBox.Show($"User with ID = {SelectedUserID} not found!", "Error!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("There is no user selected.", "Attention"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _DeleteUser()
        {
            if (dgvUsersList.SelectedCells.Count > 0)
            {
                int SelectedUserID = (int)dgvUsersList.CurrentRow.Cells["UserID"].Value;

                //Confirm deletion with the user
                if (MessageBox.Show($"Are you sure you want to delete User with ID = {SelectedUserID} ?", "Warning"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                {
                    if (clsUser.Delete(SelectedUserID))
                    {
                        MessageBox.Show("User deleted successfully!", "Deleted", MessageBoxButtons.OK);

                        _RefreshUsersList();
                    }
                    else
                    {
                        MessageBox.Show("Delete Operation Failed!", "Failed!"
                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            else
                MessageBox.Show("There is no user selected.", "Attention"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void _AddNewRole()
        {
            frmAddUpdateRole frm = new frmAddUpdateRole(-1);
            frm.ShowDialog();

            _RefreshRolesList();
        }

        private void _UpdateRole()
        {
            if (dgvRolesList.SelectedCells.Count > 0)
            {
                int SelectedRoleID = (int)dgvRolesList.CurrentRow.Cells["RoleID"].Value;

                if (clsRole.IsExist(SelectedRoleID))
                {
                    frmAddUpdateRole frm = new frmAddUpdateRole(SelectedRoleID);
                    frm.ShowDialog();

                    _RefreshRolesList();
                }
                else
                {
                    MessageBox.Show($"Role with ID = {SelectedRoleID} not found!", "Error!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("There is no Role selected.", "Attention"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _DeleteRole()
        {
            if (dgvRolesList.SelectedCells.Count > 0)
            {
                int SelectedRoleID = (int)dgvRolesList.CurrentRow.Cells["RoleID"].Value;

                //Confirm deletion with the user
                if (MessageBox.Show($"Are you sure you want to delete Role with ID = {SelectedRoleID} ?", "Warning"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                {
                    if (clsRole.Delete(SelectedRoleID))
                    {
                        MessageBox.Show("Role deleted successfully!", "Deleted", MessageBoxButtons.OK);

                        _RefreshRolesList();
                    }
                    else
                    {
                        MessageBox.Show("Delete Operation Failed!", "Failed!"
                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            else
                MessageBox.Show("There is no Role selected.", "Attention"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        
        public frmManageUsers(int CurrentUserPermissions, Action <Action, int> CheckIfUserAccess)
        {
            InitializeComponent();

            _CurrentUserPermissions = CurrentUserPermissions;
            _CheckIfUserAccess = CheckIfUserAccess;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimeDate.Text = clsUtility.DateTimeString();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void frmManageUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Manage users buttons
        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewUser, (int)clsSettings.enUsersPermissions.Add);
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_UpdateUser, (int)clsSettings.enUsersPermissions.Update);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_DeleteUser, (int)clsSettings.enUsersPermissions.Delete);
        }


        //Manage users strip menu
        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewUser, (int)clsSettings.enUsersPermissions.Add);
        }

        private void editToolUserStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_UpdateUser, (int)clsSettings.enUsersPermissions.Update);
        }

        private void deleteToolUserStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_DeleteUser, (int)clsSettings.enUsersPermissions.Delete);
        }


        //Manage roles buttons
        private void btnAddNewRole_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewRole, (int)clsSettings.enUsersPermissions.Add);
        }

        private void btnUpdateRole_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_UpdateRole, (int)clsSettings.enUsersPermissions.Update);
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_DeleteRole, (int)clsSettings.enUsersPermissions.Delete);
        }


        //Manage roles strip menu
        private void addNewRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewRole, (int)clsSettings.enUsersPermissions.Add);
        }

        private void editRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_UpdateRole, (int)clsSettings.enUsersPermissions.Update);
        }

        private void deleteRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_DeleteRole, (int)clsSettings.enUsersPermissions.Delete);
        }


        //Sorting and searching
        private void cbxSearchFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Filter();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _Filter();
        }
    }
}
