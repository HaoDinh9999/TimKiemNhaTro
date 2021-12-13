
namespace TimKiemNhaTro
{
    partial class ucCardNguoiDungChat
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNgayGui = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTinNhan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picAvt = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblNgayGui);
            this.panel4.Controls.Add(this.lblTinNhan);
            this.panel4.Controls.Add(this.lblTen);
            this.panel4.Controls.Add(this.picAvt);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(748, 90);
            this.panel4.TabIndex = 4;
            this.panel4.Click += new System.EventHandler(this.ucCardNguoiDungChat_Click);
            // 
            // lblNgayGui
            // 
            this.lblNgayGui.AutoSize = false;
            this.lblNgayGui.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayGui.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayGui.ForeColor = System.Drawing.Color.Gray;
            this.lblNgayGui.Location = new System.Drawing.Point(665, 16);
            this.lblNgayGui.Name = "lblNgayGui";
            this.lblNgayGui.Size = new System.Drawing.Size(71, 19);
            this.lblNgayGui.TabIndex = 4;
            this.lblNgayGui.Text = "06/12";
            this.lblNgayGui.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblNgayGui.Click += new System.EventHandler(this.ucCardNguoiDungChat_Click);
            // 
            // lblTinNhan
            // 
            this.lblTinNhan.BackColor = System.Drawing.Color.Transparent;
            this.lblTinNhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinNhan.ForeColor = System.Drawing.Color.Gray;
            this.lblTinNhan.Location = new System.Drawing.Point(93, 41);
            this.lblTinNhan.Name = "lblTinNhan";
            this.lblTinNhan.Size = new System.Drawing.Size(204, 25);
            this.lblTinNhan.TabIndex = 3;
            this.lblTinNhan.Text = "Admin ơi, mình cần hỗ trợ";
            this.lblTinNhan.Click += new System.EventHandler(this.ucCardNguoiDungChat_Click);
            // 
            // lblTen
            // 
            this.lblTen.BackColor = System.Drawing.Color.Transparent;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.Black;
            this.lblTen.Location = new System.Drawing.Point(93, 5);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(124, 30);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Đinh Việt Hào";
            this.lblTen.Click += new System.EventHandler(this.ucCardNguoiDungChat_Click);
            // 
            // picAvt
            // 
            this.picAvt.InitialImage = null;
            this.picAvt.Location = new System.Drawing.Point(12, 10);
            this.picAvt.Name = "picAvt";
            this.picAvt.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picAvt.ShadowDecoration.Parent = this.picAvt;
            this.picAvt.Size = new System.Drawing.Size(60, 60);
            this.picAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvt.TabIndex = 0;
            this.picAvt.TabStop = false;
            this.picAvt.Click += new System.EventHandler(this.ucCardNguoiDungChat_Click);
            // 
            // ucCardNguoiDungChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ucCardNguoiDungChat";
            this.Size = new System.Drawing.Size(748, 90);
            this.Click += new System.EventHandler(this.ucCardNguoiDungChat_Click);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNgayGui;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTinNhan;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTen;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picAvt;
    }
}
