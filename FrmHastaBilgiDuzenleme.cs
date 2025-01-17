using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane
{
    public partial class FrmHastaBilgiDuzenleme : Form
    {
        public FrmHastaBilgiDuzenleme()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        
        private void onaylıyorumradio_CheckedChanged(object sender, EventArgs e)
        {
            if (onaylıyorumradio.Checked)
            {
                button1.Enabled = true;
            }
        }
        public string tcn;
        private void FrmHastaBilgiDuzenleme_Load(object sender, EventArgs e)
        {

            HastaTcMasekdtxt.Text = tcn;
            SqlCommand komut = new SqlCommand("Select  HastaAdSoyad,HastaCinsiyet,HastaTelefon, HastaSifre From Tbl_Hastalar where HastaTc=@tc", bgl.baglanti());
            komut.Parameters.AddWithValue("@tc", tcn);
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                HastaAdSoyadtxt.Text = okuyucu[0].ToString();
                HastaCinsiyetcomboBox.Text = okuyucu[1].ToString();
                HastaTelMaskedTxt.Text = okuyucu[2].ToString();
                HastaSifretxt.Text = okuyucu[3].ToString();
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update tbl_hastalar set HastaAdSoyad=@ad,HastaCinsiyet=@cinsiyet,HastaTelefon=@tel,HastaSifre=@sifre where HastaTc=@tc ", bgl.baglanti());
            komut.Parameters.AddWithValue("@ad", HastaAdSoyadtxt.Text);
            komut.Parameters.AddWithValue("@cinsiyet", HastaCinsiyetcomboBox.Text);
            komut.Parameters.AddWithValue("@tel", HastaTelMaskedTxt.Text);
            komut.Parameters.AddWithValue("@tc", HastaTcMasekdtxt.Text);
            
            if (HastaSifretxt.Text == HastaSifreTekrartxt.Text)
            {
                komut.Parameters.AddWithValue("@sifre", HastaSifretxt.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti() .Close();
                MessageBox.Show("Kaydınız Başarıyla Güncellenmiştir", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor Lütfen Tekrar Deneyiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
           


        }
    }
}
