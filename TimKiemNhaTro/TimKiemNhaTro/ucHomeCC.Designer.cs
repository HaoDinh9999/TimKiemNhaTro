
namespace TimKiemNhaTro
{
    partial class ucHomeCC
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
            this.flwCapNhatGanNhat = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "ucHome cc";
            // 
            // flwCapNhatGanNhat
            // 
            this.flwCapNhatGanNhat.Location = new System.Drawing.Point(90, 167);
            this.flwCapNhatGanNhat.Name = "flwCapNhatGanNhat";
            this.flwCapNhatGanNhat.Size = new System.Drawing.Size(1297, 434);
            this.flwCapNhatGanNhat.TabIndex = 3;
            // 
            // ucHomeCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flwCapNhatGanNhat);
            this.Controls.Add(this.label1);
            this.Name = "ucHomeCC";
            this.Size = new System.Drawing.Size(1493, 790);
            this.Load += new System.EventHandler(this.ucHomeCC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flwCapNhatGanNhat;
    }
}
