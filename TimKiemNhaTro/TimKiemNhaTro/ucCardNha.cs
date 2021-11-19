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
    public partial class ucCardNha : UserControl
    {
        frmMain frmM = new frmMain();
        public ucCardNha()
        {
            InitializeComponent();
        }
        public ucCardNha(frmMain frm)
        {
            InitializeComponent();
            frmM = frm;
        }
        #region Properties
        int _id;
        string _titleMoney;
        string _address;
        string _type;
        int _countBed;
        int _countBath;
        string _countArea;
        string _duongDan;
        Image _imgMain;
        [Category("Custom Props")]
        public int ID
        {
            get { return _id; }
            set { _id = value; btnType.Tag = value; 
            }
        }
        [Category("Custom Props")]
        public string Money
        {
            get { return _titleMoney; }
            set { _titleMoney = value; lblMoney.Text = value + " VND"; }
        }
        [Category("Custom Props")]
        public string Address
        {
            get { return _address; }
            set { _address = value; lblAddress.Text = value; }
        }
        [Category("Custom Props")]
        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
                if (value == "1")
                    btnType.Text = "Nhà";
                if (value == "2")
                    btnType.Text = "Phòng trọ";
                else
                    btnType.Text = "Căn hộ";
            }
        }
        [Category("Custom Props")]
        public int CountBed
        {
            get { return _countBed; }
            set { _countBed = value; lblPhongNgu.Text = value.ToString()+" Phòng ngủ"; }
        }
        [Category("Custom Props")]
        public int CountBad
        {
            get { return _countBath; }
            set { _countBath = value; lblPhongTam.Text = value.ToString()+" Phòng tắm"; }
        }
        [Category("Custom Props")]
        public string CountArea
        {
            get { return _countArea; }
            set { _countArea = value; lblDienTich.Text = value.ToString()+"m2"; }
        }
        [Category("Custom Props")]
        public async Task imgMainAsync()
        {
            await Task.Run(() => ptrPicNha.LoadAsync("https://firebasestorage.googleapis.com/v0/b/timkiemnhatro-6dd5a.appspot.com/o/3612573_18012114440061220336.jpg?alt=media&token=1b991d12-60e7-4bec-af5c-c5f2b56458ff"));

        }
    #endregion
    private void ucCardNha_Click(object sender, EventArgs e)
        {
            //frmM.getDetailHome().setIdMaNha(Int32.Parse(ID));
            //frmM.setUCDetailBringtoFront();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            frmM.getDetailHome().setIdMaNha(ID);
            frmM.setUCDetailBringtoFront();
        }
    }
}
