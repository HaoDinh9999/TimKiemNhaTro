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
            lblSoPhong.Text = nhas.Where(x => x.LoaiChoThue.tenLoaiChoThue == "Phòng").ToList().Count + "";
            lblCanHo.Text = nhas.Where(x => x.LoaiChoThue.tenLoaiChoThue == "Căn hộ").ToList().Count + "";
            
        }
    }
}
