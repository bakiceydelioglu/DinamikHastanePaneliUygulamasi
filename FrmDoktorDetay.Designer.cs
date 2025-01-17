namespace Hastane
{
    partial class FrmDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDoktorBrans = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDoktorAdSoyad = new System.Windows.Forms.Label();
            this.lblDoktorTel = new System.Windows.Forms.Label();
            this.lblDoktorID = new System.Windows.Forms.Label();
            this.lblDoktorCinsiyet = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDoktorTc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Sikayettxt = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hızlıErişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sekreterEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duyurularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblRandevularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sekreterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.duyurularToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRandevularBindingSource)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblDoktorBrans);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblDoktorAdSoyad);
            this.groupBox1.Controls.Add(this.lblDoktorTel);
            this.groupBox1.Controls.Add(this.lblDoktorID);
            this.groupBox1.Controls.Add(this.lblDoktorCinsiyet);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblDoktorTc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 245);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgileri";
            // 
            // lblDoktorBrans
            // 
            this.lblDoktorBrans.AutoSize = true;
            this.lblDoktorBrans.Location = new System.Drawing.Point(176, 168);
            this.lblDoktorBrans.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDoktorBrans.Name = "lblDoktorBrans";
            this.lblDoktorBrans.Size = new System.Drawing.Size(44, 23);
            this.lblDoktorBrans.TabIndex = 23;
            this.lblDoktorBrans.Text = "Null";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 168);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Branş:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(335, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 39);
            this.button1.TabIndex = 21;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDoktorAdSoyad
            // 
            this.lblDoktorAdSoyad.AutoSize = true;
            this.lblDoktorAdSoyad.Location = new System.Drawing.Point(176, 102);
            this.lblDoktorAdSoyad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDoktorAdSoyad.Name = "lblDoktorAdSoyad";
            this.lblDoktorAdSoyad.Size = new System.Drawing.Size(44, 23);
            this.lblDoktorAdSoyad.TabIndex = 17;
            this.lblDoktorAdSoyad.Text = "Null";
            // 
            // lblDoktorTel
            // 
            this.lblDoktorTel.AutoSize = true;
            this.lblDoktorTel.Location = new System.Drawing.Point(176, 199);
            this.lblDoktorTel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDoktorTel.Name = "lblDoktorTel";
            this.lblDoktorTel.Size = new System.Drawing.Size(44, 23);
            this.lblDoktorTel.TabIndex = 16;
            this.lblDoktorTel.Text = "Null";
            // 
            // lblDoktorID
            // 
            this.lblDoktorID.AutoSize = true;
            this.lblDoktorID.Location = new System.Drawing.Point(176, 36);
            this.lblDoktorID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDoktorID.Name = "lblDoktorID";
            this.lblDoktorID.Size = new System.Drawing.Size(44, 23);
            this.lblDoktorID.TabIndex = 20;
            this.lblDoktorID.Text = "Null";
            // 
            // lblDoktorCinsiyet
            // 
            this.lblDoktorCinsiyet.AutoSize = true;
            this.lblDoktorCinsiyet.Location = new System.Drawing.Point(176, 136);
            this.lblDoktorCinsiyet.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDoktorCinsiyet.Name = "lblDoktorCinsiyet";
            this.lblDoktorCinsiyet.Size = new System.Drawing.Size(44, 23);
            this.lblDoktorCinsiyet.TabIndex = 18;
            this.lblDoktorCinsiyet.Text = "Null";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "ID No:";
            // 
            // lblDoktorTc
            // 
            this.lblDoktorTc.AutoSize = true;
            this.lblDoktorTc.Location = new System.Drawing.Point(176, 69);
            this.lblDoktorTc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDoktorTc.Name = "lblDoktorTc";
            this.lblDoktorTc.Size = new System.Drawing.Size(120, 23);
            this.lblDoktorTc.TabIndex = 15;
            this.lblDoktorTc.Text = "00000000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cinsiyet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "T.C. Kimlik No:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Sikayettxt);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 260);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasta Şikayeti";
            // 
            // Sikayettxt
            // 
            this.Sikayettxt.BackColor = System.Drawing.Color.Aquamarine;
            this.Sikayettxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sikayettxt.Location = new System.Drawing.Point(3, 27);
            this.Sikayettxt.Name = "Sikayettxt";
            this.Sikayettxt.Size = new System.Drawing.Size(418, 230);
            this.Sikayettxt.TabIndex = 27;
            this.Sikayettxt.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.ForeColor = System.Drawing.Color.BurlyWood;
            this.groupBox3.Location = new System.Drawing.Point(482, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(872, 511);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(866, 481);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Beige;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hızlıErişimToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem,
            this.iletişimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1394, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hızlıErişimToolStripMenuItem
            // 
            this.hızlıErişimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sekreterEkleToolStripMenuItem,
            this.duyurularToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.hızlıErişimToolStripMenuItem.Name = "hızlıErişimToolStripMenuItem";
            this.hızlıErişimToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.hızlıErişimToolStripMenuItem.Text = "Hızlı Erişim";
            // 
            // sekreterEkleToolStripMenuItem
            // 
            this.sekreterEkleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.sekreterEkleToolStripMenuItem.Name = "sekreterEkleToolStripMenuItem";
            this.sekreterEkleToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.sekreterEkleToolStripMenuItem.Text = "Sekreter ";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // duyurularToolStripMenuItem
            // 
            this.duyurularToolStripMenuItem.Name = "duyurularToolStripMenuItem";
            this.duyurularToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.duyurularToolStripMenuItem.Text = "Duyurular";
            this.duyurularToolStripMenuItem.Click += new System.EventHandler(this.duyurularToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
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
            // tblRandevularBindingSource
            // 
            this.tblRandevularBindingSource.DataMember = "Tbl_Randevular";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sekreterToolStripMenuItem,
            this.duyurularToolStripMenuItem1,
            this.çıkışToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(127, 70);
            // 
            // sekreterToolStripMenuItem
            // 
            this.sekreterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem1,
            this.güncelleToolStripMenuItem1});
            this.sekreterToolStripMenuItem.Name = "sekreterToolStripMenuItem";
            this.sekreterToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.sekreterToolStripMenuItem.Text = "Sekreter";
            // 
            // ekleToolStripMenuItem1
            // 
            this.ekleToolStripMenuItem1.Name = "ekleToolStripMenuItem1";
            this.ekleToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.ekleToolStripMenuItem1.Text = "Ekle";
            this.ekleToolStripMenuItem1.Click += new System.EventHandler(this.ekleToolStripMenuItem1_Click);
            // 
            // güncelleToolStripMenuItem1
            // 
            this.güncelleToolStripMenuItem1.Name = "güncelleToolStripMenuItem1";
            this.güncelleToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.güncelleToolStripMenuItem1.Text = "Güncelle";
            this.güncelleToolStripMenuItem1.Click += new System.EventHandler(this.güncelleToolStripMenuItem1_Click);
            // 
            // duyurularToolStripMenuItem1
            // 
            this.duyurularToolStripMenuItem1.Name = "duyurularToolStripMenuItem1";
            this.duyurularToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.duyurularToolStripMenuItem1.Text = "Duyurular";
            this.duyurularToolStripMenuItem1.Click += new System.EventHandler(this.duyurularToolStripMenuItem1_Click);
            // 
            // çıkışToolStripMenuItem1
            // 
            this.çıkışToolStripMenuItem1.Name = "çıkışToolStripMenuItem1";
            this.çıkışToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.çıkışToolStripMenuItem1.Text = "Çıkış";
            this.çıkışToolStripMenuItem1.Click += new System.EventHandler(this.çıkışToolStripMenuItem1_Click);
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1394, 583);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.FrmDoktorDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRandevularBindingSource)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDoktorAdSoyad;
        private System.Windows.Forms.Label lblDoktorTel;
        private System.Windows.Forms.Label lblDoktorID;
        private System.Windows.Forms.Label lblDoktorCinsiyet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDoktorTc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox Sikayettxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hızlıErişimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duyurularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        private System.Windows.Forms.Label lblDoktorBrans;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem sekreterEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
   //     private HastaneDataSet7 hastaneDataSet7;
        private System.Windows.Forms.BindingSource tblRandevularBindingSource;
  //      private HastaneDataSet7TableAdapters.Tbl_RandevularTableAdapter tbl_RandevularTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuSaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuBransDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuDoktorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuDurumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem sekreterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem duyurularToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem1;
    }
}