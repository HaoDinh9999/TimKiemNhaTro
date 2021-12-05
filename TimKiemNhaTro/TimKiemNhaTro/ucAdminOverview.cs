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
    public partial class ucAdminOverview : UserControl
    {
        public ucAdminOverview()
        {
            InitializeComponent();
        }
        public void SetInfo(int soNguoiDung, List<Nha> nhas )
        {
            lblSoNguoiDung.Text = soNguoiDung + "";
            lblSoNha.Text = nhas.Where(x => x.LoaiChoThue.tenLoaiChoThue == "Nhà").ToList().Count + "";
            lblSoPhong.Text = nhas.Where(x => x.LoaiChoThue.tenLoaiChoThue == "Phòng trọ").ToList().Count + "";
            lblCanHo.Text = nhas.Where(x => x.LoaiChoThue.tenLoaiChoThue == "Căn hộ").ToList().Count + "";
            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series1"].Points.AddXY("Quận 1", nhas.Where(x => x.quanHuyen == "Quận 1").ToList().Count);
            chart1.Series["Series1"].Points.AddXY("Quận 2", nhas.Where(x => x.quanHuyen == "Quận 2").ToList().Count);
            chart1.Series["Series1"].Points.AddXY("Quận 3", nhas.Where(x => x.quanHuyen == "Quận 3").ToList().Count);
            chart1.Series["Series1"].Points.AddXY("Quận 4", nhas.Where(x => x.quanHuyen == "Quận 4").ToList().Count);
            chart1.Series["Series1"].Points.AddXY("Quận 5", nhas.Where(x => x.quanHuyen == "Quận 5").ToList().Count);
            chart1.Series["Series1"].Points.AddXY("Quận 6", nhas.Where(x => x.quanHuyen == "Quận 6").ToList().Count);
            chart1.Series["Series1"].Points.AddXY("Quận 7", nhas.Where(x => x.quanHuyen == "Quận 7").ToList().Count);
            chart1.Series["Series1"].Points.AddXY("Quận 8", nhas.Where(x => x.quanHuyen == "Quận 8").ToList().Count);
            chart1.Series["Series1"].Points.AddXY("Quận 9", nhas.Where(x => x.quanHuyen == "Quận 9").ToList().Count);
            chart1.Series["Series1"].Points.AddXY("Quận 10", nhas.Where(x => x.quanHuyen == "Quận 10").ToList().Count);
            chart1.Series["Series1"].Points.AddXY("Quận 11", nhas.Where(x => x.quanHuyen == "Quận 11").ToList().Count);
            chart1.Series["Series1"].Points.AddXY("Quận 12", nhas.Where(x => x.quanHuyen == "Quận 12").ToList().Count);
            chart1.Series["Series1"].Points.AddXY("Quận Bình Tân", nhas.Where(x => x.quanHuyen == "Quận Bình Tân").ToList().Count);
            chart1.Series["Series1"].Points.AddXY("Quận Thủ Đức", nhas.Where(x => x.quanHuyen == "Quận Thủ Đức").ToList().Count);
            chart1.Series["Series1"].Points.AddXY("Quận Tân Phú", nhas.Where(x => x.quanHuyen == "Quận Tân Phú").ToList().Count);
            chart1.Series["Series1"].Points.AddXY("Quận Tân Bình", nhas.Where(x => x.quanHuyen == "Quận Tân Bình").ToList().Count);
            chart1.Series["Series1"].Points.AddXY("Quận Phú Nhuận", nhas.Where(x => x.quanHuyen == "Quận Phú Nhuận").ToList().Count);
            chart1.Series["Series1"].Points.AddXY("Quận Gò Vấp", nhas.Where(x => x.quanHuyen == "Quận Gò Vấp").ToList().Count);
            chart1.Series["Series1"].Points.AddXY("Quận Bình Thạnh", nhas.Where(x => x.quanHuyen == "Quận Bình Thạnh").ToList().Count);
            chart1.Series["Series1"].Points.AddXY("Huyện Bình Chánh", nhas.Where(x => x.quanHuyen == "Huyện Bình Chánh").ToList().Count);
            chart1.Series["Series1"].Points.AddXY("Huyện Cần Giờ", nhas.Where(x => x.quanHuyen == "Huyện Cần Giờ").ToList().Count);
            chart1.Series["Series1"].Points.AddXY("Huyện Củ Chi", nhas.Where(x => x.quanHuyen == "Huyện Củ Chi").ToList().Count);
            chart1.Series["Series1"].Points.AddXY("Huyện Hóc Môn", nhas.Where(x => x.quanHuyen == "Huyện Hóc Môn").ToList().Count);
            chart1.Series["Series1"].Points.AddXY("Huyện Nhà Bè", nhas.Where(x => x.quanHuyen == "Huyện Nhà Bè").ToList().Count);






        }
    }
}
