using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekakhir
{
    public partial class dasboard : Form
    {
        public dasboard()
        {
            InitializeComponent();
        }

        private void menukaryawan_Click(object sender, EventArgs e)
        {
            Mkaryawan form_karyawan = new Mkaryawan();
            form_karyawan.Show();
        }

        private void menulaporanpenjualan_Click(object sender, EventArgs e)
        {
            laporan form_laporan = new laporan();
            form_laporan.Show();
        }

        private void manajemenToko_Click(object sender, EventArgs e)
        {
            manajemenToko form_toko = new manajemenToko();
            form_toko.Show();
        }
    }
}
