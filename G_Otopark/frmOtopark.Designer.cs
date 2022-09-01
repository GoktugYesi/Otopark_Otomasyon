namespace G_Otopark
{
    partial class frmOtopark
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
            this.btnAracGiris = new System.Windows.Forms.Button();
            this.btnAracCıkıs = new System.Windows.Forms.Button();
            this.btnGarajYonetim = new System.Windows.Forms.Button();
            this.btnGarajlar = new System.Windows.Forms.Button();
            this.btnFiyat = new System.Windows.Forms.Button();
            this.btnAnaliz = new System.Windows.Forms.Button();
            this.pnlAna = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnGecmis = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAna.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAracGiris
            // 
            this.btnAracGiris.FlatAppearance.BorderSize = 0;
            this.btnAracGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAracGiris.Location = new System.Drawing.Point(3, 3);
            this.btnAracGiris.Name = "btnAracGiris";
            this.btnAracGiris.Size = new System.Drawing.Size(195, 80);
            this.btnAracGiris.TabIndex = 0;
            this.btnAracGiris.Text = "Araç Girişi";
            this.btnAracGiris.UseVisualStyleBackColor = true;
            this.btnAracGiris.Click += new System.EventHandler(this.btnAracGiris_Click);
            // 
            // btnAracCıkıs
            // 
            this.btnAracCıkıs.FlatAppearance.BorderSize = 0;
            this.btnAracCıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAracCıkıs.Location = new System.Drawing.Point(3, 86);
            this.btnAracCıkıs.Name = "btnAracCıkıs";
            this.btnAracCıkıs.Size = new System.Drawing.Size(195, 80);
            this.btnAracCıkıs.TabIndex = 0;
            this.btnAracCıkıs.Text = "Araç Çıkışı";
            this.btnAracCıkıs.UseVisualStyleBackColor = true;
            this.btnAracCıkıs.Click += new System.EventHandler(this.btnAracCıkıs_Click);
            // 
            // btnGarajYonetim
            // 
            this.btnGarajYonetim.FlatAppearance.BorderSize = 0;
            this.btnGarajYonetim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGarajYonetim.Location = new System.Drawing.Point(3, 170);
            this.btnGarajYonetim.Name = "btnGarajYonetim";
            this.btnGarajYonetim.Size = new System.Drawing.Size(195, 80);
            this.btnGarajYonetim.TabIndex = 0;
            this.btnGarajYonetim.Text = "Garajlar Yönetimi";
            this.btnGarajYonetim.UseVisualStyleBackColor = true;
            this.btnGarajYonetim.Click += new System.EventHandler(this.btnGarajlar_Click);
            // 
            // btnGarajlar
            // 
            this.btnGarajlar.FlatAppearance.BorderSize = 0;
            this.btnGarajlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGarajlar.Location = new System.Drawing.Point(3, 254);
            this.btnGarajlar.Name = "btnGarajlar";
            this.btnGarajlar.Size = new System.Drawing.Size(195, 80);
            this.btnGarajlar.TabIndex = 0;
            this.btnGarajlar.Text = "Garajlar";
            this.btnGarajlar.UseVisualStyleBackColor = true;
            this.btnGarajlar.Click += new System.EventHandler(this.btnGarajEkle_Click);
            // 
            // btnFiyat
            // 
            this.btnFiyat.FlatAppearance.BorderSize = 0;
            this.btnFiyat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiyat.Location = new System.Drawing.Point(3, 422);
            this.btnFiyat.Name = "btnFiyat";
            this.btnFiyat.Size = new System.Drawing.Size(195, 80);
            this.btnFiyat.TabIndex = 0;
            this.btnFiyat.Text = "Araç Sınıf Yönetim";
            this.btnFiyat.UseVisualStyleBackColor = true;
            this.btnFiyat.Click += new System.EventHandler(this.btnFiyat_Click);
            // 
            // btnAnaliz
            // 
            this.btnAnaliz.FlatAppearance.BorderSize = 0;
            this.btnAnaliz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaliz.Location = new System.Drawing.Point(3, 506);
            this.btnAnaliz.Name = "btnAnaliz";
            this.btnAnaliz.Size = new System.Drawing.Size(195, 80);
            this.btnAnaliz.TabIndex = 0;
            this.btnAnaliz.Text = "Analiz";
            this.btnAnaliz.UseVisualStyleBackColor = true;
            this.btnAnaliz.Click += new System.EventHandler(this.btnAnaliz_Click);
            // 
            // pnlAna
            // 
            this.pnlAna.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAna.Controls.Add(this.label4);
            this.pnlAna.Controls.Add(this.label3);
            this.pnlAna.Controls.Add(this.label2);
            this.pnlAna.Controls.Add(this.label1);
            this.pnlAna.Location = new System.Drawing.Point(198, 0);
            this.pnlAna.Name = "pnlAna";
            this.pnlAna.Size = new System.Drawing.Size(799, 593);
            this.pnlAna.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F);
            this.label4.Location = new System.Drawing.Point(292, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Goktug Yesil Hoşgeldiniz";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 45.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(351, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 68);
            this.label3.TabIndex = 1;
            this.label3.Text = "GY";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(245, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Garaj Takip Sistemi";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 25F);
            this.label1.Location = new System.Drawing.Point(308, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "11:18:00 PM";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnGecmis
            // 
            this.btnGecmis.FlatAppearance.BorderSize = 0;
            this.btnGecmis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGecmis.Location = new System.Drawing.Point(3, 338);
            this.btnGecmis.Name = "btnGecmis";
            this.btnGecmis.Size = new System.Drawing.Size(195, 80);
            this.btnGecmis.TabIndex = 0;
            this.btnGecmis.Text = "Araç Geçmişi";
            this.btnGecmis.UseVisualStyleBackColor = true;
            this.btnGecmis.Click += new System.EventHandler(this.btnGecmis_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAracGiris);
            this.panel1.Controls.Add(this.btnAnaliz);
            this.panel1.Controls.Add(this.btnAracCıkıs);
            this.panel1.Controls.Add(this.btnGarajYonetim);
            this.panel1.Controls.Add(this.btnFiyat);
            this.panel1.Controls.Add(this.btnGecmis);
            this.panel1.Controls.Add(this.btnGarajlar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 593);
            this.panel1.TabIndex = 2;
            // 
            // frmOtopark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 593);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAna);
            this.Name = "frmOtopark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOtopark";
            this.Load += new System.EventHandler(this.frmOtopark_Load);
            this.pnlAna.ResumeLayout(false);
            this.pnlAna.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAracGiris;
        private System.Windows.Forms.Button btnAracCıkıs;
        private System.Windows.Forms.Button btnGarajYonetim;
        private System.Windows.Forms.Button btnFiyat;
        private System.Windows.Forms.Button btnGarajlar;
        private System.Windows.Forms.Panel pnlAna;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAnaliz;
        private System.Windows.Forms.Button btnGecmis;
        private System.Windows.Forms.Panel panel1;
    }
}