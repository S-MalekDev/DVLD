using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLayer;

namespace DVLD_Project
{
    public partial class ctrlPersonCartWithFilter : UserControl
    {

        public event Action<int> OnPersonSelected;
        protected virtual void PersonSelected(int personID)
        {
            Action<int> Handler = OnPersonSelected;
            if (Handler != null)
            {
                Handler(PersonID);
            }
        }
        private enum enFilterTypeMode { PersonID = 0, NationalNo = 1 }
        enFilterTypeMode _FilterType = enFilterTypeMode.PersonID;//Default Filter Type Mode;

        public clsPeople SelectedPersonInfo
        {
            get { return ctrlPersonDetails1.ShelectedPersonInfo; }
        }
        public int PersonID 
        {
            get { return ctrlPersonDetails1.PersonID; } 
        }

        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get { return _ShowAddPerson; }

            set
            {
                _ShowAddPerson = value;
                btnAddNew.Visible = _ShowAddPerson;
            }
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }

        private bool _EditPersonVisibled = true;
        public bool EditPersonVisibled
        {
            set
            {
                _EditPersonVisibled = value;
                ctrlPersonDetails1.VisibleEditPerson = _EditPersonVisibled;
            }
            get { return _EditPersonVisibled; }
        }
        public ctrlPersonCartWithFilter()
        {
            InitializeComponent();
        }


        private void _SelectDefaultFilterType()
        {
            cbFilterType.SelectedIndex = (int)enFilterTypeMode.PersonID;
        }

        private void ctrlPersonCartWithFilter_Load(object sender, EventArgs e)
        {
            _SelectDefaultFilterType();
        }

        private void cbFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterType = (enFilterTypeMode)cbFilterType.SelectedIndex;
            tbTextSearch.Clear();
            tbTextSearch.Focus();
        }

        private void tbTextSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
                btnFind.PerformClick();


            if(_FilterType == enFilterTypeMode.PersonID)
            e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar));
            
        }

        public void LoadPersonInfo(int PersonID)
        {
            cbFilterType.SelectedIndex = (byte)enFilterTypeMode.PersonID;
            tbTextSearch.Text = PersonID.ToString();
            _FindAndLoadPersonInfo();
        }

        public void FilterFocus()
        {
            tbTextSearch.Focus();
        }
        private void _FindAndLoadPersonInfo()
        {
            switch (_FilterType)
            {
                case (enFilterTypeMode.PersonID):
                {
                    int PersonID = int.Parse(tbTextSearch.Text);
                    ctrlPersonDetails1.ShowPersonDetails(PersonID);

                    break;
                }
                case (enFilterTypeMode.NationalNo):
                {
                    string NationalNo = tbTextSearch.Text;
                    ctrlPersonDetails1.ShowPersonDetails(NationalNo);

                    break;
                }
                
            }
            if (ctrlPersonDetails1.PersonID != -1)
            {
                if(OnPersonSelected != null && FilterEnabled)
                {
                    OnPersonSelected(ctrlPersonDetails1.PersonID);
                }
            }    

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields Are Not Valide!, Put Muse Over The Red Icon(s) To See The Error","Error"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            _FindAndLoadPersonInfo();
        }

        private void _LoadInfoPersonAfterHisAddedNewly(object sender, int PersonID)
        {
            LoadPersonInfo(PersonID);
            
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FormAddEditPerson AddPerson = new FormAddEditPerson();
            AddPerson.DataBack += _LoadInfoPersonAfterHisAddedNewly;
            AddPerson.ShowDialog();

        }

        private void tbTextSearch_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(tbTextSearch.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbTextSearch, "This Field Is Required!");
            }
            else
            {
                errorProvider1.SetError(tbTextSearch, null);
            }
        }
    }
}
