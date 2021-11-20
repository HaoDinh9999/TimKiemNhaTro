
namespace TimKiemNhaTro
{
    partial class ucNhaDaDang
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
            this.label1 = new System.Windows.Forms.Label();
            this.flwNhaDaDang = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách nhà đã đăng";
            // 
            // flwNhaDaDang
            // 
            this.flwNhaDaDang.AutoScroll = true;
            this.flwNhaDaDang.Location = new System.Drawing.Point(182, 113);
            this.flwNhaDaDang.Margin = new System.Windows.Forms.Padding(4);
            this.flwNhaDaDang.Name = "flwNhaDaDang";
            this.flwNhaDaDang.Size = new System.Drawing.Size(1252, 604);
            this.flwNhaDaDang.TabIndex = 5;
            // 
            // ucNhaDaDang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.flwNhaDaDang);
            this.Controls.Add(this.label1);
            this.Name = "ucNhaDaDang";
            this.Size = new System.Drawing.Size(1451, 2470);
            this.Load += new System.EventHandler(this.ucNhaDaDang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flwNhaDaDang;
    }
}
