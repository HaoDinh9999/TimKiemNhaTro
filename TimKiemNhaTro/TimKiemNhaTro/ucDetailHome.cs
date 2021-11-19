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

        }
        private void ucDetailHome_Load(object sender, EventArgs e)
        {
           
        }


    }
}
