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
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
        }
        int i = 0;
        private void ucHome_Load(object sender, EventArgs e)
        {
            flwCapNhatGanDay.AutoScroll = false;

            // disable horizontal scrollbar
            flwCapNhatGanDay.HorizontalScroll.Enabled = false;
            // restore AutoScroll
            flwCapNhatGanDay.AutoScroll = true;

            var listItems = new ucCardRoom[100];
            var listNha = DataProvider.Ins.DB.Nhas;
            var listLoaiNha = DataProvider.Ins.DB.LoaiChoThues;
            foreach(var item in listNha)
            {

                listItems[i] = new ucCardRoom(this.Parent.Parent as frmMain);
                listItems[i].ID = item.maNha.ToString();
                listItems[i].Money = item.TienNha.ToString();
                listItems[i].CountBed = item.soPhongNgu.Value;
                listItems[i].CountBad = item.soPhongTam.Value;
                listItems[i].CountArea = item.dienTich.ToString();
                listItems[i].Address = item.soNha + ", phường " + item.phuongXa + ", " + item.quanHuyen + ", thành phố Hồ Chí Minh";
                listItems[i].Type = item.maCoSoVatChat.ToString();
                flwCapNhatGanDay.Controls.Add(listItems[i]);
                i++;
            }

        }
    }
}
