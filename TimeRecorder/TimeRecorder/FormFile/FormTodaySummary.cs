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
        public DataTable tableOfDay = new DataTable(); //避免null异常

        string chartPieName = "饼状图", legendPieName = "饼状图图例";
        string beginTimeColumnName = GlobalData.beginTimeColumnName;
        string endTimeColumnName = GlobalData.endTimeColumnName;
        string firstLabelColumnName = GlobalData.firstLabelColumnName;
        string secondLabelColumnName = GlobalData.secondLabelColumnName;

        string summaryDir = @"summary/";  //summary存放的目录
        string rtfExtison = ".rtf";
        string summaryFileName = String.Empty;

        string filePath = "Provider = Microsoft.ACE.OLEDB.12.0;  Data source = TimeRecorderData.accdb";
        #endregion


        #region 图表显示


        public FormTodaySummary()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;  //TODO:总结窗口在记录窗口的右边
            rTxtTodaySummary.ImeMode = ImeMode.On;
            rTxtTodaySummary.AutoWordSelection = true;
            chartAnalysis.AntiAliasing = AntiAliasingStyles.All; //文本和图形抗锯齿

        }


        public void LoadChartPie()
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

            //将所有标签和时间和 保存到字典里
            foreach (DataRow item in tableOfDay.Rows)
            {
                TimeSpan ts = (DateTime)item[endTimeColumnName] - (DateTime)item[beginTimeColumnName];
                string labelName = (string)item[firstLabelColumnName];
                if (dayDictionary.ContainsKey(labelName))
                {
                    dayDictionary[labelName] += ts;  //累加时间
                }
                else
                {
                    dayDictionary.Add(labelName, ts); //将该标签加入字典，准备累加时间
                }
            }


            //将标签和累计时间分别保存到 xLabel 和 yTime
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


        #endregion


        
        #region 富文本编辑

        public void LoadSummary(DateTime dt)
        {
            //TODO: 增删查改模板文件
            if (!Directory.Exists(summaryDir))
                Directory.CreateDirectory(summaryDir);

            summaryFileName = summaryDir + dt.ToString("yyyyMMdd ") + dt.DayOfWeek + rtfExtison;
            if (!File.Exists(summaryFileName))
            {
                rTxtTodaySummary.SaveFile(summaryFileName);
            }

            rTxtTodaySummary.Clear();  //避免更换日期时总结不消除
            rTxtTodaySummary.LoadFile(summaryFileName);

        }

        private void rTxtTodaySummary_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.S: rTxtTodaySummary_save(); break;
                    case Keys.B: toolStripBtnBold.PerformClick(); ; break;
                    case Keys.I: toolStripBtnItalic.PerformClick(); break;
                    case Keys.U: toolStripBtnUnerLine.PerformClick(); break;
                    case Keys.T: toolStripBtnStrikeout.PerformClick(); break;

                    default: break;
                }
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

        }

        private void toolStripBtnNumList_Click(object sender, EventArgs e)
        {

        }

        private void toolStripBtnOutdent_Click(object sender, EventArgs e)
        {

        }

        private void rTxtTodaySummary_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void toolStripBtnStrikeout_Click(object sender, EventArgs e)
        { //划线：在中间有条线划掉选中的字
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


        private void rTxtTodaySummary_Leave(object sender, EventArgs e)
        {
            rTxtTodaySummary_save();
        }


        private void FormTodaySummary_FormClosed(object sender, FormClosedEventArgs e)
        {
            rTxtTodaySummary_save();
        }


        private void rTxtTodaySummary_save()
        {
            rTxtTodaySummary.SaveFile(summaryFileName);
            //如果是在TextChanged事件里用SaveFile方法，会报错：有另一个进程在使用
        }

        #endregion



    }
}
