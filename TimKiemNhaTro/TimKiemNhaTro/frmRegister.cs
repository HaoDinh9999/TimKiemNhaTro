using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimKiemNhaTro.Model;

namespace TimKiemNhaTro
{
    public partial class frmRegister : Form
    {
        frmLogin _frm = new frmLogin();
        public frmRegister()
        {
            InitializeComponent();
        }
        public frmRegister(frmLogin frm)
        {
            InitializeComponent();
            _frm = frm;
            lblToLogin.Cursor = Cursors.Hand;
        }
        private void picExit_Click(object sender, EventArgs e)
        {
            Close();
            _frm.Show();
        }

        private void lblToLogin_Click(object sender, EventArgs e)
        {
            _frm.Show();
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            Regex mRegxExpression;
            mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

            if (!mRegxExpression.IsMatch(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Email không hợp lệ", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            NguoiDung nguoiDung = DataProvider.Ins.DB.NguoiDungs.Where(x => x.email == txtEmail.Text).SingleOrDefault();
            if (nguoiDung != null)
            {
                MessageBox.Show("Email đã tồn tại. Vui lòng dùng email khác");
                return;

            }
            nguoiDung = new NguoiDung() { email = txtEmail.Text, matKhau = ComputeSha256Hash(txtPassword.Text), maNhom = 2 };
            DataProvider.Ins.DB.NguoiDungs.Add(nguoiDung);
            DataProvider.Ins.DB.SaveChanges();
            MessageBox.Show("Bạn đã đăng ký tài khoản thành công");

            
            
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
