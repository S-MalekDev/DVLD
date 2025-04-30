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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace DVLD_Project
{
    public partial class FormManagePeople : Form
    {
        public FormManagePeople()
        {
            InitializeComponent();
        }
        private DataTable _dtPeopel;
        private enum enFilterType
        {
            None=0,PersonID=1,NationalNo=2,FirstName=3,SecondName=4,ThirdName=5
                ,LastName=6,Nationality=7,Gendor=8,Phone=9,Email=10
        }
        private enFilterType _FilterType = enFilterType.None;
        private void _ShowNumberRecords()
        {
            lblNumberRecords.Text = dgvPeopleList.RowCount.ToString();
        }
        private void _GetDefaultValuesToHeaderAndWidth_dgvPeopleList()
        {
            if (dgvPeopleList.Rows.Count > 0)
            {

                dgvPeopleList.Columns[0].HeaderText = "Person ID";
                dgvPeopleList.Columns[0].Width = 115;

                dgvPeopleList.Columns[1].HeaderText = "National No";
                dgvPeopleList.Columns[1].Width = 135;

                dgvPeopleList.Columns[2].HeaderText = "First Name";
                dgvPeopleList.Columns[2].Width = 150;

                dgvPeopleList.Columns[3].HeaderText = "Second Name";
                dgvPeopleList.Columns[3].Width = 150;

                dgvPeopleList.Columns[4].HeaderText = "Third Name";
                dgvPeopleList.Columns[4].Width = 150;

                dgvPeopleList.Columns[5].HeaderText = "Last Name";
                dgvPeopleList.Columns[5].Width = 150;

                dgvPeopleList.Columns[6].HeaderText = "Gendor";
                dgvPeopleList.Columns[6].Width = 80;

                dgvPeopleList.Columns[7].HeaderText = "Date Of Birth";
                dgvPeopleList.Columns[7].Width = 200;

                dgvPeopleList.Columns[8].HeaderText = "Nationality";
                dgvPeopleList.Columns[8].Width = 120;

                dgvPeopleList.Columns[9].HeaderText = "Phone";
                dgvPeopleList.Columns[9].Width = 140;

                dgvPeopleList.Columns[10].HeaderText = "Email";
                dgvPeopleList.Columns[10].Width = 230;


            }
        }
        private void _ShowExistePoepleList()
        {
            _dtPeopel = clsPeople.GetAllPeople();
            dgvPeopleList.DataSource = _dtPeopel;
            _GetDefaultValuesToHeaderAndWidth_dgvPeopleList();
        }
        private void _RefreshPeopleList()
        {
            _ShowExistePoepleList();
            _ShowNumberRecords();
        }
        private void _GetDefaultFilterType()
        { 
            cbFilter.SelectedIndex = (byte)_FilterType;
        }
        private string _GetTextOfCurrentFilterType(enFilterType filterType)
        {

            string[] ArrFilterText = { "None","PersonID", "NationalNo", "FirstName", "SecondName", "ThirdName", "LastName"
                    , "Nationality","Gendor","Phone","Email"};

            return ArrFilterText[(byte)filterType];

        }

        private void FormManagePeople_Load(object sender, EventArgs e)
        {
            _ShowExistePoepleList();
            _ShowNumberRecords();
            _GetDefaultFilterType();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterType = (enFilterType)cbFilter.SelectedIndex;

            if(_FilterType == enFilterType.None)
            {
                tbTextSearch.Visible = false;
            }
            else
            {
                tbTextSearch.Visible = true;
                tbTextSearch.Focus();
                tbTextSearch.Clear();
            }
        }

        private void tbTextSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (cbFilter.SelectedIndex != (byte)enFilterType.PersonID)
               return;

            e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar));
        }

        private void FilteringListPeopleBy(string  filterType, string filterText)
        {
            if(_FilterType == enFilterType.PersonID)
            {
                _dtPeopel.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterType, filterText.Trim());
            }
            else
            {
                _dtPeopel.DefaultView.RowFilter = string.Format("[{0}] LIKE'{1}%'", filterType, filterText.Trim());
            }
        }

        private void tbTextSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbTextSearch.Text))
                FilteringListPeopleBy(_GetTextOfCurrentFilterType(_FilterType), tbTextSearch.Text);

            else
                _dtPeopel.DefaultView.RowFilter = "";



            _ShowNumberRecords();

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            FormAddEditPerson AddPerson = new FormAddEditPerson();
            AddPerson.ShowDialog();
            _RefreshPeopleList(); 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Get the ID of the person whose record was selected.
            int PersonID = int.Parse(dgvPeopleList.CurrentRow.Cells[0].Value.ToString());

            FormAddEditPerson EditPerson = new FormAddEditPerson(PersonID);
            EditPerson.ShowDialog();
            _RefreshPeopleList();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddEditPerson AddPerson = new FormAddEditPerson();
            AddPerson.ShowDialog();
            _RefreshPeopleList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = int.Parse(dgvPeopleList.CurrentRow.Cells[0].Value.ToString());

            if(MessageBox.Show($"Are You Sure You Want To Delete Person With ID [ {PersonID} ]"
                            ,"Confirm Delete."
                            ,MessageBoxButtons.OKCancel, MessageBoxIcon.Information)== DialogResult.OK)
            {

                if(clsPeople.DeletePerson(PersonID))
                {
                    MessageBox.Show("Person Deleted Successfully."
                        , "Successfully."
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _RefreshPeopleList();
                }
                else
                {
                    MessageBox.Show("Person Was Not Deleted Because It Has Data Linked To It."
                        , "Error."
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = int.Parse(dgvPeopleList.CurrentRow.Cells[0].Value.ToString());

            FormPersonDetails formPersonDetails = new FormPersonDetails(PersonID);
            formPersonDetails.ShowDialog();
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

        private void dgvPeopleList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int PersonID = int.Parse(dgvPeopleList.CurrentRow.Cells[0].Value.ToString());

            FormPersonDetails formPersonDetails = new FormPersonDetails(PersonID);
            formPersonDetails.ShowDialog();
            
        }
    }
}
