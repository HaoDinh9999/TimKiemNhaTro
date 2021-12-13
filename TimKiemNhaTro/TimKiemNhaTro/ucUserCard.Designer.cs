
namespace TimKiemNhaTro
{
    partial class ucUserCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNgungHD = new Guna.UI2.WinForms.Guna2Button();
            this.btnKhoiPhuc = new Guna.UI2.WinForms.Guna2Button();
            this.lblDangHD = new Guna.UI2.WinForms.Guna2Button();
            this.btnVoHieu = new Guna.UI2.WinForms.Guna2Button();
            this.lblEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 4;
            this.guna2Panel1.Controls.Add(this.lblDangHD);
            this.guna2Panel1.Controls.Add(this.lblNgungHD);
            this.guna2Panel1.Controls.Add(this.btnVoHieu);
            this.guna2Panel1.Controls.Add(this.btnKhoiPhuc);
            this.guna2Panel1.Controls.Add(this.lblEmail);
            this.guna2Panel1.Controls.Add(this.lblName);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(316, 312);
            this.guna2Panel1.TabIndex = 3;
            // 
            // lblNgungHD
            // 
            this.lblNgungHD.BorderRadius = 4;
            this.lblNgungHD.CheckedState.Parent = this.lblNgungHD;
            this.lblNgungHD.CustomImages.Parent = this.lblNgungHD;
            this.lblNgungHD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblNgungHD.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgungHD.ForeColor = System.Drawing.Color.Silver;
            this.lblNgungHD.HoverState.Parent = this.lblNgungHD;
            this.lblNgungHD.ImageSize = new System.Drawing.Size(16, 16);
            this.lblNgungHD.Location = new System.Drawing.Point(92, 149);
            this.lblNgungHD.Name = "lblNgungHD";
            this.lblNgungHD.ShadowDecoration.Parent = this.lblNgungHD;
            this.lblNgungHD.Size = new System.Drawing.Size(130, 23);
            this.lblNgungHD.TabIndex = 14;
            this.lblNgungHD.Text = "Ngưng hoạt động";
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.BorderRadius = 4;
            this.btnKhoiPhuc.CheckedState.Parent = this.btnKhoiPhuc;
            this.btnKhoiPhuc.CustomImages.Parent = this.btnKhoiPhuc;
            this.btnKhoiPhuc.FillColor = System.Drawing.Color.DarkKhaki;
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKhoiPhuc.ForeColor = System.Drawing.Color.White;
            this.btnKhoiPhuc.HoverState.Parent = this.btnKhoiPhuc;
            this.btnKhoiPhuc.Location = new System.Drawing.Point(91, 249);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.ShadowDecoration.Parent = this.btnKhoiPhuc;
            this.btnKhoiPhuc.Size = new System.Drawing.Size(131, 41);
            this.btnKhoiPhuc.TabIndex = 13;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // lblDangHD
            // 
            this.lblDangHD.BorderRadius = 4;
            this.lblDangHD.CheckedState.Parent = this.lblDangHD;
            this.lblDangHD.CustomImages.Parent = this.lblDangHD;
            this.lblDangHD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblDangHD.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(167)))), ((int)(((byte)(226)))));
            this.lblDangHD.HoverState.Parent = this.lblDangHD;
            this.lblDangHD.ImageSize = new System.Drawing.Size(16, 16);
            this.lblDangHD.Location = new System.Drawing.Point(92, 149);
            this.lblDangHD.Name = "lblDangHD";
            this.lblDangHD.ShadowDecoration.Parent = this.lblDangHD;
            this.lblDangHD.Size = new System.Drawing.Size(120, 23);
            this.lblDangHD.TabIndex = 12;
            this.lblDangHD.Text = "Đang hoạt động";
            // 
            // btnVoHieu
            // 
            this.btnVoHieu.BorderRadius = 4;
            this.btnVoHieu.CheckedState.Parent = this.btnVoHieu;
            this.btnVoHieu.CustomImages.Parent = this.btnVoHieu;
            this.btnVoHieu.FillColor = System.Drawing.Color.Silver;
            this.btnVoHieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVoHieu.ForeColor = System.Drawing.Color.White;
            this.btnVoHieu.HoverState.Parent = this.btnVoHieu;
            this.btnVoHieu.Location = new System.Drawing.Point(91, 249);
            this.btnVoHieu.Name = "btnVoHieu";
            this.btnVoHieu.ShadowDecoration.Parent = this.btnVoHieu;
            this.btnVoHieu.Size = new System.Drawing.Size(131, 41);
            this.btnVoHieu.TabIndex = 3;
            this.btnVoHieu.Text = "Vô hiệu hóa";
            this.btnVoHieu.Click += new System.EventHandler(this.btnVoHieu_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = false;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Silver;
            this.lblEmail.Location = new System.Drawing.Point(0, 210);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(316, 33);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "nccuong9301@gmail.com";
            this.lblEmail.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = false;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(0, 171);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(316, 33);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nguyễn Cao Cường";
            this.lblName.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::TimKiemNhaTro.Properties.Resources.loading;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(92, 13);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(130, 130);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // ucUserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ucUserCard";
            this.Size = new System.Drawing.Size(316, 312);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnVoHieu;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button lblNgungHD;
        private Guna.UI2.WinForms.Guna2Button btnKhoiPhuc;
        private Guna.UI2.WinForms.Guna2Button lblDangHD;
    }
}
