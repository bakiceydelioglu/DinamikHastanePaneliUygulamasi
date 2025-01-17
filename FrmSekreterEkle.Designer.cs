namespace Hastane
{
    partial class FrmSekreterEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterEkle));
            this.btnEkle = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.Enabled = false;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Location = new System.Drawing.Point(205, 363);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(121, 39);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // SekreterIdtxt
            // 
            this.SekreterIdtxt.Enabled = false;
            this.SekreterIdtxt.Location = new System.Drawing.Point(205, 24);
            this.SekreterIdtxt.Name = "SekreterIdtxt";
            this.SekreterIdtxt.Size = new System.Drawing.Size(145, 29);
            this.SekreterIdtxt.TabIndex = 70;
            this.SekreterIdtxt.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(45, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 24);
            this.label9.TabIndex = 69;
            this.label9.Text = "Sekreter ID No:";
            // 
            // onaylıyorumradio
            // 
            this.onaylıyorumradio.AutoSize = true;
            this.onaylıyorumradio.BackColor = System.Drawing.Color.Transparent;
            this.onaylıyorumradio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.onaylıyorumradio.Location = new System.Drawing.Point(205, 329);
            this.onaylıyorumradio.Name = "onaylıyorumradio";
            this.onaylıyorumradio.Size = new System.Drawing.Size(144, 28);
            this.onaylıyorumradio.TabIndex = 7;
            this.onaylıyorumradio.TabStop = true;
            this.onaylıyorumradio.Text = "Onaylıyorum";
            this.onaylıyorumradio.UseVisualStyleBackColor = false;
            this.onaylıyorumradio.CheckedChanged += new System.EventHandler(this.onaylıyorumradio_CheckedChanged);
            // 
            // SekreterSifreTekrartxt
            // 
            this.SekreterSifreTekrartxt.Location = new System.Drawing.Point(205, 283);
            this.SekreterSifreTekrartxt.Name = "SekreterSifreTekrartxt";
            this.SekreterSifreTekrartxt.Size = new System.Drawing.Size(145, 29);
            this.SekreterSifreTekrartxt.TabIndex = 6;
            this.SekreterSifreTekrartxt.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(65, 283);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 24);
            this.label7.TabIndex = 65;
            this.label7.Text = "Şifre(Tekrar):";
            // 
            // SekreterCinsiyetcomboBox
            // 
            this.SekreterCinsiyetcomboBox.FormattingEnabled = true;
            this.SekreterCinsiyetcomboBox.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.SekreterCinsiyetcomboBox.Location = new System.Drawing.Point(205, 196);
            this.SekreterCinsiyetcomboBox.Name = "SekreterCinsiyetcomboBox";
            this.SekreterCinsiyetcomboBox.Size = new System.Drawing.Size(145, 32);
            this.SekreterCinsiyetcomboBox.TabIndex = 4;
            // 
            // SekreterTelMaskedTxt
            // 
            this.SekreterTelMaskedTxt.Location = new System.Drawing.Point(205, 153);
            this.SekreterTelMaskedTxt.Mask = "(999) 000-0000";
            this.SekreterTelMaskedTxt.Name = "SekreterTelMaskedTxt";
            this.SekreterTelMaskedTxt.Size = new System.Drawing.Size(145, 29);
            this.SekreterTelMaskedTxt.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(24, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 24);
            this.label5.TabIndex = 62;
            this.label5.Text = "Sekreter Cinsiyet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(26, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 24);
            this.label4.TabIndex = 61;
            this.label4.Text = "Sekreter Telefon:";
            // 
            // SekreterAdSoyadtxt
            // 
            this.SekreterAdSoyadtxt.Location = new System.Drawing.Point(205, 68);
            this.SekreterAdSoyadtxt.Name = "SekreterAdSoyadtxt";
            this.SekreterAdSoyadtxt.Size = new System.Drawing.Size(145, 29);
            this.SekreterAdSoyadtxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(11, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 24);
            this.label3.TabIndex = 59;
            this.label3.Text = "Sekreter Ad Soyad:";
            // 
            // SekreterSifretxt
            // 
            this.SekreterSifretxt.Location = new System.Drawing.Point(205, 240);
            this.SekreterSifretxt.Name = "SekreterSifretxt";
            this.SekreterSifretxt.Size = new System.Drawing.Size(145, 29);
            this.SekreterSifretxt.TabIndex = 5;
            this.SekreterSifretxt.UseSystemPasswordChar = true;
            // 
            // SekreterTcMasekdtxt
            // 
            this.SekreterTcMasekdtxt.Location = new System.Drawing.Point(205, 110);
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
            this.label2.Location = new System.Drawing.Point(139, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 55;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(48, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 56;
            this.label1.Text = "T.C. Kimlik No:";
            // 
            // FrmSekreterEkle
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = global::Hastane.Properties.Resources.zoom_interview_background_fixed_9;
            this.ClientSize = new System.Drawing.Size(417, 433);
            this.Controls.Add(this.btnEkle);
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
            this.Name = "FrmSekreterEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekreter Ekleme Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEkle;
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
    }
}