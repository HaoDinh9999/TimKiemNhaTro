
namespace TimKiemNhaTro
{
    partial class frmAddFAQ
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
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblhihi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTraLoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCauHoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 4;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.DarkKhaki;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Location = new System.Drawing.Point(45, 285);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(291, 41);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(45, 121);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(74, 22);
            this.guna2HtmlLabel1.TabIndex = 22;
            this.guna2HtmlLabel1.Text = "Câu trả lời";
            // 
            // lblhihi
            // 
            this.lblhihi.BackColor = System.Drawing.Color.Transparent;
            this.lblhihi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.lblhihi.Location = new System.Drawing.Point(45, 26);
            this.lblhihi.Name = "lblhihi";
            this.lblhihi.Size = new System.Drawing.Size(55, 22);
            this.lblhihi.TabIndex = 23;
            this.lblhihi.Text = "Câu hỏi";
            // 
            // txtTraLoi
            // 
            this.txtTraLoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTraLoi.DefaultText = "";
            this.txtTraLoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTraLoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTraLoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTraLoi.DisabledState.Parent = this.txtTraLoi;
            this.txtTraLoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTraLoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTraLoi.FocusedState.Parent = this.txtTraLoi;
            this.txtTraLoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTraLoi.HoverState.Parent = this.txtTraLoi;
            this.txtTraLoi.Location = new System.Drawing.Point(45, 150);
            this.txtTraLoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTraLoi.Multiline = true;
            this.txtTraLoi.Name = "txtTraLoi";
            this.txtTraLoi.PasswordChar = '\0';
            this.txtTraLoi.PlaceholderText = "";
            this.txtTraLoi.SelectedText = "";
            this.txtTraLoi.ShadowDecoration.Parent = this.txtTraLoi;
            this.txtTraLoi.Size = new System.Drawing.Size(291, 109);
            this.txtTraLoi.TabIndex = 17;
            // 
            // txtCauHoi
            // 
            this.txtCauHoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCauHoi.DefaultText = "";
            this.txtCauHoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCauHoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCauHoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCauHoi.DisabledState.Parent = this.txtCauHoi;
            this.txtCauHoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCauHoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCauHoi.FocusedState.Parent = this.txtCauHoi;
            this.txtCauHoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCauHoi.HoverState.Parent = this.txtCauHoi;
            this.txtCauHoi.Location = new System.Drawing.Point(45, 55);
            this.txtCauHoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCauHoi.Name = "txtCauHoi";
            this.txtCauHoi.PasswordChar = '\0';
            this.txtCauHoi.PlaceholderText = "";
            this.txtCauHoi.SelectedText = "";
            this.txtCauHoi.ShadowDecoration.Parent = this.txtCauHoi;
            this.txtCauHoi.Size = new System.Drawing.Size(291, 42);
            this.txtCauHoi.TabIndex = 16;
            // 
            // frmAddFAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(383, 355);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.lblhihi);
            this.Controls.Add(this.txtTraLoi);
            this.Controls.Add(this.txtCauHoi);
            this.Name = "frmAddFAQ";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblhihi;
        private Guna.UI2.WinForms.Guna2TextBox txtTraLoi;
        private Guna.UI2.WinForms.Guna2TextBox txtCauHoi;
    }
}