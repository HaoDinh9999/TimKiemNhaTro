using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimKiemNhaTro.Model;

namespace TimKiemNhaTro
{
    public partial class frmBaoCaoLoiUngDung : Form
    {
        public NguoiDung _nguoi;
        public frmBaoCaoLoiUngDung()
        {
            InitializeComponent();
        }
        public frmBaoCaoLoiUngDung(NguoiDung ng)
        {
            InitializeComponent();
            _nguoi = ng;
        }
        List <string >fileDinhKem = new List<string>();
        private void ptrDinhKem_Click(object sender, EventArgs e)
        {
            fileDinhKem.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Toi thieu 2 - Toi ta 8";
            ofd.Multiselect = true;
            DialogResult dr = ofd.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                //{
                foreach (var item in ofd.FileNames)
                {
                rtxDinhKem.Text += "+"+ item.ToString()+"\n";
                    fileDinhKem.Add(item.ToString());
                }
            //}
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress("vhao1509@gmail.com");
            message.To.Add(new MailAddress("vhao1509@gmail.com"));
            message.Subject = txtTieuDe.Text;
            message.IsBodyHtml = true; //to make message body as html  
            message.Body = "ID: " + _nguoi.maNguoiDung + " - " + (txtNoiDung.Text).ToString();
            foreach(var item in fileDinhKem)
            {
                if (File.Exists(item))
                {
                    Attachment dinhkem = new Attachment(item);
                    message.Attachments.Add(dinhkem);
                }
            }
          
            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.Credentials = new NetworkCredential("vhao1509@gmail.com", "H01213111038");
                smtp.EnableSsl = true;
                smtp.Send(message);
                MessageBox.Show("Thanh cong");
                fileDinhKem.Clear();
                this.Close();

            }
        }
    }
}
