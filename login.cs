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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection
        (@"Data Source = LAPTOP-3MGL4NVJ\SQLEXPRESS;Initial Catalog=SupermarketMS;Integrated Security=True");
        private string CaesarCipher(string value, int shift)
        {
            string[] joinCipher = new string[200];
            string joinText = "";
            string[] wordArray = value.Split(' ');
            try
            {
                for (int x = 0; x < wordArray.Length; x++)
                {
                    char[] buffer = wordArray[x].ToCharArray();
                    for (int i = 0; i < buffer.Length; i++)
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
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }
        private void resetdata()
        {
            tbusername.Text = "";
            tbpassword.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Registrasi reg = new Registrasi();
            reg.Show();
            this.Hide();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            if (tbusername.Text == "" | tbpassword.Text == "")
            {
                MessageBox.Show("semua data harus diisi", "Warning!");
                goto berhenti;
            }
            string tekscipher = null;
            tekscipher = CaesarCipher(tbpassword.Text, 17);

            con.Close();
            SqlCommand cmd = new SqlCommand("select * from admin where userId='" +
                tbusername.Text + "'and password='" + tekscipher + "'", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                dasboard dsb = new dasboard();
                dsb.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User id atau Password tidak valid", "warning!");
                tbusername.Text = "";
                tbpassword.Text = "";
                tbusername.Focus();
                rd.Close();
            }
        berhenti:;
        }
        private void tbpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToLower());
        }
        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
