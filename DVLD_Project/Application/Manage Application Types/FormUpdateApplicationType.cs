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

namespace DVLD_Project.Manage_Application_Types
{
    public partial class FormUpdateApplicationType : Form
    {
        private int _ApplicationTypeID;

        clsApplicationTypes ApplicationType;
        public FormUpdateApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();
            _ApplicationTypeID = ApplicationTypeID;
            
        }

        private void FormUpdateApplicationType_Load(object sender, EventArgs e)
        {
            ApplicationType = clsApplicationTypes.Find(_ApplicationTypeID);
            if (ApplicationType != null)
            {
                lblApplicationTypeID.Text = ApplicationType.ID.ToString();
                tbApplicationTypeTitle.Text = ApplicationType.Title.ToString();
                tbApplicationTypeFees.Text = ApplicationType.Fees.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                MessageBox.Show("Some Feilds Are Required!, Put Muse On Icon(s)", "Error"
                    ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ApplicationType.Title = tbApplicationTypeTitle.Text;
            ApplicationType.Fees = Convert.ToDecimal(tbApplicationTypeFees.Text);

            if(ApplicationType.Save())
            {
                MessageBox.Show("Saved Successfully.", "Success."
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Is Not Saved.", "Error."
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbApplicationTypeFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar));
        }

        private void tbApplicationTypeTitle_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(tbApplicationTypeTitle.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbApplicationTypeTitle, "The Feild is Required!");
            }
            else
                errorProvider1.SetError(tbApplicationTypeTitle, null);
        }

        private void tbApplicationTypeFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbApplicationTypeFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbApplicationTypeFees, "The Feild is Required!");
            }
            else
                errorProvider1.SetError(tbApplicationTypeFees, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
