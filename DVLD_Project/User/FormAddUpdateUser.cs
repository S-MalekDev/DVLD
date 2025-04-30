using DVLD_BusinessLayer;
using DVLD_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.User
{
    public partial class FormAddUpdateUser : Form
    {
        public delegate void BackDataDelegateHandle(object sender, int UserID);
        public event BackDataDelegateHandle BackData;

        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;


        private clsUser _User = new clsUser();
        private int _UserID=-1;

        public FormAddUpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

            AddNewFormPreparation();
        }

        public FormAddUpdateUser(int UserID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _UserID = UserID;

            UpdateFormPreparation();
        }

        private void AddNewFormPreparation()
        {
            this.Text = "Add New User";
            lblAddUpdateUser.Text = "Add New User";
            btnNext.Enabled = false;
            plLoginInfo.Enabled = false;
        }

        private void UpdateFormPreparation()
        {
            this.Text = "Update User";
            lblAddUpdateUser.Text = "Update User";
            btnNext.Enabled = true;
            plLoginInfo.Enabled = true;

            ctrlPersonCartWithFilter1.FilterEnabled = false;
        }

        private void LoadUserLoginInfo()
        {
            _User = clsUser.FindByUserID(_UserID);

            if (_User == null)
            {
                MessageBox.Show("No CreatedByUserInfo With ID [{}], CreatedByUserInfo Not Found", "Not Found"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            ctrlPersonCartWithFilter1.LoadPersonInfo(_User.PersonID);

            lblUserID.Text = _User.UserID.ToString();
            tbUsername.Text = _User.UserName.ToString();
            tbPassword.Text = _User.Password.ToString();
            tbConfirmPassword.Text = _User.Password.ToString();
            chbIsActive.Checked = _User.IsActive;
        }

        private void FormAddUpdateUser_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
                LoadUserLoginInfo();
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(_Mode == enMode.AddNew && clsUser.IsExistForPersonID(_User.PersonID))
            {
                MessageBox.Show("Selected Person Already Has a CreatedByUserInfo, Choose Another One."
                    , "Select Another Person."
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            tcAddNewUser.SelectedTab = tcAddNewUser.TabPages["LoginInfo"];

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void ctrlPersonCartWithFilter1_OnPersonSelected(int obj)
        {
            btnNext.Enabled = true;
            plLoginInfo.Enabled = true;
            _User.PersonID = obj;
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(tbUsername.Text))
            { 
                e.Cancel = true;
                errorProvider1.SetError(tbUsername, "This Field Is Required!");
            }
            else if (clsUser.IsExist(tbUsername.Text))
            {
                e.Cancel=true;
                errorProvider1.SetError(tbUsername, "The Username You Entered Already Exists");
            }
            else
            {
                errorProvider1.SetError(tbUsername,null);
            }


        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPassword, "This Field Is Required!");
            }
            else if (tbPassword.Text.Length < 4)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPassword, "The Password Must Be At Least Four Characters Long!");
            }
            else
            {
                errorProvider1.SetError(tbPassword, null);
            }
        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbConfirmPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbConfirmPassword, "This Field Is Required!");
            }
            else if (tbPassword.Text != tbConfirmPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbConfirmPassword, "The Password Does Not Match!");
            }
            else
            {
                errorProvider1.SetError(tbConfirmPassword, null);
            }
        }

        private void LoadUserInfoToAnObject()
        {
            _User.UserName = tbUsername.Text.Trim();
            _User.Password = clsUtil.ComputeHash(tbPassword.Text.Trim());
            _User.IsActive = chbIsActive.Checked;
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

            LoadUserInfoToAnObject();

            if(_User.Save())
            {
                MessageBox.Show("The User Saved Successfully."
                    , "Saved Success."
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblUserID.Text = _User.UserID.ToString();

                if (_Mode == enMode.AddNew)
                    BackData?.Invoke(this, _User.UserID);
            }
            else
            {
                MessageBox.Show("The User Does Not Save."
                    , "Saved Faild."
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        
    }
}
