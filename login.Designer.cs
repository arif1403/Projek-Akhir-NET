
namespace projekakhir
{
    partial class login
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
            this.tbusername = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.btlogin = new System.Windows.Forms.Button();
            this.cbrole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbusername
            // 
            this.tbusername.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbusername.Location = new System.Drawing.Point(86, 92);
            this.tbusername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(170, 20);
            this.tbusername.TabIndex = 1;
            // 
            // tbpassword
            // 
            this.tbpassword.Font = new System.Drawing.Font("Webdings", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.tbpassword.Location = new System.Drawing.Point(86, 122);
            this.tbpassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = 'l';
            this.tbpassword.Size = new System.Drawing.Size(170, 18);
            this.tbpassword.TabIndex = 3;
            // 
            // btlogin
            // 
            this.btlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlogin.Location = new System.Drawing.Point(86, 152);
            this.btlogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(168, 23);
            this.btlogin.TabIndex = 4;
            this.btlogin.Text = "LOGIN";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // cbrole
            // 
            this.cbrole.FormattingEnabled = true;
            this.cbrole.Items.AddRange(new object[] {
            "Admin",
            "Karyawan"});
            this.cbrole.Location = new System.Drawing.Point(86, 57);
            this.cbrole.Name = "cbrole";
            this.cbrole.Size = new System.Drawing.Size(100, 21);
            this.cbrole.TabIndex = 6;
            this.cbrole.Text = "Pilih Role";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(116, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Belum Punya Akun ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(138, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Registrasi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 250);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbrole);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbusername);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.ComboBox cbrole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}