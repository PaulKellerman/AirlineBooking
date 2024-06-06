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
    public partial class AddDataF : Form
    {
        public AddDataF()
        {
            InitializeComponent();
        }

        private void btnbackmenu2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu2 menu2 = new Menu2();
            menu2.Show();
        }
    }
}
