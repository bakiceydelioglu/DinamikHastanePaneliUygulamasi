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
    public partial class FrmHastaGirisPaneli : Form
    {
        public FrmHastaGirisPaneli()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaUyeKayit fr = new FrmHastaUyeKayit();
            fr.Show();
        }


        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Hastalar where HastaTc=@tc and HastaSifre=@sifre ", bgl.baglanti());    
            komut.Parameters.AddWithValue("@tc", HastaTcMasekdtxt.Text);
            komut.Parameters.AddWithValue("@sifre", HastaSifretxt.Text);
            SqlDataReader okuyucu = komut.ExecuteReader();
            if (okuyucu.Read())
            {
                FrmHastaDetay fr = new FrmHastaDetay();
                fr.tc = HastaTcMasekdtxt.Text;
                fr.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı Şifre & Tc No Lütfen Tekrar Deneyiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                HastaSifretxt.Text = "";
                HastaTcMasekdtxt.Text = "";
            }

        }
    }
}
