
namespace projekakhir
{
    partial class toko
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbtipe = new System.Windows.Forms.ComboBox();
            this.tbid = new System.Windows.Forms.TextBox();
            this.tbalamat = new System.Windows.Forms.TextBox();
            this.tbharga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tblamasewa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btsave = new System.Windows.Forms.Button();
            this.dgvtoko = new System.Windows.Forms.DataGridView();
            this.tbcari = new System.Windows.Forms.TextBox();
            this.btcari = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btback = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtoko)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Toko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // cbtipe
            // 
            this.cbtipe.FormattingEnabled = true;
            this.cbtipe.Location = new System.Drawing.Point(218, 163);
            this.cbtipe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbtipe.Name = "cbtipe";
            this.cbtipe.Size = new System.Drawing.Size(224, 33);
            this.cbtipe.TabIndex = 3;
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(214, 92);
            this.tbid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(116, 31);
            this.tbid.TabIndex = 4;
            // 
            // tbalamat
            // 
            this.tbalamat.Location = new System.Drawing.Point(218, 229);
            this.tbalamat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbalamat.Name = "tbalamat";
            this.tbalamat.Size = new System.Drawing.Size(228, 31);
            this.tbalamat.TabIndex = 5;
            // 
            // tbharga
            // 
            this.tbharga.Location = new System.Drawing.Point(218, 290);
            this.tbharga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbharga.Name = "tbharga";
            this.tbharga.Size = new System.Drawing.Size(228, 31);
            this.tbharga.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 296);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Harga Sewa";
            // 
            // tblamasewa
            // 
            this.tblamasewa.Location = new System.Drawing.Point(218, 352);
            this.tblamasewa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tblamasewa.Name = "tblamasewa";
            this.tblamasewa.Size = new System.Drawing.Size(228, 31);
            this.tblamasewa.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 358);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lama Sewa";
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(70, 417);
            this.btsave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(120, 42);
            this.btsave.TabIndex = 10;
            this.btsave.Text = "SAVE";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // dgvtoko
            // 
            this.dgvtoko.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtoko.Location = new System.Drawing.Point(510, 127);
            this.dgvtoko.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvtoko.Name = "dgvtoko";
            this.dgvtoko.RowHeadersWidth = 82;
            this.dgvtoko.RowTemplate.Height = 33;
            this.dgvtoko.Size = new System.Drawing.Size(928, 527);
            this.dgvtoko.TabIndex = 11;
            this.dgvtoko.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtoko_CellContentClick);
            // 
            // tbcari
            // 
            this.tbcari.Location = new System.Drawing.Point(1138, 62);
            this.tbcari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbcari.Name = "tbcari";
            this.tbcari.Size = new System.Drawing.Size(296, 31);
            this.tbcari.TabIndex = 12;
            // 
            // btcari
            // 
            this.btcari.Location = new System.Drawing.Point(962, 60);
            this.btcari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btcari.Name = "btcari";
            this.btcari.Size = new System.Drawing.Size(148, 38);
            this.btcari.TabIndex = 13;
            this.btcari.Text = "Cari";
            this.btcari.UseVisualStyleBackColor = true;
            this.btcari.Click += new System.EventHandler(this.btcari_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(214, 417);
            this.btdelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(120, 42);
            this.btdelete.TabIndex = 14;
            this.btdelete.Text = "DELETE";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(344, 417);
            this.btupdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(120, 42);
            this.btupdate.TabIndex = 15;
            this.btupdate.Text = "UPDATE";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btback
            // 
            this.btback.Location = new System.Drawing.Point(1118, 681);
            this.btback.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(120, 42);
            this.btback.TabIndex = 10;
            this.btback.Text = "BACK";
            this.btback.UseVisualStyleBackColor = true;
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1272, 677);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 46);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // toko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 746);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btcari);
            this.Controls.Add(this.tbcari);
            this.Controls.Add(this.dgvtoko);
            this.Controls.Add(this.btback);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.tblamasewa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbharga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbalamat);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.cbtipe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "toko";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "toko";
            this.Load += new System.EventHandler(this.toko_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtoko)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbtipe;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.TextBox tbalamat;
        private System.Windows.Forms.TextBox tbharga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tblamasewa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.DataGridView dgvtoko;
        private System.Windows.Forms.TextBox tbcari;
        private System.Windows.Forms.Button btcari;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btback;
        private System.Windows.Forms.Button btnPrint;
    }
}