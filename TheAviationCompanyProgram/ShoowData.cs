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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TheAviationCompanyProgram;
using tasttag;

namespace TheAviationCompanyProgram
{
    public partial class ShoowData : Form
    {
        public ShoowData()
        {
            InitializeComponent();

            CompanyLoadData();

            FlightLoadData();
        }

        public MySqlConnection connection;
        public DataTable dataTable;
        public string server = "server=localhost; port=3306; username=root; password=root; database=airport;";

        //Загразука данных из табл компания
        public void CompanyLoadData()
        {
            connection = new MySqlConnection(server);
            connection.Open();
            Column1.DataPropertyName = "name";
            string infoDB = "SELECT name FROM company";
            MySqlDataAdapter adpt = new MySqlDataAdapter(infoDB, connection);
            dataTable = new DataTable();
            adpt.Fill(dataTable);
            DataGridCompany.DataSource = dataTable;
            connection.Close();
        }


        //Загразука данных из таб рейсы
        public void FlightLoadData()
        {
            connection = new MySqlConnection(server);
            connection.Open();
            Column2.DataPropertyName = "Number";
            string infoDB = "SELECT Number FROM flight";
            MySqlDataAdapter adpt = new MySqlDataAdapter(infoDB, connection);
            dataTable = new DataTable();
            adpt.Fill(dataTable);
            DataGridFlight.DataSource = dataTable;
            connection.Close();
        }




        private void btnbackmenu2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu1 menu1 = new Menu1();
            menu1.Show();

        }


        private void DataGridCompany_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxCompany2.Text = DataGridCompany.CurrentRow.Cells[0].Value.ToString();
        }

        private void DataGridFlight_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxFlight2.Text = DataGridFlight.CurrentRow.Cells[0].Value.ToString();
        }



        private void BtnSaveShow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxCompany2.Text) || string.IsNullOrEmpty(TextBoxFlight2.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            // Сохранение данных (вы можете использовать класс FlightData, как в предыдущем примере)
            Buffer.TextBoxComapnyBuf = TextBoxCompany2.Text;
            Buffer.TextBoxFlightBuf = TextBoxFlight2.Text;

            MessageBox.Show("Сохранено", "", MessageBoxButtons.OK);

            Form chooseoflocations = new ChoiceOfLocations(); 
            chooseoflocations.Show(); 
            this.Hide(); 
        }



    }
}
