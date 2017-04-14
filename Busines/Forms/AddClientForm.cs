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
    public partial class AddClientForm : Form
    {
        DataHelper sql = new DataHelper();
        Client client = new Client();
        Product product = new Product();
        SaledProduct saled = new SaledProduct();

        public AddClientForm()
        {
            InitializeComponent();
        }

        public void LookForClient(Client client)
        {
            NameEdit.Text = client.Name;
            SurnameEdit.Text = client.Surname;
            TelephoneEdit.Text = client.Telephone;
            PrivatCardEdit.Text = client.PrivateCard;
            AdressEdit.Text = client.Adress;
            OrderIDEdit.Text = client.OrderID.ToString();
            SummToPayEdit.Text = client.SummToPay.ToString();
            DateOrderEdit.Value = client.DateOrder;
            DateRecievEdit.Value = client.DateReceiv;
            DeliveryTypeEdit.Text = client.DeliveryType;
            DeliverCostEdit.Text = client.CostDelivery.ToString();

            saled = sql.findSaledProduct(client.OrderID);
            product = sql.findProduct(saled.productID);

            OrderEdit.Text = product.Name;
            CountEdit.Value = saled.count;

            AddBtn.Enabled = false;
            this.Text = "# "+client.ID+" "+SurnameEdit.Text + " " + NameEdit.Text;

            this.ShowDialog();



        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Client temp = new Client();
                temp.Name = NameEdit.Text.ToString();
                temp.Surname = SurnameEdit.Text.ToString();
                temp.Telephone = TelephoneEdit.Text.ToString();
                temp.PrivateCard = PrivatCardEdit.Text.ToString();
                temp.Adress = AdressEdit.Text.ToString();
                temp.OrderID = Int32.Parse(OrderIDEdit.Text.ToString());
                temp.SummToPay = Math.Round(Double.Parse(SummToPayEdit.Text.ToString()));
                temp.DateOrder = DateOrderEdit.Value;
                temp.DateReceiv = DateRecievEdit.Value;
                temp.DeliveryType = DeliveryTypeEdit.Text.ToString();
                temp.CostDelivery = Double.Parse(DeliverCostEdit.Text.ToString());

                sql.insertClient(temp);
                temp.ID = sql.getLastID();

                SaledProduct saled = new SaledProduct();
                saled.clientID = temp.ID;
                saled.productID = temp.OrderID;
                saled.count = ((int)CountEdit.Value);
                
                double summ = (product.Cost);
                summ -= (summ * (product.Sale / 100));

                saled.Price = summ;

                sql.insertSaledProduct(saled);
                saled = sql.findSaledProduct(product.ID, temp.ID);
                if (saled != null)
                {
                    temp.OrderID = saled.ID;
                    sql.updateClient(temp);
                }
                

            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                return;
            }
            
            this.Close();

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
                CountEdit.Maximum = product.count - sql.getSaledCount(product.ID);
                double summ = ((double)CountEdit.Value * product.Cost);
                summ -= (summ * (product.Sale / 100));
                SummToPayEdit.Text = "" + summ;

            }
            


        }
        private void CountEdit_ValueChanged(object sender, EventArgs e)
        {
            double summ = ((double)CountEdit.Value * product.Cost);
            summ -= (summ * (product.Sale / 100));
            SummToPayEdit.Text = "" + summ;
        }
    }
}
