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
    public partial class ucUser : UserControl
    {
        public ucUser()
        {
            InitializeComponent();
        }
        public ucUser(NguoiDung ngh)
        {
            InitializeComponent();
            _nguoi = ngh;
            
        }
        string urlAvatar="";
        public NguoiDung _nguoi;
        public async void reLoad()
        {
            _nguoi = DataProvider.Ins.DB.NguoiDungs.Where(x => x.maNguoiDung == _nguoi.maNguoiDung).SingleOrDefault();
            picAvatar.LoadAsync("https://upload.wikimedia.org/wikipedia/commons/thumb/d/d3/Microsoft_Account.svg/768px-Microsoft_Account.svg.png");
            if ((string)_nguoi.hoTen != null)
                txtHoTen.Text = _nguoi.hoTen;
            else
                txtHoTen.Text = _nguoi.tenDangNhap;
            lblUsername.Text = _nguoi.tenDangNhap;
            if (_nguoi.hoTen == null)
                lblNameKH.Text = _nguoi.tenDangNhap;
            else
                lblNameKH.Text = _nguoi.hoTen;
            if (_nguoi.urlDaiDien !=null && _nguoi.urlDaiDien != "")
            {
               picAvatar.LoadAsync(_nguoi.urlDaiDien);

            }
        }
        private async void UploadFiles(string url, int idNguoiDung)
        {
            var stream = File.Open(@url, FileMode.Open);
            urlAvatar = "";
            // Construct FirebaseStorage with path to where you want to upload the file and put it there
            var task = new FirebaseStorage("timkiemnhatro-6dd5a.appspot.com")
             .Child("images")
             .Child(idNguoiDung.ToString() + url[2] + url[url.Length - 5])
             .PutAsync(stream);

            // Track progress of the upload
            task.Progress.ProgressChanged += (s, e) => Console.WriteLine($"Progress: {e.Percentage} %");

            // Await the task to wait until upload is completed and get the download url
            var downloadUrl = await task;
            urlAvatar = downloadUrl.ToString();


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Checked == true)//Vo edit
            {
                btnEdit.Checked = false;
                btnEditImage.Visible = true;
                lblHoVaTen.Visible = true;
                txtHoTen.Visible = true;
                lblNhoTen.Visible = true;
                lblSoDienThoai.Visible = true;
                txtPhoneNumber.Visible = true;
                lblDTNho.Visible = true;
                lblNameKH.Visible = false;
                lblkhNho.Visible = false;
                ptrUNho.Visible = false;
                lblUsername.Visible = false;
                ptrdthNho.Visible = false;
                lblPhone.Visible = false;
            }
            else //Thoat edit
            {
                btnEdit.Checked = true;
                btnEditImage.Visible = false;

                lblHoVaTen.Visible = false;
                txtHoTen.Visible = false;
                lblNhoTen.Visible = false;
                lblSoDienThoai.Visible = false;
                txtPhoneNumber.Visible = false;
                lblDTNho.Visible = false;
                lblNameKH.Visible = true;
                lblkhNho.Visible = true;
                ptrUNho.Visible = true;
                lblUsername.Visible = true;
                ptrdthNho.Visible = true;
                lblPhone.Visible = true;

             
                try
                {
                    // Your code...
                    // Could also be before try if you know the exception occurs in SaveChanges
                    var tklol = DataProvider.Ins.DB.NguoiDungs.Where(x => x.maNguoiDung == _nguoi.maNguoiDung).SingleOrDefault();
                    tklol.tenDangNhap = txtHoTen.Text;
                    if (urlAvatar != "")
                        tklol.urlDaiDien = urlAvatar;
                    DataProvider.Ins.DB.SaveChanges();
                    MessageBox.Show("Cập nhật thành công");

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                };

                urlAvatar = "";
                reLoad();
            }
        }

        private void btnNhaDaDang_Click(object sender, EventArgs e)
        {
            (this.Parent.Parent as frmMain).getUCNhaDaDang();
            (this.Parent.Parent as frmMain).setUCNhaDaDangBringtoFront();
        }

        private void btnNhaDaLuu_Click(object sender, EventArgs e)
        {
            (this.Parent.Parent as frmMain).getUCYeuThich();
            (this.Parent.Parent as frmMain).setUCNhaYeuThichBringtoFront();
        }

        private void btnEditImage_Click(object sender, EventArgs e)
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
                UploadFiles(op.FileName, _nguoi.maNguoiDung);
            }
        }
    }
}
