using Busines.Classes;
using Busines.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Busines
{
    public partial class Admin : Form
    {
        Employee employee;
        Auth parent;
        public Admin(Employee employee,Auth parent)
        {
            InitializeComponent();
            this.employee = employee;
            this.parent = parent;
        }
            
               

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Close();
        }

        public bool isChief()
        {
            return employee.isChief;
        }

        private void таблицяКлієнтівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientsList clientList = new ClientsList();
            clientList.Show();
        }

        private void таблицяТоварівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductList productList = new ProductList();
            productList.Show();

        }

        private void таблицяТранзакційToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaledProductList saledList = new SaledProductList();
            saledList.Show();
        }

        private void таблицяПрацівниківToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeesList employeesList = new EmployeesList();
            employeesList.Show();
        }

        private void додатиКлієнтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientsList clientList = new ClientsList();
            clientList.addClient();
        }

        private void додатиНовийТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductList productList = new ProductList();
            productList.addProduct();
        }

        private void списокБракованихТоварівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlawList flawsList = new FlawList();
            flawsList.Show();
        }

        private void вказатиНаБракToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlawList flawsList = new FlawList();
            flawsList.addFlaw();
        }

        private void списокВиданихПремійToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrizeList prizes = new PrizeList();
            prizes.Show();
        }

        private void змінитиКористувачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Hide();
        }

        private void налаштуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee settings = new AddEmployee();
            settings.editEmployee(employee);
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void місячнеСальдоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm();
            int yr = DateTime.Today.Year;
            int mth = DateTime.Today.Month;
            report.viewMonth(new DateTime(yr, mth, 1));
        }

        private void звітЗаРікToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm();
            int yr = DateTime.Today.Year;
            report.viewYear(new DateTime(yr, 1, 1));
        }
    }
}
