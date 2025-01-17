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
    public partial class FrmDuyurular : Form
    {
        public FrmDuyurular()
        {
            InitializeComponent();
        }

        private void FrmDuyurular_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneDataSet6.Tbl_Duyurular' table. You can move, or remove it, as needed.
            this.tbl_DuyurularTableAdapter.Fill(this.hastaneDataSet6.Tbl_Duyurular);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

        }
    }
}
