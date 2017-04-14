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
            LoadData();

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddData();

        }

        

        private void DeleteBtnClick(object sender, EventArgs e)
        {
            DeleteSelected();
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelected();
        }

        

        public void addClient()
        {
            AddData();
        }

        private void додатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClientForm addClient = new AddClientForm();
            addClient.ShowDialog();
            LoadData();
        }

        private void LoadData()
        {
            dataGrid.Rows.Clear();
            Client[] clients = sql.findAllClietnts();
            for (int i = 0; i < clients.Length; i++)
            {
                string temp = clients[i].Surname + " " + clients[i].Name;
                dataGrid.Rows.Add();
                dataGrid.Rows[i].Cells[0].Value = clients[i].ID.ToString();
                dataGrid.Rows[i].Cells[1].Value = temp;
                dataGrid.Rows[i].Cells[2].Value = clients[i].OrderID.ToString();
                dataGrid.Rows[i].Cells[3].Value = clients[i].DateOrder.ToString();
                dataGrid.Rows[i].Cells[4].Value = clients[i].DateReceiv.ToString();
                dataGrid.Rows[i].Cells[5].Value = clients[i].SummToPay.ToString();
            }
        }
        private void AddData()
        {
            AddClientForm addClient = new AddClientForm();
            addClient.ShowDialog();
            LoadData();
        }
        private void EditData()
        {
            int index = dataGrid.SelectedRows[0].Index;
            Client temp = sql.findClient(Int32.Parse(dataGrid.Rows[index].Cells[0].Value.ToString()));
            AddClientForm editor = new AddClientForm();
            editor.LookForClient(temp);
        }
        private bool DeleteSelected()
        {
            int index;
            while (dataGrid.SelectedRows.Count > 1)
            {
                index = dataGrid.SelectedRows[0].Index;
                sql.deleteClient(Int32.Parse(dataGrid.Rows[index].Cells[0].Value.ToString()));
                dataGrid.Rows.RemoveAt(index);
            }
            index = dataGrid.SelectedRows[0].Index;
            sql.deleteClient(Int32.Parse(dataGrid.Rows[index].Cells[0].Value.ToString()));
            dataGrid.Rows.RemoveAt(index);
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditData();
        }

        private void редагуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditData();
        }

        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditData();
        }
    }
}
