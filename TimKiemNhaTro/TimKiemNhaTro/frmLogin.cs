using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using TimKiemNhaTro.Model;

namespace TimKiemNhaTro
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            lblToRegister.Cursor = Cursors.Hand;

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblToRegister_Click(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister(this);
            frm.Show();
            Hide();
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            var pass = ComputeSha256Hash(txtPassword.Text);
            NguoiDung nguoiDung = DataProvider.Ins.DB.NguoiDungs.Where(x => x.tenDangNhap == txtUsername.Text && x.matKhau == pass ).SingleOrDefault();
            if (nguoiDung == null)
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại thông tin của bạn!");
                return;

            }
            MessageBox.Show("Đăng nhập thành công");
            frmMain frm = new frmMain(nguoiDung);
            Hide();
            frm.ShowDialog();
            Close();
        }
        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
