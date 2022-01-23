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
            this.Close();
        }

        private void manajemenToko_Click(object sender, EventArgs e)
        {

        }

        private void menupenjualan_Click(object sender, EventArgs e)
        {
            //mPenjualan form_penjualan = new mPenjualan();
            //form_penjualan.Show();
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

        private void menustok_Click(object sender, EventArgs e)
        {
            /*stock_management db = new stock_management();
            db.Show();
            this.Close();*/
        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaksi trans = new Transaksi();
            trans.Show();
            this.Close();
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mStore mPenjualan = new mStore();
            mPenjualan.Show();
            this.Close();
        }

        private void dasboard_Load(object sender, EventArgs e)
        {

        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier sp = new Supplier();
            sp.Show();
            this.Hide();
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barang brg = new barang();
            brg.Show();
            this.Hide();
        }

        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mStore toko =new mStore();
            toko.Show();
            this.Hide();
        }

        private void penyewaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            penyewa form_toko = new penyewa();
            form_toko.Show();
            this.Close();
        }
    }
}
