﻿namespace projekakhir
{
    partial class Transaksi
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
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dTtgl = new System.Windows.Forms.DateTimePicker();
            this.tbIdTrans = new System.Windows.Forms.TextBox();
            this.tbIdToko = new System.Windows.Forms.TextBox();
            this.tbIdPenyewa = new System.Windows.Forms.TextBox();
            this.tbIdBrng = new System.Windows.Forms.TextBox();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgvTransaksi = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(879, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(56, 26);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(838, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cetak";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Transaksi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Toko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Id Penyewa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Id Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Harga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tanggal Sewa";
            // 
            // dTtgl
            // 
            this.dTtgl.Location = new System.Drawing.Point(162, 227);
            this.dTtgl.Name = "dTtgl";
            this.dTtgl.Size = new System.Drawing.Size(181, 20);
            this.dTtgl.TabIndex = 2;
            // 
            // tbIdTrans
            // 
            this.tbIdTrans.BackColor = System.Drawing.Color.Blue;
            this.tbIdTrans.ForeColor = System.Drawing.Color.White;
            this.tbIdTrans.Location = new System.Drawing.Point(162, 43);
            this.tbIdTrans.Name = "tbIdTrans";
            this.tbIdTrans.Size = new System.Drawing.Size(111, 20);
            this.tbIdTrans.TabIndex = 3;
            // 
            // tbIdToko
            // 
            this.tbIdToko.BackColor = System.Drawing.Color.Blue;
            this.tbIdToko.ForeColor = System.Drawing.Color.White;
            this.tbIdToko.Location = new System.Drawing.Point(162, 80);
            this.tbIdToko.Name = "tbIdToko";
            this.tbIdToko.Size = new System.Drawing.Size(111, 20);
            this.tbIdToko.TabIndex = 3;
            // 
            // tbIdPenyewa
            // 
            this.tbIdPenyewa.BackColor = System.Drawing.Color.Blue;
            this.tbIdPenyewa.ForeColor = System.Drawing.Color.White;
            this.tbIdPenyewa.Location = new System.Drawing.Point(162, 118);
            this.tbIdPenyewa.Name = "tbIdPenyewa";
            this.tbIdPenyewa.Size = new System.Drawing.Size(111, 20);
            this.tbIdPenyewa.TabIndex = 3;
            // 
            // tbIdBrng
            // 
            this.tbIdBrng.BackColor = System.Drawing.Color.Blue;
            this.tbIdBrng.ForeColor = System.Drawing.Color.White;
            this.tbIdBrng.Location = new System.Drawing.Point(162, 155);
            this.tbIdBrng.Name = "tbIdBrng";
            this.tbIdBrng.Size = new System.Drawing.Size(111, 20);
            this.tbIdBrng.TabIndex = 3;
            // 
            // tbHarga
            // 
            this.tbHarga.BackColor = System.Drawing.Color.Blue;
            this.tbHarga.ForeColor = System.Drawing.Color.White;
            this.tbHarga.Location = new System.Drawing.Point(162, 193);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(111, 20);
            this.tbHarga.TabIndex = 3;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(30, 281);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(97, 35);
            this.btnSimpan.TabIndex = 4;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(143, 281);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(97, 35);
            this.btnHapus.TabIndex = 4;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(256, 281);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(97, 35);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // dgvTransaksi
            // 
            this.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaksi.Location = new System.Drawing.Point(391, 44);
            this.dgvTransaksi.Name = "dgvTransaksi";
            this.dgvTransaksi.Size = new System.Drawing.Size(544, 272);
            this.dgvTransaksi.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.tbIdPenyewa);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnHapus);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dTtgl);
            this.panel1.Controls.Add(this.btnSimpan);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbHarga);
            this.panel1.Controls.Add(this.tbIdTrans);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbIdBrng);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbIdToko);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 442);
            this.panel1.TabIndex = 6;
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(947, 382);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTransaksi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.Transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dTtgl;
        private System.Windows.Forms.TextBox tbIdTrans;
        private System.Windows.Forms.TextBox tbIdToko;
        private System.Windows.Forms.TextBox tbIdPenyewa;
        private System.Windows.Forms.TextBox tbIdBrng;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgvTransaksi;
        private System.Windows.Forms.Panel panel1;
    }
}