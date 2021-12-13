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
    public partial class frmAddNews : Form
    {
        public frmAddNews()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            txtTieuDe.Text = "";
            txtTrichDan.Text = "";
            txtUrlAnh.Text = "";
            txtUrlBao.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTieuDe.Text.Trim() == "" || txtTrichDan.Text.Trim() == "" || txtUrlAnh.Text.Trim() == "" || txtUrlBao.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            TinTuc tinTuc = new TinTuc() { tieuDe = txtTieuDe.Text.Trim() , trichDan = txtTrichDan.Text.Trim(), urlAnh = txtUrlAnh.Text.Trim(), urlBao = txtUrlBao.Text.Trim() };
            DataProvider.Ins.DB.TinTucs.Add(tinTuc);
            DataProvider.Ins.DB.SaveChanges();
            MessageBox.Show("Thêm tin tức thành công");
            Reset();

        }
    }
}
