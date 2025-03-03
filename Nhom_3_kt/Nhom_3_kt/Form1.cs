using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom_3_kt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = textboxusername.Text;
            string password = textboxpassword.Text;

            if (username == "admin" && password == "admin")
            {
                // Đăng nhập thành công, mở form trắng
                Form whiteForm = new Form();
                whiteForm.BackColor = System.Drawing.Color.White;
                whiteForm.WindowState = FormWindowState.Maximized;

                // Thêm nhãn thông báo đăng nhập thành công
                Label successLabel = new Label();
                successLabel.Text = "Đăng nhập thành công!";
                successLabel.Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold);
                successLabel.AutoSize = true;
                successLabel.Location = new System.Drawing.Point(50, 50);
                whiteForm.Controls.Add(successLabel);

                whiteForm.Show();

                // Ẩn form đăng nhập hiện tại
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

