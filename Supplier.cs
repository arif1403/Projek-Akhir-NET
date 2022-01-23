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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection
        (@"Data Source = LAPTOP-3MGL4NVJ\SQLEXPRESS;Initial Catalog=SupermarketMS;Integrated Security = True");
        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Supplier";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Supplier");
            dgvSupplier.DataSource = ds;
            dgvSupplier.DataMember = "Supplier";
            dgvSupplier.ReadOnly = true;
        }
        private void resetdata()
        {
            tbIdSp.Text = "";
            tbNamaSP.Text = "";
            tbAlamat.Text = "";
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "sp_supplier";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter id_supplier = new SqlParameter("id_supplier", SqlDbType.VarChar);
            SqlParameter nama_supplier = new SqlParameter("nama_supplier", SqlDbType.VarChar);
            SqlParameter alamat = new SqlParameter("alamat", SqlDbType.VarChar);

            id_supplier.Value = tbIdSp.Text;
            nama_supplier.Value = tbNamaSP.Text;
            alamat.Value = tbAlamat.Text;

            cmd.Parameters.Add(id_supplier);
            cmd.Parameters.Add(nama_supplier);
            cmd.Parameters.Add(alamat);

            cmd.ExecuteNonQuery();

            con.Close();
            showdata();
            resetdata();
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "sp_ds";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter id_supplier = new SqlParameter("@id_supplier", SqlDbType.VarChar);

            id_supplier.Value = tbIdSp.Text;
            cmd.Parameters.Add(id_supplier);
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
        }
        private void btUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "sp_supplier";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter id_supplier = new SqlParameter("id_supplier", SqlDbType.VarChar);
            SqlParameter nama_supplier = new SqlParameter("@nama_supplier", SqlDbType.VarChar);
            SqlParameter alamat = new SqlParameter("@alamat", SqlDbType.VarChar);

            id_supplier.Value = tbIdSp.Text;
            nama_supplier.Value = tbNamaSP.Text;
            alamat.Value = tbAlamat.Text;

            cmd.Parameters.Add(id_supplier);
            cmd.Parameters.Add(nama_supplier);
            cmd.Parameters.Add(alamat);

            cmd.ExecuteNonQuery();

            con.Close();
            showdata();
            resetdata();
        }
        private void Supplier_Load(object sender, EventArgs e)
        {
            showdata();
            resetdata();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            dasboard dsb = new dasboard();
            dsb.Show();
            this.Close();
        }

    }
}
