namespace TheAviationCompanyProgram
{
    partial class Menu2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu2));
            this.BtnOrderTickets = new System.Windows.Forms.Button();
            this.ChoiceToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.AddDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnbackmenu2 = new System.Windows.Forms.PictureBox();
            this.ChoiceToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnbackmenu2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOrderTickets
            // 
            this.BtnOrderTickets.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnOrderTickets.Location = new System.Drawing.Point(225, 312);
            this.BtnOrderTickets.Name = "BtnOrderTickets";
            this.BtnOrderTickets.Size = new System.Drawing.Size(170, 61);
            this.BtnOrderTickets.TabIndex = 3;
            this.BtnOrderTickets.Text = "Заказ билетов";
            this.BtnOrderTickets.UseVisualStyleBackColor = true;
            this.BtnOrderTickets.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChoiceToolStrip
            // 
            this.ChoiceToolStrip.AutoSize = false;
            this.ChoiceToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.ChoiceToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.ChoiceToolStrip.Location = new System.Drawing.Point(27, 312);
            this.ChoiceToolStrip.Name = "ChoiceToolStrip";
            this.ChoiceToolStrip.Size = new System.Drawing.Size(107, 61);
            this.ChoiceToolStrip.TabIndex = 4;
            this.ChoiceToolStrip.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddDataToolStripMenuItem,
            this.просмотретьДанныеToolStripMenuItem});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(76, 58);
            this.toolStripDropDownButton1.Text = "Аэропорт";
            // 
            // AddDataToolStripMenuItem
            // 
            this.AddDataToolStripMenuItem.Name = "AddDataToolStripMenuItem";
            this.AddDataToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.AddDataToolStripMenuItem.Text = "Добавить данные";
            this.AddDataToolStripMenuItem.Click += new System.EventHandler(this.добавитьДанныеToolStripMenuItem_Click);
            // 
            // просмотретьДанныеToolStripMenuItem
            // 
            this.просмотретьДанныеToolStripMenuItem.Name = "просмотретьДанныеToolStripMenuItem";
            this.просмотретьДанныеToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.просмотретьДанныеToolStripMenuItem.Text = "Просмотреть данные";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(226, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 110);
            this.label2.TabIndex = 6;
            this.label2.Text = "Тут вы можете выбрать \r\nпосмотерть данные\r\nв таблице или их отредактиролвать \r\nДо" +
    "бавить/Удалить.\r\nТакже заказать билет.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TheAviationCompanyProgram.Properties.Resources.airlane;
            this.pictureBox1.Location = new System.Drawing.Point(12, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Меню";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.btnbackmenu2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 92);
            this.panel1.TabIndex = 9;
            // 
            // btnbackmenu2
            // 
            this.btnbackmenu2.Image = global::TheAviationCompanyProgram.Properties.Resources.back;
            this.btnbackmenu2.Location = new System.Drawing.Point(0, 0);
            this.btnbackmenu2.Name = "btnbackmenu2";
            this.btnbackmenu2.Size = new System.Drawing.Size(42, 41);
            this.btnbackmenu2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnbackmenu2.TabIndex = 9;
            this.btnbackmenu2.TabStop = false;
            this.btnbackmenu2.Click += new System.EventHandler(this.btnbackmenu2_Click);
            // 
            // Menu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 401);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChoiceToolStrip);
            this.Controls.Add(this.BtnOrderTickets);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu2";
            this.Text = "AirlaneBooking";
            this.ChoiceToolStrip.ResumeLayout(false);
            this.ChoiceToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnbackmenu2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnOrderTickets;
        private System.Windows.Forms.ToolStrip ChoiceToolStrip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem AddDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьДанныеToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnbackmenu2;
    }
}