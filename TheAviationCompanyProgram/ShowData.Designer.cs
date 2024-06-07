namespace TheAviationCompanyProgram
{
    partial class ShowData
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
            this.dataGridReis = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridCompani = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxCompani2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnbackmenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompani)).BeginInit();
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
            // dataGridReis
            // 
            this.dataGridReis.AllowUserToAddRows = false;
            this.dataGridReis.AllowUserToDeleteRows = false;
            this.dataGridReis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.dataGridReis.Location = new System.Drawing.Point(311, 114);
            this.dataGridReis.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridReis.Name = "dataGridReis";
            this.dataGridReis.ReadOnly = true;
            this.dataGridReis.RowHeadersWidth = 51;
            this.dataGridReis.RowTemplate.Height = 24;
            this.dataGridReis.Size = new System.Drawing.Size(190, 408);
            this.dataGridReis.TabIndex = 14;
            this.dataGridReis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReis_CellContentClick);
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
            // dataGridCompani
            // 
            this.dataGridCompani.AllowUserToAddRows = false;
            this.dataGridCompani.AllowUserToDeleteRows = false;
            this.dataGridCompani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCompani.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridCompani.Location = new System.Drawing.Point(38, 114);
            this.dataGridCompani.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridCompani.Name = "dataGridCompani";
            this.dataGridCompani.ReadOnly = true;
            this.dataGridCompani.RowHeadersWidth = 51;
            this.dataGridCompani.RowTemplate.Height = 24;
            this.dataGridCompani.Size = new System.Drawing.Size(190, 408);
            this.dataGridCompani.TabIndex = 13;
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.buttonSave.Location = new System.Drawing.Point(403, 572);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(119, 40);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // textBoxCompani2
            // 
            this.textBoxCompani2.Location = new System.Drawing.Point(207, 540);
            this.textBoxCompani2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCompani2.Multiline = true;
            this.textBoxCompani2.Name = "textBoxCompani2";
            this.textBoxCompani2.ReadOnly = true;
            this.textBoxCompani2.Size = new System.Drawing.Size(159, 35);
            this.textBoxCompani2.TabIndex = 15;
            this.textBoxCompani2.TextChanged += new System.EventHandler(this.textBoxCompani2_TextChanged);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 610);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(159, 35);
            this.textBox1.TabIndex = 20;
            // 
            // ShowData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(722, 656);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxCompani2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridReis);
            this.Controls.Add(this.dataGridCompani);
            this.Controls.Add(this.panel1);
            this.Name = "ShowData";
            this.Text = "ShowData";
            this.Load += new System.EventHandler(this.ShowData_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnbackmenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompani)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnbackmenu2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridReis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView dataGridCompani;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxCompani2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}