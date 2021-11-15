using Guna.UI.WinForms;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
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
        public void setUCBringtoFront()
        {
            ucDetailHome _ucD = new ucDetailHome();
            pnlUC.Controls.Add(_ucD);
            _ucD.Dock = DockStyle.Fill;
            _ucD.BringToFront();
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
            ucHome1.Show();
            ucHome1.BringToFront();
            btnAddHouse.BringToFront();
        }

        private void btnFindMap_Click(object sender, EventArgs e)
        {
            setTitle(btnFindMap.Text);
            moveImageBox(sender);
            btnHome.Checked = false;
            btnFindMap.Checked = true;
            btnFavourite.Checked = false;
            btnUser.Checked = false;
            btnSetting.Checked = false;
            ucSearch1.Show();
            ucSearch1.BringToFront();
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
            ucFavourite1.Show();
            ucFavourite1.BringToFront();
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
            ucUser1.Show();
            ucUser1.BringToFront();
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
            ucSetting1.Show();
            ucSetting1.BringToFront();
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
            ucAddHome _ucAdd = new ucAddHome();
            pnlUC.Controls.Add(_ucAdd);
            _ucAdd.Dock = DockStyle.Fill;
            _ucAdd.BringToFront();
        }
    }
}
