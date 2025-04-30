using DVLD_BusinessLayer;
using DVLD_Classes;
using DVLD_Project.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Remoting.Channels;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class FormAddEditPerson : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;


        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        private int _PersonID = -1;

        private clsPeople _Person;
        public FormAddEditPerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            _Person = new clsPeople();
        }
        public FormAddEditPerson(int PersonID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _PersonID = PersonID;

        }
        private void _SelectGedorWithValue(byte gendor)
        {
            rbFemale.Checked = (gendor == 1);
            rbMale.Checked = (gendor == 0);
        }
        private void _SelectCountryWithValue(short CountryID)
        {
            clsCountries Country = clsCountries.Find(CountryID);
            if (Country != null)
            {
                cbCountry.SelectedItem = Country.CountryName;
            }
        }
        private void _LoadInfoThePersonOnTheForm()
        {
            _Person = clsPeople.Find(_PersonID);
            if (_Person == null)
            {
                MessageBox.Show($"No Person With ID [ {_PersonID} ]", "Person No Found!!!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            else
            {
                lblPersonID.Text = $"[ {_Person.PersonID.ToString()} ]";
                tbFirstName.Text = _Person.FirstName;
                tbSecondName.Text = _Person.SecondName;
                tbLastName.Text = _Person.LastName;
                tbNationalNo.Text = _Person.NationalNo;
                dtpDateOfBirth.Value = _Person.DateOfBirth;
                _SelectGedorWithValue(_Person.Gendor);
                _SelectCountryWithValue(_Person.NationalityCountryID);
                mtbPhone.Text = _Person.Phone;
                tbAddress.Text = _Person.Address;

                if (!string.IsNullOrEmpty(_Person.Email))
                {
                    tbEmail.Text = _Person.Email;
                }

                if (!string.IsNullOrEmpty(_Person.ThirdName))
                {
                    tbThirdName.Text = _Person.ThirdName;

                }

                if (!string.IsNullOrEmpty(_Person.ImagePath))
                {
                    pbPersonImage.ImageLocation = _Person.ImagePath;
                    llblRemove.Visible = true;
                    llblSetImage.Visible = false;
                }
            }


        }
        private void _SelectDefaultCountryInComboBoxCountries(string CountryName)
        {
            cbCountry.SelectedItem = CountryName;
        }
        private void _FillComboBoxCountriesCountries()
        {
            DataTable Countries = clsCountries.GetAllCountries();
            foreach (DataRow Country in Countries.Rows)
            {
                cbCountry.Items.Add(Country["CountryName"]);
            }

        }
        private void _LoadDefaultPuctures()
        {
            if (rbFemale.Checked)
            {
                pbPersonImage.Image = Resources.Female_512;
            }
            else if (rbMale.Checked)
            {
                pbPersonImage.Image = Resources.Male_512; 
            }
        }
        private byte _GetGendorValue()
        {
            //0 => Male   // 1=> Female
            byte Gendor = (rbFemale.Checked) ? Convert.ToByte(1) : Convert.ToByte(0);
            return Gendor;
        }
        private short _GetNationalityCountryID()
        {
            clsCountries Country = clsCountries.Find(cbCountry.SelectedItem.ToString());
            return Country.CountryID;
        }
        private string _UpperTheFirstLetterFromString(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            str = char.ToUpper(str[0]) + str.Substring(1, str.Length - 1);
            return str;
        }
        private void _LoadInfoThePersonInObject()
        {
            _Person.FirstName = tbFirstName.Text.Trim().ToUpper();
            _Person.SecondName = _UpperTheFirstLetterFromString(tbSecondName.Text.Trim());

            if (!string.IsNullOrEmpty(tbThirdName.Text))
                _Person.ThirdName = _UpperTheFirstLetterFromString(tbThirdName.Text.Trim());

            _Person.LastName = _UpperTheFirstLetterFromString(tbLastName.Text.Trim());
            _Person.NationalNo = _UpperTheFirstLetterFromString(tbNationalNo.Text.Trim());

            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.Gendor = _GetGendorValue();
            _Person.Phone = mtbPhone.Text;

            if (!string.IsNullOrEmpty(tbEmail.Text))
                _Person.Email = tbEmail.Text;

            _Person.NationalityCountryID = _GetNationalityCountryID();
            _Person.Address = _UpperTheFirstLetterFromString(tbAddress.Text.Trim());

            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
                _Person.ImagePath = pbPersonImage.ImageLocation;
        }
        private void _SpecifyTheMinAndMaxDateOfBirth()
        {
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);
        }
        private bool _ValidateEmail(string Email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return regex.IsMatch(Email);
        }
        private void _ResetDefaultValues()
        {
            _FillComboBoxCountriesCountries();
            _SelectDefaultCountryInComboBoxCountries("Algeria");
            _SpecifyTheMinAndMaxDateOfBirth();
            _LoadDefaultPuctures();

            if (_Mode == enMode.AddNew)
            {
                lblAddEditPerson.Text = "Add New Person";
            }
            if (_Mode == enMode.Update)
            {
                lblAddEditPerson.Text = "Update Person";
            }
        }
        private bool HandlePersonImage()
        {
            if (pbPersonImage.ImageLocation != _Person.ImagePath)
          {
                if(!string.IsNullOrEmpty(_Person.ImagePath))
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException ioe)
                    {
                        
                    }
                }

                
                if (!string.IsNullOrEmpty(pbPersonImage.ImageLocation))
                {

                        string SourceImagePath = pbPersonImage.ImageLocation.ToString();

                    if (clsUtil.CopieImageToProjectImagesFolder(ref SourceImagePath))
                    {

                        pbPersonImage.ImageLocation = SourceImagePath;

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error An error occurred while loading the image into the system.","Error"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
          }



            return true;
        }


        private void FormAddEditPerson_Load(object sender, EventArgs e)
        {

            _ResetDefaultValues();

            if(_Mode == enMode.Update)
            _LoadInfoThePersonOnTheForm(); 
        }

        private void tbValidaton(object sender, CancelEventArgs e)//Validation Text Boxes With First, Second And Last Name//Vlidation Text Box Address

        {
            if (String.IsNullOrEmpty(((TextBox)sender).Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(((TextBox)sender), "This Field Is Required!");
            }
            else
                errorProvider1.SetError(((TextBox)sender),null);

        }

        private void tbNationalNo_Validating(object sender, CancelEventArgs e)
        {
            string NationalNo = tbNationalNo.Text.Trim();

            if (String.IsNullOrEmpty(NationalNo))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNationalNo, "This Field Is Required!");
                
            }
            else if (_Mode == enMode.AddNew && clsPeople.IsExist(NationalNo))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNationalNo, "The NationalNo You Entered Already Exists In System.");
            }
            else if (_Mode == enMode.Update && _Person.NationalNo != NationalNo && clsPeople.IsExist(NationalNo))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNationalNo, "National Number Is Used For Another Person!");
            }
            else
                errorProvider1.SetError(tbNationalNo,null);
        }

        private void mtbPhone_Validating(object sender, CancelEventArgs e)
        {

            if (!mtbPhone.MaskFull)
            {
                e.Cancel = true;
                errorProvider1.SetError(mtbPhone, "This Field Is Required!");
            }
            else
                errorProvider1.SetError(mtbPhone, null);
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            string Email = tbEmail.Text;

            if (!String.IsNullOrEmpty(Email) && !_ValidateEmail(Email))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbEmail, "The Email You Entered Is Invalid.");
            }
            else
                errorProvider1.SetError(tbEmail, null);
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == String.Empty)
                _LoadDefaultPuctures();
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

            if(openFileDialog1.FileName == String.Empty)
                _LoadDefaultPuctures();
        }

        private void llblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Users\DELL\Desktop\Course#19 FullRealProject DVLD\PeoplePictures";
            openFileDialog1.Title = "Download Picture";
            openFileDialog1.Filter = "Pictures (jpg,png,jpeg,jfif) |*.jfif;*.jpg;*.jpeg;*.png;|All Files|*.*";
            openFileDialog1.FilterIndex = 0;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbPersonImage.Load(openFileDialog1.FileName);
                llblRemove.Visible = true;
                llblSetImage.Visible = false;
            }
        }

        private void llblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.FileName = string.Empty;
            llblRemove.Visible = false;
            llblSetImage.Visible = true;

            _LoadDefaultPuctures();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("You Must Enter All Required Information Before Retrying The Save Operation."
                    , "Saved Failled."
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!HandlePersonImage())
            {
                MessageBox.Show("An Error Occurred While Uploading The Image To The System. Please Try Again."
                    , "Error."
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadInfoThePersonInObject();
           
            if (_Person.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
           
                lblPersonID.Text = $"[ {_Person.PersonID} ]";
           
                DataBack?.Invoke(this, _Person.PersonID);
            }
            else
            {
                MessageBox.Show("Error: Data Not Saved Successfully.", "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
