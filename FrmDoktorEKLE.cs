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
    public partial class FrmDoktorEKLE : Form
    {
        public FrmDoktorEKLE()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        private void FrmDoktorEKLE_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneDataSet1.Tbl_Doktorlar' table. You can move, or remove it, as needed.
            this.tbl_DoktorlarTableAdapter.Fill(this.hastaneDataSet1.Tbl_Doktorlar);

            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar ", bgl.baglanti());
            SqlDataReader okuyucu2 = komut2.ExecuteReader();
            while (okuyucu2.Read())
            {
                DoktorBranscomboBox.Items.Add(okuyucu2[0]);
            }
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar(DoktorAdSoyad,DoktorCinsiyet,DoktorTelefon,DoktorTc,DoktorBrans,DoktorSifre ) values (@ad,@cinsiyet,@tel,@tc,@brans,@sifre)", bgl.baglanti());
            komut.Parameters.AddWithValue("@ad", DoktorAdSoyadtxt.Text);
            komut.Parameters.AddWithValue("@cinsiyet", DoktorCinsiyetcomboBox.Text);
            komut.Parameters.AddWithValue("@tel", DoktorTelMaskedTxt.Text);
            komut.Parameters.AddWithValue("@tc", DoktorTcMasekdtxt.Text);
            komut.Parameters.AddWithValue("@brans", DoktorBranscomboBox.Text);

            if (DoktorSifretxt.Text == DoktorSifreTekrartxt.Text)
            {
                komut.Parameters.AddWithValue("@sifre", DoktorSifretxt.Text);
                MessageBox.Show("Doktor Başarıyla Eklenmiştir", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                
            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor Lütfen Tekrar Deneyiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DoktorSifretxt.Text = "";
                DoktorSifreTekrartxt.Text = "";
            }
        }

        private void onaylıyorumradio_CheckedChanged(object sender, EventArgs e)
        {
            if (onaylıyorumradio.Checked)
            {
                btnEkle.Enabled = true;
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
                btnlistele.Enabled = true;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update tbl_Doktorlar set DoktorAdSoyad=@ad,DoktorCinsiyet=@cinsiyet,DoktorTelefon=@tel,DoktorSifre=@sifre,doktortc=@tc,doktorbrans=@brans where DoktorId=@id ", bgl.baglanti());
            komut.Parameters.AddWithValue("@ad", DoktorAdSoyadtxt.Text);
            komut.Parameters.AddWithValue("@cinsiyet", DoktorCinsiyetcomboBox.Text);
            komut.Parameters.AddWithValue("@tel", DoktorTelMaskedTxt.Text);
            komut.Parameters.AddWithValue("@tc", DoktorTcMasekdtxt.Text);
            komut.Parameters.AddWithValue("@brans", DoktorBranscomboBox.Text);
            komut.Parameters.AddWithValue("@id", doktorIdtxt.Text);
            if (DoktorSifretxt.Text == DoktorSifreTekrartxt.Text)
            {
                komut.Parameters.AddWithValue("@sifre", DoktorSifretxt.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kaydınız Başarıyla Güncellenmiştir", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor Lütfen Tekrar Deneyiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Doktorlar where DoktorId=@id",bgl.baglanti());
            komut.Parameters.AddWithValue("@id", doktorIdtxt.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarıyla Silinmiştir", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             int secilen = dataGridView1.SelectedCells[0].RowIndex;
            doktorIdtxt.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            DoktorAdSoyadtxt.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            DoktorCinsiyetcomboBox.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            DoktorTelMaskedTxt.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            DoktorTcMasekdtxt.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            DoktorSifretxt.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            DoktorBranscomboBox.Text=dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            this.tbl_DoktorlarTableAdapter.Fill(this.hastaneDataSet1.Tbl_Doktorlar);

        }
    }
}
