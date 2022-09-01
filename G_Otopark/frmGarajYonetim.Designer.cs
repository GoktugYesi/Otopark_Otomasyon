namespace G_Otopark
{
    partial class frmGarajYonetim
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
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboxOtopark = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nm1 = new System.Windows.Forms.NumericUpDown();
            this.cboxKat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSınıfEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOtoparkAd = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.cboxOtoparkSil = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(270, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 39);
            this.label7.TabIndex = 25;
            this.label7.Text = "Garaj Yönetim";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 65);
            this.panel1.TabIndex = 26;
            // 
            // cboxOtopark
            // 
            this.cboxOtopark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxOtopark.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboxOtopark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboxOtopark.FormattingEnabled = true;
            this.cboxOtopark.Location = new System.Drawing.Point(127, 62);
            this.cboxOtopark.Name = "cboxOtopark";
            this.cboxOtopark.Size = new System.Drawing.Size(121, 28);
            this.cboxOtopark.TabIndex = 27;
            this.cboxOtopark.SelectedIndexChanged += new System.EventHandler(this.cboxOtopark_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(51, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Otopark:";
            // 
            // nm1
            // 
            this.nm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nm1.Location = new System.Drawing.Point(254, 96);
            this.nm1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nm1.Name = "nm1";
            this.nm1.Size = new System.Drawing.Size(48, 26);
            this.nm1.TabIndex = 29;
            this.nm1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.numericUpDown1_MouseDown);
            // 
            // cboxKat
            // 
            this.cboxKat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboxKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboxKat.FormattingEnabled = true;
            this.cboxKat.Location = new System.Drawing.Point(127, 96);
            this.cboxKat.Name = "cboxKat";
            this.cboxKat.Size = new System.Drawing.Size(121, 28);
            this.cboxKat.TabIndex = 27;
            this.cboxKat.SelectedIndexChanged += new System.EventHandler(this.cboxKat_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(84, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Kat:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(202, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 32;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(88, 179);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(214, 32);
            this.button4.TabIndex = 32;
            this.button4.Text = "Sil";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSınıfEkle
            // 
            this.btnSınıfEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSınıfEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSınıfEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnSınıfEkle.ForeColor = System.Drawing.Color.White;
            this.btnSınıfEkle.Location = new System.Drawing.Point(88, 141);
            this.btnSınıfEkle.Name = "btnSınıfEkle";
            this.btnSınıfEkle.Size = new System.Drawing.Size(108, 32);
            this.btnSınıfEkle.TabIndex = 32;
            this.btnSınıfEkle.Text = "Ekle";
            this.btnSınıfEkle.UseVisualStyleBackColor = false;
            this.btnSınıfEkle.Click += new System.EventHandler(this.btnSınıfEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboxOtopark);
            this.groupBox1.Controls.Add(this.btnSınıfEkle);
            this.groupBox1.Controls.Add(this.nm1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboxKat);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(409, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 265);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kat Ekle | Sil | Güncelle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtOtoparkAd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(12, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 124);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Otopark Ekle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(26, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Otopark Adı:";
            // 
            // txtOtoparkAd
            // 
            this.txtOtoparkAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtOtoparkAd.Location = new System.Drawing.Point(129, 37);
            this.txtOtoparkAd.Name = "txtOtoparkAd";
            this.txtOtoparkAd.Size = new System.Drawing.Size(161, 26);
            this.txtOtoparkAd.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(129, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 32);
            this.button2.TabIndex = 33;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cboxOtoparkSil);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.Location = new System.Drawing.Point(12, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 124);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yeni Otopark Ekle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(26, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Otopark Adı:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(129, 69);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 32);
            this.button5.TabIndex = 33;
            this.button5.Text = "Sil";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cboxOtoparkSil
            // 
            this.cboxOtoparkSil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxOtoparkSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboxOtoparkSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboxOtoparkSil.FormattingEnabled = true;
            this.cboxOtoparkSil.Location = new System.Drawing.Point(129, 35);
            this.cboxOtoparkSil.Name = "cboxOtoparkSil";
            this.cboxOtoparkSil.Size = new System.Drawing.Size(161, 28);
            this.cboxOtoparkSil.TabIndex = 27;
            this.cboxOtoparkSil.SelectedIndexChanged += new System.EventHandler(this.cboxOtopark_SelectedIndexChanged);
            // 
            // frmGarajYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 516);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGarajYonetim";
            this.Text = "frmGarajlar";
            this.Load += new System.EventHandler(this.frmGarajlar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboxOtopark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nm1;
        private System.Windows.Forms.ComboBox cboxKat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSınıfEkle;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtOtoparkAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxOtoparkSil;
    }
}