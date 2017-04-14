using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Busines.Classes
{
    class DataHelper
    {
        private MySqlConnectionStringBuilder mysqlCSB;
        private MySqlDataReader reader;
        private MySqlConnection connection;
        private MySqlCommand command;
        private string queryString;


        public DataHelper()
        {
            try
            {
                mysqlCSB = new MySqlConnectionStringBuilder();
                mysqlCSB.Server = "localhost";
                mysqlCSB.Database = "businesclient";
                mysqlCSB.UserID = "root";
                mysqlCSB.Password = "serverPass1";

                connection = new MySqlConnection();
                connection.ConnectionString = mysqlCSB.ConnectionString;
                connection.Open();
                connection.Close();
                                
                command = new MySqlCommand(queryString, connection);
            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка:\n" + error.ToString()), "Помилка при піключенні до бази!!");
            }
        }
        
        public Client[] findAllClietnts()
        {
            List<Client> clients = new List<Client>();
            int count = 0;
            try
            {
                connection.Open();
                command.CommandText = @"SELECT * FROM businesclient.clients;";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    clients.Add(new Client());
                    if (!reader.IsDBNull(0)) clients[count].ID = reader.GetInt32(0);
                    if (!reader.IsDBNull(1)) clients[count].Name = reader.GetString(1);
                    if (!reader.IsDBNull(2)) clients[count].Surname = reader.GetString(2);
                    if (!reader.IsDBNull(3)) clients[count].Telephone = reader.GetString(3);
                    if (!reader.IsDBNull(4)) clients[count].PrivateCard = reader.GetString(4);
                    if (!reader.IsDBNull(5)) clients[count].Adress = reader.GetString(5);
                    if (!reader.IsDBNull(6)) clients[count].OrderID = reader.GetInt32(6);
                    if (!reader.IsDBNull(7)) clients[count].SummToPay = reader.GetDouble(7);
                    if (!reader.IsDBNull(8)) clients[count].DateOrder = reader.GetDateTime(8);
                    if (!reader.IsDBNull(9)) clients[count].DateReceiv = reader.GetDateTime(9);
                    if (!reader.IsDBNull(10)) clients[count].DeliveryType = reader.GetString(10);
                    if (!reader.IsDBNull(11)) clients[count].CostDelivery = reader.GetDouble(11);
                    count++;
                }
            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return null;
            }
            
            
            reader.Close();
            connection.Close();
            return clients.ToArray();
        }
        public Client[] findAllClietnts(DateTime tim1, DateTime tim2)
        {
            List<Client> clients = new List<Client>();
            int count = 0;
            try
            {
                connection.Open();
                command.CommandText = @"SELECT * FROM businesclient.clients";
                command.CommandText += " WHERE (`DateOrder`>=" + getDateStr(tim1) + " AND `DateOrder`<=" + getDateStr(tim2) + ");";
                MessageBox.Show(command.CommandText);

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    clients.Add(new Client());
                    if (!reader.IsDBNull(0)) clients[count].ID = reader.GetInt32(0);
                    if (!reader.IsDBNull(1)) clients[count].Name = reader.GetString(1);
                    if (!reader.IsDBNull(2)) clients[count].Surname = reader.GetString(2);
                    if (!reader.IsDBNull(3)) clients[count].Telephone = reader.GetString(3);
                    if (!reader.IsDBNull(4)) clients[count].PrivateCard = reader.GetString(4);
                    if (!reader.IsDBNull(5)) clients[count].Adress = reader.GetString(5);
                    if (!reader.IsDBNull(6)) clients[count].OrderID = reader.GetInt32(6);
                    if (!reader.IsDBNull(7)) clients[count].SummToPay = reader.GetDouble(7);
                    if (!reader.IsDBNull(8)) clients[count].DateOrder = reader.GetDateTime(8);
                    if (!reader.IsDBNull(9)) clients[count].DateReceiv = reader.GetDateTime(9);
                    if (!reader.IsDBNull(10)) clients[count].DeliveryType = reader.GetString(10);
                    if (!reader.IsDBNull(11)) clients[count].CostDelivery = reader.GetDouble(11);
                    count++;
                }
            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return null;
            }


            reader.Close();
            connection.Close();
            return clients.ToArray();
        }
        public Client findClient(int id)
        {
            Client client = new Client();
            try
            {
                connection.Open();
                command.CommandText = @"SELECT * FROM businesclient.clients  where (ID=" + id + ");";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (!reader.IsDBNull(0)) client.ID = reader.GetInt32(0);
                    if (!reader.IsDBNull(1)) client.Name = reader.GetString(1);
                    if (!reader.IsDBNull(2)) client.Surname = reader.GetString(2);
                    if (!reader.IsDBNull(3)) client.Telephone = reader.GetString(3);
                    if (!reader.IsDBNull(4)) client.PrivateCard = reader.GetString(4);
                    if (!reader.IsDBNull(5)) client.Adress = reader.GetString(5);
                    if (!reader.IsDBNull(6)) client.OrderID = reader.GetInt32(6);
                    if (!reader.IsDBNull(7)) client.SummToPay = reader.GetDouble(7);
                    if (!reader.IsDBNull(8)) client.DateOrder = reader.GetDateTime(8);
                    if (!reader.IsDBNull(9)) client.DateReceiv = reader.GetDateTime(9);
                    if (!reader.IsDBNull(10)) client.DeliveryType = reader.GetString(10);
                    if (!reader.IsDBNull(11)) client.CostDelivery = reader.GetDouble(11);
                }
            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return null;
            }


            reader.Close();
            connection.Close();
            return client;
        }
        public Product[] findAllProducts()
        {
            List<Product> products = new List<Product>();
            int count = 0;
            try
            {
                connection.Open();
                command.CommandText = @"SELECT * FROM businesclient.products;";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    products.Add(new Product());
                    if (!reader.IsDBNull(0)) products[count].ID = reader.GetInt32(0);
                    if (!reader.IsDBNull(1)) products[count].Name = reader.GetString(1);
                    if (!reader.IsDBNull(2)) products[count].Info = reader.GetString(2);
                    if (!reader.IsDBNull(3)) products[count].count = reader.GetInt32(3);
                    if (!reader.IsDBNull(4)) products[count].Cost = reader.GetDouble(4);
                    if (!reader.IsDBNull(5)) products[count].CostOld = reader.GetDouble(5);
                    if (!reader.IsDBNull(6)) products[count].Sale = reader.GetDouble(6);
                    if (!reader.IsDBNull(7)) products[count].Purchase = reader.GetDateTime(7);
                    
                    count++;
                }
            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return null;
            }


            reader.Close();
            connection.Close();
            return products.ToArray();
        }
        public Product[] findAllProducts(DateTime tim1, DateTime tim2)
        {
            List<Product> products = new List<Product>();
            int count = 0;
            try
            {
                connection.Open();
                command.CommandText = @"SELECT * FROM businesclient.products ";
                command.CommandText += "WHERE (`Purchase`>=" + getDateStr(tim1)+ " AND `Purchase`<=" + getDateStr(tim2) + ");";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    products.Add(new Product());
                    if (!reader.IsDBNull(0)) products[count].ID = reader.GetInt32(0);
                    if (!reader.IsDBNull(1)) products[count].Name = reader.GetString(1);
                    if (!reader.IsDBNull(2)) products[count].Info = reader.GetString(2);
                    if (!reader.IsDBNull(3)) products[count].count = reader.GetInt32(3);
                    if (!reader.IsDBNull(4)) products[count].Cost = reader.GetDouble(4);
                    if (!reader.IsDBNull(5)) products[count].CostOld = reader.GetDouble(5);
                    if (!reader.IsDBNull(6)) products[count].Sale = reader.GetDouble(6);
                    if (!reader.IsDBNull(7)) products[count].Purchase = reader.GetDateTime(7);

                    count++;
                }
            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return null;
            }


            reader.Close();
            connection.Close();
            return products.ToArray();
        }
        public Product findProduct(int id)
        {
            Product product = new Product();
            try
            {
                connection.Open();
                command.CommandText = @"SELECT * FROM businesclient.products where (ID=" + id + ");";
                reader = command.ExecuteReader();

                reader.Read();

                if (!reader.IsDBNull(0)) product.ID = reader.GetInt32(0);
                if (!reader.IsDBNull(1)) product.Name = reader.GetString(1);
                if (!reader.IsDBNull(2)) product.Info = reader.GetString(2);
                if (!reader.IsDBNull(3)) product.count = reader.GetInt32(3);
                if (!reader.IsDBNull(4)) product.Cost = reader.GetDouble(4);
                if (!reader.IsDBNull(5)) product.CostOld = reader.GetDouble(5);
                if (!reader.IsDBNull(6)) product.Sale = reader.GetDouble(6);
                if (!reader.IsDBNull(7)) product.Purchase = reader.GetDateTime(7);

            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return null;
            }


            reader.Close();
            connection.Close();
            return product;
        }
        public SaledProduct[] findAllSaledProducts()
        {
            List<SaledProduct> prodcts = new List<SaledProduct>();
            int count = 0;
            try
            {
                connection.Open();
                command.CommandText = @"SELECT * FROM businesclient.saled;";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    prodcts.Add(new SaledProduct());
                    if (!reader.IsDBNull(0)) prodcts[count].ID = reader.GetInt32(0);
                    if (!reader.IsDBNull(1)) prodcts[count].productID = reader.GetInt32(1);
                    if (!reader.IsDBNull(2)) prodcts[count].clientID = reader.GetInt32(2);
                    if (!reader.IsDBNull(3)) prodcts[count].count = reader.GetInt32(3);
                    count++;
                }
            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return null;
            }


            reader.Close();
            connection.Close();
            return prodcts.ToArray();
        }
        public SaledProduct findSaledProduct(int productID, int clientID)
        {
            SaledProduct product = new SaledProduct();
            try
            {
                connection.Open();
                command.CommandText = @"SELECT * FROM businesclient.saled where (productID=" + productID + " and clientID=" + clientID + ");";
                reader = command.ExecuteReader();

                reader.Read();

                if (!reader.IsDBNull(0)) product.ID = reader.GetInt32(0);
                if (!reader.IsDBNull(1)) product.productID = reader.GetInt32(1);
                if (!reader.IsDBNull(2)) product.clientID = reader.GetInt32(2);
                if (!reader.IsDBNull(3)) product.count = reader.GetInt32(3);
                if (!reader.IsDBNull(4)) product.Price = reader.GetDouble(4);

            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return null;
            }


            reader.Close();
            connection.Close();
            return product;
        }
        public SaledProduct[] findSaledProducts(int productID)
        {
            List<SaledProduct> prodcts = new List<SaledProduct>();
            int count = 0;
            try
            {
                connection.Open();
                command.CommandText = @"SELECT * FROM businesclient.saled where (productID=" + productID + ");";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    prodcts.Add(new SaledProduct());
                    if (!reader.IsDBNull(0)) prodcts[count].ID = reader.GetInt32(0);
                    if (!reader.IsDBNull(1)) prodcts[count].productID = reader.GetInt32(1);
                    if (!reader.IsDBNull(2)) prodcts[count].clientID = reader.GetInt32(2);
                    if (!reader.IsDBNull(3)) prodcts[count].count = reader.GetInt32(3);
                    if (!reader.IsDBNull(4)) prodcts[count].Price = reader.GetDouble(4);
                    count++;
                }


            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return null;
            }


            reader.Close();
            connection.Close();
            return prodcts.ToArray();
        }
        public SaledProduct findSaledProduct(int id)
        {
            SaledProduct product = new SaledProduct();
            try
            {
                connection.Open();
                command.CommandText = @"SELECT * FROM businesclient.saled where (ID=" + id + ");";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (!reader.IsDBNull(0)) product.ID = reader.GetInt32(0);
                    if (!reader.IsDBNull(1)) product.productID = reader.GetInt32(1);
                    if (!reader.IsDBNull(2)) product.clientID = reader.GetInt32(2);
                    if (!reader.IsDBNull(3)) product.count = reader.GetInt32(3);
                    if (!reader.IsDBNull(4)) product.Price = reader.GetDouble(4);


                }
            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return null;
            }


            reader.Close();
            connection.Close();
            return product;
        }
        public Employee[] findAllEmployees()
        {
            List<Employee> employee = new List<Employee>();
            int count = 0;
            try
            {
                connection.Open();
                command.CommandText = @"SELECT * FROM businesclient.employees;";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    employee.Add(new Employee());
                    if (!reader.IsDBNull(0)) employee[count].ID = reader.GetInt32(0);
                    if (!reader.IsDBNull(1)) employee[count].Name = reader.GetString(1);
                    if (!reader.IsDBNull(2)) employee[count].Surname = reader.GetString(2);
                    if (!reader.IsDBNull(3)) employee[count].SecondName = reader.GetString(3);
                    if (!reader.IsDBNull(4)) employee[count].Born = reader.GetDateTime(4);
                    if (!reader.IsDBNull(5)) employee[count].Passport = reader.GetString(5);
                    if (!reader.IsDBNull(6)) employee[count].Position = reader.GetString(6);
                    if (!reader.IsDBNull(7)) employee[count].Salary = reader.GetDouble(7);
                    if (!reader.IsDBNull(8)) employee[count].IndividualCode = reader.GetString(8);
                    if (!reader.IsDBNull(9)) employee[count].Study = reader.GetString(9);
                    if (!reader.IsDBNull(10)) employee[count].WorkBook = reader.GetString(10);
                    if (!reader.IsDBNull(11)) employee[count].MedicBook = reader.GetString(11);
                    if (!reader.IsDBNull(12)) employee[count].Additionaly = reader.GetString(12);
                    if (!reader.IsDBNull(13)) employee[count].Login = reader.GetString(13);
                    if (!reader.IsDBNull(14)) employee[count].Password = reader.GetString(14);
                    if (!reader.IsDBNull(15)) employee[count].isChief = (reader.GetString(14).Equals("1"));
                    count++;
                }
            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return null;
            }


            reader.Close();
            connection.Close();
            return employee.ToArray();
        }
        public Employee findEmployee(int id)
        {
            Employee employee = new Employee();
            try
            {
                connection.Open();
                command.CommandText = @"SELECT * FROM businesclient.employees where (ID=" + id + ");";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (!reader.IsDBNull(0)) employee.ID = reader.GetInt32(0);
                    if (!reader.IsDBNull(1)) employee.Name = reader.GetString(1);
                    if (!reader.IsDBNull(2)) employee.Surname = reader.GetString(2);
                    if (!reader.IsDBNull(3)) employee.SecondName = reader.GetString(3);
                    if (!reader.IsDBNull(4)) employee.Born = reader.GetDateTime(4);
                    if (!reader.IsDBNull(5)) employee.Passport = reader.GetString(5);
                    if (!reader.IsDBNull(6)) employee.Position = reader.GetString(6);
                    if (!reader.IsDBNull(7)) employee.Salary = reader.GetDouble(7);
                    if (!reader.IsDBNull(8)) employee.IndividualCode = reader.GetString(8);
                    if (!reader.IsDBNull(9)) employee.Study = reader.GetString(9);
                    if (!reader.IsDBNull(10)) employee.WorkBook = reader.GetString(10);
                    if (!reader.IsDBNull(11)) employee.MedicBook = reader.GetString(11);
                    if (!reader.IsDBNull(12)) employee.Additionaly = reader.GetString(12);
                    if (!reader.IsDBNull(13)) employee.Login = reader.GetString(13);
                    if (!reader.IsDBNull(14)) employee.Password = reader.GetString(14);
                    if (!reader.IsDBNull(15)) employee.isChief = (reader.GetString(15).Equals("1"));

                }
            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return null;
            }


            reader.Close();
            connection.Close();
            return employee;
        }
        public Employee findEmployee(string Login, string Pass)
        {
            Employee employee = new Employee();
            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM businesclient.employees where (Login=\"" + Login + "\" and Password=\""+Pass+"\");";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (!reader.IsDBNull(0)) employee.ID = reader.GetInt32(0);
                    if (!reader.IsDBNull(1)) employee.Name = reader.GetString(1);
                    if (!reader.IsDBNull(2)) employee.Surname = reader.GetString(2);
                    if (!reader.IsDBNull(3)) employee.SecondName = reader.GetString(3);
                    if (!reader.IsDBNull(4)) employee.Born = reader.GetDateTime(4);
                    if (!reader.IsDBNull(5)) employee.Passport = reader.GetString(5);
                    if (!reader.IsDBNull(6)) employee.Position = reader.GetString(6);
                    if (!reader.IsDBNull(7)) employee.Salary = reader.GetDouble(7);
                    if (!reader.IsDBNull(8)) employee.IndividualCode = reader.GetString(8);
                    if (!reader.IsDBNull(9)) employee.Study = reader.GetString(9);
                    if (!reader.IsDBNull(10)) employee.WorkBook = reader.GetString(10);
                    if (!reader.IsDBNull(11)) employee.MedicBook = reader.GetString(11);
                    if (!reader.IsDBNull(12)) employee.Additionaly = reader.GetString(12);
                    if (!reader.IsDBNull(13)) employee.Login = reader.GetString(13);
                    if (!reader.IsDBNull(14)) employee.Password = reader.GetString(14);
                    if (!reader.IsDBNull(15)) employee.isChief = (reader.GetString(15).Equals("1"));

                }
            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return null;
            }


            reader.Close();
            connection.Close();
            return employee;
        }
        public Flaw[] findAllFlaws()
        {
            List<Flaw> flaws = new List<Flaw>();
            int count = 0;
            try
            {
                connection.Open();
                command.CommandText = @"SELECT * FROM businesclient.flaw;";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    flaws.Add(new Flaw());
                    if (!reader.IsDBNull(0)) flaws[count].ID = reader.GetInt32(0);
                    if (!reader.IsDBNull(1)) flaws[count].ProductID = reader.GetInt32(1);
                    if (!reader.IsDBNull(2)) flaws[count].Count = reader.GetInt32(2);
                    if (!reader.IsDBNull(3)) flaws[count].Price = reader.GetInt32(3);
                    count++;
                }
            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return null;
            }


            reader.Close();
            connection.Close();
            return flaws.ToArray();
        }
        public Flaw findFlaw(int id)
        {
            Flaw flaw = new Flaw();
            try
            {
                connection.Open();
                command.CommandText = @"SELECT * FROM businesclient.flaw where (ID=" + id + ");";
                reader = command.ExecuteReader();

                reader.Read();
                    if (!reader.IsDBNull(0)) flaw.ID = reader.GetInt32(0);
                    if (!reader.IsDBNull(1)) flaw.ProductID = reader.GetInt32(1);
                    if (!reader.IsDBNull(2)) flaw.Count = reader.GetInt32(2);
                    if (!reader.IsDBNull(3)) flaw.Price = reader.GetInt32(3);
            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return null;
            }


            reader.Close();
            connection.Close();
            return flaw;
        }
        public Prize[] findAllPrizes()
        {
            List<Prize> prizes = new List<Prize>();
            int count = 0;
            try
            {
                connection.Open();
                command.CommandText = @"SELECT * FROM businesclient.prize;";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    prizes.Add(new Prize());
                    if (!reader.IsDBNull(0)) prizes[count].ID = reader.GetInt32(0);
                    if (!reader.IsDBNull(1)) prizes[count].EmployeeID = reader.GetInt32(1);
                    if (!reader.IsDBNull(2)) prizes[count].Count = reader.GetInt32(2);
                    if (!reader.IsDBNull(3)) prizes[count].Info = reader.GetString(3);
                    if (!reader.IsDBNull(4)) prizes[count].Purchase = reader.GetDateTime(4);
                    count++;
                }
            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return null;
            }


            reader.Close();
            connection.Close();
            return prizes.ToArray();
        }
        public Prize[] findAllPrizes(DateTime tim1, DateTime tim2)
        {
            List<Prize> prizes = new List<Prize>();
            int count = 0;
            try
            {
                connection.Open();
                command.CommandText = @"SELECT * FROM businesclient.prize ";
                command.CommandText += "WHERE (`Purchase`>=" + getDateStr(tim1) + " AND `Purchase`<=" + getDateStr(tim2) + ");";

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    prizes.Add(new Prize());
                    if (!reader.IsDBNull(0)) prizes[count].ID = reader.GetInt32(0);
                    if (!reader.IsDBNull(1)) prizes[count].EmployeeID = reader.GetInt32(1);
                    if (!reader.IsDBNull(2)) prizes[count].Count = reader.GetInt32(2);
                    if (!reader.IsDBNull(3)) prizes[count].Info = reader.GetString(3);
                    if (!reader.IsDBNull(4)) prizes[count].Purchase = reader.GetDateTime(4);
                    count++;
                }
            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return null;
            }


            reader.Close();
            connection.Close();
            return prizes.ToArray();
        }



        public bool insertClient(Client temp)
        {
            try
            {
                connection.Open();
                command.CommandText = @"INSERT INTO `businesclient`.`clients`
(`Name`,`Surname`,`Telephone`,`PrivateCard`,`Adress`,`OrderID`,`SummToPay`,
`DateOrder`,`DateReceiv`,`DeliveryType`,`CostDelivery`)";
              
                command.CommandText += "VALUES(";
                command.CommandText += "'" + temp.Name + "',";
                command.CommandText += "'" + temp.Surname + "',";
                command.CommandText += "'" + temp.Telephone + "',";
                command.CommandText += "'" + temp.PrivateCard + "',";
                command.CommandText += "'" + temp.Adress + "',";
                command.CommandText += temp.OrderID + ",";
                command.CommandText += temp.SummToPay + ",";
                command.CommandText += getDateStr(temp.DateOrder) + ",";
                command.CommandText += getDateStr(temp.DateReceiv) + ",";
                command.CommandText += "'" + temp.DeliveryType + "',";
                command.CommandText += temp.CostDelivery;
                command.CommandText += ");";

                //MessageBox.Show(("Сформовано: \n" + command.CommandText.ToString()), "Запит");

                command.ExecuteNonQuery();

                

            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
        public bool insertProduct(Product temp)
        {
            try
            {
                connection.Open();
                command.CommandText = @"INSERT INTO `businesclient`.`products`
(`Name`,`Info`,`Count`,`Cost`,`CostOld`,`Sale`,`Purchase`)";

                command.CommandText += "VALUES(";
                command.CommandText += "\"" + temp.Name + "\",";
                command.CommandText += "\"" + temp.Info + "\",";
                command.CommandText += temp.count + ",";
                temp.Cost = Math.Round(temp.Cost);
                command.CommandText += temp.Cost + ",";
                temp.CostOld = Math.Round(temp.CostOld);
                command.CommandText += temp.CostOld + ",";
                command.CommandText += temp.Sale + ",";
                command.CommandText += getDateStr(temp.Purchase);
                command.CommandText += ");";


                //MessageBox.Show(("Сформовано: \n" + command.CommandText.ToString()), "Запит");

                command.ExecuteNonQuery();

            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
        public bool insertSaledProduct(SaledProduct temp)
        {
            try
            {
                connection.Open();
                command.CommandText = @"INSERT INTO `businesclient`.`saled`(`ProductID`,`ClientID`,`Count`,`Price`)";

                command.CommandText += "VALUES(";
                command.CommandText += temp.productID + ",";
                command.CommandText += temp.clientID + ",";
                command.CommandText += temp.count + ",";
                command.CommandText += Math.Round(temp.Price);
                command.CommandText += ");";

                MessageBox.Show(("Сформовано: \n" + command.CommandText.ToString()), "Запит");

                command.ExecuteNonQuery();

            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
        public bool insertEmployee(Employee temp)
        {
            try
            {
                connection.Open();
                command.CommandText = @"INSERT INTO `businesclient`.`employees`
(`Name`,`Surname`,`SecondName`,`Born`,`Passport`,`Position`,`Salary`,`IndividualCode`,
`Study`,`WorkBook`,`MedicBook`,`Additionaly`,`Login`,`Password`,`isChief`)";

                command.CommandText += "VALUES(";
                command.CommandText += "\"" + temp.Name + "\",";
                command.CommandText += "\"" + temp.Surname + "\",";
                command.CommandText += "\"" + temp.SecondName + "\",";
                command.CommandText += getDateStr(temp.Born) + ",";
                command.CommandText += "\"" + temp.Passport + "\",";
                command.CommandText += "\"" + temp.Position + "\",";
                command.CommandText += Math.Round(temp.Salary) + ",";
                command.CommandText += "\"" + temp.IndividualCode + "\",";
                command.CommandText += "\"" + temp.Study + "\",";
                command.CommandText += "\"" + temp.WorkBook + "\",";
                command.CommandText += "\"" + temp.MedicBook + "\",";
                command.CommandText += "\"" + temp.Additionaly + "\",";
                command.CommandText += "\"" + temp.Login + "\",";
                command.CommandText += "\"" + temp.Password + "\",";
                if(temp.isChief) command.CommandText += "1";
                else command.CommandText += "0";
                command.CommandText += ");";

                MessageBox.Show(("Сформовано: \n" + command.CommandText.ToString()), "Запит");

                command.ExecuteNonQuery();

            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
        public bool insertFlaw(Flaw temp)
        {
            try
            {
                connection.Open();
                command.CommandText = @"INSERT INTO `businesclient`.`flaw`
(`ProductID`,`Count`,`Price`) VALUES (";

                command.CommandText += temp.ProductID + ",";
                command.CommandText += temp.Count + ",";
                command.CommandText += Math.Round(temp.Price);
                command.CommandText += ");";

                MessageBox.Show(("Сформовано: \n" + command.CommandText.ToString()), "Запит");

                command.ExecuteNonQuery();

            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
        public bool insertPrize(Prize temp)
        {
            try
            {
                connection.Open();
                command.CommandText = @"INSERT INTO `businesclient`.`prize`
(`EmployeeID`,`Count`,`Info`,`Purchase`) VALUES (";

                command.CommandText += temp.EmployeeID + ",";
                command.CommandText += Math.Round(temp.Count) + ",";
                command.CommandText += "\""+temp.Info+"\",";
                command.CommandText += getDateStr(temp.Purchase);
                command.CommandText += ");";

                MessageBox.Show(("Сформовано: \n" + command.CommandText.ToString()), "Запит");

                command.ExecuteNonQuery();

            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }

        public bool updateClient(Client temp)
        {
            try
            {
                connection.Open();
                command.CommandText = @"UPDATE `businesclient`.`clients` SET";

                command.CommandText += "`Name`=\"" + temp.Name + "\",";
                command.CommandText += "`Surname`=\"" + temp.Surname + "\",";
                command.CommandText += "`Telephone`=\"" + temp.Telephone + "\",";
                command.CommandText += "`PrivateCard`=\"" + temp.PrivateCard + "\",";
                command.CommandText += "`Adress`=\"" + temp.Adress + "\",";
                command.CommandText += "`OrderID`=" + temp.OrderID + ",";
                command.CommandText += "`SummToPay`=" + temp.SummToPay + ",";
                command.CommandText += "`DateOrder`=" + getDateStr(temp.DateOrder) + ",";
                command.CommandText += "`DateReceiv`=" + getDateStr(temp.DateReceiv) + ",";
                command.CommandText += "`DeliveryType`=\"" + temp.DeliveryType + "\",";
                command.CommandText += "`CostDelivery`='" + temp.CostDelivery + "'";
                command.CommandText += " where (ID=" + temp.ID + ");";

                MessageBox.Show(("Сформовано: \n" + command.CommandText.ToString()), "Запит");

                command.ExecuteNonQuery();

            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;

        }
        public bool updateProduct(Product temp)
        {
            try
            {
                connection.Open();
                command.CommandText = @"UPDATE `businesclient`.`products` SET";

                command.CommandText += "`Name`=\"" + temp.Name + "\",";
                command.CommandText += "`Info`=\"" + temp.Info + "\",";
                command.CommandText += "`Count`='" + temp.count + "',";
                command.CommandText += "`Cost`='" + Math.Round(temp.Cost) + "',";
                command.CommandText += "`CostOld`='" + Math.Round(temp.CostOld) + "',";
                command.CommandText += "`Sale`='" + temp.Sale + "',";
                command.CommandText += "`Purchase`=" + getDateStr(temp.Purchase)+ "";
                command.CommandText += " where (ID=" + temp.ID + ");";

                MessageBox.Show(("Сформовано: \n" + command.CommandText.ToString()), "Запит");

                command.ExecuteNonQuery();

            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;

        }
        public bool updateEmployee(Employee temp)
        {
            try
            {
                connection.Open();
                command.CommandText = @"UPDATE `businesclient`.`employees` SET";

                command.CommandText += "`Name` = \"" + temp.Name + "\",";
                command.CommandText += "`Surname`=\"" + temp.Surname + "\",";
                command.CommandText += "`SecondName` = \"" + temp.SecondName + "\",";
                command.CommandText += "`Born`=" + getDateStr(temp.Born) + ",";
                command.CommandText += "`Passport` = \"" + temp.Passport + "\",";
                command.CommandText += "`Position`= \"" + temp.Position + "\",";
                command.CommandText += "`Salary` = " + Math.Round(temp.Salary) + ",";
                command.CommandText += "`IndividualCode` = \"" + temp.IndividualCode + "\",";
                command.CommandText += "`Study` =\"" + temp.Study + "\",";
                command.CommandText += "`WorkBook` = \"" + temp.WorkBook + "\",";
                command.CommandText += "`MedicBook` = \"" + temp.MedicBook + "\",";
                command.CommandText += "`Additionaly` =\"" + temp.Additionaly + "\",";
                command.CommandText += "`Login` = \"" + temp.Login + "\",";
                command.CommandText += "`Password`=\"" + temp.Password + "\",";
                if (temp.isChief) command.CommandText += "`isChief` = 1";
                else command.CommandText += "`isChief` = 0";
                command.CommandText += " where (ID=" + temp.ID + ");";

                command.ExecuteNonQuery();

            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;

        }
        public bool updateFlaw(Flaw temp)
        {
            try
            {
                connection.Open();
                command.CommandText = @"UPDATE `businesclient`.`flaw` SET";

                command.CommandText += "`ProductID`=" + temp.ProductID + ",";
                command.CommandText += "`Count`=" + temp.Count + ",";
                command.CommandText += "`Price`='" + temp.Price + "'";
                command.CommandText += " where (ID=" + temp.ID + ");";

                MessageBox.Show(("Сформовано: \n" + command.CommandText.ToString()), "Запит");

                command.ExecuteNonQuery();

            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;

        }

        public bool deleteClient(int id)
        {
            try
            {
                connection.Open();
                command.CommandText = @"DELETE FROM `businesclient`.`clients` WHERE `ID`='"+id+"';";
                command.ExecuteNonQuery();
                command.CommandText = @"DELETE FROM `businesclient`.`saled` WHERE `ClientID`='" + id + "';";
                command.ExecuteNonQuery();

            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
        public bool deleteProduct(int id)
        {
            try
            {
                connection.Open();
                command.CommandText = @"DELETE FROM `businesclient`.`products` WHERE `ID`='" + id + "';";
                command.ExecuteNonQuery();

            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
        public bool deleteSaledProduct(int id)
        {
            try
            {
                connection.Open();
                command.CommandText = @"DELETE FROM `businesclient`.`saled` WHERE `ID`='" + id + "';";
                command.ExecuteNonQuery();

            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
        public bool deleteEmployee(int id)
        {
            try
            {
                connection.Open();
                command.CommandText = @"DELETE FROM `businesclient`.`employees` WHERE `ID`='" + id + "';";
                command.ExecuteNonQuery();

            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
        public bool deleteFlaw(int id)
        {
            try
            {
                connection.Open();
                command.CommandText = @"DELETE FROM `businesclient`.`flaw` WHERE `ID`='" + id + "';";
                command.ExecuteNonQuery();

            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }

        public int getLastID()
        {
            int temp = 0; ;
            try
            {
                connection.Open();
                command.CommandText = @"Select LAST_INSERT_ID();";
                reader = command.ExecuteReader();

                reader.Read();
                temp = reader.GetInt32(0);
                
            }
            catch (SystemException error)
            {
                MessageBox.Show(("Помилка: \n" + error.ToString()), ":(");
                connection.Close();
                return -1;
            }
            
            reader.Close();
            connection.Close();
            MessageBox.Show(("Отримано: \n" + temp.ToString()), ":(");
            return temp;
        }

        public string getDateStr(DateTime startDate)
        {
            string temp = "'";
            temp += startDate.Year + "-";
            temp += startDate.Month + "-";
            temp += startDate.Day + "'";
            
            return temp;
        }
        public int getSaledCount(int ID)
        {
            int temp = 0;
            SaledProduct[] saled = findSaledProducts(ID);
            for (int i = 0; i < saled.Length; i++)
            {
                temp += saled[i].count;
            }
            return temp;
        }

        public double getBuyProductsCost(DateTime date1, DateTime date2)
        {
            double temp = 0;
            Product[] all = findAllProducts(date1, date2);
            for (int i = 0; i<all.Length; i++)
            {
                temp += (all[i].count * all[i].CostOld);
            }
            return temp;
        }
        public double getSalaryCost(DateTime date1, DateTime date2)
        {
            double temp = 0;
            Employee[] all = findAllEmployees();
            for (int i = 0; i < all.Length; i++)
            {
                temp += all[i].Salary;
            }

            return temp*(date2.Month-date1.Month + 1);
        }
        public double getPrizePlusCost(DateTime date1, DateTime date2)
        {
            double temp = 0;
            Prize[] all = findAllPrizes(date1, date2);
            for (int i = 0; i < all.Length; i++)
            {
                if (all[i].Count < 0) temp -= (all[i].Count);
            }
            return temp;
        }
        public double getPrizeMinusCost(DateTime date1, DateTime date2)
        {
            double temp = 0;
            Prize[] all = findAllPrizes(date1, date2);
            for (int i = 0; i < all.Length; i++)
            {
                if (all[i].Count > 0) temp += (all[i].Count);
            }
            return temp;
        }
        public double getSallsCost(DateTime date1, DateTime date2)
        {
            double temp = 0;
            Client[] all = findAllClietnts(date1, date2);
            for (int i = 0; i < all.Length; i++)
            {
                SaledProduct tempS = findSaledProduct(all[i].OrderID);
                temp += (tempS.count * tempS.Price);
            }
            return temp;
        }
       
       

    }
}
