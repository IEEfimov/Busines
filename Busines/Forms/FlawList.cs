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
    public partial class FlawList : Form
    {
        DataHelper sql = new DataHelper();
        public FlawList()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dataGrid.Rows.Clear();
            Flaw[] flaw = sql.findAllFlaws();
            for (int i = 0; i < flaw.Length; i++)
            {
                Product temp = sql.findProduct(flaw[i].ProductID);
                dataGrid.Rows.Add();
                dataGrid.Rows[i].Cells[0].Value = flaw[i].ID.ToString();
                dataGrid.Rows[i].Cells[1].Value = temp.Name;
                dataGrid.Rows[i].Cells[2].Value = temp.Info;
                dataGrid.Rows[i].Cells[3].Value = flaw[i].Count.ToString();
                dataGrid.Rows[i].Cells[4].Value = flaw[i].Price.ToString();
            }
        }
        private void AddData()
        {
            AddFlaw addFlaw = new AddFlaw();
            addFlaw.ShowDialog();
            LoadData();
        }
        private void EditData()
        {
            int index = dataGrid.SelectedRows[0].Index;
            Flaw temp = sql.findFlaw(Int32.Parse(dataGrid.Rows[index].Cells[0].Value.ToString()));
            AddFlaw addFlaw = new AddFlaw();
            addFlaw.changeFlaw(temp);
            LoadData();
        }
        private void DeleteSelected()
        {
            int index;
            while (dataGrid.SelectedRows.Count > 1)
            {
                index = dataGrid.SelectedRows[0].Index;
                sql.deleteFlaw(Int32.Parse(dataGrid.Rows[index].Cells[0].Value.ToString()));
                dataGrid.Rows.RemoveAt(index);
            }
            index = dataGrid.SelectedRows[0].Index;
            sql.deleteFlaw(Int32.Parse(dataGrid.Rows[index].Cells[0].Value.ToString()));
            dataGrid.Rows.RemoveAt(index);
        }

        private void FlawList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DeleteSelected();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EditData();
        }

        private void dataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditData();
        }

        public void addFlaw()
        {
            AddData();
        }
    }
}
