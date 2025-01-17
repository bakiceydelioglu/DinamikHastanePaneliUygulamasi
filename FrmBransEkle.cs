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
    public partial class FrmBransEkle : Form
    {
        public FrmBransEkle()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        private void button1_Click(object sender, EventArgs e)
        {
           SqlCommand komut = new SqlCommand("insert into tbl_branslar (bransAd) values (@brans)", bgl.baglanti());
           komut.Parameters.AddWithValue("@brans", BRANSADTXT.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Başarıyla Eklenmiştir", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
           


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete FROM tbl_branslar where BransId=@id", bgl.baglanti());
            komut.Parameters.AddWithValue("@id", textBoxbransID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Başarıyla Silinmiştir", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void FrmBransEkle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneDataSet.Tbl_Branslar' table. You can move, or remove it, as needed.
            this.tbl_BranslarTableAdapter.Fill(this.hastaneDataSet.Tbl_Branslar);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tbl_BranslarTableAdapter.Fill(this.hastaneDataSet.Tbl_Branslar);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBoxbransID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            BRANSADTXT.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }
    }
}
