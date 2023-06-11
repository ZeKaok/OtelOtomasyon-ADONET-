namespace OtelOtomasyon
{
    partial class Form1
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
            this.dgvliste = new System.Windows.Forms.DataGridView();
            this.comboboxsec = new System.Windows.Forms.ComboBox();
            this.btnlistele = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.textBoxad = new System.Windows.Forms.TextBox();
            this.lblad = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.textBoxsoyad = new System.Windows.Forms.TextBox();
            this.lblSehir = new System.Windows.Forms.Label();
            this.textBoxsehir = new System.Windows.Forms.TextBox();
            this.lblUlke = new System.Windows.Forms.Label();
            this.textBoxulke = new System.Windows.Forms.TextBox();
            this.lblPostaKod = new System.Windows.Forms.Label();
            this.textBoxPostaKod = new System.Windows.Forms.TextBox();
            this.lblUnvan = new System.Windows.Forms.Label();
            this.textBoxUnvan = new System.Windows.Forms.TextBox();
            this.lblTcNo = new System.Windows.Forms.Label();
            this.textBoxTcNo = new System.Windows.Forms.TextBox();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.textBoxTelNo = new System.Windows.Forms.TextBox();
            this.lblBirimFiyat = new System.Windows.Forms.Label();
            this.textBoxBirimFiyat = new System.Windows.Forms.TextBox();
            this.lblara = new System.Windows.Forms.Label();
            this.textBoxara = new System.Windows.Forms.TextBox();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.groupBoxGirdiler = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvliste)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxGirdiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvliste
            // 
            this.dgvliste.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvliste.Location = new System.Drawing.Point(69, 62);
            this.dgvliste.Name = "dgvliste";
            this.dgvliste.RowHeadersWidth = 51;
            this.dgvliste.RowTemplate.Height = 24;
            this.dgvliste.Size = new System.Drawing.Size(892, 174);
            this.dgvliste.TabIndex = 0;
            this.dgvliste.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvliste_CellClick);
            this.dgvliste.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvliste_CellContentClick);
            this.dgvliste.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgvliste_CellStateChanged);
            // 
            // comboboxsec
            // 
            this.comboboxsec.FormattingEnabled = true;
            this.comboboxsec.Items.AddRange(new object[] {
            "Kategoriler",
            "Musteriler",
            "Odalar",
            "Personeller",
            "Satislar",
            "Tedarikciler"});
            this.comboboxsec.Location = new System.Drawing.Point(6, 33);
            this.comboboxsec.Name = "comboboxsec";
            this.comboboxsec.Size = new System.Drawing.Size(258, 24);
            this.comboboxsec.TabIndex = 1;
            this.comboboxsec.SelectedIndexChanged += new System.EventHandler(this.comboboxsec_SelectedIndexChanged);
            // 
            // btnlistele
            // 
            this.btnlistele.BackColor = System.Drawing.Color.SeaShell;
            this.btnlistele.Location = new System.Drawing.Point(305, 33);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(86, 24);
            this.btnlistele.TabIndex = 2;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = false;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.SeaShell;
            this.btnsil.Location = new System.Drawing.Point(425, 32);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(86, 24);
            this.btnsil.TabIndex = 3;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // textBoxad
            // 
            this.textBoxad.Location = new System.Drawing.Point(90, 32);
            this.textBoxad.Name = "textBoxad";
            this.textBoxad.Size = new System.Drawing.Size(155, 22);
            this.textBoxad.TabIndex = 4;
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(28, 38);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(24, 16);
            this.lblad.TabIndex = 5;
            this.lblad.Text = "Ad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(28, 89);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(47, 16);
            this.lblSoyad.TabIndex = 7;
            this.lblSoyad.Text = "Soyad";
            // 
            // textBoxsoyad
            // 
            this.textBoxsoyad.Location = new System.Drawing.Point(90, 83);
            this.textBoxsoyad.Name = "textBoxsoyad";
            this.textBoxsoyad.Size = new System.Drawing.Size(155, 22);
            this.textBoxsoyad.TabIndex = 6;
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Location = new System.Drawing.Point(28, 142);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(38, 16);
            this.lblSehir.TabIndex = 9;
            this.lblSehir.Text = "Şehir";
            // 
            // textBoxsehir
            // 
            this.textBoxsehir.Location = new System.Drawing.Point(90, 136);
            this.textBoxsehir.Name = "textBoxsehir";
            this.textBoxsehir.Size = new System.Drawing.Size(155, 22);
            this.textBoxsehir.TabIndex = 8;
            // 
            // lblUlke
            // 
            this.lblUlke.AutoSize = true;
            this.lblUlke.Location = new System.Drawing.Point(322, 145);
            this.lblUlke.Name = "lblUlke";
            this.lblUlke.Size = new System.Drawing.Size(35, 16);
            this.lblUlke.TabIndex = 11;
            this.lblUlke.Text = "Ülke";
            // 
            // textBoxulke
            // 
            this.textBoxulke.Location = new System.Drawing.Point(393, 139);
            this.textBoxulke.Name = "textBoxulke";
            this.textBoxulke.Size = new System.Drawing.Size(155, 22);
            this.textBoxulke.TabIndex = 10;
            // 
            // lblPostaKod
            // 
            this.lblPostaKod.AutoSize = true;
            this.lblPostaKod.Location = new System.Drawing.Point(322, 89);
            this.lblPostaKod.Name = "lblPostaKod";
            this.lblPostaKod.Size = new System.Drawing.Size(69, 16);
            this.lblPostaKod.TabIndex = 13;
            this.lblPostaKod.Text = "Posta Kod";
            // 
            // textBoxPostaKod
            // 
            this.textBoxPostaKod.Location = new System.Drawing.Point(393, 83);
            this.textBoxPostaKod.Name = "textBoxPostaKod";
            this.textBoxPostaKod.Size = new System.Drawing.Size(155, 22);
            this.textBoxPostaKod.TabIndex = 12;
            // 
            // lblUnvan
            // 
            this.lblUnvan.AutoSize = true;
            this.lblUnvan.Location = new System.Drawing.Point(322, 41);
            this.lblUnvan.Name = "lblUnvan";
            this.lblUnvan.Size = new System.Drawing.Size(46, 16);
            this.lblUnvan.TabIndex = 15;
            this.lblUnvan.Text = "Ünvan";
            // 
            // textBoxUnvan
            // 
            this.textBoxUnvan.Location = new System.Drawing.Point(393, 35);
            this.textBoxUnvan.Name = "textBoxUnvan";
            this.textBoxUnvan.Size = new System.Drawing.Size(155, 22);
            this.textBoxUnvan.TabIndex = 14;
            // 
            // lblTcNo
            // 
            this.lblTcNo.AutoSize = true;
            this.lblTcNo.Location = new System.Drawing.Point(638, 38);
            this.lblTcNo.Name = "lblTcNo";
            this.lblTcNo.Size = new System.Drawing.Size(44, 16);
            this.lblTcNo.TabIndex = 17;
            this.lblTcNo.Text = "Tc No";
            // 
            // textBoxTcNo
            // 
            this.textBoxTcNo.Location = new System.Drawing.Point(700, 32);
            this.textBoxTcNo.Name = "textBoxTcNo";
            this.textBoxTcNo.Size = new System.Drawing.Size(155, 22);
            this.textBoxTcNo.TabIndex = 16;
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(638, 89);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(48, 16);
            this.lblTelNo.TabIndex = 19;
            this.lblTelNo.Text = "Tel No";
            // 
            // textBoxTelNo
            // 
            this.textBoxTelNo.Location = new System.Drawing.Point(700, 83);
            this.textBoxTelNo.Name = "textBoxTelNo";
            this.textBoxTelNo.Size = new System.Drawing.Size(155, 22);
            this.textBoxTelNo.TabIndex = 18;
            // 
            // lblBirimFiyat
            // 
            this.lblBirimFiyat.AutoSize = true;
            this.lblBirimFiyat.Location = new System.Drawing.Point(638, 145);
            this.lblBirimFiyat.Name = "lblBirimFiyat";
            this.lblBirimFiyat.Size = new System.Drawing.Size(66, 16);
            this.lblBirimFiyat.TabIndex = 21;
            this.lblBirimFiyat.Text = "BirimFiyat";
            // 
            // textBoxBirimFiyat
            // 
            this.textBoxBirimFiyat.Location = new System.Drawing.Point(700, 139);
            this.textBoxBirimFiyat.Name = "textBoxBirimFiyat";
            this.textBoxBirimFiyat.Size = new System.Drawing.Size(155, 22);
            this.textBoxBirimFiyat.TabIndex = 20;
            // 
            // lblara
            // 
            this.lblara.AutoSize = true;
            this.lblara.Location = new System.Drawing.Point(754, 29);
            this.lblara.Name = "lblara";
            this.lblara.Size = new System.Drawing.Size(28, 16);
            this.lblara.TabIndex = 23;
            this.lblara.Text = "Ara";
            // 
            // textBoxara
            // 
            this.textBoxara.Location = new System.Drawing.Point(806, 23);
            this.textBoxara.Name = "textBoxara";
            this.textBoxara.Size = new System.Drawing.Size(155, 22);
            this.textBoxara.TabIndex = 22;
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.SeaShell;
            this.btnguncelle.Location = new System.Drawing.Point(543, 32);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(86, 24);
            this.btnguncelle.TabIndex = 24;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnekle);
            this.groupBox1.Controls.Add(this.comboboxsec);
            this.groupBox1.Controls.Add(this.btnguncelle);
            this.groupBox1.Controls.Add(this.btnlistele);
            this.groupBox1.Controls.Add(this.btnsil);
            this.groupBox1.Location = new System.Drawing.Point(69, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 100);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçimler";
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.SeaShell;
            this.btnekle.Location = new System.Drawing.Point(665, 32);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(86, 24);
            this.btnekle.TabIndex = 25;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // groupBoxGirdiler
            // 
            this.groupBoxGirdiler.Controls.Add(this.textBoxad);
            this.groupBoxGirdiler.Controls.Add(this.lblad);
            this.groupBoxGirdiler.Controls.Add(this.textBoxsoyad);
            this.groupBoxGirdiler.Controls.Add(this.lblSoyad);
            this.groupBoxGirdiler.Controls.Add(this.lblBirimFiyat);
            this.groupBoxGirdiler.Controls.Add(this.textBoxsehir);
            this.groupBoxGirdiler.Controls.Add(this.textBoxBirimFiyat);
            this.groupBoxGirdiler.Controls.Add(this.lblSehir);
            this.groupBoxGirdiler.Controls.Add(this.lblTelNo);
            this.groupBoxGirdiler.Controls.Add(this.textBoxulke);
            this.groupBoxGirdiler.Controls.Add(this.textBoxTelNo);
            this.groupBoxGirdiler.Controls.Add(this.lblUlke);
            this.groupBoxGirdiler.Controls.Add(this.lblTcNo);
            this.groupBoxGirdiler.Controls.Add(this.textBoxPostaKod);
            this.groupBoxGirdiler.Controls.Add(this.textBoxTcNo);
            this.groupBoxGirdiler.Controls.Add(this.lblPostaKod);
            this.groupBoxGirdiler.Controls.Add(this.lblUnvan);
            this.groupBoxGirdiler.Controls.Add(this.textBoxUnvan);
            this.groupBoxGirdiler.Location = new System.Drawing.Point(69, 348);
            this.groupBoxGirdiler.Name = "groupBoxGirdiler";
            this.groupBoxGirdiler.Size = new System.Drawing.Size(874, 187);
            this.groupBoxGirdiler.TabIndex = 26;
            this.groupBoxGirdiler.TabStop = false;
            this.groupBoxGirdiler.Text = "Girdiler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1049, 554);
            this.Controls.Add(this.groupBoxGirdiler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblara);
            this.Controls.Add(this.textBoxara);
            this.Controls.Add(this.dgvliste);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Otel Otomasyon";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvliste)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxGirdiler.ResumeLayout(false);
            this.groupBoxGirdiler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvliste;
        private System.Windows.Forms.ComboBox comboboxsec;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.TextBox textBoxad;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox textBoxsoyad;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.TextBox textBoxsehir;
        private System.Windows.Forms.TextBox textBoxulke;
        private System.Windows.Forms.Label lblPostaKod;
        private System.Windows.Forms.TextBox textBoxPostaKod;
        private System.Windows.Forms.Label lblUnvan;
        private System.Windows.Forms.TextBox textBoxUnvan;
        private System.Windows.Forms.Label lblTcNo;
        private System.Windows.Forms.TextBox textBoxTcNo;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.TextBox textBoxTelNo;
        private System.Windows.Forms.Label lblBirimFiyat;
        private System.Windows.Forms.TextBox textBoxBirimFiyat;
        private System.Windows.Forms.Label lblara;
        private System.Windows.Forms.TextBox textBoxara;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxGirdiler;
        private System.Windows.Forms.Label lblUlke;
        private System.Windows.Forms.Button btnekle;
    }
}

