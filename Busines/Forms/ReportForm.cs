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
    public partial class ReportForm : Form
    {
        DataHelper sql = new DataHelper();
        DateTime date;
        DateTime newDate;
        double param1,param2, param3, param4, param5;
        double summ1, summ2, summ3;
        public ReportForm()
        {
            InitializeComponent();
        }

        public void viewMonth(DateTime date)
        {
            this.date = date;
            newDate = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));

            param1 = sql.getBuyProductsCost(date, newDate);
            param2 = sql.getSalaryCost(date, newDate);
            param3 = sql.getPrizeMinusCost(date, newDate);
            param4 = sql.getSallsCost(date, newDate);
            param5 = sql.getPrizePlusCost(date, newDate);

            summ1 = param1 + param2 + param3;
            summ2 = param4 + param5;
            summ3 = summ2 - summ1;

            label2.Text = (param1) + " грн";
            label3.Text = (param2) + " грн";
            label5.Text = (param3) + " грн";
            label9.Text = (summ1) + " грн";

            label19.Text = (param4) + " грн";
            label17.Text = (param5) + " грн";
            label11.Text = (summ2) + " грн";

            label13.Text = (summ3) + " грн";




            this.Show();
        }

        public void viewYear(DateTime date)
        {
            this.date = date;
            newDate = new DateTime(date.Year, 12, DateTime.DaysInMonth(date.Year, 12));

            param1 = sql.getBuyProductsCost(date, newDate);
            param2 = sql.getSalaryCost(date, newDate);
            param3 = sql.getPrizeMinusCost(date, newDate);
            param4 = sql.getSallsCost(date, newDate);
            param5 = sql.getPrizePlusCost(date, newDate);

            summ1 = param1 + param2 + param3;
            summ2 = param4 + param5;
            summ3 = summ2 - summ1;

            label2.Text = (param1) + " грн";
            label3.Text = (param2) + " грн";
            label5.Text = (param3) + " грн";
            label9.Text = (summ1) + " грн";

            label19.Text = (param4) + " грн";
            label17.Text = (param5) + " грн";
            label11.Text = (summ2) + " грн";

            label13.Text = (summ3) + " грн";




            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
