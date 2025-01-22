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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.paleto_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartGrid = new System.Windows.Forms.DataGridView();
            this.columnTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paleto_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // paleto_chart
            // 
            chartArea2.Name = "ChartArea1";
            this.paleto_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.paleto_chart.Legends.Add(legend2);
            this.paleto_chart.Location = new System.Drawing.Point(12, 63);
            this.paleto_chart.Name = "paleto_chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Default";
            this.paleto_chart.Series.Add(series2);
            this.paleto_chart.Size = new System.Drawing.Size(622, 604);
            this.paleto_chart.TabIndex = 0;
            this.paleto_chart.Text = "paleto_chart";
            // 
            // chartGrid
            // 
            this.chartGrid.AllowUserToAddRows = false;
            this.chartGrid.AllowUserToDeleteRows = false;
            this.chartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chartGrid.Location = new System.Drawing.Point(670, 63);
            this.chartGrid.Name = "chartGrid";
            this.chartGrid.ReadOnly = true;
            this.chartGrid.RowHeadersWidth = 51;
            this.chartGrid.Size = new System.Drawing.Size(343, 604);
            this.chartGrid.TabIndex = 1;
            this.chartGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chartGrid_CellContentClick);
            // 
            // columnTextBox
            // 
            this.columnTextBox.Location = new System.Drawing.Point(1051, 290);
            this.columnTextBox.Name = "columnTextBox";
            this.columnTextBox.Size = new System.Drawing.Size(100, 20);
            this.columnTextBox.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1183, 290);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1048, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Column Value:";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(1279, 290);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Paleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 756);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.columnTextBox);
            this.Controls.Add(this.chartGrid);
            this.Controls.Add(this.paleto_chart);
            this.Name = "Paleto";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Paleto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paleto_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart paleto_chart;
        private System.Windows.Forms.DataGridView chartGrid;
        private System.Windows.Forms.TextBox columnTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resetButton;
    }
}

