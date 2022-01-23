
namespace projekakhir
{
    partial class dasboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menukaryawan = new System.Windows.Forms.ToolStripMenuItem();
            this.menustok = new System.Windows.Forms.ToolStripMenuItem();
            this.menupenjualan = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manajemenToko = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Blue;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menukaryawan,
            this.menustok,
            this.menupenjualan,
            this.manajemenToko,
            this.keluarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menukaryawan
            // 
            this.menukaryawan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menukaryawan.ForeColor = System.Drawing.Color.White;
            this.menukaryawan.Name = "menukaryawan";
            this.menukaryawan.Size = new System.Drawing.Size(155, 22);
            this.menukaryawan.Text = "Manajemen Karyawan";
            this.menukaryawan.Click += new System.EventHandler(this.menukaryawan_Click);
            // 
            // menustok
            // 
            this.menustok.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplierToolStripMenuItem,
            this.barangToolStripMenuItem});
            this.menustok.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menustok.ForeColor = System.Drawing.Color.White;
            this.menustok.Name = "menustok";
            this.menustok.Size = new System.Drawing.Size(122, 22);
            this.menustok.Text = "Manajemen Stok";
            this.menustok.Click += new System.EventHandler(this.menustok_Click);
            // 
            // menupenjualan
            // 
            this.menupenjualan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transaksiToolStripMenuItem,
            this.penjualanToolStripMenuItem});
            this.menupenjualan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menupenjualan.ForeColor = System.Drawing.Color.White;
            this.menupenjualan.Name = "menupenjualan";
            this.menupenjualan.Size = new System.Drawing.Size(154, 22);
            this.menupenjualan.Text = "Manajemen Penjualan";
            this.menupenjualan.Click += new System.EventHandler(this.menupenjualan_Click);
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            this.transaksiToolStripMenuItem.Click += new System.EventHandler(this.transaksiToolStripMenuItem_Click);
            // 
            // penjualanToolStripMenuItem
            // 
            this.penjualanToolStripMenuItem.Name = "penjualanToolStripMenuItem";
            this.penjualanToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.penjualanToolStripMenuItem.Text = "Penjualan";
            this.penjualanToolStripMenuItem.Click += new System.EventHandler(this.penjualanToolStripMenuItem_Click);
            // 
            // manajemenToko
            // 
            this.manajemenToko.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manajemenToko.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.manajemenToko.Name = "manajemenToko";
            this.manajemenToko.Size = new System.Drawing.Size(123, 22);
            this.manajemenToko.Text = "Manajemen toko";
            this.manajemenToko.Click += new System.EventHandler(this.manajemenToko_Click);
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keluarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(58, 22);
            this.keluarToolStripMenuItem.Text = "Keluar";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(298, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME";
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.supplierToolStripMenuItem.Text = "Supplier";
            this.supplierToolStripMenuItem.Click += new System.EventHandler(this.supplierToolStripMenuItem_Click);
            // 
            // barangToolStripMenuItem
            // 
            this.barangToolStripMenuItem.Name = "barangToolStripMenuItem";
            this.barangToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.barangToolStripMenuItem.Text = "Barang";
            this.barangToolStripMenuItem.Click += new System.EventHandler(this.barangToolStripMenuItem_Click);
            // 
            // dasboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 452);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "dasboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dasboard";
            this.Load += new System.EventHandler(this.dasboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menukaryawan;
        private System.Windows.Forms.ToolStripMenuItem menustok;
        private System.Windows.Forms.ToolStripMenuItem menupenjualan;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manajemenToko;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem penjualanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barangToolStripMenuItem;
    }
}