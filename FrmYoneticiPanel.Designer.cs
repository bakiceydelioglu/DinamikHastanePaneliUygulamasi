namespace Hastane
{
    partial class FrmYoneticiPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYoneticiPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblYoneticiID = new System.Windows.Forms.Label();
            this.lblYoneticiAdSoyad = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblYoneticiTc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGrafikler = new System.Windows.Forms.Button();
            this.btnIstatistikler = new System.Windows.Forms.Button();
            this.btnYoneticiEkle = new System.Windows.Forms.Button();
            this.btnDoktorEkle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewdoktor = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewsekreter = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hızlıErişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.branşEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.branşEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdoktor)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsekreter)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnCikis);
            this.groupBox1.Controls.Add(this.lblYoneticiID);
            this.groupBox1.Controls.Add(this.lblYoneticiAdSoyad);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblYoneticiTc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 177);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yönetici Bilgileri";
            // 
            // btnCikis
            // 
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Location = new System.Drawing.Point(307, 131);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(89, 46);
            this.btnCikis.TabIndex = 21;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            // 
            // lblYoneticiID
            // 
            this.lblYoneticiID.AutoSize = true;
            this.lblYoneticiID.Location = new System.Drawing.Point(176, 36);
            this.lblYoneticiID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblYoneticiID.Name = "lblYoneticiID";
            this.lblYoneticiID.Size = new System.Drawing.Size(47, 24);
            this.lblYoneticiID.TabIndex = 20;
            this.lblYoneticiID.Text = "Null";
            // 
            // lblYoneticiAdSoyad
            // 
            this.lblYoneticiAdSoyad.AutoSize = true;
            this.lblYoneticiAdSoyad.Location = new System.Drawing.Point(176, 102);
            this.lblYoneticiAdSoyad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblYoneticiAdSoyad.Name = "lblYoneticiAdSoyad";
            this.lblYoneticiAdSoyad.Size = new System.Drawing.Size(47, 24);
            this.lblYoneticiAdSoyad.TabIndex = 18;
            this.lblYoneticiAdSoyad.Text = "Null";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "ID No:";
            // 
            // lblYoneticiTc
            // 
            this.lblYoneticiTc.AutoSize = true;
            this.lblYoneticiTc.Location = new System.Drawing.Point(176, 69);
            this.lblYoneticiTc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblYoneticiTc.Name = "lblYoneticiTc";
            this.lblYoneticiTc.Size = new System.Drawing.Size(131, 24);
            this.lblYoneticiTc.TabIndex = 15;
            this.lblYoneticiTc.Text = "00000000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "T.C. Kimlik No:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnListele);
            this.groupBox2.Controls.Add(this.btnGrafikler);
            this.groupBox2.Controls.Add(this.btnIstatistikler);
            this.groupBox2.Controls.Add(this.btnYoneticiEkle);
            this.groupBox2.Controls.Add(this.btnDoktorEkle);
            this.groupBox2.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.groupBox2.Location = new System.Drawing.Point(12, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 392);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yönetim";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(107, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 46);
            this.button1.TabIndex = 22;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnListele
            // 
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListele.Location = new System.Drawing.Point(107, 264);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(160, 50);
            this.btnListele.TabIndex = 5;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGrafikler
            // 
            this.btnGrafikler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrafikler.Location = new System.Drawing.Point(107, 208);
            this.btnGrafikler.Name = "btnGrafikler";
            this.btnGrafikler.Size = new System.Drawing.Size(160, 50);
            this.btnGrafikler.TabIndex = 3;
            this.btnGrafikler.Text = "Grafikler";
            this.btnGrafikler.UseVisualStyleBackColor = true;
            this.btnGrafikler.Click += new System.EventHandler(this.btnGrafikler_Click);
            // 
            // btnIstatistikler
            // 
            this.btnIstatistikler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIstatistikler.Location = new System.Drawing.Point(107, 152);
            this.btnIstatistikler.Name = "btnIstatistikler";
            this.btnIstatistikler.Size = new System.Drawing.Size(160, 50);
            this.btnIstatistikler.TabIndex = 2;
            this.btnIstatistikler.Text = "İstatistikler";
            this.btnIstatistikler.UseVisualStyleBackColor = true;
            this.btnIstatistikler.Click += new System.EventHandler(this.btnIstatistikler_Click);
            // 
            // btnYoneticiEkle
            // 
            this.btnYoneticiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYoneticiEkle.Location = new System.Drawing.Point(107, 96);
            this.btnYoneticiEkle.Name = "btnYoneticiEkle";
            this.btnYoneticiEkle.Size = new System.Drawing.Size(160, 50);
            this.btnYoneticiEkle.TabIndex = 1;
            this.btnYoneticiEkle.Text = "Yönetici Ekle";
            this.btnYoneticiEkle.UseVisualStyleBackColor = true;
            this.btnYoneticiEkle.Click += new System.EventHandler(this.btnYoneticiEkle_Click);
            // 
            // btnDoktorEkle
            // 
            this.btnDoktorEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDoktorEkle.Location = new System.Drawing.Point(107, 40);
            this.btnDoktorEkle.Name = "btnDoktorEkle";
            this.btnDoktorEkle.Size = new System.Drawing.Size(160, 50);
            this.btnDoktorEkle.TabIndex = 0;
            this.btnDoktorEkle.Text = "Doktor Ekle";
            this.btnDoktorEkle.UseVisualStyleBackColor = true;
            this.btnDoktorEkle.Click += new System.EventHandler(this.btnDoktorEkle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dataGridViewdoktor);
            this.groupBox3.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.groupBox3.Location = new System.Drawing.Point(455, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(805, 283);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Doktorlar";
            // 
            // dataGridViewdoktor
            // 
            this.dataGridViewdoktor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewdoktor.BackgroundColor = System.Drawing.Color.Cyan;
            this.dataGridViewdoktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdoktor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewdoktor.Location = new System.Drawing.Point(3, 25);
            this.dataGridViewdoktor.Name = "dataGridViewdoktor";
            this.dataGridViewdoktor.Size = new System.Drawing.Size(799, 255);
            this.dataGridViewdoktor.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.dataGridViewsekreter);
            this.groupBox4.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.groupBox4.Location = new System.Drawing.Point(455, 344);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(805, 283);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sekreterler";
            // 
            // dataGridViewsekreter
            // 
            this.dataGridViewsekreter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewsekreter.BackgroundColor = System.Drawing.Color.Cyan;
            this.dataGridViewsekreter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewsekreter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewsekreter.Location = new System.Drawing.Point(3, 25);
            this.dataGridViewsekreter.Name = "dataGridViewsekreter";
            this.dataGridViewsekreter.Size = new System.Drawing.Size(799, 255);
            this.dataGridViewsekreter.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hızlıErişimToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem,
            this.iletişimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1304, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hızlıErişimToolStripMenuItem
            // 
            this.hızlıErişimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.branşEkleToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.hızlıErişimToolStripMenuItem.Name = "hızlıErişimToolStripMenuItem";
            this.hızlıErişimToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.hızlıErişimToolStripMenuItem.Text = "Hızlı Erişim";
            // 
            // branşEkleToolStripMenuItem
            // 
            this.branşEkleToolStripMenuItem.Name = "branşEkleToolStripMenuItem";
            this.branşEkleToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.branşEkleToolStripMenuItem.Text = "Branş Ekle";
            this.branşEkleToolStripMenuItem.Click += new System.EventHandler(this.branşEkleToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.branşEkleToolStripMenuItem1,
            this.çıkışToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 48);
            // 
            // branşEkleToolStripMenuItem1
            // 
            this.branşEkleToolStripMenuItem1.Name = "branşEkleToolStripMenuItem1";
            this.branşEkleToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.branşEkleToolStripMenuItem1.Text = "Branş Ekle";
            this.branşEkleToolStripMenuItem1.Click += new System.EventHandler(this.branşEkleToolStripMenuItem1_Click);
            // 
            // çıkışToolStripMenuItem1
            // 
            this.çıkışToolStripMenuItem1.Name = "çıkışToolStripMenuItem1";
            this.çıkışToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.çıkışToolStripMenuItem1.Text = "Çıkış";
            this.çıkışToolStripMenuItem1.Click += new System.EventHandler(this.çıkışToolStripMenuItem1_Click);
            // 
            // FrmYoneticiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1304, 645);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.BurlyWood;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmYoneticiPanel";
            this.Text = "Yönetici Paneli";
            this.Load += new System.EventHandler(this.FrmYoneticiPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdoktor)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsekreter)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblYoneticiID;
        private System.Windows.Forms.Label lblYoneticiAdSoyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblYoneticiTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIstatistikler;
        private System.Windows.Forms.Button btnYoneticiEkle;
        private System.Windows.Forms.Button btnDoktorEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGrafikler;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewdoktor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewsekreter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hızlıErişimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem branşEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem branşEkleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem1;
    }
}