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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();


        public string sekreterTc;
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            this.dataGridViewdoktorlar.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridViewbranslar.DefaultCellStyle.ForeColor = Color.Black;

            this.tbl_BranslarTableAdapter.Fill(this.hastaneDataSet.Tbl_Branslar);


            lblSekreterTc.Text = sekreterTc;
            SqlCommand komut = new SqlCommand("Select SekreterId, SekreterAdSoyad,SekreterCinsiyet,SekreterTelefon From Tbl_Sekreterler where SekreterTc=@tc", bgl.baglanti());
            komut.Parameters.AddWithValue("@tc", sekreterTc);
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                lblSekreterID.Text = okuyucu[0].ToString();
                lblSekreterAdSoyad.Text = okuyucu[1].ToString();
                lblSekreterCinsiyet.Text = okuyucu[2].ToString();
                lblSekreterTel.Text = okuyucu[3].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar ", bgl.baglanti());
            SqlDataReader okuyucu2 = komut2.ExecuteReader();
            while (okuyucu2.Read())
            {
                comboBoxbrans.Items.Add(okuyucu2[0]);
            }

            

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select DoktorAdSoyad,DoktorCinsiyet,DoktorTelefon,DoktorTc,DoktorBrans from tbl_doktorlar", bgl.baglanti());
            da.Fill(dt);
            dataGridViewdoktorlar.DataSource = dt;


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_randevular (randevutarih,randevusaat,randevubrans,randevudoktor,randevudurum) values (@tarih,@saat,@brans,@doktor,@durum) ", bgl.baglanti());

            komut.Parameters.AddWithValue("@tarih", maskedTextBoxtarih.Text);
            komut.Parameters.AddWithValue("@saat", maskedTextBoxsaat.Text);
            komut.Parameters.AddWithValue("@brans", comboBoxbrans.Text);
            komut.Parameters.AddWithValue("@doktor", comboBoxdoktor.Text);
            if (checkBoxacik.Checked)
            {
                komut.Parameters.AddWithValue("@durum", "Açık");
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
            else if (checkBoxdolu.Checked)
            {
                komut.Parameters.AddWithValue("@durum", "Dolu");
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
            MessageBox.Show("Randevu Başarıyla Oluşturuldu", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void comboBoxbrans_SelectedIndexChanged(object sender, EventArgs e)
        {comboBoxdoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAdSoyad from Tbl_Doktorlar where DoktorBrans=@brans ", bgl.baglanti());
            komut3.Parameters.AddWithValue("@brans",comboBoxbrans.Text);
            SqlDataReader okuyucu3 = komut3.ExecuteReader();
            while (okuyucu3.Read())
            {
                comboBoxdoktor.Items.Add(okuyucu3[0]);
            }
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_duyurular (duyuru) values (@duyuru)",bgl.baglanti());
            komut.Parameters.AddWithValue("@duyuru", richTextBoxDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            richTextBoxDuyuru.Text = "";
        }

        private void randevuListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi fr = new FrmRandevuListesi();
            fr.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Randevular where RandevuId=@id", bgl.baglanti());
            komut.Parameters.AddWithValue("@id", randevuIdtxt.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarıyla Silinmiştir", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void duyurularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm = new FrmDuyurular();
            frm.Show();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu uygulama Bülent Baki CEYDELİOĞLU tarafında geliştirilmiştir", "Hakkımızda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Telefon:+90(555) 077 6826 \n Mail:ceydeliogluiletisim@gmail.com", "İletişim", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void randevuListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi fr = new FrmRandevuListesi();
            fr.Show();
        }

        private void duyurularToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm = new FrmDuyurular();
            frm.Show();
        }
    }
}
