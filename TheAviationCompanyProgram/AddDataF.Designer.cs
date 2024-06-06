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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnbackmenu2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnbackmenu2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.btnbackmenu2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 92);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Добавление данных";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // AddDataF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(789, 486);
            this.Controls.Add(this.panel1);
            this.Name = "AddDataF";
            this.Text = "AddDataF";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnbackmenu2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnbackmenu2;
    }
}