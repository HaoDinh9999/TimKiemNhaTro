
namespace TimKiemNhaTro
{
    partial class ucCardDanhGia
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
            this.picAvatar = new Guna.UI.WinForms.GunaPictureBox();
            this.lblTenNguoiDung = new System.Windows.Forms.Label();
            this.rateNguoiDung = new Guna.UI2.WinForms.Guna2RatingStar();
            this.rtxBinhLuan = new System.Windows.Forms.RichTextBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnEdit = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // picAvatar
            // 
            this.picAvatar.BaseColor = System.Drawing.Color.White;
            this.picAvatar.Image = global::TimKiemNhaTro.Properties.Resources.triangular;
            this.picAvatar.Location = new System.Drawing.Point(55, 14);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(139, 120);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // lblTenNguoiDung
            // 
            this.lblTenNguoiDung.AutoSize = true;
            this.lblTenNguoiDung.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNguoiDung.Location = new System.Drawing.Point(243, 18);
            this.lblTenNguoiDung.Name = "lblTenNguoiDung";
            this.lblTenNguoiDung.Size = new System.Drawing.Size(148, 24);
            this.lblTenNguoiDung.TabIndex = 1;
            this.lblTenNguoiDung.Text = "Đinh Việt Hào";
            // 
            // rateNguoiDung
            // 
            this.rateNguoiDung.Location = new System.Drawing.Point(247, 49);
            this.rateNguoiDung.Name = "rateNguoiDung";
            this.rateNguoiDung.RatingColor = System.Drawing.Color.Gold;
            this.rateNguoiDung.Size = new System.Drawing.Size(144, 28);
            this.rateNguoiDung.TabIndex = 2;
            // 
            // rtxBinhLuan
            // 
            this.rtxBinhLuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxBinhLuan.Font = new System.Drawing.Font("Tahoma", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxBinhLuan.Location = new System.Drawing.Point(247, 88);
            this.rtxBinhLuan.Name = "rtxBinhLuan";
            this.rtxBinhLuan.Size = new System.Drawing.Size(1021, 47);
            this.rtxBinhLuan.TabIndex = 3;
            this.rtxBinhLuan.Text = "Mua được 7 ngày, đổi trả, tính phí 30%, ăn chặn quá mức. Ăn vô hậu.";
            // 
            // btnDelete
            // 
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Image = global::TimKiemNhaTro.Properties.Resources.icons8_wasteXOA_32;
            this.btnDelete.ImageSize = new System.Drawing.Size(18, 18);
            this.btnDelete.Location = new System.Drawing.Point(1250, 18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(32, 32);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Image = global::TimKiemNhaTro.Properties.Resources.icons8_edit_32;
            this.btnEdit.Location = new System.Drawing.Point(1212, 18);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(32, 32);
            this.btnEdit.TabIndex = 29;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // ucCardDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.rtxBinhLuan);
            this.Controls.Add(this.rateNguoiDung);
            this.Controls.Add(this.lblTenNguoiDung);
            this.Controls.Add(this.picAvatar);
            this.Name = "ucCardDanhGia";
            this.Size = new System.Drawing.Size(1300, 150);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox picAvatar;
        private System.Windows.Forms.Label lblTenNguoiDung;
        private Guna.UI2.WinForms.Guna2RatingStar rateNguoiDung;
        private System.Windows.Forms.RichTextBox rtxBinhLuan;
        private Guna.UI2.WinForms.Guna2CircleButton btnDelete;
        private Guna.UI2.WinForms.Guna2CircleButton btnEdit;
    }
}
