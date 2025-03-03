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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.Matkhau = new System.Windows.Forms.Label();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(238, 130);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(92, 16);
            this.Username.TabIndex = 0;
            this.Username.Text = "tên đăng nhập";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(332, 127);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(352, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // Matkhau
            // 
            this.Matkhau.AutoSize = true;
            this.Matkhau.Location = new System.Drawing.Point(238, 227);
            this.Matkhau.Name = "Matkhau";
            this.Matkhau.Size = new System.Drawing.Size(61, 16);
            this.Matkhau.TabIndex = 0;
            this.Matkhau.Text = "mật khẩu";
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(332, 224);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(352, 22);
            this.txtmatkhau.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 523);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.Matkhau);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.Username);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label Matkhau;
        private System.Windows.Forms.TextBox txtmatkhau;
    }
}

