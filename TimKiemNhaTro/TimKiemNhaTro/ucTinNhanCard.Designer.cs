
namespace TimKiemNhaTro
{
    partial class ucTinNhanCard
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
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.lblBan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picAvt = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.picAnhGui = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhGui)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.BackColor = System.Drawing.Color.White;
            this.lblNoiDung.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoiDung.ForeColor = System.Drawing.Color.Gray;
            this.lblNoiDung.Location = new System.Drawing.Point(46, 0);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Padding = new System.Windows.Forms.Padding(8);
            this.lblNoiDung.Size = new System.Drawing.Size(42, 35);
            this.lblNoiDung.TabIndex = 17;
            this.lblNoiDung.Text = "vãi";
            // 
            // lblBan
            // 
            this.lblBan.BackColor = System.Drawing.Color.Transparent;
            this.lblBan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBan.ForeColor = System.Drawing.Color.Black;
            this.lblBan.Location = new System.Drawing.Point(3, 1);
            this.lblBan.Name = "lblBan";
            this.lblBan.Size = new System.Drawing.Size(36, 25);
            this.lblBan.TabIndex = 19;
            this.lblBan.Text = "Bạn:";
            // 
            // picAvt
            // 
            this.picAvt.Location = new System.Drawing.Point(0, 0);
            this.picAvt.Name = "picAvt";
            this.picAvt.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picAvt.ShadowDecoration.Parent = this.picAvt;
            this.picAvt.Size = new System.Drawing.Size(40, 40);
            this.picAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvt.TabIndex = 18;
            this.picAvt.TabStop = false;
            // 
            // picAnhGui
            // 
            this.picAnhGui.Location = new System.Drawing.Point(46, 0);
            this.picAnhGui.Name = "picAnhGui";
            this.picAnhGui.ShadowDecoration.Parent = this.picAnhGui;
            this.picAnhGui.Size = new System.Drawing.Size(169, 168);
            this.picAnhGui.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnhGui.TabIndex = 20;
            this.picAnhGui.TabStop = false;
            this.picAnhGui.Visible = false;
            // 
            // ucTinNhanCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.picAnhGui);
            this.Controls.Add(this.lblBan);
            this.Controls.Add(this.picAvt);
            this.Controls.Add(this.lblNoiDung);
            this.MinimumSize = new System.Drawing.Size(0, 43);
            this.Name = "ucTinNhanCard";
            this.Size = new System.Drawing.Size(218, 171);
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhGui)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoiDung;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picAvt;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBan;
        private Guna.UI2.WinForms.Guna2PictureBox picAnhGui;
    }
}
