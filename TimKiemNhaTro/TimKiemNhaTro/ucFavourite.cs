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
    public partial class ucFavourite : UserControl
    {
        public ucFavourite()
        {
            InitializeComponent();
        }
        public int maNguoiDung = 1;
        public void reLoad()
        {
            flwFavourite.Controls.Clear();
            var listYeuThich = DataProvider.Ins.DB.YeuThiches.Where(x => x.maNguoiDung == maNguoiDung).ToList();

            foreach (var item in listYeuThich)
            {
                var card = new ucCardRoomFavourite(this.Parent.Parent as frmMain, item);
                card.SetInfo();
                flwFavourite.Controls.Add(card);

            }
        }
        private void ucFavourite_Load(object sender, EventArgs e)
        {

            var listYeuThich = DataProvider.Ins.DB.YeuThiches.Where(x => x.maNguoiDung == maNguoiDung).ToList();

            foreach (var item in listYeuThich)
            {
                var card = new ucCardRoomFavourite(this.Parent.Parent as frmMain, item);
                card.SetInfo();
                flwFavourite.Controls.Add(card);

            }
        }
    }
}
