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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpBeginTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.rdoPyramid = new System.Windows.Forms.RadioButton();
            this.rdoFunnel = new System.Windows.Forms.RadioButton();
            this.rdoDoughnut = new System.Windows.Forms.RadioButton();
            this.rdoColumn = new System.Windows.Forms.RadioButton();
            this.rdoBar = new System.Windows.Forms.RadioButton();
            this.rdoPie = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTotal = new System.Windows.Forms.TabPage();
            this.tabPageEveryDay = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEveryAnalysis = new System.Windows.Forms.Button();
            this.dtpEveryBeginTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEveryEndTime = new System.Windows.Forms.DateTimePicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cboEveryLabel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalysis)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxType.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageTotal.SuspendLayout();
            this.tabPageEveryDay.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartAnalysis
            // 
            chartArea5.Name = "ChartAreaPie";
            this.chartAnalysis.ChartAreas.Add(chartArea5);
            legend5.Name = "LegendPie";
            this.chartAnalysis.Legends.Add(legend5);
            this.chartAnalysis.Location = new System.Drawing.Point(6, 128);
            this.chartAnalysis.Name = "chartAnalysis";
            this.chartAnalysis.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series5.ChartArea = "ChartAreaPie";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.Legend = "LegendPie";
            series5.Name = "SeriesPie";
            series5.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            series5.YValuesPerPoint = 6;
            this.chartAnalysis.Series.Add(series5);
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
            this.tabPageEveryDay.Controls.Add(this.label5);
            this.tabPageEveryDay.Controls.Add(this.cboEveryLabel);
            this.tabPageEveryDay.Controls.Add(this.groupBox1);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Location = new System.Drawing.Point(478, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 66);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "显示类型";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(219, 28);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(76, 25);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "柱状图";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(122, 29);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(76, 25);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "条形图";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(22, 29);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(60, 25);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "饼图";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnEveryAnalysis);
            this.panel2.Controls.Add(this.dtpEveryBeginTime);
            this.panel2.Controls.Add(this.dtpEveryEndTime);
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
            // btnEveryAnalysis
            // 
            this.btnEveryAnalysis.Location = new System.Drawing.Point(332, 29);
            this.btnEveryAnalysis.Name = "btnEveryAnalysis";
            this.btnEveryAnalysis.Size = new System.Drawing.Size(58, 42);
            this.btnEveryAnalysis.TabIndex = 1;
            this.btnEveryAnalysis.Text = "分析";
            this.btnEveryAnalysis.UseVisualStyleBackColor = true;
            this.btnEveryAnalysis.Click += new System.EventHandler(this.btnEveryAnalysis_Click);
            // 
            // dtpEveryBeginTime
            // 
            this.dtpEveryBeginTime.Location = new System.Drawing.Point(107, 9);
            this.dtpEveryBeginTime.Name = "dtpEveryBeginTime";
            this.dtpEveryBeginTime.Size = new System.Drawing.Size(204, 29);
            this.dtpEveryBeginTime.TabIndex = 6;
            // 
            // dtpEveryEndTime
            // 
            this.dtpEveryEndTime.Location = new System.Drawing.Point(107, 57);
            this.dtpEveryEndTime.Name = "dtpEveryEndTime";
            this.dtpEveryEndTime.Size = new System.Drawing.Size(204, 29);
            this.dtpEveryEndTime.TabIndex = 5;
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(50, 172);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(740, 376);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // cboEveryLabel
            // 
            this.cboEveryLabel.FormattingEnabled = true;
            this.cboEveryLabel.Location = new System.Drawing.Point(538, 27);
            this.cboEveryLabel.Name = "cboEveryLabel";
            this.cboEveryLabel.Size = new System.Drawing.Size(121, 29);
            this.cboEveryLabel.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "标签：";
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
            this.tabPageEveryDay.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.Button btnEveryAnalysis;
        private System.Windows.Forms.DateTimePicker dtpEveryBeginTime;
        private System.Windows.Forms.DateTimePicker dtpEveryEndTime;
        private System.Windows.Forms.RadioButton rdoDoughnut;
        private System.Windows.Forms.RadioButton rdoPyramid;
        private System.Windows.Forms.RadioButton rdoFunnel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboEveryLabel;
    }
}