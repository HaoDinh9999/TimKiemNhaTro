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
    public partial class ucNhaDaDang : UserControl
    {
        public ucNhaDaDang()
        {
            InitializeComponent();
        }
        public int maChu = 1;
        private void ucNhaDaDang_Load(object sender, EventArgs e)
        {
            var listNha = DataProvider.Ins.DB.Nhas.Where(x=>x.maChuNha==maChu).ToList();

            foreach (var item in listNha)
            {
                var card = new ucCardRoomSaveee(this.Parent.Parent as frmMain, item);
                card.SetInfo();
                flwNhaDaDang.Controls.Add(card);

            }
        }
    }
}
