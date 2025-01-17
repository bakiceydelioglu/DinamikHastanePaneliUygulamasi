namespace Hastane
{
    partial class FrmHastaUyeKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaUyeKayit));
            this.HastaSifretxt = new System.Windows.Forms.TextBox();
            this.HastaTcMasekdtxt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HastaAdSoyadtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HastaTelMaskedTxt = new System.Windows.Forms.MaskedTextBox();
            this.HastaCinsiyetcomboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.HastaSifreTekrartxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.onaylıyorumradio = new System.Windows.Forms.RadioButton();
            this.btnkayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HastaSifretxt
            // 
            this.HastaSifretxt.Location = new System.Drawing.Point(150, 269);
            this.HastaSifretxt.Name = "HastaSifretxt";
            this.HastaSifretxt.Size = new System.Drawing.Size(191, 26);
            this.HastaSifretxt.TabIndex = 5;
            this.HastaSifretxt.UseSystemPasswordChar = true;
            // 
            // HastaTcMasekdtxt
            // 
            this.HastaTcMasekdtxt.Location = new System.Drawing.Point(153, 137);
            this.HastaTcMasekdtxt.Mask = "00000000000";
            this.HastaTcMasekdtxt.Name = "HastaTcMasekdtxt";
            this.HastaTcMasekdtxt.Size = new System.Drawing.Size(188, 26);
            this.HastaTcMasekdtxt.TabIndex = 2;
            this.HastaTcMasekdtxt.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(90, 269);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(21, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "T.C. Kimlik No:";
            // 
            // HastaAdSoyadtxt
            // 
            this.HastaAdSoyadtxt.Location = new System.Drawing.Point(153, 95);
            this.HastaAdSoyadtxt.Name = "HastaAdSoyadtxt";
            this.HastaAdSoyadtxt.Size = new System.Drawing.Size(188, 26);
            this.HastaAdSoyadtxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(3, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hasta Ad Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(18, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hasta Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(11, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hasta Cinsiyet:";
            // 
            // HastaTelMaskedTxt
            // 
            this.HastaTelMaskedTxt.Location = new System.Drawing.Point(153, 180);
            this.HastaTelMaskedTxt.Mask = "(999) 000-0000";
            this.HastaTelMaskedTxt.Name = "HastaTelMaskedTxt";
            this.HastaTelMaskedTxt.Size = new System.Drawing.Size(188, 26);
            this.HastaTelMaskedTxt.TabIndex = 3;
            // 
            // HastaCinsiyetcomboBox
            // 
            this.HastaCinsiyetcomboBox.FormattingEnabled = true;
            this.HastaCinsiyetcomboBox.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.HastaCinsiyetcomboBox.Location = new System.Drawing.Point(150, 223);
            this.HastaCinsiyetcomboBox.Name = "HastaCinsiyetcomboBox";
            this.HastaCinsiyetcomboBox.Size = new System.Drawing.Size(191, 28);
            this.HastaCinsiyetcomboBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(344, 46);
            this.label6.TabIndex = 16;
            this.label6.Text = "Hasta Kayıt Paneli";
            // 
            // HastaSifreTekrartxt
            // 
            this.HastaSifreTekrartxt.Location = new System.Drawing.Point(150, 308);
            this.HastaSifreTekrartxt.Name = "HastaSifreTekrartxt";
            this.HastaSifreTekrartxt.Size = new System.Drawing.Size(191, 26);
            this.HastaSifreTekrartxt.TabIndex = 6;
            this.HastaSifreTekrartxt.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(26, 308);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Şifre(Tekrar):";
            // 
            // onaylıyorumradio
            // 
            this.onaylıyorumradio.AutoSize = true;
            this.onaylıyorumradio.BackColor = System.Drawing.Color.Transparent;
            this.onaylıyorumradio.Location = new System.Drawing.Point(217, 349);
            this.onaylıyorumradio.Name = "onaylıyorumradio";
            this.onaylıyorumradio.Size = new System.Drawing.Size(124, 24);
            this.onaylıyorumradio.TabIndex = 7;
            this.onaylıyorumradio.TabStop = true;
            this.onaylıyorumradio.Text = "Onaylıyorum";
            this.onaylıyorumradio.UseVisualStyleBackColor = false;
            this.onaylıyorumradio.CheckedChanged += new System.EventHandler(this.onaylıyorumradio_CheckedChanged);
            // 
            // btnkayit
            // 
            this.btnkayit.BackColor = System.Drawing.Color.Transparent;
            this.btnkayit.Enabled = false;
            this.btnkayit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnkayit.Location = new System.Drawing.Point(217, 379);
            this.btnkayit.Name = "btnkayit";
            this.btnkayit.Size = new System.Drawing.Size(121, 39);
            this.btnkayit.TabIndex = 8;
            this.btnkayit.Text = "Kayıt Ol";
            this.btnkayit.UseVisualStyleBackColor = false;
            this.btnkayit.Click += new System.EventHandler(this.btnkayit_Click);
            // 
            // FrmHastaUyeKayit
            // 
            this.AcceptButton = this.btnkayit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = global::Hastane.Properties.Resources.zoom_interview_background_fixed_9;
            this.ClientSize = new System.Drawing.Size(408, 432);
            this.Controls.Add(this.btnkayit);
            this.Controls.Add(this.onaylıyorumradio);
            this.Controls.Add(this.HastaSifreTekrartxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HastaCinsiyetcomboBox);
            this.Controls.Add(this.HastaTelMaskedTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HastaAdSoyadtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HastaSifretxt);
            this.Controls.Add(this.HastaTcMasekdtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.BurlyWood;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaUyeKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HastaSifretxt;
        private System.Windows.Forms.MaskedTextBox HastaTcMasekdtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HastaAdSoyadtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox HastaTelMaskedTxt;
        private System.Windows.Forms.ComboBox HastaCinsiyetcomboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox HastaSifreTekrartxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton onaylıyorumradio;
        private System.Windows.Forms.Button btnkayit;
    }
}