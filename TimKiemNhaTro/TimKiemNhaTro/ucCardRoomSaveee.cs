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
    public partial class ucCardRoomSaveee : UserControl
    {
        frmMain frmM;
        Nha _nha;
        public ucCardRoomSaveee()
        {
            InitializeComponent();
        }
        public ucCardRoomSaveee(frmMain frm, Nha nha)
        {
            InitializeComponent();
            frmM = frm;
            _nha = nha;
        }
        public void SetInfo()
        {
            lblMoney.Text = _nha.TienNha.ToString()+" VNĐ";
            lblCountBedRoom.Text = _nha.soPhongNgu.ToString()+" phòng";
            lblCountBathRoom.Text = _nha.soPhongTam.ToString()+" phòng";
            lblCountMeter.Text = _nha.dienTich.ToString()+" m2";
            rtxAddress.Text = _nha.soNha + ", phường " + _nha.phuongXa + ", " + _nha.quanHuyen + ", thành phố Hồ Chí Minh";
            btnType.Text = _nha.LoaiChoThue.tenLoaiChoThue;
            string _duongDan = _nha.AnhNhas.ToList()[0].duongDan;
            picRoom.LoadAsync(_duongDan);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //frmM.getDetailHome().setIdMaNha(ID);
            //frmM.setUCDetailBringtoFront();
            frmM.getAddHome().LoadEditNha(_nha);
            frmM.setUCAddBringtoFront();
        }
    }
}
