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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            
            SqlCommand grafik1 = new SqlCommand("Select DoktorBrans,count(*) from Tbl_Doktorlar Group by DoktorBrans", bgl.baglanti());
            SqlDataReader okuyucu1 = grafik1.ExecuteReader();
            while (okuyucu1.Read())
            {
                chart1.Series["Doktorlar"].Points.AddXY(okuyucu1[0], okuyucu1[1]);
            }
            bgl.baglanti().Close();

            
            SqlCommand grafik2 = new SqlCommand("Select SekreterCinsiyet,count(*) from Tbl_Sekreterler Group by SekreterCinsiyet", bgl.baglanti());
            SqlDataReader okuyucu2 = grafik2.ExecuteReader();
            while (okuyucu2.Read())
            {
                chart2.Series["Sekreterler"].Points.AddXY(okuyucu2[0], okuyucu2[1]);
            }
            bgl.baglanti().Close();

            SqlCommand grafik3 = new SqlCommand("Select HastaCinsiyet,count(*) from Tbl_Hastalar Group by HastaCinsiyet", bgl.baglanti());
            SqlDataReader okuyucu3 = grafik3.ExecuteReader();
            while (okuyucu3.Read())
            {
                chart3.Series["Hastalar"].Points.AddXY(okuyucu3[0], okuyucu3[1]);
            }
            bgl.baglanti().Close();
        }
    }
}
