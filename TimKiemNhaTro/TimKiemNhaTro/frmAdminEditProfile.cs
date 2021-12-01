using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimKiemNhaTro.Model;

namespace TimKiemNhaTro
{
    public partial class frmAdminEditProfile : Form
    {
        NguoiDung _nguoiDung;
        string fileName = "";
        public frmAdminEditProfile(NguoiDung nguoiDung)
        {
            InitializeComponent();
            _nguoiDung = nguoiDung;
            if (_nguoiDung.hoTen == null || _nguoiDung.hoTen == "") txtHoTen.Text = "";
            txtHoTen.Text = _nguoiDung.hoTen;
            if (_nguoiDung.sdt == null || _nguoiDung.sdt == "") txtSDT.Text = "";
            txtSDT.Text = _nguoiDung.sdt;
            if (_nguoiDung.urlDaiDien != null && _nguoiDung.urlDaiDien != "") picAvatar.LoadAsync(_nguoiDung.urlDaiDien);
            else picAvatar.LoadAsync("https://www.clipartmax.com/png/full/110-1104174_computer-icons-user-clip-art-lily-pad-coloring-page.png");
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Trim() == "" || txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            NguoiDung nguoi = DataProvider.Ins.DB.NguoiDungs.Where(x => x.maNguoiDung == _nguoiDung.maNguoiDung).SingleOrDefault();
            if (nguoi == null) return;
            nguoi.hoTen = txtHoTen.Text;
            nguoi.sdt = txtSDT.Text;
            if (fileName != "") nguoi.urlDaiDien = await UploadFiles(fileName, _nguoiDung.maNguoiDung);
            DataProvider.Ins.DB.SaveChanges();
            MessageBox.Show("Cập nhật thông tin thành công");
            Close();
        }

        private void btnChonTep_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (op.ShowDialog() == DialogResult.OK)
            {
                this.picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
                using (var fs = File.OpenRead(op.FileName))
                {
                    picAvatar.Image = Image.FromStream(fs);
                }
                fileName = op.FileName;
            }
        }
        private async Task<String> UploadFiles(string url, int idNguoiDung)
        {
            var stream = File.Open(@url, FileMode.Open);
            //urlAvatar = "";
            // Construct FirebaseStorage with path to where you want to upload the file and put it there
            var task = new FirebaseStorage("timkiemnhatro-6dd5a.appspot.com")
             .Child("images")
             .Child(idNguoiDung.ToString() + url[2] + url[url.Length - 5])
             .PutAsync(stream);

            // Track progress of the upload
            task.Progress.ProgressChanged += (s, e) => Console.WriteLine($"Progress: {e.Percentage} %");

            // Await the task to wait until upload is completed and get the download url
            var downloadUrl = await task;
            return downloadUrl;


        }
    }
}
