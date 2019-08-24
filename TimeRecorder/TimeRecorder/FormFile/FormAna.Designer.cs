namespace TimeRecorder
{
    partial class FormAna
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
            this.chartAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mcAnalysis = new System.Windows.Forms.MonthCalendar();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpBeginTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // chartAnalysis
            // 
            chartArea1.Name = "ChartAreaPie";
            this.chartAnalysis.ChartAreas.Add(chartArea1);
            legend1.Name = "LegendPie";
            this.chartAnalysis.Legends.Add(legend1);
            this.chartAnalysis.Location = new System.Drawing.Point(34, 265);
            this.chartAnalysis.Name = "chartAnalysis";
            this.chartAnalysis.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartAreaPie";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "LegendPie";
            series1.Name = "SeriesPie";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            series1.YValuesPerPoint = 2;
            this.chartAnalysis.Series.Add(series1);
            this.chartAnalysis.Size = new System.Drawing.Size(429, 324);
            this.chartAnalysis.TabIndex = 0;
            this.chartAnalysis.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "开始时间 : ";
            // 
            // mcAnalysis
            // 
            this.mcAnalysis.Location = new System.Drawing.Point(34, 20);
            this.mcAnalysis.Name = "mcAnalysis";
            this.mcAnalysis.TabIndex = 4;
            this.mcAnalysis.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcAnalysis_DateSelected);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Location = new System.Drawing.Point(369, 76);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(204, 29);
            this.dtpEndTime.TabIndex = 5;
            // 
            // dtpBeginTime
            // 
            this.dtpBeginTime.Location = new System.Drawing.Point(369, 22);
            this.dtpBeginTime.Name = "dtpBeginTime";
            this.dtpBeginTime.Size = new System.Drawing.Size(204, 29);
            this.dtpBeginTime.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "结束时间 :";
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 623);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpBeginTime);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.mcAnalysis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chartAnalysis);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormAna";
            this.Text = "分析区";
            this.Load += new System.EventHandler(this.FormAna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalysis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartAnalysis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mcAnalysis;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.DateTimePicker dtpBeginTime;
        private System.Windows.Forms.Label label2;
    }
}