namespace G_Otopark
{
    partial class frmAnaliz
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
            this.dateTimeBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBitis = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalAracGC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalPara = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TimeBitis = new System.Windows.Forms.DateTimePicker();
            this.TimeBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeBaslangic
            // 
            this.dateTimeBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeBaslangic.Location = new System.Drawing.Point(230, 82);
            this.dateTimeBaslangic.Name = "dateTimeBaslangic";
            this.dateTimeBaslangic.Size = new System.Drawing.Size(146, 20);
            this.dateTimeBaslangic.TabIndex = 0;
            this.dateTimeBaslangic.Value = new System.DateTime(2022, 8, 15, 0, 0, 0, 0);
            // 
            // dateTimeBitis
            // 
            this.dateTimeBitis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeBitis.Location = new System.Drawing.Point(230, 108);
            this.dateTimeBitis.Name = "dateTimeBitis";
            this.dateTimeBitis.Size = new System.Drawing.Size(146, 20);
            this.dateTimeBitis.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.lblTotalAracGC);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTotalPara);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(113, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 224);
            this.panel1.TabIndex = 2;
            // 
            // lblTotalAracGC
            // 
            this.lblTotalAracGC.AutoSize = true;
            this.lblTotalAracGC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotalAracGC.ForeColor = System.Drawing.Color.White;
            this.lblTotalAracGC.Location = new System.Drawing.Point(377, 113);
            this.lblTotalAracGC.Name = "lblTotalAracGC";
            this.lblTotalAracGC.Size = new System.Drawing.Size(0, 25);
            this.lblTotalAracGC.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Toplam Giriş Çıkış Yapan Araç: ";
            // 
            // lblTotalPara
            // 
            this.lblTotalPara.AutoSize = true;
            this.lblTotalPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotalPara.ForeColor = System.Drawing.Color.White;
            this.lblTotalPara.Location = new System.Drawing.Point(331, 67);
            this.lblTotalPara.Name = "lblTotalPara";
            this.lblTotalPara.Size = new System.Drawing.Size(0, 25);
            this.lblTotalPara.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Toplam Kazanılan Para: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Location = new System.Drawing.Point(113, 373);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 5);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Location = new System.Drawing.Point(109, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(553, 5);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Location = new System.Drawing.Point(109, 149);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 229);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.Location = new System.Drawing.Point(657, 149);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 229);
            this.panel5.TabIndex = 3;
            // 
            // TimeBitis
            // 
            this.TimeBitis.Cursor = System.Windows.Forms.Cursors.No;
            this.TimeBitis.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeBitis.Location = new System.Drawing.Point(382, 108);
            this.TimeBitis.Name = "TimeBitis";
            this.TimeBitis.Size = new System.Drawing.Size(99, 20);
            this.TimeBitis.TabIndex = 0;
            this.TimeBitis.Value = new System.DateTime(2022, 8, 1, 23, 59, 59, 0);
            // 
            // TimeBaslangic
            // 
            this.TimeBaslangic.Cursor = System.Windows.Forms.Cursors.No;
            this.TimeBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeBaslangic.Location = new System.Drawing.Point(382, 82);
            this.TimeBaslangic.Name = "TimeBaslangic";
            this.TimeBaslangic.Size = new System.Drawing.Size(99, 20);
            this.TimeBaslangic.TabIndex = 0;
            this.TimeBaslangic.Value = new System.DateTime(2022, 8, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Başlangıç Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bitiş Tarihi:";
            // 
            // frmAnaliz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 602);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimeBitis);
            this.Controls.Add(this.TimeBaslangic);
            this.Controls.Add(this.TimeBitis);
            this.Controls.Add(this.dateTimeBaslangic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnaliz";
            this.Text = "frmAnaliz";
            this.Load += new System.EventHandler(this.frmAnaliz_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeBaslangic;
        private System.Windows.Forms.DateTimePicker dateTimeBitis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalAracGC;
        private System.Windows.Forms.Label lblTotalPara;
        private System.Windows.Forms.DateTimePicker TimeBitis;
        private System.Windows.Forms.DateTimePicker TimeBaslangic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}