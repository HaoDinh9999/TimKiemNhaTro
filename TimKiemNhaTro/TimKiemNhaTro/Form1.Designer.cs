
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
            this.ptrPaint = new System.Windows.Forms.PictureBox();
            this.gunaTileButton1 = new Guna.UI.WinForms.GunaTileButton();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnMinimize = new Guna.UI.WinForms.GunaTileButton();
            this.btnUsername = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnlUC = new System.Windows.Forms.Panel();
            this.btnAddHouse = new Guna.UI.WinForms.GunaAdvenceButton();
            this.mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            this.pnlMenu = new Guna.UI.WinForms.GunaGradientPanel();
            this.picGif = new Guna.UI.WinForms.GunaPictureBox();
            this.pnlMove = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnSetting = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnUser = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnFavourite = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnFindMap = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnHome = new Guna.UI.WinForms.GunaAdvenceButton();
            this.picAvatar = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrPaint)).BeginInit();
            this.pnlUC.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // gelipFrmTaskee
            // 
            this.gelipFrmTaskee.Radius = 35;
            this.gelipFrmTaskee.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picAvatar);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.dtpRealTime);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.ptrPaint);
            this.panel2.Controls.Add(this.gunaTileButton1);
            this.panel2.Controls.Add(this.lblPosition);
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnUsername);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(297, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1510, 58);
            this.panel2.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(24, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(132, 29);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Trang chủ";
            // 
            // dtpRealTime
            // 
            this.dtpRealTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpRealTime.BackColor = System.Drawing.Color.Transparent;
            this.dtpRealTime.BaseColor = System.Drawing.Color.White;
            this.dtpRealTime.BorderColor = System.Drawing.Color.Silver;
            this.dtpRealTime.CustomFormat = null;
            this.dtpRealTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpRealTime.FocusedColor = System.Drawing.Color.White;
            this.dtpRealTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpRealTime.ForeColor = System.Drawing.Color.Black;
            this.dtpRealTime.Location = new System.Drawing.Point(895, 10);
            this.dtpRealTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpRealTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpRealTime.Name = "dtpRealTime";
            this.dtpRealTime.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpRealTime.OnHoverBorderColor = System.Drawing.Color.Black;
            this.dtpRealTime.OnHoverForeColor = System.Drawing.Color.Black;
            this.dtpRealTime.OnPressedColor = System.Drawing.Color.Black;
            this.dtpRealTime.Radius = 10;
            this.dtpRealTime.Size = new System.Drawing.Size(234, 40);
            this.dtpRealTime.TabIndex = 2;
            this.dtpRealTime.Text = "Friday, October 15, 2021";
            this.dtpRealTime.Value = new System.DateTime(2021, 10, 15, 16, 35, 32, 952);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(1198, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 30);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Location = new System.Drawing.Point(1140, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 30);
            this.panel3.TabIndex = 2;
            // 
            // ptrPaint
            // 
            this.ptrPaint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptrPaint.Image = global::TimKiemNhaTro.Properties.Resources.icons8_paint_palette_with_brush_32;
            this.ptrPaint.Location = new System.Drawing.Point(1154, 16);
            this.ptrPaint.Name = "ptrPaint";
            this.ptrPaint.Size = new System.Drawing.Size(32, 32);
            this.ptrPaint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrPaint.TabIndex = 3;
            this.ptrPaint.TabStop = false;
            // 
            // gunaTileButton1
            // 
            this.gunaTileButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaTileButton1.AnimationHoverSpeed = 0.07F;
            this.gunaTileButton1.AnimationSpeed = 0.03F;
            this.gunaTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTileButton1.BaseColor = System.Drawing.SystemColors.Window;
            this.gunaTileButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTileButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaTileButton1.FocusedColor = System.Drawing.Color.White;
            this.gunaTileButton1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.gunaTileButton1.ForeColor = System.Drawing.Color.Transparent;
            this.gunaTileButton1.Image = global::TimKiemNhaTro.Properties.Resources.icons8_macos_closedam_32;
            this.gunaTileButton1.ImageSize = new System.Drawing.Size(32, 32);
            this.gunaTileButton1.Location = new System.Drawing.Point(1458, 8);
            this.gunaTileButton1.Name = "gunaTileButton1";
            this.gunaTileButton1.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.gunaTileButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaTileButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaTileButton1.OnHoverImage = null;
            this.gunaTileButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaTileButton1.Size = new System.Drawing.Size(39, 36);
            this.gunaTileButton1.TabIndex = 9;
            this.gunaTileButton1.UseTransfarantBackground = true;
            this.gunaTileButton1.Click += new System.EventHandler(this.gunaTileButton1_Click);
            // 
            // lblPosition
            // 
            this.lblPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPosition.AutoSize = true;
            this.lblPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPosition.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(1270, 34);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(89, 17);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "Khách hàng";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.AnimationHoverSpeed = 0.07F;
            this.btnMinimize.AnimationSpeed = 0.03F;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BaseColor = System.Drawing.SystemColors.Window;
            this.btnMinimize.BorderColor = System.Drawing.Color.Black;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinimize.FocusedColor = System.Drawing.Color.White;
            this.btnMinimize.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = global::TimKiemNhaTro.Properties.Resources.icons8_macos_minimize_32;
            this.btnMinimize.ImageSize = new System.Drawing.Size(32, 32);
            this.btnMinimize.Location = new System.Drawing.Point(1416, 8);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnMinimize.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMinimize.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMinimize.OnHoverImage = null;
            this.btnMinimize.OnPressedColor = System.Drawing.Color.Black;
            this.btnMinimize.Size = new System.Drawing.Size(39, 36);
            this.btnMinimize.TabIndex = 8;
            this.btnMinimize.UseTransfarantBackground = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnUsername
            // 
            this.btnUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsername.AnimationHoverSpeed = 0.07F;
            this.btnUsername.AnimationSpeed = 0.03F;
            this.btnUsername.BaseColor = System.Drawing.Color.White;
            this.btnUsername.BorderColor = System.Drawing.Color.Black;
            this.btnUsername.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnUsername.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnUsername.CheckedForeColor = System.Drawing.Color.White;
            this.btnUsername.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnUsername.CheckedImage")));
            this.btnUsername.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsername.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUsername.FocusedColor = System.Drawing.Color.Empty;
            this.btnUsername.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsername.ForeColor = System.Drawing.Color.Black;
            this.btnUsername.Image = null;
            this.btnUsername.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUsername.LineColor = System.Drawing.Color.White;
            this.btnUsername.Location = new System.Drawing.Point(1263, 3);
            this.btnUsername.Name = "btnUsername";
            this.btnUsername.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnUsername.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUsername.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnUsername.OnHoverImage = null;
            this.btnUsername.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUsername.OnPressedColor = System.Drawing.Color.Black;
            this.btnUsername.Size = new System.Drawing.Size(147, 39);
            this.btnUsername.TabIndex = 2;
            this.btnUsername.Text = "Hi HaoDinh";
            // 
            // pnlUC
            // 
            this.pnlUC.Controls.Add(this.btnAddHouse);
            this.pnlUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUC.Location = new System.Drawing.Point(297, 58);
            this.pnlUC.Name = "pnlUC";
            this.pnlUC.Size = new System.Drawing.Size(1510, 795);
            this.pnlUC.TabIndex = 2;
            // 
            // btnAddHouse
            // 
            this.btnAddHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnAddHouse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddHouse.ForeColor = System.Drawing.Color.White;
            this.btnAddHouse.Image = global::TimKiemNhaTro.Properties.Resources.icons8_plus_math_32;
            this.btnAddHouse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddHouse.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddHouse.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddHouse.Location = new System.Drawing.Point(1416, 720);
            this.btnAddHouse.Name = "btnAddHouse";
            this.btnAddHouse.OnHoverBaseColor = System.Drawing.Color.LightGray;
            this.btnAddHouse.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddHouse.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddHouse.OnHoverImage = null;
            this.btnAddHouse.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddHouse.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddHouse.Radius = 30;
            this.btnAddHouse.Size = new System.Drawing.Size(63, 63);
            this.btnAddHouse.TabIndex = 18;
            this.btnAddHouse.Click += new System.EventHandler(this.btnAddHouse_Click);
            // 
            // mySqlCommandBuilder1
            // 
            this.mySqlCommandBuilder1.DataAdapter = null;
            this.mySqlCommandBuilder1.QuotePrefix = "`";
            this.mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMenu.BackgroundImage")));
            this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMenu.Controls.Add(this.picGif);
            this.pnlMenu.Controls.Add(this.pnlMove);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.picLogo);
            this.pnlMenu.Controls.Add(this.btnSetting);
            this.pnlMenu.Controls.Add(this.btnUser);
            this.pnlMenu.Controls.Add(this.btnFavourite);
            this.pnlMenu.Controls.Add(this.btnFindMap);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.GradientColor1 = System.Drawing.Color.PowderBlue;
            this.pnlMenu.GradientColor2 = System.Drawing.Color.White;
            this.pnlMenu.GradientColor3 = System.Drawing.Color.Snow;
            this.pnlMenu.GradientColor4 = System.Drawing.Color.White;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(297, 853);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.Text = "gunaGradientPanel1";
            // 
            // picGif
            // 
            this.picGif.BackColor = System.Drawing.Color.Transparent;
            this.picGif.BaseColor = System.Drawing.Color.White;
            this.picGif.Image = global::TimKiemNhaTro.Properties.Resources._1e3e3738d81b9db4f6b6505b236a996a;
            this.picGif.Location = new System.Drawing.Point(18, 464);
            this.picGif.Name = "picGif";
            this.picGif.Size = new System.Drawing.Size(242, 145);
            this.picGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGif.TabIndex = 2;
            this.picGif.TabStop = false;
            // 
            // pnlMove
            // 
            this.pnlMove.BackColor = System.Drawing.Color.White;
            this.pnlMove.Location = new System.Drawing.Point(258, 117);
            this.pnlMove.Name = "pnlMove";
            this.pnlMove.Size = new System.Drawing.Size(3, 38);
            this.pnlMove.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rent-Finder";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::TimKiemNhaTro.Properties.Resources.slack;
            this.picLogo.Location = new System.Drawing.Point(18, 17);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(65, 55);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
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
            this.btnSetting.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.btnSetting.Image = global::TimKiemNhaTro.Properties.Resources.icons8_settingsVIP_32;
            this.btnSetting.ImageOffsetX = 10;
            this.btnSetting.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSetting.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSetting.Location = new System.Drawing.Point(18, 390);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.OnHoverBaseColor = System.Drawing.Color.LightGray;
            this.btnSetting.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnSetting.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSetting.OnHoverImage = null;
            this.btnSetting.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSetting.OnPressedColor = System.Drawing.Color.BlanchedAlmond;
            this.btnSetting.Radius = 15;
            this.btnSetting.Size = new System.Drawing.Size(259, 55);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = "Cài đặt";
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
            this.btnUser.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.btnUser.Image = global::TimKiemNhaTro.Properties.Resources.icons8_MALE_user123_32;
            this.btnUser.ImageOffsetX = 10;
            this.btnUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUser.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUser.Location = new System.Drawing.Point(18, 321);
            this.btnUser.Name = "btnUser";
            this.btnUser.OnHoverBaseColor = System.Drawing.Color.LightGray;
            this.btnUser.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnUser.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUser.OnHoverImage = null;
            this.btnUser.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUser.OnPressedColor = System.Drawing.Color.BlanchedAlmond;
            this.btnUser.Radius = 15;
            this.btnUser.Size = new System.Drawing.Size(259, 55);
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "Tài khoản";
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
            this.btnFavourite.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavourite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.btnFavourite.Image = global::TimKiemNhaTro.Properties.Resources.icons8_heart_32;
            this.btnFavourite.ImageOffsetX = 10;
            this.btnFavourite.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFavourite.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnFavourite.Location = new System.Drawing.Point(18, 254);
            this.btnFavourite.Name = "btnFavourite";
            this.btnFavourite.OnHoverBaseColor = System.Drawing.Color.LightGray;
            this.btnFavourite.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnFavourite.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFavourite.OnHoverImage = null;
            this.btnFavourite.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnFavourite.OnPressedColor = System.Drawing.Color.BlanchedAlmond;
            this.btnFavourite.Radius = 15;
            this.btnFavourite.Size = new System.Drawing.Size(259, 55);
            this.btnFavourite.TabIndex = 2;
            this.btnFavourite.Text = "Yêu thích";
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
            this.btnFindMap.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindMap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.btnFindMap.Image = global::TimKiemNhaTro.Properties.Resources.icons8_google_maps_32;
            this.btnFindMap.ImageOffsetX = 10;
            this.btnFindMap.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFindMap.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnFindMap.Location = new System.Drawing.Point(18, 187);
            this.btnFindMap.Name = "btnFindMap";
            this.btnFindMap.OnHoverBaseColor = System.Drawing.Color.LightGray;
            this.btnFindMap.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnFindMap.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFindMap.OnHoverImage = null;
            this.btnFindMap.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnFindMap.OnPressedColor = System.Drawing.Color.BlanchedAlmond;
            this.btnFindMap.Radius = 15;
            this.btnFindMap.Size = new System.Drawing.Size(259, 55);
            this.btnFindMap.TabIndex = 1;
            this.btnFindMap.Text = "Tìm kiếm";
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
            this.btnHome.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.btnHome.Image = global::TimKiemNhaTro.Properties.Resources.icons8_dashboard_layout2_32;
            this.btnHome.ImageOffsetX = 10;
            this.btnHome.ImageSize = new System.Drawing.Size(25, 25);
            this.btnHome.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnHome.Location = new System.Drawing.Point(18, 109);
            this.btnHome.Name = "btnHome";
            this.btnHome.OnHoverBaseColor = System.Drawing.Color.LightGray;
            this.btnHome.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnHome.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHome.OnHoverImage = null;
            this.btnHome.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnHome.OnPressedColor = System.Drawing.Color.BlanchedAlmond;
            this.btnHome.Radius = 15;
            this.btnHome.Size = new System.Drawing.Size(259, 55);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.BaseColor = System.Drawing.Color.White;
            this.picAvatar.Image = global::TimKiemNhaTro.Properties.Resources._3612573_18012114440061220336;
            this.picAvatar.Location = new System.Drawing.Point(1212, 8);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(45, 45);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 11;
            this.picAvatar.TabStop = false;
            this.picAvatar.UseTransfarantBackground = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1807, 853);
            this.Controls.Add(this.pnlUC);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrPaint)).EndInit();
            this.pnlUC.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
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
        private Guna.UI.WinForms.GunaAdvenceButton btnUsername;
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
    }
}

