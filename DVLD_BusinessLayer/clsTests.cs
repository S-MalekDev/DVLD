using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsTests
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;
        public Int32 TestID { get; set; }
        public Int32 TestAppointmentID { get; set; }
        public Boolean TestResult { get; set; }
        public String Notes { get; set; }
        public Int32 CreatedByUserID { get; set; }

        private clsTestAppointments _TestAppointmentInfo = null;
        public clsTestAppointments TestAppointmentInfo { get { return _TestAppointmentInfo; } }


        private clsUser _UserInfo = null;
        public clsUser UserInfo { get { return _UserInfo; } }


        public clsTests()
        {
            TestID = default;
            TestAppointmentID = default;
            TestResult = default;
            Notes = default;
            CreatedByUserID = default;

            _Mode = enMode.AddNew;
        }
        private clsTests(Int32 TestID, Int32 TestAppointmentID, Boolean TestResult, String Notes, Int32 CreatedByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;

            _TestAppointmentInfo = clsTestAppointments.Find(TestAppointmentID);
            _UserInfo = clsUser.FindByUserID(CreatedByUserID);

            _Mode = enMode.Update;
        }
        static public DataTable GetAllTests()
        {
            return clsDataTests.GetAllTests();
        }

        static public clsTests Find(Int32 TestID)
        {

            Int32 TestAppointmentID = default;
            Boolean TestResult = default;
            String Notes = default;
            Int32 CreatedByUserID = default;


            if (clsDataTests.GetTestInfoByID(TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
            {
                return new clsTests(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            }
            else
            {
                return null;
            }

        }

        private bool _AddNewTest()
        {
            this.TestID = clsDataTests.AddNewTest(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);

            return TestID != -1;
        }

        private bool _UpdateTest()
        {
            return clsDataTests.UpdateTest(this.TestID, this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
        }

        static public bool DeleteTest(Int32 TestID)
        {
            return clsDataTests.DeleteTest(TestID);
        }

        static public int GetNumberTestsPassedWithLocalDrivingLicenseAppID(int LocalDrivingLicenseAppID)
        {
            return clsDataTests.GetNumberTestsPassedWithLocalDrivingLicenseAppID(LocalDrivingLicenseAppID);
        }
        static public bool IsTestExist(Int32 TestID)
        {
            return clsDataTests.IsTestExist(TestID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewTest())
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
                        return _UpdateTest();

                    }
                default:
                    {
                        return false;
                    }
            }

        }


    }






}
