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
            cbJk.Text = "";
        }
        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Karyawan";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds,"Karyawan");
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
            resetdata();
            showdata();
            cbJk.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void bttambah_Click(object sender, EventArgs e)
        {
            if (tbid.Text == "" | tbnama.Text == "" | tbgaji.Text == ""| cbJk.Text =="" | tbalamat.Text == "" | tbnmrtlp.Text == "" )
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
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Karyawan values ('" + tbid.Text + "','" + tbnama.Text + "','" + cbJk.Text + "','" +
                                tbalamat.Text + "','" + int.Parse(tbnmrtlp.Text) + "','" + int.Parse(tbgaji.Text) + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();

        berhenti:
            ;
        }

        private void btupdate_Click(object sender, EventArgs e)
        {

          if (tbid.Text == "" | tbnama.Text == "" | tbgaji.Text == "" | tbalamat.Text == "" | tbnmrtlp.Text == "" )
             {
                 MessageBox.Show("Missing Information");
                 goto berhenti;
             }
                 con.Open();
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = con;
                 cmd.CommandType = CommandType.Text;
                 cmd.CommandText = "update Karyawan set nama_karyawan = '" + tbnama.Text + "', jk_karyawan='" + cbJk.SelectedItem + "', alamat_karyawan='" +
                        tbalamat.Text + "', telp_karyawan = '" + int.Parse(tbnmrtlp.Text) + "', gaji='" + int.Parse(tbgaji.Text) + "' where id_karyawan='" + tbid.Text + "'";
                 cmd.ExecuteNonQuery();
                 MessageBox.Show("Karyawan Updated Successfully");
                 con.Close();
                 showdata();
                 resetdata();
                berhenti:;
          
        }

        private void bthapus_Click(object sender, EventArgs e)
        {
            if (tbid.Text == "")
            {
                 MessageBox.Show("Pilih Id untuk Delete","Warning!");
                 goto berhenti;
            }
            int telp = Convert.ToInt32(tbnmrtlp.Text);
                con.Open();
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = con;
                 cmd.CommandType = CommandType.Text;
                 cmd.CommandText = "delete from Karyawan where id_karyawan='" + tbid.Text + "'";
                 cmd.ExecuteNonQuery();
                 MessageBox.Show("Karyawan Deleted Successfully");
                 con.Close();
                 showdata();
                 resetdata();
              berhenti:;
         }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbJk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbid_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbgaji_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tbalamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbnmrtlp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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
            printer.PrintDataGridView(dgvkaryawan);
        }
    }
}
