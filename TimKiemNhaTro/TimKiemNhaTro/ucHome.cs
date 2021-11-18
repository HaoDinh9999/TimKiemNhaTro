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
            int i = 0;
            flwCapNhatGanDay.AutoScroll = false;

            // disable horizontal scrollbar
            flwCapNhatGanDay.HorizontalScroll.Enabled = false;
            // restore AutoScroll
            flwCapNhatGanDay.AutoScroll = true;

            //var listItems = new ucCardRoom[100];
            var listNha = DataProvider.Ins.DB.Nhas;
            var listLoaiNha = DataProvider.Ins.DB.LoaiChoThues;
            
                foreach (var item in listNha)
                {

                    ucCardRoom newCard = new ucCardRoom(this.Parent.Parent as frmMain);
                    newCard.ID = item.maNha.ToString();
                    newCard.Money = item.TienNha.ToString();
                    newCard.CountBed = item.soPhongNgu.Value;
                    newCard.CountBad = item.soPhongTam.Value;
                    newCard.CountArea = item.dienTich.ToString();
                    newCard.Address = item.soNha + ", phường " + item.phuongXa + ", " + item.quanHuyen + ", thành phố Hồ Chí Minh";
                    newCard.Type = item.maCoSoVatChat.ToString();
                    flwCapNhatGanDay.Controls.Add(newCard);
                }
        }
        
        private void ucHome_Load(object sender, EventArgs e)
        {
            

        }
    }
}
