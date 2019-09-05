using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace TimeRecorder
{
    public partial class FormTodaySummary : Form
    {
        #region 数据定义

        string dataTableName = GlobalData.dataTableName, LabelTableName = GlobalData.labelTabelName;
        string firstLabelColumnName = GlobalData.firstLabelColumnName, secondLabelColumnName = GlobalData.secondLabelColumnName;
        string dateColumnName = GlobalData.dateColumnName, beginTimeColumnName = GlobalData.beginTimeColumnName,
            endTimeColumnName = GlobalData.endTimeColumnName, noteColumnName = GlobalData.noteColumnName;

        string summaryDir = @"summary/";  //summary存放的目录
        string rtfExtison = ".rtf";
        string summaryFileName = String.Empty;
        string chartPieName = "饼状图", legendPieName = "饼状图图例";


        //以下是字体大小下拉框用的数据
        //设置数组保存下拉菜单上要显示的字号的大小,
        string[] fontSizeName = { "8", "9", "10", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72", "初号", "小初", "一号", "小一", "二号", "小二", "三号", "小三", "四号", "小四", "五号", "小五", "六号", "小六", "七号", "八号" };

        //利用榜和字号的关系定义一个字体大小的数组
        float[] fontSize = { 8, 9, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72, 42, 36, 26, 24, 22, 18, 16, 15, 14, 12, 10.5F, 9, 7.5F, 6.5F, 5.5F, 5 };

        #endregion




        public FormTodaySummary()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;  //TODO:总结窗口在记录窗口的右边
            fillCboFont();
            fillCboFontSize();


            rTxtTodaySummary.ImeMode = ImeMode.On;
            rTxtTodaySummary.AcceptsTab = true; //按下tab键则增加空格而不是切换到下一个控件
            rTxtTodaySummary.AutoWordSelection = true;

            //用来决定当焦点离开文本框后，选中的文本是否还以选中的方式显示
            //最好设置为false，否则改变字体、大小时不会显示选中的文本
            rTxtTodaySummary.HideSelection = false;

            chartAnalysis.AntiAliasing = AntiAliasingStyles.All; //文本和图形抗锯齿


        }

        private void fillCboFont()
        {
            toolStripCboFont.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            toolStripCboFont.AutoCompleteSource = AutoCompleteSource.ListItems;


            var a = new System.Drawing.Text.InstalledFontCollection(); //引入系统安装的字体
            foreach (var b in a.Families)
            {
                toolStripCboFont.Items.Add(b.Name);
            }
            toolStripCboFont.SelectedItem = "微软雅黑"; //默认显示的字体

        }

        private void fillCboFontSize()
        {
            toolStripCboFontSize.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            toolStripCboFontSize.AutoCompleteSource = AutoCompleteSource.ListItems;


            foreach (var f in fontSizeName)
            {
                toolStripCboFontSize.Items.Add(f);
            }
            toolStripCboFontSize.SelectedItem = "10";  //默认显示的字号
        }

        public void LoadChartPie(DataTable tableOfDay)
        {
            //TODO: 显示格式修改为 8H：10m的样式
            Dictionary<string, TimeSpan> dayDictionary = new Dictionary<string, TimeSpan>();

            List<double> yTimeSpanData = new List<double>();
            List<string> xLbaelData = new List<string>();
            xLbaelData.Clear();
            yTimeSpanData.Clear();
            dayDictionary.Clear();
            chartAnalysis.Series[0].Name = chartPieName;
            chartAnalysis.Legends[0].Name = legendPieName;
            chartAnalysis.Legends[legendPieName].Enabled = false;

            chartAnalysis.Series[chartPieName].ChartType = SeriesChartType.Pie;
            chartAnalysis.Series[chartPieName].IsValueShownAsLabel = false;   //设置为true则不会显示文字
            chartAnalysis.Series[chartPieName].Label = "#VALX: #VAL分钟";
            chartAnalysis.Series[chartPieName]["PieLabelStyle"] = "Outside";  //将文字移到外侧
            chartAnalysis.Series[chartPieName]["PieLineColor"] = "Blue";      //绘制黑色的连线。


            foreach (DataRow item in tableOfDay.Rows)
            {
                TimeSpan ts = (DateTime)item[endTimeColumnName] - (DateTime)item[beginTimeColumnName];
                string labelName = (string)item[firstLabelColumnName];
                if (dayDictionary.ContainsKey(labelName))
                {
                    dayDictionary[labelName] += ts;
                }
                else
                {
                    dayDictionary.Add(labelName, ts);
                }
            }

            int minutesOfUnRecord = 60 * 24;
            foreach (var item in dayDictionary)
            {

                xLbaelData.Add(item.Key);
                yTimeSpanData.Add((int)item.Value.TotalMinutes);
                minutesOfUnRecord -= (int)item.Value.TotalMinutes;
            }

            if (minutesOfUnRecord != 0)
            {
                xLbaelData.Add("未记录");
                yTimeSpanData.Add(minutesOfUnRecord);
            }

            chartAnalysis.Series[chartPieName].Points.DataBindXY(xLbaelData, yTimeSpanData);
            chartAnalysis.Series[chartPieName].XValueType = ChartValueType.String;

        }


        #region 富文本编辑

        private void rTxtTodaySummary_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control)
            {
                switch (e.KeyCode)
                {

                    case Keys.S: rTxtTodaySummary_save(); break;
                    case Keys.D: toolStripBtnColor.PerformClick(); break;
                    case Keys.B: toolStripBtnBold.PerformClick(); ; break;
                    case Keys.I: toolStripBtnItalic.PerformClick(); break;
                    case Keys.U: toolStripBtnUnerLine.PerformClick(); break;
                    case Keys.T: toolStripBtnStrikeout.PerformClick(); break;
                    case Keys.W: if (e.Shift) toolStripBtnList.PerformClick(); break;
                    case Keys.M:
                        if (e.Shift)
                        {
                            toolStripBtnOutdent.PerformClick();
                        }
                        else
                        {
                            toolStripBtnIndent.PerformClick();
                        }
                        break;
                    

                    default: break;
                }
            }
        }

        private void toolStripCboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            rTxtTodaySummary.SelectionFont = new Font(toolStripCboFont.Text, rTxtTodaySummary.SelectionFont.Size, rTxtTodaySummary.SelectionFont.Style);
        }

        private void toolStripCboFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            rTxtTodaySummary.SelectionFont = new Font(rTxtTodaySummary.SelectionFont.FontFamily, fontSize[toolStripCboFontSize.SelectedIndex], rTxtTodaySummary.SelectionFont.Style);
        }

        private void toolStripBtnColor_Click(object sender, EventArgs e)
        {
            ColorDialog diaColor = new ColorDialog();

            // Set the initial color of the dialog to the current text color.
            diaColor.Color = rTxtTodaySummary.SelectionColor;

            // Determine if the user clicked OK in the dialog and that the color has changed.
            if (diaColor.ShowDialog() == DialogResult.OK && diaColor.Color != rTxtTodaySummary.SelectionColor)
            {
                // Change the selection color to the user specified color.
                rTxtTodaySummary.SelectionColor = diaColor.Color;
            }
        }

        private void toolStripBtnBold_Click(object sender, EventArgs e)
        {
            Font oldFont = rTxtTodaySummary.SelectionFont;
            Font newFont;
            if (oldFont.Bold)
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);  //取消粗体
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);  //加粗
            }
            rTxtTodaySummary.SelectionFont = newFont;

        }

        private void toolStripBtnItalic_Click(object sender, EventArgs e)
        {
            //TODO: 有bug，斜体后字会不见。
            Font oldFont = rTxtTodaySummary.SelectionFont;
            Font newFont;
            if (oldFont.Italic)
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);  //取消斜体
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);
            }
            rTxtTodaySummary.SelectionFont = newFont;
        }

        private void toolStripBtnUnerLine_Click(object sender, EventArgs e)
        {
            Font oldFont = rTxtTodaySummary.SelectionFont;
            Font newFont;
            if (oldFont.Underline)
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);  //取消下划线
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);
            }
            rTxtTodaySummary.SelectionFont = newFont;
        }

        private void toolStripBtnIndent_Click(object sender, EventArgs e)
        {
            rTxtTodaySummary.SelectionIndent += 10;
        }

        private void toolStripBtnOutdent_Click(object sender, EventArgs e)
        {
            if (rTxtTodaySummary.SelectionIndent > 0)
            {
                if (rTxtTodaySummary.SelectionIndent > 10)
                {
                    rTxtTodaySummary.SelectionIndent -= 10;
                }
                else
                {
                    rTxtTodaySummary.SelectionIndent = 0;
                }
            }
        }

        private void toolStripBtnList_Click(object sender, EventArgs e)
        {
            bool t = rTxtTodaySummary.SelectionBullet;
            rTxtTodaySummary.SelectionBullet = !t;
        }

        private void rTxtTodaySummary_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void toolStripBtnStrikeout_Click(object sender, EventArgs e)
        {
            //划线：在中间有条线划掉选中的字
            Font oldFont = rTxtTodaySummary.SelectionFont;
            Font newFont;
            if (oldFont.Strikeout)
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Strikeout);  //取消划掉
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Strikeout);
            }
            rTxtTodaySummary.SelectionFont = newFont;
        }

        #endregion


        public void LoadSummary(DateTime dt)
        {
            //TODO: 增删查改模板文件
            if (!Directory.Exists(summaryDir))
                Directory.CreateDirectory(summaryDir);

            summaryFileName = summaryDir + dt.ToString("yyyyMMdd ") + dt.DayOfWeek + rtfExtison;
            if (!File.Exists(summaryFileName))
                rTxtTodaySummary.SaveFile(summaryFileName);
            rTxtTodaySummary.Clear();  //避免更换日期时总结不消除
            rTxtTodaySummary.LoadFile(summaryFileName);

        }

        private void rTxtTodaySummary_Leave(object sender, EventArgs e)
        {
            rTxtTodaySummary_save();
        }

        private void rTxtTodaySummary_save()
        {
            rTxtTodaySummary.SaveFile(summaryFileName);
            //如果是在TextChanged事件里用SaveFile方法，会报错：有另一个进程在使用
        }

        private void FormTodaySummary_FormClosed(object sender, FormClosedEventArgs e)
        {
            rTxtTodaySummary_save();
        }

    }
}
