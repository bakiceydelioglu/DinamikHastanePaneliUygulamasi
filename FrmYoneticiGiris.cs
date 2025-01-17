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
    public partial class FrmYoneticiGiris : Form
    {
        public FrmYoneticiGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Yonetici where YoneticiTc=@tc and YoneticiSifre=@sifre", bgl.baglanti());
            komut.Parameters.AddWithValue("@tc", YoneticiTcMasekdtxt.Text);
            komut.Parameters.AddWithValue("@sifre", YoneticiSifretxt.Text);
            SqlDataReader okuyucu = komut.ExecuteReader();
            if (okuyucu.Read())
            {
                FrmYoneticiPanel fr = new FrmYoneticiPanel();
                fr.yoneticiTc = YoneticiTcMasekdtxt.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Şifre & Tc No Lütfen Tekrar Deneyiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                YoneticiTcMasekdtxt.Text = "";
                YoneticiSifretxt.Text = "";
            }
        }
    }
}
