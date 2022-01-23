
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
            this.tbSuplier = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTipe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
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
            this.tbBarang.Location = new System.Drawing.Point(153, 110);
            this.tbBarang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbBarang.Name = "tbBarang";
            this.tbBarang.Size = new System.Drawing.Size(88, 20);
            this.tbBarang.TabIndex = 1;
            // 
            // tbSuplier
            // 
            this.tbSuplier.Location = new System.Drawing.Point(153, 140);
            this.tbSuplier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSuplier.Name = "tbSuplier";
            this.tbSuplier.Size = new System.Drawing.Size(88, 20);
            this.tbSuplier.TabIndex = 3;
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
            // tbTipe
            // 
            this.tbTipe.Location = new System.Drawing.Point(153, 173);
            this.tbTipe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTipe.Name = "tbTipe";
            this.tbTipe.Size = new System.Drawing.Size(88, 20);
            this.tbTipe.TabIndex = 5;
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
            this.dgvBarang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.RowHeadersWidth = 82;
            this.dgvBarang.RowTemplate.Height = 33;
            this.dgvBarang.Size = new System.Drawing.Size(287, 269);
            this.dgvBarang.TabIndex = 6;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(292, 76);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(80, 23);
            this.btnSimpan.TabIndex = 7;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(393, 76);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(498, 76);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(80, 23);
            this.btnHapus.TabIndex = 9;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 389);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.dgvBarang);
            this.Controls.Add(this.tbTipe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSuplier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBarang);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox tbSuplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTipe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBarang;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHapus;
    }
}