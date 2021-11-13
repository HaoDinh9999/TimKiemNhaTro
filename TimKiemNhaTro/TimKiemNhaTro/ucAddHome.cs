using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimKiemNhaTro
{
    public partial class ucAddHome : UserControl
    {
        public ucAddHome()
        {
            InitializeComponent();
        }

        private void ucAddHome_Load(object sender, EventArgs e)
        {

        }

        private void btnNoiThat_Click(object sender, EventArgs e)
        {
            if (btnNoiThat.Checked == true)
            {
                btnNoiThat.Checked = false;
            }
            else
            {
                btnNoiThat.Checked = true;
            }
            
        }

        private void btnCCTV_Click(object sender, EventArgs e)
        {
            if (btnCCTV.Checked == true)
            {
                btnCCTV.Checked = false;
            }
            else
            {
                btnCCTV.Checked = true;
            }
        }

        private void btnSanThuong_Click(object sender, EventArgs e)
        {
            if (btnSanThuong.Checked == true)
            {
                btnSanThuong.Checked = false;
            }
            else
            {
                btnSanThuong.Checked = true;
            }
        }

        private void btnBaiXe_Click(object sender, EventArgs e)
        {
            if (btnBaiXe.Checked == true)
            {
                btnBaiXe.Checked = false;
            }
            else
            {
                btnBaiXe.Checked = true;
            }
        }

        private void btnHoBoi_Click(object sender, EventArgs e)
        {
            if (btnHoBoi.Checked == true)
            {
                btnHoBoi.Checked = false;
            }
            else
            {
                btnHoBoi.Checked = true;
            }
        }

        private void btnBaoVe_Click(object sender, EventArgs e)
        {
            if (btnBaoVe.Checked == true)
            {
                btnBaoVe.Checked = false;
            }
            else
            {
                btnBaoVe.Checked = true;
            }
        }

        private void btnGacLung_Click(object sender, EventArgs e)
        {
            if (btnGacLung.Checked == true)
            {
                btnGacLung.Checked = false;
            }
            else
            {
                btnGacLung.Checked = true;
            }
        }

        private void btnThuCung_Click(object sender, EventArgs e)
        {
            if (btnThuCung.Checked == true)
            {
                btnThuCung.Checked = false;
            }
            else
            {
                btnThuCung.Checked = true;
            }
        }

        private void btnMayGiat_Click(object sender, EventArgs e)
        {
            if (btnMayGiat.Checked == true)
            {
                btnMayGiat.Checked = false;
            }
            else
            {
                btnMayGiat.Checked = true;
            }
        }

        private void btnBanCong_Click(object sender, EventArgs e)
        {
            if (btnBanCong.Checked == true)
            {
                btnBanCong.Checked = false;
            }
            else
            {
                btnBanCong.Checked = true;
            }
        }

        private void btnDieuHoa_Click(object sender, EventArgs e)
        {
            if (btnDieuHoa.Checked == true)
            {
                btnDieuHoa.Checked = false;
            }
            else
            {
                btnDieuHoa.Checked = true;
            }
        }

        private void btnHon4Ngu_Click(object sender, EventArgs e)
        {
            btn1Ngu.Checked = false;
            btn2Ngu.Checked = false;
            btn3Ngu.Checked = false;
            btnHon4Ngu.Checked = true;
        }

        private void btn3Ngu_Click(object sender, EventArgs e)
        {
            btn1Ngu.Checked = false;
            btn2Ngu.Checked = false;
            btn3Ngu.Checked = true;
            btnHon4Ngu.Checked = false;
        }

        private void btn2Ngu_Click(object sender, EventArgs e)
        {
            btn1Ngu.Checked = false;
            btn2Ngu.Checked = true;
            btn3Ngu.Checked = false;
            btnHon4Ngu.Checked = false;
        }

        private void btn1Ngu_Click(object sender, EventArgs e)
        {
            btn1Ngu.Checked = true;
            btn2Ngu.Checked = false;
            btn3Ngu.Checked = false;
            btnHon4Ngu.Checked = false;
        }

        private void btnHon4Tam_Click(object sender, EventArgs e)
        {
            btn1Tam.Checked = false;
            btn2Tam.Checked = false;
            btn3Tam.Checked = false;
            btnHon4Tam.Checked = true;
        }

        private void btn3Tam_Click(object sender, EventArgs e)
        {
            btn1Tam.Checked = false;
            btn2Tam.Checked = false;
            btn3Tam.Checked = true;
            btnHon4Tam.Checked = false;
        }

        private void btn2Tam_Click(object sender, EventArgs e)
        {
            btn1Tam.Checked = false;
            btn2Tam.Checked = true;
            btn3Tam.Checked = false;
            btnHon4Tam.Checked = false;
        }

        private void btn1Tam_Click(object sender, EventArgs e)
        {
            btn1Tam.Checked = true;
            btn2Tam.Checked = false;
            btn3Tam.Checked = false;
            btnHon4Tam.Checked = false;
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            btnNha.Checked = false;
            btnCanHo.Checked = false;
            btnPhong.Checked = true;
        }

        private void btnCanHo_Click(object sender, EventArgs e)
        {
            btnNha.Checked = false;
            btnCanHo.Checked = true;
            btnPhong.Checked = false;
        }

        private void btnNha_Click(object sender, EventArgs e)
        {
            btnNha.Checked = true;
            btnCanHo.Checked = false;
            btnPhong.Checked = false;
        }
    }
}
