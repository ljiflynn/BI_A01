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
            this.chartGrid = new System.Windows.Forms.DataGridView();
            this.columnTextBox = new System.Windows.Forms.TextBox();
            this.column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paleto_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrid)).BeginInit();
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
            // chartGrid
            // 
            this.chartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chartGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column,
            this.line});
            this.chartGrid.Location = new System.Drawing.Point(723, 63);
            this.chartGrid.Name = "chartGrid";
            this.chartGrid.Size = new System.Drawing.Size(243, 604);
            this.chartGrid.TabIndex = 1;
            // 
            // columnTextBox
            // 
            this.columnTextBox.Location = new System.Drawing.Point(1019, 237);
            this.columnTextBox.Name = "columnTextBox";
            this.columnTextBox.Size = new System.Drawing.Size(100, 20);
            this.columnTextBox.TabIndex = 2;
            // 
            // column
            // 
            this.column.HeaderText = "Column Values";
            this.column.Name = "column";
            // 
            // line
            // 
            this.line.HeaderText = "Line Values";
            this.line.Name = "line";
            // 
            // lineTextBox
            // 
            this.lineTextBox.Location = new System.Drawing.Point(1199, 237);
            this.lineTextBox.Name = "lineTextBox";
            this.lineTextBox.Size = new System.Drawing.Size(100, 20);
            this.lineTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1019, 313);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1016, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Column Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1196, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Line Value:";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(1199, 313);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // Paleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 756);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.lineTextBox);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn column;
        private System.Windows.Forms.DataGridViewTextBoxColumn line;
        private System.Windows.Forms.TextBox lineTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetButton;
    }
}

