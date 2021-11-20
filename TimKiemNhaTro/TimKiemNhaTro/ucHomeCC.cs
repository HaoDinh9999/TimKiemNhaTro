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
    public partial class ucHomeCC : UserControl
    {
        public ucHomeCC()
        {
            InitializeComponent();
        }

        private void ucHomeCC_Load(object sender, EventArgs e)
        {
            flwCapNhatGanNhat.AutoScroll = false;

            // disable horizontal scrollbar
            flwCapNhatGanNhat.HorizontalScroll.Enabled = false;
            // restore AutoScroll
            flwCapNhatGanNhat.AutoScroll = true;

            var listNha = DataProvider.Ins.DB.Nhas.ToList();

            foreach (var item in listNha)
            {
                var card = new ucCardNha(this.Parent.Parent as frmMain, item);
                card.SetInfo();
                flwCapNhatGanNhat.Controls.Add(card);
               
            }
        }
    }
}
