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
    public partial class ucCardDanhGia : UserControl
    {
        public ucCardDanhGia()
        {
            InitializeComponent();
        }
        DanhGia _danhgia;
        int _idNguoiDung=1;
        ucDetailHome _ucD;
        public ucCardDanhGia(DanhGia dg,ucDetailHome ucD)
        {
            InitializeComponent();
            _danhgia = dg;
            _ucD = ucD;
            if (_idNguoiDung == _danhgia.maNguoiDung)
            {
                btnEdit.Visible = true;
                btnDelete.Visible = true;
            }
            else
            {
                btnEdit.Visible = false;
                btnDelete.Visible = false;
            }
        }
        public void setInfo()
        {
            lblTenNguoiDung.Text = _danhgia.NguoiDung.hoTen;
            rateNguoiDung.Value = (int)_danhgia.soSao;
            rtxBinhLuan.Text = _danhgia.noiDung;
            if(_danhgia.NguoiDung.urlDaiDien!=null)
            picAvatar.LoadAsync(_danhgia.NguoiDung.urlDaiDien);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_idNguoiDung == _danhgia.maNguoiDung)
            {
                var listDanhGia = DataProvider.Ins.DB.DanhGias;
                listDanhGia.Remove(_danhgia);
                DataProvider.Ins.DB.SaveChanges();
                MessageBox.Show("Xoa đánh giá thành công");
                _ucD.loadDanhGia();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_idNguoiDung == _danhgia.maNguoiDung)
            {
                _danhgia.soSao = (int)rateNguoiDung.Value;
                _danhgia.noiDung = rtxBinhLuan.Text;
                DataProvider.Ins.DB.SaveChanges();
                MessageBox.Show("Cập nhật thành công");
                _ucD.loadDanhGia();
            }
        }
    }
}
