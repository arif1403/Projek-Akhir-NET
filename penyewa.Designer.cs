
namespace projekakhir
{
    partial class penyewa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(penyewa));
            this.dgvtoko = new System.Windows.Forms.DataGridView();
            this.tbcari = new System.Windows.Forms.TextBox();
            this.btcari = new System.Windows.Forms.Button();
            this.btback = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbtipe = new System.Windows.Forms.ComboBox();
            this.tbid = new System.Windows.Forms.TextBox();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.tbalamat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbharga = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tblamasewa = new System.Windows.Forms.TextBox();
            this.btsave = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtoko)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtoko
            // 
            this.dgvtoko.AllowUserToAddRows = false;
            this.dgvtoko.AllowUserToDeleteRows = false;
            this.dgvtoko.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtoko.Location = new System.Drawing.Point(285, 90);
            this.dgvtoko.Margin = new System.Windows.Forms.Padding(2);
            this.dgvtoko.Name = "dgvtoko";
            this.dgvtoko.ReadOnly = true;
            this.dgvtoko.RowHeadersWidth = 82;
            this.dgvtoko.RowTemplate.Height = 33;
            this.dgvtoko.Size = new System.Drawing.Size(464, 274);
            this.dgvtoko.TabIndex = 11;
            this.dgvtoko.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtoko_CellContentClick);
            // 
            // tbcari
            // 
            this.tbcari.Location = new System.Drawing.Point(594, 56);
            this.tbcari.Margin = new System.Windows.Forms.Padding(2);
            this.tbcari.Name = "tbcari";
            this.tbcari.Size = new System.Drawing.Size(150, 20);
            this.tbcari.TabIndex = 12;
            // 
            // btcari
            // 
            this.btcari.Location = new System.Drawing.Point(506, 55);
            this.btcari.Margin = new System.Windows.Forms.Padding(2);
            this.btcari.Name = "btcari";
            this.btcari.Size = new System.Drawing.Size(74, 20);
            this.btcari.TabIndex = 13;
            this.btcari.Text = "Cari";
            this.btcari.UseVisualStyleBackColor = true;
            this.btcari.Click += new System.EventHandler(this.btcari_Click);
            // 
            // btback
            // 
            this.btback.Location = new System.Drawing.Point(584, 378);
            this.btback.Margin = new System.Windows.Forms.Padding(2);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(60, 22);
            this.btback.TabIndex = 10;
            this.btback.Text = "BACK";
            this.btback.UseVisualStyleBackColor = true;
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(661, 376);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(60, 24);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Penyewa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(63, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nama Penyewa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(63, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // cbtipe
            // 
            this.cbtipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipe.FormattingEnabled = true;
            this.cbtipe.Items.AddRange(new object[] {
            "Elektronik",
            "Sembako",
            "Furniture"});
            this.cbtipe.Location = new System.Drawing.Point(149, 181);
            this.cbtipe.Margin = new System.Windows.Forms.Padding(2);
            this.cbtipe.Name = "cbtipe";
            this.cbtipe.Size = new System.Drawing.Size(116, 21);
            this.cbtipe.TabIndex = 3;
            // 
            // tbid
            // 
            this.tbid.BackColor = System.Drawing.Color.Navy;
            this.tbid.Location = new System.Drawing.Point(149, 118);
            this.tbid.Margin = new System.Windows.Forms.Padding(2);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(60, 20);
            this.tbid.TabIndex = 4;
            // 
            // tbnama
            // 
            this.tbnama.BackColor = System.Drawing.Color.Navy;
            this.tbnama.Location = new System.Drawing.Point(149, 148);
            this.tbnama.Margin = new System.Windows.Forms.Padding(2);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(116, 20);
            this.tbnama.TabIndex = 4;
            // 
            // tbalamat
            // 
            this.tbalamat.BackColor = System.Drawing.Color.Navy;
            this.tbalamat.Location = new System.Drawing.Point(149, 215);
            this.tbalamat.Margin = new System.Windows.Forms.Padding(2);
            this.tbalamat.Name = "tbalamat";
            this.tbalamat.Size = new System.Drawing.Size(116, 20);
            this.tbalamat.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(63, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Harga Sewa";
            // 
            // tbharga
            // 
            this.tbharga.BackColor = System.Drawing.Color.Navy;
            this.tbharga.Location = new System.Drawing.Point(149, 247);
            this.tbharga.Margin = new System.Windows.Forms.Padding(2);
            this.tbharga.Name = "tbharga";
            this.tbharga.Size = new System.Drawing.Size(116, 20);
            this.tbharga.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(63, 282);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lama Sewa";
            // 
            // tblamasewa
            // 
            this.tblamasewa.BackColor = System.Drawing.Color.Navy;
            this.tblamasewa.Location = new System.Drawing.Point(149, 279);
            this.tblamasewa.Margin = new System.Windows.Forms.Padding(2);
            this.tblamasewa.Name = "tblamasewa";
            this.tblamasewa.Size = new System.Drawing.Size(116, 20);
            this.tblamasewa.TabIndex = 9;
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(64, 313);
            this.btsave.Margin = new System.Windows.Forms.Padding(2);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(60, 22);
            this.btsave.TabIndex = 10;
            this.btsave.Text = "SAVE";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(136, 313);
            this.btdelete.Margin = new System.Windows.Forms.Padding(2);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(60, 22);
            this.btdelete.TabIndex = 14;
            this.btdelete.Text = "DELETE";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(201, 313);
            this.btupdate.Margin = new System.Windows.Forms.Padding(2);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(60, 22);
            this.btupdate.TabIndex = 15;
            this.btupdate.Text = "UPDATE";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // penyewa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(795, 471);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.tblamasewa);
            this.Controls.Add(this.btcari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbcari);
            this.Controls.Add(this.tbharga);
            this.Controls.Add(this.dgvtoko);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btback);
            this.Controls.Add(this.tbalamat);
            this.Controls.Add(this.tbnama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbtipe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "penyewa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "toko";
            this.Load += new System.EventHandler(this.toko_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtoko)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvtoko;
        private System.Windows.Forms.TextBox tbcari;
        private System.Windows.Forms.Button btcari;
        private System.Windows.Forms.Button btback;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbtipe;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.TextBox tbalamat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbharga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tblamasewa;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btupdate;
    }
}