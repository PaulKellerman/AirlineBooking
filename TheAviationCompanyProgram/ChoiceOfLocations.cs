﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TheAviationCompanyProgram
{
    public partial class ChoiceOfLocations : Form
    {
        // хранение данных о местах
        private Dictionary<string, SeatData> seatDataMap = new Dictionary<string, SeatData>();

        private List<string> selectedSeats = new List<string>();
        private System.Windows.Forms.Label[] seatLabels;

        // хранение исходных текстов Label
        private Dictionary<System.Windows.Forms.Label, string> originalLabelTexts = new Dictionary<System.Windows.Forms.Label, string>();

        public ChoiceOfLocations()
        {
            InitializeComponent();
            InitializeSeatDataMap();
            LoadOccupiedSeats();

            Button[] buttons = new Button[105];
            for (int i = 1; i <= 105; i++)
            {
                var button = this.Controls.Find("btnSeat" + i, true).FirstOrDefault() as Button;
                if (button != null)
                {
                    button.Click += Button_Click;
                }
            }

            // Инициализируем массив Label
            seatLabels = new System.Windows.Forms.Label[] { labelS1, labelS2, labelS3, labelS4, labelS5 };

            // сохранение исходных текстов Label
            foreach (var label in seatLabels)
            {
                originalLabelTexts[label] = label.Text;
            }
        }

        private void InitializeSeatDataMap()
        {
            // все места ряда "F" - Эконом
            seatDataMap.Add("btnSeat1", new SeatData(3, "F", 4000, "Эконом"));
            seatDataMap.Add("btnSeat2", new SeatData(4, "F", 4000, "Эконом"));
            seatDataMap.Add("btnSeat3", new SeatData(5, "F", 4000, "Эконом"));
            seatDataMap.Add("btnSeat5", new SeatData(6, "F", 4000, "Эконом"));
            seatDataMap.Add("btnSeat6", new SeatData(7, "F", 4000, "Эконом"));
            seatDataMap.Add("btnSeat7", new SeatData(8, "F", 4000, "Эконом"));
            seatDataMap.Add("btnSeat8", new SeatData(9, "F", 4000, "Эконом"));
            seatDataMap.Add("btnSeat9", new SeatData(10, "F", 4000, "Эконом"));
            seatDataMap.Add("btnSeat10", new SeatData(11, "F", 4000, "Эконом"));
            seatDataMap.Add("btnSeat11", new SeatData(12, "F", 4000, "Эконом"));
            seatDataMap.Add("btnSeat12", new SeatData(13, "F", 4000, "Эконом"));
            seatDataMap.Add("btnSeat13", new SeatData(14, "F", 4000, "Эконом"));
            seatDataMap.Add("btnSeat14", new SeatData(15, "F", 4000, "Эконом"));
            seatDataMap.Add("btnSeat15", new SeatData(16, "F", 4000, "Эконом"));
            seatDataMap.Add("btnSeat16", new SeatData(17, "F", 4000, "Эконом"));
            seatDataMap.Add("btnSeat17", new SeatData(18, "F", 4000, "Эконом"));
            //все места ряда "E" - Эконом
            seatDataMap.Add("btnSeat18", new SeatData(3, "E", 4000, "Эконом"));
            seatDataMap.Add("btnSeat19", new SeatData(4, "E", 4000, "Эконом"));
            seatDataMap.Add("btnSeat20", new SeatData(5, "E", 4000, "Эконом"));
            seatDataMap.Add("btnSeat21", new SeatData(6, "E", 4000, "Эконом"));
            seatDataMap.Add("btnSeat22", new SeatData(7, "E", 4000, "Эконом"));
            seatDataMap.Add("btnSeat23", new SeatData(8, "E", 4000, "Эконом"));
            seatDataMap.Add("btnSeat24", new SeatData(9, "E", 4000, "Эконом"));
            seatDataMap.Add("btnSeat25", new SeatData(10, "E", 4000, "Эконом"));
            seatDataMap.Add("btnSeat26", new SeatData(11, "E", 4000, "Эконом"));
            seatDataMap.Add("btnSeat27", new SeatData(12, "E", 4000, "Эконом"));
            seatDataMap.Add("btnSeat28", new SeatData(13, "E", 4000, "Эконом"));
            seatDataMap.Add("btnSeat29", new SeatData(14, "E", 4000, "Эконом"));
            seatDataMap.Add("btnSeat30", new SeatData(15, "E", 4000, "Эконом"));
            seatDataMap.Add("btnSeat31", new SeatData(16, "E", 4000, "Эконом"));
            seatDataMap.Add("btnSeat32", new SeatData(17, "E", 4000, "Эконом"));
            seatDataMap.Add("btnSeat33", new SeatData(18, "E", 4000, "Эконом"));
            //все места ряда "D" - Эконом  
            seatDataMap.Add("btnSeat34", new SeatData(3, "D", 4000, "Эконом"));
            seatDataMap.Add("btnSeat35", new SeatData(4, "D", 4000, "Эконом"));
            seatDataMap.Add("btnSeat36", new SeatData(5, "D", 4000, "Эконом"));
            seatDataMap.Add("btnSeat37", new SeatData(6, "D", 4000, "Эконом"));
            seatDataMap.Add("btnSeat38", new SeatData(7, "D", 4000, "Эконом"));
            seatDataMap.Add("btnSeat39", new SeatData(8, "D", 4000, "Эконом"));
            seatDataMap.Add("btnSeat40", new SeatData(9, "D", 4000, "Эконом"));
            seatDataMap.Add("btnSeat41", new SeatData(10, "D", 4000, "Эконом"));
            seatDataMap.Add("btnSeat42", new SeatData(11, "D", 4000, "Эконом"));
            seatDataMap.Add("btnSeat43", new SeatData(12, "D", 4000, "Эконом"));
            seatDataMap.Add("btnSeat44", new SeatData(13, "D", 4000, "Эконом"));
            seatDataMap.Add("btnSeat45", new SeatData(14, "D", 4000, "Эконом"));
            seatDataMap.Add("btnSeat46", new SeatData(15, "D", 4000, "Эконом"));
            seatDataMap.Add("btnSeat47", new SeatData(16, "D", 4000, "Эконом"));
            seatDataMap.Add("btnSeat48", new SeatData(17, "D", 4000, "Эконом"));
            seatDataMap.Add("btnSeat49", new SeatData(18, "D", 4000, "Эконом"));
            //все места ряда "C" - Эконом
            seatDataMap.Add("btnSeat50", new SeatData(3, "C", 4000, "Эконом"));
            seatDataMap.Add("btnSeat51", new SeatData(4, "C", 4000, "Эконом"));
            seatDataMap.Add("btnSeat52", new SeatData(5, "C", 4000, "Эконом"));
            seatDataMap.Add("btnSeat53", new SeatData(6, "C", 4000, "Эконом"));
            seatDataMap.Add("btnSeat54", new SeatData(7, "C", 4000, "Эконом"));
            seatDataMap.Add("btnSeat55", new SeatData(8, "C", 4000, "Эконом"));
            seatDataMap.Add("btnSeat56", new SeatData(9, "C", 4000, "Эконом"));
            seatDataMap.Add("btnSeat57", new SeatData(10, "C", 4000, "Эконом"));
            seatDataMap.Add("btnSeat58", new SeatData(11, "C", 4000, "Эконом"));
            seatDataMap.Add("btnSeat59", new SeatData(12, "C", 4000, "Эконом"));
            seatDataMap.Add("btnSeat60", new SeatData(13, "C", 4000, "Эконом"));
            seatDataMap.Add("btnSeat61", new SeatData(14, "C", 4000, "Эконом"));
            seatDataMap.Add("btnSeat62", new SeatData(15, "C", 4000, "Эконом"));
            seatDataMap.Add("btnSeat63", new SeatData(16, "C", 4000, "Эконом"));
            seatDataMap.Add("btnSeat64", new SeatData(17, "C", 4000, "Эконом"));
            seatDataMap.Add("btnSeat65", new SeatData(18, "C", 4000, "Эконом"));
            //все места ряда "B" - Эконом
            seatDataMap.Add("btnSeat66", new SeatData(3, "B", 4000, "Эконом"));
            seatDataMap.Add("btnSeat67", new SeatData(4, "B", 4000, "Эконом"));
            seatDataMap.Add("btnSeat68", new SeatData(5, "B", 4000, "Эконом"));
            seatDataMap.Add("btnSeat69", new SeatData(6, "B", 4000, "Эконом"));
            seatDataMap.Add("btnSeat70", new SeatData(7, "B", 4000, "Эконом"));
            seatDataMap.Add("btnSeat71", new SeatData(8, "B", 4000, "Эконом"));
            seatDataMap.Add("btnSeat72", new SeatData(9, "B", 4000, "Эконом"));
            seatDataMap.Add("btnSeat73", new SeatData(10, "B", 4000, "Эконом"));
            seatDataMap.Add("btnSeat74", new SeatData(11, "B", 4000, "Эконом"));
            seatDataMap.Add("btnSeat75", new SeatData(12, "B", 4000, "Эконом"));
            seatDataMap.Add("btnSeat76", new SeatData(13, "B", 4000, "Эконом"));
            seatDataMap.Add("btnSeat77", new SeatData(14, "B", 4000, "Эконом"));
            seatDataMap.Add("btnSeat78", new SeatData(15, "B", 4000, "Эконом"));
            seatDataMap.Add("btnSeat79", new SeatData(16, "B", 4000, "Эконом"));
            seatDataMap.Add("btnSeat80", new SeatData(17, "B", 4000, "Эконом"));
            seatDataMap.Add("btnSeat81", new SeatData(18, "B", 4000, "Эконом"));
            //все места ряда "A" - Эконом
            seatDataMap.Add("btnSeat82", new SeatData(3, "A", 4000, "Эконом"));
            seatDataMap.Add("btnSeat83", new SeatData(4, "A", 4000, "Эконом"));
            seatDataMap.Add("btnSeat84", new SeatData(5, "A", 4000, "Эконом"));
            seatDataMap.Add("btnSeat85", new SeatData(6, "A", 4000, "Эконом"));
            seatDataMap.Add("btnSeat86", new SeatData(7, "A", 4000, "Эконом"));
            seatDataMap.Add("btnSeat87", new SeatData(8, "A", 4000, "Эконом"));
            seatDataMap.Add("btnSeat88", new SeatData(9, "A", 4000, "Эконом"));
            seatDataMap.Add("btnSeat89", new SeatData(10, "A", 4000, "Эконом"));
            seatDataMap.Add("btnSeat90", new SeatData(11, "A", 4000, "Эконом"));
            seatDataMap.Add("btnSeat91", new SeatData(12, "A", 4000, "Эконом"));
            seatDataMap.Add("btnSeat92", new SeatData(13, "A", 4000, "Эконом"));
            seatDataMap.Add("btnSeat93", new SeatData(14, "A", 4000, "Эконом"));
            seatDataMap.Add("btnSeat94", new SeatData(15, "A", 4000, "Эконом"));
            seatDataMap.Add("btnSeat95", new SeatData(16, "A", 4000, "Эконом"));
            seatDataMap.Add("btnSeat96", new SeatData(17, "A", 4000, "Эконом"));
            seatDataMap.Add("btnSeat97", new SeatData(18, "A", 4000, "Эконом"));
            //все метса ряда "F" - Бизнес
            seatDataMap.Add("btnSeat98", new SeatData(1, "F", 8000, "Бизнес"));
            seatDataMap.Add("btnSeat99", new SeatData(2, "F", 8000, "Бизнес"));
            //все метса ряда "D" - Бизнес
            seatDataMap.Add("btnSeat100", new SeatData(1, "D", 8000, "Бизнес"));
            seatDataMap.Add("btnSeat101", new SeatData(2, "D", 8000, "Бизнес"));
            //все метса ряда "C" - Бизнес
            seatDataMap.Add("btnSeat102", new SeatData(1, "C", 8000, "Бизнес"));
            seatDataMap.Add("btnSeat103", new SeatData(2, "C", 8000, "Бизнес"));
            //все метса ряда "A" - Бизнес
            seatDataMap.Add("btnSeat104", new SeatData(1, "A", 8000, "Бизнес"));
            seatDataMap.Add("btnSeat105", new SeatData(2, "A", 8000, "Бизнес"));
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonKey = clickedButton.Name;

            // проверка выбрано ли место уже
            if (selectedSeats.Contains(buttonKey))
            {
                int index = selectedSeats.IndexOf(buttonKey);
                selectedSeats.RemoveAt(index);

                if (buttonKey == "btnSeat98" || buttonKey == "btnSeat99" || buttonKey == "btnSeat100" ||
                    buttonKey == "btnSeat101" || buttonKey == "btnSeat102" || buttonKey == "btnSeat103" ||
                    buttonKey == "btnSeat104" || buttonKey == "btnSeat105")
                {
                    clickedButton.BackColor = Color.Green;
                }
                else
                {
                    clickedButton.BackColor = Color.Lime;
                }

                // сброс соответствующего текста к исходному тексту
                if (index >= 0 && index < seatLabels.Length)
                {
                    seatLabels[index].Text = originalLabelTexts[seatLabels[index]];
                }

                for (int i = index; i < selectedSeats.Count; i++)
                {
                    seatLabels[i].Text = seatLabels[i + 1].Text;
                }

                if (selectedSeats.Count < seatLabels.Length)
                {
                    seatLabels[selectedSeats.Count].Text = originalLabelTexts[seatLabels[selectedSeats.Count]];
                }

                UpdateFullPrice();
            }
            else
            {
                // проверка на лимит кнопок
                if (selectedSeats.Count < seatLabels.Length)
                {
                    // Добавление места в список выбранных мест
                    selectedSeats.Add(buttonKey);
                    clickedButton.BackColor = Color.Blue;

                    int index = selectedSeats.Count - 1;
                    if (seatDataMap.TryGetValue(buttonKey, out SeatData seatData))
                    {
                        seatLabels[index].Text = $"Ряд: {seatData.Row}, Место: {seatData.Place}, Стоимость: {seatData.Price}, Класс: {seatData.Class}";
                    }

                    UpdateFullPrice();
                }
                else
                {
                    MessageBox.Show("Вы можете выбрать максимум 5 мест.");
                }
            }
        }

        public int fullPrice = 0;
        private void UpdateFullPrice()
        {
            fullPrice = 0;
            foreach (var seat in selectedSeats)
            {
                if (seatDataMap.TryGetValue(seat, out SeatData seatData))
                {
                    fullPrice += seatData.Price;
                }
            }
            FullPrice.Text = $"Полная стоимость: {fullPrice}";
        }

        // класс для хранения данных о месте
        private class SeatData
        {
            public int Row { get; set; }
            public string Place { get; set; }
            public int Price { get; set; }
            public string Class { get; set; }

            public SeatData(int row, string place, int price, string classType)
            {
                Row = row;
                Place = place;
                Price = price;
                Class = classType;
            }
        }

        private void btnbackmenu2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu2 menu2 = new Menu2();
            menu2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Все успешно сохранилось!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            this.Close();
            Menu2 menu2 = new Menu2();
            menu2.Show();

            Buffer.priceC = fullPrice;
            SaveSelectedSeatsToDatabase();
        }

        private void SaveSelectedSeatsToDatabase()
        {
            string connectionString = "server=localhost; port=3306; username=root; password=root; database=airport;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                foreach (var seat in selectedSeats)
                {
                    if (seatDataMap.TryGetValue(seat, out SeatData seatData))
                    {
                        string query = "INSERT INTO choiceoflocation (Row, Place, Price, Class) VALUES (@Row, @Place, @Price, @Class)";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Row", seatData.Row);
                            command.Parameters.AddWithValue("@Place", seatData.Place);
                            command.Parameters.AddWithValue("@Price", seatData.Price);
                            command.Parameters.AddWithValue("@Class", seatData.Class);

                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
        }





        private void LoadOccupiedSeats()
        {
            string connectionString = "server=localhost; port=3306; username=root; password=root; database=airport;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Row, Place FROM choiceoflocation";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int row = reader.GetInt32("Row");
                            string place = reader.GetString("Place");
                            string buttonKey = seatDataMap.FirstOrDefault(x => x.Value.Row == row && x.Value.Place == place).Key;

                            if (!string.IsNullOrEmpty(buttonKey))
                            {
                                var button = this.Controls.Find(buttonKey, true).FirstOrDefault() as Button;
                                if (button != null)
                                {
                                    button.BackColor = Color.Gray; 
                                    button.Enabled = false; 
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}