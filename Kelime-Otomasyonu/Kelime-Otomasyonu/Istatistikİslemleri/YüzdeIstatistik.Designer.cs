namespace Kelime_Otomasyonu.Istatistikİslemleri
{
    partial class YüzdeIstatistik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cYuzdelik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.cYuzdelik)).BeginInit();
            this.SuspendLayout();
            // 
            // cYuzdelik
            // 
            this.cYuzdelik.BackColor = System.Drawing.Color.PaleTurquoise;
            chartArea1.Name = "ChartArea1";
            this.cYuzdelik.ChartAreas.Add(chartArea1);
            this.cYuzdelik.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.cYuzdelik.Legends.Add(legend1);
            this.cYuzdelik.Location = new System.Drawing.Point(0, 0);
            this.cYuzdelik.Name = "cYuzdelik";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "sYuzdelik";
            this.cYuzdelik.Series.Add(series1);
            this.cYuzdelik.Size = new System.Drawing.Size(724, 482);
            this.cYuzdelik.TabIndex = 0;
            this.cYuzdelik.Text = "chart1";
            
            // 
            // YüzdeIstatistik
            // 
            this.Appearance.BackColor = System.Drawing.Color.Olive;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 482);
            this.Controls.Add(this.cYuzdelik);
            this.Name = "YüzdeIstatistik";
            this.Text = "YüzdeIstatistik";
            this.Load += new System.EventHandler(this.YüzdeIstatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cYuzdelik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cYuzdelik;
    }
}