using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseCenterDataLayer;

namespace CourseCenterBusinessLayer
{
    public class clsLevel
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public clsLevel()
        {
            ID = -1;
            Name = string.Empty;
            Description = string.Empty;

            _Mode = enMode.AddNew;
        }

        private clsLevel(int ID, string Name, string Description)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;

            _Mode = enMode.Update;
        }

        private bool _AddNewLevel()
        {
            this.ID = clsLevelData.AddNewLevel(this.Name, this.Description);
            return this.ID != -1;
        }

        private bool _UpdateLevel()
        {
            return clsLevelData.UpdateLevel(this.ID, this.Name, this.Description) ;
        }

        public static bool Delete(int ID)
        {
            if (clsLevelData.DeleteLevel(ID)) 
                return true;
            return false;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewLevel())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        return false;
                    }
                case enMode.Update:
                    {
                        if (_UpdateLevel())
                            return true;
                        return false;
                    }
            }
            return false;
        }

        public static clsLevel Find(int ID)
        {
            string Name = string.Empty, Description = string.Empty;

            if (clsLevelData.FindLevelByID(ID, ref Name, ref Description))
                return new clsLevel(ID, Name, Description);
            return null;
        }

        public static clsLevel Find(string Name)
        {
            int ID = -1;
            string Description = string.Empty;

            if (clsLevelData.FindLevelByName(Name, ref ID, ref Description))
                return new clsLevel(ID, Name, Description);
            return null;
        }

        public static bool IsExist(int ID)
        {
            return clsLevelData.IsLevelExist(ID);
        }

        public static DataTable GetAllLevels()
        {
            return clsLevelData.GetAllLevels();
        }
    }
}
