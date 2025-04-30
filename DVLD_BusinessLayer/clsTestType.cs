using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsTestType
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;

        public  enum enTestType {VisionTest=1, WrittenTest=2, PracticalTest=3}
        public Int32 TestTypeID { get; set; }
        public String TestTypeTitle { get; set; }
        public String TestTypeDescription { get; set; }
        public Decimal TestTypeFees { get; set; }


        public clsTestType()
        {
            TestTypeID = default;
            TestTypeTitle = default;
            TestTypeDescription = default;
            TestTypeFees = default;

            _Mode = enMode.AddNew;
        }
        private clsTestType(Int32 TestTypeID, String TestTypeTitle, String TestTypeDescription, Decimal TestTypeFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;

            _Mode = enMode.Update;
        }
        static public DataTable GetAllTestTypes()
        {
            return clsDataTestType.GetAllTestTypes();
        }

        static public clsTestType Find(Int32 TestTypeID)
        {

            String TestTypeTitle = default;
            String TestTypeDescription = default;
            Decimal TestTypeFees = default;


            if (clsDataTestType.GetTestTypeInfoByID(TestTypeID, ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees))
            {
                return new clsTestType(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
            }
            else
            {
                return null;
            }

        }

        private bool _AddNewTestType()
        {
            this.TestTypeID = clsDataTestType.AddNewTestType(this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);

            return TestTypeID != -1;
        }

        private bool _UpdateTestType()
        {
            return clsDataTestType.UpdateTestType(this.TestTypeID, this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);
        }

        static public decimal GetFeesTestType(enTestType Type)
        {
            return clsDataTestType.GetFeesTestType((byte)Type);
        }

        static public bool DeleteTestType(Int32 TestTypeID)
        {
            return clsDataTestType.DeleteTestType(TestTypeID);
        }

        static public bool IsTestTypeExist(Int32 TestTypeID)
        {
            return clsDataTestType.IsTestTypeExist(TestTypeID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewTestType())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }
                case enMode.Update:
                    {
                        return _UpdateTestType();

                    }
                default:
                    {
                        return false;
                    }
            }

        }


    }



    
}
