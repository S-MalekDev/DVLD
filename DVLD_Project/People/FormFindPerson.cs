using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class FormFindPerson : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler BackEvent;

        private int _PersonID=-1;
        public FormFindPerson()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_PersonID != -1)
                BackEvent?.Invoke(this, _PersonID);

            this.Close();
        }

        private void ctrlPersonCartWithFilter1_OnPersonSelected(int obj)
        {
            _PersonID = obj;            
        }

    }
}
