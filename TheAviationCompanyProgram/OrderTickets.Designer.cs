namespace TheAviationCompanyProgram
{
    partial class OrderTickets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderTickets));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AirlineTextBox = new System.Windows.Forms.TextBox();
            this.FlightTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnBook = new System.Windows.Forms.Button();
            this.BtnPay = new System.Windows.Forms.Button();
            this.ArrivalDateTimePickerFall = new System.Windows.Forms.DateTimePicker();
            this.DepartureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OrderTimer = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 92);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TheAviationCompanyProgram.Properties.Resources.back;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Заказ билетов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AirlineTextBox
            // 
            this.AirlineTextBox.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AirlineTextBox.Location = new System.Drawing.Point(91, 144);
            this.AirlineTextBox.Multiline = true;
            this.AirlineTextBox.Name = "AirlineTextBox";
            this.AirlineTextBox.Size = new System.Drawing.Size(151, 29);
            this.AirlineTextBox.TabIndex = 11;
            this.AirlineTextBox.TextChanged += new System.EventHandler(this.DepartureDateTimePicker_ValueChanged);
            // 
            // FlightTextBox
            // 
            this.FlightTextBox.Font = new System.Drawing.Font("Open Sans", 11.25F);
            this.FlightTextBox.Location = new System.Drawing.Point(281, 144);
            this.FlightTextBox.Multiline = true;
            this.FlightTextBox.Name = "FlightTextBox";
            this.FlightTextBox.Size = new System.Drawing.Size(151, 29);
            this.FlightTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(106, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Авиакомпания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(320, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "№ Рейса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(115, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Дата вылета";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(291, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Дата прибытия";
            // 
            // BtnBook
            // 
            this.BtnBook.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnBook.Location = new System.Drawing.Point(96, 276);
            this.BtnBook.Name = "BtnBook";
            this.BtnBook.Size = new System.Drawing.Size(146, 63);
            this.BtnBook.TabIndex = 19;
            this.BtnBook.Text = "Забронировать";
            this.BtnBook.UseVisualStyleBackColor = true;
            this.BtnBook.Click += new System.EventHandler(this.BtnBook_Click);
            // 
            // BtnPay
            // 
            this.BtnPay.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnPay.Location = new System.Drawing.Point(281, 275);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(151, 63);
            this.BtnPay.TabIndex = 20;
            this.BtnPay.Text = "Оплатить";
            this.BtnPay.UseVisualStyleBackColor = true;
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click_1);
            // 
            // ArrivalDateTimePickerFall
            // 
            this.ArrivalDateTimePickerFall.CalendarFont = new System.Drawing.Font("Open Sans Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArrivalDateTimePickerFall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArrivalDateTimePickerFall.Location = new System.Drawing.Point(281, 218);
            this.ArrivalDateTimePickerFall.Margin = new System.Windows.Forms.Padding(2);
            this.ArrivalDateTimePickerFall.Name = "ArrivalDateTimePickerFall";
            this.ArrivalDateTimePickerFall.Size = new System.Drawing.Size(151, 21);
            this.ArrivalDateTimePickerFall.TabIndex = 22;
            this.ArrivalDateTimePickerFall.ValueChanged += new System.EventHandler(this.ArrivalDateTimePickerFall_ValueChanged);
            // 
            // DepartureDateTimePicker
            // 
            this.DepartureDateTimePicker.CalendarFont = new System.Drawing.Font("Open Sans Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepartureDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepartureDateTimePicker.Location = new System.Drawing.Point(91, 218);
            this.DepartureDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.DepartureDateTimePicker.Name = "DepartureDateTimePicker";
            this.DepartureDateTimePicker.Size = new System.Drawing.Size(151, 21);
            this.DepartureDateTimePicker.TabIndex = 21;
            this.DepartureDateTimePicker.ValueChanged += new System.EventHandler(this.DepartureDateTimePicker_ValueChanged);
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPrice.ForeColor = System.Drawing.Color.Black;
            this.LabelPrice.Location = new System.Drawing.Point(331, 360);
            this.LabelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(46, 22);
            this.LabelPrice.TabIndex = 23;
            this.LabelPrice.Text = "0000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(128, 360);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 22);
            this.label6.TabIndex = 24;
            this.label6.Text = "Цена билета составляет:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(381, 360);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 22);
            this.label7.TabIndex = 25;
            this.label7.Text = "руб.";
            // 
            // OrderTimer
            // 
            this.OrderTimer.Tick += new System.EventHandler(this.OrderTimer_Tick_1);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 394);
            this.progressBar.Maximum = 600;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(532, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 26;
            // 
            // OrderTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 417);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.ArrivalDateTimePickerFall);
            this.Controls.Add(this.DepartureDateTimePicker);
            this.Controls.Add(this.BtnPay);
            this.Controls.Add(this.BtnBook);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FlightTextBox);
            this.Controls.Add(this.AirlineTextBox);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderTickets";
            this.Text = "AirlaneBooking";
            this.Load += new System.EventHandler(this.OrderTickets_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AirlineTextBox;
        private System.Windows.Forms.TextBox FlightTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnBook;
        private System.Windows.Forms.Button BtnPay;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker ArrivalDateTimePickerFall;
        private System.Windows.Forms.DateTimePicker DepartureDateTimePicker;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer OrderTimer;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}