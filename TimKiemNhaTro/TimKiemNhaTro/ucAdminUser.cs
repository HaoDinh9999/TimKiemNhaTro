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
    public partial class ucAdminUser : UserControl
    {
        public ucAdminUser()
        {
            InitializeComponent();
        }
        public void SetInfo(List<NguoiDung> nguoiDungs)
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < nguoiDungs.Count; i++)
            {
                ucUserCard card = new ucUserCard(nguoiDungs[i]);
                card.SetInfo();
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                SetInfo(DataProvider.Ins.DB.NguoiDungs.ToList());
                return;
            }
            SetInfo(DataProvider.Ins.DB.NguoiDungs.Where(x => x.email.Contains(txtSearch.Text.Trim()) || x.hoTen.Contains(txtSearch.Text.Trim()) ).ToList());

        }
        public void ResetSearch()
        {
            txtSearch.Text = "";
        }
    }
}
