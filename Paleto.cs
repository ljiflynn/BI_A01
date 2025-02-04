﻿using System;
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
        private List<ChartData> DataList = new List<ChartData>();
        private ChartData selectedData;
        private bool isStartup = true;
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
            chartGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Default_Data();
            chartGrid.DataSource = DataList;
        }

        /// <summary>
        /// Adds default data to the chart on startup or when the reset button is clicked
        /// </summary>
        private void Default_Data()
        {
            int dataPoint = 100;
            for(int i = 1; i <= DEFAULT_POINT_COUNT; i++)
            {
                paleto_chart.Series["Default"].Points.AddY(dataPoint);
                dataPoint = dataPoint + (dataPoint / i);
            }

            Make_Chart();
        }

        /// <summary>
        /// Handles the creation of the line portion of the chart
        /// </summary>
        private void Make_Chart()
        {
            paleto_chart.Titles.Add("Paleto");
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

            paleto_chart.ChartAreas[chartAreaStr].AxisY.Maximum = total / 4;
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

            Series temp = paleto_chart.Series["Default"];
            double columnVal;
            double lineVal;
            if(isStartup == true)
            {
                for (int i = 0; i < paleto_chart.Series["Default"].Points.Count; i++)
                {
                    columnVal = temp.Points[i].YValues[0];
                    lineVal = series.Points[i].YValues[0];
                    DataList.Add(new ChartData()
                    {
                        ID = i + 1,
                        ColumnValue = columnVal,
                        LineValue = lineVal
                    });
                }
                isStartup = false;
            }
            
        }

        /// <summary>
        /// An event handler where the textbox is updated with the selected row from the data grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chartGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedData = chartGrid.SelectedRows[0].DataBoundItem as ChartData;
            if (selectedData != null)
            {
                columnTextBox.Text = selectedData.ColumnValue.ToString();
            }
        }

        /// <summary>
        /// An event handler where the data grid is updated from user input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            if(columnTextBox.Text != "")
            {
                double colVal = Convert.ToDouble(columnTextBox.Text);
                int index = DataList.IndexOf(selectedData);

                selectedData.ColumnValue = colVal;

                DataList[index] = selectedData;

                paleto_chart.Series.RemoveAt(1);
                paleto_chart.Series.RemoveAt(0);
                paleto_chart.Titles.Clear();

                paleto_chart.Series.Add("Default");

                for (int i = 0; i < DataList.Count; i++)
                {
                    paleto_chart.Series["Default"].Points.AddY(Convert.ToInt32(DataList[i].ColumnValue));
                }

                Make_Chart();
            }
        }

        /// <summary>
        /// An event handler where the chart is reset and the default data is added back in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            paleto_chart.Series.RemoveAt(1);
            paleto_chart.Series.RemoveAt(0);
            paleto_chart.Titles.Clear();
            paleto_chart.Series.Add("Default");
            Default_Data();
        }
    }
}
