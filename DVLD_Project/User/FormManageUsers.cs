using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.User
{
    public partial class FormManageUsers : Form
    {
        private enum enFilterType
        {
            None = 0, UserID = 1, PersonID = 2, UserName = 3, FullName = 4, IsActive = 5
        }
        private enFilterType  _SelectedFilter = enFilterType.None;

        private enum enFilterIsActive { No = 0, Yes = 1, All = 2 }
        private enFilterIsActive _IsActive = enFilterIsActive.All;

        DataTable dtUsers;
        public FormManageUsers()
        {
            InitializeComponent();
        }


        private void _SelectDefaultFilterType()
        {
            cbFilterType.SelectedIndex = (byte)_SelectedFilter;
        }
        private void _SelectDefaultFilterIsActive()
        {
            cbFilterIsActive.SelectedIndex = (byte)_IsActive;
        }
        private string _GetTextCurrentFilterType()
        {
            string[] ArrFilterType  = { "None", "UserID", "PersonID", "UserName", "FullName", "IsActive" };
            return ArrFilterType[(byte)_SelectedFilter];
        }
        private void __GetModifationTheDesignOfUsersList()
        {
            if (dgvUsersList.Rows.Count > 0)
            {
                dgvUsersList.Columns["UserID"].HeaderText = "User ID";
                dgvUsersList.Columns["UserID"].Width = 119;

                dgvUsersList.Columns["PersonID"].HeaderText = "Person ID";
                dgvUsersList.Columns["PersonID"].Width = 119;

                dgvUsersList.Columns["FullName"].HeaderText = "Full Name";
                dgvUsersList.Columns["FullName"].Width = 550;

                dgvUsersList.Columns["UserName"].HeaderText = "UserName";
                dgvUsersList.Columns["UserName"].Width = 180;

                dgvUsersList.Columns["IsActive"].HeaderText = "Is Active";
                dgvUsersList.Columns["IsActive"].Width = 180;

            }
        }
        private void _RefreshUsersList()
        {
            _ShowUsersList();
            _ShowNumberRows();
        }
        private void _ShowNumberRows()
        {
            lblNumberRecords.Text = dgvUsersList.RowCount.ToString();
        }
        private void _ShowUsersList()
        {
            dtUsers = clsUser.GetAllUsers();
            dgvUsersList.DataSource = dtUsers;
        
            __GetModifationTheDesignOfUsersList();
        }
        private void _RefreshTextBox_tbFilterText()
        {
            tbFilterText.Clear();
            tbFilterText.Focus();
        }
        private void _FilteringUsersListBy(string FilterType, string FilterText)
        {
            if(_SelectedFilter == enFilterType.UserID || _SelectedFilter == enFilterType.PersonID
               || 
               _SelectedFilter == enFilterType.IsActive)

            {
                dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterType, FilterText);
            }

            else
            {
                dtUsers.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterType, FilterText);
            }


            _ShowNumberRows();
        }
        private void OpenFormAddNewUser()
        {
            FormAddUpdateUser frm = new FormAddUpdateUser();
            frm.ShowDialog();
            _RefreshUsersList();
        }
        private void OpenUserDetailsForm()
        {
           FormUserDetails frm  = new FormUserDetails(((int)dgvUsersList.CurrentRow.Cells[0].Value));
           frm.ShowDialog();
        }






        private void FormManageUsers_Load(object sender, EventArgs e)
        {
            _SelectDefaultFilterType();
            _RefreshUsersList();
        }


        private void cbFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectedFilter = (enFilterType)cbFilterType.SelectedIndex;
            


            switch (_SelectedFilter)
            {
                case enFilterType.None:
                {
                    cbFilterIsActive.Visible = false;
                    tbFilterText.Visible = false;
                    _RefreshUsersList();
                    break;
                }
                case enFilterType.IsActive:
                {
                    cbFilterIsActive.Visible = true;
                    tbFilterText.Visible = false;
                    _SelectDefaultFilterIsActive();
                   
                    break;
                }
                default:
                {
                    cbFilterIsActive.Visible = false;
                    tbFilterText.Visible = true;
                    _RefreshTextBox_tbFilterText();
                    break;
                }
                    
            }
            
        }


        private void cbFilterIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            _IsActive = (enFilterIsActive)cbFilterIsActive.SelectedIndex;

            if(_IsActive == enFilterIsActive.All)
            {
                _RefreshUsersList();
            }
            else
            {
                _FilteringUsersListBy(_GetTextCurrentFilterType(),((byte)_IsActive).ToString());
            }

            
        }


        private void tbFilterText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_SelectedFilter == enFilterType.PersonID || _SelectedFilter == enFilterType.UserID)
                e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar));
        }


        private void tbFilterText_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbFilterText.Text))
            {
                _RefreshUsersList();
                return;
                
            }

             _FilteringUsersListBy(_GetTextCurrentFilterType(), tbFilterText.Text);

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnAddUser_Click(object sender, EventArgs e)
        {
            OpenFormAddNewUser();
        }


        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormAddNewUser();
        }


        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddUpdateUser frm = new FormAddUpdateUser((int)dgvUsersList.CurrentRow.Cells["UserID"].Value);
            frm.ShowDialog();
            _RefreshUsersList();
        }


        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChangePassword frm = new FormChangePassword((int)dgvUsersList.CurrentRow.Cells["UserID"].Value);
            frm.ShowDialog();
            _RefreshUsersList();
        }


        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!"
                            , "Not Ready!"
                            , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!"
                            , "Not Ready!"
                            , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsersList.CurrentRow.Cells["UserID"].Value;

            if (MessageBox.Show($"Are You Sure You Want To Delete CreatedByUserInfo With ID [ {UserID} ]"
                            , "Confirm Delete."
                            , MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if(clsUser.DeleteUser(UserID))
                {
                    MessageBox.Show("CreatedByUserInfo Deleted Successfully."
                        , "Successfully."
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _RefreshUsersList();
                }
                else
                {
                    MessageBox.Show("CreatedByUserInfo Was Not Deleted Because It Has Data Linked To It."
                        , "Error."
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenUserDetailsForm();
        }


        private void dgvUsersList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OpenUserDetailsForm();
        }
    }
}
