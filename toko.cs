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

        private void btsave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into penyewa values = ('" + tbid.Text + "', '" + tbalamat.Text + "', '" + tbharga + "', '" + tblamasewa + "', '" + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();
            resetdata();

            berhenti:
            ;
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            if (tbid.Text == "")
            {
                MessageBox.Show("Isi id toko yang akan dihapus");
                goto berhenti;
            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Penyewa where penyewa_id = '" + tbid.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();
            resetdata();

        berhenti:
            ;
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            if (tbid.Text == "" | tbalamat.Text == "" | tblamasewa.Text == "" | tbharga.Text == "")
            {
                MessageBox.Show("Semua data harus di isi", "peringatan");
                goto berhenti;

            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " update customer set id";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();
            resetdata();

            berhenti:
            ;
        }

        private void btcari_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select * from toko where id like '%" + tbcari.Text + "%'" ;
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();
            resetdata();
        }
    }
}
