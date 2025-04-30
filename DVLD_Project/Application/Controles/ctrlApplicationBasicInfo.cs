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
    public partial class ctrlApplicationBasicInfo : UserControl
    {

        private clsApplication _Application = null;
        public clsApplication ApplicationInfo { get  { return _Application; } }

        public int ApplicationID
        {
            get { return (_Application == null) ? -1 : _Application.ApplicationID; }
        }

        public ctrlApplicationBasicInfo()
        {
            InitializeComponent();
        }

        public void LoadApplicationInfo(int ApplicationID)
        {
            _Application = clsApplication.Find(ApplicationID);

            if (!(llblViewPersonInfo.Visible = !(_Application == null)))
            {
                MessageBox.Show($"The Application With ID [{ApplicationID}] Was No Found!","Error"
                    ,MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }


            lblID.Text = _Application.ApplicationID.ToString();
            lblStatus.Text = _Application.StatusText;
            lblFees.Text = _Application.PaidFees.ToString();
            lblType.Text = _Application.ApplicationTypeInfo.Title;
            lblApplicant.Text = _Application.ApplicationPersonInfo.FullName;
            lblDate.Text = _Application.ApplicationDate.ToString("dd/MMM/yyyy");
            lblStatusDate.Text = _Application.LastStatusDate.ToString("dd/MMM/yyyy");
            lblCreatedBy.Text = _Application.CreatedByUserInfo.UserName;

        }

        private void llblViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormPersonDetails frm = new FormPersonDetails(_Application.ApplicationPersonInfo.PersonID);
            frm.ShowDialog();
        }
    }
}
