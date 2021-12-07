using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimKiemNhaTro.Model;

namespace TimKiemNhaTro
{
    public partial class ucFAQs : UserControl
    {
        NguoiDung _nguoi;
        public ucFAQs()
        {
            InitializeComponent();
        }
        public ucFAQs(NguoiDung _ng)
        {
            InitializeComponent();
            _nguoi = _ng;
            

        }
        bool P1e = false;
        bool P2e = false;
        public void SetInfo()
        {
            List<FAQ> fAQs = DataProvider.Ins.DB.FAQs.ToList();
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < fAQs.Count; i++)
            {
                var card = new ucFAQsCard(fAQs[i]);
                card.SetInfo();
                flowLayoutPanel1.Controls.Add(card);
            }
        }
        public void reloadColorFAQ(Color clr)
        {
            //if (clr == Color.White)
            //{
            //    this.BackColor = clr;
            //    panel1.BackColor = Color.WhiteSmoke;
            //    btnCau1.BaseColor = Color.WhiteSmoke;
            //    btnCau2.BaseColor = Color.WhiteSmoke;
            //    btnCau3.BaseColor = Color.WhiteSmoke;
            //    btnCau4.BaseColor = Color.WhiteSmoke;
            //    btnCau5.BaseColor = Color.WhiteSmoke;
            //    btnCau6.BaseColor = Color.WhiteSmoke;
            //    btnCau7.BaseColor = Color.WhiteSmoke;


            //    btnCau1.BorderSize = 0;
            //    btnCau2.BorderSize = 0;
            //    btnCau3.BorderSize = 0;
            //    btnCau4.BorderSize = 0;
            //    btnCau5.BorderSize = 0;
            //    btnCau6.BorderSize = 0;
            //    btnCau7.BorderSize = 0;

            //    richTextBox1.BackColor = clr;
            //    richTextBox2.BackColor = clr;
            //    richTextBox3.BackColor = clr;
            //    richTextBox4.BackColor = clr;
            //    richTextBox5.BackColor = clr;
            //    richTextBox6.BackColor = clr;
            //    richTextBox7.BackColor = clr;
            //    richTextBox8.BackColor = clr;
            //    richTextBox9.BackColor = clr;
            //    richTextBox10.BackColor = clr;
            //    richTextBox11.BackColor = clr;
            //    richTextBox12.BackColor = clr;
            //    richTextBox13.BackColor = clr;
            //    richTextBox14.BackColor = clr;

            //    richTextBox1.ForeColor = Color.DimGray;
            //    richTextBox2.ForeColor = Color.DimGray;
            //    richTextBox3.ForeColor = Color.DimGray;
            //    richTextBox4.ForeColor = Color.DimGray;
            //    richTextBox5.ForeColor = Color.DimGray;
            //    richTextBox6.ForeColor = Color.DimGray;
            //    richTextBox7.ForeColor = Color.DimGray;
            //    richTextBox8.ForeColor = Color.DimGray;
            //    richTextBox9.ForeColor = Color.DimGray;
            //    richTextBox10.ForeColor = Color.DimGray;
            //    richTextBox11.ForeColor = Color.DimGray;
            //    richTextBox12.ForeColor = Color.DimGray;
            //    richTextBox13.ForeColor = Color.DimGray;
            //    richTextBox14.ForeColor = Color.DimGray;


            //}
            //else
            //{
            //    this.BackColor = clr;
            //    panel1.BackColor = Color.LightGray;
            //    btnCau1.BaseColor = Color.LightGray;
            //    btnCau2.BaseColor = Color.LightGray;
            //    btnCau3.BaseColor = Color.LightGray;
            //    btnCau4.BaseColor = Color.LightGray;
            //    btnCau5.BaseColor = Color.LightGray;
            //    btnCau6.BaseColor = Color.LightGray;
            //    btnCau7.BaseColor = Color.LightGray;

            //    btnCau1.BorderSize = 1;
            //    btnCau2.BorderSize = 1;
            //    btnCau3.BorderSize = 1;
            //    btnCau4.BorderSize = 1;
            //    btnCau5.BorderSize = 1;
            //    btnCau6.BorderSize = 1;
            //    btnCau7.BorderSize = 1;


            //    btnCau1.CheckedBorderColor = Color.WhiteSmoke;
            //    btnCau2.CheckedBorderColor = Color.WhiteSmoke;
            //    btnCau3.CheckedBorderColor = Color.WhiteSmoke;
            //    btnCau4.CheckedBorderColor = Color.WhiteSmoke;
            //    btnCau5.CheckedBorderColor = Color.WhiteSmoke;
            //    btnCau6.CheckedBorderColor = Color.WhiteSmoke;
            //    btnCau7.CheckedBorderColor = Color.WhiteSmoke;

            //    richTextBox1.BackColor = clr;
            //    richTextBox2.BackColor = clr;
            //    richTextBox3.BackColor = clr;
            //    richTextBox4.BackColor = clr;
            //    richTextBox5.BackColor = clr;
            //    richTextBox6.BackColor = clr;
            //    richTextBox7.BackColor = clr;
            //    richTextBox8.BackColor = clr;
            //    richTextBox9.BackColor = clr;
            //    richTextBox10.BackColor = clr;
            //    richTextBox11.BackColor = clr;
            //    richTextBox12.BackColor = clr;
            //    richTextBox13.BackColor = clr;
            //    richTextBox14.BackColor = clr;

            //    richTextBox1.ForeColor = Color.White;
            //    richTextBox2.ForeColor = Color.White;
            //    richTextBox3.ForeColor = Color.White;
            //    richTextBox4.ForeColor = Color.White;
            //    richTextBox5.ForeColor = Color.White;
            //    richTextBox6.ForeColor = Color.White;
            //    richTextBox7.ForeColor = Color.White;
            //    richTextBox8.ForeColor = Color.White;
            //    richTextBox9.ForeColor = Color.White;
            //    richTextBox10.ForeColor = Color.White;
            //    richTextBox11.ForeColor = Color.White;
            //    richTextBox12.ForeColor = Color.White;
            //    richTextBox13.ForeColor = Color.White;
            //    richTextBox14.ForeColor = Color.White;


            //}
        }
        private void ucFAQs_Load(object sender, EventArgs e)
        {
            //pnl1.Height = 0;
            //pnl2.Height = 0;
            //pnl3.Height = 0;
            //pnl4.Height = 0;
            //pnl5.Height = 0;
            //pnl6.Height = 0;
            //pnl7.Height = 0;
            //btnCau2.Top = pnl1.Top;
            //btnCau3.Top = btnCau2.Top + 60;
            //btnCau4.Top = btnCau3.Top + 60;
            //btnCau5.Top = btnCau4.Top + 60;
            //btnCau6.Top = btnCau5.Top + 60;
            //btnCau7.Top = btnCau6.Top + 60;

        }


        private void btnGuiEmail_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress("vhao1509@gmail.com");
                message.To.Add(new MailAddress("vhao1509@gmail.com"));
                message.Subject = "Câu hỏi thắc mắc ?";
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = "ID: " + _nguoi.maNguoiDung + " - " + (txtCauHoi.Text).ToString();
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential("vhao1509@gmail.com", "H01213111038");
                    smtp.EnableSsl = true;
                    smtp.Send(message);
                    MessageBox.Show("Thanh cong");
                }
            }
            catch (Exception er) {
                MessageBox.Show(er.Message);
            }
        }
    }
}
