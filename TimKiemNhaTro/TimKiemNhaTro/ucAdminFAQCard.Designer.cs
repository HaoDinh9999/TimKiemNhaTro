
namespace TimKiemNhaTro
{
    partial class ucAdminFAQCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAdminFAQCard));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCauTraLoi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCauHoi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picDel = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDel)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.Controls.Add(this.picDel);
            this.guna2Panel1.Controls.Add(this.lblCauTraLoi);
            this.guna2Panel1.Controls.Add(this.lblCauHoi);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(917, 118);
            this.guna2Panel1.TabIndex = 1;
            // 
            // lblCauTraLoi
            // 
            this.lblCauTraLoi.AutoSize = false;
            this.lblCauTraLoi.BackColor = System.Drawing.Color.Transparent;
            this.lblCauTraLoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCauTraLoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCauTraLoi.Location = new System.Drawing.Point(37, 53);
            this.lblCauTraLoi.Name = "lblCauTraLoi";
            this.lblCauTraLoi.Size = new System.Drawing.Size(854, 53);
            this.lblCauTraLoi.TabIndex = 2;
            this.lblCauTraLoi.Text = resources.GetString("lblCauTraLoi.Text");
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.BackColor = System.Drawing.Color.Transparent;
            this.lblCauHoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCauHoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(162)))), ((int)(((byte)(180)))));
            this.lblCauHoi.Location = new System.Drawing.Point(37, 22);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(169, 25);
            this.lblCauHoi.TabIndex = 1;
            this.lblCauHoi.Text = "Ứng dụng này là gì ?";
            // 
            // picDel
            // 
            this.picDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDel.Image = global::TimKiemNhaTro.Properties.Resources.cancel;
            this.picDel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picDel.Location = new System.Drawing.Point(868, 22);
            this.picDel.Name = "picDel";
            this.picDel.Size = new System.Drawing.Size(23, 23);
            this.picDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDel.TabIndex = 8;
            this.picDel.TabStop = false;
            this.picDel.Click += new System.EventHandler(this.picDel_Click);
            // 
            // ucAdminFAQCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ucAdminFAQCard";
            this.Size = new System.Drawing.Size(917, 118);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox picDel;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCauTraLoi;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCauHoi;
    }
}
