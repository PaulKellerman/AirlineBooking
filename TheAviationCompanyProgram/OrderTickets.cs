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
    public partial class OrderTickets : Form
    {
        public OrderTickets()
        {
            InitializeComponent();

            Check();
        }




        public void Check()
        {
            if (Buffer.CompaniTxtBox == "Выберите авиакомпанию")
            {
                if (Buffer.CompaniTxtBox == "Выберите авиакомпанию" && Buffer.ReisTxtBox == "Выберите номер рейса")
                {
                    MessageBox.Show("Вы не выбрали авиакомпанию и номер рейса", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Buffer.CheckString = false;
                }

                else MessageBox.Show("Вы не выбрали авиакомпанию", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (Buffer.ReisTxtBox == "Выберите номер рейса")
            {
                MessageBox.Show("Вы не выбрали номер рейса", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




            private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu2 menu2 = new Menu2();
            menu2.Show();
        }

        private void DepartureDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
