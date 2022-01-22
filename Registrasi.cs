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
    public partial class Registrasi : Form
    {
        public Registrasi()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection
        (@"Data Source = LAPTOP-0EV4K4D6\SQLEXPRESS01;Initial Catalog=SupermarketMS;Integrated Security=True");

        private void resetdata()
        {
            txtUser.Text = "";
            txtPaswd.Text = "";
        }
        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from admin";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds,"admin");
            dgvReg.DataSource = ds;
            dgvReg.DataMember = "admin";
            dgvReg.ReadOnly = true;
        } 
        private string CaesarCipher(string value, int shift)
        {
            string[] joinCipher = new string[200];
            string joinText = "";
            string[] wordArray = value.Split(' ');
            try
            {
                for(int x = 0; x < wordArray.Length; x++)
                {
                    char[] buffer = wordArray[x].ToCharArray();
                    for(int i = 0; i < buffer.Length; i++)
                    {
                        char letter = buffer[i];
                        letter = (char)(letter + shift);

                        if (letter > 'z')
                        {
                            letter = (char)(letter - 26);
                        }
                        else if (letter < 'a')
                        {
                            letter = (char)(letter + 26);
                        }
                        buffer[i] = letter;
                    }
                    string HasilKonversi = new string(buffer);
                    joinCipher[x] = HasilKonversi;
                }
                joinText = string.Join(" ", joinCipher);
                return joinText;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" | txtPaswd.Text== "")
            {
                MessageBox.Show("Semua data harus diisi", "Warning!");
                goto berhenti;
            }
            string tekscipher = null;
            tekscipher = CaesarCipher(txtPaswd.Text, 17);

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into admin values ('" + txtUser.Text + "','" +
                tekscipher + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();
        berhenti:;
        }
        private void Registrasi_Load(object sender, EventArgs e)
        {
            resetdata();
            showdata();
        }
        private void txtPaswd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToLower());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Isi user id yang akan dihapus");
                goto berhenti;
            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from admin where userId ='" + txtUser.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();
        berhenti:;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login masuk = new login();
            masuk.Show();
            this.Close();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Close();
        }
    }
}
