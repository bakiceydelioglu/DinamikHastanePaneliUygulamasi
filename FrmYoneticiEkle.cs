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
    public partial class FrmYoneticiEkle : Form
    {
        public FrmYoneticiEkle()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Yonetici(YoneticiAdSoyad,YoneticiTc,YoneticiSifre ) values (@ad,@tc,@sifre)", bgl.baglanti());
            komut.Parameters.AddWithValue("@ad", YoneticiAdSoyadtxt.Text);
            komut.Parameters.AddWithValue("@tc", YoneticiTcMasekdtxt.Text);


            if (YoneticiSifretxt.Text == YoneticiSifreTekrartxt.Text)
            {
                komut.Parameters.AddWithValue("@sifre", YoneticiSifretxt.Text);
                MessageBox.Show("Yönetici Başarıyla Eklenmiştir", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor Lütfen Tekrar Deneyiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                YoneticiSifretxt.Text = "";
                YoneticiSifreTekrartxt.Text = "";
            }
        }

        private void onaylıyorumradio_CheckedChanged(object sender, EventArgs e)
        {
            if (onaylıyorumradio.Checked)
            {
                btnEkle.Enabled = true;
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
            }
        }

        private void FrmYoneticiEkle_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_yonetici ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update tbl_Yonetici set YoneticiAdSoyad=@ad,YoneticiSifre=@sifre , YoneticiTc=@tc where YoneticiId=@id ", bgl.baglanti());
            komut.Parameters.AddWithValue("@ad", YoneticiAdSoyadtxt.Text);
            komut.Parameters.AddWithValue("@tc", YoneticiTcMasekdtxt.Text);
            komut.Parameters.AddWithValue("@id", YoneticiIdtxt.Text);

            if (YoneticiSifretxt.Text == YoneticiSifreTekrartxt.Text)
            {
                komut.Parameters.AddWithValue("@sifre", YoneticiSifretxt.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kaydınız Başarıyla Güncellenmiştir", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor Lütfen Tekrar Deneyiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                YoneticiSifretxt.Text = "";
                YoneticiSifreTekrartxt.Text = "";
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from tbl_Yonetici  where YoneticiId=@id ", bgl.baglanti());
            komut.Parameters.AddWithValue("@id", YoneticiIdtxt.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarıyla Silinmiştir", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            YoneticiIdtxt.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            YoneticiAdSoyadtxt.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            YoneticiTcMasekdtxt.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

        }
    }
}
