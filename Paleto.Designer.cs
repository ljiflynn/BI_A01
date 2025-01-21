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
            this.lineTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
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
            this.paleto_chart.Location = new System.Drawing.Point(16, 78);
            this.paleto_chart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paleto_chart.Name = "paleto_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Default";
            this.paleto_chart.Series.Add(series1);
            this.paleto_chart.Size = new System.Drawing.Size(829, 743);
            this.paleto_chart.TabIndex = 0;
            this.paleto_chart.Text = "paleto_chart";
            // 
            // chartGrid
            // 
            this.chartGrid.AllowUserToAddRows = false;
            this.chartGrid.AllowUserToDeleteRows = false;
            this.chartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chartGrid.Location = new System.Drawing.Point(893, 78);
            this.chartGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartGrid.Name = "chartGrid";
            this.chartGrid.ReadOnly = true;
            this.chartGrid.RowHeadersWidth = 51;
            this.chartGrid.Size = new System.Drawing.Size(457, 743);
            this.chartGrid.TabIndex = 1;
            this.chartGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chartGrid_CellContentClick);
            // 
            // columnTextBox
            // 
            this.columnTextBox.Location = new System.Drawing.Point(1412, 292);
            this.columnTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.columnTextBox.Name = "columnTextBox";
            this.columnTextBox.Size = new System.Drawing.Size(132, 22);
            this.columnTextBox.TabIndex = 2;
            // 
            // lineTextBox
            // 
            this.lineTextBox.Location = new System.Drawing.Point(1652, 292);
            this.lineTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lineTextBox.Name = "lineTextBox";
            this.lineTextBox.Size = new System.Drawing.Size(132, 22);
            this.lineTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1412, 370);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 28);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1408, 268);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Column Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1648, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Line Value:";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(1652, 370);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(100, 28);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1412, 453);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 28);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add Datapoint";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(1652, 453);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(145, 28);
            this.removeButton.TabIndex = 9;
            this.removeButton.Text = "Remove Datapoint";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // Paleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1852, 930);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.lineTextBox);
            this.Controls.Add(this.columnTextBox);
            this.Controls.Add(this.chartGrid);
            this.Controls.Add(this.paleto_chart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox lineTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
    }
}

