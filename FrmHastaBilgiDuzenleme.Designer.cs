namespace Hastane
{
    partial class FrmHastaBilgiDuzenleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaBilgiDuzenleme));
            this.button1 = new System.Windows.Forms.Button();
            this.onaylıyorumradio = new System.Windows.Forms.RadioButton();
            this.HastaSifreTekrartxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.HastaCinsiyetcomboBox = new System.Windows.Forms.ComboBox();
            this.HastaTelMaskedTxt = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HastaAdSoyadtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HastaSifretxt = new System.Windows.Forms.TextBox();
            this.HastaTcMasekdtxt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(242, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // onaylıyorumradio
            // 
            this.onaylıyorumradio.AutoSize = true;
            this.onaylıyorumradio.BackColor = System.Drawing.Color.Transparent;
            this.onaylıyorumradio.Location = new System.Drawing.Point(226, 282);
            this.onaylıyorumradio.Name = "onaylıyorumradio";
            this.onaylıyorumradio.Size = new System.Drawing.Size(137, 27);
            this.onaylıyorumradio.TabIndex = 7;
            this.onaylıyorumradio.TabStop = true;
            this.onaylıyorumradio.Text = "Onaylıyorum";
            this.onaylıyorumradio.UseVisualStyleBackColor = false;
            this.onaylıyorumradio.CheckedChanged += new System.EventHandler(this.onaylıyorumradio_CheckedChanged);
            // 
            // HastaSifreTekrartxt
            // 
            this.HastaSifreTekrartxt.Location = new System.Drawing.Point(191, 234);
            this.HastaSifreTekrartxt.Name = "HastaSifreTekrartxt";
            this.HastaSifreTekrartxt.Size = new System.Drawing.Size(172, 31);
            this.HastaSifreTekrartxt.TabIndex = 6;
            this.HastaSifreTekrartxt.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(67, 234);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "Şifre(Tekrar):";
            // 
            // HastaCinsiyetcomboBox
            // 
            this.HastaCinsiyetcomboBox.FormattingEnabled = true;
            this.HastaCinsiyetcomboBox.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.HastaCinsiyetcomboBox.Location = new System.Drawing.Point(191, 149);
            this.HastaCinsiyetcomboBox.Name = "HastaCinsiyetcomboBox";
            this.HastaCinsiyetcomboBox.Size = new System.Drawing.Size(172, 31);
            this.HastaCinsiyetcomboBox.TabIndex = 4;
            // 
            // HastaTelMaskedTxt
            // 
            this.HastaTelMaskedTxt.Location = new System.Drawing.Point(194, 106);
            this.HastaTelMaskedTxt.Mask = "(999) 000-0000";
            this.HastaTelMaskedTxt.Name = "HastaTelMaskedTxt";
            this.HastaTelMaskedTxt.Size = new System.Drawing.Size(169, 31);
            this.HastaTelMaskedTxt.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(52, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Hasta Cinsiyet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(59, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Hasta Telefon:";
            // 
            // HastaAdSoyadtxt
            // 
            this.HastaAdSoyadtxt.Location = new System.Drawing.Point(194, 21);
            this.HastaAdSoyadtxt.Name = "HastaAdSoyadtxt";
            this.HastaAdSoyadtxt.Size = new System.Drawing.Size(169, 31);
            this.HastaAdSoyadtxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(44, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Hasta Ad Soyad:";
            // 
            // HastaSifretxt
            // 
            this.HastaSifretxt.Location = new System.Drawing.Point(191, 195);
            this.HastaSifretxt.Name = "HastaSifretxt";
            this.HastaSifretxt.Size = new System.Drawing.Size(172, 31);
            this.HastaSifretxt.TabIndex = 5;
            // 
            // HastaTcMasekdtxt
            // 
            this.HastaTcMasekdtxt.Location = new System.Drawing.Point(194, 63);
            this.HastaTcMasekdtxt.Mask = "00000000000";
            this.HastaTcMasekdtxt.Name = "HastaTcMasekdtxt";
            this.HastaTcMasekdtxt.Size = new System.Drawing.Size(169, 31);
            this.HastaTcMasekdtxt.TabIndex = 2;
            this.HastaTcMasekdtxt.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(131, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(62, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "T.C. Kimlik No:";
            // 
            // FrmHastaBilgiDuzenleme
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = global::Hastane.Properties.Resources.zoom_interview_background_fixed_9;
            this.ClientSize = new System.Drawing.Size(435, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.onaylıyorumradio);
            this.Controls.Add(this.HastaSifreTekrartxt);
            this.Controls.Add(this.label7);
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
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaBilgiDuzenleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hasta Bilgi Düzenleme Paneli";
            this.Load += new System.EventHandler(this.FrmHastaBilgiDuzenleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton onaylıyorumradio;
        private System.Windows.Forms.TextBox HastaSifreTekrartxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox HastaCinsiyetcomboBox;
        private System.Windows.Forms.MaskedTextBox HastaTelMaskedTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HastaAdSoyadtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HastaSifretxt;
        private System.Windows.Forms.MaskedTextBox HastaTcMasekdtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}