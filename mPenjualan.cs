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
    public partial class mPenjualan : Form
    {
        public mPenjualan()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection
       (@"Data Source = LAPTOP-0EV4K4D6\SQLEXPRESS01;Initial Catalog=SupermarketMS;Integrated Security=True");
        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Transaksi";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Transaksi");
            dgvtransaksi.DataSource = ds;
            dgvtransaksi.DataMember = "Transaksi";
            dgvtransaksi.ReadOnly = true;
        }
        private void resetdata()
        {
            tbnamakaryawan.Text = "";
            tbnamabarang.Text = "";
            tbidbarang.Text = "";
            tbharga.Text="";
            tbharga.Text = "";
            tbkuantiti.Text = "";
            tbnomortelp.Text = "";
        }
        private void btback_Click(object sender, EventArgs e)
        {
            dasboard db = new dasboard();
            db.Show();
            this.Close();
        }

        private void mPenjualan_Load(object sender, EventArgs e)
        {
            showdata();
            resetdata();
        }
    }
}
