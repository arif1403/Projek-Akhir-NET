namespace projekakhir
{
    partial class Supplier
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
            this.tbIdSp = new System.Windows.Forms.TextBox();
            this.tbNamaSP = new System.Windows.Forms.TextBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.btSave = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(184, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(184, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Supplier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(184, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Alamat";
            // 
            // tbIdSp
            // 
            this.tbIdSp.Location = new System.Drawing.Point(285, 35);
            this.tbIdSp.Name = "tbIdSp";
            this.tbIdSp.Size = new System.Drawing.Size(177, 20);
            this.tbIdSp.TabIndex = 2;
            // 
            // tbNamaSP
            // 
            this.tbNamaSP.Location = new System.Drawing.Point(285, 68);
            this.tbNamaSP.Name = "tbNamaSP";
            this.tbNamaSP.Size = new System.Drawing.Size(177, 20);
            this.tbNamaSP.TabIndex = 2;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(285, 102);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(177, 20);
            this.tbAlamat.TabIndex = 2;
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AllowUserToAddRows = false;
            this.dgvSupplier.AllowUserToDeleteRows = false;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Location = new System.Drawing.Point(129, 212);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.ReadOnly = true;
            this.dgvSupplier.Size = new System.Drawing.Size(403, 170);
            this.dgvSupplier.TabIndex = 3;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(185, 157);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 27);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(285, 157);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 27);
            this.btUpdate.TabIndex = 4;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(387, 157);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 27);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.Red;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.ForeColor = System.Drawing.Color.White;
            this.btBack.Location = new System.Drawing.Point(590, 20);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(58, 30);
            this.btBack.TabIndex = 5;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(666, 419);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.dgvSupplier);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.tbNamaSP);
            this.Controls.Add(this.tbIdSp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIdSp;
        private System.Windows.Forms.TextBox tbNamaSP;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btBack;
    }
}