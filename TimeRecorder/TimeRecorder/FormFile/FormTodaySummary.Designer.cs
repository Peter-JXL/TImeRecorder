﻿namespace TimeRecorder
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.rTxtTodaySummary = new System.Windows.Forms.RichTextBox();
            this.chartAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.cmsRichText = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripCboFont = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripCboFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripBtnBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnUnerLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnStrikeout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnIndent = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnOutdent = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnNumList = new System.Windows.Forms.ToolStripButton();
            this.toolStripFormSummary = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnColor = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalysis)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStripFormSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // rTxtTodaySummary
            // 
            this.rTxtTodaySummary.Location = new System.Drawing.Point(3, 28);
            this.rTxtTodaySummary.Name = "rTxtTodaySummary";
            this.rTxtTodaySummary.Size = new System.Drawing.Size(477, 482);
            this.rTxtTodaySummary.TabIndex = 0;
            this.rTxtTodaySummary.Text = "";
            this.rTxtTodaySummary.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rTxtTodaySummary_LinkClicked);
            this.rTxtTodaySummary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rTxtTodaySummary_KeyDown);
            // 
            // chartAnalysis
            // 
            this.chartAnalysis.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartAreaPie";
            this.chartAnalysis.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "LegendPie";
            this.chartAnalysis.Legends.Add(legend2);
            this.chartAnalysis.Location = new System.Drawing.Point(-2, 44);
            this.chartAnalysis.Name = "chartAnalysis";
            this.chartAnalysis.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.ChartArea = "ChartAreaPie";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "LegendPie";
            series2.Name = "SeriesPie";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            series2.YValuesPerPoint = 2;
            this.chartAnalysis.Series.Add(series2);
            this.chartAnalysis.Size = new System.Drawing.Size(437, 502);
            this.chartAnalysis.TabIndex = 20;
            this.chartAnalysis.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "今日总结：";
            // 
            // cmsRichText
            // 
            this.cmsRichText.Name = "contextMenuStrip1";
            this.cmsRichText.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStripFormSummary);
            this.panel1.Controls.Add(this.rTxtTodaySummary);
            this.panel1.Location = new System.Drawing.Point(442, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 513);
            this.panel1.TabIndex = 24;
            // 
            // toolStripCboFont
            // 
            this.toolStripCboFont.Name = "toolStripCboFont";
            this.toolStripCboFont.Size = new System.Drawing.Size(150, 25);
            this.toolStripCboFont.SelectedIndexChanged += new System.EventHandler(this.toolStripCboFont_SelectedIndexChanged);
            // 
            // toolStripCboFontSize
            // 
            this.toolStripCboFontSize.Name = "toolStripCboFontSize";
            this.toolStripCboFontSize.Size = new System.Drawing.Size(75, 25);
            this.toolStripCboFontSize.SelectedIndexChanged += new System.EventHandler(this.toolStripCboFontSize_SelectedIndexChanged);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnIndent
            // 
            this.toolStripBtnIndent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnIndent.Image = global::TimeRecorder.Properties.Resources.indent_48px;
            this.toolStripBtnIndent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnIndent.Name = "toolStripBtnIndent";
            this.toolStripBtnIndent.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnIndent.Text = "toolStripButton13";
            this.toolStripBtnIndent.Click += new System.EventHandler(this.toolStripBtnOutdent_Click);
            // 
            // toolStripBtnOutdent
            // 
            this.toolStripBtnOutdent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnOutdent.Image = global::TimeRecorder.Properties.Resources.outdent_48px;
            this.toolStripBtnOutdent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnOutdent.Name = "toolStripBtnOutdent";
            this.toolStripBtnOutdent.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnOutdent.Text = "toolStripButton1";
            this.toolStripBtnOutdent.Click += new System.EventHandler(this.toolStripBtnIndent_Click);
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
            // toolStripFormSummary
            // 
            this.toolStripFormSummary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCboFont,
            this.toolStripCboFontSize,
            this.toolStripBtnColor,
            this.toolStripBtnBold,
            this.toolStripBtnItalic,
            this.toolStripBtnUnerLine,
            this.toolStripBtnStrikeout,
            this.toolStripSeparator1,
            this.toolStripBtnIndent,
            this.toolStripBtnOutdent,
            this.toolStripBtnNumList});
            this.toolStripFormSummary.Location = new System.Drawing.Point(0, 0);
            this.toolStripFormSummary.Name = "toolStripFormSummary";
            this.toolStripFormSummary.Size = new System.Drawing.Size(547, 25);
            this.toolStripFormSummary.TabIndex = 25;
            this.toolStripFormSummary.Text = "toolStrip1";
            // 
            // toolStripBtnColor
            // 
            this.toolStripBtnColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnColor.Image = global::TimeRecorder.Properties.Resources.color;
            this.toolStripBtnColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnColor.Name = "toolStripBtnColor";
            this.toolStripBtnColor.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnColor.Text = "修改颜色";
            this.toolStripBtnColor.Click += new System.EventHandler(this.toolStripBtnColor_Click);
            // 
            // FormTodaySummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 603);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartAnalysis);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormTodaySummary";
            this.Text = "FormTodaySummary";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTodaySummary_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalysis)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStripFormSummary.ResumeLayout(false);
            this.toolStripFormSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTxtTodaySummary;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAnalysis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsRichText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStripFormSummary;
        private System.Windows.Forms.ToolStripComboBox toolStripCboFont;
        private System.Windows.Forms.ToolStripComboBox toolStripCboFontSize;
        private System.Windows.Forms.ToolStripButton toolStripBtnBold;
        private System.Windows.Forms.ToolStripButton toolStripBtnItalic;
        private System.Windows.Forms.ToolStripButton toolStripBtnUnerLine;
        private System.Windows.Forms.ToolStripButton toolStripBtnStrikeout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBtnIndent;
        private System.Windows.Forms.ToolStripButton toolStripBtnOutdent;
        private System.Windows.Forms.ToolStripButton toolStripBtnNumList;
        private System.Windows.Forms.ToolStripButton toolStripBtnColor;
    }
}