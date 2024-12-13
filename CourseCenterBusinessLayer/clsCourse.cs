using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CourseCenterDataLayer;

namespace CourseCenterBusinessLayer
{
    public class clsCourse
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;

        public int ID { get; set; }
        public string Name { get; set; }
        public int InstructorID { get; set; }
        public short CreditHours { get; set; }
        public decimal CourseFee { get; set; }

        public clsCourse()
        {
            this.ID = -1;
            this.Name = string.Empty;
            this.InstructorID = -1;
            this.CreditHours = -1;
            this.CourseFee = -1;

            _Mode = enMode.AddNew;
        }

        private clsCourse(int iD, string name, int instructorID, short creditHours, decimal courseFee)
        {
            this.ID = iD;
            this.Name = name;
            this.InstructorID = instructorID;
            this.CreditHours = creditHours;
            this.CourseFee = courseFee;

            _Mode = enMode.Update;
        }

        private bool _AddNewCourse()    
        {
            this.ID = clsCourseData.AddNewCourse(this.Name, this.InstructorID, this.CreditHours, this.CourseFee);
            return this.ID != -1;
        }

        private bool _UpdateCourse()
        {
            return clsCourseData.UpdateCourse(this.ID, this.Name, this.InstructorID, this.CreditHours, this.CourseFee);
        }

        public static bool Delete(int ID)
        {
            return clsCourseData.DeleteCourse(ID);
        }

        public static clsCourse Find(int ID)
        {
            int InstructorID = -1;
            short CreditHours = -1;
            string Name = string.Empty;
            decimal CourseFee = -1;

            if (clsCourseData.FindCourseByID(ID, ref Name, ref InstructorID, ref CreditHours, ref CourseFee))
                return new clsCourse(ID, Name, InstructorID, CreditHours, CourseFee);
            return null;
        }

        public static clsCourse Find(string Name)
        {
            int ID = -1, InstructorID = -1;
            short CreditHours = -1;
            decimal CourseFee = -1;

            if (clsCourseData.FindCourseByName(ref ID, Name, ref InstructorID, ref CreditHours, ref CourseFee))
                return new clsCourse(ID, Name, InstructorID, CreditHours, CourseFee);
            return null;
        }

        public static bool IsExist(int ID)
        {
            return clsCourseData.IsCourseExist(ID);
        }

        public static bool IsExist(string Name)
        {
            return clsCourseData.IsCourseExist(Name);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewCourse())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        return false;
                    }
                case enMode.Update:
                    {
                        if (_UpdateCourse())
                            return true;
                        return false;
                    }
            }
            return false;
        }

        public static DataTable GetCoursesList()
        {
            return clsCourseData.GetAllCourses();
        }

        public static DataTable GetInstructorCourses(int InstructorID)
        {
            return clsCourseData.GetInstructorCourses(InstructorID);
        }

        public static DataTable GetCompletedCourses()
        {
            return clsCourseData.GetCompleteCourses();
        }

        public static int Count()
        {
            return clsCourseData.CountCourses();
        }

        public static int CountInstructorCourses(int InstructorID)
        {
            return clsCourseData.CountInstructorCourses(InstructorID);
        }

        public static int CountInstructors()
        {
            return clsCourseData.CountInstructorsTeachCourses();
        }
    }
}
