using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimKiemNhaTro.Model;

namespace TimKiemNhaTro
{
    public partial class ucDetailHome : UserControl
    {
        int _idMaNha;
        int _idNguoiDung;
        Nha nhas;
        CoSoVatChat csvs;
        List<AnhNha> listAnh;
        int x = 30;
        int y = 30;
        int maxHeight = -1;
        public ucDetailHome()
        {
            InitializeComponent();
        }
        public void setIdMaNha(int ID)
        {
            _idMaNha = ID;
            nhas = DataProvider.Ins.DB.Nhas.Where(x => x.maNha == _idMaNha).SingleOrDefault();
            listAnh = new List<AnhNha>(DataProvider.Ins.DB.AnhNhas.Where(x => x.maNha == nhas.maNha));
            loadNha();
        }
        void addCSVC(string url,string txtName)
        {
            
            GunaCircleButton btn = new GunaCircleButton();
            Label lbl = new Label();
            btn.Image = Image.FromFile(url);
            btn.Width = 40;
            btn.Height = 40;
            btn.ImageSize = new Size(30, 30);
            btn.Location = new Point(x, y);
            btn.BaseColor = Color.Transparent;

            lbl.Text = txtName;
            lbl.Location = new Point(x + 40, y + 10);
            lbl.Font = new Font("Seogui UI", 12, FontStyle.Regular);
            lbl.ForeColor = Color.DarkSlateGray;

            x += btn.Width + lbl.Width;
            maxHeight = Math.Max(btn.Height, maxHeight);
            if (x > this.pnlCSVC.Width - 100)
            {
                x = 30;
                y += maxHeight + 15;
            }
            this.pnlCSVC.Controls.Add(btn);
            this.pnlCSVC.Controls.Add(lbl);
        }

        async void loadAnhNha()
        {
            int xX = 20;
            int yY = 20;
            int maxHeightT = -1;
            if (listAnh.Count > 3)
            {
                await Task.Run(() => picone.LoadAsync(listAnh[0].duongDan));
                await Task.Run(() => pictwo.LoadAsync(listAnh[1].duongDan));
                await Task.Run(() => picthree.LoadAsync(listAnh[2].duongDan));
                await Task.Run(() => picfour.LoadAsync(listAnh[3].duongDan));
            }
           

            for (int i = 0; i < listAnh.Count; i++)
            {
                GunaPictureBox pic = new GunaPictureBox();
                pic.Width = 300;
                pic.Height = 200;
                await Task.Run(() => pic.LoadAsync(listAnh[i].duongDan));
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Radius = 10;
                pic.Location = new Point(xX, yY);
                xX += pic.Width + 10;
                pic.Tag = listAnh[i].duongDan;
                //pic.Click += new EventHandler(picAnhNhaHeHe_Click);
                pic.MouseClick += new MouseEventHandler((o, a) => 
                {  frmLoadAnh frmAnh = new frmLoadAnh(pic.Tag.ToString(),listAnh);
                    frmAnh.Show();
                }) ;
                    this.pnlImage.Controls.Add(pic);
            }

        }
        public static string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        void  loadNha()
        {
            for(int i = 0; i < 5;i++)
            {

            }
            x = 30;
            y = 30;
            maxHeight = -1;
            pnlCSVC.Controls.Clear();
            pnlImage.Controls.Clear();
            lblGiaPhong.Text = nhas.TienNha + " VNĐ";
            lblDienTich.Text = nhas.dienTich +" m2";
            lblTinhTrang.Text = nhas.tinhTrang;
            lblLoaiNha.Text = nhas.LoaiChoThue.tenLoaiChoThue;
            lblGiuongNgu.Text = nhas.soPhongNgu.ToString();
            lblPhongTam.Text = nhas.soPhongTam.ToString();
            rtxDiaChi.Text = nhas.soNha + ", " + nhas.phuongXa + ", " + nhas.quanHuyen + ", thành phố Hồ Chí Minh";
            lblTenChu.Text = nhas.NguoiDung.hoTen;
            csvs = DataProvider.Ins.DB.CoSoVatChats.Where(x => x.maCoSoVatChat == nhas.maCoSoVatChat).SingleOrDefault();
            //Map
            webBrowser1.ScriptErrorsSuppressed = true;
            StringBuilder queryaddress = new StringBuilder();
            queryaddress.Append("http://maps.google.com/maps?q=");
            queryaddress.Append(convertToUnSign3(rtxDiaChi.Text));
            webBrowser1.Navigate(queryaddress.ToString());

            if (csvs.baiDauXe == true)
            {
                addCSVC("../../Resources/icons8_parking_assist_32.png", "Bãi đậu xe");
            }
            if (csvs.banCong == true)
            {
                addCSVC("../../Resources/icons8_balcony_32.png", "Ban công");

            }
            if (csvs.baoVe == true)
            {
                addCSVC("../../Resources/icons8_Greek_Guard_32.png", "Bảo vệ");
            }
            if (csvs.cctv == true)
            {
                addCSVC("../../Resources/icons8_wall_mount_camera_error_32.png", "CCTV");
            }
            if (csvs.dieuHoa == true)
            {
                addCSVC("../../Resources/icons8_air_conditionerBlack_321.png", "Điều hoà");
            }
            if (csvs.gacLung == true)
            {
                addCSVC("../../Resources/icons8_staircase_32.png", "Gác lửng");
            }
            if (csvs.sanThuong == true)
            {
                addCSVC("../../Resources/icons8_bungalow_32.png", "Sân thượng");
            }
            if (csvs.hoBoi == true)
            {
                addCSVC("../../Resources/icons8_lap_pool_32.png", "Hồ bơi");
            }
            if (csvs.mayGiat == true)
            {
                addCSVC("../../Resources/icons8_washing_machineAAA_32.png", "Máy giặt");
            }
            if (csvs.noiThat == true)
            {
                addCSVC("../../Resources/icons8_furniture_32.png", "Nội thất");
            }
            if (csvs.nuoiThuCung == true)
            {
                addCSVC("../../Resources/icons8_pet_commands_summon_32.png", "Thú cưng");
            }

            loadAnhNha();

            //Danh gia

            loadDanhGia();

        }
        public void loadDanhGia()
        {
            flwDanhGia.Controls.Clear();
            var listDanhGia = DataProvider.Ins.DB.DanhGias.Where(x => x.maNha == nhas.maNha).ToList();
            if (listDanhGia.Count >0)
            {
                lblCountRate.Text = listDanhGia.Count.ToString();
                btnCountRate.Text = listDanhGia.Count.ToString();

                lblCount1Sao.Text = listDanhGia.Where(x => x.soSao == 1).Count().ToString();
                lblCount2Sao.Text = listDanhGia.Where(x => x.soSao == 2).Count().ToString();
                lblCount3Sao.Text = listDanhGia.Where(x => x.soSao == 3).Count().ToString();
                lblCount4Sao.Text = listDanhGia.Where(x => x.soSao == 4).Count().ToString();
                lblCount5Sao.Text = listDanhGia.Where(x => x.soSao == 5).Count().ToString();

                int tbSao = 0;
                foreach (var item in listDanhGia)
                {
                    var cardDanhGia = new ucCardDanhGia(item,this);
                    cardDanhGia.setInfo();
                    flwDanhGia.Controls.Add(cardDanhGia);
                    tbSao += (int)item.soSao;
                }
                double soSaoo = (double)tbSao / (double)listDanhGia.Count();
                lblSaoChung.Text = (tbSao / listDanhGia.Count()).ToString()+"/5";
                rateChungAll.Value = (float)soSaoo;
                
            }
         
        }
        private void ucDetailHome_Load(object sender, EventArgs e)
        {
           
        }

        private void rateVietSao_ValueChanged(object sender, EventArgs e)
        {
            if (rateVietSao.Value <= 1)
            {
                lblDanhGiaSao.Text = "Không thích";
            }
            else if (rateVietSao.Value <= 2)
            {
                lblDanhGiaSao.Text = "Tạm được";
            }
            else if (rateVietSao.Value <= 3)
            {
                lblDanhGiaSao.Text = "Bình thường";
            }

            else if (rateVietSao.Value <= 4)
            {
                lblDanhGiaSao.Text = "Tốt";
            }
            else if (rateVietSao.Value <= 5)
            {
                lblDanhGiaSao.Text = "Rất tốt";
            }


        }

        private void btnGuiDanhGia_Click(object sender, EventArgs e)
        {
            _idNguoiDung = 1;
            var danhGiaa= new DanhGia(){ maNguoiDung=_idNguoiDung,maNha=nhas.maNha,soSao=(int)rateVietSao.Value,noiDung=rtxComment.Text};
            if (DataProvider.Ins.DB.DanhGias.Where(x => x.maNguoiDung == _idNguoiDung && x.maNha == nhas.maNha).Count() > 0)
            {
                MessageBox.Show("Bạn không thể viết đánh giá thêm được nữa");
            }
            else
            {
                DataProvider.Ins.DB.DanhGias.Add(danhGiaa);
                DataProvider.Ins.DB.SaveChanges();

                MessageBox.Show("Đã gửi đánh giá");
                loadDanhGia();
            }
        }
    }
}
