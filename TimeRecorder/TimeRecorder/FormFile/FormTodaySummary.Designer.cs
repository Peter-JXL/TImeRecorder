namespace TimeRecorder
{
    partial class FormTodaySummary
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
            Hide();
            //if (disposing && (components != null))
            //{
            //    components.Dispose();
            //}
            //base.Dispose(disposing);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTodaySummary));
            this.rTxtTodaySummary = new System.Windows.Forms.RichTextBox();
            this.chartAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStripFormSummary = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnUnerLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnStrikeout = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalysis)).BeginInit();
            this.toolStripFormSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // rTxtTodaySummary
            // 
            this.rTxtTodaySummary.Location = new System.Drawing.Point(416, 72);
            this.rTxtTodaySummary.Name = "rTxtTodaySummary";
            this.rTxtTodaySummary.Size = new System.Drawing.Size(354, 433);
            this.rTxtTodaySummary.TabIndex = 0;
            this.rTxtTodaySummary.Text = "";
            this.rTxtTodaySummary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rTxtTodaySummary_KeyDown);
            // 
            // chartAnalysis
            // 
            this.chartAnalysis.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartAreaPie";
            this.chartAnalysis.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "LegendPie";
            this.chartAnalysis.Legends.Add(legend1);
            this.chartAnalysis.Location = new System.Drawing.Point(12, 37);
            this.chartAnalysis.Name = "chartAnalysis";
            this.chartAnalysis.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartAreaPie";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "LegendPie";
            series1.Name = "SeriesPie";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            series1.YValuesPerPoint = 2;
            this.chartAnalysis.Series.Add(series1);
            this.chartAnalysis.Size = new System.Drawing.Size(398, 436);
            this.chartAnalysis.TabIndex = 20;
            this.chartAnalysis.Text = "chart1";
            // 
            // toolStripFormSummary
            // 
            this.toolStripFormSummary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSplitButton1,
            this.toolStripSeparator1,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripSeparator2,
            this.toolStripBtnBold,
            this.toolStripBtnItalic,
            this.toolStripBtnUnerLine,
            this.toolStripBtnStrikeout,
            this.toolStripButton13});
            this.toolStripFormSummary.Location = new System.Drawing.Point(0, 0);
            this.toolStripFormSummary.Name = "toolStripFormSummary";
            this.toolStripFormSummary.Size = new System.Drawing.Size(823, 25);
            this.toolStripFormSummary.TabIndex = 21;
            this.toolStripFormSummary.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "toolStripButton7";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "toolStripButton8";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnBold
            // 
            this.toolStripBtnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnBold.Image = global::TimeRecorder.Properties.Resources.bold;
            this.toolStripBtnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnBold.Name = "toolStripBtnBold";
            this.toolStripBtnBold.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnBold.Text = "toolStripButton9";
            this.toolStripBtnBold.Click += new System.EventHandler(this.toolStripBtnBold_Click);
            // 
            // toolStripBtnItalic
            // 
            this.toolStripBtnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnItalic.Image = global::TimeRecorder.Properties.Resources.font_italic;
            this.toolStripBtnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnItalic.Name = "toolStripBtnItalic";
            this.toolStripBtnItalic.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnItalic.Text = "toolStripButton10";
            this.toolStripBtnItalic.Click += new System.EventHandler(this.toolStripBtnItalic_Click);
            // 
            // toolStripBtnUnerLine
            // 
            this.toolStripBtnUnerLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnUnerLine.Image = global::TimeRecorder.Properties.Resources.font_underlined;
            this.toolStripBtnUnerLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnUnerLine.Name = "toolStripBtnUnerLine";
            this.toolStripBtnUnerLine.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnUnerLine.Text = "toolStripButton11";
            this.toolStripBtnUnerLine.Click += new System.EventHandler(this.toolStripBtnUnerLine_Click);
            // 
            // toolStripBtnStrikeout
            // 
            this.toolStripBtnStrikeout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnStrikeout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnStrikeout.Image")));
            this.toolStripBtnStrikeout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnStrikeout.Name = "toolStripBtnStrikeout";
            this.toolStripBtnStrikeout.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnStrikeout.Text = "划掉";
            this.toolStripBtnStrikeout.Click += new System.EventHandler(this.toolStripBtnStrikeout_Click);
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "toolStripButton13";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "今日总结：";
            // 
            // FormTodaySummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 572);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStripFormSummary);
            this.Controls.Add(this.chartAnalysis);
            this.Controls.Add(this.rTxtTodaySummary);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormTodaySummary";
            this.Text = "FormTodaySummary";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTodaySummary_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalysis)).EndInit();
            this.toolStripFormSummary.ResumeLayout(false);
            this.toolStripFormSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTxtTodaySummary;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAnalysis;
        private System.Windows.Forms.ToolStrip toolStripFormSummary;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripBtnBold;
        private System.Windows.Forms.ToolStripButton toolStripBtnItalic;
        private System.Windows.Forms.ToolStripButton toolStripBtnUnerLine;
        private System.Windows.Forms.ToolStripButton toolStripBtnStrikeout;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.Label label1;
    }
}