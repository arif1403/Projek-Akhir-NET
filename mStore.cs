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
    public partial class mStore : Form
    {
        public mStore()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection
       (@"Data Source = LAPTOP-3MGL4NVJ\SQLEXPRESS;Initial Catalog=SupermarketMS;Integrated Security=True");
        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Store";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Store");
            dgvtransaksi.DataSource = ds;
            dgvtransaksi.DataMember = "Store";
            dgvtransaksi.ReadOnly = true;
        }
        private void resetdata()
        {
            tbIdtoko.Text = "";
            tbnamatoko.Text = "";
            cbStoreType.Text = "";
            tbharga.Text = "";
            tbalamat.Text = "";
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
