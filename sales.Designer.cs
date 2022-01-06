
namespace projekakhir
{
    partial class sales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbharga = new System.Windows.Forms.TextBox();
            this.dgvtransaksi = new System.Windows.Forms.DataGridView();
            this.cbjenisbarang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbkuantiti = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbnamakaryawan = new System.Windows.Forms.TextBox();
            this.tbnomortelp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtptanggal = new System.Windows.Forms.DateTimePicker();
            this.tbnamabarang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btsave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbidbarang = new System.Windows.Forms.TextBox();
            this.btdelete = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1096, 881);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "simpan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jenis Barang";
            // 
            // tbharga
            // 
            this.tbharga.Location = new System.Drawing.Point(684, 200);
            this.tbharga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbharga.Name = "tbharga";
            this.tbharga.Size = new System.Drawing.Size(180, 31);
            this.tbharga.TabIndex = 2;
            // 
            // dgvtransaksi
            // 
            this.dgvtransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtransaksi.Location = new System.Drawing.Point(252, 371);
            this.dgvtransaksi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvtransaksi.Name = "dgvtransaksi";
            this.dgvtransaksi.RowHeadersWidth = 82;
            this.dgvtransaksi.RowTemplate.Height = 33;
            this.dgvtransaksi.Size = new System.Drawing.Size(1082, 356);
            this.dgvtransaksi.TabIndex = 3;
            // 
            // cbjenisbarang
            // 
            this.cbjenisbarang.FormattingEnabled = true;
            this.cbjenisbarang.Items.AddRange(new object[] {
            "Elctronic",
            "Furniture",
            "Sembako",
            "Fashion",
            "Makanan"});
            this.cbjenisbarang.Location = new System.Drawing.Point(250, 129);
            this.cbjenisbarang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbjenisbarang.Name = "cbjenisbarang";
            this.cbjenisbarang.Size = new System.Drawing.Size(256, 33);
            this.cbjenisbarang.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(566, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Harga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(954, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kuantiti";
            // 
            // tbkuantiti
            // 
            this.tbkuantiti.Location = new System.Drawing.Point(1080, 200);
            this.tbkuantiti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbkuantiti.Name = "tbkuantiti";
            this.tbkuantiti.Size = new System.Drawing.Size(180, 31);
            this.tbkuantiti.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nama Karyawan";
            // 
            // tbnamakaryawan
            // 
            this.tbnamakaryawan.Location = new System.Drawing.Point(250, 63);
            this.tbnamakaryawan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbnamakaryawan.Name = "tbnamakaryawan";
            this.tbnamakaryawan.Size = new System.Drawing.Size(256, 31);
            this.tbnamakaryawan.TabIndex = 9;
            // 
            // tbnomortelp
            // 
            this.tbnomortelp.Location = new System.Drawing.Point(684, 63);
            this.tbnomortelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbnomortelp.Name = "tbnomortelp";
            this.tbnomortelp.Size = new System.Drawing.Size(222, 31);
            this.tbnomortelp.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telepon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(948, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tanggal";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(942, 900);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(114, 31);
            this.textBox6.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(860, 900);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "total";
            // 
            // dtptanggal
            // 
            this.dtptanggal.Location = new System.Drawing.Point(1078, 63);
            this.dtptanggal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtptanggal.Name = "dtptanggal";
            this.dtptanggal.Size = new System.Drawing.Size(250, 31);
            this.dtptanggal.TabIndex = 16;
            // 
            // tbnamabarang
            // 
            this.tbnamabarang.Location = new System.Drawing.Point(250, 200);
            this.tbnamabarang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbnamabarang.Name = "tbnamabarang";
            this.tbnamabarang.Size = new System.Drawing.Size(256, 31);
            this.tbnamabarang.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 203);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nama Barang";
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(254, 285);
            this.btsave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(258, 44);
            this.btsave.TabIndex = 17;
            this.btsave.Text = "SAVE";
            this.btsave.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(566, 132);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Id Barang";
            // 
            // tbidbarang
            // 
            this.tbidbarang.Location = new System.Drawing.Point(684, 129);
            this.tbidbarang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbidbarang.Name = "tbidbarang";
            this.tbidbarang.Size = new System.Drawing.Size(118, 31);
            this.tbidbarang.TabIndex = 9;
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(662, 285);
            this.btdelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(258, 44);
            this.btdelete.TabIndex = 17;
            this.btdelete.Text = "DELETE";
            this.btdelete.UseVisualStyleBackColor = true;
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(1070, 285);
            this.btupdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(258, 44);
            this.btupdate.TabIndex = 17;
            this.btupdate.Text = "UPDATE";
            this.btupdate.UseVisualStyleBackColor = true;
            // 
            // sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 748);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.dtptanggal);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbnomortelp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbidbarang);
            this.Controls.Add(this.tbnamabarang);
            this.Controls.Add(this.tbnamakaryawan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbkuantiti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbjenisbarang);
            this.Controls.Add(this.dgvtransaksi);
            this.Controls.Add(this.tbharga);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaksi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvtransaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbharga;
        private System.Windows.Forms.DataGridView dgvtransaksi;
        private System.Windows.Forms.ComboBox cbjenisbarang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbkuantiti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbnamakaryawan;
        private System.Windows.Forms.TextBox tbnomortelp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtptanggal;
        private System.Windows.Forms.TextBox tbnamabarang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbidbarang;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btupdate;
    }
}