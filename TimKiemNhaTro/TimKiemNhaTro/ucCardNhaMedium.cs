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
        frmMain frmM;
        public ucCardNhaMedium()
        {
            InitializeComponent();
        }
        public ucCardNhaMedium(frmMain fr,Nha nha)
        {
            InitializeComponent();
            _nha = nha;
            frmM = fr;
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

        private void picImg_Click(object sender, EventArgs e)
        {
            frmM.getDetailHome().setIdMaNha(_nha.maNha);
            frmM.setUCDetailBringtoFront();
        }

        private void ucCardNhaMedium_Load(object sender, EventArgs e)
        {

        }

        private void ucCardNhaMedium_Click(object sender, EventArgs e)
        {
            frmM.getDetailHome().setIdMaNha(_nha.maNha);
            frmM.setUCDetailBringtoFront();
        }
    }
}
