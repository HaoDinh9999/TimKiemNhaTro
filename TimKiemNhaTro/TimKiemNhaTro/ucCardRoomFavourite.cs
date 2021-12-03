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
    public partial class ucCardRoomFavourite : UserControl
    {
        frmMain frmM;
        YeuThich _yeuThich;
        int _idNha;
        public ucCardRoomFavourite()
        {
            InitializeComponent();
        }
        public ucCardRoomFavourite(frmMain frm,YeuThich yeuthich)
        {
            InitializeComponent();
            frmM = frm;
            _yeuThich = yeuthich;
        }
        public void reloadColorCardRoomFavor()
        {
            this.BackColor = frmM.nenColor;
            pnlChung.BaseColor = frmM.nenColor;
            rtxAddress.BackColor = frmM.nenColor;
        }
        public void SetInfo()
        {
            //btnType.Tag = _nha.maNha;
            lblMoney.Text = _yeuThich.Nha.TienNha.ToString() + " VNĐ";
            lblCountBedRoom.Text = _yeuThich.Nha.soPhongNgu.ToString() + " ";
            lblCountBathRoom.Text = _yeuThich.Nha.soPhongTam.ToString() + " ";
            lblCountMeter.Text = _yeuThich.Nha.dienTich.ToString() + " ";
            rtxAddress.Text = _yeuThich.Nha.soNha + ", phường " + _yeuThich.Nha.phuongXa + ", " + _yeuThich.Nha.quanHuyen + ", thành phố Hồ Chí Minh";
            btnType.Text = _yeuThich.Nha.LoaiChoThue.tenLoaiChoThue;
            string _duongDan = _yeuThich.Nha.AnhNhas.ToList()[0].duongDan;
            picRoom.LoadAsync(_duongDan);
            reloadColorCardRoomFavor();
        }

        private void btnHeart_Click(object sender, EventArgs e)
        {
            DataProvider.Ins.DB.YeuThiches.Remove(_yeuThich);
            DataProvider.Ins.DB.SaveChanges();
            (this.Parent.Parent as ucFavourite).reLoad();
        }
    }
}
