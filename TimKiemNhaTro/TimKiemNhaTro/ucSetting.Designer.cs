
namespace TimKiemNhaTro
{
    partial class ucSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSetting));
            this.label1 = new System.Windows.Forms.Label();
            this.rdbEnglish = new Guna.UI.WinForms.GunaRadioButton();
            this.rdbVietNam = new Guna.UI.WinForms.GunaRadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // rdbEnglish
            // 
            resources.ApplyResources(this.rdbEnglish, "rdbEnglish");
            this.rdbEnglish.BaseColor = System.Drawing.SystemColors.Control;
            this.rdbEnglish.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdbEnglish.CheckedOnColor = System.Drawing.Color.Lime;
            this.rdbEnglish.FillColor = System.Drawing.Color.White;
            this.rdbEnglish.Name = "rdbEnglish";
            this.rdbEnglish.CheckedChanged += new System.EventHandler(this.rdbEnglish_CheckedChanged);
            // 
            // rdbVietNam
            // 
            resources.ApplyResources(this.rdbVietNam, "rdbVietNam");
            this.rdbVietNam.BaseColor = System.Drawing.SystemColors.Control;
            this.rdbVietNam.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdbVietNam.CheckedOnColor = System.Drawing.Color.Lime;
            this.rdbVietNam.FillColor = System.Drawing.Color.White;
            this.rdbVietNam.Name = "rdbVietNam";
            this.rdbVietNam.CheckedChanged += new System.EventHandler(this.rdbVietNam_CheckedChanged);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::TimKiemNhaTro.Properties.Resources._775_7750441_apartment_png;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // ucSetting
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbEnglish);
            this.Controls.Add(this.rdbVietNam);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ucSetting";
            this.Load += new System.EventHandler(this.ucSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaRadioButton rdbEnglish;
        private Guna.UI.WinForms.GunaRadioButton rdbVietNam;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
