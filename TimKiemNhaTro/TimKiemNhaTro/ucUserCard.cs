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
    public partial class ucUserCard : UserControl
    {
        NguoiDung _nguoiDung;
        public ucUserCard(NguoiDung nguoiDung)
        {
            InitializeComponent();
            _nguoiDung = nguoiDung;
        }
        public void SetInfo()
        {
            if (_nguoiDung.biVoHieu == 1)
            {
                lblNgungHD.BringToFront();
                btnKhoiPhuc.BringToFront();
            }
            else
            {
                lblDangHD.BringToFront();
                btnVoHieu.BringToFront();
            }
            if (_nguoiDung.hoTen != null && _nguoiDung.hoTen != "")
                lblName.Text = _nguoiDung.hoTen;
            else lblName.Text = "Chưa đặt tên";
            lblEmail.Text = _nguoiDung.email;
            if (_nguoiDung.urlDaiDien != null && _nguoiDung.urlDaiDien != "")
            guna2CirclePictureBox1.LoadAsync(_nguoiDung.urlDaiDien);
            guna2CirclePictureBox1.LoadAsync("https://www.clipartmax.com/png/full/110-1104174_computer-icons-user-clip-art-lily-pad-coloring-page.png");
            
        }

        private void btnVoHieu_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có muốn vô hiệu hóa người dùng này không?", "Nhắc nhở", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                NguoiDung nguoiDung = DataProvider.Ins.DB.NguoiDungs.Where(x => x.maNguoiDung == _nguoiDung.maNguoiDung).SingleOrDefault();
                if (nguoiDung != null)
                {
                    _nguoiDung.biVoHieu = 1;
                    nguoiDung.biVoHieu = 1;
                    DataProvider.Ins.DB.SaveChanges();
                    MessageBox.Show("Vô hiệu hóa người dùng thành công");
                    SetInfo();
                }
                else
                {
                    MessageBox.Show("Không tim thấy người dùng này. Đã có lỗi xảy ra");

                }
            }
            
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có muốn khôi phục người dùng này không?", "Nhắc nhở", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                NguoiDung nguoiDung = DataProvider.Ins.DB.NguoiDungs.Where(x => x.maNguoiDung == _nguoiDung.maNguoiDung).SingleOrDefault();
                if (nguoiDung != null)
                {
                    _nguoiDung.biVoHieu = 0;
                    nguoiDung.biVoHieu = 0;
                    DataProvider.Ins.DB.SaveChanges();
                    MessageBox.Show("Khôi phục người dùng thành công");
                    SetInfo();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy người dùng này. Đã có lỗi xảy ra");

                }
            }
            
        }
    }
}
