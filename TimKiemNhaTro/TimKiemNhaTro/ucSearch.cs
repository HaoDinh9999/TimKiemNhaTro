using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimKiemNhaTro.Model;

namespace TimKiemNhaTro
{
    public partial class ucSearch : UserControl
    {
        private List<Nha> nhas = new List<Nha>();
        public List<Districts> listt = new List<Districts>();
        public ucSearch()
        {
            InitializeComponent();
        }

        private void ucSearch_Load(object sender, EventArgs e)
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
            listt.Add(new Districts("Thành phố Thủ Đức", ThuDuc));
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
            cboQuan.Items.Clear();
            for (int i = 0; i < AllQuan.Length; i++)
            {
                cboQuan.Items.Add(AllQuan[i]);
            }
        }
        private void LoadNha()
        {
            flwSearch.Controls.Clear();
            for (int i = 0; i < nhas.Count; i++)
            {
                var card = new ucCardNhaMedium(nhas[i]);
                card.SetInfo();
                flwSearch.Controls.Add(card);
            }
        }
        private void cboQuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboPhuong.Items.Clear();
            foreach (var item in listt)
            {
                if (item.name == cboQuan.Text)
                {
                    for (int i = 0; i < item.commune.Length; i++)
                    {
                        cboPhuong.Items.Add(item.commune[i]);
                    }
                }
            }
        }
        private void cboSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboSapXep.SelectedIndex)
            {
                case 0:
                    nhas = nhas.OrderBy(x => x.TienNha).ToList();
                    break;
                case 1:
                    nhas = nhas.OrderByDescending(x => x.TienNha).ToList();

                    break;
                case 2:
                    nhas = nhas.OrderByDescending(x => x.ngayCapNhat).ToList();
                    break;
                case 3:
                    nhas = nhas.OrderBy(x => x.ngayCapNhat).ToList();
                    break;
            }
            LoadNha();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
           nhas = DataProvider.Ins.DB.Nhas.ToList();
          
                switch (cboPhongNgu.SelectedIndex)
                {
                    case 0:
                        nhas = nhas.Where(x => x.soPhongNgu == 1).ToList();
                        break;
                    case 1:
                        nhas = nhas.Where(x => x.soPhongNgu == 2).ToList();
                        break;
                    case 2:
                        nhas = nhas.Where(x => x.soPhongNgu == 3).ToList();
                        break;
                    case 3:
                        nhas = nhas.Where(x => x.soPhongNgu >= 4).ToList();
                        break;
                }
            
           
            
                switch (cboPhongTam.SelectedIndex)
                {
                    case 0:
                        nhas = nhas.Where(x => x.soPhongTam == 1).ToList();
                        break;
                    case 1:
                        nhas = nhas.Where(x => x.soPhongTam == 2).ToList();
                        break;
                    case 2:
                        nhas = nhas.Where(x => x.soPhongTam == 3).ToList();
                        break;
                    case 3:
                        nhas = nhas.Where(x => x.soPhongTam >= 4).ToList();
                        break;
                }
           

                switch (cboDienTich.SelectedIndex)
                {
                    case 0:
                        nhas = nhas.Where(x => x.dienTich <= 20).ToList();
                        break;
                    case 1:
                        nhas = nhas.Where(x => x.dienTich >= 20 && x.dienTich <= 50).ToList();
                        break;
                    case 2:
                        nhas = nhas.Where(x => x.dienTich >= 50 && x.dienTich <= 100).ToList();
                        break;
                    case 3:
                        nhas = nhas.Where(x => x.dienTich > 100).ToList();
                        break;
                }
            switch (cboGia.SelectedIndex)
            {
                case 0:
                    nhas = nhas.Where(x => x.TienNha <= 3000000).ToList();
                    break;
                case 1:
                    nhas = nhas.Where(x => x.TienNha >= 3000000 && x.TienNha <= 5000000).ToList();
                    break;
                case 2:
                    nhas = nhas.Where(x => x.TienNha >= 5000000 && x.TienNha <= 70000000).ToList();
                    break;
                case 3:
                    nhas = nhas.Where(x => x.TienNha > 7000000).ToList();
                    break;
            }
            if (cboQuan.SelectedIndex != -1)
            {
                nhas = nhas.Where(x => x.quanHuyen == cboQuan.Text).ToList();
            }
            if (cboPhuong.SelectedIndex != -1)
            {
                nhas = nhas.Where(x => x.phuongXa == cboPhuong.Text).ToList();
            }
            if (cboSapXep.SelectedIndex != -1)
            {
                switch (cboSapXep.SelectedIndex)
                {
                    case 0:
                        nhas = nhas.OrderBy(x => x.TienNha).ToList();
                        break;
                    case 1:
                        nhas = nhas.OrderByDescending(x => x.TienNha).ToList();

                        break;
                    case 2:
                        nhas = nhas.OrderByDescending(x => x.ngayCapNhat).ToList();
                        break;
                    case 3:
                        nhas = nhas.OrderBy(x => x.ngayCapNhat).ToList();
                        break;
                }
            }
            
            lblSoKQ.Text = nhas.Count + " kết quả";
            LoadNha();
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
        "Thành phố Thủ Đức",
        "Huyện Bình Chánh",
        "Huyện Cần Giờ",
        "Huyện Củ Chi",
        "Huyện Hóc Môn",
        "Huyện Nhà Bè"
        };

        
    }
  
}
