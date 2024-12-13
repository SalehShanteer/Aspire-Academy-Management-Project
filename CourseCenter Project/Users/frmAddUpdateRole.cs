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
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;

namespace CourseCenter_Project
{
    public partial class frmAddUpdateRole : Form
    {
       
        private enum enMode { AddNew =  0, Update = 1 };

        private enMode _Mode = enMode.AddNew;

        private int _RoleID;

        private clsRole _Role;



        private bool _ValidateRoleName()
        {
            if (string.IsNullOrWhiteSpace(txtRoleName.Text))
            {
                errorProvider1.SetError(txtRoleName, "Level name cannot be empty");
                return false;
            }

            errorProvider1.Clear();
            return true;
        }


        //Save Role
        private void _SetNameAndDescription()
        {
            _Role.Name = txtRoleName.Text;

            if (string.IsNullOrWhiteSpace(rtxtDescription.Text))
                rtxtDescription.Text = string.Empty;
            _Role.Description = rtxtDescription.Text;
        }

        private void _SetPermissionsFromCheckBoxes()
        {
            foreach (Control control in gbPermissions.Controls)
            {
                if (control is Guna2CustomCheckBox ckb)
                {
                    if (ckb.Checked)
                    {
                        _Role.Permissions += Convert.ToInt32(ckb.Tag);
                    }
                }
            }
        }
        
        private void _SetPermissions()
        {
            _Role.Permissions = 0;

            if (ckbFullAccess.Checked)
            {
                //Give full access to all properties
                _Role.Permissions = -1;
            }
            else
            {
                //Set specific permissions
                _SetPermissionsFromCheckBoxes();

            }
        }

        private void _Save()
        {
          
            _SetNameAndDescription();
                        
            _SetPermissions();

            if (_Role.Save())
            {
                MessageBox.Show("Role Saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Change title to Update and display Role ID
                lblAddUpdateRole.Text = "Update User";
                lblRoleID.Text = _Role.ID.ToString();

                _Mode = enMode.Update;
            }
            else
                MessageBox.Show("Role Save Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        //Display Role Info

        private void _DisableAllSpecificPermissions()
        {
            foreach (Control ckb in gbPermissions.Controls)
            {
                if (ckb is Guna2CustomCheckBox && ckb.Tag.ToString() != "-1")
                {
                    ckb.Enabled = false;
                }
            }
        }

        private void _EnableAllSpecificPermissions()
        {
            foreach (Control ckb in gbPermissions.Controls)
            {
                if (ckb is Guna2CustomCheckBox && ckb.Tag.ToString() != "-1")
                {
                    ckb.Enabled = true;
                }
            }
        }

        private void _CheckPermissionsCheckBoxes()
        {
            foreach (Control control in gbPermissions.Controls)
            {
                if (control is Guna2CustomCheckBox ckb &&
                    (_Role.Permissions & Convert.ToInt32(ckb.Tag)) == Convert.ToInt32(ckb.Tag))
                {
                    ckb.Checked = true;
                }
            }
        }

        private void _DisplayPermissions()
        {
            if (_Role.Permissions == -1)
            {
                ckbFullAccess.Checked = true;
            }
            else
            {
                ckbFullAccess.Checked = false;

                _CheckPermissionsCheckBoxes();
            }
        }

        private void _DisplayRoleInfo()
        {
            //Display name and description
            txtRoleName.Text = _Role.Name;
            rtxtDescription.Text = _Role.Description;

            _DisplayPermissions();
        }

        private void _LoadRoleInfo()
        {
            if (_Mode == enMode.AddNew)
            {
                _Role = new clsRole();

                //Set title to add new
                lblAddUpdateRole.Text = "Add New Role";
            }
            else
            {
                _Role = clsRole.Find(_RoleID);

                if (_Role != null)
                {
                    //Set title to update and display Role ID 
                    lblAddUpdateRole.Text = "Update Role";
                    lblRoleID.Text = _Role.ID.ToString();

                    _DisplayRoleInfo();
                }
                else
                {
                    MessageBox.Show($"There is no Info about Role with ID = {_RoleID}!!", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public frmAddUpdateRole(int RoleID)
        {
            InitializeComponent();
            _RoleID = RoleID;

            if (RoleID != -1)
            {
                _Mode = enMode.Update;
            }
            else
            {
                _Mode = enMode.AddNew;
            }
        }

        private void frmAddUpdateRole_Load(object sender, EventArgs e)
        {
            _LoadRoleInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (tcRole.SelectedIndex < 1)
                tcRole.SelectedIndex++;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (tcRole.SelectedIndex > 0)
                tcRole.SelectedIndex--;
        }

        private void tcRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcRole.SelectedIndex == 0)
            {
                btnBack.Enabled = false;
                btnNext.Enabled = true;
                btnSave.Enabled = false;
            }
            else if (tcRole.SelectedIndex == 1)
            {
                btnBack.Enabled = true;
                btnNext.Enabled = false;
                btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_ValidateRoleName())
            {
                if (MessageBox.Show("Do you want to save Role info?", "Save?"
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

        private void ckbFullAccess_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFullAccess.Checked)
            {
                _DisableAllSpecificPermissions();
            }
            else
            {
                _EnableAllSpecificPermissions();
            }
        }
    }
}
