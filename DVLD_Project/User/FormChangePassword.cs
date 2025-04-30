using DVLD_BusinessLayer;
using DVLD_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.User
{
    public partial class FormChangePassword : Form
    {
        private int _UserID;

        private clsUser _User;
        public FormChangePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            
            ctrlUserDetails1.VisibleEditPerson = false;
        }


        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNewPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNewPassword, "This Field Is Required!");
            }
            else if (tbNewPassword.Text.Length < 4)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNewPassword, "The Password Must Be At Least Four Characters Long!");
            }
            else
            {
                errorProvider1.SetError(tbNewPassword, null);
            }
        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbConfirmPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbConfirmPassword, "This Field Is Required!");
            }
            else if (tbNewPassword.Text != tbConfirmPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbConfirmPassword, "The Password Does Not Match!");
            }
            else
            {
                errorProvider1.SetError(tbConfirmPassword, null);
            }
        }

        private void tbCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            string CurrentPassword = ctrlUserDetails1.UserInfo.Password;

            if (string.IsNullOrEmpty(tbCurrentPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbCurrentPassword, "This Field Is Required!");
            }
            else if (clsUtil.ComputeHash(tbCurrentPassword.Text) != CurrentPassword)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbCurrentPassword, "Password Incorrect.");
            }
            else
            {
                errorProvider1.SetError(tbCurrentPassword, null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

            _User.Password = tbNewPassword.Text;

            if (clsUser.ChangePassword(_UserID,clsUtil.ComputeHash(_User.Password)))
            {
                MessageBox.Show("Password Has Been Changed Successfully."
                    , "Success."
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password Has Not Been Modified."
                    , "Error."
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormChangePassword_Load(object sender, EventArgs e)
        {
            tbCurrentPassword.Focus();

             _User = clsUser.FindByUserID(_UserID);

            if (_User == null)
            {
                MessageBox.Show($"Could Not Find User With ID = {_UserID}", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ctrlUserDetails1.ShowUserDetails(_UserID);

        }
    }
}
