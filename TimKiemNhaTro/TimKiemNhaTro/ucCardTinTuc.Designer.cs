
namespace TimKiemNhaTro
{
    partial class ucCardTinTuc
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
            this.ptrPicNha = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnType = new Guna.UI2.WinForms.Guna2Button();
            this.btnChiTiet = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblContent = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrPicNha)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.ptrPicNha);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(616, 300);
            this.guna2Panel1.TabIndex = 1;
            // 
            // ptrPicNha
            // 
            this.ptrPicNha.BorderRadius = 20;
            this.ptrPicNha.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptrPicNha.Image = global::TimKiemNhaTro.Properties.Resources.quan2;
            this.ptrPicNha.Location = new System.Drawing.Point(10, 10);
            this.ptrPicNha.Name = "ptrPicNha";
            this.ptrPicNha.ShadowDecoration.Parent = this.ptrPicNha;
            this.ptrPicNha.Size = new System.Drawing.Size(280, 280);
            this.ptrPicNha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrPicNha.TabIndex = 10;
            this.ptrPicNha.TabStop = false;
            // 
            // btnType
            // 
            this.btnType.BorderRadius = 4;
            this.btnType.CheckedState.Parent = this.btnType;
            this.btnType.CustomImages.Parent = this.btnType;
            this.btnType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnType.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(167)))), ((int)(((byte)(226)))));
            this.btnType.HoverState.Parent = this.btnType;
            this.btnType.Image = global::TimKiemNhaTro.Properties.Resources.home1;
            this.btnType.ImageSize = new System.Drawing.Size(16, 16);
            this.btnType.Location = new System.Drawing.Point(10, 3);
            this.btnType.Name = "btnType";
            this.btnType.ShadowDecoration.Parent = this.btnType;
            this.btnType.Size = new System.Drawing.Size(89, 23);
            this.btnType.TabIndex = 11;
            this.btnType.Text = "Tin tức";
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.BorderRadius = 10;
            this.btnChiTiet.CheckedState.Parent = this.btnChiTiet;
            this.btnChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChiTiet.CustomImages.Parent = this.btnChiTiet;
            this.btnChiTiet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.btnChiTiet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnChiTiet.HoverState.Parent = this.btnChiTiet;
            this.btnChiTiet.Location = new System.Drawing.Point(184, 232);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.ShadowDecoration.Parent = this.btnChiTiet;
            this.btnChiTiet.Size = new System.Drawing.Size(105, 45);
            this.btnChiTiet.TabIndex = 12;
            this.btnChiTiet.Text = "Chi Tiết";
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel2.Controls.Add(this.lblContent);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel6);
            this.guna2Panel2.Controls.Add(this.btnChiTiet);
            this.guna2Panel2.Controls.Add(this.btnType);
            this.guna2Panel2.Controls.Add(this.lblTitle);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel2.Location = new System.Drawing.Point(296, 10);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(310, 280);
            this.guna2Panel2.TabIndex = 11;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.lblTitle.Location = new System.Drawing.Point(15, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(274, 55);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Giảm tiền thuê trọ tốt cho cả đôi bên";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.Blue;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(69, 241);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(94, 19);
            this.guna2HtmlLabel6.TabIndex = 19;
            this.guna2HtmlLabel6.Text = "vnexpress.com";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = false;
            this.lblContent.BackColor = System.Drawing.Color.Transparent;
            this.lblContent.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.ForeColor = System.Drawing.Color.DimGray;
            this.lblContent.Location = new System.Drawing.Point(15, 113);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(274, 113);
            this.lblContent.TabIndex = 22;
            this.lblContent.Text = "Nếu tôi trả nhà, chủ trọ cũng mất đi thu nhập hàng tháng, thời điểm này khó cho t" +
    "huê lại, mà nhà để không cũng mau hư.";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Blue;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(18, 241);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(45, 19);
            this.guna2HtmlLabel2.TabIndex = 23;
            this.guna2HtmlLabel2.Text = "Nguồn";
            // 
            // ucCardTinTuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ucCardTinTuc";
            this.Size = new System.Drawing.Size(616, 300);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptrPicNha)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox ptrPicNha;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblContent;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2Button btnChiTiet;
        private Guna.UI2.WinForms.Guna2Button btnType;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
    }
}
