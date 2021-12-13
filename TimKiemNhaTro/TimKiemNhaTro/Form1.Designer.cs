
namespace TimKiemNhaTro
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gelipFrmTaskee = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dtpRealTime = new Guna.UI.WinForms.GunaDateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPosition = new System.Windows.Forms.Label();
            this.pnlUC = new System.Windows.Forms.Panel();
            this.mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAddHouse = new Guna.UI.WinForms.GunaAdvenceButton();
            this.picAvatar = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.ptrPaint = new System.Windows.Forms.PictureBox();
            this.gunaTileButton1 = new Guna.UI.WinForms.GunaTileButton();
            this.btnMinimize = new Guna.UI.WinForms.GunaTileButton();
            this.pnlMenu = new Guna.UI.WinForms.GunaGradientPanel();
            this.btnTiengAnh = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnTiengViet = new Guna.UI.WinForms.GunaAdvenceButton();
            this.picGif = new Guna.UI.WinForms.GunaPictureBox();
            this.pnlMove = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnSetting = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnUser = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnFavourite = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnFindMap = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnHome = new Guna.UI.WinForms.GunaAdvenceButton();
            this.picChat = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.pnlUC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrPaint)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChat)).BeginInit();
            this.SuspendLayout();
            // 
            // gelipFrmTaskee
            // 
            this.gelipFrmTaskee.Radius = 35;
            this.gelipFrmTaskee.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.picChat);
            this.panel2.Controls.Add(this.picAvatar);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.dtpRealTime);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.ptrPaint);
            this.panel2.Controls.Add(this.gunaTileButton1);
            this.panel2.Controls.Add(this.lblPosition);
            this.panel2.Controls.Add(this.btnMinimize);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
            // 
            // dtpRealTime
            // 
            resources.ApplyResources(this.dtpRealTime, "dtpRealTime");
            this.dtpRealTime.BackColor = System.Drawing.Color.Transparent;
            this.dtpRealTime.BaseColor = System.Drawing.Color.Transparent;
            this.dtpRealTime.BorderColor = System.Drawing.Color.Silver;
            this.dtpRealTime.FocusedColor = System.Drawing.Color.White;
            this.dtpRealTime.ForeColor = System.Drawing.Color.Black;
            this.dtpRealTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRealTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpRealTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpRealTime.Name = "dtpRealTime";
            this.dtpRealTime.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpRealTime.OnHoverBorderColor = System.Drawing.Color.Black;
            this.dtpRealTime.OnHoverForeColor = System.Drawing.Color.Black;
            this.dtpRealTime.OnPressedColor = System.Drawing.Color.Black;
            this.dtpRealTime.Radius = 10;
            this.dtpRealTime.Value = new System.DateTime(2021, 10, 15, 16, 35, 32, 952);
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Name = "panel4";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Name = "panel3";
            // 
            // lblPosition
            // 
            resources.ApplyResources(this.lblPosition, "lblPosition");
            this.lblPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPosition.Name = "lblPosition";
            // 
            // pnlUC
            // 
            this.pnlUC.Controls.Add(this.btnAddHouse);
            resources.ApplyResources(this.pnlUC, "pnlUC");
            this.pnlUC.Name = "pnlUC";
            // 
            // mySqlCommandBuilder1
            // 
            this.mySqlCommandBuilder1.DataAdapter = null;
            this.mySqlCommandBuilder1.QuotePrefix = "`";
            this.mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAddHouse
            // 
            resources.ApplyResources(this.btnAddHouse, "btnAddHouse");
            this.btnAddHouse.AnimationHoverSpeed = 0.07F;
            this.btnAddHouse.AnimationSpeed = 0.03F;
            this.btnAddHouse.BackColor = System.Drawing.Color.Transparent;
            this.btnAddHouse.BaseColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddHouse.BorderColor = System.Drawing.Color.Black;
            this.btnAddHouse.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAddHouse.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddHouse.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddHouse.CheckedImage = global::TimKiemNhaTro.Properties.Resources.icons8_heart_322;
            this.btnAddHouse.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddHouse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddHouse.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddHouse.ForeColor = System.Drawing.Color.White;
            this.btnAddHouse.Image = global::TimKiemNhaTro.Properties.Resources.icons8_plus_math_32;
            this.btnAddHouse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddHouse.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddHouse.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddHouse.Name = "btnAddHouse";
            this.btnAddHouse.OnHoverBaseColor = System.Drawing.Color.LightGray;
            this.btnAddHouse.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddHouse.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddHouse.OnHoverImage = null;
            this.btnAddHouse.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddHouse.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddHouse.Radius = 30;
            this.btnAddHouse.Click += new System.EventHandler(this.btnAddHouse_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.BaseColor = System.Drawing.Color.White;
            resources.ApplyResources(this.picAvatar, "picAvatar");
            this.picAvatar.InitialImage = global::TimKiemNhaTro.Properties.Resources.loading;
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.TabStop = false;
            this.picAvatar.UseTransfarantBackground = false;
            // 
            // ptrPaint
            // 
            resources.ApplyResources(this.ptrPaint, "ptrPaint");
            this.ptrPaint.Image = global::TimKiemNhaTro.Properties.Resources.icons8_paint_palette_with_brush_32;
            this.ptrPaint.Name = "ptrPaint";
            this.ptrPaint.TabStop = false;
            this.ptrPaint.Click += new System.EventHandler(this.ptrPaint_Click);
            // 
            // gunaTileButton1
            // 
            resources.ApplyResources(this.gunaTileButton1, "gunaTileButton1");
            this.gunaTileButton1.AnimationHoverSpeed = 0.07F;
            this.gunaTileButton1.AnimationSpeed = 0.03F;
            this.gunaTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTileButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaTileButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTileButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaTileButton1.FocusedColor = System.Drawing.Color.White;
            this.gunaTileButton1.ForeColor = System.Drawing.Color.Transparent;
            this.gunaTileButton1.Image = global::TimKiemNhaTro.Properties.Resources.icons8_macos_closedam_32;
            this.gunaTileButton1.ImageSize = new System.Drawing.Size(32, 32);
            this.gunaTileButton1.Name = "gunaTileButton1";
            this.gunaTileButton1.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.gunaTileButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaTileButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaTileButton1.OnHoverImage = null;
            this.gunaTileButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaTileButton1.UseTransfarantBackground = true;
            this.gunaTileButton1.Click += new System.EventHandler(this.gunaTileButton1_Click);
            // 
            // btnMinimize
            // 
            resources.ApplyResources(this.btnMinimize, "btnMinimize");
            this.btnMinimize.AnimationHoverSpeed = 0.07F;
            this.btnMinimize.AnimationSpeed = 0.03F;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BaseColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BorderColor = System.Drawing.Color.Black;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinimize.FocusedColor = System.Drawing.Color.White;
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = global::TimKiemNhaTro.Properties.Resources.icons8_macos_minimize_32;
            this.btnMinimize.ImageSize = new System.Drawing.Size(32, 32);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnMinimize.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMinimize.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMinimize.OnHoverImage = null;
            this.btnMinimize.OnPressedColor = System.Drawing.Color.Black;
            this.btnMinimize.UseTransfarantBackground = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlMenu
            // 
            resources.ApplyResources(this.pnlMenu, "pnlMenu");
            this.pnlMenu.Controls.Add(this.btnTiengAnh);
            this.pnlMenu.Controls.Add(this.btnTiengViet);
            this.pnlMenu.Controls.Add(this.picGif);
            this.pnlMenu.Controls.Add(this.pnlMove);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.picLogo);
            this.pnlMenu.Controls.Add(this.btnSetting);
            this.pnlMenu.Controls.Add(this.btnUser);
            this.pnlMenu.Controls.Add(this.btnFavourite);
            this.pnlMenu.Controls.Add(this.btnFindMap);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.GradientColor1 = System.Drawing.Color.PowderBlue;
            this.pnlMenu.GradientColor2 = System.Drawing.Color.White;
            this.pnlMenu.GradientColor3 = System.Drawing.Color.Snow;
            this.pnlMenu.GradientColor4 = System.Drawing.Color.White;
            this.pnlMenu.Name = "pnlMenu";
            // 
            // btnTiengAnh
            // 
            this.btnTiengAnh.AnimationHoverSpeed = 0.07F;
            this.btnTiengAnh.AnimationSpeed = 0.03F;
            this.btnTiengAnh.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnTiengAnh.BorderColor = System.Drawing.Color.Black;
            this.btnTiengAnh.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnTiengAnh.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnTiengAnh.CheckedForeColor = System.Drawing.Color.White;
            this.btnTiengAnh.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnTiengAnh.CheckedImage")));
            this.btnTiengAnh.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnTiengAnh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTiengAnh.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btnTiengAnh, "btnTiengAnh");
            this.btnTiengAnh.ForeColor = System.Drawing.Color.White;
            this.btnTiengAnh.Image = ((System.Drawing.Image)(resources.GetObject("btnTiengAnh.Image")));
            this.btnTiengAnh.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTiengAnh.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTiengAnh.Name = "btnTiengAnh";
            this.btnTiengAnh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTiengAnh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTiengAnh.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTiengAnh.OnHoverImage = null;
            this.btnTiengAnh.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTiengAnh.OnPressedColor = System.Drawing.Color.Black;
            this.btnTiengAnh.Click += new System.EventHandler(this.btnTiengAnh_Click);
            // 
            // btnTiengViet
            // 
            this.btnTiengViet.AnimationHoverSpeed = 0.07F;
            this.btnTiengViet.AnimationSpeed = 0.03F;
            this.btnTiengViet.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnTiengViet.BorderColor = System.Drawing.Color.Black;
            this.btnTiengViet.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnTiengViet.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnTiengViet.CheckedForeColor = System.Drawing.Color.White;
            this.btnTiengViet.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnTiengViet.CheckedImage")));
            this.btnTiengViet.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnTiengViet.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTiengViet.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btnTiengViet, "btnTiengViet");
            this.btnTiengViet.ForeColor = System.Drawing.Color.White;
            this.btnTiengViet.Image = ((System.Drawing.Image)(resources.GetObject("btnTiengViet.Image")));
            this.btnTiengViet.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTiengViet.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTiengViet.Name = "btnTiengViet";
            this.btnTiengViet.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTiengViet.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTiengViet.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTiengViet.OnHoverImage = null;
            this.btnTiengViet.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTiengViet.OnPressedColor = System.Drawing.Color.Black;
            this.btnTiengViet.Click += new System.EventHandler(this.btnTiengViet_Click);
            // 
            // picGif
            // 
            this.picGif.BackColor = System.Drawing.Color.Transparent;
            this.picGif.BaseColor = System.Drawing.Color.White;
            this.picGif.Image = global::TimKiemNhaTro.Properties.Resources._1e3e3738d81b9db4f6b6505b236a996a;
            resources.ApplyResources(this.picGif, "picGif");
            this.picGif.Name = "picGif";
            this.picGif.TabStop = false;
            // 
            // pnlMove
            // 
            this.pnlMove.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.pnlMove, "pnlMove");
            this.pnlMove.Name = "pnlMove";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::TimKiemNhaTro.Properties.Resources.slack;
            resources.ApplyResources(this.picLogo, "picLogo");
            this.picLogo.Name = "picLogo";
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.AnimationHoverSpeed = 0.07F;
            this.btnSetting.AnimationSpeed = 0.03F;
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BaseColor = System.Drawing.Color.Transparent;
            this.btnSetting.BorderColor = System.Drawing.Color.Transparent;
            this.btnSetting.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnSetting.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSetting.CheckedForeColor = System.Drawing.Color.White;
            this.btnSetting.CheckedImage = global::TimKiemNhaTro.Properties.Resources.icons8_settingwHITEs_32;
            this.btnSetting.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSetting.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btnSetting, "btnSetting");
            this.btnSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.btnSetting.Image = global::TimKiemNhaTro.Properties.Resources.icons8_settingsVIP_32;
            this.btnSetting.ImageOffsetX = 10;
            this.btnSetting.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSetting.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.OnHoverBaseColor = System.Drawing.Color.LightGray;
            this.btnSetting.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnSetting.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSetting.OnHoverImage = null;
            this.btnSetting.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSetting.OnPressedColor = System.Drawing.Color.BlanchedAlmond;
            this.btnSetting.Radius = 15;
            this.btnSetting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnUser
            // 
            this.btnUser.AnimationHoverSpeed = 0.07F;
            this.btnUser.AnimationSpeed = 0.03F;
            this.btnUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUser.BaseColor = System.Drawing.Color.Transparent;
            this.btnUser.BorderColor = System.Drawing.Color.Transparent;
            this.btnUser.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnUser.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnUser.CheckedForeColor = System.Drawing.Color.White;
            this.btnUser.CheckedImage = global::TimKiemNhaTro.Properties.Resources.icons8_male_userWHITE_32;
            this.btnUser.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUser.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btnUser, "btnUser");
            this.btnUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.btnUser.Image = global::TimKiemNhaTro.Properties.Resources.icons8_MALE_user123_32;
            this.btnUser.ImageOffsetX = 10;
            this.btnUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUser.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUser.Name = "btnUser";
            this.btnUser.OnHoverBaseColor = System.Drawing.Color.LightGray;
            this.btnUser.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnUser.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUser.OnHoverImage = null;
            this.btnUser.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUser.OnPressedColor = System.Drawing.Color.BlanchedAlmond;
            this.btnUser.Radius = 15;
            this.btnUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnFavourite
            // 
            this.btnFavourite.AnimationHoverSpeed = 0.07F;
            this.btnFavourite.AnimationSpeed = 0.03F;
            this.btnFavourite.BackColor = System.Drawing.Color.Transparent;
            this.btnFavourite.BaseColor = System.Drawing.Color.Transparent;
            this.btnFavourite.BorderColor = System.Drawing.Color.Transparent;
            this.btnFavourite.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnFavourite.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnFavourite.CheckedForeColor = System.Drawing.Color.White;
            this.btnFavourite.CheckedImage = global::TimKiemNhaTro.Properties.Resources.icons8_heartWHITE_32;
            this.btnFavourite.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnFavourite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFavourite.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFavourite.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btnFavourite, "btnFavourite");
            this.btnFavourite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.btnFavourite.Image = global::TimKiemNhaTro.Properties.Resources.icons8_heart_32;
            this.btnFavourite.ImageOffsetX = 10;
            this.btnFavourite.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFavourite.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnFavourite.Name = "btnFavourite";
            this.btnFavourite.OnHoverBaseColor = System.Drawing.Color.LightGray;
            this.btnFavourite.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnFavourite.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFavourite.OnHoverImage = null;
            this.btnFavourite.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnFavourite.OnPressedColor = System.Drawing.Color.BlanchedAlmond;
            this.btnFavourite.Radius = 15;
            this.btnFavourite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFavourite.Click += new System.EventHandler(this.btnFavourite_Click);
            // 
            // btnFindMap
            // 
            this.btnFindMap.AnimationHoverSpeed = 0.07F;
            this.btnFindMap.AnimationSpeed = 0.03F;
            this.btnFindMap.BackColor = System.Drawing.Color.Transparent;
            this.btnFindMap.BaseColor = System.Drawing.Color.Transparent;
            this.btnFindMap.BorderColor = System.Drawing.Color.Transparent;
            this.btnFindMap.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnFindMap.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnFindMap.CheckedForeColor = System.Drawing.Color.White;
            this.btnFindMap.CheckedImage = global::TimKiemNhaTro.Properties.Resources.icons8_google_mapsWHITE_32;
            this.btnFindMap.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnFindMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindMap.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFindMap.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btnFindMap, "btnFindMap");
            this.btnFindMap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.btnFindMap.Image = global::TimKiemNhaTro.Properties.Resources.icons8_google_maps_32;
            this.btnFindMap.ImageOffsetX = 10;
            this.btnFindMap.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFindMap.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnFindMap.Name = "btnFindMap";
            this.btnFindMap.OnHoverBaseColor = System.Drawing.Color.LightGray;
            this.btnFindMap.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnFindMap.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFindMap.OnHoverImage = null;
            this.btnFindMap.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnFindMap.OnPressedColor = System.Drawing.Color.BlanchedAlmond;
            this.btnFindMap.Radius = 15;
            this.btnFindMap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFindMap.Click += new System.EventHandler(this.btnFindMap_Click);
            // 
            // btnHome
            // 
            this.btnHome.AnimationHoverSpeed = 0.07F;
            this.btnHome.AnimationSpeed = 0.03F;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BaseColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderColor = System.Drawing.Color.Transparent;
            this.btnHome.Checked = true;
            this.btnHome.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnHome.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnHome.CheckedForeColor = System.Drawing.Color.White;
            this.btnHome.CheckedImage = global::TimKiemNhaTro.Properties.Resources.icons8_dashboard_layoutrreal_32;
            this.btnHome.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHome.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btnHome, "btnHome");
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.btnHome.Image = global::TimKiemNhaTro.Properties.Resources.icons8_dashboard_layout2_32;
            this.btnHome.ImageOffsetX = 10;
            this.btnHome.ImageSize = new System.Drawing.Size(25, 25);
            this.btnHome.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnHome.Name = "btnHome";
            this.btnHome.OnHoverBaseColor = System.Drawing.Color.LightGray;
            this.btnHome.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnHome.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHome.OnHoverImage = null;
            this.btnHome.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnHome.OnPressedColor = System.Drawing.Color.BlanchedAlmond;
            this.btnHome.Radius = 15;
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // picChat
            // 
            resources.ApplyResources(this.picChat, "picChat");
            this.picChat.Image = global::TimKiemNhaTro.Properties.Resources.chat_bubbles_with_ellipsis__1_;
            this.picChat.Name = "picChat";
            this.picChat.TabStop = false;
            this.picChat.Click += new System.EventHandler(this.picChat_Click);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlUC);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlUC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrPaint)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel pnlMenu;
        private Guna.UI.WinForms.GunaAdvenceButton btnHome;
        private Guna.UI.WinForms.GunaAdvenceButton btnFindMap;
        private Guna.UI.WinForms.GunaAdvenceButton btnUser;
        private Guna.UI.WinForms.GunaAdvenceButton btnFavourite;
        private Guna.UI.WinForms.GunaAdvenceButton btnSetting;
        private Guna.UI.WinForms.GunaElipse gelipFrmTaskee;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMove;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPosition;
        private Guna.UI.WinForms.GunaTileButton btnMinimize;
        private Guna.UI.WinForms.GunaTileButton gunaTileButton1;
        private System.Windows.Forms.PictureBox ptrPaint;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaDateTimePicker dtpRealTime;
        private Guna.UI.WinForms.GunaPictureBox picGif;
        private System.Windows.Forms.Panel pnlUC;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddHouse;
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private Guna.UI.WinForms.GunaCirclePictureBox picAvatar;
        private Guna.UI.WinForms.GunaAdvenceButton btnTiengAnh;
        private Guna.UI.WinForms.GunaAdvenceButton btnTiengViet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picChat;
    }
}

