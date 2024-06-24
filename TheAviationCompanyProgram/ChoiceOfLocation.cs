using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheAviationCompanyProgram
{
    public partial class ChoiceOfLocation : Form
    {
        public ChoiceOfLocation()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            // Проверяем, не выбрано ли уже максимальное количество мест
            if (_selectedSeats.Count < 5 || clickedButton.BackColor == Color.Yellow)
            {
                // Меняем цвет кнопки
                clickedButton.BackColor = (clickedButton.BackColor == Color.Green || clickedButton.BackColor == Color.LightBlue)
                                             ? Color.Yellow
                                             : (clickedButton.BackColor == Color.Yellow && clickedButton.Tag.ToString().Contains("E"))
                                                 ? Color.Green
                                                 : Color.LightBlue; // Цвет, если место уже выбрано 

                // Получаем информацию о месте из тега кнопки (SeatId, Row, Price)
                // Пример: btnSeat1.Tag = "SeatId:1|Row:1|Price:100|E" (E - эконом, B - бизнес)
                string[] tagParts = clickedButton.Tag.ToString().Split('|');
                int seatId = int.Parse(tagParts[0].Split(':')[1]);
                int row = int.Parse(tagParts[1].Split(':')[1]);
                decimal price = decimal.Parse(tagParts[2].Split(':')[1]);
                string seatClass = tagParts[3];

                // Обновляем список выбранных мест
                if (clickedButton.BackColor == Color.Yellow)
                {
                    _selectedSeats.Add(new SeatInfo { SeatId = seatId, Row = row, Price = price, Class = seatClass });
                }
                else
                {
                    _selectedSeats.RemoveAll(s => s.SeatId == seatId);
                }

                // Обновляем информацию о выбранных местах и итоговую сумму
                UpdateSelectedSeatInfo();
            }
            else
            {
                MessageBox.Show("Можно выбрать не более 5 мест.");
            }

            
        }

        public class SeatInfo
        {
            public int SeatId { get; set; }
            public int Row { get; set; }
            public decimal Price { get; set; }
            public string Class { get; set; } // "E" или "B"
        }

        // Список для хранения выбранных мест
        private List<SeatInfo> _selectedSeats = new List<SeatInfo>();



        private void UpdateSelectedSeatInfo()
        {
            // Очищаем предыдущую информацию
            listBoxSelectedSeats.Items.Clear();
            labelTotalPrice.Text = "Итого: 0";

            // Выводим информацию о каждом выбранном месте
            decimal totalPrice = 0;
            foreach (var seat in _selectedSeats)
            {
                listBoxSelectedSeats.Items.Add($"Ряд {seat.Row}, Место {seat.SeatId}, Класс: {(seat.Class == "E" ? "Эконом" : "Бизнес")}, Цена: {seat.Price}");
                totalPrice += seat.Price;
            }

            // Отображаем итоговую стоимость
            labelTotalPrice.Text = $"Итого: {totalPrice}";
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedSeats.Count > 0)
            {
                try
                {
                    // Обновляем базу данных 
                    using (var connection = new SqlConnection()) // Подставьте строку подключения
                    {
                        await connection.OpenAsync();

                        foreach (var seat in _selectedSeats)
                        {
                            // Выполняем SQL-запрос на обновление статуса бронирования места 
                            await connection.ExecuteAsync(
                                "UPDATE Seats SET IsBooked = 1 WHERE SeatId = @SeatId",
                                new { SeatId = seat.SeatId });
                        }
                    }

                    MessageBox.Show("Места успешно забронированы!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Обновляем состояние кнопок (делаем их недоступными)
                    foreach (var seat in _selectedSeats)
                    {
                        Button btnSeat = Controls.Find("btnSeat" + seat.SeatId, true).FirstOrDefault() as Button;
                        if (btnSeat != null)
                        {
                            btnSeat.Enabled = false;
                            // Можно изменить цвет или добавить другую индикацию
                        }
                    }

                    // Очищаем список выбранных мест
                    _selectedSeats.Clear();
                    UpdateSelectedSeatInfo(); // Обновляем информацию на форме
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка при бронировании: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите хотя бы одно место.");
            }
        }

        private void btnSeat1_Click(object sender, EventArgs e)
        {
            btnSeat1.Tag = "SeatId:1|Row:1|Price:100|E";
        }
    }
}
