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
    public partial class AddFlaw : Form
    {
        DataHelper sql = new DataHelper();
        Flaw flaw;
        Product product;
        public AddFlaw()
        {
            InitializeComponent();
            flaw  = new Flaw();
            product = new Product();
        }

        public void changeFlaw(Flaw flaw)
        {
            this.flaw = flaw;
            this.product = sql.findProduct(flaw.ProductID);
            OrderIDEdit.Text = product.ID.ToString();
            OrderEdit.Text = product.Name;
            CountEdit.Value = flaw.Count;
            SummToPayEdit.Text = flaw.Price.ToString();

            AddBtn.Text = "Зберегти";
            this.Text = product.Name;
            AddBtn.Click -= AddBtn_Click;
            AddBtn.Click += SaveBtn_Click;
            this.ShowDialog();
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                flaw.ProductID = Int32.Parse(OrderIDEdit.Text);
                flaw.Count = (int)CountEdit.Value;
                flaw.Price = Int32.Parse(SummToPayEdit.Text);
                if (sql.insertFlaw(flaw)) this.Close();
            }
            catch (SystemException)
            {

            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                flaw.ProductID = Int32.Parse(OrderIDEdit.Text);
                flaw.Count = (int)CountEdit.Value;
                flaw.Price = Int32.Parse(SummToPayEdit.Text);
                if (sql.updateFlaw(flaw)) this.Close();
            }
            catch (SystemException)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void OrderEdit_Click(object sender, EventArgs e)
        {
            ProductList findProduct = new ProductList();
            Product temp = findProduct.getProduct();

            if (temp != null)
            {
                product = temp;
                OrderIDEdit.Text = product.ID.ToString();
                OrderEdit.Text = product.Name;
                CountEdit.Maximum = product.count;
                double summ = ((double)CountEdit.Value * product.Cost);
                summ -= (summ * (product.Sale / 100));
                SummToPayEdit.Text = "" + summ;

            }

        }


        private void CountEdit_ValueChanged(object sender, EventArgs e)
        {
            SummToPayEdit.Text = (product.Cost * ((int)CountEdit.Value)).ToString();
        }
    }
    
}
