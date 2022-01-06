
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvtoko)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // cbtipe
            // 
            this.cbtipe.FormattingEnabled = true;
            this.cbtipe.Location = new System.Drawing.Point(109, 85);
            this.cbtipe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbtipe.Name = "cbtipe";
            this.cbtipe.Size = new System.Drawing.Size(114, 21);
            this.cbtipe.TabIndex = 3;
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(107, 48);
            this.tbid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(60, 20);
            this.tbid.TabIndex = 4;
            // 
            // tbalamat
            // 
            this.tbalamat.Location = new System.Drawing.Point(109, 119);
            this.tbalamat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbalamat.Name = "tbalamat";
            this.tbalamat.Size = new System.Drawing.Size(116, 20);
            this.tbalamat.TabIndex = 5;
            // 
            // tbharga
            // 
            this.tbharga.Location = new System.Drawing.Point(109, 151);
            this.tbharga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbharga.Name = "tbharga";
            this.tbharga.Size = new System.Drawing.Size(116, 20);
            this.tbharga.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Harga Sewa";
            // 
            // tblamasewa
            // 
            this.tblamasewa.Location = new System.Drawing.Point(109, 183);
            this.tblamasewa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tblamasewa.Name = "tblamasewa";
            this.tblamasewa.Size = new System.Drawing.Size(116, 20);
            this.tblamasewa.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lama sewa";
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(21, 217);
            this.btsave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(60, 22);
            this.btsave.TabIndex = 10;
            this.btsave.Text = "SAVE";
            this.btsave.UseVisualStyleBackColor = true;
            // 
            // dgvtoko
            // 
            this.dgvtoko.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtoko.Location = new System.Drawing.Point(255, 66);
            this.dgvtoko.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvtoko.Name = "dgvtoko";
            this.dgvtoko.RowHeadersWidth = 82;
            this.dgvtoko.RowTemplate.Height = 33;
            this.dgvtoko.Size = new System.Drawing.Size(380, 274);
            this.dgvtoko.TabIndex = 11;
            // 
            // tbcari
            // 
            this.tbcari.Location = new System.Drawing.Point(420, 32);
            this.tbcari.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbcari.Name = "tbcari";
            this.tbcari.Size = new System.Drawing.Size(137, 20);
            this.tbcari.TabIndex = 12;
            // 
            // btcari
            // 
            this.btcari.Location = new System.Drawing.Point(561, 32);
            this.btcari.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btcari.Name = "btcari";
            this.btcari.Size = new System.Drawing.Size(74, 20);
            this.btcari.TabIndex = 13;
            this.btcari.Text = "Cari";
            this.btcari.UseVisualStyleBackColor = true;
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(93, 217);
            this.btdelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(60, 22);
            this.btdelete.TabIndex = 14;
            this.btdelete.Text = "DELETE";
            this.btdelete.UseVisualStyleBackColor = true;
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(172, 217);
            this.btupdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(60, 22);
            this.btupdate.TabIndex = 15;
            this.btupdate.Text = "UPDATE";
            this.btupdate.UseVisualStyleBackColor = true;
            // 
            // toko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 388);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btcari);
            this.Controls.Add(this.tbcari);
            this.Controls.Add(this.dgvtoko);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "toko";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "toko";
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
    }
}