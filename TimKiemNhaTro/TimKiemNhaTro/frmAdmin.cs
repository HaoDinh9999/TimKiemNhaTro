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
    public partial class frmAdmin : Form
    {
        NguoiDung _nguoiDung;
        public frmAdmin()
        {
            InitializeComponent();
        }
        public frmAdmin(NguoiDung n)
        {
            InitializeComponent();
            _nguoiDung = n;
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có muốn đăng xuất không?",  "Nhắc nhở",  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnDieuHuong_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as Guna.UI2.WinForms.Guna2Button).Checked)
            {
                switch ((sender as Guna.UI2.WinForms.Guna2Button).Text)
                {
                    case "Tổng quan":
                        ucAdminOverview1.SetInfo(DataProvider.Ins.DB.NguoiDungs.ToList().Count, DataProvider.Ins.DB.Nhas.ToList());
                        ucAdminOverview1.BringToFront();

                        lblPage.Text = "Tổng quan";
                        break;
                    case "Thống kê":
                        ucAdminStatistic1.BringToFront();
                        lblPage.Text = "Thống kê";
                        break;
                    case "Người dùng":
                        ucAdminUser1.BringToFront();
                        ucAdminUser1.ResetSearch();
                        ucAdminUser1.SetInfo(DataProvider.Ins.DB.NguoiDungs.ToList());
                        lblPage.Text = "Người dùng";
                        break;
                    case "Tin tức":
                        ucAdminNews1.BringToFront();
                        ucAdminNews1.ResetSearch();
                        ucAdminNews1.SetNewsList(DataProvider.Ins.DB.TinTucs.ToList());
                        
                        lblPage.Text = "Tin tức";
                        break;
                    case "Cá nhân":
                        ucAdminProfile1.BringToFront();
                        ucAdminProfile1.SetNguoiDung(_nguoiDung);
                        ucAdminProfile1.SetInfo();
                        lblPage.Text = "Cá nhân";
                        break;
                    case "FAQ":
                        ucAdminFAQ1.BringToFront();
                        ucAdminFAQ1.SetInfo(DataProvider.Ins.DB.FAQs.ToList());
                        lblPage.Text = "FAQ";
                        break;
                    case "Tin nhắn":
                        ucAdminChat1.BringToFront();
                        ucAdminChat1.LoadLichSu();
                        lblPage.Text = "Tin nhắn";
                        break;
                }
            }
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            ucAdminOverview1.SetInfo(DataProvider.Ins.DB.NguoiDungs.ToList().Count, DataProvider.Ins.DB.Nhas.ToList());
            ucAdminOverview1.BringToFront();
        }
        public void SetNguoiDung(NguoiDung n)
        {
            _nguoiDung = n;
        }
    }
}
