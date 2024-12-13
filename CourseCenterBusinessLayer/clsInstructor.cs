using CourseCenterDataLayer;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCenterBusinessLayer
{
    public class clsInstructor
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;

        public int ID { get; set; }
        public int PersonID { get; set; }
        public int SpecializationID { get; set; }
        public string Certificates { get; set; }
        public decimal Salary { get; set; }

        public clsInstructor()
        {
            this.ID = -1;
            this.PersonID = -1;
            this.SpecializationID = -1;
            this.Certificates = string.Empty;
            this.Salary = -1;

            _Mode = enMode.AddNew;
        }

        private clsInstructor(int iD, int personID, int specializationID, string Certificates, decimal salary)
        {
            this.ID = iD;
            this.PersonID = personID;
            this.SpecializationID = specializationID;
            this.Certificates = Certificates;
            this.Salary = salary;

            _Mode = enMode.Update;
        }

        private bool _AddNewInstructor()
        {
            this.ID = clsInstructorData.AddNewInstructor(this.PersonID, this.SpecializationID, this.Certificates, this.Salary);
            return this.ID != -1;
        }

        private bool _UpdateInstructor()
        {
            return clsInstructorData.UpdateInstructor(this.ID, this.PersonID, this.SpecializationID, this.Certificates, this.Salary);
        }

        public static bool Delete(int ID)
        {
            return clsInstructorData.DeleteInstructor(ID);
        }

        public static clsInstructor Find(int ID)
        {
            int PersonID = -1, SpecializationID = -1;
            decimal Salary = -1;
            string Certificates = string.Empty;

            if (clsInstructorData.FindInstructorByID(ID, ref PersonID, ref SpecializationID, ref Certificates, ref Salary))
                return new clsInstructor(ID, PersonID, SpecializationID, Certificates, Salary);
            return null;
        }

        public static bool IsExist(int ID)
        {
            return clsInstructorData.IsInstructorExist(ID);
        }

        public static bool IsPersonAddedBefore(int PersonID)
        {
            return clsInstructorData.IsPersonIDExist(PersonID);
        }

        public static int GetPersonID(int ID)
        {
            return clsInstructorData.GetPersonIDByInstructorID(ID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewInstructor())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        return false;
                    }
                case enMode.Update:
                    {
                        if (_UpdateInstructor())
                            return true;
                        return false;
                    }
            }
            return false;
        }

        public static DataTable GetInstructorsList() 
        {
            return clsInstructorData.GetAllInstructors();
        }

        public static int Count()
        {
            return clsInstructorData.CountInstructors();
        }
    }
}
