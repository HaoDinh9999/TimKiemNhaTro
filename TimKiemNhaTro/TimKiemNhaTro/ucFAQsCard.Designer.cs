
namespace TimKiemNhaTro
{
    partial class ucFAQsCard
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
            this.picCollapse = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picExpand = new System.Windows.Forms.PictureBox();
            this.lblCauHoi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCauTraLoi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCollapse)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExpand)).BeginInit();
            this.SuspendLayout();
            // 
            // picCollapse
            // 
            this.picCollapse.BackColor = System.Drawing.Color.Transparent;
            this.picCollapse.Image = global::TimKiemNhaTro.Properties.Resources.icons8_upward_arrow_32;
            this.picCollapse.Location = new System.Drawing.Point(918, 6);
            this.picCollapse.Name = "picCollapse";
            this.picCollapse.Size = new System.Drawing.Size(32, 32);
            this.picCollapse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCollapse.TabIndex = 7;
            this.picCollapse.TabStop = false;
            this.picCollapse.Click += new System.EventHandler(this.picCollapse_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.lblCauTraLoi);
            this.panel1.Controls.Add(this.lblCauHoi);
            this.panel1.Controls.Add(this.picExpand);
            this.panel1.Controls.Add(this.picCollapse);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(16);
            this.panel1.Size = new System.Drawing.Size(969, 104);
            this.panel1.TabIndex = 9;
            // 
            // picExpand
            // 
            this.picExpand.BackColor = System.Drawing.Color.Transparent;
            this.picExpand.Image = global::TimKiemNhaTro.Properties.Resources.icons8_scroll_down_32;
            this.picExpand.Location = new System.Drawing.Point(918, 6);
            this.picExpand.Name = "picExpand";
            this.picExpand.Size = new System.Drawing.Size(32, 32);
            this.picExpand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExpand.TabIndex = 11;
            this.picExpand.TabStop = false;
            this.picExpand.Click += new System.EventHandler(this.picExpand_Click);
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.BackColor = System.Drawing.Color.Transparent;
            this.lblCauHoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCauHoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(162)))), ((int)(((byte)(180)))));
            this.lblCauHoi.Location = new System.Drawing.Point(26, 13);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(169, 25);
            this.lblCauHoi.TabIndex = 12;
            this.lblCauHoi.Text = "Ứng dụng này là gì ?";
            // 
            // lblCauTraLoi
            // 
            this.lblCauTraLoi.AutoSize = true;
            this.lblCauTraLoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCauTraLoi.ForeColor = System.Drawing.Color.Gray;
            this.lblCauTraLoi.Location = new System.Drawing.Point(23, 48);
            this.lblCauTraLoi.MaximumSize = new System.Drawing.Size(920, 0);
            this.lblCauTraLoi.Name = "lblCauTraLoi";
            this.lblCauTraLoi.Size = new System.Drawing.Size(914, 40);
            this.lblCauTraLoi.TabIndex = 14;
            this.lblCauTraLoi.Text = "Công tbodia từng được biết là một trong những đối thủ nặng kí Đông Nam Á trong Mi" +
    "ss Grand 2021. Cô lọt top 10 chung cuộc khi chiến thắng giải Miss Popular Vote t" +
    "ại Miss Grand 2021.";
            this.lblCauTraLoi.Visible = false;
            // 
            // ucFAQsCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "ucFAQsCard";
            this.Size = new System.Drawing.Size(972, 107);
            ((System.ComponentModel.ISupportInitialize)(this.picCollapse)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExpand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picCollapse;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCauHoi;
        private System.Windows.Forms.PictureBox picExpand;
        private System.Windows.Forms.Label lblCauTraLoi;
    }
}
