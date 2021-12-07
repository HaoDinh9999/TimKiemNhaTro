
namespace TimKiemNhaTro
{
    partial class frmNguoiDungChat
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
            this.btnGui = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtNoiDung = new Guna.UI2.WinForms.Guna2TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnGuiAnh = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnGui
            // 
            this.btnGui.BorderRadius = 4;
            this.btnGui.CheckedState.Parent = this.btnGui;
            this.btnGui.CustomImages.Parent = this.btnGui;
            this.btnGui.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGui.ForeColor = System.Drawing.Color.White;
            this.btnGui.HoverState.Parent = this.btnGui;
            this.btnGui.Location = new System.Drawing.Point(610, 666);
            this.btnGui.Name = "btnGui";
            this.btnGui.ShadowDecoration.Parent = this.btnGui;
            this.btnGui.Size = new System.Drawing.Size(93, 40);
            this.btnGui.TabIndex = 8;
            this.btnGui.Text = "Gửi";
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(748, 638);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.BorderRadius = 4;
            this.txtNoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoiDung.DefaultText = "";
            this.txtNoiDung.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNoiDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNoiDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoiDung.DisabledState.Parent = this.txtNoiDung;
            this.txtNoiDung.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoiDung.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoiDung.FocusedState.Parent = this.txtNoiDung;
            this.txtNoiDung.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoiDung.HoverState.Parent = this.txtNoiDung;
            this.txtNoiDung.Location = new System.Drawing.Point(12, 666);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.PasswordChar = '\0';
            this.txtNoiDung.PlaceholderText = "";
            this.txtNoiDung.SelectedText = "";
            this.txtNoiDung.ShadowDecoration.Parent = this.txtNoiDung;
            this.txtNoiDung.Size = new System.Drawing.Size(591, 40);
            this.txtNoiDung.TabIndex = 6;
            // 
            // btnGuiAnh
            // 
            this.btnGuiAnh.BorderRadius = 4;
            this.btnGuiAnh.CheckedState.Parent = this.btnGuiAnh;
            this.btnGuiAnh.CustomImages.Parent = this.btnGuiAnh;
            this.btnGuiAnh.FillColor = System.Drawing.Color.White;
            this.btnGuiAnh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuiAnh.ForeColor = System.Drawing.Color.White;
            this.btnGuiAnh.HoverState.Parent = this.btnGuiAnh;
            this.btnGuiAnh.Image = global::TimKiemNhaTro.Properties.Resources.image;
            this.btnGuiAnh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnGuiAnh.ImageSize = new System.Drawing.Size(32, 32);
            this.btnGuiAnh.Location = new System.Drawing.Point(709, 666);
            this.btnGuiAnh.Name = "btnGuiAnh";
            this.btnGuiAnh.ShadowDecoration.Parent = this.btnGuiAnh;
            this.btnGuiAnh.Size = new System.Drawing.Size(52, 40);
            this.btnGuiAnh.TabIndex = 9;
            this.btnGuiAnh.Click += new System.EventHandler(this.btnGuiAnh_Click);
            // 
            // frmNguoiDungChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(773, 718);
            this.Controls.Add(this.btnGuiAnh);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtNoiDung);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNguoiDungChat";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnGui;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txtNoiDung;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button btnGuiAnh;
    }
}