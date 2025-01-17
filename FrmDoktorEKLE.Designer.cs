namespace Hastane
{
    partial class FrmDoktorEKLE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorEKLE));
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.onaylıyorumradio = new System.Windows.Forms.RadioButton();
            this.DoktorSifreTekrartxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DoktorCinsiyetcomboBox = new System.Windows.Forms.ComboBox();
            this.DoktorTelMaskedTxt = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DoktorAdSoyadtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DoktorSifretxt = new System.Windows.Forms.TextBox();
            this.DoktorTcMasekdtxt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.doktorIdtxt = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DoktorBranscomboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doktorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorCinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorBransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDoktorlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDataSet1 = new Hastane.HastaneDataSet1();
            this.tbl_DoktorlarTableAdapter = new Hastane.HastaneDataSet1TableAdapters.Tbl_DoktorlarTableAdapter();
            this.btnlistele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoktorlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuncelle.Location = new System.Drawing.Point(199, 458);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(121, 39);
            this.btnGuncelle.TabIndex = 48;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // onaylıyorumradio
            // 
            this.onaylıyorumradio.AutoSize = true;
            this.onaylıyorumradio.BackColor = System.Drawing.Color.Transparent;
            this.onaylıyorumradio.Location = new System.Drawing.Point(196, 379);
            this.onaylıyorumradio.Name = "onaylıyorumradio";
            this.onaylıyorumradio.Size = new System.Drawing.Size(124, 24);
            this.onaylıyorumradio.TabIndex = 47;
            this.onaylıyorumradio.TabStop = true;
            this.onaylıyorumradio.Text = "Onaylıyorum";
            this.onaylıyorumradio.UseVisualStyleBackColor = false;
            this.onaylıyorumradio.CheckedChanged += new System.EventHandler(this.onaylıyorumradio_CheckedChanged);
            // 
            // DoktorSifreTekrartxt
            // 
            this.DoktorSifreTekrartxt.Location = new System.Drawing.Point(196, 337);
            this.DoktorSifreTekrartxt.Name = "DoktorSifreTekrartxt";
            this.DoktorSifreTekrartxt.Size = new System.Drawing.Size(121, 26);
            this.DoktorSifreTekrartxt.TabIndex = 8;
            this.DoktorSifreTekrartxt.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(72, 337);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Şifre(Tekrar):";
            // 
            // DoktorCinsiyetcomboBox
            // 
            this.DoktorCinsiyetcomboBox.FormattingEnabled = true;
            this.DoktorCinsiyetcomboBox.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.DoktorCinsiyetcomboBox.Location = new System.Drawing.Point(196, 209);
            this.DoktorCinsiyetcomboBox.Name = "DoktorCinsiyetcomboBox";
            this.DoktorCinsiyetcomboBox.Size = new System.Drawing.Size(121, 28);
            this.DoktorCinsiyetcomboBox.TabIndex = 5;
            // 
            // DoktorTelMaskedTxt
            // 
            this.DoktorTelMaskedTxt.Location = new System.Drawing.Point(199, 166);
            this.DoktorTelMaskedTxt.Mask = "(999) 000-0000";
            this.DoktorTelMaskedTxt.Name = "DoktorTelMaskedTxt";
            this.DoktorTelMaskedTxt.Size = new System.Drawing.Size(118, 26);
            this.DoktorTelMaskedTxt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(57, 209);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Doktor Cinsiyet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(64, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Doktor Telefon:";
            // 
            // DoktorAdSoyadtxt
            // 
            this.DoktorAdSoyadtxt.Location = new System.Drawing.Point(199, 81);
            this.DoktorAdSoyadtxt.Name = "DoktorAdSoyadtxt";
            this.DoktorAdSoyadtxt.Size = new System.Drawing.Size(118, 26);
            this.DoktorAdSoyadtxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(49, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Doktor Ad Soyad:";
            // 
            // DoktorSifretxt
            // 
            this.DoktorSifretxt.Location = new System.Drawing.Point(196, 298);
            this.DoktorSifretxt.Name = "DoktorSifretxt";
            this.DoktorSifretxt.Size = new System.Drawing.Size(121, 26);
            this.DoktorSifretxt.TabIndex = 7;
            this.DoktorSifretxt.UseSystemPasswordChar = true;
            // 
            // DoktorTcMasekdtxt
            // 
            this.DoktorTcMasekdtxt.Location = new System.Drawing.Point(199, 123);
            this.DoktorTcMasekdtxt.Mask = "00000000000";
            this.DoktorTcMasekdtxt.Name = "DoktorTcMasekdtxt";
            this.DoktorTcMasekdtxt.Size = new System.Drawing.Size(118, 26);
            this.DoktorTcMasekdtxt.TabIndex = 3;
            this.DoktorTcMasekdtxt.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(136, 298);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(67, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "T.C. Kimlik No:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(78, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "Doktor ID No:";
            // 
            // doktorIdtxt
            // 
            this.doktorIdtxt.Enabled = false;
            this.doktorIdtxt.Location = new System.Drawing.Point(199, 37);
            this.doktorIdtxt.Name = "doktorIdtxt";
            this.doktorIdtxt.Size = new System.Drawing.Size(118, 26);
            this.doktorIdtxt.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.Enabled = false;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Location = new System.Drawing.Point(199, 413);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(121, 39);
            this.btnEkle.TabIndex = 51;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.Enabled = false;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Location = new System.Drawing.Point(199, 503);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(121, 39);
            this.btnSil.TabIndex = 52;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(71, 257);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Doktor Branş:";
            // 
            // DoktorBranscomboBox
            // 
            this.DoktorBranscomboBox.FormattingEnabled = true;
            this.DoktorBranscomboBox.Location = new System.Drawing.Point(196, 254);
            this.DoktorBranscomboBox.Name = "DoktorBranscomboBox";
            this.DoktorBranscomboBox.Size = new System.Drawing.Size(121, 28);
            this.DoktorBranscomboBox.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doktorIdDataGridViewTextBoxColumn,
            this.doktorAdSoyadDataGridViewTextBoxColumn,
            this.doktorCinsiyetDataGridViewTextBoxColumn,
            this.doktorTelefonDataGridViewTextBoxColumn,
            this.doktorTcDataGridViewTextBoxColumn,
            this.doktorSifreDataGridViewTextBoxColumn,
            this.doktorBransDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDoktorlarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(345, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(933, 326);
            this.dataGridView1.TabIndex = 55;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // doktorIdDataGridViewTextBoxColumn
            // 
            this.doktorIdDataGridViewTextBoxColumn.DataPropertyName = "DoktorId";
            this.doktorIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.doktorIdDataGridViewTextBoxColumn.Name = "doktorIdDataGridViewTextBoxColumn";
            this.doktorIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doktorAdSoyadDataGridViewTextBoxColumn
            // 
            this.doktorAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "DoktorAdSoyad";
            this.doktorAdSoyadDataGridViewTextBoxColumn.HeaderText = "Ad Soyad";
            this.doktorAdSoyadDataGridViewTextBoxColumn.Name = "doktorAdSoyadDataGridViewTextBoxColumn";
            // 
            // doktorCinsiyetDataGridViewTextBoxColumn
            // 
            this.doktorCinsiyetDataGridViewTextBoxColumn.DataPropertyName = "DoktorCinsiyet";
            this.doktorCinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            this.doktorCinsiyetDataGridViewTextBoxColumn.Name = "doktorCinsiyetDataGridViewTextBoxColumn";
            // 
            // doktorTelefonDataGridViewTextBoxColumn
            // 
            this.doktorTelefonDataGridViewTextBoxColumn.DataPropertyName = "DoktorTelefon";
            this.doktorTelefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.doktorTelefonDataGridViewTextBoxColumn.Name = "doktorTelefonDataGridViewTextBoxColumn";
            // 
            // doktorTcDataGridViewTextBoxColumn
            // 
            this.doktorTcDataGridViewTextBoxColumn.DataPropertyName = "DoktorTc";
            this.doktorTcDataGridViewTextBoxColumn.HeaderText = "Tc";
            this.doktorTcDataGridViewTextBoxColumn.Name = "doktorTcDataGridViewTextBoxColumn";
            // 
            // doktorSifreDataGridViewTextBoxColumn
            // 
            this.doktorSifreDataGridViewTextBoxColumn.DataPropertyName = "DoktorSifre";
            this.doktorSifreDataGridViewTextBoxColumn.HeaderText = "Sifre";
            this.doktorSifreDataGridViewTextBoxColumn.Name = "doktorSifreDataGridViewTextBoxColumn";
            // 
            // doktorBransDataGridViewTextBoxColumn
            // 
            this.doktorBransDataGridViewTextBoxColumn.DataPropertyName = "DoktorBrans";
            this.doktorBransDataGridViewTextBoxColumn.HeaderText = "Brans";
            this.doktorBransDataGridViewTextBoxColumn.Name = "doktorBransDataGridViewTextBoxColumn";
            // 
            // tblDoktorlarBindingSource
            // 
            this.tblDoktorlarBindingSource.DataMember = "Tbl_Doktorlar";
            this.tblDoktorlarBindingSource.DataSource = this.hastaneDataSet1;
            // 
            // hastaneDataSet1
            // 
            this.hastaneDataSet1.DataSetName = "HastaneDataSet1";
            this.hastaneDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_DoktorlarTableAdapter
            // 
            this.tbl_DoktorlarTableAdapter.ClearBeforeFill = true;
            // 
            // btnlistele
            // 
            this.btnlistele.BackColor = System.Drawing.Color.Transparent;
            this.btnlistele.Enabled = false;
            this.btnlistele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlistele.Location = new System.Drawing.Point(199, 548);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(121, 39);
            this.btnlistele.TabIndex = 56;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = false;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // FrmDoktorEKLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = global::Hastane.Properties.Resources.ed82529805250b004815da6debb66851;
            this.ClientSize = new System.Drawing.Size(1300, 586);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DoktorBranscomboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.doktorIdtxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.onaylıyorumradio);
            this.Controls.Add(this.DoktorSifreTekrartxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DoktorCinsiyetcomboBox);
            this.Controls.Add(this.DoktorTelMaskedTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DoktorAdSoyadtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DoktorSifretxt);
            this.Controls.Add(this.DoktorTcMasekdtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.BurlyWood;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorEKLE";
            this.Text = "Doktor Ekleme Paneli";
            this.Load += new System.EventHandler(this.FrmDoktorEKLE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoktorlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.RadioButton onaylıyorumradio;
        private System.Windows.Forms.TextBox DoktorSifreTekrartxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox DoktorCinsiyetcomboBox;
        private System.Windows.Forms.MaskedTextBox DoktorTelMaskedTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DoktorAdSoyadtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DoktorSifretxt;
        private System.Windows.Forms.MaskedTextBox DoktorTcMasekdtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox doktorIdtxt;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox DoktorBranscomboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HastaneDataSet1 hastaneDataSet1;
        private System.Windows.Forms.BindingSource tblDoktorlarBindingSource;
        private HastaneDataSet1TableAdapters.Tbl_DoktorlarTableAdapter tbl_DoktorlarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorCinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorSifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorBransDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnlistele;
    }
}