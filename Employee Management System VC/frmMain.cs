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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DGV_reLOAD();
        }
        public void DGV_reLOAD()
        {
        
            DGV_EMP.Columns.Clear();
            DGV_EMP.DataSource = BLL_Load.SelectToDataGrid();

            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();

            btnEdit.HeaderText = "Edit";
            btnEdit.Text = "Edit";
            btnEdit.Name = "btnEdit";
            btnEdit.UseColumnTextForButtonValue = true;
            DGV_EMP.Columns.Insert(1, btnEdit);

            btnDelete.HeaderText = "Delete";
            btnDelete.Text = "Delete";
            btnDelete.Name = "btnDelete";
            btnDelete.UseColumnTextForButtonValue = true;
            DGV_EMP.Columns.Insert(2, btnDelete);
        }

        private void DGV_EMP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1) // Edit
            {
                string _ID = DGV_EMP.Rows[e.RowIndex].Cells[3].Value.ToString();
                var fEdit = new frmEdit(_ID, this);
                fEdit.Show(); 

            }
            else if (e.ColumnIndex == 2) // Delete
            {
                String _ID = ""; 
                _ID = DGV_EMP.Rows[e.RowIndex].Cells[3].Value.ToString();
                string message = "Do you want to delete : " + DGV_EMP.Rows[e.RowIndex].Cells[4].Value + " " + DGV_EMP.Rows[e.RowIndex].Cells[5].Value + " ? ";
                string title = "Delete Employee";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    if ( BLL_Load.DeletesFromDB(_ID) == 1)
                    {
                        MessageBox.Show("Delete record complete!", "complete!", MessageBoxButtons.OK);
                        DGV_reLOAD();
                    }
                    else
                    {
                        MessageBox.Show("Delete record not complete!", "not complete!", MessageBoxButtons.OK);
                        DGV_reLOAD();
                    }
                    
                }
             
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var fAdd = new fromAdd(this);
            fAdd.ShowDialog();
        }
    }
}
