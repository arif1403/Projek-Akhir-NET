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
    public partial class Mkaryawan : Form
    {
        public Mkaryawan()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection
        (@"Data Source = LAPTOP-3MGL4NVJ\SQLEXPRESS;Initial Catalog=SupermarketMS;Integrated Security=True");
        private void resetdata()
        {
            tbid.Text = "";
            tbnama.Text = "";
            tbgaji.Text = "";
            tbalamat.Text = "";
            tbnmrtlp.Text = "";
            tbpekerjaan.Text = "";
        }
        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Karyawan";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            dgvkaryawan.DataSource = ds;
            dgvkaryawan.DataMember = "Karyawan";
            dgvkaryawan.ReadOnly = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dasboard db = new dasboard();
            db.Show();
            this.Close();
        }

        private void Mkaryawan_Load(object sender, EventArgs e)
        {

        }

        private void bttambah_Click(object sender, EventArgs e)
        {
            if (tbid.Text == "" | tbnama.Text == "" | tbgaji.Text == "" | tbalamat.Text == "" | tbnmrtlp.Text == "" | tbpekerjaan.Text == "" )
            //gunakan OR untuk argumen membandingkan
            {
                MessageBox.Show("Semua data harus diisi", "Peringatan");
                goto berhenti;
            }

            int num;
            //buat variabel num
            bool isNum = int.TryParse(tbgaji.Text.ToString(), out num);
            //membuat variabel is Num dan kemudian isi dari variabel isNum itu sendiri
            //mengubah type data dan menyimpan hasilnya pada variabel num

            if (!isNum)
            //mengecek nilai isNum false
            //( karena bukan number melainkan alfabet
            {
                MessageBox.Show("Gaji harus angka", "Peringatan");
                goto berhenti;
            }

            con.Open();
            //membuka koneksi

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Karyawan values('" + tbid.Text + "','" + tbnama.Text + "','" + int.Parse(tbgaji.Text) +
                "','" + tbalamat.Text + "','" + tbnmrtlp.Text + "','" + tbpekerjaan.Text + "')";
            cmd.ExecuteNonQuery();
            //mengisi perintah SQL dengan Insert data ke dalam table customer
            //cmd.ExecuteNonQuery();
            //execute ( jalankan perintah )
            con.Close();
            showdata();
            resetdata();
        //panggil procedur untuk refresh data

        berhenti:
            ;
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbid.Text == "" | tbnama.Text == "" | tbgaji.Text == "" | tbalamat.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Karyawan set nama_karyawan = '" + tbnama.Text + "', jk_karyawan='" + tbpekerjaan.Text + "', alamat_karyawan='" +
                        tbalamat.Text + "', telp_karyawan = " + tbnmrtlp.Text + "', gaji='" + int.Parse(tbgaji.Text) + " where id_karyawan='" + tbid.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Karyawan Updated Successfully");
                    con.Close();
                    showdata();
                    resetdata();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bthapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbid.Text == "")
                {
                    MessageBox.Show("Select The Category to Delete");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from Karyawan where CatId=" + tbid.Text + "";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Karyawan Deleted Successfully");
                    con.Close();
                    showdata();
                    resetdata();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
    }
}
