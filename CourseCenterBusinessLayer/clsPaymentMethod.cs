using CourseCenterDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCenterBusinessLayer
{
    public class clsPaymentMethod
    {
        private enum enMode {AddNew = 0, Update = 1}
        private enMode _Mode = enMode.AddNew;
        public int ID { get; set; }
        public string MethodName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public clsPaymentMethod()
        {
            this.ID = -1;
            this.MethodName = string.Empty;
            this.Description = string.Empty;
            this.IsActive = false;

            _Mode = enMode.AddNew;
        }

        private clsPaymentMethod(int ID, string methodName, string description, bool isActive)
        {
            this.ID = ID;
            this.MethodName = methodName;
            this.Description = description;
            this.IsActive = isActive;

            _Mode = enMode.Update;
        }

        private bool _AddNewPaymentMethod()
        {
            return clsPaymentMethodData.AddNewPaymentMethod(this.ID, this.MethodName, this.Description, this.IsActive);
        }

        private bool _UpdatePaymentMethod()
        {
            return clsPaymentMethodData.UpdatePaymentMethod(this.ID, this.MethodName, this.Description, this.IsActive);
        }

        public static clsPaymentMethod Find(int ID)
        {
            string MethodName = string.Empty, Description = string.Empty;
            bool IsActive = false;

            if (clsPaymentMethodData.FindPaymentMethodByID(ID, ref MethodName, ref Description, ref IsActive))
                return new clsPaymentMethod(ID, MethodName, Description, IsActive);
            return null;
        }

        public static clsPaymentMethod Find(string MethodName)
        {
            int ID = -1;
            string Description = string.Empty;
            bool IsActive = false;

            if (clsPaymentMethodData.FindPaymentMethodByName(ref ID, MethodName, ref Description, ref IsActive))
                return new clsPaymentMethod(ID, MethodName, Description, IsActive);
            return null;
        }

        public static bool IsExist(int ID)
        {
            return clsPaymentMethodData.IsPaymentMethodExistByID(ID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewPaymentMethod())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        return false;
                    }
                    case enMode.Update:
                    {
                        if (_UpdatePaymentMethod())
                            return true;
                        return false;
                    }
            }
            return false;
        }

        public static bool Delete(int ID)
        {
            return clsPaymentMethodData.DeletePaymentMethod(ID);
        }

        public static DataTable GetPaymentMethodsList()
        {
            return clsPaymentMethodData.GetAllPaymentMethods();
        }

        public static DataTable GetActivePaymentMethodsList()
        {
            return clsPaymentMethodData.GetActivePaymentMethods();
        }
       

    }
}
