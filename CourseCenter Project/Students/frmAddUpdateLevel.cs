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
    public partial class frmAddUpdateLevel : Form
    {
        
        private enum enMode { AddNew = 0, Update = 1 }

        private enMode _Mode = enMode.AddNew;

        private int _LevelID;

        private clsLevel _Level = new clsLevel(); 

       
        private bool _ValidateLevelName()
        {
            if (string.IsNullOrWhiteSpace(txtLevelName.Text))
            {
                errorProvider1.SetError(txtLevelName, "Level name cannot be empty");
                return false;
            }

            errorProvider1.Clear();
            return true;
        }
        
        private void _DisplayLevelInfo()
        {
            lblLevelID.Text = _Level.ID.ToString();
            txtLevelName.Text = _Level.Name;
            rtxtDescription.Text = _Level.Description;
        }
        
        private void _LoadLevelInfo()
        {
            if (_Mode == enMode.AddNew)
            {
                //Change title to Add New
                lblAddUpdateLevel.Text = "Add New Level";
                _Level = new clsLevel();
            }
            else
            {
                //Retrieve Level info
                _Level = clsLevel.Find(_LevelID);

                //Change title to Add New
                lblAddUpdateLevel.Text = "Update Level";

                _DisplayLevelInfo();
            }
        }

        private void _SetLevelDetails()
        {
            _Level.Name = txtLevelName.Text;
            if (!string.IsNullOrWhiteSpace(rtxtDescription.Text))
                _Level.Description = rtxtDescription.Text;
            else
                _Level.Description = string.Empty;
        }

        private void _Save()
        {
            _SetLevelDetails();

            if (_Level.Save())
            {
                MessageBox.Show("Level saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                //Change title to Update and display Level ID
                lblAddUpdateLevel.Text = "Update Level";
                lblLevelID.Text = _Level.ID.ToString();
                
                _Mode = enMode.Update;
            }
            else
                MessageBox.Show("Level save operation failed!, This might be because the level name was added before.", "Error!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        public frmAddUpdateLevel(int LevelID)
        {
            InitializeComponent();

            _LevelID = LevelID;

            if (_LevelID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_ValidateLevelName())
            {
                if (MessageBox.Show("Are you sure you want to save?", "Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    _Save();
            }
            else
            {
                MessageBox.Show(clsSettings.InvalidErrorMessage, "Attention"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAddUpdateLevel_Load(object sender, EventArgs e)
        {
            _LoadLevelInfo();
        }
    }
}
