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
    public partial class frmManagePeople : Form
    {

        private DataView _dvPeopleList = new DataView();

        private int _CurrentUserPermissions;

        private Action<Action, int> _CheckIfUserAccess;

     

        private void _Refresh()
        {
            timer1.Enabled = true;
            lblTimeDate.Text = clsUtility.DateTimeString();

            _RefreshPeopleList();
            _PreparePeopleList();

            cbxPeopleSort.SelectedIndex = 0;//Set default index value for ComboBox
        }

        private void _PreparePeopleList()
        {
            //Adjust columns widths
            dgvPeopleList.Columns["PersonID"].Width = 70;
            dgvPeopleList.Columns["FirstName"].Width = 70;
            dgvPeopleList.Columns["LastName"].Width = 70;
            dgvPeopleList.Columns["Gender"].Width = 50;
            dgvPeopleList.Columns["DateOfBirth"].Width = 70;
            dgvPeopleList.Columns["Address"].Width = 115;
            dgvPeopleList.Columns["Email"].Width = 120;
            dgvPeopleList.Columns["ImagePath"].Width = 80;
        }

        private void _RefreshPeopleList()
        {
            _dvPeopleList = clsPerson.GetPersonsList().DefaultView;
            dgvPeopleList.DataSource = _dvPeopleList;
        }


        private void _ShowAllList()
        {
            _dvPeopleList.RowFilter = "";//Show All List
        }

        private void _PeopleSort()
        {
            string Sort = Convert.ToString(cbxPeopleSort.SelectedItem);
            string Order = " Asc";
            if (rbDescending.Checked)
                Order = " Desc";

            _dvPeopleList.Sort = Sort + Order;
        }

        private void _SearchFilter(string Filter)
        {
            string[] FilterString = Filter.Split(' ');
            if (FilterString.Length > 1) //If search box has more than one word
                _dvPeopleList.RowFilter = $"FirstName like '{FilterString[0]}%' and LastName like '{FilterString[1]}%'";
            else
                _dvPeopleList.RowFilter = $"FirstName like '{FilterString[0]}%' or LastName like '{FilterString[0]}%'";
        }


        private void _AddNewPerson()
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(-1);
            frm.ShowDialog();

            _RefreshPeopleList();
        }

        private void _UpdatePerson()
        {
            if (dgvPeopleList.SelectedCells.Count > 0)
            {
                int SelectedPersonID = (int)dgvPeopleList.CurrentRow.Cells["PersonID"].Value;

                if (clsPerson.IsExist(SelectedPersonID))
                {
                    frmAddUpdatePerson frm = new frmAddUpdatePerson(SelectedPersonID);
                    frm.ShowDialog();

                    _RefreshPeopleList();
                }
                else
                    MessageBox.Show($"Person with ID = {SelectedPersonID} not found!", "No Result!"
                       , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("There is no person selected", "Error");
        }

        private void _DeletePerson()
        {
            if (dgvPeopleList.SelectedCells.Count > 0)
            {
                int ID = (int)dgvPeopleList.CurrentRow.Cells["PersonID"].Value;

                //Confirm deletion with the user
                if (MessageBox.Show($"Do you want to delete person with ID = {ID}?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (clsPerson.Delete(ID))
                        _RefreshPeopleList();
                    else
                        MessageBox.Show("Delete Operation Failed, Maybe this person is connected with Student Or Instructor"
                            , "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("There is no Person selected!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public frmManagePeople(int CurrentUserPermissions, Action <Action, int>CheckIfUserAccess)
        {
            InitializeComponent();

            _CurrentUserPermissions = CurrentUserPermissions;

            _CheckIfUserAccess = CheckIfUserAccess;
        }
           
        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimeDate.Text = clsUtility.DateTimeString();
        }

        private void frmManagePeople_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                _SearchFilter(txtSearch.Text);
            }
            else
                MessageBox.Show("The Search Field is empty. Please Type Name to search.", "Attention");
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            _ShowAllList();
        }


        //Manage people buttons
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewPerson, (int)clsSettings.enPeoplePermissions.Add);
        }

        private void btnUpdatePerson_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_UpdatePerson, (int)clsSettings.enPeoplePermissions.Update);         
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_DeletePerson, (int)clsSettings.enPeoplePermissions.Delete);
        }


        //Manage poeple strip menu
        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_AddNewPerson, (int)clsSettings.enPeoplePermissions.Add);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_UpdatePerson, (int)clsSettings.enPeoplePermissions.Update);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckIfUserAccess(_DeletePerson, (int)clsSettings.enPeoplePermissions.Delete);
        }


        //Sorting and searching
        private void cbxPeopleSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            _PeopleSort();
        }

        private void rbAscending_CheckedChanged(object sender, EventArgs e)
        {
            _PeopleSort();
        }

        private void btnShowAll1_Click(object sender, EventArgs e)
        {
            _ShowAllList();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Press enter ==> Search
                e.SuppressKeyPress = true;//To prevent enter sound
                btnSearch_Click(sender, e);
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
