
namespace TimKiemNhaTro
{
    partial class ucAdminStatistic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cboQuan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboNam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnXem = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(40, 18);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.LegendText = "Số lượng nhà";
            series7.Name = "Series1";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.LegendText = "Số lượng phòng";
            series8.Name = "Series2";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.LegendText = "Số lượng căn hộ";
            series9.Name = "Series3";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(857, 332);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(40, 368);
            this.chart2.Name = "chart2";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.LegendText = "Số lượng nhà";
            series10.Name = "Series1";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.LegendText = "Số lượng phòng";
            series11.Name = "Series2";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.LegendText = "Số lượng căn hộ";
            series12.Name = "Series3";
            this.chart2.Series.Add(series10);
            this.chart2.Series.Add(series11);
            this.chart2.Series.Add(series12);
            this.chart2.Size = new System.Drawing.Size(857, 335);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // cboQuan
            // 
            this.cboQuan.BackColor = System.Drawing.Color.Transparent;
            this.cboQuan.BorderRadius = 4;
            this.cboQuan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboQuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuan.FocusedColor = System.Drawing.Color.Empty;
            this.cboQuan.FocusedState.Parent = this.cboQuan;
            this.cboQuan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboQuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboQuan.FormattingEnabled = true;
            this.cboQuan.HoverState.Parent = this.cboQuan;
            this.cboQuan.ItemHeight = 30;
            this.cboQuan.ItemsAppearance.Parent = this.cboQuan;
            this.cboQuan.Location = new System.Drawing.Point(912, 18);
            this.cboQuan.Name = "cboQuan";
            this.cboQuan.ShadowDecoration.Parent = this.cboQuan;
            this.cboQuan.Size = new System.Drawing.Size(156, 36);
            this.cboQuan.TabIndex = 2;
            // 
            // cboNam
            // 
            this.cboNam.BackColor = System.Drawing.Color.Transparent;
            this.cboNam.BorderRadius = 4;
            this.cboNam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNam.FocusedColor = System.Drawing.Color.Empty;
            this.cboNam.FocusedState.Parent = this.cboNam;
            this.cboNam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboNam.FormattingEnabled = true;
            this.cboNam.HoverState.Parent = this.cboNam;
            this.cboNam.ItemHeight = 30;
            this.cboNam.Items.AddRange(new object[] {
            "2020",
            "2021"});
            this.cboNam.ItemsAppearance.Parent = this.cboNam;
            this.cboNam.Location = new System.Drawing.Point(912, 59);
            this.cboNam.Name = "cboNam";
            this.cboNam.ShadowDecoration.Parent = this.cboNam;
            this.cboNam.Size = new System.Drawing.Size(156, 36);
            this.cboNam.TabIndex = 3;
            // 
            // btnXem
            // 
            this.btnXem.BorderRadius = 4;
            this.btnXem.CheckedState.Parent = this.btnXem;
            this.btnXem.CustomImages.Parent = this.btnXem;
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.HoverState.Parent = this.btnXem;
            this.btnXem.Location = new System.Drawing.Point(912, 102);
            this.btnXem.Name = "btnXem";
            this.btnXem.ShadowDecoration.Parent = this.btnXem;
            this.btnXem.Size = new System.Drawing.Size(156, 36);
            this.btnXem.TabIndex = 4;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // ucAdminStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cboNam);
            this.Controls.Add(this.cboQuan);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Name = "ucAdminStatistic";
            this.Size = new System.Drawing.Size(1084, 721);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Guna.UI2.WinForms.Guna2ComboBox cboQuan;
        private Guna.UI2.WinForms.Guna2ComboBox cboNam;
        private Guna.UI2.WinForms.Guna2Button btnXem;
    }
}
