using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines.Classes
{
    public class Client
    {
        public int ID = 0;
        public string Name="";
        public string Surname = "";
        public string Telephone = "";
        public string PrivateCard = "";
        public string Adress = "";
        public int OrderID;
        public double SummToPay;
        public DateTime DateOrder;
        public DateTime DateReceiv;
        public string DeliveryType = "";
        public double CostDelivery;
              

        public Client()
        {

        }
    }
}
