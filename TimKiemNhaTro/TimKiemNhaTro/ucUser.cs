﻿using Firebase.Storage;
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
        public int _maNguoiDung=1;
        string urlAvatar="";
        NguoiDung _nguoi=new NguoiDung();
        public async void reLoad()
        {
            _nguoi = new NguoiDung();
            _nguoi = DataProvider.Ins.DB.NguoiDungs.Where(x => x.maNguoiDung == _maNguoiDung).SingleOrDefault();
            picAvatar.Image = null;
            txtHoTen.Text = _nguoi.hoTen;
            lblUsername.Text = _nguoi.tenDangNhap;
            lblNameKH.Text = _nguoi.hoTen;
            if (_nguoi.urlDaiDien !=null && _nguoi.urlDaiDien != "")
            {
                await Task.Run(() => picAvatar.LoadAsync(_nguoi.urlDaiDien));

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
                    _nguoi.hoTen = txtHoTen.Text;
                    ////if (urlAvatar != "")
                    ////    _nguoi.urlDaiDien = urlAvatar.ToString();
                    DataProvider.Ins.DB.SaveChanges();

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
                UploadFiles(op.FileName, _maNguoiDung);
            }
        }
    }
}
