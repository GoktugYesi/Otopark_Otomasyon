namespace G_Otopark
{
    partial class frmAracCıkıs
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
            this.label20 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxTur = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.cboxOtopark = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tnCıkıs = new System.Windows.Forms.Button();
            this.btnFiltre = new System.Windows.Forms.Button();
            this.cıkısTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblUcret = new System.Windows.Forms.Label();
            this.cboxKat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cıkısTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(304, -1);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(171, 39);
            this.label20.TabIndex = 20;
            this.label20.Text = "Arac Çıkış";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(258, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "Araç Türü:";
            // 
            // cboxTur
            // 
            this.cboxTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxTur.FormattingEnabled = true;
            this.cboxTur.Location = new System.Drawing.Point(359, 333);
            this.cboxTur.Name = "cboxTur";
            this.cboxTur.Size = new System.Drawing.Size(176, 32);
            this.cboxTur.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPlaka);
            this.panel1.Location = new System.Drawing.Point(262, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 32);
            this.panel1.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "TR";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlaka.Location = new System.Drawing.Point(43, 0);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(230, 32);
            this.txtPlaka.TabIndex = 1;
            // 
            // cboxOtopark
            // 
            this.cboxOtopark.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxOtopark.FormattingEnabled = true;
            this.cboxOtopark.Location = new System.Drawing.Point(359, 371);
            this.cboxOtopark.Name = "cboxOtopark";
            this.cboxOtopark.Size = new System.Drawing.Size(176, 32);
            this.cboxOtopark.TabIndex = 26;
            this.cboxOtopark.SelectedIndexChanged += new System.EventHandler(this.cboxOtopark_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(274, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "Otopark:";
            // 
            // tnCıkıs
            // 
            this.tnCıkıs.Location = new System.Drawing.Point(451, 447);
            this.tnCıkıs.Name = "tnCıkıs";
            this.tnCıkıs.Size = new System.Drawing.Size(84, 30);
            this.tnCıkıs.TabIndex = 33;
            this.tnCıkıs.Text = "Çıkışı Yap";
            this.tnCıkıs.UseVisualStyleBackColor = true;
            this.tnCıkıs.Click += new System.EventHandler(this.tnCıkıs_Click);
            // 
            // btnFiltre
            // 
            this.btnFiltre.Location = new System.Drawing.Point(359, 447);
            this.btnFiltre.Name = "btnFiltre";
            this.btnFiltre.Size = new System.Drawing.Size(86, 30);
            this.btnFiltre.TabIndex = 33;
            this.btnFiltre.Text = "Filtrele";
            this.btnFiltre.UseVisualStyleBackColor = true;
            this.btnFiltre.Click += new System.EventHandler(this.btnFiltre_Click);
            // 
            // cıkısTBLBindingSource
            // 
            this.cıkısTBLBindingSource.DataMember = "CıkısTBL";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 219);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Location = new System.Drawing.Point(612, 370);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(35, 13);
            this.lblUcret.TabIndex = 35;
            this.lblUcret.Text = "label3";
            // 
            // cboxKat
            // 
            this.cboxKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxKat.FormattingEnabled = true;
            this.cboxKat.Location = new System.Drawing.Point(359, 409);
            this.cboxKat.Name = "cboxKat";
            this.cboxKat.Size = new System.Drawing.Size(176, 32);
            this.cboxKat.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(307, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "Kat:";
            // 
            // frmAracCıkıs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 516);
            this.Controls.Add(this.lblUcret);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFiltre);
            this.Controls.Add(this.tnCıkıs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxKat);
            this.Controls.Add(this.cboxOtopark);
            this.Controls.Add(this.cboxTur);
            this.Controls.Add(this.label20);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAracCıkıs";
            this.Text = "frmAracCıkıs";
            this.Load += new System.EventHandler(this.frmAracCıkıs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cıkısTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxTur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.ComboBox cboxOtopark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tnCıkıs;
        private System.Windows.Forms.Button btnFiltre;
    //    private OtoParkDbDataSet otoParkDbDataSet;
        private System.Windows.Forms.BindingSource cıkısTBLBindingSource;
  //      private OtoParkDbDataSetTableAdapters.CıkısTBLTableAdapter cıkısTBLTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.ComboBox cboxKat;
        private System.Windows.Forms.Label label3;
    }
}