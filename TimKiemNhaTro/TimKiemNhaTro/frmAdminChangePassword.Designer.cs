
namespace TimKiemNhaTro
{
    partial class frmAdminChangePassword
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
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMKMoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMKCu = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNhapLai = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 4;
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Location = new System.Drawing.Point(49, 358);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(300, 46);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Thay đổi";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(49, 135);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(98, 22);
            this.guna2HtmlLabel2.TabIndex = 17;
            this.guna2HtmlLabel2.Text = "Mật khẩu mới";
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.BorderRadius = 4;
            this.txtMKMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMKMoi.DefaultText = "";
            this.txtMKMoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMKMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMKMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMKMoi.DisabledState.Parent = this.txtMKMoi;
            this.txtMKMoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMKMoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMKMoi.FocusedState.Parent = this.txtMKMoi;
            this.txtMKMoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMKMoi.HoverState.Parent = this.txtMKMoi;
            this.txtMKMoi.Location = new System.Drawing.Point(49, 164);
            this.txtMKMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.PasswordChar = '\0';
            this.txtMKMoi.PlaceholderText = "";
            this.txtMKMoi.SelectedText = "";
            this.txtMKMoi.ShadowDecoration.Parent = this.txtMKMoi;
            this.txtMKMoi.Size = new System.Drawing.Size(300, 42);
            this.txtMKMoi.TabIndex = 16;
            this.txtMKMoi.UseSystemPasswordChar = true;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(49, 43);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(88, 22);
            this.guna2HtmlLabel1.TabIndex = 15;
            this.guna2HtmlLabel1.Text = "Mật khẩu cũ";
            // 
            // txtMKCu
            // 
            this.txtMKCu.BorderRadius = 4;
            this.txtMKCu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMKCu.DefaultText = "";
            this.txtMKCu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMKCu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMKCu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMKCu.DisabledState.Parent = this.txtMKCu;
            this.txtMKCu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMKCu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMKCu.FocusedState.Parent = this.txtMKCu;
            this.txtMKCu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMKCu.HoverState.Parent = this.txtMKCu;
            this.txtMKCu.Location = new System.Drawing.Point(49, 72);
            this.txtMKCu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.PasswordChar = '\0';
            this.txtMKCu.PlaceholderText = "";
            this.txtMKCu.SelectedText = "";
            this.txtMKCu.ShadowDecoration.Parent = this.txtMKCu;
            this.txtMKCu.Size = new System.Drawing.Size(300, 42);
            this.txtMKCu.TabIndex = 14;
            this.txtMKCu.UseSystemPasswordChar = true;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(49, 222);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(159, 22);
            this.guna2HtmlLabel3.TabIndex = 20;
            this.guna2HtmlLabel3.Text = "Nhập lại mật khẩu mới";
            // 
            // txtNhapLai
            // 
            this.txtNhapLai.BorderRadius = 4;
            this.txtNhapLai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhapLai.DefaultText = "";
            this.txtNhapLai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNhapLai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNhapLai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhapLai.DisabledState.Parent = this.txtNhapLai;
            this.txtNhapLai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhapLai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhapLai.FocusedState.Parent = this.txtNhapLai;
            this.txtNhapLai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhapLai.HoverState.Parent = this.txtNhapLai;
            this.txtNhapLai.Location = new System.Drawing.Point(49, 251);
            this.txtNhapLai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNhapLai.Name = "txtNhapLai";
            this.txtNhapLai.PasswordChar = '\0';
            this.txtNhapLai.PlaceholderText = "";
            this.txtNhapLai.SelectedText = "";
            this.txtNhapLai.ShadowDecoration.Parent = this.txtNhapLai;
            this.txtNhapLai.Size = new System.Drawing.Size(300, 42);
            this.txtNhapLai.TabIndex = 19;
            this.txtNhapLai.UseSystemPasswordChar = true;
            // 
            // frmAdminChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(391, 436);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.txtNhapLai);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtMKCu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdminChangePassword";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtMKMoi;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtMKCu;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtNhapLai;
    }
}