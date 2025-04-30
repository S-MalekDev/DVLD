using DVLD_BusinessLayer;
using DVLD_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class FormListTestAppointmerts : Form
    {

        private int _LocalDrivingLicenseAppID = -1;

        private clsTestType.enTestType _SelectedTestType;
        public FormListTestAppointmerts(int LocalDrivingLicenseAppID, clsTestType.enTestType Type)
        {
            InitializeComponent();
            _LocalDrivingLicenseAppID = LocalDrivingLicenseAppID;
            _SelectedTestType = Type;
            _PerepareTheForm();
        }
        private void _PrepareTheTitleAndTheImage()
        {
            switch (_SelectedTestType)
            {
                case clsTestType.enTestType.VisionTest:
                    {
                        this.Text = "Vision Test Appointments.";
                        lblAppointmentTittle.Text = "Vision Test Appointments";
                        pbTestImage.Image = Resources.Vision_512;
                        break;
                    }
                case clsTestType.enTestType.WrittenTest:
                    {
                        this.Text = "Written Test Appointments.";
                        lblAppointmentTittle.Text = "Written Test Appointments";
                        pbTestImage.Image = Resources.Written_Test_512;
                        break;
                    }
                case clsTestType.enTestType.PracticalTest:
                    {
                        this.Text = "Driving Test Appointments.";
                        lblAppointmentTittle.Text = "Driving Test Appointments";
                        pbTestImage.Image = Resources.Driving_test;
                        break;
                    }
            } 
                
        }
        private void _PerepareTheForm()
        {
            _PrepareTheTitleAndTheImage();
            ctrlLocalDrivingLicenseApplicationInfo1.ShowLicenseInfoEnebled = false;
        }
        private void _MakeModificationToDesign_dgvAppointmentsList()
        {
            if(dgvAppointmentsList.Rows.Count > 0)
            {
                dgvAppointmentsList.Columns[0].Width = 200;
                dgvAppointmentsList.Columns[1].Width = 300;
                dgvAppointmentsList.Columns[2].Width = 200;
                dgvAppointmentsList.Columns[3].Width = 100;
            }
        }
        private void _ShowListOfAppointments()
        {
            dgvAppointmentsList.DataSource = clsTestAppointments.GetAllAppointmentsBy_LDL_AppID_TestType(_LocalDrivingLicenseAppID, (byte)_SelectedTestType);
            _MakeModificationToDesign_dgvAppointmentsList();
        }
        private void _ShowNumberRecordes()
        {
            lblNumberRecords.Text = dgvAppointmentsList.RowCount.ToString();
        }
        private void _RefreshListAppointments()
        {
            _ShowListOfAppointments();
            _ShowNumberRecordes();
        }
        private void _ShowInfoOfLocalDrivingLicenseApp()
        {
            ctrlLocalDrivingLicenseApplicationInfo1.LoadLocalDrivingLicenseAppInfo(_LocalDrivingLicenseAppID);
        }


        private void FormSechduleTests_Load(object sender, EventArgs e)
        {
            _ShowInfoOfLocalDrivingLicenseApp();
            _RefreshListAppointments();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {

            if(clsTestAppointments.IsHaveAnAppointmentActiveOfTestType(_LocalDrivingLicenseAppID, (byte)_SelectedTestType))
            {
                MessageBox.Show("The Person Already Have An Active Appointment For This Test, You Cannot Add New Appointment."
                    ,"Not Allowed",MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            if(clsTestAppointments.DidHePassTheTest(_LocalDrivingLicenseAppID, (byte)_SelectedTestType))
            {
                MessageBox.Show("The Person Already Was Took The Test And Passed It Successfully."
                    , "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FormScheduleTest frm = new FormScheduleTest(ctrlLocalDrivingLicenseApplicationInfo1.LocalLicenseApplicationInfo.LocalDrivingLicenseApplicationID);
            frm.ShowDialog();
            _RefreshListAppointments();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormScheduleTest frm = new FormScheduleTest(ctrlLocalDrivingLicenseApplicationInfo1.LocalLicenseApplicationInfo.LocalDrivingLicenseApplicationID);
            frm.ShowDialog();
            _RefreshListAppointments();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTakeTest frm = new FormTakeTest((int)dgvAppointmentsList.CurrentRow.Cells[0].Value,_SelectedTestType);
            frm.ShowDialog();
            FormSechduleTests_Load(null,null);
        }

        private void dgvAppointmentsList_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            takeTestToolStripMenuItem.Enabled = !(bool)dgvAppointmentsList.CurrentRow.Cells["Is Locked"].Value;
            editToolStripMenuItem.Enabled = takeTestToolStripMenuItem.Enabled;
        }
    }
}
