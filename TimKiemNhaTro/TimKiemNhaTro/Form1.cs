using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimKiemNhaTro.Model;

namespace TimKiemNhaTro
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            //pnlUC.Controls.Add(ucH);
            //ucH.Dock = DockStyle.Fill;
            //ucH.BringToFront();
            //btnAddHouse.BringToFront();
        }
        public frmMain(NguoiDung user)
        {
            _user = user;
            InitializeComponent();
            //pnlUC.Controls.Add(ucH);
            //ucH.Dock = DockStyle.Fill;
            //ucH.BringToFront();
            //btnAddHouse.BringToFront();
            dtpRealTime.CustomFormat = "dd/MM/yyyy HH:mm";
            timer1.Enabled = true;


        }
        public NguoiDung _user;
        ucDetailHome ucD;
        ucHomeCC ucH;
        ucSearch ucS;
        ucUser ucUss;
        ucFavourite ucF;
        ucSetting ucSet;
        ucAddHome _ucAdd;
        ucNhaDaDang _ucNhaDaDang;
        ucTinTuc _ucTinTuc;
        ucFAQs _ucFAQs;
        private void moveImageBox(object sender)
        {
            GunaAdvenceButton b = (GunaAdvenceButton)sender;
            pnlMove.Location = new Point(b.Location.X + 240, b.Location.Y+8 );
            pnlMove.BringToFront();

        }
        void setTitle(string a)
        {
            lblTitle.Text = a;
        }

        public void setUCTinTucBringtoFront()
        {
            _ucTinTuc.Show();
            _ucTinTuc.BringToFront();
        }
        public ucTinTuc getUCTinTuc()
        {
            return _ucTinTuc;
        }

        public void setUCNhaDaDangBringtoFront()
        {
            _ucNhaDaDang.Show();
            _ucNhaDaDang.BringToFront();
            _ucNhaDaDang._userNhaDang = _user;
        }
        public ucNhaDaDang getUCNhaDaDang()
        {
            _ucNhaDaDang._userNhaDang = _user;
            _ucNhaDaDang.reLoad();
            return _ucNhaDaDang;
        }

        public void setUCNhaYeuThichBringtoFront()
        {
            ucF.Show();
            ucF.BringToFront();
        }
        public ucFavourite getUCYeuThich()
        {
            return ucF;
        }
        public ucSearch getUCTịmKiem()
        {
            return ucS;
        }
        public void setUCDetailBringtoFront()
        {
            ucD.Show();
            ucD.BringToFront();
        }
        public ucDetailHome getDetailHome()
        {
            return ucD;
        }

        public void setUCAddBringtoFront()
        {
            _ucAdd.Show();
            _ucAdd.BringToFront();
        }
        public ucAddHome getAddHome()
        {
            return _ucAdd;
        }

        public void setUCFAQBringtoFront()
        {
            _ucFAQs.Show();
            _ucFAQs.BringToFront();
        }
        public ucFAQs getFAQ()
        {
            return _ucFAQs;
        }

        public void addToPanel()
        {
            pnlUC.Controls.Add(ucH);
            ucH.Dock = DockStyle.Fill;
            pnlUC.Controls.Add(ucS);
            ucS.Dock = DockStyle.Fill;
            pnlUC.Controls.Add(ucF);
            ucF.Dock = DockStyle.Fill;
            pnlUC.Controls.Add(ucUss);
            ucUss.Dock = DockStyle.Fill;
            pnlUC.Controls.Add(ucSet);
            ucSet.Dock = DockStyle.Fill;
            pnlUC.Controls.Add(ucD);
            ucD.Dock = DockStyle.Fill;
            pnlUC.Controls.Add(_ucAdd);
            _ucAdd.Dock = DockStyle.Fill;
            pnlUC.Controls.Add(_ucNhaDaDang);
            _ucNhaDaDang.Dock = DockStyle.Fill;
            pnlUC.Controls.Add(_ucTinTuc);
            _ucTinTuc.Dock = DockStyle.Fill;
            pnlUC.Controls.Add(_ucFAQs);
            _ucFAQs.Dock = DockStyle.Fill;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            setTitle(btnHome.Text);
            moveImageBox(sender);
            btnHome.Checked = true;
            btnFindMap.Checked = false;
            btnFavourite.Checked = false;
            btnUser.Checked = false;
            btnSetting.Checked = false;
            //ucHome1.Show();
            //ucHome1.BringToFront();

            ucH.BringToFront();
            btnAddHouse.BringToFront();
            ucH._userHome = _user;
            ucH.reLoad();
 
        }

        private void btnFindMap_Click(object sender, EventArgs e)
        {
         MoveToSearch();   
        }
        public void MoveToSearch()
        {
            setTitle(btnFindMap.Text);
            moveImageBox(btnFindMap);
            btnHome.Checked = false;
            btnFindMap.Checked = true;
            btnFavourite.Checked = false;
            btnUser.Checked = false;
            btnSetting.Checked = false;

            ucS.BringToFront();
        }

        private void btnFavourite_Click(object sender, EventArgs e)
        {
            setTitle(btnFavourite.Text);
            moveImageBox(sender);
            btnHome.Checked = false;
            btnFindMap.Checked = false;
            btnFavourite.Checked = true;
            btnUser.Checked = false;
            btnSetting.Checked = false;

            ucF.BringToFront();
            ucF._userYeuThich = _user;
            ucF.reLoad();
        }


        private void btnUser_Click(object sender, EventArgs e)
        {
            setTitle(btnUser.Text);
            moveImageBox(sender);
            btnHome.Checked = false;
            btnFindMap.Checked = false;
            btnFavourite.Checked = false;
            btnUser.Checked = true;
            btnSetting.Checked = false;

            ucUss.BringToFront();
            ucUss._nguoi = _user;
            ucUss.reLoad();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            setTitle(btnSetting.Text);
            moveImageBox(sender);
            btnHome.Checked = false;
            btnFindMap.Checked = false;
            btnFavourite.Checked = false;
            btnUser.Checked = false;
            btnSetting.Checked = true;

            ucSet.BringToFront();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void gunaTileButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width > 200)
            {
                pnlMenu.Width = 100;
                picGif.Visible = false;
            }
            else
            {
                pnlMenu.Width = 297;
                picGif.Visible = true;
            }
        }
        private void btnAddHouse_Click(object sender, EventArgs e)
        {
            _ucAdd.reSet1();
            _ucAdd.BringToFront();
        }
        public void reLoadNguoiDung()
        {
            if (_user.urlDaiDien == null)
                picAvatar.LoadAsync("https://www.clipartmax.com/png/full/110-1104174_computer-icons-user-clip-art-lily-pad-coloring-page.png");
            else
                picAvatar.LoadAsync(_user.urlDaiDien);
            //lblUserName.Text =  _user.email;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (_user.urlDaiDien == null)
                picAvatar.LoadAsync("https://www.clipartmax.com/png/full/110-1104174_computer-icons-user-clip-art-lily-pad-coloring-page.png");
            else
                picAvatar.LoadAsync(_user.urlDaiDien);
            //lblUserName.Text =  _user.email;
            ucH = new ucHomeCC();
            ucS = new ucSearch();
            ucF = new ucFavourite(_user);
            ucUss = new ucUser(_user,this);
            ucSet = new ucSetting();
            ucD = new ucDetailHome(_user);
            _ucAdd = new ucAddHome(_user);
            _ucNhaDaDang = new ucNhaDaDang(_user);
            _ucTinTuc = new ucTinTuc();
            _ucFAQs = new ucFAQs(_user);
            addToPanel();

        }
        bool doimau = false;
        public Color nenColor = Color.White;
        private void ptrPaint_Click(object sender, EventArgs e)
        {
            doimau = !doimau;
            if (doimau==false)//white
            {
                nenColor = Color.White;
                pnlMenu.GradientColor1 = Color.PowderBlue;
                pnlMenu.GradientColor2 = Color.White;
                pnlMenu.GradientColor3 = Color.Snow;
                pnlMenu.GradientColor4 = Color.White;


                reLoadColorfrM();
                ucH.reLoadColorHome(nenColor);
                ucS.reloadSearchColor(nenColor);
                ucF.reloadColorFavor(nenColor);
                ucUss.reloadColorUser();
                _ucNhaDaDang.reloadColorNhaDaDang(nenColor);
                _ucFAQs.reloadColorFAQ(nenColor);
                ucD.reloadColorDetail(nenColor);
                _ucAdd.reloadColor(nenColor);
                ucSet.reloadColor(nenColor);
            }
            else //black
            {
                nenColor = Color.Gray;
                pnlMenu.GradientColor1 = Color.White;
                pnlMenu.GradientColor2= Color.Black;
                pnlMenu.GradientColor3 = Color.Black;
                pnlMenu.GradientColor4 = Color.DarkGray;

                reLoadColorfrM();
                ucH.reLoadColorHome(nenColor);
                ucS.reloadSearchColor(nenColor);
                ucF.reloadColorFavor(nenColor);
                ucUss.reloadColorUser();
                _ucNhaDaDang.reloadColorNhaDaDang(nenColor);
                _ucFAQs.reloadColorFAQ(nenColor);
                ucD.reloadColorDetail(nenColor);
                _ucAdd.reloadColor(nenColor);
                ucSet.reloadColor(nenColor);
            }
        }
        void reLoadColorfrM()
        {
            this.BackColor = nenColor;
        }
        public void resetIni()
        {
            InitializeComponent();

        }

        private void btnTiengViet_Click(object sender, EventArgs e)
        {
            var language = ConfigurationManager.AppSettings["language"];
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi-VN");
            this.Controls.Clear();
            InitializeComponent();

        }

        private void btnTiengAnh_Click(object sender, EventArgs e)
        {
            var language = ConfigurationManager.AppSettings["language"];
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            this.Controls.Clear();
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dtpRealTime.Value = DateTime.Now;
        }

        private void picChat_Click(object sender, EventArgs e)
        {
            frmNguoiDungChat frm = new frmNguoiDungChat(_user, DataProvider.Ins.DB.NguoiDungs.Where(x => x.maNguoiDung == 3).SingleOrDefault());
            frm.Show();
        }
    }
}
