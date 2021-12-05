using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
            if(txtMaXacNhan.Text != luuMaXacNhan)
            {
                MessageBox.Show("Bạn đã nhập sai mã xác nhận, vui lòng thử lại");
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
        public string RandomString(int size, bool lowerCase = false)
        {
            Random _r = new Random();

            var builder = new StringBuilder(size);

            // Unicode/ASCII Letters are divided into two blocks
            // (Letters 65–90 / 97–122):
            // The first group containing the uppercase letters and
            // the second group containing the lowercase.  

            // char is a single Unicode character  
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26; // A...Z or a..z: length=26  

            for (var i = 0; i < size; i++)
            {
                var @char = (char)_r.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }
        public int RandomNumber(int min, int max)
        {
            Random _r = new Random();
            return _r.Next(min, max);
        }
        public string RandomMa()
        {
            var passwordBuilder = new StringBuilder();

            // 4-Letters lower case   
            passwordBuilder.Append(RandomString(4, true));

            // 4-Digits between 1000 and 9999  
            passwordBuilder.Append(RandomNumber(1000, 9999));

            // 2-Letters upper case  
            passwordBuilder.Append(RandomString(2));
            return passwordBuilder.ToString();
        }
        string luuMaXacNhan;
        private void lblGuima_Click(object sender, EventArgs e)
        {
            
            luuMaXacNhan = RandomMa();
            MailMessage message = new MailMessage();
            message.From = new MailAddress("vhao1509@gmail.com");
            message.To.Add(new MailAddress(txtEmail.Text));
            message.Subject = "Mã xác nhận đăng ký";
            message.IsBodyHtml = true; //to make message body as html  
            message.Body = "From Rent-Finder"    + " - Mã xác nhận của bạn là: "+"\n" +"<b>"+luuMaXacNhan.ToString()+"</b>";
            message.IsBodyHtml = true;
            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                try
                {
                    smtp.Credentials = new NetworkCredential("vhao1509@gmail.com", "H01213111038");
                    smtp.EnableSsl = true;
                    smtp.Send(message);
                    MessageBox.Show("Mã xác nhận gửi thành công, vui lòng kiểm tra Email");
                }
                catch
                {
                    MessageBox.Show("Email không tồn tại, vui lòng nhập lại");
                }
               
            }
        }
    }
}
