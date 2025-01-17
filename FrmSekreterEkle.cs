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
    public partial class FrmSekreterEkle : Form
    {
        public FrmSekreterEkle()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Sekreterler(SekreterAdSoyad,SekreterCinsiyet,SekreterTelefon,SekreterTc,SekreterSifre ) values (@ad,@cinsiyet,@tel,@tc,@sifre)", bgl.baglanti());
            komut.Parameters.AddWithValue("@ad", SekreterAdSoyadtxt.Text);
            komut.Parameters.AddWithValue("@cinsiyet", SekreterCinsiyetcomboBox.Text);
            komut.Parameters.AddWithValue("@tel", SekreterTelMaskedTxt.Text);
            komut.Parameters.AddWithValue("@tc", SekreterTcMasekdtxt.Text);
            

            if (SekreterSifretxt.Text == SekreterSifreTekrartxt.Text)
            {
                komut.Parameters.AddWithValue("@sifre", SekreterSifretxt.Text);
                MessageBox.Show("Sekreter Başarıyla Eklenmiştir", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor Lütfen Tekrar Deneyiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SekreterSifretxt.Text = "";
                SekreterSifreTekrartxt.Text = "";
            }
        }

        private void onaylıyorumradio_CheckedChanged(object sender, EventArgs e)
        {
            if (onaylıyorumradio.Checked)
            {
                btnEkle.Enabled = true;
            }
        }
    }
}
