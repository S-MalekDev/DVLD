using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DVLD_BusinessLayer;
using DVLD_Classes;

namespace DVLD_Project
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        string LoginInfo = string.Empty;
        

        private void FormLogin_Load(object sender, EventArgs e)
        {
            string Username = string.Empty, Password = string.Empty; 
            
            if(clsGlobal.GetStoredCredential(ref Username, ref Password))
            {
                tbUsername.Text = Username;
                tbPassword.Text = Password;
                chbRememberMe.Checked = true;
            }
            else
            {
                tbUsername.Focus();
                chbRememberMe.Checked=false;
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            clsUser User = clsUser.FindByUsernameAndPassword(tbUsername.Text,clsUtil.ComputeHash(tbPassword.Text));

            if(User == null)
            {
                MessageBox.Show("Invalid Username / Password.","Wrong Credintials"
                    ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbUsername.Focus ();
                return;
            }

            if(!User.IsActive)
            {
                MessageBox.Show("You Can't Log In, This Account Is Deactive Please Call Admin","Account Deactive!"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Warning);

                return;
            }

            clsGlobal.RememberUsernameAndPassword(tbUsername.Text,tbPassword.Text,chbRememberMe.Checked);
            clsGlobal.CurrentUser = User;

            this.Hide();
            FormMain frm = new FormMain(this);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
