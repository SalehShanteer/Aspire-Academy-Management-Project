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
    public partial class frmAddUpdateSpecialization : Form
    {
        private enum enMode { AddNew = 0, Update = 1 }

        private enMode _Mode = enMode.AddNew;
        
        private clsSpecialization _Specialization = new clsSpecialization();
        
        private int _SpecializationID;


        private bool _ValidateSpecializationName()
        {
            if (string.IsNullOrWhiteSpace(txtSpecializationName.Text))
            {
                errorProvider1.SetError(txtSpecializationName, "Level name cannot be empty");
                return false;
            }

            errorProvider1.Clear();
            return true;
        }


        private void _SetSpecializationDetails()
        {
            _Specialization.Name = txtSpecializationName.Text;
            _Specialization.Description = rtxtDescription.Text;
        }

        private void _Save()
        {
            _SetSpecializationDetails();

            if (_Specialization.Save())
            {
                MessageBox.Show("Specialization Saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                //Change title to Update and display Specialization ID
                lblAddUpdateSpecialization.Text = "Update Specialization";
                lblSpecializationID.Text = _Specialization.ID.ToString();
                
                _Mode = enMode.Update;
            }
            else
                MessageBox.Show("Specialization Save Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void _DisplaySpecializationInfo()
        {
            lblSpecializationID.Text = _Specialization.ID.ToString();
            txtSpecializationName.Text = _Specialization.Name;
            rtxtDescription.Text = _Specialization.Description;
        }

        private void _LoadSpecializationInfo()
        {
            if (_Mode == enMode.AddNew)
            {
                //Change title to Add New
                lblAddUpdateSpecialization.Text = "Add New Specialization";
                _Specialization = new clsSpecialization();

            }
            else
            {
                //Change title to Update and retrieve Specialization info
                lblAddUpdateSpecialization.Text = "Update Specialization";
                _Specialization = clsSpecialization.Find(_SpecializationID);

                _DisplaySpecializationInfo();
            }
        }

        
        public frmAddUpdateSpecialization(int SpecializatonID)
        {
            InitializeComponent();
            _SpecializationID = SpecializatonID;

            if (_SpecializationID != -1)
                _Mode = enMode.Update;               
            else
                _Mode = enMode.AddNew;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddUpdateSpecialization_Load(object sender, EventArgs e)
        {
            _LoadSpecializationInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_ValidateSpecializationName())
            {
                if (MessageBox.Show("Do you want to save Specializaton info?", "Save?"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    _Save();
            }
            else
            {
                MessageBox.Show(clsSettings.InvalidErrorMessage, "Attention"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
