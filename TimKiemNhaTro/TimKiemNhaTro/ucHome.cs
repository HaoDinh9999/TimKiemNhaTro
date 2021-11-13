using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimKiemNhaTro
{
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
        }

        private void ucHome_Load(object sender, EventArgs e)
        {
            flwCapNhatGanDay.AutoScroll = false;

            // disable horizontal scrollbar
            flwCapNhatGanDay.HorizontalScroll.Enabled = false;
            // restore AutoScroll
            flwCapNhatGanDay.AutoScroll = true;

            var listItems = new ucCardRoom[100];
            for(int i = 0; i < 4; i++)
            {
                listItems[i] = new ucCardRoom();
                flwCapNhatGanDay.Controls.Add(listItems[i]);
            }
        }
    }
}
