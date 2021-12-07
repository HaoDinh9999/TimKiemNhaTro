
namespace TimKiemNhaTro
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSideBar = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPage = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.ucAdminUser1 = new TimKiemNhaTro.ucAdminUser();
            this.ucAdminStatistic1 = new TimKiemNhaTro.ucAdminStatistic();
            this.ucAdminProfile1 = new TimKiemNhaTro.ucAdminProfile();
            this.ucAdminNews1 = new TimKiemNhaTro.ucAdminNews();
            this.ucAdminOverview1 = new TimKiemNhaTro.ucAdminOverview();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.btnTongQuan = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.btnTinTuc = new Guna.UI2.WinForms.Guna2Button();
            this.btnChat = new Guna.UI2.WinForms.Guna2Button();
            this.btnFAQ = new Guna.UI2.WinForms.Guna2Button();
            this.btnCaNhan = new Guna.UI2.WinForms.Guna2Button();
            this.btnNguoiDung = new Guna.UI2.WinForms.Guna2Button();
            this.ucAdminFAQ1 = new TimKiemNhaTro.ucAdminFAQ();
            this.ucAdminChat1 = new TimKiemNhaTro.ucAdminChat();
            this.pnlSideBar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.Controls.Add(this.btnDangXuat);
            this.pnlSideBar.Controls.Add(this.btnTongQuan);
            this.pnlSideBar.Controls.Add(this.btnThongKe);
            this.pnlSideBar.Controls.Add(this.btnTinTuc);
            this.pnlSideBar.Controls.Add(this.btnChat);
            this.pnlSideBar.Controls.Add(this.btnFAQ);
            this.pnlSideBar.Controls.Add(this.btnCaNhan);
            this.pnlSideBar.Controls.Add(this.btnNguoiDung);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(64)))));
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.ShadowDecoration.Parent = this.pnlSideBar;
            this.pnlSideBar.Size = new System.Drawing.Size(256, 776);
            this.pnlSideBar.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.guna2HtmlLabel2);
            this.pnlHeader.Controls.Add(this.lblPage);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(256, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1084, 55);
            this.pnlHeader.TabIndex = 1;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(970, 17);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(102, 19);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Xin chào, Admin";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPage
            // 
            this.lblPage.BackColor = System.Drawing.Color.Transparent;
            this.lblPage.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.Location = new System.Drawing.Point(28, 10);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(115, 33);
            this.lblPage.TabIndex = 0;
            this.lblPage.Text = "Tổng quan";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.ucAdminChat1);
            this.pnlMain.Controls.Add(this.ucAdminFAQ1);
            this.pnlMain.Controls.Add(this.ucAdminUser1);
            this.pnlMain.Controls.Add(this.ucAdminStatistic1);
            this.pnlMain.Controls.Add(this.ucAdminProfile1);
            this.pnlMain.Controls.Add(this.ucAdminNews1);
            this.pnlMain.Controls.Add(this.ucAdminOverview1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(256, 55);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1084, 721);
            this.pnlMain.TabIndex = 2;
            // 
            // ucAdminUser1
            // 
            this.ucAdminUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAdminUser1.Location = new System.Drawing.Point(0, 0);
            this.ucAdminUser1.Name = "ucAdminUser1";
            this.ucAdminUser1.Size = new System.Drawing.Size(1084, 721);
            this.ucAdminUser1.TabIndex = 4;
            // 
            // ucAdminStatistic1
            // 
            this.ucAdminStatistic1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAdminStatistic1.Location = new System.Drawing.Point(0, 0);
            this.ucAdminStatistic1.Name = "ucAdminStatistic1";
            this.ucAdminStatistic1.Size = new System.Drawing.Size(1084, 721);
            this.ucAdminStatistic1.TabIndex = 3;
            // 
            // ucAdminProfile1
            // 
            this.ucAdminProfile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAdminProfile1.Location = new System.Drawing.Point(0, 0);
            this.ucAdminProfile1.Name = "ucAdminProfile1";
            this.ucAdminProfile1.Size = new System.Drawing.Size(1084, 721);
            this.ucAdminProfile1.TabIndex = 2;
            // 
            // ucAdminNews1
            // 
            this.ucAdminNews1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAdminNews1.Location = new System.Drawing.Point(0, 0);
            this.ucAdminNews1.Name = "ucAdminNews1";
            this.ucAdminNews1.Size = new System.Drawing.Size(1084, 721);
            this.ucAdminNews1.TabIndex = 1;
            // 
            // ucAdminOverview1
            // 
            this.ucAdminOverview1.BackColor = System.Drawing.Color.Transparent;
            this.ucAdminOverview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAdminOverview1.Location = new System.Drawing.Point(0, 0);
            this.ucAdminOverview1.Name = "ucAdminOverview1";
            this.ucAdminOverview1.Size = new System.Drawing.Size(1084, 721);
            this.ucAdminOverview1.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(162)))), ((int)(((byte)(180)))));
            this.btnDangXuat.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.btnDangXuat.CheckedState.Image = global::TimKiemNhaTro.Properties.Resources.setting;
            this.btnDangXuat.CheckedState.Parent = this.btnDangXuat;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.CustomImages.Parent = this.btnDangXuat;
            this.btnDangXuat.FillColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(179)))));
            this.btnDangXuat.HoverState.Parent = this.btnDangXuat;
            this.btnDangXuat.Image = global::TimKiemNhaTro.Properties.Resources.logout;
            this.btnDangXuat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangXuat.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnDangXuat.Location = new System.Drawing.Point(12, 614);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ShadowDecoration.Parent = this.btnDangXuat;
            this.btnDangXuat.Size = new System.Drawing.Size(228, 51);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangXuat.TextOffset = new System.Drawing.Point(30, 0);
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnTongQuan
            // 
            this.btnTongQuan.BackColor = System.Drawing.Color.Transparent;
            this.btnTongQuan.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTongQuan.Checked = true;
            this.btnTongQuan.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(162)))), ((int)(((byte)(180)))));
            this.btnTongQuan.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.btnTongQuan.CheckedState.Image = global::TimKiemNhaTro.Properties.Resources.dashboard__1_;
            this.btnTongQuan.CheckedState.Parent = this.btnTongQuan;
            this.btnTongQuan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTongQuan.CustomImages.Parent = this.btnTongQuan;
            this.btnTongQuan.FillColor = System.Drawing.Color.Transparent;
            this.btnTongQuan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongQuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(179)))));
            this.btnTongQuan.HoverState.Parent = this.btnTongQuan;
            this.btnTongQuan.Image = global::TimKiemNhaTro.Properties.Resources.dashboard;
            this.btnTongQuan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTongQuan.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnTongQuan.Location = new System.Drawing.Point(12, 150);
            this.btnTongQuan.Name = "btnTongQuan";
            this.btnTongQuan.ShadowDecoration.Parent = this.btnTongQuan;
            this.btnTongQuan.Size = new System.Drawing.Size(228, 51);
            this.btnTongQuan.TabIndex = 1;
            this.btnTongQuan.Text = "Tổng quan";
            this.btnTongQuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTongQuan.TextOffset = new System.Drawing.Point(30, 0);
            this.btnTongQuan.CheckedChanged += new System.EventHandler(this.btnDieuHuong_CheckedChanged);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Transparent;
            this.btnThongKe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThongKe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(162)))), ((int)(((byte)(180)))));
            this.btnThongKe.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.btnThongKe.CheckedState.Image = global::TimKiemNhaTro.Properties.Resources.statistics;
            this.btnThongKe.CheckedState.Parent = this.btnThongKe;
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.CustomImages.Parent = this.btnThongKe;
            this.btnThongKe.FillColor = System.Drawing.Color.Transparent;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(179)))));
            this.btnThongKe.HoverState.Parent = this.btnThongKe;
            this.btnThongKe.Image = global::TimKiemNhaTro.Properties.Resources.statistics__1_;
            this.btnThongKe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThongKe.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnThongKe.Location = new System.Drawing.Point(12, 264);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.ShadowDecoration.Parent = this.btnThongKe;
            this.btnThongKe.Size = new System.Drawing.Size(228, 51);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThongKe.TextOffset = new System.Drawing.Point(30, 0);
            this.btnThongKe.CheckedChanged += new System.EventHandler(this.btnDieuHuong_CheckedChanged);
            // 
            // btnTinTuc
            // 
            this.btnTinTuc.BackColor = System.Drawing.Color.Transparent;
            this.btnTinTuc.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTinTuc.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(162)))), ((int)(((byte)(180)))));
            this.btnTinTuc.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.btnTinTuc.CheckedState.Image = global::TimKiemNhaTro.Properties.Resources.newspaper;
            this.btnTinTuc.CheckedState.Parent = this.btnTinTuc;
            this.btnTinTuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTinTuc.CustomImages.Parent = this.btnTinTuc;
            this.btnTinTuc.FillColor = System.Drawing.Color.Transparent;
            this.btnTinTuc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinTuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(179)))));
            this.btnTinTuc.HoverState.Parent = this.btnTinTuc;
            this.btnTinTuc.Image = global::TimKiemNhaTro.Properties.Resources.newspaper__1_;
            this.btnTinTuc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTinTuc.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnTinTuc.Location = new System.Drawing.Point(12, 321);
            this.btnTinTuc.Name = "btnTinTuc";
            this.btnTinTuc.ShadowDecoration.Parent = this.btnTinTuc;
            this.btnTinTuc.Size = new System.Drawing.Size(228, 51);
            this.btnTinTuc.TabIndex = 0;
            this.btnTinTuc.Text = "Tin tức";
            this.btnTinTuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTinTuc.TextOffset = new System.Drawing.Point(30, 0);
            this.btnTinTuc.CheckedChanged += new System.EventHandler(this.btnDieuHuong_CheckedChanged);
            // 
            // btnChat
            // 
            this.btnChat.BackColor = System.Drawing.Color.Transparent;
            this.btnChat.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnChat.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(162)))), ((int)(((byte)(180)))));
            this.btnChat.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.btnChat.CheckedState.Image = global::TimKiemNhaTro.Properties.Resources.chat_bubbles_with_ellipsis;
            this.btnChat.CheckedState.Parent = this.btnChat;
            this.btnChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChat.CustomImages.Parent = this.btnChat;
            this.btnChat.FillColor = System.Drawing.Color.Transparent;
            this.btnChat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(179)))));
            this.btnChat.HoverState.Parent = this.btnChat;
            this.btnChat.Image = global::TimKiemNhaTro.Properties.Resources.chat_bubbles_with_ellipsis__1_;
            this.btnChat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChat.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnChat.Location = new System.Drawing.Point(12, 492);
            this.btnChat.Name = "btnChat";
            this.btnChat.ShadowDecoration.Parent = this.btnChat;
            this.btnChat.Size = new System.Drawing.Size(228, 51);
            this.btnChat.TabIndex = 0;
            this.btnChat.Text = "Tin nhắn";
            this.btnChat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChat.TextOffset = new System.Drawing.Point(30, 0);
            this.btnChat.CheckedChanged += new System.EventHandler(this.btnDieuHuong_CheckedChanged);
            // 
            // btnFAQ
            // 
            this.btnFAQ.BackColor = System.Drawing.Color.Transparent;
            this.btnFAQ.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnFAQ.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(162)))), ((int)(((byte)(180)))));
            this.btnFAQ.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.btnFAQ.CheckedState.Image = global::TimKiemNhaTro.Properties.Resources.question_mark_on_a_circular_black_background;
            this.btnFAQ.CheckedState.Parent = this.btnFAQ;
            this.btnFAQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFAQ.CustomImages.Parent = this.btnFAQ;
            this.btnFAQ.FillColor = System.Drawing.Color.Transparent;
            this.btnFAQ.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFAQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(179)))));
            this.btnFAQ.HoverState.Parent = this.btnFAQ;
            this.btnFAQ.Image = global::TimKiemNhaTro.Properties.Resources.question_mark_on_a_circular_black_background__1_;
            this.btnFAQ.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFAQ.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnFAQ.Location = new System.Drawing.Point(12, 435);
            this.btnFAQ.Name = "btnFAQ";
            this.btnFAQ.ShadowDecoration.Parent = this.btnFAQ;
            this.btnFAQ.Size = new System.Drawing.Size(228, 51);
            this.btnFAQ.TabIndex = 0;
            this.btnFAQ.Text = "FAQ";
            this.btnFAQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFAQ.TextOffset = new System.Drawing.Point(30, 0);
            this.btnFAQ.CheckedChanged += new System.EventHandler(this.btnDieuHuong_CheckedChanged);
            // 
            // btnCaNhan
            // 
            this.btnCaNhan.BackColor = System.Drawing.Color.Transparent;
            this.btnCaNhan.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCaNhan.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(162)))), ((int)(((byte)(180)))));
            this.btnCaNhan.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.btnCaNhan.CheckedState.Image = global::TimKiemNhaTro.Properties.Resources.setting;
            this.btnCaNhan.CheckedState.Parent = this.btnCaNhan;
            this.btnCaNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaNhan.CustomImages.Parent = this.btnCaNhan;
            this.btnCaNhan.FillColor = System.Drawing.Color.Transparent;
            this.btnCaNhan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(179)))));
            this.btnCaNhan.HoverState.Parent = this.btnCaNhan;
            this.btnCaNhan.Image = global::TimKiemNhaTro.Properties.Resources.setting__1_;
            this.btnCaNhan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCaNhan.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnCaNhan.Location = new System.Drawing.Point(12, 378);
            this.btnCaNhan.Name = "btnCaNhan";
            this.btnCaNhan.ShadowDecoration.Parent = this.btnCaNhan;
            this.btnCaNhan.Size = new System.Drawing.Size(228, 51);
            this.btnCaNhan.TabIndex = 0;
            this.btnCaNhan.Text = "Cá nhân";
            this.btnCaNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCaNhan.TextOffset = new System.Drawing.Point(30, 0);
            this.btnCaNhan.CheckedChanged += new System.EventHandler(this.btnDieuHuong_CheckedChanged);
            // 
            // btnNguoiDung
            // 
            this.btnNguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.btnNguoiDung.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNguoiDung.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(162)))), ((int)(((byte)(180)))));
            this.btnNguoiDung.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.btnNguoiDung.CheckedState.Image = global::TimKiemNhaTro.Properties.Resources.user;
            this.btnNguoiDung.CheckedState.Parent = this.btnNguoiDung;
            this.btnNguoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNguoiDung.CustomImages.Parent = this.btnNguoiDung;
            this.btnNguoiDung.FillColor = System.Drawing.Color.Transparent;
            this.btnNguoiDung.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNguoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(179)))));
            this.btnNguoiDung.HoverState.Parent = this.btnNguoiDung;
            this.btnNguoiDung.Image = global::TimKiemNhaTro.Properties.Resources.user__1_;
            this.btnNguoiDung.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNguoiDung.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnNguoiDung.Location = new System.Drawing.Point(12, 207);
            this.btnNguoiDung.Name = "btnNguoiDung";
            this.btnNguoiDung.ShadowDecoration.Parent = this.btnNguoiDung;
            this.btnNguoiDung.Size = new System.Drawing.Size(228, 51);
            this.btnNguoiDung.TabIndex = 0;
            this.btnNguoiDung.Text = "Người dùng";
            this.btnNguoiDung.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNguoiDung.TextOffset = new System.Drawing.Point(30, 0);
            this.btnNguoiDung.CheckedChanged += new System.EventHandler(this.btnDieuHuong_CheckedChanged);
            // 
            // ucAdminFAQ1
            // 
            this.ucAdminFAQ1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAdminFAQ1.Location = new System.Drawing.Point(0, 0);
            this.ucAdminFAQ1.Name = "ucAdminFAQ1";
            this.ucAdminFAQ1.Size = new System.Drawing.Size(1084, 721);
            this.ucAdminFAQ1.TabIndex = 5;
            // 
            // ucAdminChat1
            // 
            this.ucAdminChat1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAdminChat1.Location = new System.Drawing.Point(0, 0);
            this.ucAdminChat1.Name = "ucAdminChat1";
            this.ucAdminChat1.Size = new System.Drawing.Size(1084, 721);
            this.ucAdminChat1.TabIndex = 6;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1340, 776);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSideBar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdmin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.pnlSideBar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlSideBar;
        private Guna.UI2.WinForms.Guna2Button btnNguoiDung;
        private Guna.UI2.WinForms.Guna2Button btnTongQuan;
        private Guna.UI2.WinForms.Guna2Button btnThongKe;
        private Guna.UI2.WinForms.Guna2Button btnTinTuc;
        private Guna.UI2.WinForms.Guna2Button btnCaNhan;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
        private System.Windows.Forms.Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPage;
        private System.Windows.Forms.Panel pnlMain;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private ucAdminUser ucAdminUser1;
        private ucAdminStatistic ucAdminStatistic1;
        private ucAdminProfile ucAdminProfile1;
        private ucAdminNews ucAdminNews1;
        private ucAdminOverview ucAdminOverview1;
        private Guna.UI2.WinForms.Guna2Button btnFAQ;
        private Guna.UI2.WinForms.Guna2Button btnChat;
        private ucAdminChat ucAdminChat1;
        private ucAdminFAQ ucAdminFAQ1;
    }
}