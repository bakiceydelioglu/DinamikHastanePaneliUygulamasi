namespace Hastane
{
    partial class FrmSekreterGuncelle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterGuncelle));
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.SekreterIdtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.onaylıyorumradio = new System.Windows.Forms.RadioButton();
            this.SekreterSifreTekrartxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SekreterCinsiyetcomboBox = new System.Windows.Forms.ComboBox();
            this.SekreterTelMaskedTxt = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SekreterAdSoyadtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SekreterSifretxt = new System.Windows.Forms.TextBox();
            this.SekreterTcMasekdtxt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuncelle.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnGuncelle.Location = new System.Drawing.Point(219, 369);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(121, 39);
            this.btnGuncelle.TabIndex = 87;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // SekreterIdtxt
            // 
            this.SekreterIdtxt.Enabled = false;
            this.SekreterIdtxt.Location = new System.Drawing.Point(209, 20);
            this.SekreterIdtxt.Name = "SekreterIdtxt";
            this.SekreterIdtxt.Size = new System.Drawing.Size(145, 29);
            this.SekreterIdtxt.TabIndex = 86;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label9.Location = new System.Drawing.Point(49, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 24);
            this.label9.TabIndex = 85;
            this.label9.Text = "Sekreter ID No:";
            // 
            // onaylıyorumradio
            // 
            this.onaylıyorumradio.AutoSize = true;
            this.onaylıyorumradio.BackColor = System.Drawing.Color.Transparent;
            this.onaylıyorumradio.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.onaylıyorumradio.Location = new System.Drawing.Point(209, 325);
            this.onaylıyorumradio.Name = "onaylıyorumradio";
            this.onaylıyorumradio.Size = new System.Drawing.Size(145, 28);
            this.onaylıyorumradio.TabIndex = 84;
            this.onaylıyorumradio.TabStop = true;
            this.onaylıyorumradio.Text = "Onaylıyorum";
            this.onaylıyorumradio.UseVisualStyleBackColor = false;
            this.onaylıyorumradio.CheckedChanged += new System.EventHandler(this.onaylıyorumradio_CheckedChanged);
            // 
            // SekreterSifreTekrartxt
            // 
            this.SekreterSifreTekrartxt.Location = new System.Drawing.Point(209, 279);
            this.SekreterSifreTekrartxt.Name = "SekreterSifreTekrartxt";
            this.SekreterSifreTekrartxt.Size = new System.Drawing.Size(145, 29);
            this.SekreterSifreTekrartxt.TabIndex = 6;
            this.SekreterSifreTekrartxt.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label7.Location = new System.Drawing.Point(69, 279);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 24);
            this.label7.TabIndex = 82;
            this.label7.Text = "Şifre(Tekrar):";
            // 
            // SekreterCinsiyetcomboBox
            // 
            this.SekreterCinsiyetcomboBox.FormattingEnabled = true;
            this.SekreterCinsiyetcomboBox.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.SekreterCinsiyetcomboBox.Location = new System.Drawing.Point(209, 192);
            this.SekreterCinsiyetcomboBox.Name = "SekreterCinsiyetcomboBox";
            this.SekreterCinsiyetcomboBox.Size = new System.Drawing.Size(145, 32);
            this.SekreterCinsiyetcomboBox.TabIndex = 4;
            // 
            // SekreterTelMaskedTxt
            // 
            this.SekreterTelMaskedTxt.Location = new System.Drawing.Point(209, 149);
            this.SekreterTelMaskedTxt.Mask = "(999) 000-0000";
            this.SekreterTelMaskedTxt.Name = "SekreterTelMaskedTxt";
            this.SekreterTelMaskedTxt.Size = new System.Drawing.Size(145, 29);
            this.SekreterTelMaskedTxt.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Location = new System.Drawing.Point(28, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 24);
            this.label5.TabIndex = 79;
            this.label5.Text = "Sekreter Cinsiyet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(30, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 24);
            this.label4.TabIndex = 78;
            this.label4.Text = "Sekreter Telefon:";
            // 
            // SekreterAdSoyadtxt
            // 
            this.SekreterAdSoyadtxt.Location = new System.Drawing.Point(209, 64);
            this.SekreterAdSoyadtxt.Name = "SekreterAdSoyadtxt";
            this.SekreterAdSoyadtxt.Size = new System.Drawing.Size(145, 29);
            this.SekreterAdSoyadtxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(15, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 24);
            this.label3.TabIndex = 76;
            this.label3.Text = "Sekreter Ad Soyad:";
            // 
            // SekreterSifretxt
            // 
            this.SekreterSifretxt.Location = new System.Drawing.Point(209, 236);
            this.SekreterSifretxt.Name = "SekreterSifretxt";
            this.SekreterSifretxt.Size = new System.Drawing.Size(145, 29);
            this.SekreterSifretxt.TabIndex = 5;
            this.SekreterSifretxt.UseSystemPasswordChar = true;
            // 
            // SekreterTcMasekdtxt
            // 
            this.SekreterTcMasekdtxt.Location = new System.Drawing.Point(209, 106);
            this.SekreterTcMasekdtxt.Mask = "00000000000";
            this.SekreterTcMasekdtxt.Name = "SekreterTcMasekdtxt";
            this.SekreterTcMasekdtxt.Size = new System.Drawing.Size(145, 29);
            this.SekreterTcMasekdtxt.TabIndex = 2;
            this.SekreterTcMasekdtxt.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(143, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 72;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(52, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 73;
            this.label1.Text = "T.C. Kimlik No:";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.Enabled = false;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSil.Location = new System.Drawing.Point(219, 424);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(121, 39);
            this.btnSil.TabIndex = 88;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkBlue;
            this.dataGridView1.Location = new System.Drawing.Point(405, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(639, 288);
            this.dataGridView1.TabIndex = 89;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // FrmSekreterGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1046, 481);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.SekreterIdtxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.onaylıyorumradio);
            this.Controls.Add(this.SekreterSifreTekrartxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SekreterCinsiyetcomboBox);
            this.Controls.Add(this.SekreterTelMaskedTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SekreterAdSoyadtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SekreterSifretxt);
            this.Controls.Add(this.SekreterTcMasekdtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.BurlyWood;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterGuncelle";
            this.Text = "Sekreter Bilgi Güncelle";
            this.Load += new System.EventHandler(this.FrmSekreterGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox SekreterIdtxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton onaylıyorumradio;
        private System.Windows.Forms.TextBox SekreterSifreTekrartxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox SekreterCinsiyetcomboBox;
        private System.Windows.Forms.MaskedTextBox SekreterTelMaskedTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SekreterAdSoyadtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SekreterSifretxt;
        private System.Windows.Forms.MaskedTextBox SekreterTcMasekdtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}