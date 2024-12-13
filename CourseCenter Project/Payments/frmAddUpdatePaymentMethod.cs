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
    public partial class frmAddUpdatePaymentMethod : Form
    {

        private enum enMode { AddNew = 0, Update = 1 } 

        private enMode _Mode = enMode.AddNew;

        private int _PaymentMethodID;

        private clsPaymentMethod _PaymentMethod;



        private bool _ValidateField(Guna2TextBox ctrl, string name)
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
            //Clear error
            errorProvider1.Clear();

            bool IsValid = true;

            if (!_ValidateField(txtID, "Payment method ID"))
            {
                IsValid = false;
            }

            if (!_ValidateField(txtMethodName, "Method name"))
            {
                IsValid = false;
            }

            return IsValid;
        }

        private void _DisplayPaymentMethodInfo()
        {
            txtID.Text = _PaymentMethod.ID.ToString();
            txtMethodName.Text = _PaymentMethod.MethodName.ToString();
            rtxtDescription.Text = _PaymentMethod.Description;
            ckbActive.Checked = _PaymentMethod.IsActive;
        }

        private void _LoadPaymentMethodInfo()
        {
           if (_Mode == enMode.AddNew)
            {
                //Change title to Add New
                lblAddUpdatePaymentMethod.Text = "Add New Payment Method";
                _PaymentMethod = new clsPaymentMethod();
            }
           else
            {
                //Change title to Update and Retrieve PaymentMethod
                lblAddUpdatePaymentMethod.Text = "Update Payment Method";
                _PaymentMethod = clsPaymentMethod.Find(_PaymentMethodID);

                _DisplayPaymentMethodInfo();
            }
        }

        private void _SetPaymentMethodDetails()
        {
            _PaymentMethod.ID = Convert.ToInt32(txtID.Text);
            _PaymentMethod.MethodName = txtMethodName.Text;
            
            if (string.IsNullOrWhiteSpace(rtxtDescription.Text))
                rtxtDescription.Text = string.Empty;

            _PaymentMethod.Description = rtxtDescription.Text;
            _PaymentMethod.IsActive = ckbActive.Checked;
        }
        
        private void _Save()
        {
            _SetPaymentMethodDetails();

            if (_PaymentMethod.Save())
            {
                MessageBox.Show("Payment Method saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Change title to update
                lblAddUpdatePaymentMethod.Text = "Update Payment Method";

                _Mode = enMode.Update;
            }
            else
                MessageBox.Show("Payment Method save Failed", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public frmAddUpdatePaymentMethod(int PaymentMethodID)
        {
            InitializeComponent();
            _PaymentMethodID = PaymentMethodID;

            if (_PaymentMethodID != -1)
                _Mode = enMode.Update;
            else
                _Mode = enMode.AddNew;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddUpdatePaymentMethod_Load(object sender, EventArgs e)
        {
            _LoadPaymentMethodInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_ValidateAllRequiredFields())
            {
                if (MessageBox.Show("Do you want to save payment method info?", "Save?"
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

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true; //Ensure only digits allowed 
        }
    }
}
