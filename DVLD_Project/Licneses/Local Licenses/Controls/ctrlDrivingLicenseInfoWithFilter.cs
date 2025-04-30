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
    public partial class ctrlDrivingLicenseInfoWithFilter : UserControl
    {

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
            get { return _FilterEnabled; }
        }

        public clsLicenses SelectedLicenseInfo { get { return ctrlShowLicneseInfo1.SelectedLicenseInfo; } }
        public int LicenseID { get { return ctrlShowLicneseInfo1.LicenseID; } }
        public void FilterFocus()
        {
            tbFilter.Focus();
        }

        public event Action<int> OnSelectedLicense;
        protected virtual void SelectedLicense(int LicenseID)
        {
            Action<int> Handler = OnSelectedLicense;
            if(Handler!=null) Handler(LicenseID);
        }

        public ctrlDrivingLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        public void LoadLicenseInfo(int LicenseID)
        {
            tbFilter.Text = LicenseID.ToString();

            if(!clsLicenses.IsLicenseExistWithLicenseID(LicenseID))
            {
                MessageBox.Show("The license with id = " + LicenseID + " is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           ctrlShowLicneseInfo1.ShowLicenseInfoByLicenseID(LicenseID);

            if(OnSelectedLicense != null && FilterEnabled)
                OnSelectedLicense(LicenseID);
        }
        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar));

            if (e.Handled == true) errorProvider1.SetError(tbFilter, "You must to enter only digites");
            else errorProvider1.SetError(tbFilter, null);

            if (e.KeyChar == (char)13) btnFilter.PerformClick();
        }

        private void tbFilter_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilter.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbFilter, "Please, enter a license ID");
            }
            else errorProvider1.SetError(tbFilter, null);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("The field of the filter is required","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    

            int LicenseID = Convert.ToInt32(tbFilter.Text);
            LoadLicenseInfo(LicenseID);
        }
    }
}
