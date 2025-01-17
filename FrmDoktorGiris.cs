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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Doktorlar where DoktorTc=@tc and DoktorSifre=@sifre", bgl.baglanti());
            komut.Parameters.AddWithValue("@tc", DoktorTcMasekdtxt.Text);
            komut.Parameters.AddWithValue("@sifre", DoktorSifretxt.Text);
            SqlDataReader okuyucu = komut.ExecuteReader();
            if (okuyucu.Read())
            {
                FrmDoktorDetay fr = new FrmDoktorDetay();
                fr.doktorTc = DoktorTcMasekdtxt.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Şifre & Tc No Lütfen Tekrar Deneyiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DoktorTcMasekdtxt.Text = "";
                DoktorSifretxt.Text = "";
            }
        }
    }
}
