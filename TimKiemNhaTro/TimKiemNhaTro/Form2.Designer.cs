
namespace TimKiemNhaTro
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCauHoi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCauTraLoi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picCollapse = new System.Windows.Forms.PictureBox();
            this.picExpand = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCollapse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExpand)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoSize = true;
            this.guna2Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.Controls.Add(this.picExpand);
            this.guna2Panel1.Controls.Add(this.picCollapse);
            this.guna2Panel1.Controls.Add(this.lblCauTraLoi);
            this.guna2Panel1.Controls.Add(this.lblCauHoi);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(55, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(16);
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(980, 110);
            this.guna2Panel1.TabIndex = 2;
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.BackColor = System.Drawing.Color.Transparent;
            this.lblCauHoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCauHoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(162)))), ((int)(((byte)(180)))));
            this.lblCauHoi.Location = new System.Drawing.Point(37, 19);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(169, 25);
            this.lblCauHoi.TabIndex = 1;
            this.lblCauHoi.Text = "Ứng dụng này là gì ?";
            // 
            // lblCauTraLoi
            // 
            this.lblCauTraLoi.AutoSize = false;
            this.lblCauTraLoi.BackColor = System.Drawing.Color.Transparent;
            this.lblCauTraLoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCauTraLoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCauTraLoi.Location = new System.Drawing.Point(37, 50);
            this.lblCauTraLoi.MaximumSize = new System.Drawing.Size(924, 0);
            this.lblCauTraLoi.MinimumSize = new System.Drawing.Size(0, 36);
            this.lblCauTraLoi.Name = "lblCauTraLoi";
            this.lblCauTraLoi.Size = new System.Drawing.Size(924, 41);
            this.lblCauTraLoi.TabIndex = 2;
            this.lblCauTraLoi.Text = resources.GetString("lblCauTraLoi.Text");
            // 
            // picCollapse
            // 
            this.picCollapse.BackColor = System.Drawing.Color.Transparent;
            this.picCollapse.Image = global::TimKiemNhaTro.Properties.Resources.icons8_upward_arrow_32;
            this.picCollapse.Location = new System.Drawing.Point(929, 12);
            this.picCollapse.Name = "picCollapse";
            this.picCollapse.Size = new System.Drawing.Size(32, 32);
            this.picCollapse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCollapse.TabIndex = 3;
            this.picCollapse.TabStop = false;
            // 
            // picExpand
            // 
            this.picExpand.BackColor = System.Drawing.Color.Transparent;
            this.picExpand.Image = global::TimKiemNhaTro.Properties.Resources.icons8_scroll_down_32;
            this.picExpand.Location = new System.Drawing.Point(929, 12);
            this.picExpand.Name = "picExpand";
            this.picExpand.Size = new System.Drawing.Size(32, 32);
            this.picExpand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExpand.TabIndex = 4;
            this.picExpand.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 676);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCollapse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExpand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCauTraLoi;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCauHoi;
        private System.Windows.Forms.PictureBox picExpand;
        private System.Windows.Forms.PictureBox picCollapse;
    }
}