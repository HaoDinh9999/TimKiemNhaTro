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
    public partial class ucFavourite : UserControl
    {
        public ucFavourite()
        {
            InitializeComponent();
        }

        private void ucFavourite_Load(object sender, EventArgs e)
        {

            var listItems = new ucCardRoomFavourite[100];
            for (int i = 0; i < 4; i++)
            {
                listItems[i] = new ucCardRoomFavourite();
                flwFavourite.Controls.Add(listItems[i]);
            }
        }
    }
}
