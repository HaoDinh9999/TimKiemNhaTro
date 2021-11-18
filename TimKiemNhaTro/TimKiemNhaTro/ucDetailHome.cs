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
    public partial class ucDetailHome : UserControl
    {
        public ucDetailHome()
        {
            InitializeComponent();
            DataProvider.Ins.DB.DanhGias.Where(x => x.maNguoiDung == 1).SingleOrDefault();
        }
    }
}
