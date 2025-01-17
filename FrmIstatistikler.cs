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
    public partial class FrmIstatistikler : Form
    {
        public FrmIstatistikler()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        private void FrmIstatistikler_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select count(*) from Tbl_Doktorlar where DoktorCinsiyet = 'Erkek' ", bgl.baglanti());
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                lblerkekdoktor.Text = okuyucu[0].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut1 = new SqlCommand("select count(*) from Tbl_Doktorlar where DoktorCinsiyet = 'Kadın' ", bgl.baglanti());
            SqlDataReader okuyucu1 = komut1.ExecuteReader();
            while (okuyucu1.Read())
            {
                lblkadindoktor.Text = okuyucu1[0].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("select count(*) from Tbl_Sekreterler where SekreterCinsiyet = 'Erkek' ", bgl.baglanti());
            SqlDataReader okuyucu2 = komut2.ExecuteReader();
            while (okuyucu2.Read())
            {
                lblsekretersayisierkek.Text = okuyucu2[0].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut3 = new SqlCommand("select count(*) from Tbl_Sekreterler where SekreterCinsiyet = 'Kadın' ", bgl.baglanti());
            SqlDataReader okuyucu3 = komut3.ExecuteReader();
            while (okuyucu3.Read())
            {
                lblkadinsekretersayisi.Text = okuyucu3[0].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut4 = new SqlCommand("select count(*) from Tbl_Branslar  ", bgl.baglanti());
            SqlDataReader okuyucu4 = komut4.ExecuteReader();
            while (okuyucu4.Read())
            {
                lblbranssayisi.Text = okuyucu4[0].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut5 = new SqlCommand("select count(*) from Tbl_Hastalar  ", bgl.baglanti());
            SqlDataReader okuyucu5 = komut5.ExecuteReader();
            while (okuyucu5.Read())
            {
                lblhastasayisi.Text = okuyucu5[0].ToString();
            }
            bgl.baglanti().Close();







        }
    }
}
