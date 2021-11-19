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
    public partial class frmLoadAnh : Form
    {
        string _url;
        List<AnhNha> _anhNha;
        public frmLoadAnh(string url, List<AnhNha> anh)
        {
            InitializeComponent();
            _url = url;
            _anhNha = anh;
            webBrowser1.Navigate(_url);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
          
        }
        public bool IsHorizontalScrollbarPresent
        {
            get
            {
                var widthofScrollableArea = webBrowser1.Document.Body.ScrollRectangle.Width;
                var widthofControl = webBrowser1.Document.Window.Size.Width;

                return widthofScrollableArea > widthofControl;
            }
        }
    }
}
