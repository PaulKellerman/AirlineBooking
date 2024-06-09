namespace TheAviationCompanyProgram
{
    partial class ShoowData
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnbackmenu2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridFlight = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridCompany = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSaveShow = new System.Windows.Forms.Button();
            this.TextBoxCompany2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxFlight2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnbackmenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCompany)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(722, 92);
            this.panel1.TabIndex = 12;
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
            this.label2.Location = new System.Drawing.Point(259, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Просмотр данных";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataGridFlight
            // 
            this.DataGridFlight.AllowUserToAddRows = false;
            this.DataGridFlight.AllowUserToDeleteRows = false;
            this.DataGridFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridFlight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.DataGridFlight.Location = new System.Drawing.Point(311, 114);
            this.DataGridFlight.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridFlight.Name = "DataGridFlight";
            this.DataGridFlight.ReadOnly = true;
            this.DataGridFlight.RowHeadersWidth = 51;
            this.DataGridFlight.RowTemplate.Height = 24;
            this.DataGridFlight.Size = new System.Drawing.Size(190, 408);
            this.DataGridFlight.TabIndex = 14;
            this.DataGridFlight.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridFlight_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Column2";
            this.Column2.HeaderText = "Рейсы";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 137;
            // 
            // DataGridCompany
            // 
            this.DataGridCompany.AllowUserToAddRows = false;
            this.DataGridCompany.AllowUserToDeleteRows = false;
            this.DataGridCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.DataGridCompany.Location = new System.Drawing.Point(38, 114);
            this.DataGridCompany.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridCompany.Name = "DataGridCompany";
            this.DataGridCompany.ReadOnly = true;
            this.DataGridCompany.RowHeadersWidth = 51;
            this.DataGridCompany.RowTemplate.Height = 24;
            this.DataGridCompany.Size = new System.Drawing.Size(190, 408);
            this.DataGridCompany.TabIndex = 13;
            this.DataGridCompany.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCompany_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Column1";
            this.Column1.HeaderText = "Авиакомпании";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 137;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(64, 551);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Авиакомпании";
            // 
            // BtnSaveShow
            // 
            this.BtnSaveShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSaveShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.BtnSaveShow.Location = new System.Drawing.Point(403, 572);
            this.BtnSaveShow.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSaveShow.Name = "BtnSaveShow";
            this.BtnSaveShow.Size = new System.Drawing.Size(119, 40);
            this.BtnSaveShow.TabIndex = 19;
            this.BtnSaveShow.Text = "Сохранить";
            this.BtnSaveShow.UseVisualStyleBackColor = true;
            this.BtnSaveShow.Click += new System.EventHandler(this.BtnSaveShow_Click);
            // 
            // TextBoxCompany2
            // 
            this.TextBoxCompany2.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxCompany2.Location = new System.Drawing.Point(207, 540);
            this.TextBoxCompany2.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxCompany2.Multiline = true;
            this.TextBoxCompany2.Name = "TextBoxCompany2";
            this.TextBoxCompany2.ReadOnly = true;
            this.TextBoxCompany2.Size = new System.Drawing.Size(159, 35);
            this.TextBoxCompany2.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(64, 610);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "№ Рейса";
            // 
            // TextBoxFlight2
            // 
            this.TextBoxFlight2.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.TextBoxFlight2.Location = new System.Drawing.Point(207, 610);
            this.TextBoxFlight2.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxFlight2.Multiline = true;
            this.TextBoxFlight2.Name = "TextBoxFlight2";
            this.TextBoxFlight2.ReadOnly = true;
            this.TextBoxFlight2.Size = new System.Drawing.Size(159, 35);
            this.TextBoxFlight2.TabIndex = 20;
            // 
            // ShoowData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(722, 656);
            this.Controls.Add(this.TextBoxFlight2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSaveShow);
            this.Controls.Add(this.TextBoxCompany2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataGridFlight);
            this.Controls.Add(this.DataGridCompany);
            this.Controls.Add(this.panel1);
            this.Name = "ShoowData";
            this.Text = "ShowData";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnbackmenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCompany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnbackmenu2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DataGridFlight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView DataGridCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSaveShow;
        private System.Windows.Forms.TextBox TextBoxCompany2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxFlight2;
    }
}