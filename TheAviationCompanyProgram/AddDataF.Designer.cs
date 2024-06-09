namespace TheAviationCompanyProgram
{
    partial class AddDataF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDataF));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnbackmenu2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.flight = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBoxArrivalTimeF = new System.Windows.Forms.TextBox();
            this.TextBoxDepartureTimeF = new System.Windows.Forms.TextBox();
            this.TextBoxArrivalСityF = new System.Windows.Forms.TextBox();
            this.TextBoxDepartureСityF = new System.Windows.Forms.TextBox();
            this.TextBoxNumF = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnDelDbF = new System.Windows.Forms.Button();
            this.BtnLoadDbFly = new System.Windows.Forms.Button();
            this.BtnSaveDbF = new System.Windows.Forms.Button();
            this.dataGridReis = new System.Windows.Forms.DataGridView();
            this.IdFlight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumFlight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureСity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalСity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnCompanyDel = new System.Windows.Forms.Button();
            this.BtnLoadDbCompany = new System.Windows.Forms.Button();
            this.BtnSaveCompany = new System.Windows.Forms.Button();
            this.dataGridCompany = new System.Windows.Forms.DataGridView();
            this.IDcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatingCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabButton = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnbackmenu2)).BeginInit();
            this.flight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReis)).BeginInit();
            this.company.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompany)).BeginInit();
            this.tabButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.btnbackmenu2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 92);
            this.panel1.TabIndex = 11;
            // 
            // btnbackmenu2
            // 
            this.btnbackmenu2.Image = global::TheAviationCompanyProgram.Properties.Resources.back;
            this.btnbackmenu2.Location = new System.Drawing.Point(0, 0);
            this.btnbackmenu2.Name = "btnbackmenu2";
            this.btnbackmenu2.Size = new System.Drawing.Size(42, 41);
            this.btnbackmenu2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnbackmenu2.TabIndex = 10;
            this.btnbackmenu2.TabStop = false;
            this.btnbackmenu2.Click += new System.EventHandler(this.btnbackmenu2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(11, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 31);
            this.panel2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Добавление данных";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flight
            // 
            this.flight.Controls.Add(this.label9);
            this.flight.Controls.Add(this.TextBoxArrivalTimeF);
            this.flight.Controls.Add(this.TextBoxDepartureTimeF);
            this.flight.Controls.Add(this.TextBoxArrivalСityF);
            this.flight.Controls.Add(this.TextBoxDepartureСityF);
            this.flight.Controls.Add(this.TextBoxNumF);
            this.flight.Controls.Add(this.label8);
            this.flight.Controls.Add(this.label5);
            this.flight.Controls.Add(this.label6);
            this.flight.Controls.Add(this.label7);
            this.flight.Controls.Add(this.BtnDelDbF);
            this.flight.Controls.Add(this.BtnLoadDbFly);
            this.flight.Controls.Add(this.BtnSaveDbF);
            this.flight.Controls.Add(this.dataGridReis);
            this.flight.Location = new System.Drawing.Point(4, 25);
            this.flight.Margin = new System.Windows.Forms.Padding(2);
            this.flight.Name = "flight";
            this.flight.Padding = new System.Windows.Forms.Padding(2);
            this.flight.Size = new System.Drawing.Size(746, 463);
            this.flight.TabIndex = 1;
            this.flight.Text = "Рейс";
            this.flight.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(547, 351);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Время прилёта";
            // 
            // TextBoxArrivalTimeF
            // 
            this.TextBoxArrivalTimeF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxArrivalTimeF.Location = new System.Drawing.Point(549, 368);
            this.TextBoxArrivalTimeF.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxArrivalTimeF.Name = "TextBoxArrivalTimeF";
            this.TextBoxArrivalTimeF.Size = new System.Drawing.Size(105, 21);
            this.TextBoxArrivalTimeF.TabIndex = 19;
            // 
            // TextBoxDepartureTimeF
            // 
            this.TextBoxDepartureTimeF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxDepartureTimeF.Location = new System.Drawing.Point(440, 368);
            this.TextBoxDepartureTimeF.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxDepartureTimeF.Name = "TextBoxDepartureTimeF";
            this.TextBoxDepartureTimeF.Size = new System.Drawing.Size(105, 21);
            this.TextBoxDepartureTimeF.TabIndex = 17;
            // 
            // TextBoxArrivalСityF
            // 
            this.TextBoxArrivalСityF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxArrivalСityF.Location = new System.Drawing.Point(286, 368);
            this.TextBoxArrivalСityF.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxArrivalСityF.Name = "TextBoxArrivalСityF";
            this.TextBoxArrivalСityF.Size = new System.Drawing.Size(150, 21);
            this.TextBoxArrivalСityF.TabIndex = 13;
            // 
            // TextBoxDepartureСityF
            // 
            this.TextBoxDepartureСityF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxDepartureСityF.Location = new System.Drawing.Point(133, 368);
            this.TextBoxDepartureСityF.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxDepartureСityF.Name = "TextBoxDepartureСityF";
            this.TextBoxDepartureСityF.Size = new System.Drawing.Size(150, 21);
            this.TextBoxDepartureСityF.TabIndex = 12;
            // 
            // TextBoxNumF
            // 
            this.TextBoxNumF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxNumF.Location = new System.Drawing.Point(6, 368);
            this.TextBoxNumF.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxNumF.Name = "TextBoxNumF";
            this.TextBoxNumF.Size = new System.Drawing.Size(123, 21);
            this.TextBoxNumF.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(438, 351);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Время вылета";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 351);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Город прилёта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 351);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Город вылета";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 351);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Номер рейса";
            // 
            // BtnDelDbF
            // 
            this.BtnDelDbF.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnDelDbF.Location = new System.Drawing.Point(228, 406);
            this.BtnDelDbF.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDelDbF.Name = "BtnDelDbF";
            this.BtnDelDbF.Size = new System.Drawing.Size(66, 36);
            this.BtnDelDbF.TabIndex = 6;
            this.BtnDelDbF.Text = "Удалить";
            this.BtnDelDbF.UseVisualStyleBackColor = false;
            this.BtnDelDbF.Click += new System.EventHandler(this.BtnDelDbF_Click);
            // 
            // BtnLoadDbFly
            // 
            this.BtnLoadDbFly.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnLoadDbFly.Location = new System.Drawing.Point(19, 406);
            this.BtnLoadDbFly.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLoadDbFly.Name = "BtnLoadDbFly";
            this.BtnLoadDbFly.Size = new System.Drawing.Size(94, 36);
            this.BtnLoadDbFly.TabIndex = 5;
            this.BtnLoadDbFly.Text = "Загрузить БД";
            this.BtnLoadDbFly.UseVisualStyleBackColor = false;
            this.BtnLoadDbFly.Click += new System.EventHandler(this.buttonLoadReis_Click);
            // 
            // BtnSaveDbF
            // 
            this.BtnSaveDbF.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnSaveDbF.Location = new System.Drawing.Point(118, 406);
            this.BtnSaveDbF.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSaveDbF.Name = "BtnSaveDbF";
            this.BtnSaveDbF.Size = new System.Drawing.Size(106, 36);
            this.BtnSaveDbF.TabIndex = 4;
            this.BtnSaveDbF.Text = "Сохранить БД";
            this.BtnSaveDbF.UseVisualStyleBackColor = false;
            this.BtnSaveDbF.Click += new System.EventHandler(this.BtnSaveDbF_Click);
            // 
            // dataGridReis
            // 
            this.dataGridReis.AllowUserToAddRows = false;
            this.dataGridReis.AllowUserToDeleteRows = false;
            this.dataGridReis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFlight,
            this.NumFlight,
            this.DepartureСity,
            this.ArrivalСity,
            this.DepartureTime,
            this.ArrivalTime});
            this.dataGridReis.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridReis.Location = new System.Drawing.Point(2, 2);
            this.dataGridReis.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridReis.Name = "dataGridReis";
            this.dataGridReis.ReadOnly = true;
            this.dataGridReis.RowHeadersWidth = 51;
            this.dataGridReis.RowTemplate.Height = 24;
            this.dataGridReis.Size = new System.Drawing.Size(742, 345);
            this.dataGridReis.TabIndex = 0;
            // 
            // IdFlight
            // 
            this.IdFlight.HeaderText = "id";
            this.IdFlight.MinimumWidth = 6;
            this.IdFlight.Name = "IdFlight";
            this.IdFlight.ReadOnly = true;
            this.IdFlight.Width = 70;
            // 
            // NumFlight
            // 
            this.NumFlight.HeaderText = "Номер рейса";
            this.NumFlight.MinimumWidth = 6;
            this.NumFlight.Name = "NumFlight";
            this.NumFlight.ReadOnly = true;
            this.NumFlight.Width = 125;
            // 
            // DepartureСity
            // 
            this.DepartureСity.HeaderText = "Город вылета";
            this.DepartureСity.MinimumWidth = 6;
            this.DepartureСity.Name = "DepartureСity";
            this.DepartureСity.ReadOnly = true;
            this.DepartureСity.Width = 125;
            // 
            // ArrivalСity
            // 
            this.ArrivalСity.HeaderText = "Город прилёта";
            this.ArrivalСity.MinimumWidth = 6;
            this.ArrivalСity.Name = "ArrivalСity";
            this.ArrivalСity.ReadOnly = true;
            this.ArrivalСity.Width = 125;
            // 
            // DepartureTime
            // 
            this.DepartureTime.HeaderText = "Время вылета";
            this.DepartureTime.MinimumWidth = 6;
            this.DepartureTime.Name = "DepartureTime";
            this.DepartureTime.ReadOnly = true;
            this.DepartureTime.Width = 121;
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.HeaderText = "Время прилёта";
            this.ArrivalTime.MinimumWidth = 6;
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.ReadOnly = true;
            this.ArrivalTime.Width = 121;
            // 
            // company
            // 
            this.company.Controls.Add(this.label4);
            this.company.Controls.Add(this.label3);
            this.company.Controls.Add(this.label1);
            this.company.Controls.Add(this.textBox3);
            this.company.Controls.Add(this.textBox2);
            this.company.Controls.Add(this.textBox1);
            this.company.Controls.Add(this.BtnCompanyDel);
            this.company.Controls.Add(this.BtnLoadDbCompany);
            this.company.Controls.Add(this.BtnSaveCompany);
            this.company.Controls.Add(this.dataGridCompany);
            this.company.Location = new System.Drawing.Point(4, 25);
            this.company.Margin = new System.Windows.Forms.Padding(2);
            this.company.Name = "company";
            this.company.Padding = new System.Windows.Forms.Padding(2);
            this.company.Size = new System.Drawing.Size(746, 463);
            this.company.TabIndex = 0;
            this.company.Text = "Компания";
            this.company.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 350);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Рейтинг компании";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 350);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Год основания";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 350);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(260, 367);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 21);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(133, 367);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 21);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(6, 367);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 21);
            this.textBox1.TabIndex = 5;
            // 
            // BtnCompanyDel
            // 
            this.BtnCompanyDel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnCompanyDel.Location = new System.Drawing.Point(228, 406);
            this.BtnCompanyDel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCompanyDel.Name = "BtnCompanyDel";
            this.BtnCompanyDel.Size = new System.Drawing.Size(66, 36);
            this.BtnCompanyDel.TabIndex = 4;
            this.BtnCompanyDel.Text = "Удалить";
            this.BtnCompanyDel.UseVisualStyleBackColor = false;
            this.BtnCompanyDel.Click += new System.EventHandler(this.BtnCompanyDel_Click);
            // 
            // BtnLoadDbCompany
            // 
            this.BtnLoadDbCompany.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnLoadDbCompany.Location = new System.Drawing.Point(19, 406);
            this.BtnLoadDbCompany.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLoadDbCompany.Name = "BtnLoadDbCompany";
            this.BtnLoadDbCompany.Size = new System.Drawing.Size(94, 36);
            this.BtnLoadDbCompany.TabIndex = 3;
            this.BtnLoadDbCompany.Text = "Загрузить БД";
            this.BtnLoadDbCompany.UseVisualStyleBackColor = false;
            this.BtnLoadDbCompany.Click += new System.EventHandler(this.BtnLoadDbCompany_Click_1);
            // 
            // BtnSaveCompany
            // 
            this.BtnSaveCompany.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnSaveCompany.Location = new System.Drawing.Point(118, 406);
            this.BtnSaveCompany.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSaveCompany.Name = "BtnSaveCompany";
            this.BtnSaveCompany.Size = new System.Drawing.Size(106, 36);
            this.BtnSaveCompany.TabIndex = 2;
            this.BtnSaveCompany.Text = "Сохранить БД";
            this.BtnSaveCompany.UseVisualStyleBackColor = false;
            this.BtnSaveCompany.Click += new System.EventHandler(this.BtnSaveCompany_Click);
            // 
            // dataGridCompany
            // 
            this.dataGridCompany.AllowUserToAddRows = false;
            this.dataGridCompany.AllowUserToDeleteRows = false;
            this.dataGridCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDcol,
            this.NameCompany,
            this.YearCompany,
            this.RatingCompany});
            this.dataGridCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridCompany.Location = new System.Drawing.Point(2, 2);
            this.dataGridCompany.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridCompany.Name = "dataGridCompany";
            this.dataGridCompany.ReadOnly = true;
            this.dataGridCompany.RowHeadersWidth = 51;
            this.dataGridCompany.RowTemplate.Height = 24;
            this.dataGridCompany.Size = new System.Drawing.Size(742, 346);
            this.dataGridCompany.TabIndex = 1;
            this.dataGridCompany.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCompany_CellContentClick);
            // 
            // IDcol
            // 
            this.IDcol.HeaderText = "id";
            this.IDcol.MinimumWidth = 6;
            this.IDcol.Name = "IDcol";
            this.IDcol.ReadOnly = true;
            this.IDcol.Width = 125;
            // 
            // NameCompany
            // 
            this.NameCompany.HeaderText = "Название";
            this.NameCompany.MinimumWidth = 6;
            this.NameCompany.Name = "NameCompany";
            this.NameCompany.ReadOnly = true;
            this.NameCompany.Width = 150;
            // 
            // YearCompany
            // 
            this.YearCompany.HeaderText = "Год основания";
            this.YearCompany.MinimumWidth = 6;
            this.YearCompany.Name = "YearCompany";
            this.YearCompany.ReadOnly = true;
            this.YearCompany.Width = 150;
            // 
            // RatingCompany
            // 
            this.RatingCompany.HeaderText = "Рейтинг компании";
            this.RatingCompany.MinimumWidth = 6;
            this.RatingCompany.Name = "RatingCompany";
            this.RatingCompany.ReadOnly = true;
            this.RatingCompany.Width = 160;
            // 
            // tabButton
            // 
            this.tabButton.Controls.Add(this.company);
            this.tabButton.Controls.Add(this.flight);
            this.tabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabButton.ItemSize = new System.Drawing.Size(71, 21);
            this.tabButton.Location = new System.Drawing.Point(0, 92);
            this.tabButton.Margin = new System.Windows.Forms.Padding(0);
            this.tabButton.Name = "tabButton";
            this.tabButton.SelectedIndex = 0;
            this.tabButton.Size = new System.Drawing.Size(754, 492);
            this.tabButton.TabIndex = 13;
            // 
            // AddDataF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(754, 584);
            this.Controls.Add(this.tabButton);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDataF";
            this.Text = "AirlineBooking";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnbackmenu2)).EndInit();
            this.flight.ResumeLayout(false);
            this.flight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReis)).EndInit();
            this.company.ResumeLayout(false);
            this.company.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompany)).EndInit();
            this.tabButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnbackmenu2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage flight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBoxArrivalTimeF;
        private System.Windows.Forms.TextBox TextBoxDepartureTimeF;
        private System.Windows.Forms.TextBox TextBoxArrivalСityF;
        private System.Windows.Forms.TextBox TextBoxDepartureСityF;
        private System.Windows.Forms.TextBox TextBoxNumF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnDelDbF;
        private System.Windows.Forms.Button BtnLoadDbFly;
        private System.Windows.Forms.Button BtnSaveDbF;
        private System.Windows.Forms.DataGridView dataGridReis;
        private System.Windows.Forms.TabPage company;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnCompanyDel;
        private System.Windows.Forms.Button BtnLoadDbCompany;
        private System.Windows.Forms.Button BtnSaveCompany;
        private System.Windows.Forms.TabControl tabButton;
        private System.Windows.Forms.DataGridView dataGridCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatingCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFlight;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumFlight;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureСity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalСity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
    }
}