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
            tbBarang.Text = "";
            cbTipe.Text = "";
            cbIdSup.Text = "";
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
            id_supplier.Value = cbIdSup.Text;
            tipe_barang.Value = cbTipe.Text;

            cmd.Parameters.Add(id_barang);
            cmd.Parameters.Add(id_supplier);
            cmd.Parameters.Add(tipe_barang);

            cmd.ExecuteNonQuery() ;

            con.Close();
            showdata();
            resetdata();
        }
        private void btnHapus_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "sp_db";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter id_supplier = new SqlParameter("@id_barang", SqlDbType.VarChar);

            id_supplier.Value = tbBarang.Text;
            cmd.Parameters.Add(id_supplier);
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
        }
        private void btBack_Click(object sender, EventArgs e)
        {
            dasboard dsb = new dasboard();
            dsb.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
            id_supplier.Value = cbIdSup.Text;
            tipe_barang.Value = cbTipe.Text;

            cmd.Parameters.Add(id_barang);
            cmd.Parameters.Add(id_supplier);
            cmd.Parameters.Add(tipe_barang);

            cmd.ExecuteNonQuery();

            con.Close();
            showdata();
            resetdata();
        }

        private void tbSuplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbIdSup_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            cmd2.CommandType = CommandType.StoredProcedure;
            DataSet ds1 = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd2);
            sda.Fill(ds1, "Supplier");
            cbIdSup.DataSource = ds1.Tables["Supplier"];
            cbIdSup.DisplayMember = "id_supplier";
        }
    }
}
