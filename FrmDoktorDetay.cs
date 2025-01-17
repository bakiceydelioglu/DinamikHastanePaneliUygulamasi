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

namespace Hastane
{
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        public string doktorTc;
        SqlBaglanti bgl = new SqlBaglanti();

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            lblDoktorTc.Text = doktorTc;
            SqlCommand komut = new SqlCommand("Select DoktorId, DoktorAdSoyad,DoktorCinsiyet,DoktorTelefon,DoktorBrans From Tbl_Doktorlar where DoktorTc=@tc", bgl.baglanti());
            komut.Parameters.AddWithValue("@tc", doktorTc);
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                lblDoktorID.Text = okuyucu[0].ToString();
                lblDoktorAdSoyad.Text = okuyucu[1].ToString();
                lblDoktorCinsiyet.Text = okuyucu[2].ToString();
                lblDoktorTel.Text = okuyucu[3].ToString();
                lblDoktorBrans.Text = okuyucu[4].ToString();
            }
            bgl.baglanti().Close();

            
            

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_randevular ", bgl.baglanti());
            
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Sikayettxt.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void duyurularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm = new FrmDuyurular();
            frm.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSekreterEkle frm = new FrmSekreterEkle();
            frm.Show();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSekreterGuncelle frm = new FrmSekreterGuncelle();
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

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSekreterEkle frm = new FrmSekreterEkle();
            frm.Show();
        }

        private void güncelleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSekreterGuncelle frm = new FrmSekreterGuncelle();
            frm.Show();
        }

        private void duyurularToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm = new FrmDuyurular();
            frm.Show();
        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
