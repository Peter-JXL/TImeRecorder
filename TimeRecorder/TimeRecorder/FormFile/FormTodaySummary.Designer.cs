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
            this.rTxtTodaySummary = new System.Windows.Forms.RichTextBox();
            this.chartAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStripFormSummary = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnUnerLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnStrikeout = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnIndent = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnNumList = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnOutdent = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowserWord = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalysis)).BeginInit();
            this.toolStripFormSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // rTxtTodaySummary
            // 
            this.rTxtTodaySummary.Location = new System.Drawing.Point(416, 72);
            this.rTxtTodaySummary.Name = "rTxtTodaySummary";
            this.rTxtTodaySummary.Size = new System.Drawing.Size(268, 206);
            this.rTxtTodaySummary.TabIndex = 0;
            this.rTxtTodaySummary.Text = "";
            this.rTxtTodaySummary.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rTxtTodaySummary_LinkClicked);
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
            this.chartAnalysis.Location = new System.Drawing.Point(21, 72);
            this.chartAnalysis.Name = "chartAnalysis";
            this.chartAnalysis.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartAreaPie";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "LegendPie";
            series1.Name = "SeriesPie";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            series1.YValuesPerPoint = 2;
            this.chartAnalysis.Series.Add(series1);
            this.chartAnalysis.Size = new System.Drawing.Size(389, 409);
            this.chartAnalysis.TabIndex = 20;
            this.chartAnalysis.Text = "chart1";
            // 
            // toolStripFormSummary
            // 
            this.toolStripFormSummary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnBold,
            this.toolStripBtnItalic,
            this.toolStripBtnUnerLine,
            this.toolStripBtnStrikeout,
            this.toolStripBtnIndent,
            this.toolStripBtnNumList,
            this.toolStripBtnOutdent});
            this.toolStripFormSummary.Location = new System.Drawing.Point(0, 0);
            this.toolStripFormSummary.Name = "toolStripFormSummary";
            this.toolStripFormSummary.Size = new System.Drawing.Size(823, 25);
            this.toolStripFormSummary.TabIndex = 21;
            this.toolStripFormSummary.Text = "toolStrip1";
            // 
            // toolStripBtnBold
            // 
            this.toolStripBtnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnBold.Image = global::TimeRecorder.Properties.Resources.bold_48px;
            this.toolStripBtnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnBold.Name = "toolStripBtnBold";
            this.toolStripBtnBold.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnBold.Text = "toolStripButton9";
            this.toolStripBtnBold.Click += new System.EventHandler(this.toolStripBtnBold_Click);
            // 
            // toolStripBtnItalic
            // 
            this.toolStripBtnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnItalic.Image = global::TimeRecorder.Properties.Resources.italic_48px;
            this.toolStripBtnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnItalic.Name = "toolStripBtnItalic";
            this.toolStripBtnItalic.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnItalic.Text = "toolStripButton10";
            this.toolStripBtnItalic.Click += new System.EventHandler(this.toolStripBtnItalic_Click);
            // 
            // toolStripBtnUnerLine
            // 
            this.toolStripBtnUnerLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnUnerLine.Image = global::TimeRecorder.Properties.Resources.underline_48px;
            this.toolStripBtnUnerLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnUnerLine.Name = "toolStripBtnUnerLine";
            this.toolStripBtnUnerLine.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnUnerLine.Text = "toolStripButton11";
            this.toolStripBtnUnerLine.Click += new System.EventHandler(this.toolStripBtnUnerLine_Click);
            // 
            // toolStripBtnStrikeout
            // 
            this.toolStripBtnStrikeout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnStrikeout.Image = global::TimeRecorder.Properties.Resources.text_48px;
            this.toolStripBtnStrikeout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnStrikeout.Name = "toolStripBtnStrikeout";
            this.toolStripBtnStrikeout.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnStrikeout.Text = "划掉";
            this.toolStripBtnStrikeout.Click += new System.EventHandler(this.toolStripBtnStrikeout_Click);
            // 
            // toolStripBtnIndent
            // 
            this.toolStripBtnIndent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnIndent.Image = global::TimeRecorder.Properties.Resources.indent_48px;
            this.toolStripBtnIndent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnIndent.Name = "toolStripBtnIndent";
            this.toolStripBtnIndent.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnIndent.Text = "toolStripButton13";
            this.toolStripBtnIndent.Click += new System.EventHandler(this.toolStripBtnIndent_Click);
            // 
            // toolStripBtnNumList
            // 
            this.toolStripBtnNumList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnNumList.Image = global::TimeRecorder.Properties.Resources.numbered_list_48px;
            this.toolStripBtnNumList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnNumList.Name = "toolStripBtnNumList";
            this.toolStripBtnNumList.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnNumList.Text = "toolStripButton2";
            this.toolStripBtnNumList.Click += new System.EventHandler(this.toolStripBtnNumList_Click);
            // 
            // toolStripBtnOutdent
            // 
            this.toolStripBtnOutdent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnOutdent.Image = global::TimeRecorder.Properties.Resources.outdent_48px;
            this.toolStripBtnOutdent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnOutdent.Name = "toolStripBtnOutdent";
            this.toolStripBtnOutdent.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnOutdent.Text = "toolStripButton1";
            this.toolStripBtnOutdent.Click += new System.EventHandler(this.toolStripBtnOutdent_Click);
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
            // webBrowserWord
            // 
            this.webBrowserWord.Location = new System.Drawing.Point(434, 299);
            this.webBrowserWord.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserWord.Name = "webBrowserWord";
            this.webBrowserWord.Size = new System.Drawing.Size(366, 261);
            this.webBrowserWord.TabIndex = 24;
            // 
            // FormTodaySummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 572);
            this.Controls.Add(this.webBrowserWord);
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
        private System.Windows.Forms.ToolStripButton toolStripBtnBold;
        private System.Windows.Forms.ToolStripButton toolStripBtnItalic;
        private System.Windows.Forms.ToolStripButton toolStripBtnUnerLine;
        private System.Windows.Forms.ToolStripButton toolStripBtnStrikeout;
        private System.Windows.Forms.ToolStripButton toolStripBtnIndent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripBtnOutdent;
        private System.Windows.Forms.ToolStripButton toolStripBtnNumList;
        private System.Windows.Forms.WebBrowser webBrowserWord;
    }
}