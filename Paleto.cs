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

namespace BI_A01
{
    public partial class Paleto : Form
    {
        private const int DEFAULT_POINT_COUNT = 10;
        public Paleto()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads data into the pareto chart and data grid on startup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Paleto_Load(object sender, EventArgs e)
        {
            int dataPoint = 100;
            for (int i = 1; i <= DEFAULT_POINT_COUNT; i++)
            {
                dataPoint = dataPoint + (dataPoint / i);
                paleto_chart.Series["Default"].Points.AddY(dataPoint);
            }


            Update_Data();
        }

        private void Update_Data()
        {
            string chartAreaStr = paleto_chart.Series["Default"].ChartArea;
            double total = 0.0;
            double totalPercentage = 0.0;
            Series series = new Series("Paleto");

            paleto_chart.Series["Default"].ChartType = SeriesChartType.Column;
            paleto_chart.DataManipulator.Sort(PointSortOrder.Descending, "Default");

            
            foreach (DataPoint pt in paleto_chart.Series["Default"].Points)
            {
                total += pt.YValues[0];
            }
            
            paleto_chart.ChartAreas[chartAreaStr].AxisY.Maximum = total;
            paleto_chart.Series.Add(series);

            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 4;
            series.ChartArea = paleto_chart.Series["Default"].ChartArea;
            series.YAxisType = AxisType.Secondary;

            paleto_chart.ChartAreas[chartAreaStr].AxisY2.Maximum = 1;
            paleto_chart.ChartAreas[chartAreaStr].AxisY2.LabelStyle.Format = "P0";
            paleto_chart.ChartAreas[chartAreaStr].AxisX.LabelStyle.IsEndLabelVisible = false;

            foreach (DataPoint pt in paleto_chart.Series["Default"].Points)
            {
                totalPercentage += (pt.YValues[0] / total);
                series.Points.Add(Math.Round(totalPercentage, 2));
            }
        }
    }
}
