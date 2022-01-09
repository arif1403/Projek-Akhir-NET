
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
            this.menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.menustok = new System.Windows.Forms.ToolStripMenuItem();
            this.menupenjualan = new System.Windows.Forms.ToolStripMenuItem();
            this.menulaporanpenjualan = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manajemenToko = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menukaryawan,
            this.menuitem,
            this.menustok,
            this.menupenjualan,
            this.menulaporanpenjualan,
            this.keluarToolStripMenuItem,
            this.manajemenToko});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1520, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menukaryawan
            // 
            this.menukaryawan.Name = "menukaryawan";
            this.menukaryawan.Size = new System.Drawing.Size(270, 38);
            this.menukaryawan.Text = "Manajemen Karyawan";
            this.menukaryawan.Click += new System.EventHandler(this.menukaryawan_Click);
            // 
            // menuitem
            // 
            this.menuitem.Name = "menuitem";
            this.menuitem.Size = new System.Drawing.Size(217, 38);
            this.menuitem.Text = "Manajemen Item";
            // 
            // menustok
            // 
            this.menustok.Name = "menustok";
            this.menustok.Size = new System.Drawing.Size(215, 38);
            this.menustok.Text = "Manajemen Stok";
            // 
            // menupenjualan
            // 
            this.menupenjualan.Name = "menupenjualan";
            this.menupenjualan.Size = new System.Drawing.Size(272, 38);
            this.menupenjualan.Text = "Manajemen Penjualan";
            // 
            // menulaporanpenjualan
            // 
            this.menulaporanpenjualan.Name = "menulaporanpenjualan";
            this.menulaporanpenjualan.Size = new System.Drawing.Size(127, 38);
            this.menulaporanpenjualan.Text = "Laporan ";
            this.menulaporanpenjualan.Click += new System.EventHandler(this.menulaporanpenjualan_Click);
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(102, 38);
            this.keluarToolStripMenuItem.Text = "Keluar";
            // 
            // manajemenToko
            // 
            this.manajemenToko.Name = "manajemenToko";
            this.manajemenToko.Size = new System.Drawing.Size(217, 38);
            this.manajemenToko.Text = "Manajemen toko";
            this.manajemenToko.Click += new System.EventHandler(this.manajemenToko_Click);
            // 
            // dasboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 820);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "dasboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dasboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menukaryawan;
        private System.Windows.Forms.ToolStripMenuItem menuitem;
        private System.Windows.Forms.ToolStripMenuItem menustok;
        private System.Windows.Forms.ToolStripMenuItem menupenjualan;
        private System.Windows.Forms.ToolStripMenuItem menulaporanpenjualan;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manajemenToko;
    }
}