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
    public partial class Form2 : Form
    {
        DateTime last;
        public Form2()
        {
            InitializeComponent();
            timer1.Interval = 5000;
            timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //List<TinNhan> tinNhans = DataProvider.Ins.DB.TinNhans.OrderBy(x => x.ngayGui).Where(x => x.maNguoiGui == 3 || x.maNguoiNhan == 3 || x.maNguoiGui == 4 || x.maNguoiNhan == 4).ToList();
            //if (last != tinNhans.Last().ngayGui)
            //{
            //    tinNhans = tinNhans.Where(x => x.ngayGui > last).ToList();
            //    for (int i = 0; i < tinNhans.Count; i++)
            //    {
            //        listBox1.Items.Add(tinNhans[i].NguoiDung.hoTen + ": " + tinNhans[i].noiDung);
            //    }
            //    last = tinNhans.Last().ngayGui;
            //}
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //List<TinNhan> tinNhans = DataProvider.Ins.DB.TinNhans.OrderBy(x => x.ngayGui).Where(x => x.maNguoiGui == 3 || x.maNguoiNhan == 3 || x.maNguoiGui == 4 || x.maNguoiNhan == 4).ToList();
            //for (int i = 0; i < tinNhans.Count; i++)
            //{
            //    listBox1.Items.Add(tinNhans[i].NguoiDung.hoTen + ": " + tinNhans[i].noiDung);
            //}
            //last = tinNhans.Last().ngayGui;
            //timer1.Start();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    TinNhan tin = new TinNhan { maNguoiGui = 3, maNguoiNhan = 4, noiDung = textBox1.Text, ngayGui = DateTime.Now };

        //    DataProvider.Ins.DB.TinNhans.Add(tin);
        //    DataProvider.Ins.DB.SaveChanges();
        //    last = tin.ngayGui;
        //    listBox1.Items.Add(tin.NguoiDung.hoTen + ": " + tin.noiDung);
        //    textBox1.Text = "";
        //}
    }
}
