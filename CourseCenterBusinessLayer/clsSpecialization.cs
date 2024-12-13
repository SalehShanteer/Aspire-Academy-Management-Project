using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseCenterDataLayer;

namespace CourseCenterBusinessLayer
{
    public class clsSpecialization
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 

        public clsSpecialization()
        {
            ID = -1;
            Name = string.Empty;
            Description = string.Empty;

            _Mode = enMode.AddNew;
        }

        private clsSpecialization(int ID, string Name, string Description)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;

            _Mode = enMode.Update;
        }

        private bool _AddNewSpecialization()
        {
            this.ID = clsSpecializationData.AddNewSpecialization(this.Name, this.Description);
            return this.ID != -1;
        }

        private bool _UpdateSpecialization()
        {
            return clsSpecializationData.UpdateSpecialization(this.ID, this.Name, this.Description);
        }

        public static bool Delete(int ID)
        {
            if (clsSpecializationData.DeleteSpecialization(ID))
                return true;
            return false;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewSpecialization())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        return false;
                    }
                case enMode.Update:
                    {
                        if (_UpdateSpecialization())
                            return true;
                        return false;
                    }
            }
            return false;
        }

        public static clsSpecialization Find(int ID)
        {
            string Name = string.Empty, Description = string.Empty;

            if (clsSpecializationData.FindSpecializationByID(ID, ref Name, ref Description))
                return new clsSpecialization(ID, Name, Description);
            return null;
        }

        public static clsSpecialization Find(string Name)
        {
            int ID = -1;
            string Description = string.Empty;

            if (clsSpecializationData.FindSpecializationByName(Name, ref ID, ref Description))
                return new clsSpecialization(ID, Name, Description);
            return null;
        }

        public static bool IsExist(int ID)
        {
            return clsSpecializationData.IsSpecializationExist(ID);
        }

        public static DataTable GetAllSpecializations()
        {
            return clsSpecializationData.GetAllSpecializations();
        }

    }
}
