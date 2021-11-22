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
    public partial class ucCardTinTuc : UserControl
    {
        frmMain frmM;
        public ucCardTinTuc()
        {
            InitializeComponent();
        }
        public string _title, _content, _duongDanAnh,_duongDanBao;

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            frmM.getUCTinTuc().setURL(_duongDanBao);
            frmM.setUCTinTucBringtoFront();
        }

        public ucCardTinTuc(frmMain frm,string title,string content,string duongDanAnh,string duongDanBao)
        {
            InitializeComponent();
            frmM = frm;
            _title = title;
            _content = content;
            _duongDanAnh = duongDanAnh;
            _duongDanBao = duongDanBao;
        }
        public void SetInfo()
        {
            lblTitle.Text = _title;
            lblContent.Text = _content;
            ptrPicNha.LoadAsync(_duongDanAnh);

        }
    }
}
