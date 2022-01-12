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
    public partial class toko : Form
    {
        public toko()
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
            cmd.CommandText = "select * from Penyewa";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Penyewa");
            dgvtoko.DataSource = ds;
            dgvtoko.DataMember = "Penyewa";
            dgvtoko.ReadOnly = true;
        }
        private void resetdata()
        {
            tbid.Text = "";
            tbalamat.Text = "";
            tbharga.Text = "";
            tbalamat.Text = "";
        }
        private void btback_Click(object sender, EventArgs e)
        {
            dasboard db = new dasboard();
            db.Show();
            this.Close();
        }

        private void dgvtoko_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toko_Load(object sender, EventArgs e)
        {

        }
    }
}
