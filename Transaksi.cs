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

namespace projekakhir
{
    public partial class Transaksi : Form
    {
        public Transaksi()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection
       (@"Data Source = LAPTOP-3MGL4NVJ\SQLEXPRESS;Initial Catalog=SupermarketMS;Integrated Security=True");
        private void resetdata()
        {
            tbIdTrans.Text = "";
            tbIdToko.Text = "";
            tbIdPenyewa.Text = "";
            tbIdBrng.Text = "";
            tbHarga.Text = "";
            dTtgl.Text = "";
        }
        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Transaksi";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Transaksi");
            dgvTransaksi.DataSource = ds;
            dgvTransaksi.DataMember = "Transaksi";
            dgvTransaksi.ReadOnly = true;

        }
        private void Transaksi_Load(object sender, EventArgs e)
        {
            showdata();
            resetdata();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dasboard dsb = new dasboard();
            dsb.Show();
            this.Close();
        }
    }
}
