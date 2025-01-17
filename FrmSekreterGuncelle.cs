using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane
{
    public partial class FrmSekreterGuncelle : Form
    {
        public FrmSekreterGuncelle()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update tbl_Sekreterler set SekreterAdSoyad=@ad,SekreterCinsiyet=@cinsiyet,SekreterTelefon=@tel,SekreterSifre=@sifre, SekreterTc=@tc where SekreterId=@id ", bgl.baglanti());
            komut.Parameters.AddWithValue("@ad", SekreterAdSoyadtxt.Text);
            komut.Parameters.AddWithValue("@cinsiyet", SekreterCinsiyetcomboBox.Text);
            komut.Parameters.AddWithValue("@tel", SekreterTelMaskedTxt.Text);
            komut.Parameters.AddWithValue("@tc", SekreterTcMasekdtxt.Text);
            komut.Parameters.AddWithValue("@id", SekreterIdtxt.Text);

            if (SekreterSifretxt.Text == SekreterSifreTekrartxt.Text)
            {
                komut.Parameters.AddWithValue("@sifre", SekreterSifretxt.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kaydınız Başarıyla Güncellenmiştir", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor Lütfen Tekrar Deneyiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            SekreterIdtxt.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            SekreterAdSoyadtxt.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            SekreterCinsiyetcomboBox.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            SekreterTelMaskedTxt.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            SekreterTcMasekdtxt.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            SekreterSifretxt.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void onaylıyorumradio_CheckedChanged(object sender, EventArgs e)
        {
            if (onaylıyorumradio.Checked)
            {
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Sekreterler where SekreterId=@id", bgl.baglanti());
            komut.Parameters.AddWithValue("@id", SekreterIdtxt.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarıyla Silinmiştir", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FrmSekreterGuncelle_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_sekreterler ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
        }
    }
}
