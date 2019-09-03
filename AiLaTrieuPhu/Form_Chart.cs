using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AiLaTrieuPhu
{
    public partial class Form_Chart : Form
    {
        double a;
        double b;
        double c;
        double d;

        public Form_Chart(double[] percents)
        {
            this.a = percents[0];
            this.b = percents[1];
            this.c = percents[2];
            this.d = percents[3];

            InitializeComponent();
        }

        private void Form_Chart_Load(object sender, EventArgs e)
        {

            plotAudience(a, b, c, d);
        }

        public void plotAudience(double a, double b, double c, double d)
        {
            // Set title.
            chart_Audience.Titles.Add("Ý kiến khán giả");

            
            chart_Audience.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;
            //chart_Audience.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;

            // Add series. (Store the data)
            chart_Audience.Series.Add("Options");
            //Console.WriteLine(chart_Audience.Series[0].IsVisibleInLegend);
            chart_Audience.Series[0].IsVisibleInLegend = false;

            //hide the grid lines:
            chart_Audience.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;//the same as chart_Audience.ChartAreas["ChartArea1"]...
            chart_Audience.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;


            chart_Audience.Series[0].Points.Add(a); // it is the same chart_Audience.Series["Options"].Points.Add(100);
            chart_Audience.Series[0].Points[0].Color = Color.Red;
            chart_Audience.Series[0].Points[0].LegendText = "Phương án A";
            chart_Audience.Series[0].Points[0].AxisLabel = "A";
            chart_Audience.Series[0].Points[0].Label = (100 * a + "%"); 

            chart_Audience.Series[0].Points.Add(b);
            chart_Audience.Series[0].Points[1].Color = Color.Purple;
            chart_Audience.Series[0].Points[1].LegendText = "Phương án B";
            chart_Audience.Series[0].Points[1].AxisLabel = "B";
            chart_Audience.Series[0].Points[1].Label = (100 * b + "%");

            chart_Audience.Series[0].Points.Add(c);
            chart_Audience.Series[0].Points[2].Color = Color.Blue;
            chart_Audience.Series[0].Points[2].LegendText = "Phương án C";
            chart_Audience.Series[0].Points[2].AxisLabel = "C";
            chart_Audience.Series[0].Points[2].Label = (100 * c + "%");

            chart_Audience.Series[0].Points.Add(d);
            chart_Audience.Series[0].Points[3].Color = Color.Green;
            chart_Audience.Series[0].Points[3].LegendText = "Phương án D";
            chart_Audience.Series[0].Points[3].AxisLabel = "D";
            chart_Audience.Series[0].Points[3].Label = (100 * d + "%"); 

        }
    }
}
