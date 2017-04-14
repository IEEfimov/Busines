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

namespace Busines.Forms
{
    public partial class Auth : Form
    {
        DataHelper sql = new DataHelper();
        public Auth()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Employee result = sql.findEmployee(LoginEdit.Text, PassEdit.Text);
            if (result != null)
            {
                Admin admin = new Admin(result,this);
                admin.Show();
                this.Hide();
            }

        }
    }
}
