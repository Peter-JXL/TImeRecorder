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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpBeginTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.rdoColumn = new System.Windows.Forms.RadioButton();
            this.rdoBar = new System.Windows.Forms.RadioButton();
            this.rdoPie = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTotal = new System.Windows.Forms.TabPage();
            this.tabPageEveryDay = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.rdoDoughnut = new System.Windows.Forms.RadioButton();
            this.rdoFunnel = new System.Windows.Forms.RadioButton();
            this.rdoPyramid = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalysis)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxType.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageTotal.SuspendLayout();
            this.tabPageEveryDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartAnalysis
            // 
            chartArea1.Name = "ChartAreaPie";
            this.chartAnalysis.ChartAreas.Add(chartArea1);
            legend1.Name = "LegendPie";
            this.chartAnalysis.Legends.Add(legend1);
            this.chartAnalysis.Location = new System.Drawing.Point(6, 128);
            this.chartAnalysis.Name = "chartAnalysis";
            this.chartAnalysis.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartAreaPie";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "LegendPie";
            series1.Name = "SeriesPie";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            series1.YValuesPerPoint = 6;
            this.chartAnalysis.Series.Add(series1);
            this.chartAnalysis.Size = new System.Drawing.Size(828, 434);
            this.chartAnalysis.TabIndex = 0;
            this.chartAnalysis.Text = "chart1";
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Location = new System.Drawing.Point(332, 29);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(58, 42);
            this.btnAnalysis.TabIndex = 1;
            this.btnAnalysis.Text = "分析";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "开始时间 : ";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Location = new System.Drawing.Point(107, 57);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(204, 29);
            this.dtpEndTime.TabIndex = 5;
            // 
            // dtpBeginTime
            // 
            this.dtpBeginTime.Location = new System.Drawing.Point(107, 9);
            this.dtpBeginTime.Name = "dtpBeginTime";
            this.dtpBeginTime.Size = new System.Drawing.Size(204, 29);
            this.dtpBeginTime.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "结束时间 :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAnalysis);
            this.panel1.Controls.Add(this.dtpBeginTime);
            this.panel1.Controls.Add(this.dtpEndTime);
            this.panel1.Location = new System.Drawing.Point(26, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 109);
            this.panel1.TabIndex = 8;
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.rdoPyramid);
            this.groupBoxType.Controls.Add(this.rdoFunnel);
            this.groupBoxType.Controls.Add(this.rdoDoughnut);
            this.groupBoxType.Controls.Add(this.rdoColumn);
            this.groupBoxType.Controls.Add(this.rdoBar);
            this.groupBoxType.Controls.Add(this.rdoPie);
            this.groupBoxType.Location = new System.Drawing.Point(460, 13);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(345, 109);
            this.groupBoxType.TabIndex = 9;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "显示类型";
            // 
            // rdoColumn
            // 
            this.rdoColumn.AutoSize = true;
            this.rdoColumn.Location = new System.Drawing.Point(219, 28);
            this.rdoColumn.Name = "rdoColumn";
            this.rdoColumn.Size = new System.Drawing.Size(76, 25);
            this.rdoColumn.TabIndex = 2;
            this.rdoColumn.TabStop = true;
            this.rdoColumn.Text = "柱状图";
            this.rdoColumn.UseVisualStyleBackColor = true;
            this.rdoColumn.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdoBar
            // 
            this.rdoBar.AutoSize = true;
            this.rdoBar.Location = new System.Drawing.Point(122, 29);
            this.rdoBar.Name = "rdoBar";
            this.rdoBar.Size = new System.Drawing.Size(76, 25);
            this.rdoBar.TabIndex = 1;
            this.rdoBar.TabStop = true;
            this.rdoBar.Text = "条形图";
            this.rdoBar.UseVisualStyleBackColor = true;
            this.rdoBar.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdoPie
            // 
            this.rdoPie.AutoSize = true;
            this.rdoPie.Location = new System.Drawing.Point(22, 29);
            this.rdoPie.Name = "rdoPie";
            this.rdoPie.Size = new System.Drawing.Size(60, 25);
            this.rdoPie.TabIndex = 0;
            this.rdoPie.TabStop = true;
            this.rdoPie.Text = "饼图";
            this.rdoPie.UseVisualStyleBackColor = true;
            this.rdoPie.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageTotal);
            this.tabControl1.Controls.Add(this.tabPageEveryDay);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(848, 599);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPageTotal
            // 
            this.tabPageTotal.Controls.Add(this.chartAnalysis);
            this.tabPageTotal.Controls.Add(this.groupBoxType);
            this.tabPageTotal.Controls.Add(this.panel1);
            this.tabPageTotal.Location = new System.Drawing.Point(4, 30);
            this.tabPageTotal.Name = "tabPageTotal";
            this.tabPageTotal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTotal.Size = new System.Drawing.Size(840, 565);
            this.tabPageTotal.TabIndex = 0;
            this.tabPageTotal.Text = "数据汇总";
            this.tabPageTotal.UseVisualStyleBackColor = true;
            // 
            // tabPageEveryDay
            // 
            this.tabPageEveryDay.Controls.Add(this.panel2);
            this.tabPageEveryDay.Controls.Add(this.chart1);
            this.tabPageEveryDay.Location = new System.Drawing.Point(4, 30);
            this.tabPageEveryDay.Name = "tabPageEveryDay";
            this.tabPageEveryDay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEveryDay.Size = new System.Drawing.Size(840, 565);
            this.tabPageEveryDay.TabIndex = 1;
            this.tabPageEveryDay.Text = "每日分布";
            this.tabPageEveryDay.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(50, 172);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(740, 376);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Location = new System.Drawing.Point(50, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 109);
            this.panel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "开始时间 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "结束时间 :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "分析";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 29);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(107, 57);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(204, 29);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // rdoDoughnut
            // 
            this.rdoDoughnut.AutoSize = true;
            this.rdoDoughnut.Location = new System.Drawing.Point(22, 63);
            this.rdoDoughnut.Name = "rdoDoughnut";
            this.rdoDoughnut.Size = new System.Drawing.Size(76, 25);
            this.rdoDoughnut.TabIndex = 3;
            this.rdoDoughnut.TabStop = true;
            this.rdoDoughnut.Text = "圆环图";
            this.rdoDoughnut.UseVisualStyleBackColor = true;
            this.rdoDoughnut.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdoFunnel
            // 
            this.rdoFunnel.AutoSize = true;
            this.rdoFunnel.Location = new System.Drawing.Point(122, 63);
            this.rdoFunnel.Name = "rdoFunnel";
            this.rdoFunnel.Size = new System.Drawing.Size(76, 25);
            this.rdoFunnel.TabIndex = 4;
            this.rdoFunnel.TabStop = true;
            this.rdoFunnel.Text = "漏斗图";
            this.rdoFunnel.UseVisualStyleBackColor = true;
            this.rdoFunnel.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdoPyramid
            // 
            this.rdoPyramid.AutoSize = true;
            this.rdoPyramid.Location = new System.Drawing.Point(219, 63);
            this.rdoPyramid.Name = "rdoPyramid";
            this.rdoPyramid.Size = new System.Drawing.Size(76, 25);
            this.rdoPyramid.TabIndex = 5;
            this.rdoPyramid.TabStop = true;
            this.rdoPyramid.Text = "棱锥图";
            this.rdoPyramid.UseVisualStyleBackColor = true;
            this.rdoPyramid.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 623);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormAna";
            this.Text = "分析区";
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalysis)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageTotal.ResumeLayout(false);
            this.tabPageEveryDay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartAnalysis;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.DateTimePicker dtpBeginTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.RadioButton rdoPie;
        private System.Windows.Forms.RadioButton rdoColumn;
        private System.Windows.Forms.RadioButton rdoBar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTotal;
        private System.Windows.Forms.TabPage tabPageEveryDay;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.RadioButton rdoDoughnut;
        private System.Windows.Forms.RadioButton rdoPyramid;
        private System.Windows.Forms.RadioButton rdoFunnel;
    }
}