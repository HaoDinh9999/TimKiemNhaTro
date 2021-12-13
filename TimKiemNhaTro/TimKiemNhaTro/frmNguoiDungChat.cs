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
    public partial class frmNguoiDungChat : Form
    {
        DateTime last;
        NguoiDung _nguoiGui, _nguoiNhan;
        string fileName = "";
        public frmNguoiDungChat(NguoiDung nguoiGui, NguoiDung nguoiNhan)
        {
            InitializeComponent();
            timer1.Interval = 5000;
            timer1.Tick += Timer1_Tick;
            _nguoiGui = nguoiGui;
            _nguoiNhan = nguoiNhan;
            LoadTinNhan();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            List<TinNhan> tinNhans = DataProvider.Ins.DB.TinNhans.OrderBy(x => x.ngayGui).Where(x => (x.maNguoiGui == _nguoiNhan.maNguoiDung && x.maNguoiNhan == _nguoiGui.maNguoiDung) || (x.maNguoiGui == _nguoiGui.maNguoiDung && x.maNguoiNhan == _nguoiNhan.maNguoiDung)).ToList();
            if (tinNhans.Count == 0) return;
            if (last != tinNhans.Last().ngayGui)
            {
                tinNhans = tinNhans.Where(x => x.ngayGui > last).ToList();
                for (int i = 0; i < tinNhans.Count; i++)
                {
                    var card = new ucTinNhanCard(tinNhans[i], _nguoiGui, _nguoiNhan);
                    card.SetInfo();
                    flowLayoutPanel1.Controls.Add(card);
                    card.SetLocation();
                    flowLayoutPanel1.ScrollControlIntoView(card);

                }
                if (tinNhans.Count > 0) last = tinNhans.Last().ngayGui;
            }
        }

        public void LoadTinNhan()
        {
            flowLayoutPanel1.Controls.Clear();
            List<TinNhan> tinNhans = DataProvider.Ins.DB.TinNhans.OrderBy(x => x.ngayGui).Where(x => (x.maNguoiGui == _nguoiNhan.maNguoiDung && x.maNguoiNhan == _nguoiGui.maNguoiDung) || (x.maNguoiGui == _nguoiGui.maNguoiDung && x.maNguoiNhan == _nguoiNhan.maNguoiDung)).ToList();
            for (int i = 0; i < tinNhans.Count; i++)
            {
                var card = new ucTinNhanCard(tinNhans[i], _nguoiGui, _nguoiNhan);
                card.SetInfo();
                flowLayoutPanel1.Controls.Add(card);
                card.SetLocation();
                flowLayoutPanel1.ScrollControlIntoView(card);

            }
            if (tinNhans.Count > 0) last = tinNhans.Last().ngayGui;
            timer1.Start();
        }
        private async Task<String> UploadFiles(string url)
        {
            var stream = File.Open(@url, FileMode.Open);
            //urlAvatar = "";
            // Construct FirebaseStorage with path to where you want to upload the file and put it there
            var task = new FirebaseStorage("nhatro-a2ad8.appspot.com")
             .Child("chat")
             .Child(url)
             .PutAsync(stream);

            // Track progress of the upload
            task.Progress.ProgressChanged += (s, e) => Console.WriteLine($"Progress: {e.Percentage} %");

            // Await the task to wait until upload is completed and get the download url
            var downloadUrl = await task;
            return downloadUrl;


        }
        private async void btnGuiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (op.ShowDialog() == DialogResult.OK)
            {
                //this.picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
                //using (var fs = File.OpenRead(op.FileName))
                //{
                //    picAvatar.Image = Image.FromStream(fs);
                //}
                fileName = op.FileName;
            }
            if (fileName != "")
            {
                TinNhan tin = new TinNhan { maNguoiGui = _nguoiGui.maNguoiDung, loai=2, maNguoiNhan = _nguoiNhan.maNguoiDung, noiDung = await UploadFiles(fileName), ngayGui = DateTime.Now };
                DataProvider.Ins.DB.TinNhans.Add(tin);
                DataProvider.Ins.DB.SaveChanges();
            } 
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            if (txtNoiDung.Text.Trim() != "")
            {
                TinNhan tin = new TinNhan { maNguoiGui = _nguoiGui.maNguoiDung, loai = 1, maNguoiNhan = _nguoiNhan.maNguoiDung, noiDung = txtNoiDung.Text, ngayGui = DateTime.Now };

                DataProvider.Ins.DB.TinNhans.Add(tin);
                DataProvider.Ins.DB.SaveChanges();
                last = tin.ngayGui;
                var card = new ucTinNhanCard(tin, _nguoiGui, _nguoiNhan);
                card.SetInfo();
                flowLayoutPanel1.Controls.Add(card);
                card.SetLocation();
                flowLayoutPanel1.ScrollControlIntoView(card);

                txtNoiDung.Text = "";
            }
        }
    }
}
