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
    public partial class ucAdminChat : UserControl
    {
        NguoiDung _nguoi;
        public ucAdminChat()
        {
            InitializeComponent();
            _nguoi = DataProvider.Ins.DB.NguoiDungs.Where(x => x.maNguoiDung == 3).SingleOrDefault();
        }
        public void LoadLichSu()
        {
            List<int> maNguoiNhans = new List<int>();
            List<TinNhan> tinNhans = DataProvider.Ins.DB.TinNhans.Where(x => x.maNguoiGui == _nguoi.maNguoiDung || x.maNguoiNhan == _nguoi.maNguoiDung).ToList();
            for (int i = 0; i < tinNhans.Count; i++)
            {
                if (tinNhans[i].maNguoiGui == _nguoi.maNguoiDung)
                {
                    if (!maNguoiNhans.Contains(tinNhans[i].maNguoiNhan))
                        maNguoiNhans.Add(tinNhans[i].maNguoiNhan);
                }
                else
                {
                    if (!maNguoiNhans.Contains(tinNhans[i].maNguoiGui))
                        maNguoiNhans.Add(tinNhans[i].maNguoiGui);
                }
            }
            flowLayoutPanel1.Controls.Clear();
            List<TinNhan> res = new List<TinNhan>();
            for (int i = 0; i < maNguoiNhans.Count; i++)
            {
                var tmp = tinNhans.OrderByDescending(x => x.ngayGui).Where(x => x.maNguoiGui == maNguoiNhans[i] || x.maNguoiNhan == maNguoiNhans[i]).First();
                res.Add(tmp);
            }
            res = res.OrderByDescending(x => x.ngayGui).ToList();
            for (int i = 0; i < res.Count; i++)
            {
                var card = new ucCardNguoiDungChat(res[i]);
                card.SetInfo();
                flowLayoutPanel1.Controls.Add(card);
            }
            
        }
       
    }
}
