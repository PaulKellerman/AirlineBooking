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
using System.Xml.Linq;

namespace TheAviationCompanyProgram
{
    public partial class AddDataF : Form
    {
        public AddDataF()
        {
            InitializeComponent();
            connection = new MySqlConnection(server);
        }

        private void btnbackmenu2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu2 menu2 = new Menu2();
            menu2.Show();
        }


        public string server = "server=localhost; port=3306; username=root; password=root; database=airport;";
        public MySqlConnection connection;
        public MySqlCommand command;
        public DataTable dataTable;




        //функция загрузки бд в таблицу Рейс
        private void buttonLoadReis_Click(object sender, EventArgs e) => GetFlightDB();

        private void GetFlightDB()
        {
            connection = new MySqlConnection(server);
            connection.Open();
            dataGridReis.AutoGenerateColumns = false;
            IdFlight.DataPropertyName = "id";
            NumFlight.DataPropertyName = "Number";
            DepartureСity.DataPropertyName = "departureСity";
            ArrivalСity.DataPropertyName = "arrivalСity";
            DepartureTime.DataPropertyName = "departureTime";
            ArrivalTime.DataPropertyName = "arrivalTime";
            string infoDB = "SELECT * FROM flight";
            MySqlDataAdapter adpt = new MySqlDataAdapter(infoDB, connection);
            dataTable = new DataTable();
            adpt.Fill(dataTable);
            dataGridReis.DataSource = dataTable;
            connection.Close();
        }




       

        private void BtnCompanyDel_Click(object sender, EventArgs e)
        {
            CompanyDelC();
        }



        private object GetIdC()
        {
            return dataGridCompany.SelectedRows[0].Cells[0].Value;
        }






        //функция загрузки бд в таблицу Компания
        private void BtnLoadDbCompany_Click_1(object sender, EventArgs e)
        {
            GetCompanyDB();
        }

        public void GetCompanyDB()
        {
            connection.Open();
            dataGridCompany.AutoGenerateColumns = false;
            IdComapny.DataPropertyName = "id";
            NameCompany.DataPropertyName = "Name";
            YearCompany.DataPropertyName = "Year";
            RatingCompany.DataPropertyName = "Rating";
            string infoDB = "SELECT id, Name, Year, Rating FROM company";
            MySqlDataAdapter adpt = new MySqlDataAdapter(infoDB, connection);
            dataTable = new DataTable();
            adpt.Fill(dataTable);
            dataGridCompany.DataSource = dataTable;
            connection.Close();
        }





        //кнокпка удаления в таблице Рейсы
        private void BtnDelDbF_Click(object sender, EventArgs e)
        {
            FlightDelC();
        }

        private void FlightDelC()
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand("DELETE FROM `flight` WHERE `flight`.`id` = @id", connection);
            command.Parameters.Add("@id", MySqlDbType.Int16).Value = GetIdR();
            command.ExecuteNonQuery();
            connection.Close();

            dataGridReis.Rows.RemoveAt(dataGridReis.SelectedRows[0].Index);
        }

        private object GetIdR()
        {
            return dataGridReis.SelectedRows[0].Cells[0].Value;
        }

        private void BtnSaveDbF_Click_1(object sender, EventArgs e)
        {
            // Проверка на пустые поля ввода
            if (string.IsNullOrEmpty(TextBoxNumF.Text) ||
                string.IsNullOrEmpty(TextBoxDepartureСityF.Text) ||
                string.IsNullOrEmpty(TextBoxArrivalСityF.Text) ||
                string.IsNullOrEmpty(TextBoxDepartureTimeF.Text) ||
                string.IsNullOrEmpty(TextBoxArrivalTimeF.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            try
            {

                connection.Open();

                MySqlCommand command = new MySqlCommand(
                    "INSERT INTO flight (Number , departureСity, arrivalСity, departureTime, arrivalTime) VALUES (@Number, @departureСity, @arrivalСity, @departureTime, @arrivalTime);",
                    connection);

                // Заполняем параметры значениями из текстовых полей
                command.Parameters.Add("@Number", MySqlDbType.VarChar).Value = TextBoxNumF.Text;
                command.Parameters.Add("@departureСity", MySqlDbType.VarChar).Value = TextBoxDepartureСityF.Text;
                command.Parameters.Add("@arrivalСity", MySqlDbType.VarChar).Value = TextBoxArrivalСityF.Text;
                command.Parameters.Add("@departureTime", MySqlDbType.VarChar).Value = TextBoxDepartureTimeF.Text;
                command.Parameters.Add("@arrivalTime", MySqlDbType.VarChar).Value = TextBoxArrivalTimeF.Text;

                command.ExecuteNonQuery();

                connection.Close();


                GetFlightDB();

                MessageBox.Show("Данные успешно сохранены!");

                ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении данных: " + ex.Message);
            }
        }
        
        
        ///кнопка сохранения таблицы Компания
        private void BtnSaveCompany_Click_1(object sender, EventArgs e)
        {
            //проверка на пустые поля ввода
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            try
            {

                int year = Convert.ToInt32(textBox2.Text);


                connection.Open();


                MySqlCommand command = new MySqlCommand("INSERT INTO company (name, year, rating) VALUES (@n, @year, @rating);", connection);


                command.Parameters.Add("@n", MySqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@year", MySqlDbType.Int32).Value = year;
                command.Parameters.Add("@rating", MySqlDbType.VarChar).Value = textBox3.Text;


                command.ExecuteNonQuery();


                connection.Close();


                GetCompanyDB();


                MessageBox.Show("Данные успешно сохранены!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка при сохранении данных: " + ex.Message);
            }
        }

        ///кнопка удаления строк таблицы Комапания
        private void CompanyDelC()
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand("DELETE FROM `company` WHERE `company`.`id` = @id", connection);
            command.Parameters.Add("@id", MySqlDbType.Int16).Value = GetIdC();
            command.ExecuteNonQuery();
            connection.Close();

            dataGridCompany.Rows.RemoveAt(dataGridCompany.SelectedRows[0].Index);
        }

    }
}