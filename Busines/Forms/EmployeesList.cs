using Busines.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Busines.Forms
{
    public partial class EmployeesList : Form
    {
        DataHelper sql = new DataHelper();

        public EmployeesList()
        {
            InitializeComponent();
        }

        public EmployeesList(Admin admin)
        {
            InitializeComponent();
            this.MdiParent = admin;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            addData();
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditData();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteSelected();
        }

        private void LoadData()
        {
            dataGrid.Rows.Clear();
            Employee[] employees = sql.findAllEmployees();
            for (int i = 0; i < employees.Length; i++)
            {
                string temp = employees[i].Surname + " " + employees[i].Name + " " + employees[i].SecondName;
                DateTime zeroTime = new DateTime(1, 1, 1);
                TimeSpan ageTemp = (DateTime.Now - employees[i].Born);
                int years = (zeroTime + ageTemp).Year - 1;
                dataGrid.Rows.Add();
                dataGrid.Rows[i].Cells[0].Value = employees[i].ID.ToString();
                dataGrid.Rows[i].Cells[1].Value = temp;
                dataGrid.Rows[i].Cells[2].Value = years.ToString();
                dataGrid.Rows[i].Cells[3].Value = employees[i].Position.ToString();
                dataGrid.Rows[i].Cells[4].Value = employees[i].Salary.ToString();
               
            }
        }

        private bool DeleteSelected()
        {
            int index;
            while (dataGrid.SelectedRows.Count > 1)
            {
                index = dataGrid.SelectedRows[0].Index;
                sql.deleteEmployee(Int32.Parse(dataGrid.Rows[index].Cells[0].Value.ToString()));
                dataGrid.Rows.RemoveAt(index);
            }
            index = dataGrid.SelectedRows[0].Index;
            sql.deleteEmployee(Int32.Parse(dataGrid.Rows[index].Cells[0].Value.ToString()));
            dataGrid.Rows.RemoveAt(index);
            return true;
        }
        private void addData()
        {
            AddEmployee add = new AddEmployee();
            add.ShowDialog();
            LoadData();

        }
        private void EditData()
        {
            int index = dataGrid.SelectedRows[0].Index;
            Employee temp = sql.findEmployee(Int32.Parse(dataGrid.Rows[index].Cells[0].Value.ToString()));
            AddEmployee editor = new AddEmployee();
            if (editor.editEmployee(temp)) LoadData();
        }

        private void EmployeesList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void додатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addData();
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelected();
        }

        private void зміToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditData();
        }

        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditData();
        }


    }
}
