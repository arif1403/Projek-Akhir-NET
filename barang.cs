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
    public partial class barang : Form
    {
        public barang()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection
        (@"Data Source = LAPTOP-3MGL4NVJ\SQLEXPRESS;Initial Catalog=SupermarketMS;Integrated Security=True");

        private void barang_Load(object sender, EventArgs e)
        {
            showdata();
            resetdata();
        }
        private void resetdata()
        {
            tbSuplier.Text = "";
            tbBarang.Text = "";
            tbTipe.Text = "";

        }
        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Barang";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Barang");
            dgvBarang.DataSource = ds;
            dgvBarang.DataMember = "Barang";
            dgvBarang.ReadOnly = true;

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "sp_barang";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter id_barang = new SqlParameter("id_barang", SqlDbType.VarChar);
            SqlParameter id_supplier = new SqlParameter("id_supplier", SqlDbType.VarChar);
            SqlParameter tipe_barang = new SqlParameter("tipe_barang", SqlDbType.VarChar);

            id_barang.Value = tbBarang.Text;
            id_supplier.Value = tbSuplier.Text;
            tipe_barang.Value = tbTipe.Text;

            cmd.Parameters.Add(id_barang);
            cmd.Parameters.Add(id_supplier);
            cmd.Parameters.Add(tipe_barang);

            cmd.ExecuteNonQuery() ;

            con.Close();
            showdata();
            resetdata();
        }
    }
}
