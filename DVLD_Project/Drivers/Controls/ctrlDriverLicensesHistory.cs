using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class ctrlDriverLicensesHistory : UserControl
    {
        clsDrivers TheDriver;
        public ctrlDriverLicensesHistory()
        {
            InitializeComponent();
        }

        private void _LoadInternationalLicnesesOfTheDriver()
        {
            dgvInternationalLicenseHistory.DataSource = TheDriver.GetInternationalLicense();
        }

        private void _GetModificationToDesign_dgvInternationalLicenseHistory()
        {
            if (dgvInternationalLicenseHistory.Rows.Count > 0)
            {
                dgvInternationalLicenseHistory.Columns[0].Width = 60;
                dgvInternationalLicenseHistory.Columns[1].Width = 160;
                dgvInternationalLicenseHistory.Columns[2].Width = 200;
                dgvInternationalLicenseHistory.Columns[3].Width = 180;
                dgvInternationalLicenseHistory.Columns[4].Width = 180;
                dgvInternationalLicenseHistory.Columns[5].Width = 110;

            }
        }
        private void _ShowNumberRecoredsInternationalLicenses()
        {
            lblNumberRecordsInternationalLicenses.Text = dgvInternationalLicenseHistory.Rows.Count.ToString();
        }
        private void _LoadLocalLicensesOfTheDriver()
        {
            dgvLocalLicensesHistory.DataSource = TheDriver.GetAllLicesnes() ;
        }
        private void _GetModificationToDesign_dgvLocalLicensesHistory()
        {
            if (dgvLocalLicensesHistory.Rows.Count > 0)
            {
                dgvLocalLicensesHistory.Columns[0].Width = 60;
                dgvLocalLicensesHistory.Columns[1].Width = 100;
                dgvLocalLicensesHistory.Columns[2].Width = 300;
                dgvLocalLicensesHistory.Columns[3].Width = 150;
                dgvLocalLicensesHistory.Columns[4].Width = 170;
                dgvLocalLicensesHistory.Columns[5].Width = 110;

            }

        }
        private void _ShowNumberRecoredsLocalLicenses()
        {
            lblNumberRecordsLocalLicenses.Text = dgvLocalLicensesHistory.Rows.Count.ToString();
        }

        public void LoadDrivingLicensesHistorybyDriverID(int DriverID)
        {
            if((TheDriver = clsDrivers.Find(DriverID))==null)
            {
                MessageBox.Show($"The driver with id = {DriverID} is not found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            _ShowListLocalLicensesOfTheDriver();
            _ShowListInternationalLicensesOfTheDriver();
        }

        private void _ShowListInternationalLicensesOfTheDriver()
        {
            _LoadInternationalLicnesesOfTheDriver();
            _GetModificationToDesign_dgvInternationalLicenseHistory();
            _ShowNumberRecoredsInternationalLicenses();
        }


        private void _ShowListLocalLicensesOfTheDriver()
        {
            _LoadLocalLicensesOfTheDriver();
            _GetModificationToDesign_dgvLocalLicensesHistory();
            _ShowNumberRecoredsLocalLicenses();
        }

        private void ShowLicenseInfo_Tool_cmsLocalLicenses_Click(object sender, EventArgs e)
        {
            FormLocalDrivingLicenseInfo frm = new FormLocalDrivingLicenseInfo((int)dgvLocalLicensesHistory.CurrentRow.Cells[0].Value,true);
            frm.ShowDialog();
        }

        private void ShowLicenseInfo_Tool_cmsInternationalLicense_Click(object sender, EventArgs e)
        {
            FormShowInternationalLicenseDetails frm = new FormShowInternationalLicenseDetails((int)dgvInternationalLicenseHistory.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}

