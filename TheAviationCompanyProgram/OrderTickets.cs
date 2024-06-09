using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TheAviationCompanyProgram
{
    public partial class OrderTickets : Form
    {
        public OrderTickets()
        {
            InitializeComponent();

            Check();

        }



        public void GetInfo()
        {
            AirlineTextBox.Text = Buffer.TextBoxComapnyBuf;

            FlightTextBox.Text = Buffer.TextBoxFlightBuf;
            DepartureDateTimePicker.MinDate = DateTime.Now;
        }

        public void progHide()
        {
            progressBar.Visible = false;
        }

        public void btnFalse()
        {
            BtnPay.Enabled = false;
        }

        private void OrderTickets_Load(object sender, EventArgs e)
        {
            GetInfo();
            btnFalse();
            progHide();
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu1 Menu1 = new Menu1();
            Menu1.Show();
            MessageBox.Show("Оплачено :)", "", MessageBoxButtons.OK);
        }

        private void BtnBook_Click(object sender, EventArgs e)
        {
            progress = 0;
            mseconds = 600;
            BtnPay.Enabled = true;
            OrderTimer.Start();
            OrderTimer.Start();
            progressBar.Visible = true;
            BtnBook.Enabled = false;
        }
        int progress;
        int mseconds;


      

        public void CheckPrice()
        {
            int price = 1000;

            if (ArrivalDateTimePickerFall.Value.DayOfWeek == DayOfWeek.Saturday)
            {
                if (price < 1100)
                {
                    price += 100;
                }

            }
            if (ArrivalDateTimePickerFall.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                if (price < 1100)
                {
                    price += 100;
                }

            }
            if (DepartureDateTimePicker.Value.DayOfWeek == DayOfWeek.Saturday)
            {
                if (price < 1100)
                {
                    price += 100;
                }

            }
            if (DepartureDateTimePicker.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                if (price < 1100)
                {
                    price += 100;
                }
            }
            LabelPrice.Text = price.ToString();
        }

        


        public void Check()
        {
            if (Buffer.TextBoxComapnyBuf == "Выберите авиакомпанию")
            {
                if (Buffer.TextBoxComapnyBuf == "Выберите авиакомпанию" && Buffer.TextBoxFlightBuf == "Выберите номер рейса")
                {
                    MessageBox.Show("Вы не выбрали авиакомпанию и номер рейса", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Buffer.CheckString = false;
                }

                else MessageBox.Show("Вы не выбрали авиакомпанию", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (Buffer.TextBoxFlightBuf == "Выберите номер рейса")
            {
                MessageBox.Show("Вы не выбрали номер рейса", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void AirlineTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu2 menu2 = new Menu2();
            menu2.Show();
        }

        private void DepartureDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            CheckPrice();
        }

        private void ArrivalDateTimePickerFall_ValueChanged(object sender, EventArgs e)
        {
            if (DepartureDateTimePicker.Value > ArrivalDateTimePickerFall.Value)
            {
                MessageBox.Show("Ошибка дата посадки не может быть раньше даты вылета", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ArrivalDateTimePickerFall.Value = DepartureDateTimePicker.Value;
            }
            CheckPrice();
        }

        private void OrderTimer_Tick_1(object sender, EventArgs e)
        {

            mseconds--;
            progress++;
            progressBar.Value = progress;

            if (mseconds <= 0)
            {

                OrderTimer.Stop();
                MessageBox.Show("Вы не успели оплатить", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                progressBar.Visible = false;
                BtnPay.Enabled = false;
                BtnBook.Enabled = true;
                DepartureDateTimePicker.Value = DateTime.Now;
                ArrivalDateTimePickerFall.Value = DateTime.Now;
                Buffer.TextBoxComapnyBuf = "Выберите авиакомпанию";
                Buffer.TextBoxFlightBuf = "Выберите № рейса";
                AirlineTextBox.Text = "Выберите авиакомпанию";
                FlightTextBox.Text = "Выберите № рейса";


            }
        }

        private void BtnPay_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Menu1 Menu1 = new Menu1();
            Menu1.Show();
            MessageBox.Show("Успешно ", "", MessageBoxButtons.OK);
        }
    }
}