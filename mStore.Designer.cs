﻿
namespace projekakhir
{
    partial class mStore
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
            this.dgvStore = new System.Windows.Forms.DataGridView();
            this.cbStoreType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIdtoko = new System.Windows.Forms.TextBox();
            this.tbharga = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbnamatoko = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btsave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbalamat = new System.Windows.Forms.TextBox();
            this.btdelete = new System.Windows.Forms.Button();
            this.btback = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Store Name";
            // 
            // dgvStore
            // 
            this.dgvStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStore.Location = new System.Drawing.Point(126, 193);
            this.dgvStore.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStore.Name = "dgvStore";
            this.dgvStore.RowHeadersWidth = 82;
            this.dgvStore.RowTemplate.Height = 33;
            this.dgvStore.Size = new System.Drawing.Size(541, 246);
            this.dgvStore.TabIndex = 3;
            // 
            // cbStoreType
            // 
            this.cbStoreType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStoreType.FormattingEnabled = true;
            this.cbStoreType.Items.AddRange(new object[] {
            "Elctronic",
            "Furniture",
            "Sembako",
            "Fashion",
            "Makanan"});
            this.cbStoreType.Location = new System.Drawing.Point(125, 103);
            this.cbStoreType.Margin = new System.Windows.Forms.Padding(2);
            this.cbStoreType.Name = "cbStoreType";
            this.cbStoreType.Size = new System.Drawing.Size(130, 21);
            this.cbStoreType.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Store Id";
            // 
            // tbIdtoko
            // 
            this.tbIdtoko.Location = new System.Drawing.Point(125, 33);
            this.tbIdtoko.Margin = new System.Windows.Forms.Padding(2);
            this.tbIdtoko.Name = "tbIdtoko";
            this.tbIdtoko.Size = new System.Drawing.Size(130, 20);
            this.tbIdtoko.TabIndex = 9;
            // 
            // tbharga
            // 
            this.tbharga.Location = new System.Drawing.Point(342, 33);
            this.tbharga.Margin = new System.Windows.Forms.Padding(2);
            this.tbharga.Name = "tbharga";
            this.tbharga.Size = new System.Drawing.Size(113, 20);
            this.tbharga.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(283, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Harga";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(471, 468);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(59, 20);
            this.textBox6.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 468);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "total";
            // 
            // tbnamatoko
            // 
            this.tbnamatoko.Location = new System.Drawing.Point(125, 67);
            this.tbnamatoko.Margin = new System.Windows.Forms.Padding(2);
            this.tbnamatoko.Name = "tbnamatoko";
            this.tbnamatoko.Size = new System.Drawing.Size(130, 20);
            this.tbnamatoko.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(22, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Store Type";
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(132, 154);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(129, 23);
            this.btsave.TabIndex = 17;
            this.btsave.Text = "SAVE";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(283, 69);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Alamat";
            // 
            // tbalamat
            // 
            this.tbalamat.Location = new System.Drawing.Point(342, 67);
            this.tbalamat.Margin = new System.Windows.Forms.Padding(2);
            this.tbalamat.Name = "tbalamat";
            this.tbalamat.Size = new System.Drawing.Size(113, 20);
            this.tbalamat.TabIndex = 9;
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(267, 154);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(129, 23);
            this.btdelete.TabIndex = 17;
            this.btdelete.Text = "DELETE";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btback
            // 
            this.btback.BackColor = System.Drawing.Color.Red;
            this.btback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btback.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btback.ForeColor = System.Drawing.Color.White;
            this.btback.Location = new System.Drawing.Point(672, 12);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(49, 23);
            this.btback.TabIndex = 17;
            this.btback.Text = "BACK";
            this.btback.UseVisualStyleBackColor = false;
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(402, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(597, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "PRINT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(733, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btback);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbharga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbalamat);
            this.Controls.Add(this.tbnamatoko);
            this.Controls.Add(this.tbIdtoko);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbStoreType);
            this.Controls.Add(this.dgvStore);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STORE";
            this.Load += new System.EventHandler(this.mPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStore;
        private System.Windows.Forms.ComboBox cbStoreType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIdtoko;
        private System.Windows.Forms.TextBox tbharga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbnamatoko;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbalamat;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btback;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}