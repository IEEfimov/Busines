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
    public partial class ProductList : Form
    {
        DataHelper sql = new DataHelper();
        bool haveReturn = false;
        public ProductList()
        {
            InitializeComponent();
        }
     
        private void LoadData()
        {
            dataGrid.Rows.Clear();
            Product[] product = sql.findAllProducts();
            for (int i = 0; i < product.Length; i++)
            {
                dataGrid.Rows.Add();
                dataGrid.Rows[i].Cells[0].Value = product[i].ID.ToString();
                dataGrid.Rows[i].Cells[1].Value = product[i].Name.ToString();
                dataGrid.Rows[i].Cells[2].Value = product[i].Info.ToString();
                dataGrid.Rows[i].Cells[3].Value = (product[i].count - sql.getSaledCount(product[i].ID)).ToString();
                dataGrid.Rows[i].Cells[4].Value = product[i].Cost.ToString();
                dataGrid.Rows[i].Cells[5].Value = product[i].Sale.ToString();
            }
        }
        private void AddData()
        {
            AddProductForm addProduct = new AddProductForm();
            addProduct.ShowDialog();
            LoadData();
        }
        private void EditData()
        {
            int index = dataGrid.SelectedRows[0].Index;
            Product temp = sql.findProduct(Int32.Parse(dataGrid.Rows[index].Cells[0].Value.ToString()));
            AddProductForm addProduct = new AddProductForm();
            addProduct.changeProduct(temp);
            LoadData();
        }
        private void DeleteSelected()
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

        private void ProductList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            haveReturn = true;
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            EditData();
        }
        private void AddProduct_Click(object sender, EventArgs e)
        {
            AddData();

        }

        private void dataGrid_CellDoubleClick1(object sender, DataGridViewCellEventArgs e)
        {
            haveReturn = true;
            this.Close();
        }
        private void dataGrid_CellDoubleClick2(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGrid.SelectedRows[0].Index;
            Product temp = sql.findProduct(Int32.Parse(dataGrid.Rows[index].Cells[0].Value.ToString()));
            AddProductForm addProduct = new AddProductForm();
            addProduct.changeProduct(temp);
            LoadData();
        }
      

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddData();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EditData();
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DeleteSelected();
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            haveReturn = true;
            this.Close();
        }
                

        public void addProduct()
        {
            AddData();
        }
        public Product getProduct()
        {
            AddProduct.Text = "Вибарти";
            AddProduct.Click -= AddProduct_Click;
            AddProduct.Click += button1_Click;

            dataGrid.CellDoubleClick -= dataGrid_CellDoubleClick2;
            dataGrid.CellDoubleClick += dataGrid_CellDoubleClick1;


            this.ShowDialog();
            if (!haveReturn) return null;
            int index = dataGrid.SelectedRows[0].Index;
            try
            {
                index = Int32.Parse(dataGrid.Rows[index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

            }

            return sql.findProduct(index);
        }

        
    }
}
