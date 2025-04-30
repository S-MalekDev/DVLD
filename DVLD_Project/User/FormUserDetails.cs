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
    public partial class FormUserDetails : Form
    {
        public FormUserDetails(int UserID)
        {
            InitializeComponent();
            ctrlUserDetails1.VisibleEditPerson = false;
            ctrlUserDetails1.ShowUserDetails(UserID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
