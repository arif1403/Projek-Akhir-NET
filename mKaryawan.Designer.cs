
namespace projekakhir
{
    partial class Mkaryawan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mkaryawan));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.tbid = new System.Windows.Forms.TextBox();
            this.tbalamat = new System.Windows.Forms.TextBox();
            this.tbgaji = new System.Windows.Forms.TextBox();
            this.tbnmrtlp = new System.Windows.Forms.TextBox();
            this.dgvkaryawan = new System.Windows.Forms.DataGridView();
            this.bttambah = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.bthapus = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbcari = new System.Windows.Forms.ToolStripTextBox();
            this.btcari = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbJk = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkaryawan)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Karyawan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Karyawan";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gaji";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(366, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(366, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "No Telepon";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbnama
            // 
            this.tbnama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbnama.ForeColor = System.Drawing.Color.White;
            this.tbnama.Location = new System.Drawing.Point(149, 81);
            this.tbnama.Margin = new System.Windows.Forms.Padding(2);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(147, 20);
            this.tbnama.TabIndex = 6;
            this.tbnama.TextChanged += new System.EventHandler(this.tbnama_TextChanged);
            // 
            // tbid
            // 
            this.tbid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbid.ForeColor = System.Drawing.Color.White;
            this.tbid.Location = new System.Drawing.Point(149, 111);
            this.tbid.Margin = new System.Windows.Forms.Padding(2);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(147, 20);
            this.tbid.TabIndex = 7;
            this.tbid.TextChanged += new System.EventHandler(this.tbid_TextChanged);
            // 
            // tbalamat
            // 
            this.tbalamat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbalamat.ForeColor = System.Drawing.Color.White;
            this.tbalamat.Location = new System.Drawing.Point(484, 76);
            this.tbalamat.Margin = new System.Windows.Forms.Padding(2);
            this.tbalamat.Name = "tbalamat";
            this.tbalamat.Size = new System.Drawing.Size(155, 20);
            this.tbalamat.TabIndex = 9;
            this.tbalamat.TextChanged += new System.EventHandler(this.tbalamat_TextChanged);
            // 
            // tbgaji
            // 
            this.tbgaji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbgaji.ForeColor = System.Drawing.Color.White;
            this.tbgaji.Location = new System.Drawing.Point(149, 142);
            this.tbgaji.Margin = new System.Windows.Forms.Padding(2);
            this.tbgaji.Name = "tbgaji";
            this.tbgaji.Size = new System.Drawing.Size(147, 20);
            this.tbgaji.TabIndex = 8;
            this.tbgaji.TextChanged += new System.EventHandler(this.tbgaji_TextChanged);
            // 
            // tbnmrtlp
            // 
            this.tbnmrtlp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbnmrtlp.ForeColor = System.Drawing.Color.White;
            this.tbnmrtlp.Location = new System.Drawing.Point(484, 111);
            this.tbnmrtlp.Margin = new System.Windows.Forms.Padding(2);
            this.tbnmrtlp.Name = "tbnmrtlp";
            this.tbnmrtlp.Size = new System.Drawing.Size(155, 20);
            this.tbnmrtlp.TabIndex = 10;
            this.tbnmrtlp.TextChanged += new System.EventHandler(this.tbnmrtlp_TextChanged);
            // 
            // dgvkaryawan
            // 
            this.dgvkaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkaryawan.Location = new System.Drawing.Point(22, 239);
            this.dgvkaryawan.Margin = new System.Windows.Forms.Padding(2);
            this.dgvkaryawan.Name = "dgvkaryawan";
            this.dgvkaryawan.RowHeadersWidth = 82;
            this.dgvkaryawan.RowTemplate.Height = 33;
            this.dgvkaryawan.Size = new System.Drawing.Size(694, 254);
            this.dgvkaryawan.TabIndex = 12;
            // 
            // bttambah
            // 
            this.bttambah.Location = new System.Drawing.Point(21, 198);
            this.bttambah.Margin = new System.Windows.Forms.Padding(2);
            this.bttambah.Name = "bttambah";
            this.bttambah.Size = new System.Drawing.Size(86, 27);
            this.bttambah.TabIndex = 13;
            this.bttambah.Text = "TAMBAH";
            this.bttambah.UseVisualStyleBackColor = true;
            this.bttambah.Click += new System.EventHandler(this.bttambah_Click);
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(130, 198);
            this.btupdate.Margin = new System.Windows.Forms.Padding(2);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(86, 27);
            this.btupdate.TabIndex = 14;
            this.btupdate.Text = "UPDATE";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // bthapus
            // 
            this.bthapus.Location = new System.Drawing.Point(239, 198);
            this.bthapus.Margin = new System.Windows.Forms.Padding(2);
            this.bthapus.Name = "bthapus";
            this.bthapus.Size = new System.Drawing.Size(86, 27);
            this.bthapus.TabIndex = 16;
            this.bthapus.Text = "HAPUS";
            this.bthapus.UseVisualStyleBackColor = true;
            this.bthapus.Click += new System.EventHandler(this.bthapus_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.tbcari,
            this.btcari});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(740, 39);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(39, 36);
            this.toolStripLabel1.Text = "CARI :";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tbcari
            // 
            this.tbcari.Name = "tbcari";
            this.tbcari.Size = new System.Drawing.Size(152, 39);
            // 
            // btcari
            // 
            this.btcari.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btcari.Image = ((System.Drawing.Image)(resources.GetObject("btcari.Image")));
            this.btcari.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btcari.Name = "btcari";
            this.btcari.Size = new System.Drawing.Size(36, 36);
            this.btcari.Text = "toolStripButton2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(671, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 25);
            this.button1.TabIndex = 19;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(592, 498);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(124, 29);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(366, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Jenis Kelamin";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cbJk
            // 
            this.cbJk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJk.FormattingEnabled = true;
            this.cbJk.Items.AddRange(new object[] {
            "Laki - laki",
            "Perempuan"});
            this.cbJk.Location = new System.Drawing.Point(484, 143);
            this.cbJk.Name = "cbJk";
            this.cbJk.Size = new System.Drawing.Size(155, 21);
            this.cbJk.TabIndex = 22;
            this.cbJk.SelectedIndexChanged += new System.EventHandler(this.cbJk_SelectedIndexChanged);
            // 
            // Mkaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(740, 537);
            this.Controls.Add(this.cbJk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.tbnmrtlp);
            this.Controls.Add(this.tbalamat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbgaji);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.bthapus);
            this.Controls.Add(this.tbnama);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bttambah);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvkaryawan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Mkaryawan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelola Karyawan";
            this.Load += new System.EventHandler(this.Mkaryawan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkaryawan)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.TextBox tbalamat;
        private System.Windows.Forms.TextBox tbgaji;
        private System.Windows.Forms.TextBox tbnmrtlp;
        private System.Windows.Forms.DataGridView dgvkaryawan;
        private System.Windows.Forms.Button bttambah;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button bthapus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tbcari;
        private System.Windows.Forms.ToolStripButton btcari;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbJk;
    }
}

