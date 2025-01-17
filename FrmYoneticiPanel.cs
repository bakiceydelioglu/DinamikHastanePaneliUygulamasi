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
    public partial class FrmYoneticiPanel : Form
    {
        public FrmYoneticiPanel()
        {
            InitializeComponent();
        }
        public string yoneticiTc;
        SqlBaglanti bgl = new SqlBaglanti();

        private void FrmYoneticiPanel_Load(object sender, EventArgs e)
        {
            
            lblYoneticiTc.Text = yoneticiTc;
            this.dataGridViewdoktor.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridViewsekreter.DefaultCellStyle.ForeColor = Color.Black;

            SqlCommand komut = new SqlCommand("Select YoneticiId, YoneticiAdSoyad From Tbl_Yonetici where YoneticiTc=@tc", bgl.baglanti());
            komut.Parameters.AddWithValue("@tc", yoneticiTc);
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                lblYoneticiID.Text = okuyucu[0].ToString();
                lblYoneticiAdSoyad.Text = okuyucu[1].ToString();
               
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_Doktorlar ", bgl.baglanti());
            da.Fill(dt);
            dataGridViewdoktor.DataSource = dt;

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from tbl_sekreterler ", bgl.baglanti());
            da1.Fill(dt1);
            dataGridViewsekreter.DataSource = dt1;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void branşEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBransEkle frm = new FrmBransEkle();
            frm.Show();
        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            FrmDoktorEKLE frm = new FrmDoktorEKLE();
            frm.Show();
        }

        private void btnYoneticiEkle_Click(object sender, EventArgs e)
        {
            FrmYoneticiEkle frm = new FrmYoneticiEkle();
            frm.Show();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_Doktorlar ", bgl.baglanti());
            da.Fill(dt);
            dataGridViewdoktor.DataSource = dt;

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from tbl_sekreterler ", bgl.baglanti());
            da1.Fill(dt1);
            dataGridViewsekreter.DataSource = dt1;
        }

        private void btnIstatistikler_Click(object sender, EventArgs e)
        {
            FrmIstatistikler frm = new FrmIstatistikler();
            frm.Show();
        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler frm = new FrmGrafikler();  
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu uygulama Bülent Baki CEYDELİOĞLU tarafında geliştirilmiştir", "Hakkımızda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Telefon:+90(555) 077 6826 \n Mail:ceydeliogluiletisim@gmail.com", "İletişim", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void branşEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBransEkle frm = new FrmBransEkle();
            frm.Show();
        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
