
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCardTinTuc));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnChiTiet = new Guna.UI2.WinForms.Guna2Button();
            this.btnType = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ptrPicNha = new Guna.UI2.WinForms.Guna2PictureBox();
            this.rtxContent = new System.Windows.Forms.RichTextBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrPicNha)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.ptrPicNha);
            resources.ApplyResources(this.guna2Panel1, "guna2Panel1");
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.rtxContent);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel6);
            this.guna2Panel2.Controls.Add(this.btnChiTiet);
            this.guna2Panel2.Controls.Add(this.btnType);
            this.guna2Panel2.Controls.Add(this.lblTitle);
            resources.ApplyResources(this.guna2Panel2, "guna2Panel2");
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2HtmlLabel2, "guna2HtmlLabel2");
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Blue;
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2HtmlLabel6, "guna2HtmlLabel6");
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.Blue;
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.BorderRadius = 10;
            this.btnChiTiet.CheckedState.Parent = this.btnChiTiet;
            this.btnChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChiTiet.CustomImages.Parent = this.btnChiTiet;
            this.btnChiTiet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            resources.ApplyResources(this.btnChiTiet, "btnChiTiet");
            this.btnChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnChiTiet.HoverState.Parent = this.btnChiTiet;
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.ShadowDecoration.Parent = this.btnChiTiet;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnType
            // 
            this.btnType.BorderRadius = 4;
            this.btnType.CheckedState.Parent = this.btnType;
            this.btnType.CustomImages.Parent = this.btnType;
            this.btnType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            resources.ApplyResources(this.btnType, "btnType");
            this.btnType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(167)))), ((int)(((byte)(226)))));
            this.btnType.HoverState.Parent = this.btnType;
            this.btnType.Image = global::TimKiemNhaTro.Properties.Resources.home1;
            this.btnType.ImageSize = new System.Drawing.Size(16, 16);
            this.btnType.Name = "btnType";
            this.btnType.ShadowDecoration.Parent = this.btnType;
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.lblTitle.Name = "lblTitle";
            // 
            // ptrPicNha
            // 
            this.ptrPicNha.BorderRadius = 20;
            resources.ApplyResources(this.ptrPicNha, "ptrPicNha");
            this.ptrPicNha.Image = global::TimKiemNhaTro.Properties.Resources.quan2;
            this.ptrPicNha.Name = "ptrPicNha";
            this.ptrPicNha.ShadowDecoration.Parent = this.ptrPicNha;
            this.ptrPicNha.TabStop = false;
            // 
            // rtxContent
            // 
            this.rtxContent.BackColor = System.Drawing.Color.White;
            this.rtxContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.rtxContent, "rtxContent");
            this.rtxContent.ForeColor = System.Drawing.Color.LightGray;
            this.rtxContent.Name = "rtxContent";
            // 
            // ucCardTinTuc
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ucCardTinTuc";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrPicNha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox ptrPicNha;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2Button btnChiTiet;
        private Guna.UI2.WinForms.Guna2Button btnType;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private System.Windows.Forms.RichTextBox rtxContent;
    }
}
