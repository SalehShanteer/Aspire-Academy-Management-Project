using CourseCenter_Project.Properties;
using CourseCenterBusinessLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseCenter_Project
{
    public partial class frmAddUpdateUser : Form
    {
        
        private enum enMode { AddNew = 0, Update = 1};

        private enMode _Mode = enMode.AddNew;

        private int _UserID;

        private clsUser _User;
         
        private clsPerson _Person = null;

        private Action<Action, int> _CheckIfUserAccess;


        private bool _ValidatePersonField()
        {
            if (_Person == null)
            {
                errorProvider1.SetError(txtFindByID, "Person cannot be empty");
                return false;
            }

            errorProvider1.Clear();
            return true;
        }

        private bool _ValidateRequiredField(Guna2TextBox ctrl, string name)
        {
            if (string.IsNullOrWhiteSpace(ctrl.Text))
            {
                errorProvider1.SetError(ctrl, $"{name} cannot be empty");
                return false;
            }
            return true;
        }

        private bool _ValidateAllRequiredFields()
        {
            bool IsValid = true;

            if (!_ValidatePersonField())
            {
                IsValid = false;
            }

            if (!_ValidateRequiredField(txtUsername, "FirstName"))
            {
                IsValid = false;
            }

            if (!_ValidateRequiredField(txtPassword, "LastName"))
            {
                IsValid = false;
            }

            if (!_ValidateRequiredField(txtConfirmPassword, "Email"))
            {
                IsValid = false;
            }

            return IsValid;
        }


        //Display User Info
        private void _DisplayAccountAccessInfo()
        {
            txtUsername.Text = _User.Username;

            txtPassword.Text = clsUtility.Decrypt(_User.Password);
            txtConfirmPassword.Text = txtPassword.Text;

            ckbActive.Checked = _User.IsActive;
        }

        private void _DisplayRole()
        {
            string RoleName = clsRole.Find(_User.RoleID).Name;

            cbxRoles.SelectedIndex = cbxRoles.FindString(RoleName);
        }

        private void _DisplayUserInfo()
        {
            _DisplayPersonInfo();
            _DisplayAccountAccessInfo();
            _DisplayRole();
        }

        private void _LoadRolesComboBox()
        {
            DataTable dtRoles = clsRole.GetAllRoles();
            
            foreach (DataRow row in dtRoles.Rows)
            {
                cbxRoles.Items.Add(row["Name"]);
            }
        }

        private void _LoadUserInfo()
        {
          
            _LoadRolesComboBox();

            if (_Mode == enMode.AddNew)
            {
                //Change title to add new and set Roles at default index
                lblAddUpdateUser.Text = "Add New User";
                cbxRoles.SelectedIndex = 0;

                _User = new clsUser();

            }
            else
            {
               
                //Retrieve user data
                _User = clsUser.Find(_UserID);

                if (_User != null)
                {
                    //Change title to update and display user ID
                    lblAddUpdateUser.Text = "Update User";
                    lblUserID.Text = _UserID.ToString();

                    //Retrieve person data
                    _Person = clsPerson.Find(_User.PersonID);

                    _DisplayUserInfo();
                }
                else
                {
                    MessageBox.Show($"There is no Info about user with ID = {_UserID}!!", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   
            }

        } 
      
        //Person Info
        private void _DisplayPersonInfo()
        {
            lblPersonID.Text = _Person.ID.ToString();
            lblName.Text = _Person.FullName;

            lblGender.Text = _Person.Gender == "M" ? "Male" : "Female";

            if (!string.IsNullOrWhiteSpace(_Person.Address))
                lblAddress.Text = _Person.Address;
            else
                lblAddress.Text = "N/A";

            lblEmail.Text = _Person.Email;
            lblPhone.Text = _Person.Phone;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToString("M/d/yyyy");

            if (_Person.ImagePath != "")
                pbImage.Load(_Person.ImagePath);
        }

        private void _LoadPersonInfo(int ID)
        {
            _Person = clsPerson.Find(ID);
            if (_Person != null)
            {
                _DisplayPersonInfo();

                //Enable edit person info link label
                llblEditPersonInfo.Enabled = true;
            }
            else
                MessageBox.Show("Find Person Operation Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _SearchPerson()
        {
            int PersonID = Convert.ToInt32(txtFindByID.Text);
            if (clsPerson.IsExist(PersonID))
            {
                //To check if person added before 
                if (!clsUser.IsPersonAddedBefore(PersonID))
                {
                    //Retrirve and display Person info  
                    _LoadPersonInfo(PersonID);
                }
                else
                    MessageBox.Show("This Person Added Before!!", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show($"There is no person exist with this ID = {PersonID}", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void _AddNewPerson()
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(-1);
            frm.ShowDialog();
        }

        private void _UpdatePerson()
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(_Person.ID);
            frm.ShowDialog();
        }

        //Saving Proccess
        private bool _IsUsernameUsedBefore()
        {
            if (_Mode == enMode.AddNew)
            {
                return clsUser.IsUsernameAddedBefore(txtUsername.Text);
            }
            else
            {
                return clsUser.IsUsernameAddedBefore(_UserID, txtUsername.Text);
            }
        }
        
        private bool _CheckPasswordValidation()
        {
            if (!clsUtility.IsLengthValid(txtPassword.Text, 8))
            {
                return false;
            }

            if (!clsUtility.IsContainCapitalLetter(txtPassword.Text))
            {
                return false;
            }

            if (!clsUtility.IsContainSmallLetter(txtPassword.Text))
            {
                return false;
            }

            if (!clsUtility.IsContainDigit(txtPassword.Text))
            {
                return false;
            }

            if (!clsUtility.IsContainSpecialCharacter(txtPassword.Text))
            {
                return false;
            }

            return true;
        }

        private bool _CheckPasswordMatch()
        {
            return txtPassword.Text == txtConfirmPassword.Text;
        }

        private void _SetRole()
        {
            int RoleID = clsRole.Find(cbxRoles.SelectedItem.ToString()).ID;

            _User.RoleID = RoleID;

        }

        private bool _SetAccountAccessDetails(ref string errorMessage)
        {
            if (!_IsUsernameUsedBefore())
            {
                _User.Username = txtUsername.Text;
            }
            else
            {
                errorMessage = "The username used before!";

                return false;
            }

            if (!_CheckPasswordMatch())
            {
                errorMessage = "Password does not match!";

                return false;
            }

            if (!_CheckPasswordValidation())
            {
                errorMessage = "Password should be 8 or more characters and " +
                    "contains capital, small and special characters and contains digit";

                return false;
            }
            _User.Password = clsUtility.Encrypt(txtPassword.Text);
            _User.IsActive = ckbActive.Checked;

            return true;
        }
   
        private void _Save()
        {
            _User.PersonID = _Person.ID;

            //check if role selected or not
            _SetRole();
            
            string errorMessage = string.Empty;

            //Check if account details valid
            if (_SetAccountAccessDetails(ref errorMessage))
            {
                if (_User.Save())
                {
                    MessageBox.Show("User Saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Change title to Update and display User ID
                    lblAddUpdateUser.Text = "Update User";
                    lblUserID.Text = _User.ID.ToString();

                    _Mode = enMode.Update;
                }
                else
                    MessageBox.Show("User Save Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        private void _AddNewRole()
        {
            frmAddUpdateRole frm = new frmAddUpdateRole(-1);
            frm.ShowDialog();

            _LoadRolesComboBox();
        }


        public frmAddUpdateUser(int UserID, Action<Action, int> CheckIfUserAccess)
        {
            InitializeComponent();
            
            _UserID = UserID;
            _CheckIfUserAccess = CheckIfUserAccess;

            if (_UserID != -1)
            {
                _Mode = enMode.Update;
            }
            else
            {
                _Mode = enMode.AddNew;
            }
        }

       
        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _LoadUserInfo();
        }


        //Manage people and add role
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewPerson, (int)clsSettings.enPeoplePermissions.Add);
        }
           
        private void llblEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _CheckIfUserAccess(_UpdatePerson, (int)clsSettings.enPeoplePermissions.Update);
        }

        private void btnAddNewRole_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewRole, (int)clsSettings.enPeoplePermissions.Add);
        }


        //Saving user
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_ValidateAllRequiredFields())
            {
                if (MessageBox.Show("Do you want to save User info?", "Save?"
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

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            _SearchPerson();
        }


        //Sub
        private void btnPasswordShowHide_Click(object sender, EventArgs e)
        {
            if (btnPasswordShowHide.Tag.ToString() == "Show")
            {
                //Hide password
                btnPasswordShowHide.Image = Resources.hide;
                btnPasswordShowHide.Tag = "Hide";
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                //Show password
                btnPasswordShowHide.Image = Resources.show;
                btnPasswordShowHide.Tag = "Show";
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnConfirmPasswordShowHide_Click(object sender, EventArgs e)
        {
            if (btnConfirmPasswordShowHide.Tag.ToString() == "Show")
            {
                //Hide password
                btnConfirmPasswordShowHide.Image = Resources.hide;
                btnConfirmPasswordShowHide.Tag = "Hide";
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
            else
            {
                //Show password
                btnConfirmPasswordShowHide.Image = Resources.show;
                btnConfirmPasswordShowHide.Tag = "Show";
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (tcUser.SelectedIndex < 1)
                tcUser.SelectedIndex++;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (tcUser.SelectedIndex > 0)
                tcUser.SelectedIndex--;
        }

        private void tcUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcUser.SelectedIndex == 0)
            {
                btnBack.Enabled = false;
                btnNext.Enabled = true;
                btnSave.Enabled = false;
            }
            else if (tcUser.SelectedIndex == 1)
            {
                btnBack.Enabled = true;
                btnNext.Enabled = false;
                btnSave.Enabled = true;
            }

        }

        private void txtFindByID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Press Enter ==> Search
                e.SuppressKeyPress = true;
                _SearchPerson();
            }
        }

        private void txtFindByID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;//Ensure only digits allowed
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
