namespace Personel_kayıt2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.durum = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.sehir = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.meslek = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.maas = new System.Windows.Forms.Label();
            this.soyad = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grafikler = new System.Windows.Forms.Button();
            this.istatistik = new System.Windows.Forms.Button();
            this.temizle = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.kaydet = new System.Windows.Forms.Button();
            this.listele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perdurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.permeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personeltblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabaniDataSet = new Personel_kayıt2.PersonelVeriTabaniDataSet();
            this.personel_tblTableAdapter = new Personel_kayıt2.PersonelVeriTabaniDataSetTableAdapters.Personel_tblTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personeltblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox1.Font = new System.Drawing.Font("Fenwick", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(101, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 26);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.durum);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.sehir);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.meslek);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.maas);
            this.groupBox1.Controls.Add(this.soyad);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.ad);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(34, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 359);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.maskedTextBox1.Font = new System.Drawing.Font("Fenwick", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox1.Location = new System.Drawing.Point(101, 229);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(151, 26);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // durum
            // 
            this.durum.AutoSize = true;
            this.durum.Font = new System.Drawing.Font("Bebas Neue Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durum.ForeColor = System.Drawing.Color.White;
            this.durum.Location = new System.Drawing.Point(42, 314);
            this.durum.Name = "durum";
            this.durum.Size = new System.Drawing.Size(52, 23);
            this.durum.TabIndex = 14;
            this.durum.Text = "Durum";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Bebas Neue Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.Location = new System.Drawing.Point(146, 318);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "BEKAR";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Bebas Neue Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(101, 318);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(39, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "EVLİ";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // sehir
            // 
            this.sehir.AutoSize = true;
            this.sehir.Font = new System.Drawing.Font("Bebas Neue Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sehir.ForeColor = System.Drawing.Color.White;
            this.sehir.Location = new System.Drawing.Point(50, 273);
            this.sehir.Name = "sehir";
            this.sehir.Size = new System.Drawing.Size(44, 23);
            this.sehir.TabIndex = 11;
            this.sehir.Text = "ŞEHİR";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.comboBox1.Font = new System.Drawing.Font("Fenwick", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            " Adana",
            " Adıyaman",
            " Afyonkarahisar",
            " Ağrı",
            " Aksaray",
            " Amasya",
            " Ankara",
            " Antalya",
            " Ardahan",
            " Artvin",
            " Aydın",
            " Balıkesir",
            " Bartın",
            " Batman",
            " Bayburt",
            " Bilecik",
            " Bingöl",
            " Bitlis",
            " Bolu",
            " Burdur",
            " Bursa",
            " Çanakkale",
            " Çankırı",
            " Çorum",
            " Denizli",
            " Diyarbakır",
            " Düzce",
            " Edirne",
            " Elazığ",
            " Erzincan",
            " Erzurum",
            " Eskişehir",
            " Gaziantep",
            " Giresun",
            " Gümüşhane",
            " Hakkâri",
            " Hatay",
            " Iğdır",
            " Isparta",
            " İstanbul",
            " İzmir",
            " Kahramanmaraş",
            " Karabük",
            " Karaman",
            " Kars",
            " Kastamonu",
            " Kayseri",
            " Kilis",
            " Kırıkkale",
            " Kırklareli",
            " Kırşehir",
            " Kocaeli",
            " Konya",
            " Kütahya",
            " Malatya",
            " Manisa",
            " Mardin",
            " Mersin",
            " Muğla",
            " Muş",
            " Nevşehir",
            " Niğde",
            " Ordu",
            " Osmaniye",
            " Rize",
            " Sakarya",
            " Samsun",
            " Şanlıurfa",
            " Siirt",
            " Sinop",
            " Sivas",
            " Şırnak",
            " Tekirdağ",
            " Tokat",
            " Trabzon",
            " Tunceli",
            " Uşak",
            " Van",
            " Yalova",
            " Yozgat",
            " Zonguldak"});
            this.comboBox1.Location = new System.Drawing.Point(101, 270);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 26);
            this.comboBox1.TabIndex = 5;
            // 
            // meslek
            // 
            this.meslek.AutoSize = true;
            this.meslek.Font = new System.Drawing.Font("Bebas Neue Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meslek.ForeColor = System.Drawing.Color.White;
            this.meslek.Location = new System.Drawing.Point(39, 187);
            this.meslek.Name = "meslek";
            this.meslek.Size = new System.Drawing.Size(55, 23);
            this.meslek.TabIndex = 9;
            this.meslek.Text = "MESLEK";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox4.Font = new System.Drawing.Font("Fenwick", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(101, 185);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(151, 26);
            this.textBox4.TabIndex = 3;
            // 
            // maas
            // 
            this.maas.AutoSize = true;
            this.maas.Font = new System.Drawing.Font("Bebas Neue Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maas.ForeColor = System.Drawing.Color.White;
            this.maas.Location = new System.Drawing.Point(51, 231);
            this.maas.Name = "maas";
            this.maas.Size = new System.Drawing.Size(43, 23);
            this.maas.TabIndex = 7;
            this.maas.Text = "MAAŞ";
            // 
            // soyad
            // 
            this.soyad.AutoSize = true;
            this.soyad.Font = new System.Drawing.Font("Bebas Neue Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soyad.ForeColor = System.Drawing.Color.White;
            this.soyad.Location = new System.Drawing.Point(46, 147);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(48, 23);
            this.soyad.TabIndex = 5;
            this.soyad.Text = "SOYAD";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox3.Font = new System.Drawing.Font("Fenwick", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(101, 141);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 26);
            this.textBox3.TabIndex = 2;
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Font = new System.Drawing.Font("Bebas Neue Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ad.ForeColor = System.Drawing.Color.White;
            this.ad.Location = new System.Drawing.Point(68, 101);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(26, 23);
            this.ad.TabIndex = 3;
            this.ad.Text = "AD";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox2.Font = new System.Drawing.Font("Fenwick", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(101, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 26);
            this.textBox2.TabIndex = 1;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Bebas Neue Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.Color.White;
            this.id.Location = new System.Drawing.Point(72, 60);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(22, 23);
            this.id.TabIndex = 1;
            this.id.Text = "İd";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grafikler);
            this.groupBox2.Controls.Add(this.istatistik);
            this.groupBox2.Controls.Add(this.temizle);
            this.groupBox2.Controls.Add(this.guncelle);
            this.groupBox2.Controls.Add(this.sil);
            this.groupBox2.Controls.Add(this.kaydet);
            this.groupBox2.Controls.Add(this.listele);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(434, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 359);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // grafikler
            // 
            this.grafikler.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grafikler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.grafikler.Location = new System.Drawing.Point(37, 292);
            this.grafikler.Name = "grafikler";
            this.grafikler.Size = new System.Drawing.Size(125, 32);
            this.grafikler.TabIndex = 6;
            this.grafikler.Text = "GRAFİKLER";
            this.grafikler.UseVisualStyleBackColor = true;
            // 
            // istatistik
            // 
            this.istatistik.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.istatistik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.istatistik.Location = new System.Drawing.Point(37, 251);
            this.istatistik.Name = "istatistik";
            this.istatistik.Size = new System.Drawing.Size(125, 32);
            this.istatistik.TabIndex = 5;
            this.istatistik.Text = "İSTATİSTİK";
            this.istatistik.UseVisualStyleBackColor = true;
            this.istatistik.Click += new System.EventHandler(this.istatistik_Click);
            // 
            // temizle
            // 
            this.temizle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.temizle.Location = new System.Drawing.Point(37, 210);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(125, 32);
            this.temizle.TabIndex = 4;
            this.temizle.Text = "TEMİZLE";
            this.temizle.UseVisualStyleBackColor = true;
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // guncelle
            // 
            this.guncelle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guncelle.Location = new System.Drawing.Point(37, 168);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(125, 32);
            this.guncelle.TabIndex = 3;
            this.guncelle.Text = "GÜNCELLE";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // sil
            // 
            this.sil.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.sil.Location = new System.Drawing.Point(37, 124);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(125, 32);
            this.sil.TabIndex = 2;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // kaydet
            // 
            this.kaydet.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.kaydet.Location = new System.Drawing.Point(37, 81);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(125, 32);
            this.kaydet.TabIndex = 1;
            this.kaydet.Text = "KAYDET";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // listele
            // 
            this.listele.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.listele.Location = new System.Drawing.Point(37, 40);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(125, 32);
            this.listele.TabIndex = 0;
            this.listele.Text = "LİSTELE";
            this.listele.UseVisualStyleBackColor = true;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(34, 410);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(752, 202);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.peradDataGridViewTextBoxColumn,
            this.persoyadDataGridViewTextBoxColumn,
            this.persehirDataGridViewTextBoxColumn,
            this.permaasDataGridViewTextBoxColumn,
            this.perdurumDataGridViewCheckBoxColumn,
            this.permeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personeltblBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 183);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "per_id";
            this.peridDataGridViewTextBoxColumn.HeaderText = "per_id";
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peradDataGridViewTextBoxColumn
            // 
            this.peradDataGridViewTextBoxColumn.DataPropertyName = "per_ad";
            this.peradDataGridViewTextBoxColumn.HeaderText = "per_ad";
            this.peradDataGridViewTextBoxColumn.Name = "peradDataGridViewTextBoxColumn";
            // 
            // persoyadDataGridViewTextBoxColumn
            // 
            this.persoyadDataGridViewTextBoxColumn.DataPropertyName = "per_soyad";
            this.persoyadDataGridViewTextBoxColumn.HeaderText = "per_soyad";
            this.persoyadDataGridViewTextBoxColumn.Name = "persoyadDataGridViewTextBoxColumn";
            // 
            // persehirDataGridViewTextBoxColumn
            // 
            this.persehirDataGridViewTextBoxColumn.DataPropertyName = "per_sehir";
            this.persehirDataGridViewTextBoxColumn.HeaderText = "per_sehir";
            this.persehirDataGridViewTextBoxColumn.Name = "persehirDataGridViewTextBoxColumn";
            // 
            // permaasDataGridViewTextBoxColumn
            // 
            this.permaasDataGridViewTextBoxColumn.DataPropertyName = "per_maas";
            this.permaasDataGridViewTextBoxColumn.HeaderText = "per_maas";
            this.permaasDataGridViewTextBoxColumn.Name = "permaasDataGridViewTextBoxColumn";
            // 
            // perdurumDataGridViewCheckBoxColumn
            // 
            this.perdurumDataGridViewCheckBoxColumn.DataPropertyName = "per_durum";
            this.perdurumDataGridViewCheckBoxColumn.HeaderText = "per_durum";
            this.perdurumDataGridViewCheckBoxColumn.Name = "perdurumDataGridViewCheckBoxColumn";
            // 
            // permeslekDataGridViewTextBoxColumn
            // 
            this.permeslekDataGridViewTextBoxColumn.DataPropertyName = "per_meslek";
            this.permeslekDataGridViewTextBoxColumn.HeaderText = "per_meslek";
            this.permeslekDataGridViewTextBoxColumn.Name = "permeslekDataGridViewTextBoxColumn";
            // 
            // personeltblBindingSource
            // 
            this.personeltblBindingSource.DataMember = "Personel_tbl";
            this.personeltblBindingSource.DataSource = this.personelVeriTabaniDataSet;
            // 
            // personelVeriTabaniDataSet
            // 
            this.personelVeriTabaniDataSet.DataSetName = "PersonelVeriTabaniDataSet";
            this.personelVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personel_tblTableAdapter
            // 
            this.personel_tblTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(688, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Personel Kayıt Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personeltblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label durum;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label sehir;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label meslek;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label maas;
        private System.Windows.Forms.Label soyad;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button grafikler;
        private System.Windows.Forms.Button istatistik;
        private System.Windows.Forms.Button temizle;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private PersonelVeriTabaniDataSet personelVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource personeltblBindingSource;
        private PersonelVeriTabaniDataSetTableAdapters.Personel_tblTableAdapter personel_tblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perdurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}

