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

            var listItems = new ucCardNha[50];
            var listNha = DataProvider.Ins.DB.Nhas;

            foreach (var item in listNha)
            {
                listItems[i] = new ucCardNha(this.Parent.Parent as frmMain);
                listItems[i].ID = item.maNha;
                listItems[i].Money = item.TienNha.ToString();
                listItems[i].CountBed = item.soPhongNgu.Value;
                listItems[i].CountBad = item.soPhongTam.Value;
                listItems[i].CountArea = item.dienTich.ToString();
                listItems[i].Address = item.soNha + ", phường " + item.phuongXa + ", " + item.quanHuyen + ", thành phố Hồ Chí Minh";
                listItems[i].Type = item.maCoSoVatChat.ToString();
                //string _duongDan = listAnh.Where(x => x.maNha == item.maNha).FirstOrDefault().duongDan;
                //listItems[i].imgMainAsync();
                flwCapNhatGanDay.Controls.Add(listItems[i]);
                i++;
            }

        }
    }
}
