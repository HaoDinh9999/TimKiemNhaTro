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
    public partial class ucAdminStatistic : UserControl
    {
        public ucAdminStatistic()
        {
            InitializeComponent();
            cboQuan.Items.AddRange(AllQuan);
        }
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

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cboQuan.SelectedIndex == -1 || cboNam.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin");
                return;
            }
            List<Nha> nhas = new List<Nha>();
            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series2"].Points.Clear();
            chart1.Series["Series3"].Points.Clear();

            chart2.Series["Series1"].Points.Clear();
            chart2.Series["Series2"].Points.Clear();
            chart2.Series["Series3"].Points.Clear();
            nhas = DataProvider.Ins.DB.Nhas.Where(x=>x.quanHuyen == cboQuan.Text).ToList();
            nhas = nhas.Where(x => x.ngayCapNhat.Year + "" == cboNam.Text).ToList();
            chart1.Series["Series1"].Points.AddXY("Tháng 1", nhas.Where(x => x.ngayCapNhat.Month == 1 && x.LoaiChoThue.tenLoaiChoThue == "Nhà").ToList().Count());
            chart1.Series["Series1"].Points.AddXY("Tháng 2", nhas.Where(x => x.ngayCapNhat.Month == 2 && x.LoaiChoThue.tenLoaiChoThue == "Nhà").ToList().Count());
            chart1.Series["Series1"].Points.AddXY("Tháng 3", nhas.Where(x => x.ngayCapNhat.Month == 3 && x.LoaiChoThue.tenLoaiChoThue == "Nhà").ToList().Count());
            chart1.Series["Series1"].Points.AddXY("Tháng 4", nhas.Where(x => x.ngayCapNhat.Month == 4 && x.LoaiChoThue.tenLoaiChoThue == "Nhà").ToList().Count());
            chart1.Series["Series1"].Points.AddXY("Tháng 5", nhas.Where(x => x.ngayCapNhat.Month == 5 && x.LoaiChoThue.tenLoaiChoThue == "Nhà").ToList().Count());
            chart1.Series["Series1"].Points.AddXY("Tháng 6", nhas.Where(x => x.ngayCapNhat.Month == 6 && x.LoaiChoThue.tenLoaiChoThue == "Nhà").ToList().Count());

            chart1.Series["Series2"].Points.AddXY("Tháng 1", nhas.Where(x => x.ngayCapNhat.Month == 1 && x.LoaiChoThue.tenLoaiChoThue == "Phòng trọ").ToList().Count());
            chart1.Series["Series2"].Points.AddXY("Tháng 2", nhas.Where(x => x.ngayCapNhat.Month == 2 && x.LoaiChoThue.tenLoaiChoThue == "Phòng trọ").ToList().Count());
            chart1.Series["Series2"].Points.AddXY("Tháng 3", nhas.Where(x => x.ngayCapNhat.Month == 3 && x.LoaiChoThue.tenLoaiChoThue == "Phòng trọ").ToList().Count());
            chart1.Series["Series2"].Points.AddXY("Tháng 4", nhas.Where(x => x.ngayCapNhat.Month == 4 && x.LoaiChoThue.tenLoaiChoThue == "Phòng trọ").ToList().Count());
            chart1.Series["Series2"].Points.AddXY("Tháng 5", nhas.Where(x => x.ngayCapNhat.Month == 5 && x.LoaiChoThue.tenLoaiChoThue == "Phòng trọ").ToList().Count());
            chart1.Series["Series2"].Points.AddXY("Tháng 6", nhas.Where(x => x.ngayCapNhat.Month == 6 && x.LoaiChoThue.tenLoaiChoThue == "Phòng trọ").ToList().Count());

            chart1.Series["Series3"].Points.AddXY("Tháng 1", nhas.Where(x => x.ngayCapNhat.Month == 1 && x.LoaiChoThue.tenLoaiChoThue == "Căn hộ").ToList().Count());
            chart1.Series["Series3"].Points.AddXY("Tháng 2", nhas.Where(x => x.ngayCapNhat.Month == 2 && x.LoaiChoThue.tenLoaiChoThue == "Căn hộ").ToList().Count());
            chart1.Series["Series3"].Points.AddXY("Tháng 3", nhas.Where(x => x.ngayCapNhat.Month == 3 && x.LoaiChoThue.tenLoaiChoThue == "Căn hộ").ToList().Count());
            chart1.Series["Series3"].Points.AddXY("Tháng 4", nhas.Where(x => x.ngayCapNhat.Month == 4 && x.LoaiChoThue.tenLoaiChoThue == "Căn hộ").ToList().Count());
            chart1.Series["Series3"].Points.AddXY("Tháng 5", nhas.Where(x => x.ngayCapNhat.Month == 5 && x.LoaiChoThue.tenLoaiChoThue == "Căn hộ").ToList().Count());
            chart1.Series["Series3"].Points.AddXY("Tháng 6", nhas.Where(x => x.ngayCapNhat.Month == 6 && x.LoaiChoThue.tenLoaiChoThue == "Căn hộ").ToList().Count());

            chart2.Series["Series1"].Points.AddXY("Tháng 7", nhas.Where(x => x.ngayCapNhat.Month == 7 && x.LoaiChoThue.tenLoaiChoThue == "Nhà").ToList().Count());
            chart2.Series["Series1"].Points.AddXY("Tháng 8", nhas.Where(x => x.ngayCapNhat.Month == 8 && x.LoaiChoThue.tenLoaiChoThue == "Nhà").ToList().Count());
            chart2.Series["Series1"].Points.AddXY("Tháng 9", nhas.Where(x => x.ngayCapNhat.Month == 9 && x.LoaiChoThue.tenLoaiChoThue == "Nhà").ToList().Count());
            chart2.Series["Series1"].Points.AddXY("Tháng 10", nhas.Where(x => x.ngayCapNhat.Month == 10 && x.LoaiChoThue.tenLoaiChoThue == "Nhà").ToList().Count());
            chart2.Series["Series1"].Points.AddXY("Tháng 11", nhas.Where(x => x.ngayCapNhat.Month == 11 && x.LoaiChoThue.tenLoaiChoThue == "Nhà").ToList().Count());
            chart2.Series["Series1"].Points.AddXY("Tháng 12", nhas.Where(x => x.ngayCapNhat.Month == 12 && x.LoaiChoThue.tenLoaiChoThue == "Nhà").ToList().Count());

            chart2.Series["Series2"].Points.AddXY("Tháng 7", nhas.Where(x => x.ngayCapNhat.Month == 7 && x.LoaiChoThue.tenLoaiChoThue == "Phòng trọ").ToList().Count());
            chart2.Series["Series2"].Points.AddXY("Tháng 8", nhas.Where(x => x.ngayCapNhat.Month == 8 && x.LoaiChoThue.tenLoaiChoThue == "Phòng trọ").ToList().Count());
            chart2.Series["Series2"].Points.AddXY("Tháng 9", nhas.Where(x => x.ngayCapNhat.Month == 9 && x.LoaiChoThue.tenLoaiChoThue == "Phòng trọ").ToList().Count());
            chart2.Series["Series2"].Points.AddXY("Tháng 10", nhas.Where(x => x.ngayCapNhat.Month == 10 && x.LoaiChoThue.tenLoaiChoThue == "Phòng trọ").ToList().Count());
            chart2.Series["Series2"].Points.AddXY("Tháng 11", nhas.Where(x => x.ngayCapNhat.Month == 11 && x.LoaiChoThue.tenLoaiChoThue == "Phòng trọ").ToList().Count());
            chart2.Series["Series2"].Points.AddXY("Tháng 12", nhas.Where(x => x.ngayCapNhat.Month == 12 && x.LoaiChoThue.tenLoaiChoThue == "Phòng trọ").ToList().Count());

            chart2.Series["Series3"].Points.AddXY("Tháng 7", nhas.Where(x => x.ngayCapNhat.Month == 7 && x.LoaiChoThue.tenLoaiChoThue == "Căn hộ").ToList().Count());
            chart2.Series["Series3"].Points.AddXY("Tháng 8", nhas.Where(x => x.ngayCapNhat.Month == 8 && x.LoaiChoThue.tenLoaiChoThue == "Căn hộ").ToList().Count());
            chart2.Series["Series3"].Points.AddXY("Tháng 9", nhas.Where(x => x.ngayCapNhat.Month == 9 && x.LoaiChoThue.tenLoaiChoThue == "Căn hộ").ToList().Count());
            chart2.Series["Series3"].Points.AddXY("Tháng 10", nhas.Where(x => x.ngayCapNhat.Month == 10 && x.LoaiChoThue.tenLoaiChoThue == "Căn hộ").ToList().Count());
            chart2.Series["Series3"].Points.AddXY("Tháng 11", nhas.Where(x => x.ngayCapNhat.Month == 11 && x.LoaiChoThue.tenLoaiChoThue == "Căn hộ").ToList().Count());
            chart2.Series["Series3"].Points.AddXY("Tháng 12", nhas.Where(x => x.ngayCapNhat.Month == 12 && x.LoaiChoThue.tenLoaiChoThue == "Căn hộ").ToList().Count());


        }
    }
}
