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
    public partial class ucAdminNews : UserControl
    {
        public ucAdminNews()
        {
            InitializeComponent();
        }
        public void SetNewsList(List<TinTuc> tinTucs)
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < tinTucs.Count; i++)
            {
                ucAdminNewsCard card = new ucAdminNewsCard(tinTucs[i]);
                card.SetInfo();
                flowLayoutPanel1.Controls.Add(card);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddNews frm = new frmAddNews();
            frm.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                SetNewsList(DataProvider.Ins.DB.TinTucs.ToList());
                return;
            }
            SetNewsList(DataProvider.Ins.DB.TinTucs.Where(x => x.tieuDe.Contains(txtSearch.Text.Trim())).ToList());
        }
        public void ResetSearch()
        {
            txtSearch.Text = "";
        }
    }
}
