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
    public partial class frmActiveStudentsInCoursesList : Form
    {

        private DataView dvActiveStudentsList = new DataView();

        private void _DisplayNumberOfActiveStudents()
        {
            lblNumberOfActiveStudents.Text = clsEnrollment.CountActiveStudent().ToString();
        }

        private void _RefreshActiveStudentsList()
        {
            dvActiveStudentsList = clsEnrollment.GetActiveStudentsList().DefaultView;
            dgvActiveStudentsList.DataSource = dvActiveStudentsList;
        }

        private void _Refresh()
        {
            _DisplayNumberOfActiveStudents();
            _RefreshActiveStudentsList();           
        }

        public frmActiveStudentsInCoursesList()
        {
            InitializeComponent();
        }

        private void frmActiveStudentsList_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
      
    }
}
