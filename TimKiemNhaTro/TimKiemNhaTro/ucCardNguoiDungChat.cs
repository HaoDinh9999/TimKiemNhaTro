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
    public partial class ucCardNguoiDungChat : UserControl
    {
        TinNhan _tin;
        public ucCardNguoiDungChat()
        {
            InitializeComponent();
        }
        public ucCardNguoiDungChat(TinNhan tin)
        {
            InitializeComponent();
            _tin = tin;
        }
        public void SetInfo()
        {
            lblNgayGui.Text = _tin.ngayGui.Day + "/" + _tin.ngayGui.Month; 
            if (_tin.maNguoiGui == 3)
            {
                lblTen.Text = _tin.NguoiDung1.hoTen;
                if (_tin.loai == 1)
                    lblTinNhan.Text = "Bạn: " + _tin.noiDung;
                else
                {
                    lblTinNhan.Text = "Bạn đã gửi 1 ảnh";

                }
                if (_tin.NguoiDung1.urlDaiDien == null || _tin.NguoiDung1.urlDaiDien == "")
                    picAvt.LoadAsync("https://www.clipartmax.com/png/full/110-1104174_computer-icons-user-clip-art-lily-pad-coloring-page.png");
                else picAvt.LoadAsync(_tin.NguoiDung1.urlDaiDien);

            }
            else
            {
                lblTen.Text = _tin.NguoiDung.hoTen;
                if (_tin.loai == 1)
                lblTinNhan.Text = _tin.noiDung;
                else
                {
                    lblTinNhan.Text = "Đã gửi 1 ảnh";

                }
                if (_tin.NguoiDung.urlDaiDien == null || _tin.NguoiDung.urlDaiDien == "")
                    picAvt.LoadAsync("https://www.clipartmax.com/png/full/110-1104174_computer-icons-user-clip-art-lily-pad-coloring-page.png");
                else picAvt.LoadAsync(_tin.NguoiDung.urlDaiDien);

            }
        }
        private void ucCardNguoiDungChat_Click(object sender, EventArgs e)
        {
            if (_tin.maNguoiGui == 3)
            {
                frmNguoiDungChat frm = new frmNguoiDungChat(_tin.NguoiDung, _tin.NguoiDung1);
                frm.Show();

            }
            else
            {
                frmNguoiDungChat frm = new frmNguoiDungChat(_tin.NguoiDung1, _tin.NguoiDung);
                frm.Show();

            }
        }
    }
}
