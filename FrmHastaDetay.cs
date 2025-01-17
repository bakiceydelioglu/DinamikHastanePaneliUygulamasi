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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        SqlBaglanti bgl = new SqlBaglanti();

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView2.DefaultCellStyle.ForeColor = Color.Black;

            //Bilgileri Çekme
            lblHastaTc.Text = tc;
            SqlCommand komut = new SqlCommand("Select HastaId, HastaAdSoyad,HastaCinsiyet,HastaTelefon From Tbl_Hastalar where HastaTc=@tc", bgl.baglanti());
            komut.Parameters.AddWithValue("@tc", lblHastaTc.Text);
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                lblHastaID.Text = okuyucu[0].ToString();
                lblHastaAdSoyad.Text = okuyucu[1].ToString();
                lblHastaCinsiyet.Text = okuyucu[2].ToString();
                lblHastaTel.Text = okuyucu[3].ToString();
            }
            bgl.baglanti().Close();

            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTc="+ tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branşları Çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar ",bgl.baglanti());
            SqlDataReader okuyucu2 = komut2.ExecuteReader();
            while (okuyucu2.Read())
            {
                comboBoxBrans.Items.Add(okuyucu2[0]);
            }

            

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDoktor.Items.Clear();   
            //Doktorları Çekme
            SqlCommand komut3 = new SqlCommand("Select DoktorAdSoyad from Tbl_Doktorlar where DoktorBrans= @brans" , bgl.baglanti());
            komut3.Parameters.AddWithValue("@brans", comboBoxBrans.Text);
            SqlDataReader okuyucu3 = komut3.ExecuteReader();
            while (okuyucu3.Read())
            {
                comboBoxDoktor.Items.Add(okuyucu3[0]);
            }


        }

        private void comboBoxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_randevular where RandevuBrans='"+comboBoxBrans.Text+"'" + "and RandevuDoktor='" + comboBoxDoktor.Text + "'and RandevuDurum='Açık'", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void lnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaBilgiDuzenleme fr = new FrmHastaBilgiDuzenleme();
            fr.tcn = lblHastaTc.Text;
            fr.Show();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            randevuIdtxt.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_randevular set randevudurum=@durum, HastaTc=@tc, sikayet =@sikayet where randevuId=@id",bgl.baglanti());
            komut.Parameters.AddWithValue("@durum", "Dolu");

            komut.Parameters.AddWithValue("@tc",lblHastaTc.Text);
            komut.Parameters.AddWithValue("@sikayet", Sikayettxt.Text);
            komut.Parameters.AddWithValue("@id", randevuIdtxt.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Başarıyla Oluşturuldu", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu uygulama Bülent Baki CEYDELİOĞLU tarafında geliştirilmiştir", "Hakkımızda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Telefon:+90(555) 077 6826 \n Mail:ceydeliogluiletisim@gmail.com", "İletişim", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
