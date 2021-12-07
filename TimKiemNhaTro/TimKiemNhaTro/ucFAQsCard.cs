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
    public partial class ucFAQsCard : UserControl
    {
        FAQ _faq;
        public ucFAQsCard(FAQ faq)
        {
            InitializeComponent();
            _faq = faq;
        }
        public void SetInfo()
        {
            lblCauHoi.Text = _faq.cauHoi;
            lblCauTraLoi.Text = _faq.cauTraLoi;
        }
        private void picExpand_Click(object sender, EventArgs e)
        {
            picCollapse.BringToFront();
            lblCauTraLoi.Show();
           
        }

        private void picCollapse_Click(object sender, EventArgs e)
        {
            picExpand.BringToFront();
            lblCauTraLoi.Hide();
        }
    }
}
