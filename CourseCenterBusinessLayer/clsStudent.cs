using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseCenterDataLayer;

namespace CourseCenterBusinessLayer
{
    public class clsStudent
    {
        private enum enMode { AddNew = 0, Update =  1 }
        private enMode _Mode = enMode.AddNew;
        
        public int ID { get; set; }
        public int PersonID { get; set; }
        public int LevelID { get; set; }

        public clsStudent()
        {
            this.ID = -1;
            this.PersonID = -1;
            this.LevelID = -1;

            _Mode = enMode.AddNew;
        }

        private clsStudent(int iD, int personID, int levelID)
        {
            this.ID = iD;
            this.PersonID = personID;
            this.LevelID = levelID;
            
            _Mode = enMode.Update;
        }

        private bool _AddNewStudent()
        {
            this.ID = clsStudentData.AddNewStudent(this.PersonID, this.LevelID);
            return this.ID != -1;
        }

        private bool _UpdateStudent()
        {
            return clsStudentData.UpdateStudent(this.ID, this.PersonID, this.LevelID);
        }

        public static bool Delete(int ID)
        {
            return clsStudentData.DeleteStudent(ID);
        }

        public static clsStudent Find(int ID)
        {
            int PersonID = -1, LevelID = -1;

            if (clsStudentData.FindStudentByID(ID, ref PersonID, ref LevelID)) 
                return new clsStudent(ID, PersonID, LevelID);
            return null;
        }

        public static bool IsExist(int ID)
        {
            return clsStudentData.IsStudentExist(ID); 
        }

        public static bool IsPersonIDExist(int PersonID)
        {
            return clsStudentData.IsPersonIDExist(PersonID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewStudent())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        return false;
                    }
                case enMode.Update:
                    {
                        if (_UpdateStudent())
                            return true;
                        return false;
                    }
            }
            return false;
        }

        public static DataTable GetStudentsList()
        {
            return clsStudentData.GetAllStudents();
        }

        public static int Count()
        {
            return clsStudentData.CountStudents();
        }

        public static string GetFullName(int ID)
        {
            return clsStudentData.GetStudentFullName(ID);
        }

    }
}
