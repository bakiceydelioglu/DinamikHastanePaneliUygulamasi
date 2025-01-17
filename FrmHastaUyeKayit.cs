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
    public partial class FrmHastaUyeKayit : Form
    {
        public FrmHastaUyeKayit()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void btnkayit_Click(object sender, EventArgs e)
        {
           
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar(HastaAdSoyad,HastaCinsiyet,HastaTelefon,HastaTc,HastaSifre) values (@ad,@cinsiyet,@tel,@tc,@sifre)", bgl.baglanti());
            komut.Parameters.AddWithValue("@ad", HastaAdSoyadtxt.Text);
            komut.Parameters.AddWithValue("@cinsiyet", HastaCinsiyetcomboBox.Text);
            komut.Parameters.AddWithValue("@tel", HastaTelMaskedTxt.Text);
            komut.Parameters.AddWithValue("@tc", HastaTcMasekdtxt.Text);
            if (HastaSifretxt.Text == HastaSifreTekrartxt.Text)
            {
                komut.Parameters.AddWithValue("@sifre", HastaSifretxt.Text);
                MessageBox.Show("Kaydınız Başarıyla Gerçekleşmiştir", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Şifreler Uyuşmuyor Lütfen Tekrar Deneyiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                HastaSifretxt.Text = "";
                HastaSifreTekrartxt.Text = "";
            }

            
           





        }

        private void onaylıyorumradio_CheckedChanged(object sender, EventArgs e)
        {
            if (onaylıyorumradio.Checked)
            {
                btnkayit.Enabled = true;
            }
        }

       
    }
}
