using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheAviationCompanyProgram
{
    public partial class Menu2 : Form
    {
        public Menu2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderTickets newForm = new  OrderTickets();
            newForm.Show();
            this.Hide();
        }


        private void добавитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDataF addDataForm = new AddDataF();
            addDataForm.Show();
            this.Close();
        }

        private void btnbackmenu2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu1 menu1 = new Menu1();
            menu1.Show();
        }

        private void ShowDataTool_Click(object sender, EventArgs e)
        {
            AddDataF addDataForm = new AddDataF();
            addDataForm.Show();
            this.Close();
        }


    }
}
