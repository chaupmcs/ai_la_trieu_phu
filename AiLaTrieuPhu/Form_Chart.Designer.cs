namespace AiLaTrieuPhu
{
    partial class Form_Chart
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Chart));
            this.chart_Audience = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Audience)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_Audience
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Audience.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Audience.Legends.Add(legend1);
            this.chart_Audience.Location = new System.Drawing.Point(-17, -2);
            this.chart_Audience.Name = "chart_Audience";
            this.chart_Audience.Size = new System.Drawing.Size(317, 351);
            this.chart_Audience.TabIndex = 0;
            title1.Name = "TitleChart";
            this.chart_Audience.Titles.Add(title1);
            // 
            // Form_Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 342);
            this.Controls.Add(this.chart_Audience);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Chart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ý kiến khản giả";
            this.Load += new System.EventHandler(this.Form_Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Audience)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Audience;
    }
}