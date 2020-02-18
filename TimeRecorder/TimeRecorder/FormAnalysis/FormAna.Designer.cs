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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAna));
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
            this.tabControlAnalysis = new System.Windows.Forms.TabControl();
            this.tabPageTotal = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExportToJPG = new System.Windows.Forms.Button();
            this.checkBoxShow3D = new System.Windows.Forms.CheckBox();
            this.checkBoxShowLegend = new System.Windows.Forms.CheckBox();
            this.tabPageEveryDay = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.cboEveryLabel = new System.Windows.Forms.ComboBox();
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
            this.tabPageShowSourceData = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpShowSecondTIme = new System.Windows.Forms.DateTimePicker();
            this.dtpShowBeginTIme = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnIOExcelLabel = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtShowNote = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboShowSecondLabel = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboShowFirstLabel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalysis)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxType.SuspendLayout();
            this.tabControlAnalysis.SuspendLayout();
            this.tabPageTotal.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPageEveryDay.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPageShowSourceData.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.groupBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartAnalysis
            // 
            chartArea1.Name = "ChartAreaPie";
            this.chartAnalysis.ChartAreas.Add(chartArea1);
            legend1.Name = "LegendPie";
            this.chartAnalysis.Legends.Add(legend1);
            this.chartAnalysis.Location = new System.Drawing.Point(26, 194);
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
            this.chartAnalysis.Size = new System.Drawing.Size(640, 521);
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
            this.groupBoxType.Location = new System.Drawing.Point(464, 13);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(333, 109);
            this.groupBoxType.TabIndex = 9;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "显示类型";
            // 
            // rdoPyramid
            // 
            this.rdoPyramid.AutoSize = true;
            this.rdoPyramid.Location = new System.Drawing.Point(219, 76);
            this.rdoPyramid.Name = "rdoPyramid";
            this.rdoPyramid.Size = new System.Drawing.Size(76, 25);
            this.rdoPyramid.TabIndex = 5;
            this.rdoPyramid.TabStop = true;
            this.rdoPyramid.Text = "棱锥图";
            this.rdoPyramid.UseVisualStyleBackColor = true;
            this.rdoPyramid.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // rdoFunnel
            // 
            this.rdoFunnel.AutoSize = true;
            this.rdoFunnel.Location = new System.Drawing.Point(122, 76);
            this.rdoFunnel.Name = "rdoFunnel";
            this.rdoFunnel.Size = new System.Drawing.Size(76, 25);
            this.rdoFunnel.TabIndex = 4;
            this.rdoFunnel.TabStop = true;
            this.rdoFunnel.Text = "漏斗图";
            this.rdoFunnel.UseVisualStyleBackColor = true;
            this.rdoFunnel.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // rdoDoughnut
            // 
            this.rdoDoughnut.AutoSize = true;
            this.rdoDoughnut.Location = new System.Drawing.Point(22, 76);
            this.rdoDoughnut.Name = "rdoDoughnut";
            this.rdoDoughnut.Size = new System.Drawing.Size(76, 25);
            this.rdoDoughnut.TabIndex = 3;
            this.rdoDoughnut.TabStop = true;
            this.rdoDoughnut.Text = "圆环图";
            this.rdoDoughnut.UseVisualStyleBackColor = true;
            this.rdoDoughnut.Click += new System.EventHandler(this.radioButton_Click);
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
            this.rdoColumn.Click += new System.EventHandler(this.radioButton_Click);
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
            this.rdoBar.Click += new System.EventHandler(this.radioButton_Click);
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
            this.rdoPie.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // tabControlAnalysis
            // 
            this.tabControlAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlAnalysis.Controls.Add(this.tabPageTotal);
            this.tabControlAnalysis.Controls.Add(this.tabPageEveryDay);
            this.tabControlAnalysis.Controls.Add(this.tabPageShowSourceData);
            this.tabControlAnalysis.Location = new System.Drawing.Point(12, 12);
            this.tabControlAnalysis.Name = "tabControlAnalysis";
            this.tabControlAnalysis.SelectedIndex = 0;
            this.tabControlAnalysis.Size = new System.Drawing.Size(1220, 824);
            this.tabControlAnalysis.TabIndex = 10;
            // 
            // tabPageTotal
            // 
            this.tabPageTotal.Controls.Add(this.groupBox3);
            this.tabPageTotal.Controls.Add(this.groupBoxType);
            this.tabPageTotal.Controls.Add(this.chartAnalysis);
            this.tabPageTotal.Controls.Add(this.panel1);
            this.tabPageTotal.Location = new System.Drawing.Point(4, 30);
            this.tabPageTotal.Name = "tabPageTotal";
            this.tabPageTotal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTotal.Size = new System.Drawing.Size(1212, 790);
            this.tabPageTotal.TabIndex = 0;
            this.tabPageTotal.Text = "数据汇总";
            this.tabPageTotal.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExportToJPG);
            this.groupBox3.Controls.Add(this.checkBoxShow3D);
            this.groupBox3.Controls.Add(this.checkBoxShowLegend);
            this.groupBox3.Location = new System.Drawing.Point(851, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 352);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "图表设置";
            // 
            // btnExportToJPG
            // 
            this.btnExportToJPG.Location = new System.Drawing.Point(22, 278);
            this.btnExportToJPG.Name = "btnExportToJPG";
            this.btnExportToJPG.Size = new System.Drawing.Size(140, 35);
            this.btnExportToJPG.TabIndex = 8;
            this.btnExportToJPG.Text = "导出为JPG图片";
            this.btnExportToJPG.UseVisualStyleBackColor = true;
            this.btnExportToJPG.Click += new System.EventHandler(this.btnExportToJPG_Click);
            // 
            // checkBoxShow3D
            // 
            this.checkBoxShow3D.AutoSize = true;
            this.checkBoxShow3D.Location = new System.Drawing.Point(138, 54);
            this.checkBoxShow3D.Name = "checkBoxShow3D";
            this.checkBoxShow3D.Size = new System.Drawing.Size(82, 25);
            this.checkBoxShow3D.TabIndex = 1;
            this.checkBoxShow3D.Text = "3D显示";
            this.checkBoxShow3D.UseVisualStyleBackColor = true;
            this.checkBoxShow3D.Click += new System.EventHandler(this.checkBoxShow3D_Click);
            // 
            // checkBoxShowLegend
            // 
            this.checkBoxShowLegend.AutoSize = true;
            this.checkBoxShowLegend.Location = new System.Drawing.Point(22, 54);
            this.checkBoxShowLegend.Name = "checkBoxShowLegend";
            this.checkBoxShowLegend.Size = new System.Drawing.Size(93, 25);
            this.checkBoxShowLegend.TabIndex = 0;
            this.checkBoxShowLegend.Text = "显示图例";
            this.checkBoxShowLegend.UseVisualStyleBackColor = true;
            this.checkBoxShowLegend.Click += new System.EventHandler(this.checkBoxShowLegend_Click);
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
            this.tabPageEveryDay.Size = new System.Drawing.Size(1212, 790);
            this.tabPageEveryDay.TabIndex = 1;
            this.tabPageEveryDay.Text = "每日分布";
            this.tabPageEveryDay.UseVisualStyleBackColor = true;
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
            // cboEveryLabel
            // 
            this.cboEveryLabel.FormattingEnabled = true;
            this.cboEveryLabel.Location = new System.Drawing.Point(538, 27);
            this.cboEveryLabel.Name = "cboEveryLabel";
            this.cboEveryLabel.Size = new System.Drawing.Size(121, 29);
            this.cboEveryLabel.TabIndex = 11;
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
            // tabPageShowSourceData
            // 
            this.tabPageShowSourceData.Controls.Add(this.groupBox2);
            this.tabPageShowSourceData.Controls.Add(this.dgvShow);
            this.tabPageShowSourceData.Controls.Add(this.groupBoxFilter);
            this.tabPageShowSourceData.Location = new System.Drawing.Point(4, 30);
            this.tabPageShowSourceData.Name = "tabPageShowSourceData";
            this.tabPageShowSourceData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShowSourceData.Size = new System.Drawing.Size(1212, 790);
            this.tabPageShowSourceData.TabIndex = 3;
            this.tabPageShowSourceData.Text = "显示源数据";
            this.tabPageShowSourceData.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(770, 421);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 369);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "导出每日总结";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 34);
            this.button2.TabIndex = 13;
            this.button2.Text = "导出数据到Excel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgvShow
            // 
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Location = new System.Drawing.Point(6, 6);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowTemplate.Height = 23;
            this.dgvShow.Size = new System.Drawing.Size(712, 766);
            this.dgvShow.TabIndex = 13;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.label7);
            this.groupBoxFilter.Controls.Add(this.label6);
            this.groupBoxFilter.Controls.Add(this.dtpShowSecondTIme);
            this.groupBoxFilter.Controls.Add(this.dtpShowBeginTIme);
            this.groupBoxFilter.Controls.Add(this.btnFilter);
            this.groupBoxFilter.Controls.Add(this.btnIOExcelLabel);
            this.groupBoxFilter.Controls.Add(this.label17);
            this.groupBoxFilter.Controls.Add(this.txtShowNote);
            this.groupBoxFilter.Controls.Add(this.label14);
            this.groupBoxFilter.Controls.Add(this.cboShowSecondLabel);
            this.groupBoxFilter.Controls.Add(this.label13);
            this.groupBoxFilter.Controls.Add(this.cboShowFirstLabel);
            this.groupBoxFilter.Location = new System.Drawing.Point(751, 24);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(337, 369);
            this.groupBoxFilter.TabIndex = 12;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "筛选条件";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "二级标签: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "开始时间: ";
            // 
            // dtpShowSecondTIme
            // 
            this.dtpShowSecondTIme.Location = new System.Drawing.Point(104, 75);
            this.dtpShowSecondTIme.Name = "dtpShowSecondTIme";
            this.dtpShowSecondTIme.Size = new System.Drawing.Size(200, 29);
            this.dtpShowSecondTIme.TabIndex = 15;
            // 
            // dtpShowBeginTIme
            // 
            this.dtpShowBeginTIme.Location = new System.Drawing.Point(104, 28);
            this.dtpShowBeginTIme.Name = "dtpShowBeginTIme";
            this.dtpShowBeginTIme.Size = new System.Drawing.Size(200, 29);
            this.dtpShowBeginTIme.TabIndex = 14;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(19, 253);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(105, 34);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "筛选";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnIOExcelLabel
            // 
            this.btnIOExcelLabel.Location = new System.Drawing.Point(136, 253);
            this.btnIOExcelLabel.Name = "btnIOExcelLabel";
            this.btnIOExcelLabel.Size = new System.Drawing.Size(168, 34);
            this.btnIOExcelLabel.TabIndex = 13;
            this.btnIOExcelLabel.Text = "导出数据到Excel";
            this.btnIOExcelLabel.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 205);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 21);
            this.label17.TabIndex = 10;
            this.label17.Text = "备注: ";
            // 
            // txtShowNote
            // 
            this.txtShowNote.Location = new System.Drawing.Point(104, 202);
            this.txtShowNote.Name = "txtShowNote";
            this.txtShowNote.Size = new System.Drawing.Size(150, 29);
            this.txtShowNote.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 21);
            this.label14.TabIndex = 3;
            this.label14.Text = "二级标签: ";
            // 
            // cboShowSecondLabel
            // 
            this.cboShowSecondLabel.FormattingEnabled = true;
            this.cboShowSecondLabel.Location = new System.Drawing.Point(104, 160);
            this.cboShowSecondLabel.Name = "cboShowSecondLabel";
            this.cboShowSecondLabel.Size = new System.Drawing.Size(150, 29);
            this.cboShowSecondLabel.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 21);
            this.label13.TabIndex = 1;
            this.label13.Text = "一级标签: ";
            // 
            // cboShowFirstLabel
            // 
            this.cboShowFirstLabel.FormattingEnabled = true;
            this.cboShowFirstLabel.Location = new System.Drawing.Point(104, 113);
            this.cboShowFirstLabel.Name = "cboShowFirstLabel";
            this.cboShowFirstLabel.Size = new System.Drawing.Size(150, 29);
            this.cboShowFirstLabel.TabIndex = 2;
            this.cboShowFirstLabel.SelectedIndexChanged += new System.EventHandler(this.cboShowFirstLabel_SelectedIndexChanged);
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 840);
            this.Controls.Add(this.tabControlAnalysis);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormAna";
            this.Text = "分析区";
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalysis)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            this.tabControlAnalysis.ResumeLayout(false);
            this.tabPageTotal.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPageEveryDay.ResumeLayout(false);
            this.tabPageEveryDay.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPageShowSourceData.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControlAnalysis;
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxShowLegend;
        private System.Windows.Forms.CheckBox checkBoxShow3D;
        private System.Windows.Forms.Button btnExportToJPG;
        private System.Windows.Forms.TabPage tabPageShowSourceData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpShowSecondTIme;
        private System.Windows.Forms.DateTimePicker dtpShowBeginTIme;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnIOExcelLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtShowNote;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboShowSecondLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboShowFirstLabel;
    }
}