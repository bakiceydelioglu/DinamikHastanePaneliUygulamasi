using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnDoktor_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris fr = new FrmDoktorGiris();
            fr.Show();
            this.Hide();
        }

        private void btnSekreter_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris fr = new FrmSekreterGiris();
            fr.Show();
            this.Hide();
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            FrmHastaGirisPaneli fr = new FrmHastaGirisPaneli();
            fr.Show();
            this.Hide();
        }

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            FrmYoneticiGiris fr = new FrmYoneticiGiris();
            fr.Show();
            this.Hide();
        }
    }
}
