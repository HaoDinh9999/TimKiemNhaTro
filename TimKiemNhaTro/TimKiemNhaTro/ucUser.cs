using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

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
        frmMain _frmM;
        public ucUser(NguoiDung ngh,frmMain frm)
        {
            InitializeComponent();
            _nguoi = ngh;
            _frmM = frm;
            
        }
        string urlAvatar="";
        public NguoiDung _nguoi;
        public void reloadColorUser()
        {
            this.BackColor = _frmM.nenColor;
        }
        public async void reLoad()
        {
            _nguoi = DataProvider.Ins.DB.NguoiDungs.Where(x => x.maNguoiDung == _nguoi.maNguoiDung).SingleOrDefault();

            if ((string)_nguoi.sdt != null && _nguoi.sdt != "")
            {
                txtPhoneNumber.Text = _nguoi.sdt;
                lblPhone.Text = _nguoi.sdt;
            }
            else
            {
                txtPhoneNumber.Text = "";
                lblPhone.Text = "Chưa có";
            }
            if ((string)_nguoi.hoTen != null && _nguoi.hoTen != "")
                txtHoTen.Text = _nguoi.hoTen;
            else
                txtHoTen.Text = "";
            lblUsername.Text = _nguoi.email;
            if (_nguoi.hoTen == null || _nguoi.hoTen == "")
                lblNameKH.Text = "Chưa đặt tên";
            else
                lblNameKH.Text = _nguoi.hoTen;
            if (_nguoi.urlDaiDien != null && _nguoi.urlDaiDien != "")
            {
                picAvatar.LoadAsync(_nguoi.urlDaiDien);

            }
            else picAvatar.LoadAsync("https://www.clipartmax.com/png/full/110-1104174_computer-icons-user-clip-art-lily-pad-coloring-page.png");
        }
        private async Task UploadFiles(string url, int idNguoiDung)
        {
            var stream = File.Open(@url, FileMode.Open);

            urlAvatar = "";
            // Construct FirebaseStorage with path to where you want to upload the file and put it there
            var task = new FirebaseStorage("nhatro-a2ad8.appspot.com")
             .Child("images")
             .Child(idNguoiDung.ToString() + url[2] + url[url.Length - 5])
             .PutAsync(stream);

            // Track progress of the upload
            task.Progress.ProgressChanged += (s, e) => Console.WriteLine($"Progress: {e.Percentage} %");

            // Await the task to wait until upload is completed and get the download url
            var downloadUrl = await task;
            urlAvatar = downloadUrl.ToString();
            MessageBox.Show("Upload file ảnh thành công");

        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Checked == true)//Vo edit
            {
                btnEdit.Checked = false;
                btnEditImage.Visible = true;
                btnCamera.Visible = true;
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
                btnCamera.Visible = false;

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
                    tklol.hoTen = txtHoTen.Text;
                    tklol.sdt = txtPhoneNumber.Text;
                    if (saveFileDialog1.FileName != "")
                    {
                       await UploadFiles(saveFileDialog1.FileName, _nguoi.maNguoiDung);

                    }
                    else if (op!=null &&op.FileName!="")
                    {
                       await UploadFiles(op.FileName, _nguoi.maNguoiDung);

                    }
                    if (urlAvatar != "")
                        tklol.urlDaiDien = urlAvatar;
                    DataProvider.Ins.DB.SaveChanges();
                    MessageBox.Show("Cập nhật thành công");

                    _frmM.reLoadNguoiDung();

                }
                catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
                    Exception raise = dbEx;
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            string message = string.Format("{0}:{1}",
                                validationErrors.Entry.Entity.ToString(),
                                validationError.ErrorMessage);
                            // raise a new exception nesting  
                            // the current instance as InnerException  
                            raise = new InvalidOperationException(message, raise);
                        }
                    }
                    throw raise;
                }
                timer1.Enabled = false;
                if (cap != null) cap.Dispose();
                savechupAnh = false;
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
        OpenFileDialog op;
        private void btnEditImage_Click(object sender, EventArgs e)
        {
            op = new OpenFileDialog();
            op.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (op.ShowDialog() == DialogResult.OK)
            {
                timer1.Enabled = false;
                if (cap != null) cap.Dispose();
                savechupAnh = false;
                this.picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
                using (var fs = File.OpenRead(op.FileName))
                {
                    picAvatar.Image = Image.FromStream(fs);
                }
                saveFileDialog1.FileName = "";
                //UploadFiles(op.FileName, _nguoi.maNguoiDung);
            }
        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            (this.Parent.Parent as frmMain).getFAQ();
            (this.Parent.Parent as frmMain).setUCFAQBringtoFront();
        }

        private void btnLoiUngDung_Click(object sender, EventArgs e)
        {
            frmBaoCaoLoiUngDung frmLoi = new frmBaoCaoLoiUngDung(_nguoi);
            frmLoi.Show();
        }
        private Capture cap;


        private void ucUser_Load(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Image<Bgr, byte> nextFrame = cap.QueryFrame();
                Image gray = ToolStripRenderer.CreateDisabledImage(nextFrame.ToBitmap());
                picAvatar.Image = nextFrame.ToBitmap();
            }
            catch
            {
                MessageBox.Show("Loi camera");
            }
           

        }
        bool savechupAnh = false;
        private void btnCamera_Click(object sender, EventArgs e)
        {
            if(op!=null)
            op.FileName = "";
            if (savechupAnh == true)
            {
                saveFileDialog1.InitialDirectory = "";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    picAvatar.Image.Save(saveFileDialog1.FileName);
                    //UploadFiles(saveFileDialog1.FileName, _nguoi.maNguoiDung);
                    cap.Dispose();
                    savechupAnh = false;
                    timer1.Enabled = false;
                    btnCamera.Text = "Camera";
                }
            }
            else
            {
                cap = new Capture(0);
                timer1.Enabled = true;
                savechupAnh = true;
                btnCamera.Text = "Chụp ảnh";
            }
            
        }

        private void ptrFacebook_Click(object sender, EventArgs e)
        {
            _frmM.getUCTinTuc().setURL("https://www.fb.com/");
            _frmM.setUCTinTucBringtoFront();
        }

        private void ptrInsta_Click(object sender, EventArgs e)
        {
            _frmM.getUCTinTuc().setURL("https://www.instagram.com/");
            _frmM.setUCTinTucBringtoFront();
        }

        private void ptrTwitter_Click(object sender, EventArgs e)
        {
            _frmM.getUCTinTuc().setURL("https://twitter.com/home");
            _frmM.setUCTinTucBringtoFront();
        }
    }
}
