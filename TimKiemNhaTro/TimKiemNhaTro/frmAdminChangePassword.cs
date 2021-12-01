using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimKiemNhaTro.Model;

namespace TimKiemNhaTro
{
    public partial class frmAdminChangePassword : Form
    {
        NguoiDung _nguoiDung;
        public frmAdminChangePassword(NguoiDung nguoi)
        {
            InitializeComponent();
            _nguoiDung = nguoi;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMKCu.Text.Trim() == "" || txtMKMoi.Text.Trim() == "" || txtNhapLai.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (ComputeSha256Hash(txtMKCu.Text) != _nguoiDung.matKhau)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác");
                return;
            }
            if (txtNhapLai.Text != txtMKMoi.Text)
            {
                MessageBox.Show("Mật khẩu mới không khớp");
                return;
            }
            NguoiDung n = DataProvider.Ins.DB.NguoiDungs.Where(x => x.maNguoiDung == _nguoiDung.maNguoiDung).SingleOrDefault();
            if (n == null)
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại sau");
                return;
            }
            n.matKhau = ComputeSha256Hash(txtMKMoi.Text);
            DataProvider.Ins.DB.SaveChanges();
            MessageBox.Show("Bạn đã đổi mật khẩu thành công");
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
