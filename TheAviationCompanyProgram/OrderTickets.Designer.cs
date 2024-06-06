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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderTickets));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AirlineTextBox = new System.Windows.Forms.TextBox();
            this.FlightTextBox = new System.Windows.Forms.TextBox();
            this.DepartureTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ArrivalTextBox = new System.Windows.Forms.TextBox();
            this.BtnBook = new System.Windows.Forms.Button();
            this.BtnPay = new System.Windows.Forms.Button();
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
            // DepartureTextBox
            // 
            this.DepartureTextBox.Font = new System.Drawing.Font("Open Sans", 11.25F);
            this.DepartureTextBox.Location = new System.Drawing.Point(91, 210);
            this.DepartureTextBox.Multiline = true;
            this.DepartureTextBox.Name = "DepartureTextBox";
            this.DepartureTextBox.Size = new System.Drawing.Size(151, 29);
            this.DepartureTextBox.TabIndex = 13;
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
            // ArrivalTextBox
            // 
            this.ArrivalTextBox.Font = new System.Drawing.Font("Open Sans", 11.25F);
            this.ArrivalTextBox.Location = new System.Drawing.Point(281, 210);
            this.ArrivalTextBox.Multiline = true;
            this.ArrivalTextBox.Name = "ArrivalTextBox";
            this.ArrivalTextBox.Size = new System.Drawing.Size(151, 29);
            this.ArrivalTextBox.TabIndex = 18;
            // 
            // BtnBook
            // 
            this.BtnBook.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnBook.Location = new System.Drawing.Point(96, 271);
            this.BtnBook.Name = "BtnBook";
            this.BtnBook.Size = new System.Drawing.Size(146, 63);
            this.BtnBook.TabIndex = 19;
            this.BtnBook.Text = "Забронировать";
            this.BtnBook.UseVisualStyleBackColor = true;
            // 
            // BtnPay
            // 
            this.BtnPay.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnPay.Location = new System.Drawing.Point(281, 271);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(151, 63);
            this.BtnPay.TabIndex = 20;
            this.BtnPay.Text = "Оплатить";
            this.BtnPay.UseVisualStyleBackColor = true;
            // 
            // OrderTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 401);
            this.Controls.Add(this.BtnPay);
            this.Controls.Add(this.BtnBook);
            this.Controls.Add(this.ArrivalTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DepartureTextBox);
            this.Controls.Add(this.FlightTextBox);
            this.Controls.Add(this.AirlineTextBox);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderTickets";
            this.Text = "AirlaneBooking";

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
        private System.Windows.Forms.TextBox DepartureTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ArrivalTextBox;
        private System.Windows.Forms.Button BtnBook;
        private System.Windows.Forms.Button BtnPay;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}