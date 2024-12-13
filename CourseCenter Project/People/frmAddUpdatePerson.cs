using CourseCenter_Project.Properties;
using CourseCenterBusinessLayer;
using Guna.UI2.WinForms;
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
    public partial class frmAddUpdatePerson : Form
    {

        private enum enMode { AddNew = 0, Update = 1}

        private enMode _Mode = enMode.AddNew;

        private int _PersonID;

        private clsPerson _Person;



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

            if (!_ValidateRequiredField(txtFirstName, "FirstName"))
            {
                IsValid = false;
            }

            if (!_ValidateRequiredField(txtLastName, "LastName"))
            {
                IsValid = false;
            }

            if (!_ValidateRequiredField(txtEmail, "Email"))
            {
                IsValid = false;
            }

            if (!_ValidateRequiredField(txtPhone, "Phone"))
            {
                IsValid = false;
            }

            return IsValid;
        }

        private void _DisplayPersonImage()
        {
            if (_Person.ImagePath != "")
            {
                pbImage.Image = Image.FromFile(_Person.ImagePath);
                llblRemove.Visible = true;//Show remove link lable
            }
            else
            {
                pbImage.Image = Resources.office_man;//Default Image
            }
        }
        
        private void _DisplayPeronsDetails()
        {
            //Display Person ID
            lblID.Text = _Person.ID.ToString();

            txtFirstName.Text = _Person.FirstName;
            txtLastName.Text = _Person.LastName;

            if (_Person.Gender == "M")
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            dtpDateOfBirth.Value = _Person.DateOfBirth;
            txtEmail.Text = _Person.Email;
            txtPhone.Text = _Person.Phone;
            rtxtAddress.Text = _Person.Address;   
            
            _DisplayPersonImage();
        }


        private void _LoadPersonInfo()
        {
            if (_Mode == enMode.AddNew)
            {
                //Change title to add new 
                lblAddUpdatePerson.Text = "Add New Person";
                _Person = new clsPerson();
            }
            else
            {
                //Change title to update and retrieve person info
                lblAddUpdatePerson.Text = "Update Person";
                _Person = clsPerson.Find(_PersonID);

                _DisplayPeronsDetails();
            }
        }

        private void _SetPersonDetails()
        {
            _Person.FirstName = txtFirstName.Text;
            _Person.LastName = txtLastName.Text;
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.Email = txtEmail.Text;
            _Person.Phone = txtPhone.Text;
            _Person.Address = rtxtAddress.Text;

            _Person.Gender = rbMale.Checked ? "M" : "F";

            //Set Imagepath if not has default image
            _Person.ImagePath = pbImage.Image != Resources.office_man ? pbImage.ImageLocation : string.Empty;
        }

        private void _Save()
        {
            _SetPersonDetails();

            if (_Person.Save())
            {
                MessageBox.Show("Person saved successfully!", "success");
                
                //Change title to Update and display PersonID
                lblAddUpdatePerson.Text = "Update Person";
                lblID.Text = _Person.ID.ToString();
                
                _Mode = enMode.Update;
            }
            else
            {    
                MessageBox.Show("Person save failed, Person email used before", "Error");
            }

        }


        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;

            if (_PersonID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _LoadPersonInfo();
        }

        private void llblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Remove person image and set default image but does take it as image path 
            pbImage.Image = Resources.office_man;

            //Hide remove link lable
            llblRemove.Visible = false;
        }

        private void llblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Prepare openFileDialog
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;//save last Directory

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Display Person Image
                string SelectedPath = openFileDialog1.FileName;
                pbImage.Load(SelectedPath);

                //Show remove link lable
                llblRemove.Visible = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (_ValidateAllRequiredFields())
            {
                if (MessageBox.Show("Are you sure you want to save?", "Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    _Save();
            }
            else
                MessageBox.Show(clsSettings.InvalidErrorMessage, "Attention"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
