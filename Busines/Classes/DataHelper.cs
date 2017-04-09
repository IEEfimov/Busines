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
        
        public void insertClient()
        {

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
                    if (!reader.IsDBNull(6)) clients[count].SummToPay = reader.GetDouble(6);
                    if (!reader.IsDBNull(7)) clients[count].DateOrder = reader.GetDateTime(7);
                    if (!reader.IsDBNull(8)) clients[count].DateReceiv = reader.GetDateTime(8);
                    if (!reader.IsDBNull(9)) clients[count].DeliveryType = reader.GetString(9);
                    if (!reader.IsDBNull(10)) clients[count].CostDelivery = reader.GetDouble(10);
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
    }
}
