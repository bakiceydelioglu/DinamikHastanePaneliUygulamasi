namespace Hastane
{
    partial class FrmSekreterDetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblSekreterAdSoyad = new System.Windows.Forms.Label();
            this.lblSekreterTel = new System.Windows.Forms.Label();
            this.lblSekreterID = new System.Windows.Forms.Label();
            this.lblSekreterCinsiyet = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSekreterTc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.richTextBoxDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.checkBoxdolu = new System.Windows.Forms.CheckBox();
            this.checkBoxacik = new System.Windows.Forms.CheckBox();
            this.comboBoxdoktor = new System.Windows.Forms.ComboBox();
            this.comboBoxbrans = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxtc = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxsaat = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxtarih = new System.Windows.Forms.MaskedTextBox();
            this.randevuIdtxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewbranslar = new System.Windows.Forms.DataGridView();
            this.bransIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bransAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblBranslarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDataSet = new Hastane.HastaneDataSet();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridViewdoktorlar = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hızlıErişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duyurularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbl_BranslarTableAdapter = new Hastane.HastaneDataSetTableAdapters.Tbl_BranslarTableAdapter();
            this.hastaneDataSet1 = new Hastane.HastaneDataSet1();
            this.tblDoktorlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_DoktorlarTableAdapter = new Hastane.HastaneDataSet1TableAdapters.Tbl_DoktorlarTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.randevuListesiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.duyurularToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbranslar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBranslarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdoktorlar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoktorlarBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnCikis);
            this.groupBox1.Controls.Add(this.lblSekreterAdSoyad);
            this.groupBox1.Controls.Add(this.lblSekreterTel);
            this.groupBox1.Controls.Add(this.lblSekreterID);
            this.groupBox1.Controls.Add(this.lblSekreterCinsiyet);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblSekreterTc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Chocolate;
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 246);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgileri";
            // 
            // btnCikis
            // 
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Location = new System.Drawing.Point(274, 208);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(82, 38);
            this.btnCikis.TabIndex = 21;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lblSekreterAdSoyad
            // 
            this.lblSekreterAdSoyad.AutoSize = true;
            this.lblSekreterAdSoyad.Location = new System.Drawing.Point(154, 102);
            this.lblSekreterAdSoyad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSekreterAdSoyad.Name = "lblSekreterAdSoyad";
            this.lblSekreterAdSoyad.Size = new System.Drawing.Size(39, 20);
            this.lblSekreterAdSoyad.TabIndex = 17;
            this.lblSekreterAdSoyad.Text = "Null";
            // 
            // lblSekreterTel
            // 
            this.lblSekreterTel.AutoSize = true;
            this.lblSekreterTel.Location = new System.Drawing.Point(154, 174);
            this.lblSekreterTel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSekreterTel.Name = "lblSekreterTel";
            this.lblSekreterTel.Size = new System.Drawing.Size(39, 20);
            this.lblSekreterTel.TabIndex = 16;
            this.lblSekreterTel.Text = "Null";
            // 
            // lblSekreterID
            // 
            this.lblSekreterID.AutoSize = true;
            this.lblSekreterID.Location = new System.Drawing.Point(154, 36);
            this.lblSekreterID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSekreterID.Name = "lblSekreterID";
            this.lblSekreterID.Size = new System.Drawing.Size(39, 20);
            this.lblSekreterID.TabIndex = 20;
            this.lblSekreterID.Text = "Null";
            // 
            // lblSekreterCinsiyet
            // 
            this.lblSekreterCinsiyet.AutoSize = true;
            this.lblSekreterCinsiyet.Location = new System.Drawing.Point(154, 136);
            this.lblSekreterCinsiyet.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSekreterCinsiyet.Name = "lblSekreterCinsiyet";
            this.lblSekreterCinsiyet.Size = new System.Drawing.Size(39, 20);
            this.lblSekreterCinsiyet.TabIndex = 18;
            this.lblSekreterCinsiyet.Text = "Null";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "ID No:";
            // 
            // lblSekreterTc
            // 
            this.lblSekreterTc.AutoSize = true;
            this.lblSekreterTc.Location = new System.Drawing.Point(154, 69);
            this.lblSekreterTc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSekreterTc.Name = "lblSekreterTc";
            this.lblSekreterTc.Size = new System.Drawing.Size(119, 20);
            this.lblSekreterTc.TabIndex = 15;
            this.lblSekreterTc.Text = "00000000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cinsiyet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "T.C. Kimlik No:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnTemizle);
            this.groupBox2.Controls.Add(this.btnOlustur);
            this.groupBox2.Controls.Add(this.richTextBoxDuyuru);
            this.groupBox2.ForeColor = System.Drawing.Color.Chocolate;
            this.groupBox2.Location = new System.Drawing.Point(12, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 259);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btnTemizle
            // 
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTemizle.Location = new System.Drawing.Point(0, 221);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(118, 38);
            this.btnTemizle.TabIndex = 23;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnOlustur
            // 
            this.btnOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOlustur.Location = new System.Drawing.Point(238, 221);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(118, 38);
            this.btnOlustur.TabIndex = 22;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // richTextBoxDuyuru
            // 
            this.richTextBoxDuyuru.Location = new System.Drawing.Point(6, 28);
            this.richTextBoxDuyuru.Name = "richTextBoxDuyuru";
            this.richTextBoxDuyuru.Size = new System.Drawing.Size(344, 184);
            this.richTextBoxDuyuru.TabIndex = 0;
            this.richTextBoxDuyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnGuncelle);
            this.groupBox3.Controls.Add(this.btnKaydet);
            this.groupBox3.Controls.Add(this.checkBoxdolu);
            this.groupBox3.Controls.Add(this.checkBoxacik);
            this.groupBox3.Controls.Add(this.comboBoxdoktor);
            this.groupBox3.Controls.Add(this.comboBoxbrans);
            this.groupBox3.Controls.Add(this.maskedTextBoxtc);
            this.groupBox3.Controls.Add(this.maskedTextBoxsaat);
            this.groupBox3.Controls.Add(this.maskedTextBoxtarih);
            this.groupBox3.Controls.Add(this.randevuIdtxt);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.Chocolate;
            this.groupBox3.Location = new System.Drawing.Point(394, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 519);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuncelle.Location = new System.Drawing.Point(104, 429);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(152, 48);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "Sil";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.Location = new System.Drawing.Point(105, 380);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(151, 43);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // checkBoxdolu
            // 
            this.checkBoxdolu.AutoSize = true;
            this.checkBoxdolu.Location = new System.Drawing.Point(191, 337);
            this.checkBoxdolu.Name = "checkBoxdolu";
            this.checkBoxdolu.Size = new System.Drawing.Size(65, 24);
            this.checkBoxdolu.TabIndex = 15;
            this.checkBoxdolu.Text = "Dolu";
            this.checkBoxdolu.UseVisualStyleBackColor = true;
            // 
            // checkBoxacik
            // 
            this.checkBoxacik.AutoSize = true;
            this.checkBoxacik.Location = new System.Drawing.Point(105, 335);
            this.checkBoxacik.Name = "checkBoxacik";
            this.checkBoxacik.Size = new System.Drawing.Size(62, 24);
            this.checkBoxacik.TabIndex = 14;
            this.checkBoxacik.Text = "Açık";
            this.checkBoxacik.UseVisualStyleBackColor = true;
            // 
            // comboBoxdoktor
            // 
            this.comboBoxdoktor.FormattingEnabled = true;
            this.comboBoxdoktor.Location = new System.Drawing.Point(104, 241);
            this.comboBoxdoktor.Name = "comboBoxdoktor";
            this.comboBoxdoktor.Size = new System.Drawing.Size(152, 28);
            this.comboBoxdoktor.TabIndex = 13;
            // 
            // comboBoxbrans
            // 
            this.comboBoxbrans.FormattingEnabled = true;
            this.comboBoxbrans.Location = new System.Drawing.Point(104, 197);
            this.comboBoxbrans.Name = "comboBoxbrans";
            this.comboBoxbrans.Size = new System.Drawing.Size(153, 28);
            this.comboBoxbrans.TabIndex = 12;
            this.comboBoxbrans.SelectedIndexChanged += new System.EventHandler(this.comboBoxbrans_SelectedIndexChanged);
            // 
            // maskedTextBoxtc
            // 
            this.maskedTextBoxtc.Location = new System.Drawing.Point(103, 288);
            this.maskedTextBoxtc.Mask = "00000000000";
            this.maskedTextBoxtc.Name = "maskedTextBoxtc";
            this.maskedTextBoxtc.Size = new System.Drawing.Size(153, 26);
            this.maskedTextBoxtc.TabIndex = 10;
            this.maskedTextBoxtc.ValidatingType = typeof(int);
            // 
            // maskedTextBoxsaat
            // 
            this.maskedTextBoxsaat.Location = new System.Drawing.Point(105, 149);
            this.maskedTextBoxsaat.Mask = "00:00";
            this.maskedTextBoxsaat.Name = "maskedTextBoxsaat";
            this.maskedTextBoxsaat.Size = new System.Drawing.Size(152, 26);
            this.maskedTextBoxsaat.TabIndex = 9;
            this.maskedTextBoxsaat.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxtarih
            // 
            this.maskedTextBoxtarih.Location = new System.Drawing.Point(105, 105);
            this.maskedTextBoxtarih.Mask = "00/00/0000";
            this.maskedTextBoxtarih.Name = "maskedTextBoxtarih";
            this.maskedTextBoxtarih.Size = new System.Drawing.Size(152, 26);
            this.maskedTextBoxtarih.TabIndex = 8;
            this.maskedTextBoxtarih.ValidatingType = typeof(System.DateTime);
            // 
            // randevuIdtxt
            // 
            this.randevuIdtxt.Location = new System.Drawing.Point(105, 62);
            this.randevuIdtxt.Name = "randevuIdtxt";
            this.randevuIdtxt.Size = new System.Drawing.Size(152, 26);
            this.randevuIdtxt.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(20, 335);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 24);
            this.label12.TabIndex = 6;
            this.label12.Text = "Durum:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(22, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 24);
            this.label11.TabIndex = 5;
            this.label11.Text = "TC No:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(22, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 24);
            this.label10.TabIndex = 4;
            this.label10.Text = "Doktor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(29, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Branş:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(42, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Saat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(34, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(63, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.dataGridViewbranslar);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.Chocolate;
            this.groupBox4.Location = new System.Drawing.Point(726, 41);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(747, 245);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridViewbranslar
            // 
            this.dataGridViewbranslar.AutoGenerateColumns = false;
            this.dataGridViewbranslar.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridViewbranslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewbranslar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bransIdDataGridViewTextBoxColumn,
            this.bransAdDataGridViewTextBoxColumn});
            this.dataGridViewbranslar.DataSource = this.tblBranslarBindingSource;
            this.dataGridViewbranslar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewbranslar.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewbranslar.Name = "dataGridViewbranslar";
            this.dataGridViewbranslar.Size = new System.Drawing.Size(741, 220);
            this.dataGridViewbranslar.TabIndex = 0;
            // 
            // bransIdDataGridViewTextBoxColumn
            // 
            this.bransIdDataGridViewTextBoxColumn.DataPropertyName = "BransId";
            this.bransIdDataGridViewTextBoxColumn.HeaderText = "Brans Id";
            this.bransIdDataGridViewTextBoxColumn.Name = "bransIdDataGridViewTextBoxColumn";
            this.bransIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bransAdDataGridViewTextBoxColumn
            // 
            this.bransAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bransAdDataGridViewTextBoxColumn.DataPropertyName = "BransAd";
            this.bransAdDataGridViewTextBoxColumn.HeaderText = "Brans Ad";
            this.bransAdDataGridViewTextBoxColumn.Name = "bransAdDataGridViewTextBoxColumn";
            // 
            // tblBranslarBindingSource
            // 
            this.tblBranslarBindingSource.DataMember = "Tbl_Branslar";
            this.tblBranslarBindingSource.DataSource = this.hastaneDataSet;
            // 
            // hastaneDataSet
            // 
            this.hastaneDataSet.DataSetName = "HastaneDataSet";
            this.hastaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.dataGridViewdoktorlar);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.ForeColor = System.Drawing.Color.Chocolate;
            this.groupBox5.Location = new System.Drawing.Point(726, 312);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(750, 248);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridViewdoktorlar
            // 
            this.dataGridViewdoktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewdoktorlar.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridViewdoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdoktorlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewdoktorlar.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewdoktorlar.Name = "dataGridViewdoktorlar";
            this.dataGridViewdoktorlar.Size = new System.Drawing.Size(744, 223);
            this.dataGridViewdoktorlar.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hızlıErişimToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem,
            this.iletişimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1539, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hızlıErişimToolStripMenuItem
            // 
            this.hızlıErişimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevuListesiToolStripMenuItem,
            this.duyurularToolStripMenuItem});
            this.hızlıErişimToolStripMenuItem.Name = "hızlıErişimToolStripMenuItem";
            this.hızlıErişimToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.hızlıErişimToolStripMenuItem.Text = "Hızlı Erişim";
            // 
            // randevuListesiToolStripMenuItem
            // 
            this.randevuListesiToolStripMenuItem.Name = "randevuListesiToolStripMenuItem";
            this.randevuListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.randevuListesiToolStripMenuItem.Text = "Randevu Listesi";
            this.randevuListesiToolStripMenuItem.Click += new System.EventHandler(this.randevuListesiToolStripMenuItem_Click);
            // 
            // duyurularToolStripMenuItem
            // 
            this.duyurularToolStripMenuItem.Name = "duyurularToolStripMenuItem";
            this.duyurularToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.duyurularToolStripMenuItem.Text = "Duyurular";
            this.duyurularToolStripMenuItem.Click += new System.EventHandler(this.duyurularToolStripMenuItem_Click);
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.iletişimToolStripMenuItem.Text = "İletişim";
            this.iletişimToolStripMenuItem.Click += new System.EventHandler(this.iletişimToolStripMenuItem_Click);
            // 
            // tbl_BranslarTableAdapter
            // 
            this.tbl_BranslarTableAdapter.ClearBeforeFill = true;
            // 
            // hastaneDataSet1
            // 
            this.hastaneDataSet1.DataSetName = "HastaneDataSet1";
            this.hastaneDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDoktorlarBindingSource
            // 
            this.tblDoktorlarBindingSource.DataMember = "Tbl_Doktorlar";
            this.tblDoktorlarBindingSource.DataSource = this.hastaneDataSet1;
            // 
            // tbl_DoktorlarTableAdapter
            // 
            this.tbl_DoktorlarTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevuListesiToolStripMenuItem1,
            this.duyurularToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 48);
            // 
            // randevuListesiToolStripMenuItem1
            // 
            this.randevuListesiToolStripMenuItem1.Name = "randevuListesiToolStripMenuItem1";
            this.randevuListesiToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.randevuListesiToolStripMenuItem1.Text = "Randevu Listesi";
            this.randevuListesiToolStripMenuItem1.Click += new System.EventHandler(this.randevuListesiToolStripMenuItem1_Click);
            // 
            // duyurularToolStripMenuItem1
            // 
            this.duyurularToolStripMenuItem1.Name = "duyurularToolStripMenuItem1";
            this.duyurularToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.duyurularToolStripMenuItem1.Text = "Duyurular";
            this.duyurularToolStripMenuItem1.Click += new System.EventHandler(this.duyurularToolStripMenuItem1_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = global::Hastane.Properties.Resources.ed82529805250b004815da6debb66851;
            this.ClientSize = new System.Drawing.Size(1539, 582);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Chocolate;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekreter Paneli";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbranslar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBranslarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdoktorlar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoktorlarBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblSekreterAdSoyad;
        private System.Windows.Forms.Label lblSekreterTel;
        private System.Windows.Forms.Label lblSekreterID;
        private System.Windows.Forms.Label lblSekreterCinsiyet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSekreterTc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.RichTextBox richTextBoxDuyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxdoktor;
        private System.Windows.Forms.ComboBox comboBoxbrans;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxtc;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxsaat;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxtarih;
        private System.Windows.Forms.TextBox randevuIdtxt;
        private System.Windows.Forms.CheckBox checkBoxdolu;
        private System.Windows.Forms.CheckBox checkBoxacik;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridViewbranslar;
        private System.Windows.Forms.DataGridView dataGridViewdoktorlar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hızlıErişimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuListesiToolStripMenuItem;
        private HastaneDataSet hastaneDataSet;
        private System.Windows.Forms.BindingSource tblBranslarBindingSource;
        private HastaneDataSetTableAdapters.Tbl_BranslarTableAdapter tbl_BranslarTableAdapter;
        private HastaneDataSet1 hastaneDataSet1;
        private System.Windows.Forms.BindingSource tblDoktorlarBindingSource;
        private HastaneDataSet1TableAdapters.Tbl_DoktorlarTableAdapter tbl_DoktorlarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bransIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bransAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ToolStripMenuItem duyurularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem randevuListesiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem duyurularToolStripMenuItem1;
    }
}