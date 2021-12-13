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
    public partial class ucAdminProfile : UserControl
    {
        NguoiDung _nguoi;
        public ucAdminProfile()
        {
            InitializeComponent();
        }
        public void SetNguoiDung(NguoiDung nguoi)
        {
            _nguoi = nguoi;
        }
        public void SetInfo()
        {
            if (_nguoi.urlDaiDien != null && _nguoi.urlDaiDien != "")
            {
                picAvatar.LoadAsync(_nguoi.urlDaiDien);
            }
            else
            {
                picAvatar.LoadAsync("https://www.clipartmax.com/png/full/110-1104174_computer-icons-user-clip-art-lily-pad-coloring-page.png");
            }
            txtEmail.Text = _nguoi.email;
            txtHoTen.Text = _nguoi.hoTen;
            if (_nguoi.hoTen == null || _nguoi.hoTen == "") txtHoTen.Text = "Chưa đặt tên";
            txtHoTen.Text = _nguoi.hoTen;
            if (_nguoi.sdt == null || _nguoi.sdt == "") txtSDT.Text = "Chưa có sđt";
            txtSDT.Text = _nguoi.sdt;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmAdminEditProfile frm = new frmAdminEditProfile(_nguoi);
            frm.ShowDialog();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            frmAdminChangePassword frm = new frmAdminChangePassword(_nguoi);
            frm.ShowDialog();
        }
    }
}
