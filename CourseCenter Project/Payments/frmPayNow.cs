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
    public partial class frmPaymentPortal : Form
    {

        private clsPayment _Payment = new clsPayment();



        private bool _ValidateAmountToPayField()
        {
            if (string.IsNullOrWhiteSpace(txtAmountToPay.Text))
            {
                errorProvider1.SetError(txtAmountToPay, "Amount to pay cannot be empty");
                return false;
            }

            //Clear error
            errorProvider1.Clear();

            return true;
        }


        private bool _CheckAndSetPaidAmount()
        {
            decimal Amount = Convert.ToDecimal(txtAmountToPay.Text);

            //Check if amount exceed the remaining cost
            if (Amount + _Payment.ActualPayAmount <= (decimal)_Payment.CostAfterDiscount)
            {
                _Payment.ActualPayAmount += Amount;
                return true;
            }
            else
            {
                MessageBox.Show("Amount exceeds the required amount", "Over paid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void _PaymentProccess()
        {   
            _Payment.PaymentMethodID = clsPaymentMethod.Find(cbxPaymentMethods.Text).ID;
            
            if (_CheckAndSetPaidAmount())
            {
                if (_Payment.Save())
                {
                    MessageBox.Show("Payment proccess done successfully!", "Done"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    //When payment complete pay button will unenable
                    if (_Payment.ActualPayAmount == _Payment.CostAfterDiscount)
                    {
                        btnPay.Enabled = false;
                    }
                    
                    //Clear amount to pay textBox
                    txtAmountToPay.Text = string.Empty;

                    _DisplayCostInfo();

                }
                else
                    MessageBox.Show("Payment proccess Failed!", "Failed"
                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private float _CalculateRemainingCost()
        {
            //Subtract Total cost from the amount of how much student paid
            float RemainingCost = (float)_Payment.CostAfterDiscount - (float)_Payment.ActualPayAmount;

            return RemainingCost;
        }

        private void _LoadPaymentMethodComboBox()
        {
            DataTable dtPaymentMethods = clsPaymentMethod.GetActivePaymentMethodsList();

            foreach (DataRow row in dtPaymentMethods.Rows)
            {
                cbxPaymentMethods.Items.Add(row["MethodName"]);
            }
        }
        
    
        private void _DisplayStudentName()
        {
            lblStudentName.Text = clsStudent.GetFullName(_Payment.StudentID);
        }

        private void _DisplayCostInfo()
        {
            lblTotalPaymentCost.Text = _Payment.CostAfterDiscount.ToString() + '$';
            lblRemainingCost.Text = _CalculateRemainingCost().ToString() + '$';
        }

        private void _DisplayPaymentInfo()
        {
            lblPaymentID.Text = _Payment.ID.ToString();
            lblStudentID.Text = _Payment.StudentID.ToString();
            lblEnrollmentID.Text = _Payment.EnrollmentID.ToString();
            
            _DisplayCostInfo();
            _DisplayStudentName();
            _LoadPaymentMethodComboBox();

            cbxPaymentMethods.SelectedIndex = 0;//Set default index for comboBox
        }


        public frmPaymentPortal(int PaymentID)
        {
            InitializeComponent();
            _Payment = clsPayment.Find(PaymentID);
        }

        private void frmPaymentPortal_Load(object sender, EventArgs e)
        {
            _DisplayPaymentInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAmountToPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) && e.KeyChar != '.')
                e.Handled = true;//Ensure only digits Allowed

            
            if (e.KeyChar == '.' && txtAmountToPay.Text.IndexOf(".") > -1)
                e.Handled = true ;//Allow for only one '.' in textBox
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (_ValidateAmountToPayField())
            {
                if (MessageBox.Show("Are you sure you want to pay?", "Pay?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _PaymentProccess();
                }
            }
            else
            {
                MessageBox.Show(clsSettings.InvalidErrorMessage, "Attention"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
