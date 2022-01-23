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
        (@"Data Source =LAPTOP-PVNKCO56\SQLEXPRESS;Initial Catalog=Supermarket;Integrated Security=True");

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



    }
}
