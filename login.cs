﻿using System;
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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Registrasi reg = new Registrasi();
            reg.Show();
            this.Hide();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            dasboard dsb = new dasboard();
            dsb.Show();
            this.Hide();
        }
    }
}
