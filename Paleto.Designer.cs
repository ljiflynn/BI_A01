namespace BI_A01
{
    partial class Paleto
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
            this.paleto_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.paleto_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // paleto_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.paleto_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.paleto_chart.Legends.Add(legend1);
            this.paleto_chart.Location = new System.Drawing.Point(49, 63);
            this.paleto_chart.Name = "paleto_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Default";
            this.paleto_chart.Series.Add(series1);
            this.paleto_chart.Size = new System.Drawing.Size(622, 604);
            this.paleto_chart.TabIndex = 0;
            this.paleto_chart.Text = "paleto_chart";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(723, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(633, 326);
            this.dataGridView1.TabIndex = 1;
            // 
            // Paleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 756);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.paleto_chart);
            this.Name = "Paleto";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Paleto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paleto_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart paleto_chart;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

