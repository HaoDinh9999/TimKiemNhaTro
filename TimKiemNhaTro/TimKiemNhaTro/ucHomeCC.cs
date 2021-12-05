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
        public NguoiDung _userHome;
        public ucHomeCC()
        {
            InitializeComponent();
        }
        public ucHomeCC(NguoiDung ucN)
        {
            InitializeComponent();
            _userHome = ucN;
        }
        string[] tieuDe = {
            "Giảm tiền thuê trọ tốt cho cả đôi bên",
            "Những chủ nhà bị đóng vai ác",
            "Người thuê trọ sẽ không còn lo bị 'chặt chém' giá điện",
            "Chủ nhà trọ cần kiên nhẫn chờ cơ hội",
        };
        string[] noiDung = { 
            "Nếu tôi trả nhà, chủ trọ cũng mất đi thu nhập hàng tháng, thời điểm này khó cho thuê lại, mà nhà để không cũng mau hư.",
            "Người cho thuê nhà cũng là đang kinh doanh, không nên quá bức xúc nếu họ không giảm tiền cho người thuê.",
            "Từ 26/10, người thuê nhà trọ sẽ chỉ phải trả giá điện theo đúng bảng giá Nhà nước quy định. ",
            "Nhóm công nhân, lao động tự do có thể về quê nghỉ ngơi, thăm người thân nhưng sẽ sớm trở lại Sài Gòn khi cần phải có thu nhập."

        };
        string[] duongDanAnh = {
            "https://i1-vnexpress.vnecdn.net/2021/08/17/GiamGiaPhongTro01-1629194936-8459-1629194991.jpg?w=500&h=300&q=100&dpr=1&fit=crop&s=slyr-HmHLwgUQeYicuuc3g",
            "https://i1-vnexpress.vnecdn.net/2021/07/02/matbang-1625198924-1625198947-3867-1625199057.jpg?w=500&h=300&q=100&dpr=1&fit=crop&s=8GH66L5YLSZ2buwJui9eVA",
            "https://i1-kinhdoanh.vnecdn.net/2018/10/18/dien-1539833430-8436-1539833558.jpg?w=500&h=300&q=100&dpr=1&fit=crop&s=fHbplwXInhWLO_RzDlt71g",
            "https://i1-vnexpress.vnecdn.net/2021/10/06/thuephong-1633488818-7418-1633488845.jpg?w=500&h=300&q=100&dpr=1&fit=crop&s=Gf9YvTnXYAzAXJ-amtYUZQ",
        };
        string[] duongDanBao = {
            "https://vnexpress.net/giam-tien-thue-tro-tot-cho-ca-doi-ben-4342088.html",
            "https://vnexpress.net/nhung-chu-nha-bi-dong-vai-ac-4303272.html",
            "https://vnexpress.net/nguoi-thue-tro-se-khong-con-lo-bi-chat-chem-gia-dien-3825880.html",
            "https://vnexpress.net/chu-nha-tro-can-kien-nhan-cho-co-hoi-4367901.html",
        };
        Color nenHomeColor;
        public void reLoadColorHome(Color clr)
        {
            nenHomeColor = clr;
            this.BackColor = nenHomeColor;
            pnlTimKiem.BaseColor = nenHomeColor;
            rtxTieuDeLon.BackColor = nenHomeColor;
            pnlNhaTro.BaseColor = nenHomeColor;
            pnlChuTro.BaseColor = nenHomeColor;
            pnlNguoiDung.BaseColor = nenHomeColor;
            reLoad();
        }
        public void reLoad()
        {
            lblCountTro.Text = DataProvider.Ins.DB.Nhas.Count().ToString();
            lblCountNguoiDung.Text = DataProvider.Ins.DB.NguoiDungs.Count().ToString();
            flwCapNhatGanNhat.Controls.Clear();
            flwTinTuc.Controls.Clear();
            var listNha = DataProvider.Ins.DB.Nhas.Where(x=>x.NguoiDung.biVoHieu==0).ToList();
            int demNha = 0;
            for (int i = listNha.Count - 1; i >= 0; i--)
            {
                var card = new ucCardNha(this.Parent.Parent as frmMain, listNha[i]);
                card.SetInfo();
                card.reloadColorCardNha();
                flwCapNhatGanNhat.Controls.Add(card);
                demNha++;
                if (demNha > 6)
                    break;
            }

            var listTinTuc = DataProvider.Ins.DB.TinTucs.ToArray();
            foreach(var item in listTinTuc)
            {
                var card = new ucCardTinTuc(this.Parent.Parent as frmMain, item.tieuDe, item.trichDan, item.urlAnh, item.urlBao);
                card.SetInfo();
                card.reloadTinTucColor();
                flwTinTuc.Controls.Add(card);
            }
            //for (int i = 0; i < tieuDe.Count(); i++)
            //{
            //    var card = new ucCardTinTuc(this.Parent.Parent as frmMain, tieuDe[i], noiDung[i], duongDanAnh[i], duongDanBao[i]);
            //    card.SetInfo();
            //    flwTinTuc.Controls.Add(card);

            //}
        }
        private void ucHomeCC_Load(object sender, EventArgs e)
        {
          
            flwCapNhatGanNhat.AutoScroll = false;

            // disable horizontal scrollbar
            flwCapNhatGanNhat.HorizontalScroll.Enabled = false;
            // restore AutoScroll
            flwCapNhatGanNhat.AutoScroll = true;

            reLoad();
            //for(int i=0;i<tieuDe.Count();i++)
            //{
            //    var card = new ucCardTinTuc(this.Parent.Parent as frmMain,tieuDe[i],noiDung[i],duongDanAnh[i],duongDanBao[i]);
            //    card.SetInfo();
            //    flwTinTuc.Controls.Add(card);

            //}
        }
    }
}
