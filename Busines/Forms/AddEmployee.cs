using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Busines.Classes;

namespace Busines.Forms
{
    public partial class AddEmployee : Form
    {
        Employee employee = new Employee();
        DataHelper sql = new DataHelper();
        bool mayBeSaved = false;

        public AddEmployee()
        {
            InitializeComponent();
        }

        public bool editEmployee(Employee employee)
        {
            this.employee = employee;
            NameEdit.Text = employee.Name;
            SurnameEdit.Text = employee.Surname;
            SecondNameEdit.Text = employee.SecondName;
            BornEdit.Value = employee.Born;
            PassportEdit.Text = employee.Passport;
            PositionEdit.Text = employee.Position;
            SalaryEdit.Value = (decimal)employee.Salary;
            IndividualCodeEdit.Text = employee.IndividualCode;
            StudyEdit.Text = employee.Study;
            WorkBookEdit.Text = employee.WorkBook;
            MedicBookEdit.Text = employee.MedicBook;
            AdditionalyEdit.Text = employee.Additionaly;
            LoginEdit.Text = employee.Login;
            PasswordEdit.Text = employee.Password;
            isChief.Checked = employee.isChief;

            addBtn.Text = "Зберегти";
            addBtn.Click -= addBtn_Click;
            addBtn.Click += saveBtn_Click;

            if (employee.ID >= 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;

            }

            this.ShowDialog();
            return mayBeSaved;
        }

        public void viewInfo(Employee employee)
        {
            this.employee = employee;
            NameEdit.Text = employee.Name;
            SurnameEdit.Text = employee.Surname;
            SecondNameEdit.Text = employee.SecondName;
            BornEdit.Value = employee.Born;
            PassportEdit.Text = employee.Passport;
            PositionEdit.Text = employee.Position;
            SalaryEdit.Value = (decimal)employee.Salary;
            IndividualCodeEdit.Text = employee.IndividualCode;
            StudyEdit.Text = employee.Study;
            WorkBookEdit.Text = employee.WorkBook;
            MedicBookEdit.Text = employee.MedicBook;
            AdditionalyEdit.Text = employee.Additionaly;
            LoginEdit.Text = employee.Login;
            PasswordEdit.Text = employee.Password;
            isChief.Checked = employee.isChief;

            if (employee.ID >= 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;

            }

            this.ShowDialog();
        } 

        private void addBtn_Click(object sender, EventArgs e)
        {
            employee.Name = NameEdit.Text.ToString();
            employee.Surname = SurnameEdit.Text.ToString();
            employee.SecondName = SecondNameEdit.Text.ToString();
            employee.Born = BornEdit.Value;
            employee.Passport = PassportEdit.Text.ToString();
            employee.Position = PositionEdit.Text.ToString();
            employee.Salary = (double)SalaryEdit.Value;
            employee.IndividualCode = IndividualCodeEdit.Text.ToString();
            employee.Study = StudyEdit.Text.ToString();
            employee.WorkBook = WorkBookEdit.Text.ToString();
            employee.MedicBook = MedicBookEdit.Text.ToString();
            employee.Additionaly = AdditionalyEdit.Text.ToString();
            employee.Login = LoginEdit.Text.ToString();
            employee.Password = PasswordEdit.Text.ToString();
            employee.isChief = isChief.Checked;

            if (sql.insertEmployee(employee)) this.Close();
         }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            mayBeSaved = true;
            employee.Name = NameEdit.Text.ToString();
            employee.Surname = SurnameEdit.Text.ToString();
            employee.SecondName = SecondNameEdit.Text.ToString();
            employee.Born = BornEdit.Value;
            employee.Passport = PassportEdit.Text.ToString();
            employee.Position = PositionEdit.Text.ToString();
            employee.Salary = (double)SalaryEdit.Value;
            employee.IndividualCode = IndividualCodeEdit.Text.ToString();
            employee.Study = StudyEdit.Text.ToString();
            employee.WorkBook = WorkBookEdit.Text.ToString();
            employee.MedicBook = MedicBookEdit.Text.ToString();
            employee.Additionaly = AdditionalyEdit.Text.ToString();
            employee.Login = LoginEdit.Text.ToString();
            employee.Password = PasswordEdit.Text.ToString();
            employee.isChief = isChief.Checked;

            if (sql.updateEmployee(employee)) this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            NameEdit.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPrize addPrize = new AddPrize();
            addPrize.getPrize(employee);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPrize addPrize = new AddPrize();
            addPrize.getSurcharge(employee);

        }
    }
}
