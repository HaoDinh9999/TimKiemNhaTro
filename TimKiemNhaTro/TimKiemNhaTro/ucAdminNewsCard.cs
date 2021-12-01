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
    public partial class ucAdminNewsCard : UserControl
    {
        TinTuc _tin;
        public ucAdminNewsCard(TinTuc tin)
        {
            InitializeComponent();
            _tin = tin;
        }
        public void SetInfo()
        {
            lblTitle.Text = _tin.tieuDe;
            picImg.LoadAsync(_tin.urlAnh);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có muốn xóa tin tức này không?", "Nhắc nhở", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                DataProvider.Ins.DB.TinTucs.Remove(_tin);
                DataProvider.Ins.DB.SaveChanges();
                MessageBox.Show("Bạn đã xóa thành công!");
            }
        }
    }
}
