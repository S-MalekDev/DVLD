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

namespace DVLD_Project.User
{
    public partial class ctrlUserDetails : UserControl
    {
        public ctrlUserDetails()
        {
            InitializeComponent();
        }

        private clsUser _User;

        public clsUser UserInfo
        { get { return _User; } }

        public int _UserID;
        public int UserID 
        {
            get { return _UserID; }
        }

        private bool _VisibleEditPerson = true;
        public bool VisibleEditPerson
        {
            get { return _VisibleEditPerson; }
            set
            {
                _VisibleEditPerson=value;
                ctrlPersonDetails1.VisibleEditPerson = _VisibleEditPerson;
            }
        }
        private void LoadUserDetailsOnForm()
        {
            ctrlPersonDetails1.ShowPersonDetails(_User.PersonID);
            lblUserID.Text = _User.UserID.ToString();
            lblUsername.Text = _User.UserName;
            lblIsActive.Text = (_User.IsActive) ? "Yes" : "No";
        }

        public void ShowUserDetails(int UserID)
        {
            _User = clsUser.FindByUserID(_UserID=UserID);

            if(_User == null)
            {
                MessageBox.Show($"Error: CreatedByUserInfo With ID [{UserID}] Was Not Found", "Error"
                    ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadUserDetailsOnForm();
        }

        
    }
}
