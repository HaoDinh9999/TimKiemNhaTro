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
            if (IsHorizontalScrollbarPresent)
            {
                webBrowser1.Size = new Size(webBrowser1.Document.Body.ScrollRectangle.Width, webBrowser1.Document.Body.ScrollRectangle.Height);
                frmLoadAnh.ActiveForm.Size = new Size(webBrowser1.Document.Body.ScrollRectangle.Width, webBrowser1.Document.Body.ScrollRectangle.Height);
            }
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
        int demAnh = 0;
        private void btnLeft_Click(object sender, EventArgs e)
        {
            demAnh--;
            if (demAnh == -1)
            {
                demAnh = _anhNha.Count - 1;
            }
            webBrowser1.Navigate(_anhNha[demAnh].duongDan);

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            demAnh++;
            if (demAnh == _anhNha.Count)
            {
                demAnh = 0;
            }
            webBrowser1.Navigate(_anhNha[demAnh].duongDan);

        }
    }
}
