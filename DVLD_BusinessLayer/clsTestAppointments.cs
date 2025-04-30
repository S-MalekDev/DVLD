using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static DVLD_BusinessLayer.clsTestType;

namespace DVLD_BusinessLayer
{
    public class clsTestAppointments
    {
        protected enum enMode { AddNew = 0, Update = 1 }
        protected enMode _Mode;


        public Int32 TestAppointmentID { get; set; }
        public Int32 TestTypeID { get; set; }
        public Int32 LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public Decimal PaidFees { get; set; }
        public Int32 CreatedByUserID { get; set; }
        public Boolean IsLocked { get; set; }
        public Int32 RetakeTestApplicationID { get; set; }

        private clsLocalLicenseApplication _LocalDrivingLicenseAppInfo;
        private clsTestType _TestType;
        private clsUser _UserInfo;


        public clsLocalLicenseApplication LocalDrivingLicenseAppInfo { get { return _LocalDrivingLicenseAppInfo; } }
        public clsTestType TestTypeInfo {  get { return _TestType; } }
        public clsUser UserInfo { get { return _UserInfo; } }
           

        public clsTestAppointments()
        {
            TestAppointmentID = default;
            TestTypeID = default;
            LocalDrivingLicenseApplicationID = default;
            AppointmentDate = default;
            PaidFees = default;
            CreatedByUserID = default;
            IsLocked = default;
            RetakeTestApplicationID = default;

            _LocalDrivingLicenseAppInfo = null;
            _TestType = null;
            _UserInfo = null;
        

            _Mode = enMode.AddNew;
        }
        protected clsTestAppointments(Int32 TestAppointmentID, Int32 TestTypeID, Int32 LocalDrivingLicenseApplicationID, DateTime AppointmentDate, Decimal PaidFees, Int32 CreatedByUserID, Boolean IsLocked, Int32 RetakeTestApplicationID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;

            _LocalDrivingLicenseAppInfo = clsLocalLicenseApplication.Find(LocalDrivingLicenseApplicationID);
            _TestType = clsTestType.Find(TestTypeID);
            _UserInfo = clsUser.FindByUserID(TestTypeID);

            _Mode = enMode.Update;
        }
        static public DataTable GetAllTestAppointments()
        {
            return clsDataTestAppointments.GetAllTestAppointments();
        }

        static public DataTable GetAllAppointmentsBy_LDL_AppID_TestType(int LocalDrivingLicenseAppID, byte TestType)
        {
            return clsDataTestAppointments.GetAllAppointmentsBy_LDL_AppID_TestType(LocalDrivingLicenseAppID, TestType);
        }
        static public clsTestAppointments Find(Int32 TestAppointmentID)
        {

            Int32 TestTypeID = default;
            Int32 LocalDrivingLicenseApplicationID = default;
            DateTime AppointmentDate = default;
            Decimal PaidFees = default;
            Int32 CreatedByUserID = default;
            Boolean IsLocked = default;
            Int32 RetakeTestApplicationID = default;


            if (clsDataTestAppointments.GetTestAppointmentInfoByID(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))
            {
                return new clsTestAppointments(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            }
            else
            {
                return null;
            }

        }


        public bool Locked()
        {
            return clsDataTestAppointments.Locked(this.TestAppointmentID);
        }

        static public bool IsThereALockedAppointment(int LocalDrivingLicenseAppID, byte TestTypeID)
        {
            return clsDataTestAppointments.IsThereALockedAppointment(LocalDrivingLicenseAppID,TestTypeID);
        }
        private bool _AddNewTestAppointment()
        {
            this.TestAppointmentID = clsDataTestAppointments.AddNewTestAppointment(this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);

            return TestAppointmentID != -1;
        }

        private bool _UpdateTestAppointment()
        {
            return clsDataTestAppointments.UpdateTestAppointment(this.TestAppointmentID, this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);
        }

        static public bool DeleteTestAppointment(Int32 TestAppointmentID)
        {
            return clsDataTestAppointments.DeleteTestAppointment(TestAppointmentID);
        }

        static public bool IsTestAppointmentExist(Int32 TestAppointmentID)
        {
            return clsDataTestAppointments.IsTestAppointmentExist(TestAppointmentID);
        }

        static public bool IsHaveAnAppointmentActiveOfTestType(int _LocalDrivingLicenseAppID, byte TestTypeID)
        {
            return clsDataTestAppointments.IsHaveAnAppointmentActiveOfTestType(_LocalDrivingLicenseAppID, TestTypeID);
        }

        static public clsTestAppointments GetTheLastTestAppointmentsByLocalDrivingLicenseAppID(int LocalDrivingLicenseApplicationID)
        {
            int TestAppointmentID = default;
            byte TestTypeID = default;
            DateTime AppointmentDate = default;
            Decimal PaidFees = default;
            Int32 CreatedByUserID = default;
            Boolean IsLocked = default;
            Int32 RetakeTestApplicationID = default;

            if (clsDataTestAppointments.GetTheLastTestAppointmentsByLocalDrivingLicenseAppID(ref TestAppointmentID, ref TestTypeID, LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))
            {
                return new clsTestAppointments(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            }
            else
                return null;
        }

        static public bool DidHePassTheTest(int LocalDrivingLicenseAppID, byte TestTypeID)
        {
            return clsDataTestAppointments.DidHePassTheTest(LocalDrivingLicenseAppID, TestTypeID);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewTestAppointment())
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
                        return _UpdateTestAppointment();

                    }
                default:
                    {
                        return false;
                    }
            }

        }


    }



}
