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
            dgvStore.DataSource = ds;
            dgvStore.DataMember = "Store";
            dgvStore.ReadOnly = true;
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

        private void btsave_Click(object sender, EventArgs e)
        {
            if (tbIdtoko.Text == "" | tbnamatoko.Text == "" | cbStoreType.Text == "" | tbharga.Text == "" | tbalamat.Text == "")
            {
                MessageBox.Show("Semua data harus terisi","Warning!");
                goto berhenti;
            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Store values ('" + tbIdtoko.Text + "','" + tbnamatoko.Text + "', '" + cbStoreType.Text + "', '" +
                               int.Parse(tbharga.Text) + "', '" + tbalamat.Text + "')";
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
            if (tbIdtoko.Text == "")
            {
                MessageBox.Show("Isi id toko yang akan dihapus");
                goto berhenti;
            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Store where store_id = '" + tbIdtoko.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();
            resetdata();

        berhenti:
            ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbIdtoko.Text == "" | tbnamatoko.Text == "" | cbStoreType.Text == "" | tbalamat.Text == "")
            {
                MessageBox.Show("Semua data harus di isi", "peringatan");
                goto berhenti;

            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Store set store_name = '" + tbnamatoko.Text + "', store_type='" + cbStoreType.Text + "', alamat_store='" + tbalamat.Text+
                        "' where store_id='" + tbIdtoko.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update data Penyewa Successfully");
            con.Close();
            showdata();
            resetdata();
            resetdata();

        berhenti:
            ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Data Store";
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.Footer = "Terimakasih";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvStore);
        }
    }
}
