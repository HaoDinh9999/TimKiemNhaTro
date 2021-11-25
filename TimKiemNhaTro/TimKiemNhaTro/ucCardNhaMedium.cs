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
    public partial class ucCardNhaMedium : UserControl
    {
        Nha _nha;
        public ucCardNhaMedium()
        {
            InitializeComponent();
        }
        public ucCardNhaMedium(Nha nha)
        {
            InitializeComponent();
            _nha = nha;
        }
        public void SetInfo()
        {
            lblGia.Text = _nha.TienNha.ToString() + "Đ";
            lblDiaChi.Text = _nha.soNha + " " + _nha.tenDuong + " " + _nha.phuongXa + " " + _nha.quanHuyen;
            lblDienTich.Text = _nha.dienTich.ToString();
            lblPhongNgu.Text = _nha.soPhongNgu + " Phòng ngủ";
            lblPhongTam.Text = _nha.soPhongTam + " Phòng tắm";
            lblSoNgay.Text = (DateTime.Now - _nha.ngayCapNhat).Days + " ngày trước";
            picImg.LoadAsync(_nha.AnhNhas.ToList()[0].duongDan);
        }
    }
}
