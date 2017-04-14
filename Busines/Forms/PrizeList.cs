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
    public partial class PrizeList : Form
    {
        DataHelper sql = new DataHelper();

        public PrizeList()
        {
            InitializeComponent();
        }

        private void PrizeList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dataGrid.Rows.Clear();
            Prize[] prizes = sql.findAllPrizes();
            for (int i = 0; i < prizes.Length; i++)
            {
                Employee tempEmployee = sql.findEmployee(prizes[i].EmployeeID);
                dataGrid.Rows.Add();
                dataGrid.Rows[i].Cells[0].Value = prizes[i].ID.ToString();
                dataGrid.Rows[i].Cells[1].Value = tempEmployee.Surname + " " + tempEmployee.Name;
                dataGrid.Rows[i].Cells[2].Value = prizes[i].Count.ToString();
            }
        }
    }
}
