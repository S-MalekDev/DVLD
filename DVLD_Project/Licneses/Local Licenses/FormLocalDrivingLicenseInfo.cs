﻿using DVLD_BusinessLayer;
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
    public partial class FormLocalDrivingLicenseInfo : Form
    {
        public FormLocalDrivingLicenseInfo(int ID, bool IsLicenseID = false)
        {
            InitializeComponent();


            if (IsLicenseID == true)
                ctrlShowLicneseInfo1.ShowLicenseInfoByLicenseID(ID);
            else
            ctrlShowLicneseInfo1.ShowLicenseInfoByLocalDrivingLicenseAppID(ID);
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
