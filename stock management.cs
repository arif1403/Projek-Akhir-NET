using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekakhir
{
    public partial class stock_management : Form
    {
        public stock_management()
        {
            InitializeComponent();
        }

        private void btndasbord_Click(object sender, EventArgs e)
        {
            dasboard db = new dasboard();
            db.Show();
            this.Close();
        }

        private void stock_management_Load(object sender, EventArgs e)
        {

        }
    }
}
