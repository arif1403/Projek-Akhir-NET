
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
            this.manajemenKaryawanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manajemenItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanPenjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manajemenKaryawanToolStripMenuItem,
            this.manajemenItemToolStripMenuItem,
            this.mToolStripMenuItem,
            this.sToolStripMenuItem,
            this.laporanPenjualanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1366, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manajemenKaryawanToolStripMenuItem
            // 
            this.manajemenKaryawanToolStripMenuItem.Name = "manajemenKaryawanToolStripMenuItem";
            this.manajemenKaryawanToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.manajemenKaryawanToolStripMenuItem.Text = "Manajemen Karyawan";
            // 
            // manajemenItemToolStripMenuItem
            // 
            this.manajemenItemToolStripMenuItem.Name = "manajemenItemToolStripMenuItem";
            this.manajemenItemToolStripMenuItem.Size = new System.Drawing.Size(217, 36);
            this.manajemenItemToolStripMenuItem.Text = "Manajemen Item";
            // 
            // mToolStripMenuItem
            // 
            this.mToolStripMenuItem.Name = "mToolStripMenuItem";
            this.mToolStripMenuItem.Size = new System.Drawing.Size(215, 36);
            this.mToolStripMenuItem.Text = "Manajemen Stok";
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(272, 36);
            this.sToolStripMenuItem.Text = "Manajemen Penjualan";
            // 
            // laporanPenjualanToolStripMenuItem
            // 
            this.laporanPenjualanToolStripMenuItem.Name = "laporanPenjualanToolStripMenuItem";
            this.laporanPenjualanToolStripMenuItem.Size = new System.Drawing.Size(230, 36);
            this.laporanPenjualanToolStripMenuItem.Text = "Laporan Penjualan";
            // 
            // dasboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 834);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "dasboard";
            this.Text = "dasboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manajemenKaryawanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manajemenItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanPenjualanToolStripMenuItem;
    }
}