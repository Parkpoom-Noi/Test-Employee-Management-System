using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;


namespace Employee_Management_System_VC
{
    public partial class fromAdd : Form
    {
        frmMain fMain;
        public fromAdd(frmMain frmMain)
        {
            InitializeComponent();
            fMain = frmMain;
        }

        private void fromAdd_Load(object sender, EventArgs e)
        {
            dtpBirth.CustomFormat = "dd/MM/yyyy";
            dtpBirth.Format = DateTimePickerFormat.Custom;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int _Gender = new int();
            if (rbMale.Checked == true)
            {
                _Gender = 1;
            }
            else if (rbFemale.Checked == true)
            {
                _Gender = 2;
            }
            else 
            {
                MessageBox.Show("Please select Gender!");
                return;
            }

            int _Position = new int();
            if (cbPosition.Text == "Programmer")
            {
                _Position = 1;
            }
            else if (cbPosition.Text == "System Analyst")
            {
                _Position = 2;
            }
            else if (cbPosition.Text == "Tester")
            {
                _Position = 3;
            }
            else
            {
                MessageBox.Show("Please select Position!");
                return;
            }
            string _bDate = dtpBirth.Value.Date.ToString("yyyy-MM-dd");
            if(BLL_Load.InsertToDB(tbName.Text, tbSname.Text, _bDate, _Gender, _Position) == 1)
            {
                MessageBox.Show("Add Employee complete!");
               
                fMain.DGV_reLOAD();
                Close();

            }
            else
            {
                MessageBox.Show("Add Employee not complete!"); 
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
