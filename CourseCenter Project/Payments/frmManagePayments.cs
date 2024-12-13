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
    public partial class frmManagePayments : Form
    {

        private DataView _dvPaymentsList = new DataView();

        private DataView _dvPaymentMethodsList = new DataView();

        private int _CurrentUserPermissions;

        private Action<Action, int> _CheckIfUserAccess;


        private void _Filter()
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                string Filter = cbxSearchFilter.SelectedItem.ToString();
                string SearchedNumber = txtSearch.Text;

                _dvPaymentsList.RowFilter = $"{Filter} = {SearchedNumber}";

            }
            else
            {
                _dvPaymentsList.RowFilter = "";//show all payments
            }

        }


        private void _PreparePaymentsList()
        {
            //Adjust columns widths 
            dgvPaymentsList.Columns["PaymentID"].Width = 60;
            dgvPaymentsList.Columns["StudentID"].Width = 57;
            dgvPaymentsList.Columns["EnrollmentID"].Width = 70;
            dgvPaymentsList.Columns["OriginalCost"].Width = 65;
            dgvPaymentsList.Columns["CostAfterDiscount"].Width = 93;
            dgvPaymentsList.Columns["ActualPayAmount"].Width = 93;
            dgvPaymentsList.Columns["PaymentMethodID"].Width = 96;
            dgvPaymentsList.Columns["DiscountPercentage"].Width = 105;
            dgvPaymentsList.Columns["LastUpdatedDate"].Width = 95;
            dgvPaymentsList.Columns["IsPaid"].Width = 50;
        }

        private void _RefreshPaymentsList()
        {
            _dvPaymentsList = clsPayment.GetPaymentsList().DefaultView;
            dgvPaymentsList.DataSource = _dvPaymentsList;

            //Display Total Payment Amount
            lblTotalPaymentsAmount.Text = clsPayment.GetTotalPayments().ToString() + '$';
        }

        private void _PreparePaymentMethodsList()
        {
            //Adjust columns widths
            dgvPaymentMethodsList.Columns["Description"].Width = 165;
            dgvPaymentMethodsList.Columns["IsActive"].Width = 50;
        }

        private void _RefreshPaymentMethodsList()
        {
            _dvPaymentMethodsList = clsPaymentMethod.GetPaymentMethodsList().DefaultView;
            dgvPaymentMethodsList.DataSource = _dvPaymentMethodsList;
        }


        private void _Refresh()
        {
            cbxSearchFilter.SelectedIndex = 0;//Set it as a default index   
            timer1.Enabled = true;
            lblTimeDate.Text = clsUtility.DateTimeString();

            _RefreshPaymentsList();
            _RefreshPaymentMethodsList();

            _PreparePaymentsList();
            _PreparePaymentMethodsList();
        }


        private void _ShowPaymentPortalScreen()
        {
            if (dgvPaymentsList.SelectedCells.Count > 0)
            {
                int PaymentID = Convert.ToInt32(dgvPaymentsList.CurrentRow.Cells["PaymentID"].Value);

                //Open payment portal only for who does not pay full cost for payment
                if (!clsPayment.IsPaidFullAmount(PaymentID))
                {
                    frmPaymentPortal frm = new frmPaymentPortal(PaymentID);
                    frm.ShowDialog();

                    _RefreshPaymentsList();
                }
                else
                    MessageBox.Show("This payment is fully paid", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("There is no payment selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _AddNewPaymentMethod()
        {
            frmAddUpdatePaymentMethod frm = new frmAddUpdatePaymentMethod(-1);
            frm.ShowDialog();

            _RefreshPaymentMethodsList();
        }

        private void _UpdatePaymentMethod()
        {
            if (dgvPaymentMethodsList.SelectedCells.Count > 0)
            {
                int SelectedPaymentMethodID = (int)dgvPaymentMethodsList.CurrentRow.Cells["PaymentMethodID"].Value;

                if (clsPaymentMethod.IsExist(SelectedPaymentMethodID))
                {
                    frmAddUpdatePaymentMethod frm = new frmAddUpdatePaymentMethod(SelectedPaymentMethodID);
                    frm.ShowDialog();

                    _RefreshPaymentMethodsList();
                }
                else
                    MessageBox.Show($"Payment Method with ID = {SelectedPaymentMethodID} not found!", "No Result!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show($"There is no Payment Method selected!", "Error!"
                           , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void _DeletePaymentMethod()
        {
            if (dgvPaymentMethodsList.SelectedCells.Count > 0)
            {
                int SelectedPaymentMethodID = (int)dgvPaymentMethodsList.CurrentRow.Cells["PaymentMethodID"].Value;

                //Confirm deletion with the user
                if (MessageBox.Show($"Are you sure you want to delete this Payment Method with ID = {SelectedPaymentMethodID} ?", "Delete"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsPaymentMethod.IsExist(SelectedPaymentMethodID))
                    {
                        clsPaymentMethod.Delete(SelectedPaymentMethodID);

                        _RefreshPaymentMethodsList();
                    }
                    else
                        MessageBox.Show("Payment Method ID not found!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("There is no Payment Method selected!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public frmManagePayments(int currentUserPermissions, Action<Action, int> CheckIfUserAccess)
        {
            InitializeComponent();

            _CurrentUserPermissions = currentUserPermissions;
            _CheckIfUserAccess = CheckIfUserAccess;
        }

      
        private void frmManagePayments_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void frmManagePayments_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimeDate.Text = clsUtility.DateTimeString();
        }
     

        //Show payment portal
        private void btnPaymentPortal_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_ShowPaymentPortalScreen, (int)clsSettings.enPaymentsPermissions.Add);
        }

        private void payToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_ShowPaymentPortalScreen, (int)clsSettings.enPaymentsPermissions.Add);
        }


        //Manage payment methods buttons
        private void btnAddNewPaymentMethod_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewPaymentMethod, (int)clsSettings.enPaymentsPermissions.Add);
        }

        private void btnUpdatePaymentMethod_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_UpdatePaymentMethod, (int)clsSettings.enPaymentsPermissions.Update);
        }

        private void btnDeletePaymentMethod_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_DeletePaymentMethod, (int)clsSettings.enPaymentsPermissions.Delete);
        }


        //Manage payment methods strip menu
        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewPaymentMethod, (int)clsSettings.enPaymentsPermissions.Add);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_UpdatePaymentMethod, (int)clsSettings.enPaymentsPermissions.Update);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_DeletePaymentMethod, (int)clsSettings.enPaymentsPermissions.Delete);
        }


        //Searching
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;//Ensure only digits allowed
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _Filter();

        }

        private void cbxSearchFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Filter();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
