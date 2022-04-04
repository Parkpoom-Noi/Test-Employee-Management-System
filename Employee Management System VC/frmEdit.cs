using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Employee_Management_System_VC
{
    public partial class frmEdit : Form
    {
        frmMain fMain;
        public string _ID;
        public frmEdit(string _gID, frmMain frmMain)
        {
            InitializeComponent();
            _ID = _gID; 
            fMain = frmMain;
        } 
        private void frmEdit_Load(object sender, EventArgs e)
        { 
            DataTable dtEdit = BLL_Load.SelectToEdit(_ID);
            if (dtEdit.Rows.Count > 0)
            {
                for (int i = 0; i < dtEdit.Rows.Count; i++)
                {
                    tbID.Text = dtEdit.Rows[i]["EmployeeID"].ToString();
                    tbName.Text = dtEdit.Rows[i]["Name"].ToString();
                    tbSname.Text = dtEdit.Rows[i]["Surname"].ToString();
                    dtpBirth.Value = Convert.ToDateTime(dtEdit.Rows[i]["Birthday"]);
                    dtpBirth.CustomFormat = "dd/MM/yyyy";
                    dtpBirth.Format = DateTimePickerFormat.Custom;

                    if (dtEdit.Rows[i]["GenderID"].ToString() == "1")
                    {
                        rbMale.Checked = true;
                        rbFemale.Checked = false;

                    }
                    else
                    {
                        rbMale.Checked = false;
                        rbFemale.Checked = true;
                    }  
                if (dtEdit.Rows[i]["PositionID"].ToString() == "1")
                    {
                        cbPosition.Text = "Programmer";
                        cbPosition.Items.Add("Programmer");
                        cbPosition.Items.Add("System Analyst");
                        cbPosition.Items.Add("Tester");

                }
                    else if (dtEdit.Rows[i]["PositionID"].ToString() == "2")
                    {
                        cbPosition.Text = "System Analyst";
                        cbPosition.Items.Add("Programmer");
                        cbPosition.Items.Add("System Analyst");
                        cbPosition.Items.Add("Tester");
                    }
                else
                    {
                        cbPosition.Text = "Tester";
                        cbPosition.Items.Add("Programmer");
                        cbPosition.Items.Add("System Analyst");
                        cbPosition.Items.Add("Tester");
                    }
            }
        }

        } 

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int _Gender = new int();
            if (rbMale.Checked = true)
            {
                _Gender = 1;
            }
            else if (rbFemale.Checked = true)
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
            if (BLL_Load.UpdateToDB(tbName.Text, tbSname.Text, _bDate, _Gender, _Position, tbID.Text) == 1)
            {
                MessageBox.Show("Edit Employee complete!");
                fMain.DGV_reLOAD();
                Close();

            }
            else
            {
                MessageBox.Show("Edit Employee not complete!");
            }


        }
    }
}
