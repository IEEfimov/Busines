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
    public partial class SaledProductList : Form
    {
        DataHelper sql = new DataHelper();

        public SaledProductList()
        {
            InitializeComponent();
        }

        public SaledProductList(Admin admin)
        {
            InitializeComponent();
            this.MdiParent = admin;
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index;
            while (dataGrid.SelectedRows.Count > 1)
            {
                index = dataGrid.SelectedRows[0].Index;
                sql.deleteSaledProduct(Int32.Parse(dataGrid.Rows[index].Cells[0].Value.ToString()));
                dataGrid.Rows.RemoveAt(index);
            }
            index = dataGrid.SelectedRows[0].Index;
            sql.deleteSaledProduct(Int32.Parse(dataGrid.Rows[index].Cells[0].Value.ToString()));
            dataGrid.Rows.RemoveAt(index);
        }

        private void знайтиТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGrid.SelectedRows[0].Index;
            Product temp = sql.findProduct(Int32.Parse(dataGrid.Rows[index].Cells[1].Value.ToString()));
            AddProductForm addProduct = new AddProductForm();
            addProduct.viewProduct(temp);
            LoadData();
        }

        private void знайтиКлієнтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGrid.SelectedRows[0].Index;
            Client temp = sql.findClient(Int32.Parse(dataGrid.Rows[index].Cells[2].Value.ToString()));
            AddClientForm editor = new AddClientForm();
            editor.LookForClient(temp);
        }

        private void LoadData()
        {
            dataGrid.Rows.Clear();
            SaledProduct[] saleds = sql.findAllSaledProducts();
            for (int i = 0; i < saleds.Length; i++)
            {
                Product tempProduct = sql.findProduct(saleds[i].productID);
                Client tempClient = sql.findClient(saleds[i].clientID);
                dataGrid.Rows.Add();
                dataGrid.Rows[i].Cells[0].Value = saleds[i].ID.ToString();
                dataGrid.Rows[i].Cells[1].Value = tempClient.Surname + " " + tempClient.Name;
                dataGrid.Rows[i].Cells[2].Value = tempProduct.Name;
                dataGrid.Rows[i].Cells[3].Value = saleds[i].count.ToString();
            }
        }

        private void SaledProductList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
