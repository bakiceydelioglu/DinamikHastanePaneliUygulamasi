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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Sekreterler where SekreterTc=@tc and SekreterSifre=@sifre", bgl.baglanti());
            komut.Parameters.AddWithValue("@tc", SekreterTcMasekdtxt.Text);
            komut.Parameters.AddWithValue("@sifre", SekreterSifretxt.Text);
            SqlDataReader okuyucu = komut.ExecuteReader();
            if (okuyucu.Read())
            {
                FrmSekreterDetay fr = new FrmSekreterDetay();
                fr.sekreterTc = SekreterTcMasekdtxt.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Şifre & Tc No Lütfen Tekrar Deneyiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SekreterTcMasekdtxt.Text = "";
               SekreterSifretxt.Text = "";
            }
        }
    }
}
