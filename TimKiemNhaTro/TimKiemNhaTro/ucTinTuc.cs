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
    public partial class ucTinTuc : UserControl
    {
        public ucTinTuc()
        {
            InitializeComponent();
        }
        public void  setURL(string _url)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate(_url);

        }
    }
}
