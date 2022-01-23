
namespace projekakhir
{
    partial class barang
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
            this.tbBarang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.cbTipe = new System.Windows.Forms.ComboBox();
            this.cbIdSup = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id barang";
            // 
            // tbBarang
            // 
            this.tbBarang.Location = new System.Drawing.Point(153, 107);
            this.tbBarang.Margin = new System.Windows.Forms.Padding(2);
            this.tbBarang.Name = "tbBarang";
            this.tbBarang.Size = new System.Drawing.Size(108, 20);
            this.tbBarang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id suplier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipe barang";
            // 
            // dgvBarang
            // 
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarang.Location = new System.Drawing.Point(292, 110);
            this.dgvBarang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.RowHeadersWidth = 82;
            this.dgvBarang.RowTemplate.Height = 33;
            this.dgvBarang.Size = new System.Drawing.Size(345, 269);
            this.dgvBarang.TabIndex = 6;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(292, 76);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(2);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(80, 23);
            this.btnSimpan.TabIndex = 7;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(406, 76);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(512, 76);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(80, 23);
            this.btnHapus.TabIndex = 9;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(538, 12);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 10;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // cbTipe
            // 
            this.cbTipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipe.FormattingEnabled = true;
            this.cbTipe.Items.AddRange(new object[] {
            "Elektronik",
            "Furniture",
            "Busana",
            "Sembako",
            "Makanan"});
            this.cbTipe.Location = new System.Drawing.Point(153, 170);
            this.cbTipe.Name = "cbTipe";
            this.cbTipe.Size = new System.Drawing.Size(108, 21);
            this.cbTipe.TabIndex = 11;
            // 
            // cbIdSup
            // 
            this.cbIdSup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdSup.FormattingEnabled = true;
            this.cbIdSup.Location = new System.Drawing.Point(153, 139);
            this.cbIdSup.Name = "cbIdSup";
            this.cbIdSup.Size = new System.Drawing.Size(108, 21);
            this.cbIdSup.TabIndex = 12;
            this.cbIdSup.SelectedIndexChanged += new System.EventHandler(this.cbIdSup_SelectedIndexChanged);
            // 
            // barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 394);
            this.Controls.Add(this.cbIdSup);
            this.Controls.Add(this.cbTipe);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.dgvBarang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBarang);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "barang";
            this.Text = "barang";
            this.Load += new System.EventHandler(this.barang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBarang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBarang;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.ComboBox cbTipe;
        private System.Windows.Forms.ComboBox cbIdSup;
    }
}