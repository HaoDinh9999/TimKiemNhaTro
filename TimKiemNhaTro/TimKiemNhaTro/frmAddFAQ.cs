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
    public partial class frmAddFAQ : Form
    {
        public frmAddFAQ()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            txtCauHoi.Text = "";
            txtTraLoi.Text = "";
            
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtCauHoi.Text.Trim() == "" || txtTraLoi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            FAQ faq = new FAQ { cauHoi = txtCauHoi.Text.Trim(), cauTraLoi = txtTraLoi.Text.Trim() };
            DataProvider.Ins.DB.FAQs.Add(faq);
            DataProvider.Ins.DB.SaveChanges();
            MessageBox.Show("Thêm faq thành công");
            Reset();
        }
    }
}
