using CourseCenter_Project.Properties;
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
    public partial class frmAddUpdateStudent : Form
    {
        
        private enum enMode { AddNew = 0, Update = 1}

        private enMode _Mode = enMode.AddNew;
        
        private clsPerson _Person = null;

        private clsStudent _Student = new clsStudent();

        private int _StudentID;

        private Action<Action, int> _CheckIfUserAccess;


        private bool _ValidateIfRequiredFields()
        {
            if (_Person == null)
            {
                errorProvider1.SetError(txtFindByID, "Person cannot be empty");
                return false;
            }

            errorProvider1.Clear();
            return true;
        }

        private bool IsPersonAddedBefore(int PersonID)
        {
            return clsStudent.IsPersonIDExist(PersonID);
        }

        private void _SearchPerson()
        {
            int PersonID = Convert.ToInt32(txtFindByID.Text);

            if (clsPerson.IsExist(PersonID))
            {
                if (IsPersonAddedBefore(PersonID))
                    MessageBox.Show("This Person Added Before!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    _LoadPersonInfo(PersonID);
            }
            else
                MessageBox.Show($"There is no person exist with this ID = {PersonID}", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _SetStudentDetails()
        {
            _Student.PersonID = Convert.ToInt32(lblPersonID.Text);
            _Student.LevelID = clsLevel.Find(cbxLevels.SelectedItem.ToString()).ID;

        }

        private void _Save()
        {
            _SetStudentDetails();

             if (_Student.Save())
            {
                MessageBox.Show("Student saved successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                //Change title to update and display Student ID
                lblAddUpdateStudent.Text = "Update Student";
                lblStudentID.Text = _Student.ID.ToString();
                
                _Mode = enMode.Update;
            }
            else
                MessageBox.Show("Save Operation Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void _DisplayStudentLevel()
        {
            string StudentLevel = clsLevel.Find(_Student.LevelID).Name;
            cbxLevels.SelectedItem = StudentLevel;
        }

        private void _DisplayPersonInfo()
        {
            llblEditPersonInfo.Enabled = true;
            lblPersonID.Text = _Person.ID.ToString();
            lblName.Text = _Person.FullName;
            lblEmail.Text = _Person.Email;
            lblPhone.Text = _Person.Phone;

            lblDateOfBirth.Text = _Person.DateOfBirth.ToString("M/d/yyyy");
            lblGender.Text = _Person.Gender == "M" ? "Male" : "Female";

            if (!string.IsNullOrWhiteSpace(_Person.Address))
                lblAddress.Text = _Person.Address;
            else
                lblAddress.Text = "N/A";

            if (_Person.ImagePath != "")
                pbImage.Load(_Person.ImagePath);
            else
                pbImage.Image = Resources.office_man;
        }


        private void _LoadLevelsComboBox()
        {
            DataTable dtLevels = clsLevel.GetAllLevels();
            foreach (DataRow row in dtLevels.Rows)
            {
                cbxLevels.Items.Add(row["Name"]);
            }
            cbxLevels.SelectedIndex = 0;
        }
       
        private void _LoadStudentInfo()
        {
            _LoadLevelsComboBox();
            if (_Mode == enMode.AddNew)
            {
                //Change title to Add New
                lblAddUpdateStudent.Text = "Add New Student";
                _Student = new clsStudent();
            }
            else
            {
                //Change title to Add New and Retrieve Student Info
                lblAddUpdateStudent.Text = "Update Student";
                _Student = clsStudent.Find(_StudentID);

                //Display Studnet ID
                lblStudentID.Text = _Student.ID.ToString();

                _LoadPersonInfo(_Student.PersonID);
                _DisplayStudentLevel();
            }
        }
            
        private void _LoadPersonInfo(int PersonID)
        {
            //Retrieve Pesron info
            _Person = clsPerson.Find(PersonID);

            if (_Person != null)
                _DisplayPersonInfo();
            else
                MessageBox.Show("Find Person Operation Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);         
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

            _LoadPersonInfo(_Person.ID);
        }

        private void _AddNewLevel()
        {
            frmAddUpdateLevel frm = new frmAddUpdateLevel(-1);
            frm.ShowDialog();

            _LoadLevelsComboBox();
        }



        public frmAddUpdateStudent(int StudentID, Action<Action, int> CheckIfUserAccess)
        {
            InitializeComponent();
            
            _StudentID = StudentID;
            _CheckIfUserAccess = CheckIfUserAccess;

            if (_StudentID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }

        private void frmAddUpdateStudent_Load(object sender, EventArgs e)
        {
            _LoadStudentInfo();
        }


        //Save student
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_ValidateIfRequiredFields())
            {
                if (MessageBox.Show("Do you want to save student info?", "Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    _Save();
            }
            else
            {
                MessageBox.Show(clsSettings.InvalidErrorMessage, "Attention"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error );
            }    
        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            _SearchPerson();
        }

      
        //Manage people and add levels
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewPerson, (int)clsSettings.enPeoplePermissions.Add);
        }

        private void llblEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _CheckIfUserAccess(_UpdatePerson, (int)clsSettings.enPeoplePermissions.Update);               
        }     

        private void btnAddNewLevel_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewLevel, (int)clsSettings.enPeoplePermissions.Add);
        }

        
        //Sub
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
