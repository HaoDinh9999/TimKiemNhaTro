using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimKiemNhaTro
{
    public partial class ucSetting : UserControl
    {
        public ucSetting()
        {
            InitializeComponent();
        }

        public void reloadColor(Color clr)
        {
            this.BackColor = clr;
        }

        private void ucSetting_Load(object sender, EventArgs e)
        {
           
        }

        private void rdbVietNam_CheckedChanged(object sender, EventArgs e)
        {
            //rdbVietNam.Checked = true;
            //rdbEnglish.Checked = false;

            //    var language = ConfigurationManager.AppSettings["vi-VN"];
            //    Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("vi-VN");
            //    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi-VN");
            //    this.Controls.Clear();
            //Application.Restart();


            //var changeLanguage = new ChangeLanguage();
            //changeLanguage.UpdateConfig("language", "vi-VN");
            //Application.Restart();

            //var changeLanguage = new ChangeLanguage();
            //changeLanguage.UpdateConfig("language", "vi-VN");
            //Application.Restart();
        }

        private void rdbEnglish_CheckedChanged(object sender, EventArgs e)
        {

            //rdbVietNam.Checked = false;
            //rdbEnglish.Checked = true;

            //var language = ConfigurationManager.AppSettings["en"];
            //Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            //this.Controls.Clear();
            //Application.Restart();
            //var changeLanguage = new ChangeLanguage();
            //changeLanguage.UpdateConfig("language", "en");
            //Application.Restart();

            //var changeLanguage = new ChangeLanguage();
            //changeLanguage.UpdateConfig("language", "en");
            //Application.Restart();
        }
    }
}
