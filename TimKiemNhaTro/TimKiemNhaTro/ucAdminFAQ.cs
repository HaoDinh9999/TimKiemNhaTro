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
    public partial class ucAdminFAQ : UserControl
    {
        public ucAdminFAQ()
        {
            InitializeComponent();
        }
        public void SetInfo(List<FAQ> faqs)
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i< faqs.Count; i++)
            {
                var card = new ucAdminFAQCard(faqs[i]);
                card.SetInfo();
                flowLayoutPanel1.Controls.Add(card);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddFAQ frm = new frmAddFAQ();
            frm.ShowDialog();
        }
    }
}
