namespace G_Otopark
{
    partial class frmSinifYonetim
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
            this.cboxTur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFiyatGuncelle = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSınıfEkle = new System.Windows.Forms.Button();
            this.txtYeniAracAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboxTur2 = new System.Windows.Forms.ComboBox();
            this.btnSınıfSil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label7.Location = new System.Drawing.Point(229, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(322, 39);
            this.label7.TabIndex = 25;
            this.label7.Text = "Sınıf Yönetim Paneli";
            // 
            // cboxTur
            // 
            this.cboxTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxTur.FormattingEnabled = true;
            this.cboxTur.Location = new System.Drawing.Point(117, 47);
            this.cboxTur.Name = "cboxTur";
            this.cboxTur.Size = new System.Drawing.Size(172, 28);
            this.cboxTur.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Araç Sınıfı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Saatlik Ücret:";
            // 
            // btnFiyatGuncelle
            // 
            this.btnFiyatGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFiyatGuncelle.FlatAppearance.BorderSize = 0;
            this.btnFiyatGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiyatGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFiyatGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnFiyatGuncelle.Location = new System.Drawing.Point(180, 92);
            this.btnFiyatGuncelle.Name = "btnFiyatGuncelle";
            this.btnFiyatGuncelle.Size = new System.Drawing.Size(109, 32);
            this.btnFiyatGuncelle.TabIndex = 29;
            this.btnFiyatGuncelle.Text = "Guncelle/Ekle";
            this.btnFiyatGuncelle.UseVisualStyleBackColor = false;
            this.btnFiyatGuncelle.Click += new System.EventHandler(this.btnFiyatGuncelle_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numericUpDown1.Location = new System.Drawing.Point(117, 95);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 26);
            this.numericUpDown1.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxTur);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFiyatGuncelle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(441, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 176);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fiyat Ayarlama";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSınıfEkle);
            this.groupBox2.Controls.Add(this.txtYeniAracAd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(43, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 176);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Sınıfı Ekleme";
            // 
            // btnSınıfEkle
            // 
            this.btnSınıfEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSınıfEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSınıfEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnSınıfEkle.ForeColor = System.Drawing.Color.White;
            this.btnSınıfEkle.Location = new System.Drawing.Point(103, 94);
            this.btnSınıfEkle.Name = "btnSınıfEkle";
            this.btnSınıfEkle.Size = new System.Drawing.Size(172, 32);
            this.btnSınıfEkle.TabIndex = 28;
            this.btnSınıfEkle.Text = "Ekle";
            this.btnSınıfEkle.UseVisualStyleBackColor = false;
            this.btnSınıfEkle.Click += new System.EventHandler(this.btnSınıfEkle_Click);
            // 
            // txtYeniAracAd
            // 
            this.txtYeniAracAd.Location = new System.Drawing.Point(103, 47);
            this.txtYeniAracAd.Name = "txtYeniAracAd";
            this.txtYeniAracAd.Size = new System.Drawing.Size(172, 23);
            this.txtYeniAracAd.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Araç Sınıfı:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboxTur2);
            this.groupBox3.Controls.Add(this.btnSınıfSil);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.Location = new System.Drawing.Point(43, 295);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 176);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Araç Sınıfını Silme";
            // 
            // cboxTur2
            // 
            this.cboxTur2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxTur2.FormattingEnabled = true;
            this.cboxTur2.Location = new System.Drawing.Point(103, 44);
            this.cboxTur2.Name = "cboxTur2";
            this.cboxTur2.Size = new System.Drawing.Size(172, 28);
            this.cboxTur2.TabIndex = 26;
            // 
            // btnSınıfSil
            // 
            this.btnSınıfSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSınıfSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSınıfSil.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnSınıfSil.ForeColor = System.Drawing.Color.White;
            this.btnSınıfSil.Location = new System.Drawing.Point(103, 94);
            this.btnSınıfSil.Name = "btnSınıfSil";
            this.btnSınıfSil.Size = new System.Drawing.Size(172, 32);
            this.btnSınıfSil.TabIndex = 28;
            this.btnSınıfSil.Text = "Sil";
            this.btnSınıfSil.UseVisualStyleBackColor = false;
            this.btnSınıfSil.Click += new System.EventHandler(this.btnSınıfSil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Araç Sınıfı:";
            // 
            // frmSinifYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 516);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSinifYonetim";
            this.Text = "frmFiyatList";
            this.Load += new System.EventHandler(this.frmFiyatList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboxTur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFiyatGuncelle;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSınıfEkle;
        private System.Windows.Forms.TextBox txtYeniAracAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSınıfSil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxTur2;
    }
}