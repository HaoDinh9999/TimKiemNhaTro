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
    public partial class ucAdminFAQCard : UserControl
    {
        FAQ _faq;
        public ucAdminFAQCard()
        {
            InitializeComponent();
        }
        public ucAdminFAQCard(FAQ faq)
        {
            InitializeComponent();
            _faq = faq;
        }
        public void SetInfo()
        {
            lblCauHoi.Text = _faq.cauHoi;
            lblCauTraLoi.Text = _faq.cauTraLoi;
        }

        private void picDel_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có muốn xóa faq này không?", "Nhắc nhở", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                DataProvider.Ins.DB.FAQs.Remove(_faq);
                DataProvider.Ins.DB.SaveChanges();
                MessageBox.Show("Bạn đã xóa thành công!");
            }
        }
    }
}
