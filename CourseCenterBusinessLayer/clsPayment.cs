using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseCenterDataLayer;

namespace CourseCenterBusinessLayer
{
    public class clsPayment
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;

        public int ID { get; set; }
        public int StudentID {  get; set; }
        public int EnrollmentID { get; set; }
        public decimal OriginalCost { get; set; }
        public byte DiscountPercentage { get; set; }   
        public decimal CostAfterDiscount { get; set; }
        public decimal ActualPayAmount { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public int PaymentMethodID { get; set; }
        public bool IsPaid { get; set; }

        public clsPayment()
        {
            this.ID = -1;
            this.StudentID = -1;
            this.EnrollmentID = -1;
            this.OriginalCost = -1;

            //database have check if discount Percentage exceed 100
            this.DiscountPercentage = 101;

            this.ActualPayAmount = 0;
            this.PaymentMethodID = -1;

            _Mode = enMode.AddNew;
        }

        private clsPayment(int ID, int StudentID, int EnrollmentID, decimal OriginalCost, byte DiscountPercentage
            , decimal CostAfterDiscount, decimal ActualPayAmount, DateTime LastUpdatedDate
            , int PaymentMethodID, bool IsPaid)
        {
            this.ID = ID;
            this.StudentID = StudentID;
            this.EnrollmentID = EnrollmentID;
            this.OriginalCost = OriginalCost;
            this.DiscountPercentage = DiscountPercentage;
            this.CostAfterDiscount = CostAfterDiscount;
            this.ActualPayAmount = ActualPayAmount;
            this.LastUpdatedDate = LastUpdatedDate;
            this.PaymentMethodID = PaymentMethodID;
            this.IsPaid = IsPaid;

            _Mode = enMode.Update;
        }

        private bool _AddNewPayment()
        {
            this.ID = clsPaymentData.AddNewPayment(this.StudentID, this.EnrollmentID, this.OriginalCost
                , this.DiscountPercentage, this.ActualPayAmount, this.PaymentMethodID);
            return ID != -1;
        }

        private bool _UpdatePayment()
        {
            return clsPaymentData.UpdatePayment(this.ID, this.StudentID, this.EnrollmentID, this.OriginalCost
                , this.DiscountPercentage, this.ActualPayAmount, this.PaymentMethodID);
        }

        public static bool Delete(int ID)
        {
            return clsPaymentData.DeletePayment(ID);
        }

        public static bool DeleteByEnrollmentID(int EnrollmentID)
        {
            return clsPaymentData.DeletePaymentByEnrollmentID(EnrollmentID);
        }

        public static clsPayment Find(int ID)
        {
            int StudentID = -1, EnrollmentID = -1, PaymentMethodID = -1;
            decimal CostAfterDiscount = -1;
            decimal OriginalCost = -1, ActualPayAmount = 0;
            byte DiscountPercentage = 101;
            bool IsPaid = false;
            DateTime LastUpdatedDate = DateTime.MinValue;

            if (clsPaymentData.FindPaymentByID(ID, ref StudentID, ref EnrollmentID, ref OriginalCost, ref DiscountPercentage
                , ref CostAfterDiscount, ref ActualPayAmount, ref LastUpdatedDate, ref PaymentMethodID, ref IsPaid))
            {
                return new clsPayment(ID, StudentID, EnrollmentID, OriginalCost, DiscountPercentage, CostAfterDiscount
                    , ActualPayAmount, LastUpdatedDate, PaymentMethodID, IsPaid);
            }
            return null;
        }

        public static clsPayment FindByEnrollmentID(int EnrollmentID)
        {
            int StudentID = -1, ID = -1, PaymentMethodID = -1;
            decimal CostAfterDiscount = -1;
            decimal OriginalCost = -1, ActualPayAmount = 0;
            byte DiscountPercentage = 101;
            bool IsPaid = false;
            DateTime LastUpdatedDate = DateTime.MinValue;

            if (clsPaymentData.FindPaymentByEnrollmentID(ref ID, ref StudentID, EnrollmentID, ref OriginalCost, ref DiscountPercentage
                , ref CostAfterDiscount, ref ActualPayAmount, ref LastUpdatedDate, ref PaymentMethodID, ref IsPaid))
            {
                return new clsPayment(ID, StudentID, EnrollmentID, OriginalCost, DiscountPercentage, CostAfterDiscount
                                    , ActualPayAmount, LastUpdatedDate, PaymentMethodID, IsPaid);
            }
            return null;
        }

        public static bool IsExist(int ID)
        {
            return clsPaymentData.IsPaymentExist(ID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewPayment())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        return false;
                    }
                case enMode.Update:
                    {
                        if (_UpdatePayment())
                            return true;
                        return false;
                    }
            }
            return false;
        }

        public static bool IsPaidAnyAmount(int EnrollmentID)
        {
            return clsPaymentData.IsPaidAnyAmount(EnrollmentID);
        }

        public static bool IsPaidFullAmount(int ID)
        {
            return clsPaymentData.IsPaidFullAmount(ID);
        }

        public static bool IsEnrolmentPaidFullAmount(int  EnrollmentID)
        {
            return clsPaymentData.IsEnrolmentPaidFullAmount(EnrollmentID);
        }

        public static DataTable GetPaymentsList()
        {
            return clsPaymentData.GetAllPayments();
        }

        public static int CountUnPaid()
        {
            return clsPaymentData.CountUnPaidPayments();
        }

        public static decimal GetTotalPayments()
        {
            return clsPaymentData.GetTotalPayments();
        }
    }
}
