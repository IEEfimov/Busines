using Busines.Classes;
using MySql.Data.MySqlClient;
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
    public partial class ClientsList : Form
    {
        DataHelper sql = new DataHelper();
        public ClientsList()
        {
            InitializeComponent();

        }

        private void ClientsList_Load(object sender, EventArgs e)
        {
            Client[] clients = sql.findAllClietnts();
            for (int i = 0; i < clients.Length; i++)
            {
                dataGrid.Rows.Add();
                dataGrid.Rows[i].Cells[0].Value = clients[i].ID.ToString();
                dataGrid.Rows[i].Cells[1].Value = clients[i].Name.ToString();
                dataGrid.Rows[i].Cells[2].Value = clients[i].Surname.ToString();
                //...
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
