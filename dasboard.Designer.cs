﻿
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
            this.manajemenToko = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
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
            this.menuStrip1.Size = new System.Drawing.Size(591, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menukaryawan
            // 
            this.menukaryawan.Name = "menukaryawan";
            this.menukaryawan.Size = new System.Drawing.Size(136, 22);
            this.menukaryawan.Text = "Manajemen Karyawan";
            this.menukaryawan.Click += new System.EventHandler(this.menukaryawan_Click);
            // 
            // menustok
            // 
            this.menustok.Name = "menustok";
            this.menustok.Size = new System.Drawing.Size(108, 22);
            this.menustok.Text = "Manajemen Stok";
            this.menustok.Click += new System.EventHandler(this.menustok_Click);
            // 
            // menupenjualan
            // 
            this.menupenjualan.Name = "menupenjualan";
            this.menupenjualan.Size = new System.Drawing.Size(137, 22);
            this.menupenjualan.Text = "Manajemen Penjualan";
            this.menupenjualan.Click += new System.EventHandler(this.menupenjualan_Click);
            // 
            // manajemenToko
            // 
            this.manajemenToko.Name = "manajemenToko";
            this.manajemenToko.Size = new System.Drawing.Size(109, 22);
            this.manajemenToko.Text = "Manajemen toko";
            this.manajemenToko.Click += new System.EventHandler(this.manajemenToko_Click);
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.keluarToolStripMenuItem.Text = "Keluar";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
            // 
            // dasboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(591, 339);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.ToolStripMenuItem menustok;
        private System.Windows.Forms.ToolStripMenuItem menupenjualan;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manajemenToko;
    }
}