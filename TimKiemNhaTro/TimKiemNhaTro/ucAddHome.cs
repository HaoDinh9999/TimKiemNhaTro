using Firebase.Storage;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimKiemNhaTro.Model;

namespace TimKiemNhaTro
{
    public partial class ucAddHome : UserControl
    {
        public ucAddHome()
        {
            InitializeComponent();
        }
        public ucAddHome(NguoiDung ng)
        {
            InitializeComponent();
            _userAdd = ng;
        }
        public NguoiDung _userAdd;
        public List<Districts> listt = new List<Districts>();
        List<string> fileList = new List<string>();
        public int maLoaiNha = 0, soPhongNgu = 0, soPhongTam = 0;
        public bool baixe = false, bancong = false, baove = false, cctv = false, dieuhoa = false, gaclung = false, santhuong = false, hoboi = false, maygiat = false, noithat = false, nuoithucung = false;
       public void reloadColor(Color clr)
        {
            this.BackColor = clr;
        }
        private void ucAddHome_Load(object sender, EventArgs e)
        {
            listt.Add(new Districts("Quận 1", Quan1));
            listt.Add(new Districts("Quận 2", Quan2));
            listt.Add(new Districts("Quận 3", Quan3));
            listt.Add(new Districts("Quận 4", Quan4));
            listt.Add(new Districts("Quận 5", Quan5));
            listt.Add(new Districts("Quận 6", Quan6));
            listt.Add(new Districts("Quận 7", Quan7));
            listt.Add(new Districts("Quận 8", Quan8));
            listt.Add(new Districts("Quận 9", Quan9));
            listt.Add(new Districts("Quận 10", Quan10));
            listt.Add(new Districts("Quận 11", Quan11));
            listt.Add(new Districts("Quận 12", Quan12));
            listt.Add(new Districts("Quận Bình Tân", QuanBinhTan));
            listt.Add(new Districts("Quận Thủ Đức", ThuDuc));
            listt.Add(new Districts("Quận Tân Phú", QuanTanPhu));
            listt.Add(new Districts("Quận Tân Bình", QuanTanBinh));
            listt.Add(new Districts("Quận Phú Nhuận", QuanPhuNhuan));
            listt.Add(new Districts("Quận Gò Vấp", QuanGoVap));
            listt.Add(new Districts("Quận Bình Thạnh", QuanBinhThanh));
            listt.Add(new Districts("Huyện Bình Chánh", HuyenBinhChanh));
            listt.Add(new Districts("Huyện Cần Giờ", HuyenCanGio));
            listt.Add(new Districts("Huyện Củ Chi", HuyenCuChi));
            listt.Add(new Districts("Huyện Hóc Môn", HuyenHocMon));
            listt.Add(new Districts("Huyện Nhà Bè", HuyenNhaBe));
            cbxQuanHuyen.Items.Clear();
            for(int i = 0; i < AllQuan.Length; i++)
            {
                cbxQuanHuyen.Items.Add(AllQuan[i]);
            }
            
            if (nhaeidt != null)
            {
                btnDangTin.Text = "Lưu thông tin";
            }
            else
            {
                btnDangTin.Text = "Đăng tin";
            }
        }
        public void reSet1()
        {
            //cbxTinhTrang.Text = "Còn trống";
            //cbxQuanHuyen.Text = "";
            //cbxPhuongXa.Text = "";
            //txtSoNha.Text = "";
            //txtTenDuong.Text = "";
            //btnNha.Checked = false;
            //btnPhong.Checked = false;
            //btnCanHo.Checked = false;
            //btn1Ngu.Checked = false;
            //btn2Ngu.Checked = false;
            //btn3Ngu.Checked = false;
            //btnHon4Ngu.Checked = false;
            //btn1Tam.Checked = false;
            //btn2Tam.Checked = false;
            //btn3Tam.Checked = false;
            //btnHon4Tam.Checked = false;
            //btn1Ngu.Checked = false;
            //btnDieuHoa.Checked = false;
            //btnBanCong.Checked = false;
            //btnMayGiat.Checked = false;
            //btnGacLung.Checked = false;
            //btnNoiThat.Checked = false;
            //btnBaoVe.Checked = false;
            //btnHoBoi.Checked = false;
            //btnBaiXe.Checked = false;
            //btnSanThuong.Checked = false;
            //btnCCTV.Checked = false;
            //btnThuCung.Checked = false;
            //txtDienTich.Text = "";
            //txtTienChoThue.Text = "";
            //txtMoTa.Text = "";
            pnlPic.Controls.Clear();
            nhaeidt = null;
            if (nhaeidt != null)
            {
                btnDangTin.Text = "Lưu thông tin";
            }
            else
            {
                btnDangTin.Text = "Đăng tin";
            }

            anhBiXoa.Clear();
            fileList.Clear();


        }
        Nha nhaeidt;
        List<int> anhBiXoa = new List<int>();
        public void LoadEditNha(Nha nhalol)
        {
            reSet1();
            
            nhaeidt = nhalol;

            if (nhaeidt != null)
            {
                btnDangTin.Text = "Lưu thông tin";
            }
            else
            {
                btnDangTin.Text = "Đăng tin";
            }
            cbxTinhTrang.Text = nhaeidt.tinhTrang;
            cbxPhuongXa.Text = nhaeidt.phuongXa.ToString();
            cbxQuanHuyen.Text = nhaeidt.quanHuyen;
            txtSoNha.Text = nhaeidt.soNha;
            //txtTenDuong.Text = nhaeidt.soNha;
            if (nhaeidt.maLoaiChoThue == 1)
            {
                btnNha.Checked = true;
                btnCanHo.Checked = false;
                btnPhong.Checked = false;
                maLoaiNha = 1;
            }
            else if (nhaeidt.maLoaiChoThue == 2)
            {
                btnNha.Checked = false;
                btnCanHo.Checked = false;
                btnPhong.Checked = true;
                maLoaiNha = 2;
            }
            else if (nhaeidt.maLoaiChoThue == 3)
            {
                btnNha.Checked = false;
                btnCanHo.Checked = true;
                btnPhong.Checked = false;
                maLoaiNha = 3;
            }
            //PhongNgu
            if (nhaeidt.soPhongNgu == 1)
            {
                btn1Ngu.Checked = true;
                soPhongNgu = 1;
            }
            else if (nhaeidt.soPhongNgu == 2)
            {
                btn2Ngu.Checked = true;
                soPhongNgu = 2;
            }
            else if (nhaeidt.soPhongNgu == 3)
            {
                btn3Ngu.Checked = true;
                soPhongNgu = 3;
            }
            else if (nhaeidt.soPhongNgu >3)
            {
                btnHon4Ngu.Checked = true;
                soPhongNgu = 4;
            }
            //PhongTam
            if (nhaeidt.soPhongTam == 1)
            {
                btn1Tam.Checked = true;
                soPhongTam = 1;
            }
            else if (nhaeidt.soPhongTam == 2)
            {
                btn2Tam.Checked = true;
                soPhongTam = 2;
            }
            else if (nhaeidt.soPhongTam == 3)
            {
                btn3Tam.Checked = true;
                soPhongTam = 3;
            }
            else if (nhaeidt.soPhongTam > 3)
            {
                btnHon4Tam.Checked = true;
                soPhongTam = 4;
            }
            //
            txtDienTich.Text = nhaeidt.dienTich.ToString();
            txtTienChoThue.Text = nhaeidt.TienNha.ToString();
            //CoSoVatChat
            btnDieuHoa.Checked = (bool)nhaeidt.CoSoVatChat.dieuHoa;
            btnBanCong.Checked = (bool)nhaeidt.CoSoVatChat.banCong;
            btnMayGiat.Checked = (bool)nhaeidt.CoSoVatChat.mayGiat;
            btnGacLung.Checked = (bool)nhaeidt.CoSoVatChat.gacLung;
            btnNoiThat.Checked = (bool)nhaeidt.CoSoVatChat.noiThat;
            btnBaoVe.Checked = (bool)nhaeidt.CoSoVatChat.baoVe;
            btnHoBoi.Checked = (bool)nhaeidt.CoSoVatChat.hoBoi;
            btnBaiXe.Checked = (bool)nhaeidt.CoSoVatChat.baiDauXe;
            btnSanThuong.Checked = (bool)nhaeidt.CoSoVatChat.sanThuong;
            btnCCTV.Checked = (bool)nhaeidt.CoSoVatChat.cctv;
            btnThuCung.Checked = (bool)nhaeidt.CoSoVatChat.nuoiThuCung;
            txtMoTa.Text = nhaeidt.moTa;
            //Anh
            var urlDan = nhaeidt.AnhNhas.ToList();
            int x = 20;
            int y = 20;
            int maxHeight = -1;
            anhBiXoa.Clear();
            fileList.Clear();

            //foreach (var item in urlDan)
            //{
            //    GunaPictureBox pic = new GunaPictureBox();              
            //    GunaCircleButton btn = new GunaCircleButton();
            //    //button
            //    btn.Text = "X";
            //    btn.Font = new Font("Arial", 15, FontStyle.Bold);
            //    btn.OnHoverBaseColor = Color.Black;
            //    btn.Width = 30;
            //    btn.Height = 30;
            //    btn.BaseColor = Color.Black;
            //    btn.Tag = item.maAnhNha;
            //    anhBiXoa.Clear();
            //    btn.MouseClick += new MouseEventHandler((o, a) =>
            //    {
            //        anhBiXoa.Add(Int32.Parse(btn.Tag.ToString()));
            //        reSetPanelPic();
            //    }
            //    );


            //    //pic
            //    pic.Tag = item.maAnhNha;
            //    pic.SizeMode = PictureBoxSizeMode.StretchImage;
            //    pic.Width = 250;
            //    pic.Height = 200;
            //    pic.Radius = 10;
            //    pic.Location = new Point(x, y);
            //    btn.Location = new Point(x + pic.Width - 30, y - 5);


            //    x += pic.Width + 10;
            //    maxHeight = Math.Max(pic.Height, maxHeight);
            //    if (x > this.ClientSize.Width - 100)
            //    {
            //        x = 20;
            //        y += maxHeight + 10;
            //    }
            //    pic.LoadAsync(item.duongDan);
            //    pnlPic.Controls.Add(pic);
            //    pnlPic.Controls.Add(btn);
            //    btn.BringToFront();
            //    //Xoa anh


            //}

            reSetPanelPic();
        }
        private void btnNoiThat_Click(object sender, EventArgs e)
        {
            if (btnNoiThat.Checked == true)
            {
                btnNoiThat.Checked = false;
                noithat = false;
            }
            else
            {
                btnNoiThat.Checked = true;
                noithat = true;
            }
            
        }

        private void btnCCTV_Click(object sender, EventArgs e)
        {
            if (btnCCTV.Checked == true)
            {
                btnCCTV.Checked = false;
                cctv = false;
            }
            else
            {
                btnCCTV.Checked = true;
                cctv = true;
            }
        }

        private void btnSanThuong_Click(object sender, EventArgs e)
        {
            if (btnSanThuong.Checked == true)
            {
                btnSanThuong.Checked = false;
                santhuong = false;
            }
            else
            {
                btnSanThuong.Checked = true;
                santhuong = true;
            }
        }

        private void btnBaiXe_Click(object sender, EventArgs e)
        {
            if (btnBaiXe.Checked == true)
            {
                btnBaiXe.Checked = false;
                baixe = false;
            }
            else
            {
                btnBaiXe.Checked = true;
                baixe = true;
            }
        }

        private void btnHoBoi_Click(object sender, EventArgs e)
        {
            if (btnHoBoi.Checked == true)
            {
                btnHoBoi.Checked = false;
                hoboi = false;
            }
            else
            {
                btnHoBoi.Checked = true;
                hoboi = true;
            }
        }

        private void btnBaoVe_Click(object sender, EventArgs e)
        {
            if (btnBaoVe.Checked == true)
            {
                btnBaoVe.Checked = false;
                baove = false;
            }
            else
            {
                btnBaoVe.Checked = true;
                baove = true;
            }
        }

        private void btnGacLung_Click(object sender, EventArgs e)
        {
            if (btnGacLung.Checked == true)
            {
                btnGacLung.Checked = false;
                gaclung = false;
            }
            else
            {
                btnGacLung.Checked = true;
                gaclung = true;
            }
        }

        private void btnThuCung_Click(object sender, EventArgs e)
        {
            if (btnThuCung.Checked == true)
            {
                btnThuCung.Checked = false;
                nuoithucung = false;
            }
            else
            {
                btnThuCung.Checked = true;
                nuoithucung = true;
            }
        }

        private void btnMayGiat_Click(object sender, EventArgs e)
        {
            if (btnMayGiat.Checked == true)
            {
                btnMayGiat.Checked = false;
                maygiat = false;
            }
            else
            {
                btnMayGiat.Checked = true;
                maygiat = true;
            }
        }

        private void btnBanCong_Click(object sender, EventArgs e)
        {
            if (btnBanCong.Checked == true)
            {
                btnBanCong.Checked = false;
                bancong = false;
            }
            else
            {
                btnBanCong.Checked = true;
                bancong = true;
            }
        }

        private void btnDieuHoa_Click(object sender, EventArgs e)
        {
            if (btnDieuHoa.Checked == true)
            {
                btnDieuHoa.Checked = false;
                dieuhoa = false;
            }
            else
            {
                btnDieuHoa.Checked = true;
                dieuhoa = true;
            }
        }

        private void btnHon4Ngu_Click(object sender, EventArgs e)
        {
            btn1Ngu.Checked = false;
            btn2Ngu.Checked = false;
            btn3Ngu.Checked = false;
            btnHon4Ngu.Checked = true;
            soPhongNgu = 4;
        }

        private void btn3Ngu_Click(object sender, EventArgs e)
        {
            btn1Ngu.Checked = false;
            btn2Ngu.Checked = false;
            btn3Ngu.Checked = true;
            btnHon4Ngu.Checked = false;
            soPhongNgu = 3;
        }

        private void btn2Ngu_Click(object sender, EventArgs e)
        {
            btn1Ngu.Checked = false;
            btn2Ngu.Checked = true;
            btn3Ngu.Checked = false;
            btnHon4Ngu.Checked = false;
            soPhongNgu = 2;
        }

        private void btn1Ngu_Click(object sender, EventArgs e)
        {
            btn1Ngu.Checked = true;
            btn2Ngu.Checked = false;
            btn3Ngu.Checked = false;
            btnHon4Ngu.Checked = false;
            soPhongNgu = 1;
        }

        private void btnHon4Tam_Click(object sender, EventArgs e)
        {
            btn1Tam.Checked = false;
            btn2Tam.Checked = false;
            btn3Tam.Checked = false;
            btnHon4Tam.Checked = true;
            soPhongTam = 4;
        }

        private void btn3Tam_Click(object sender, EventArgs e)
        {
            btn1Tam.Checked = false;
            btn2Tam.Checked = false;
            btn3Tam.Checked = true;
            btnHon4Tam.Checked = false;
            soPhongTam = 3;
        }

        private void btn2Tam_Click(object sender, EventArgs e)
        {
            btn1Tam.Checked = false;
            btn2Tam.Checked = true;
            btn3Tam.Checked = false;
            btnHon4Tam.Checked = false;
            soPhongTam = 2;
        }

        private void btn1Tam_Click(object sender, EventArgs e)
        {
            btn1Tam.Checked = true;
            btn2Tam.Checked = false;
            btn3Tam.Checked = false;
            btnHon4Tam.Checked = false;
            soPhongTam = 1;
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            btnNha.Checked = false;
            btnCanHo.Checked = false;
            btnPhong.Checked = true;
            maLoaiNha = 2;
        }

        private void btnCanHo_Click(object sender, EventArgs e)
        {
            btnNha.Checked = false;
            btnCanHo.Checked = true;
            btnPhong.Checked = false;
            maLoaiNha = 3;
        }

        private void btnNha_Click(object sender, EventArgs e)
        {
            btnNha.Checked = true;
            btnCanHo.Checked = false;
            btnPhong.Checked = false;
            maLoaiNha = 1;
        }
        void reSet()
        {
            pnlPic.Controls.Clear();
        }
        private async Task UploadFiles(string url, string _idNha)
        {
            var stream = File.Open(@url, FileMode.Open);
            
                // Construct FirebaseStorage with path to where you want to upload the file and put it there
                var task = new FirebaseStorage("nhatro-a2ad8.appspot.com")
                 .Child("images")
                 .Child(_idNha + url[2] + url[url.Length - 5] )
                 .PutAsync(stream);

                // Track progress of the upload
                task.Progress.ProgressChanged += (s, e) => Console.WriteLine($"Progress: {e.Percentage} %");

                // Await the task to wait until upload is completed and get the download url
                var downloadUrl = await task;
                 DataProvider.Ins.DB.AnhNhas.Add(new AnhNha() { maNha=Int32.Parse(_idNha),duongDan=downloadUrl});
                 //DataProvider.Ins.DB.SaveChanges();
            



        }

        void reSetPanelPic()
        {
            pnlPic.Controls.Clear();
            int x = 20;
            int y = 20;
            int maxHeight = -1;
            //Firebase
            bool canXoa = false;
            //button
            if (nhaeidt!=null)
            {
                foreach (var item in nhaeidt.AnhNhas.ToList())
                {
                    GunaPictureBox pic = new GunaPictureBox();
                    GunaCircleButton btn = new GunaCircleButton();
                    btn.Text = "X";
                    btn.Font = new Font("Arial", 15, FontStyle.Bold);
                    btn.OnHoverBaseColor = Color.Black;
                    btn.Width = 30;
                    btn.Height = 30;
                    btn.BaseColor = Color.Black;
                    btn.Tag = item.maAnhNha;
                    btn.MouseClick += new MouseEventHandler((o, a) =>
                    {
                        anhBiXoa.Add(Int32.Parse(btn.Tag.ToString()));
                        reSetPanelPic();
                    });
                    foreach (var xoaanh in anhBiXoa)
                    {
                        if (xoaanh == item.maAnhNha)
                        {
                            canXoa = true;
                            break;
                        }
                    }
                    if (canXoa != true)
                    {
                        pic.Tag = item.maAnhNha;
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Width = 250;
                        pic.Height = 200;
                        pic.Radius = 10;
                        pic.Location = new Point(x, y);
                        btn.Location = new Point(x + pic.Width - 30, y - 5);

                        x += pic.Width + 10;
                        maxHeight = Math.Max(pic.Height, maxHeight);
                        if (x > this.ClientSize.Width - 100)
                        {
                            x = 20;
                            y += maxHeight + 10;
                        }
                        pic.LoadAsync(item.duongDan);
                        pnlPic.Controls.Add(pic);
                        pnlPic.Controls.Add(btn);
                        btn.BringToFront();
                    }
                    canXoa = false;
                }
            }
           
            //Anhpicfile
            foreach (string file in fileList)
            {
                GunaPictureBox pic = new GunaPictureBox();
                GunaCircleButton btn = new GunaCircleButton();
                btn.Text = "X";
                btn.Font = new Font("Arial", 15, FontStyle.Bold);
                btn.OnHoverBaseColor = Color.Black;
                btn.Width = 30;
                btn.Height = 30;
                btn.BaseColor = Color.Black;
                btn.MouseClick += new MouseEventHandler((o, a) =>
                {
                    fileList.Remove(file);
                    reSetPanelPic();
                });
                using (var fs = File.OpenRead(file))
                {
                    pic.Image = Image.FromStream(fs);
                }
                //using (var img = Image.FromStream(fs))
                //{
                //    MessageBox.Show(img.Width.ToString());
                //}
                //pic.Image = Image.FromFile(@"H:\\cc2.png");
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Radius = 10;
                pic.Width = 250;
                pic.Height = 200;
                pic.Tag = file.ToString();
                pic.Location = new Point(x, y);
                btn.Location = new Point(x + pic.Width - 30, y - 5);

                x += pic.Width + 10;
                maxHeight = Math.Max(pic.Height, maxHeight);
                if (x > this.ClientSize.Width - 100)
                {
                    x = 20;
                    y += maxHeight + 10;
                }
                pnlPic.Controls.Add(pic);
                pnlPic.Controls.Add(btn);
                btn.BringToFront();
                // UploadFiles(img);
            }
        }
        private void btnPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Toi thieu 2 - Toi ta 8";
            ofd.Multiselect = true;
            ofd.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
            DialogResult dr = ofd.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (var item in ofd.FileNames)
                {
                    fileList.Add(item);
                }
            }
            reSetPanelPic();
            //"Phường Bến Nghé",
            //"Phường Bến Thành",
            //"Phường Cầu Kho",
            //"Phường Cầu Ông Lãnh",
            //"Phường Cô Giang",
            //"Phường Đa Kao",
            //"Phường Nguyễn Cư Trinh",
            //"Phường Nguyễn Thái Bình",
            //"Phường Phạm Ngũ Lão",
            //"Phường Phường Tân Định",];
        }
        string[] Quan1 =
        {
        "Phường Bến Nghé",
        "Phường Bến Thành",
        "Phường Cầu Kho",
        "Phường Cầu Ông Lãnh",
        "Phường Cô Giang",
        "Phường Đa Kao",
        "Phường Nguyễn Cư Trinh",
        "Phường Nguyễn Thái Bình",
        "Phường Phạm Ngũ Lão",
        "Phường Phường Tân Định"
        };
        string[] Quan2 =
       {
          "Phường An Khánh",
    "Phường An Lợi Đông",
    "Phường An Phú",
    "Phường Bình An",
    "Phường Bình Khánh",
    "Phường Bình Trưng Đông",
    "Phường Bình Trưng Tây",
    "Phường Cát Lái",
    "Phường Thạnh Mỹ Lợi",
    "Phường Thảo Điền",
    "Phường Thủ Thiêm"
    };
        string[] Quan3 =
        {
    "Phường 1",
    "Phường 2",
    "Phường 3",
    "Phường 4",
    "Phường 5",
    "Phường 6",
    "Phường 7",
    "Phường 8",
    "Phường 9",
    "Phường 10",
    "Phường 11",
    "Phường 12",
    "Phường 13",
    "Phường 14",
    };
        string[] Quan4 =
        {
             "Phường 1",
    "Phường 2",
    "Phường 3",
    "Phường 4",
    "Phường 5",
    "Phường 6",
    "Phường 7",
    "Phường 8",
    "Phường 9",
    "Phường 10",
    "Phường 11",
    "Phường 12",
    "Phường 13",
    "Phường 14",
        };
        string[] Quan5 =
        {
            "Phường 1",
    "Phường 2",
    "Phường 3",
    "Phường 4",
    "Phường 5",
    "Phường 6",
    "Phường 7",
    "Phường 8",
    "Phường 9",
    "Phường 10",
    "Phường 11",
    "Phường 12",
    "Phường 13",
    "Phường 14",
    "Phường 15"
        };
        string[] Quan6 =
        {
              "Phường 1",
    "Phường 2",
    "Phường 3",
    "Phường 4",
    "Phường 5",
    "Phường 6",
    "Phường 7",
    "Phường 8",
    "Phường 9",
    "Phường 10",
    "Phường 11",
    "Phường 12",
    "Phường 13",
    "Phường 14",
        };
        string[] Quan7 =
        {
             "Phường Bình Thuận",
    "Phường Phú Mỹ",
    "Phường Phú Thuận",
    "Phường Tân Hưng",
    "Phường Tân Kiểng",
    "Phường Tân Phong",
    "Phường Tân Phú",
    "Phường Tân Quy",
    "Phường Tân Thuận Đông",
    "Phường Tân Thuận Tây",
        };
        string[] Quan8 =
        {
             "Phường 1",
    "Phường 2",
    "Phường 3",
    "Phường 4",
    "Phường 5",
    "Phường 6",
    "Phường 7",
    "Phường 8",
    "Phường 9",
    "Phường 10",
    "Phường 11",
    "Phường 12",
    "Phường 13",
    "Phường 14",
    "Phường 15",
    "Phường 16",
        };
        string[] Quan9 =
        {
            "Phường Hiệp Phú",
    "Phường Long Bình",
    "Phường Long Phước",
    "Phường Long Thạnh Mỹ",
    "Phường Long Trường",
    "Phường Phú Hữu",
    "Phường Phước Bình",
    "Phường Phước Long A",
    "Phường Phước Long B",
    "Phường Tân Phú",
    "Phường Tăng Nhơn Phú A",
    "Phường Tăng Nhơn Phú B",
    "Phường Trường Thạnh",
        };
        string[] Quan10 =
        {
               "Phường 1",
    "Phường 2",
    "Phường 3",
    "Phường 4",
    "Phường 5",
    "Phường 6",
    "Phường 7",
    "Phường 8",
    "Phường 9",
    "Phường 10",
    "Phường 11",
    "Phường 12",
    "Phường 13",
    "Phường 14",
    "Phường 15"
        };
        string[] Quan11 =
        {
             "Phường 1",
    "Phường 2",
    "Phường 3",
    "Phường 4",
    "Phường 5",
    "Phường 6",
    "Phường 7",
    "Phường 8",
    "Phường 9",
    "Phường 10",
    "Phường 11",
    "Phường 12",
    "Phường 13",
    "Phường 14",
    "Phường 15",
    "Phường 16",
        };
        string[] Quan12 =
        {
             "Phường An Phú Đông",
    "Phường Đông Hưng Thuận",
    "Phường Hiệp Thành",
    "Phường Tân Chánh Hiệp",
    "Phường Tân Hưng Thuận",
    "Phường Tân Thới Hiệp",
    "Phường Tân Thới Nhất",
    "Phường Thạnh Lộc",
    "Phường Thạnh Xuân",
    "Phường Thới An",
    "Phường Trung Mỹ Tây",
        };
        string[] QuanBinhTan =
        {
              "Phường An Lạc",
    "Phường An Lạc A",
    "Phường Bình Hưng Hòa",
    "Phường Bình Hưng Hòa A",
    "Phường Bình Hưng Hòa B",
    "Phường Bình Trị Đông",
    "Phường Bình Trị Đông A",
    "Phường Bình Trị Đông B",
    "Phường Tân Tạo",
    "Phường Tân Tạo A",
        };
        string[] ThuDuc =
        {
             "Phường Bình Chiểu",
    "Phường Bình Thọ",
    "Phường Hiệp Bình Chánh",
    "Phường Hiệp Bình Phước",
    "Phường Linh Chiểu",
    "Phường Linh Ðông",
    "Phường Linh Tây",
    "Phường Linh Trung",
    "Phường Linh Xuân",
    "Phường Tam Bình",
    "Phường Tam Phú",
    "Phường Trường Thọ",
        };
        string[] QuanTanPhu =
        {
             "Phường Hiệp Tân",
    "Phường Hòa Thạnh",
    "Phường Phú Thạnh",
    "Phường Phú Thọ Hòa",
    "Phường Phú Trung",
    "Phường Sơn Kỳ",
    "Phường Tân Quý",
    "Phường Tân Sơn Nhì",
    "Phường Tân Thành",
    "Phường Tân Thới Hòa",
    "Phường Tây Thạnh",
        };



        string[] QuanTanBinh =
        {
              "Phường 1",
    "Phường 2",
    "Phường 3",
    "Phường 4",
    "Phường 5",
    "Phường 6",
    "Phường 7",
    "Phường 8",
    "Phường 9",
    "Phường 10",
    "Phường 11",
    "Phường 12",
    "Phường 13",
    "Phường 14",
    "Phường 15",
        };
        string[] QuanPhuNhuan =
        {
            "Phường 1",
    "Phường 2",
    "Phường 3",
    "Phường 4",
    "Phường 5",
    "Phường 7",
    "Phường 8",
    "Phường 9",
    "Phường 10",
    "Phường 11",
    "Phường 12",
    "Phường 13",
    "Phường 14",
    "Phường 15",
    "Phường 17",
        };
        string[] QuanGoVap =
        {
            "Phường 1",
    "Phường 2",
    "Phường 3",
    "Phường 4",
    "Phường 5",
    "Phường 7",
    "Phường 8",
    "Phường 9",
    "Phường 10",
    "Phường 11",
    "Phường 12",
    "Phường 13",
    "Phường 14",
    "Phường 15",
    "Phường 17",
        };
        string[] QuanBinhThanh =
        {
                "Phường 1",
    "Phường 2",
    "Phường 3",
    "Phường 5",
    "Phường 6",
    "Phường 7",
    "Phường 11",
    "Phường 12",
    "Phường 13",
    "Phường 14",
    "Phường 15",
    "Phường 17",
    "Phường 19",
    "Phường 21",
    "Phường 22",
    "Phường 24",
    "Phường 25",
    "Phường 26",
    "Phường 27",
    "Phường 28",
        };
        string[] HuyenBinhChanh =
        {
             "Xã An Phú Tây",
    "Xã Bình Chánh",
    "Xã Bình Hưng",
    "Xã Bình Lợi",
    "Xã Đa Phước",
    "Xã Hưng Long",
    "Xã Lê Minh Xuân",
    "Xã Phạm Văn Hai",
    "Xã Phong Phú",
    "Xã Quy Đức",
    "Xã Tân Kiên",
    "Xã Tân Nhựt",
    "Xã Tân Quý Tây",
    "Xã Vĩnh Lộc A",
    "Xã Vĩnh Lộc B",
        };
        string[] HuyenCanGio =
        {
             "Xã An Thới Đông",
    "Xã Bình Khánh",
    "Xã Long Hòa",
    "Xã Lý Nhơn",
    "Xã Tam Thôn Hiệp",
    "Xã Thạnh An",
        };
        string[] HuyenCuChi =
        {
              "Thị Trấn Củ Chi ",
    "Xã An Nhơn Tây",
    "Xã An Phú",
    "Xã Bình Mỹ",
    "Xã Hòa Phú",
    "Xã Nhuận Đức",
    "Xã Phạm Văn Cội",
    "Xã Phú Hòa Đông",
    "Xã Phú Mỹ Hưng",
    "Xã Phước Hiệp",
    "Xã Phước Thạnh",
    "Xã Phước Vĩnh An",
    "Xã Tân An Hội",
    "Xã Tân Phú Trung",
    "Xã Tân Thạnh Đông",
    "Xã Tân Thạnh Tây",
    "Xã Tân Thông Hội",
    "Xã Thái Mỹ",
    "Xã Trung An",
    "Xã Trung Lập Hạ",
    "Xã Trung Lập Thượng",
        };
        string[] HuyenHocMon =
        {
             "Xã Bà Điểm",
    "Xã Đông Thạnh",
    "Xã Nhị Bình",
    "Xã Tân Hiệp",
    "Xã Tân Thới Nhì",
    "Xã Tân Xuân",
    "Xã Thới Tam Thôn",
    "Xã Trung Chánh",
    "Xã Xuân Thới Đông",
    "Xã Xuân Thới Sơn",
    "Xã Xuân Thới Thượng",
        };
        string[] HuyenNhaBe =
        {
              "Thị Trấn Nhà Bè",
    "Xã Hiệp Phước",
    "Xã Long Thới",
    "Xã Nhơn Đức",
    "Xã Phú Xuân",
    "Xã Phước Kiển",
    "Xã Phước Lộc",
        };

        public string[] AllQuan = {
        "Quận 1",
        "Quận 2",
        "Quận 3",
        "Quận 4",
        "Quận 5",
        "Quận 6",
        "Quận 7",
        "Quận 8",
        "Quận 9",
        "Quận 10",
        "Quận 11",
        "Quận 12",
        "Quận Bình Tân",
        "Quận Bình Thạnh",
        "Quận Gò Vấp",
        "Quận Phú Nhuận",
        "Quận Tân Bình",
        "Quận Tân Phú",
        "Quận Thủ Đức",
        "Huyện Bình Chánh",
        "Huyện Cần Giờ",
        "Huyện Củ Chi",
        "Huyện Hóc Môn",
        "Huyện Nhà Bè"
        };

        private void cbxQuanHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxPhuongXa.Items.Clear();
            foreach(var item in listt)
            {
                if (item.name == cbxQuanHuyen.Text)
                {
                    for (int i = 0; i < item.commune.Length; i++)
                    {
                        cbxPhuongXa.Items.Add(item.commune[i]);
                        //if (nhaeidt.phuongXa != ""||nhaeidt.phuongXa!=null)
                        //{
                            //cbxPhuongXa.Text = nhaeidt.phuongXa;
                        //}
                    }
                }
            }

        }
 
        private async void btnDangTin_Click(object sender, EventArgs e)
        {
            if (nhaeidt == null)
            {
                ////CoSoVatChat
                var csVC = new CoSoVatChat() { baiDauXe = btnBaiXe.Checked, banCong = btnBanCong.Checked, baoVe = btnBaoVe.Checked, cctv = btnCCTV.Checked, dieuHoa = btnDieuHoa.Checked, gacLung = btnGacLung.Checked, sanThuong = btnSanThuong.Checked, hoBoi = btnHoBoi.Checked, mayGiat = btnMayGiat.Checked, noiThat = btnNoiThat.Checked, nuoiThuCung = btnThuCung.Checked };
                DataProvider.Ins.DB.CoSoVatChats.Add(csVC);
                DataProvider.Ins.DB.SaveChanges();
                //Nha
                Nha nhas = new Nha();
                nhas.maChuNha = _userAdd.maNguoiDung;
                nhas.maCoSoVatChat = csVC.maCoSoVatChat;
                nhas.maLoaiChoThue = maLoaiNha;
                nhas.soPhongNgu = soPhongNgu;
                nhas.soPhongTam = soPhongTam;
                nhas.dienTich = decimal.Parse(txtDienTich.Text);
                nhas.tinhTrang = cbxTinhTrang.Text;
                nhas.soNha = txtSoNha.Text;
                nhas.tenDuong = txtTenDuong.Text;
                nhas.phuongXa = cbxPhuongXa.Text;
                nhas.quanHuyen = cbxQuanHuyen.Text;
                nhas.ngayCapNhat = DateTime.Now;
                nhas.moTa = txtMoTa.Text;
                nhas.TienNha = decimal.Parse(txtTienChoThue.Text);
                DataProvider.Ins.DB.Nhas.Add(nhas);
                DataProvider.Ins.DB.SaveChanges();

                ////Anhnha


                foreach (var item in fileList)
                {
                    await UploadFiles(item, nhas.maNha.ToString());
                }
                DataProvider.Ins.DB.SaveChanges();

                MessageBox.Show("Đăng trọ thành công");
            }
            else
            {
                var nhaluu = DataProvider.Ins.DB.Nhas.Where(x => x.maNha == nhaeidt.maNha).SingleOrDefault();
                //CSVC
                nhaluu.CoSoVatChat.baiDauXe = btnBaiXe.Checked;
                nhaluu.CoSoVatChat.banCong = btnBanCong.Checked;
                nhaluu.CoSoVatChat.baoVe = btnBaoVe.Checked;
                nhaluu.CoSoVatChat.cctv = btnCCTV.Checked;
                nhaluu.CoSoVatChat.dieuHoa = btnDieuHoa.Checked;
                nhaluu.CoSoVatChat.gacLung = btnGacLung.Checked;
                nhaluu.CoSoVatChat.sanThuong = btnSanThuong.Checked;
                nhaluu.CoSoVatChat.hoBoi = btnHoBoi.Checked;
                nhaluu.CoSoVatChat.mayGiat = btnMayGiat.Checked;
                nhaluu.CoSoVatChat.noiThat = btnNoiThat.Checked;
                nhaluu.CoSoVatChat.nuoiThuCung = btnThuCung.Checked;
                //
                nhaluu.maLoaiChoThue = maLoaiNha;
                nhaluu.soPhongNgu = soPhongNgu;
                nhaluu.soPhongTam = soPhongTam;
                nhaluu.dienTich = decimal.Parse(txtDienTich.Text);
                nhaluu.tinhTrang = cbxTinhTrang.Text;
                nhaluu.soNha = txtSoNha.Text + " " + txtTenDuong.Text;
                nhaluu.phuongXa = cbxPhuongXa.Text;
                nhaluu.quanHuyen = cbxQuanHuyen.Text;
                nhaluu.moTa = txtMoTa.Text;
                nhaluu.TienNha = decimal.Parse(txtTienChoThue.Text);
                nhaluu.maNha = nhaeidt.maNha;

                nhaluu.ngayCapNhat = DateTime.Now;
                //Luu
                //DataProvider.Ins.DB.SaveChanges();
                var listAnhh = DataProvider.Ins.DB.AnhNhas;
                foreach (var anhxoa in anhBiXoa)
                {
                    listAnhh.Remove( listAnhh.Where(x => x.maAnhNha == anhxoa).SingleOrDefault());
                }
                try
                {
                    DataProvider.Ins.DB.SaveChanges();

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                foreach (var item in fileList)
                {
                    UploadFiles(item, nhaluu.maNha.ToString());
                }
                MessageBox.Show("Lưu nhà thành công");
            }
            reSet1();

        }


    }

}

