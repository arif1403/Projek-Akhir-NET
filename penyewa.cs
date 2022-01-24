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
using DGVPrinterHelper;

namespace projekakhir
{
    public partial class penyewa : Form
    {
        public penyewa()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection
      (@"Data Source =LAPTOP-3MGL4NVJ\SQLEXPRESS;Initial Catalog=SupermarketMS;Integrated Security=True");
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
            tblamasewa.Text = "";
            tbalamat.Text = "";
            tbnama.Text = "";
            
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
            showdata();
            resetdata();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            if (tbid.Text == ""|tbnama.Text==""|tbharga.Text==""|tbharga.Text==""|tblamasewa.Text=="")
            {
                MessageBox.Show("Isi id toko yang akan dihapus");
                goto berhenti;
            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Penyewa values ('" + tbid.Text + "','"+tbnama.Text+"', '" + tbalamat.Text + "', '" + 
                               int.Parse(tbharga.Text) + "', '" + int.Parse(tblamasewa.Text) + "')";
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
            cmd.CommandText = "update Penyewa set penyewa_name = '" + tbnama.Text + "', alamat_penyewa='" + tbalamat.Text +
                        "', harga_sewa = '" + int.Parse(tbharga.Text) + "', lama_sewa='" + int.Parse(tblamasewa.Text) + 
                        "' where penyewa_id='" + tbid.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update data Penyewa Successfully");
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
            cmd.CommandText = " select * from Penyewa where penyewa_id like '%" + tbcari.Text + "%'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Penyewa");
            dgvtoko.DataSource = ds;
            dgvtoko.DataMember = "Penyewa";
            dgvtoko.ReadOnly = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Data Penyewa";
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.Footer = "Terimakasih";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvtoko);
        }

        private void btnBarang_Click(object sender, EventArgs e)
        {
            barang brg = new barang();
            brg.Show();
        }
    }
}
