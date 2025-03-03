namespace Nhom_3_kt
{
    partial class Form1
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
            this.Username = new System.Windows.Forms.Label();
            this.textboxusername = new System.Windows.Forms.TextBox();
            this.Matkhau = new System.Windows.Forms.Label();
            this.textboxpassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(239, 129);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(92, 16);
            this.Username.TabIndex = 0;
            this.Username.Text = "tên đăng nhập";
            // 
            // textboxusername
            // 
            this.textboxusername.Location = new System.Drawing.Point(332, 127);
            this.textboxusername.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textboxusername.Name = "textboxusername";
            this.textboxusername.Size = new System.Drawing.Size(352, 22);
            this.textboxusername.TabIndex = 1;
            // 
            // Matkhau
            // 
            this.Matkhau.AutoSize = true;
            this.Matkhau.Location = new System.Drawing.Point(239, 228);
            this.Matkhau.Name = "Matkhau";
            this.Matkhau.Size = new System.Drawing.Size(61, 16);
            this.Matkhau.TabIndex = 0;
            this.Matkhau.Text = "mật khẩu";
            // 
            // textboxpassword
            // 
            this.textboxpassword.Location = new System.Drawing.Point(332, 224);
            this.textboxpassword.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textboxpassword.Name = "textboxpassword";
            this.textboxpassword.Size = new System.Drawing.Size(352, 22);
            this.textboxpassword.TabIndex = 1;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(332, 300);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(81, 38);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Đăng nhập";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 523);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.textboxpassword);
            this.Controls.Add(this.Matkhau);
            this.Controls.Add(this.textboxusername);
            this.Controls.Add(this.Username);
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox textboxusername;
        private System.Windows.Forms.Label Matkhau;
        private System.Windows.Forms.TextBox textboxpassword;
        private System.Windows.Forms.Button btnlogin;
    }
}

