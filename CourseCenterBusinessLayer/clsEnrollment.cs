using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseCenterDataLayer;

namespace CourseCenterBusinessLayer
{
    public class clsEnrollment
    {
        private enum enMode { AddNew = 0, Update = 1}
        private enMode _Mode = enMode.AddNew;
        
        public int ID {  get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public byte Grade {  get; set; }
        
        public clsEnrollment()
        {
            this.ID = -1;
            this.StudentID = -1;
            this.CourseID = -1;
            this.StartDate = DateTime.MinValue;
            this.EndDate = DateTime.MinValue;
            this.Grade = 101;

            _Mode = enMode.AddNew;
        }

        private clsEnrollment(int iD, int studentID, int courseID, DateTime startDate, DateTime endDate, byte grade)
        {
            this.ID = iD;
            this.StudentID = studentID;
            this.CourseID = courseID;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Grade = grade;

            _Mode = enMode.Update;
        }

        private bool _AddNewEnrollment()
        {
            this.ID = clsEnrollmentData.AddNewEnrollment(this.StudentID, this.CourseID,  this.StartDate, this.EndDate, this.Grade);
            return ID != -1;
        }

        private bool _UpdateEnrollment()
        {
            return clsEnrollmentData.UpdateEnrollment(this.ID, this.StudentID, this.CourseID,  this.StartDate, this.EndDate, this.Grade);
        }

        public static bool Delete(int ID)
        {
            return clsEnrollmentData.DeleteEnrollment(ID);
        }

        public static clsEnrollment Find(int ID)
        {
            int CourseID = -1, StudentID = -1;
            byte Grade = 101;
            DateTime StarDate = DateTime.MinValue, EndDate = DateTime.MinValue;

            if (clsEnrollmentData.FindEnrollmentByID(ID, ref StudentID, ref CourseID,  ref StarDate, ref EndDate, ref Grade))
                return new clsEnrollment(ID, StudentID, CourseID, StarDate, EndDate, Grade);
            return null;
        }

        public static bool IsExist(int ID)
        {
            return clsEnrollmentData.IsEnrollmentExist(ID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewEnrollment())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        return false;
                    }
                case enMode.Update:
                    {
                        if (_UpdateEnrollment())
                            return true;
                        return false;
                    }
            }
            return false;
        }

        public static DataTable GetEnrollmentsList()
        {
            return clsEnrollmentData.GetAllEnrollments();
        }

        public static int Count()
        {
            return clsEnrollmentData.CountEnrollments();
        }

        public static DataTable GetActiveStudentsList()
        {
            return clsEnrollmentData.GetActiveStudentsList();
        }

        public static DataTable GetStudentsListForCourse(int CourseID)
        {
            return clsEnrollmentData.GetStudentsListForCourse(CourseID);
        }

        public static DataTable GetStudentEnrollmentsList(int StudentID)
        {
            return clsEnrollmentData.GetStudentEnrollments(StudentID);
        }

        public static int CountActiveStudent()
        {
            return clsEnrollmentData.CountActiveStudents();
        }

        public static int CountStudentsEnrolledInCourse(int CourseID)
        {
            return clsEnrollmentData.CountStudentsEnrolledInCourse(CourseID);
        }

        public static int CountStudentEnrollments(int StudentID)
        {
            return clsEnrollmentData.CountStudentEnrollments(StudentID);
        }

    }
}
