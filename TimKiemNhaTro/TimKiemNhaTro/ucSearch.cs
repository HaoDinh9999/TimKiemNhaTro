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
    public partial class ucSearch : UserControl
    {
        public ucSearch()
        {
            InitializeComponent();
        }

        private void ucSearch_Load(object sender, EventArgs e)
        {
            var listItems = new ucCardRoomLong[100];
            for (int i = 0; i < 4; i++)
            {
                listItems[i] = new ucCardRoomLong();
                flwSearch.Controls.Add(listItems[i]);
            }
        }
    }
}
