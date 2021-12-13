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
    public partial class ucTinNhanCard : UserControl
    {
        TinNhan _tinNhan;
        NguoiDung _ngGui, _ngNhan;
        public ucTinNhanCard()
        {
            InitializeComponent();
        }
        public ucTinNhanCard(TinNhan tin, NguoiDung nguoiGui, NguoiDung nguoiNhan )
        {
            InitializeComponent();
            _tinNhan = tin;
            _ngGui = nguoiGui;
            _ngNhan = nguoiNhan;
        }
        public void SetInfo()
        {
            if (_tinNhan.maNguoiGui == _ngGui.maNguoiDung)
            {
                lblBan.Hide();
                picAvt.Hide();
                lblNoiDung.BackColor = Color.FromArgb(233, 234, 246);
                if (_tinNhan.loai == 2)
                {
                    picAnhGui.Show();
                    lblNoiDung.Hide();
                    picAnhGui.LoadAsync(_tinNhan.noiDung);
                }
                else if (_tinNhan.loai == 1)
                {
                    picAnhGui.Hide();
                    lblNoiDung.Show();
                    lblNoiDung.Text = _tinNhan.noiDung;
                }
            }
            else
            {
                picAvt.Show();
                lblBan.Hide();
                if (_tinNhan.NguoiDung.urlDaiDien == null || _tinNhan.NguoiDung.urlDaiDien == "")
                    picAvt.LoadAsync("https://www.clipartmax.com/png/full/110-1104174_computer-icons-user-clip-art-lily-pad-coloring-page.png");
                else picAvt.LoadAsync(_tinNhan.NguoiDung.urlDaiDien);
                if (_tinNhan.loai == 2)
                {
                    picAnhGui.Show();
                    lblNoiDung.Hide();
                    picAnhGui.LoadAsync(_tinNhan.noiDung);
                }
                else if (_tinNhan.loai == 1)
                {
                    picAnhGui.Hide();
                    lblNoiDung.Show();
                    lblNoiDung.Text = _tinNhan.noiDung;
                }
            }
        }
        public void SetLocation()
        {
            if (_tinNhan.maNguoiGui == _ngGui.maNguoiDung)
            {
                Margin = new Padding(Parent.Width - Width - 30, 0, 0, 0);
            }
        }
    }
}
