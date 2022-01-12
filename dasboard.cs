﻿using System;
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
            this.Close();
        }

        private void menulaporanpenjualan_Click(object sender, EventArgs e)
        {
            laporan form_laporan = new laporan();
            form_laporan.Show();
        }

        private void manajemenToko_Click(object sender, EventArgs e)
        {
            toko form_toko = new toko();
            form_toko.Show();
        }

        private void menupenjualan_Click(object sender, EventArgs e)
        {
            mPenjualan form_penjualan = new mPenjualan();
            form_penjualan.Show();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Yakin akan keluar?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void menuitem_Click(object sender, EventArgs e)
        {

        }
    }
}
