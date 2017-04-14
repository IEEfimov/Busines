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
    public partial class AddPrize : Form
    {
        Employee employee;
        Prize prize = new Prize();
        DataHelper sql = new DataHelper();
        public AddPrize()
        {
            InitializeComponent();
        }

        public void getPrize(Employee employee)
        {
            this.employee = employee;
            OkBtn.Text = "Видати!";
            this.Text = "Премія: " + employee.Surname;
            OkBtn.Click += getPrize;
            textBox1.Text = "Інформація про премію";
            this.ShowDialog();
        }

        public void getSurcharge(Employee employee)
        {
            this.employee = employee;
            OkBtn.Text = "Виписати!";
            this.Text = "Штраф: " + employee.Surname;
            OkBtn.Click += getSurcharge;
            textBox1.Text = "Інформація про штраф";
            this.ShowDialog();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getPrize(object sender, EventArgs e)
        {
            prize.EmployeeID = employee.ID;
            prize.Count = (double)numericUpDown1.Value;
            prize.Info = textBox1.Text;
            prize.Purchase = dateTimePicker1.Value;
            if (sql.insertPrize(prize)) this.Close();
        }
        private void getSurcharge(object sender, EventArgs e)
        {
            prize.EmployeeID = employee.ID;
            prize.Count = (double)numericUpDown1.Value;
            prize.Count *= -1;
            prize.Info = textBox1.Text;
            prize.Purchase = dateTimePicker1.Value;
            if (sql.insertPrize(prize)) this.Close();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
