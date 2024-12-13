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
    public partial class frmAddUpdateInstructor : Form
    {

        private enum enMode { AddNew = 0, Update = 1 }

        private enMode _Mode = enMode.AddNew;

        private clsPerson _Person = null;

        private clsInstructor _Instructor = new clsInstructor();

        private int _InstructorID;

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

        private void _DisplaySalary()
        {
            if (_Instructor.Salary != -1)
            {
                txtSalary.Text = _Instructor.Salary.ToString();
                lblAmountToIncrease.Visible = true;
                txtAmountToIncrease.Visible = true;
            }
            else
                txtSalary.Text = string.Empty;
        }

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


        private void _SetInstructorSalary()
        {
            if (txtSalary.Text == string.Empty)
                _Instructor.Salary = -1;
            else
            {
                _Instructor.Salary = Convert.ToDecimal(txtSalary.Text);

                //Manage Amount to increase
                if (txtAmountToIncrease.Text != string.Empty)
                    if (_Instructor.Salary > 0)
                        _Instructor.Salary += Convert.ToDecimal(txtAmountToIncrease.Text);
            }
        }

        private void _SetInstructorDetails()
        {
            _Instructor.PersonID = Convert.ToInt32(lblPersonID.Text);
            _Instructor.SpecializationID = clsSpecialization.Find(cbxSpecializations.SelectedItem.ToString()).ID;

            _SetInstructorSalary();

            if (string.IsNullOrWhiteSpace(rtxtCertificates.Text))
                _Instructor.Certificates = string.Empty;
            else
                _Instructor.Certificates = rtxtCertificates.Text;
        }

        private void _Save()
        {
            _SetInstructorDetails();

            if (_Instructor.Save())
            {
                MessageBox.Show("Instructor Saved successfully!", "Saved"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Change title to Update and display Instructor ID
                lblAddUpdateInstructor.Text = "Update Instructor";
                lblInstructorID.Text = _Instructor.ID.ToString();

                _DisplaySalary();

                _Mode = enMode.Update;
            }
            else
                MessageBox.Show("Instructor Save Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void _LoadInstructorOtherInfo()
        {
            if (_Instructor.Salary == -1)
            {
                txtSalary.Text = string.Empty;
            }
            else
            {
                txtSalary.Text = _Instructor.Salary.ToString();
            }
            rtxtCertificates.Text = _Instructor.Certificates;
            _LoadSpecialization();
        }

        private void _LoadInstructorInfo()
        {
            _LoadSpecializationsComboBox();

            if (_Mode == enMode.AddNew)
            {
                //Change title Add New
                lblAddUpdateInstructor.Text = "Add New Instructor";
            }
            else
            {
                //Change title Update and Display Instructor ID
                lblAddUpdateInstructor.Text = "Update Instructor";
                lblInstructorID.Text = _Instructor.ID.ToString();

                _LoadPersonInfo(_Instructor.PersonID);
                _LoadInstructorOtherInfo();
                if (txtSalary.Text != string.Empty)
                {
                    lblAmountToIncrease.Visible = true;
                    txtAmountToIncrease.Visible = true;
                }
            }
        }

        private void _LoadSpecialization()
        {
            cbxSpecializations.SelectedIndex = cbxSpecializations.FindString(clsSpecialization.Find(_Instructor.SpecializationID).Name);
        }

        private void _LoadSpecializationsComboBox()
        {
            DataTable dtSpecializations = clsSpecialization.GetAllSpecializations();
            foreach(DataRow row in dtSpecializations.Rows)
            {
                cbxSpecializations.Items.Add(row["Name"]);
            }
            cbxSpecializations.SelectedIndex = 0;
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
                if (!clsInstructor.IsPersonAddedBefore(PersonID))
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


        private void _AddNewSpecialization()
        {
            frmAddUpdateSpecialization frm = new frmAddUpdateSpecialization(-1);
            frm.ShowDialog();
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

            //Retrieve and display Person info
            _LoadPersonInfo(_Person.ID);
        }


        public frmAddUpdateInstructor(int instructorID, Action<Action, int> checkIfUserAccess)
        {
            InitializeComponent();

            _InstructorID = instructorID;
            _CheckIfUserAccess = checkIfUserAccess;

            if (_InstructorID == -1)
                _Mode = enMode.AddNew;
            else
            {
                _Instructor = clsInstructor.Find(instructorID);
                _Mode = enMode.Update;
            }

        }

        private void frmAddUpdateInstructor_Load(object sender, EventArgs e)
        {
            _LoadInstructorInfo();
        }


      
        //Adding Specialization and person button
        private void btnAddNewSpecialization_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewSpecialization, (int)clsSettings.enInstructorsPermissions.Add);  
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewPerson, (int)clsSettings.enPeoplePermissions.Add);
        }


        //Save and search
       private void btnSave_Click(object sender, EventArgs e)
        {
            if (_ValidateIfRequiredFields())
            {
                if (MessageBox.Show("Do you want to save Instructor info?", "Save?"
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
        private void txtFindByID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Press Enter ==> Search
                e.SuppressKeyPress = true;
                _SearchPerson();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFindByID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;//Ensure only digits allowed
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;//Ensure only digits allowed
        }

        private void llblEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _CheckIfUserAccess(_UpdatePerson, (int)clsSettings.enPeoplePermissions.Update);         
        }

    }
}
