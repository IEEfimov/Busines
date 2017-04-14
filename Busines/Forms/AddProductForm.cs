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
    public partial class AddProductForm : Form
    {
        DataHelper sql = new DataHelper();
        Product product;
        public AddProductForm()
        {
            InitializeComponent();
            product = new Product();
        }

        public void changeProduct(Product product)
        {
            this.product = product;
            NameEdit.Text = product.Name;
            InfoEdit.Text = product.Info;
            CountEdit.Value = (decimal)product.count;
            CostEdit.Text = product.Cost.ToString();
            CostOldEdit.Text = product.CostOld.ToString();
            SaleEdit.Value = (decimal)product.Sale;
            dateTimePicker1.Value = product.Purchase;
            AddBtn.Text = "Зберегти";
            this.Text = "#"+product.ID+" "+product.Name;
            AddBtn.Click -= AddBtn_Click1;
            AddBtn.Click += AddBtn_Click2;
            this.ShowDialog();
        }

        public void viewProduct(Product product)
        {
            this.product = product;
            NameEdit.Text = product.Name;
            InfoEdit.Text = product.Info;
            CountEdit.Value = (decimal)product.count;
            CostEdit.Text = product.Cost.ToString();
            CostOldEdit.Text = product.CostOld.ToString();
            SaleEdit.Value = (decimal)product.Sale;
            dateTimePicker1.Value = product.Purchase;
            AddBtn.Text = "Зберегти";
            this.Text = "#" + product.ID + " " + product.Name;
            AddBtn.Enabled = false;

            this.ShowDialog();
        }

        private void AddBtn_Click2(object sender, EventArgs e)
        {
            product.Name = NameEdit.Text;
            product.Info = InfoEdit.Text;
            product.count = (int)CountEdit.Value;
            product.Cost = Double.Parse(CostEdit.Text.ToString());
            product.CostOld = Double.Parse(CostOldEdit.Text.ToString());
            product.Sale = (double)SaleEdit.Value;
            product.Purchase = dateTimePicker1.Value;

            if (sql.updateProduct(product)) this.Close();
        }
        private void AddBtn_Click1(object sender, EventArgs e)
        {
            product.Name = NameEdit.Text;
            product.Info = InfoEdit.Text;
            product.count = (int)CountEdit.Value;
            product.Cost = Double.Parse(CostEdit.Text.ToString());
            product.CostOld = Double.Parse(CostOldEdit.Text.ToString());
            product.Sale = (double)SaleEdit.Value;
            product.Purchase = dateTimePicker1.Value;

            if (sql.insertProduct(product)) this.Close();

        }

        private void CostOldEdit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double cost0 = Double.Parse(CostOldEdit.Text.ToString());
                double cost1 = cost0 + (cost0 * 0.3);
                CostEdit.Text = cost1.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
