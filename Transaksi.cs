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
    public partial class Transaksi : Form
    {
        public Transaksi()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection
       (@"Data Source =LAPTOP-3MGL4NVJ\SQLEXPRESS;Initial Catalog=SupermarketMS;Integrated Security=True");
        
        private void resetdata()
        {
            
            tbIdTrans.Text = "";
            tbIdToko.Text = "";
            tbIdPenyewa.Text = "";
            tbHarga.Text = "";
            dateTimePicker1.Text = "";
            tbBrng.Text = "";
            tbKaryawan.Text = "";
            

        }
        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Transaksi";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Transaksi");
            dgvTransaksi.DataSource = ds;
            dgvTransaksi.DataMember = "Transaksi";
            dgvTransaksi.ReadOnly = true;

        }
       
        private void Transaksi_Load(object sender, EventArgs e)
        {
            showdata();
            resetdata();
            //textBox1.Text = DateTime.Now.ToString("dd/MM/yyyy");
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dasboard dsb = new dasboard();
            dsb.Show();
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (tbIdTrans.Text == "" | tbIdToko.Text == "" | tbIdPenyewa.Text == "" | tbHarga.Text == "" |tbBrng.Text ==""|tbKaryawan.Text == ""|dateTimePicker1.Text=="")
            //gunakan OR untuk argumen membandingkan
            {
                MessageBox.Show("Semua data harus diisi", "Peringatan");
                goto berhenti;
            }

            int num;
            //buat variabel num
            bool isNum = int.TryParse(tbHarga.Text.ToString(), out num);
            //membuat variabel is Num dan kemudian isi dari variabel isNum itu sendiri
            //mengubah type data dan menyimpan hasilnya pada variabel num

            if (!isNum)
            //mengecek nilai isNum false
            //( karena bukan number melainkan alfabet
            {
                MessageBox.Show("Nilai harga harus angka", "Peringatan");
                goto berhenti;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Transaksi values ('" + tbIdTrans.Text + "','" + tbIdToko.Text + "','" + tbIdPenyewa.Text + "','" + int.Parse(tbHarga.Text) +
               "','" + tbBrng.Text+ "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss.fffffffK") + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();

        berhenti:
            ;
    }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (tbIdToko.Text == "")
            {
                MessageBox.Show("Pilih Id Toko untuk Delete", "Warning!");
                goto berhenti;
            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Transaksi where store_id='" + tbIdToko.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Transaksi Penyewaan Berhasil Dihapus");
            con.Close();
            showdata();
            resetdata();
        berhenti:;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbIdTrans.Text == "" | tbIdToko.Text == "" | tbIdPenyewa.Text == "" | tbHarga.Text == "" |tbBrng.Text == "")
            {
                MessageBox.Show("Missing Information");
                goto berhenti;
            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Transaksi set id_transaksi = '" + tbIdTrans.Text + "', penyewa_id='" +
                   tbIdPenyewa.Text + "', harga = '" + int.Parse(tbHarga.Text) + "', id_barang = '" + tbBrng.Text +
                   "', tgl_sewa='" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss.fffffffK") + "' where store_id='" + tbIdToko.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Transaksi Berhasil Diedit");
            con.Close();
            showdata();
            resetdata();
        berhenti:;
        }
    }
}
