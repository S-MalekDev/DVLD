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
    public partial class FormUpdateTestType : Form
    {
        private clsTestType TestType;
        public FormUpdateTestType(int TestTypeID)
        {
            InitializeComponent();
            TestType = clsTestType.Find(TestTypeID);
        }
        private void _LoadTestTypeDataOnForm()
        {
            lblID.Text = TestType.TestTypeID.ToString();
            tbTitle.Text = TestType.TestTypeTitle.ToString();
            tbDescription.Text = TestType.TestTypeDescription.ToString();
            tbFees.Text = TestType.TestTypeFees.ToString();
        }

        private bool _IsTestTypeModificationSaved()
        {
            TestType.TestTypeTitle= tbTitle.Text;
            TestType.TestTypeDescription= tbDescription.Text;
            TestType.TestTypeFees = Convert.ToDecimal(tbFees.Text);

            return TestType.Save();
        }
        private void FormUpdateTestType_Load(object sender, EventArgs e)
        {
            if(TestType == null)
            {
                MessageBox.Show("The test type not found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            _LoadTestTypeDataOnForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fields you must enter the data in it, put the mouse on the icons to read message error", "Error"
                    ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_IsTestTypeModificationSaved())
                MessageBox.Show("Data saved successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("The data is not saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TextBoxes_Validating(object sender, CancelEventArgs e)
        {
            //Validation For//Fees//Title//Description.
            
            if (string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(((TextBox)sender), "This feild is required!");
            }
            else
                errorProvider1.SetError(((TextBox)sender), null);
        }

        private void tbFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
                errorProvider1.SetError(tbFees, "You cann't entered letters!!!");
            
            else
                errorProvider1.SetError(tbFees,null); 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
