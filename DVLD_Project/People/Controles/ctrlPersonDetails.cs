using System;
using System.Drawing;
using System.Windows.Forms;
using DVLD_BusinessLayer;
using System.IO;
using DVLD_Project.Properties;

namespace DVLD_Project
{
    public partial class ctrlPersonDetails : UserControl
    {
        public ctrlPersonDetails()
        {
            InitializeComponent();
        }

        private bool _VisibleEditPerson = true;
        public bool VisibleEditPerson
        {
            get { return llblEditPersonInfo.Enabled; }
            set 
            {
                _VisibleEditPerson = value;
                llblEditPersonInfo.Visible = _VisibleEditPerson;
            }
            
        }
        private enum enGendor { Male = 0, Female = 1 }

        private clsPeople _Person = null;
        
        public clsPeople ShelectedPersonInfo  
        {
            get { return _Person; }
        }

        private int _PersonID = -1;
        public int PersonID { get { return _PersonID; } }
        private string _GetPersonFullName()
        {
            string PersonFullName = _Person.FirstName + " " + _Person.SecondName + " ";

            if (!string.IsNullOrEmpty(_Person.ThirdName))
                PersonFullName += _Person.ThirdName + " ";


                PersonFullName +=  _Person.LastName;

            return PersonFullName;
        }

        private enGendor _Gendor;
        private string _GetGendor()
        {
            _Gendor = (enGendor)(_Person.Gendor);

            string Gendor = (_Gendor==enGendor.Male) ? "Male" : "Female";

            return Gendor;
        }
        
        private Bitmap _GetDefaultPictureByGendor()
        {
            if(_Gendor == enGendor.Male)
            {
                return Resources.Male_512;
            }

            else //(Gendor == enGendor.Female)
            {
                return Resources.Female_512;
            }
            
        }
        private void _LoadImagePerson()
        {
            pbGender.Image = (_Gendor == enGendor.Male) ? Resources.Man_32 : Resources.Woman_32;
 
            pbPersonImage.Image = _GetDefaultPictureByGendor();

            string ImagePath = _Person.ImagePath;
            if (!string.IsNullOrEmpty(ImagePath))
            {
                if (File.Exists(_Person.ImagePath))
                {
                    pbPersonImage.ImageLocation = _Person.ImagePath;
                }
                else
                {
                    MessageBox.Show("Could Not Found This Image = " + ImagePath, "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        private void _FillPersonInfo()
        {

            lblPersonID.Text = $"[ {_PersonID=_Person.PersonID} ]";
            lblName.Text = _GetPersonFullName();
            lblNationalNo.Text = _Person.NationalNo;
            lblGendor.Text = _GetGendor();
            lblEmail.Text = _Person.Email;
            lblAddress.Text = _Person.Address;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToString("MM/dd/yyyy");
            lblPhone.Text = _Person.Phone;
            lblCountry.Text = _Person.CountryInfo.CountryName;
            _LoadImagePerson();

        }
        public void ShowPersonDetails(int PersonID)
        {
            _Person = clsPeople.Find(PersonID);

            if (_Person == null)
            {
                MessageBox.Show($"The Person With ID = {PersonID} Was Not Found.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

                _PersonID = -1;
                return;
            }

            _FillPersonInfo();
        }
        public void ShowPersonDetails(string NationalNo)
        {
            _Person = clsPeople.Find(NationalNo);

            if (_Person == null)
            {
                MessageBox.Show($"The Person With National Number = {NationalNo} Was Not Found.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

                _PersonID = -1;
                return;
            }

            _FillPersonInfo();
        }
        private void llblEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_Person == null)
            {
                MessageBox.Show("It is not possible to modify a person who is not in the system.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    


            FormAddEditPerson EditPerson = new FormAddEditPerson(_Person.PersonID);
            EditPerson.ShowDialog();
            ShowPersonDetails(_Person.PersonID);
            
        }
    }
}
