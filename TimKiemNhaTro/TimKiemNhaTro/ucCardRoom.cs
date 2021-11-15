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
    public partial class ucCardRoom : UserControl
    {
        frmMain frmM = new frmMain();

        public ucCardRoom()
        {
            InitializeComponent();
        }
        public ucCardRoom(frmMain frm)
        {
            InitializeComponent();
            frmM = frm;
        }
        //public ucCardRoom(frmMain frm)
        //{
        //    InitializeComponent();
        //    frmM = frm;
        //}
        #region Properties
        string _id;
        string _titleMoney;
        string _address;
        string _type;
        int _countBed;
        int _countBath;
        string _countArea;
        Image _imgMain;
        [Category("Custom Props")]
        public string ID
        {
            get { return _id; }
            set { _id = value; lblTopType.Tag = value; }
        }
        [Category("Custom Props")]
        public string Money
        {
            get { return _titleMoney; }
            set { _titleMoney = value; lblMoney.Text = value+" VND"; }
        }
        [Category("Custom Props")]
        public string Address
        {
            get { return _address; }
            set { _address = value; rtxAddress.Text = value; }
        }
        [Category("Custom Props")]
        public string Type
        {
            get { return _type; }
            set {
                _type = value;
                if (value == "1")
                    lblTopType.Text = "Nhà";
                if (value == "2")
                    lblTopType.Text = "Phòng trọ";
                else
                    lblTopType.Text = "Căn hộ";
                 }
        }
        [Category("Custom Props")]
        public int CountBed
        {
            get { return _countBed; }
            set { _countBed = value; lblCountBedRoom.Text = value.ToString(); }
        }
        [Category("Custom Props")]
        public int CountBad
        {
            get { return _countBath; }
            set { _countBath = value; lblCountBathRoom.Text = value.ToString(); }
        }
        [Category("Custom Props")]
        public string CountArea
        {
            get { return _countArea; }
            set { _countArea = value; lblCountMeter.Text = value.ToString(); }
        }
        [Category("Custom Props")]
        public Image imgMain
        {
            get { return _imgMain; }
            set { _imgMain = value; this.BackgroundImage = value; }
        }
        #endregion

        private void ucCardRoom_Load(object sender, EventArgs e)
        {

        }

        private void ucCardRoom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("showw");
            //frmMain frmM = new frmMain();
            frmM.setUCBringtoFront();
        }
    }
}
