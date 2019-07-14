using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TimeRecorder
{
    public partial class FormTodaySummary : Form
    {
        string summaryDir = @"summary/";
        string rtfExtison = ".rtf";
        string summaryFileName = String.Empty;
        string chartPieName = "饼状图", legendPieName = "饼状图图例";
        double minutesOfDay = 60 * 24;
        Dictionary<string, TimeSpan> dayDictionary = new Dictionary<string, TimeSpan>();
        string LabelTableName = "标签表", firstLabelColumnName = "一级标签", secondLabelColumnName = "二级标签";
        string dateColumnName = "日期", beginTimeColumnName = "开始时间", endTimeColumnName = "结束时间";

        public DataTable tableOfDay;

        public FormTodaySummary()
        {
            InitializeComponent();
            tableOfDay = new DataTable(); //避免null异常
            rTxtTodaySummary.ImeMode = ImeMode.On;

        }

        private void rTxtTodaySummary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.S: break;
                    case Keys.B: toolStripBtnBold.PerformClick(); ; break;
                    case Keys.I: toolStripBtnItalic.PerformClick(); break;
                    case Keys.U: toolStripBtnUnerLine.PerformClick(); break;
                    case Keys.T: toolStripBtnStrikeout.PerformClick(); break;

                    default: break;
                }
            }
        }

        public void LoadChartPie(DateTime dt)
        {
            //TODO: 显示格式修改为 8H：10m的样式
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

            foreach (var item in dayDictionary)
            {
                xLbaelData.Add(item.Key);
                yTimeSpanData.Add(item.Value.TotalMinutes);
            }


            chartAnalysis.Series[chartPieName].Points.DataBindXY(xLbaelData, yTimeSpanData);
            chartAnalysis.Series[chartPieName].XValueType = ChartValueType.String;

        }

        #region 富文本编辑

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

        private void toolStripBtnStrikeout_Click(object sender, EventArgs e)
        {
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

            summaryFileName = summaryDir + dt.ToString("yyyyMMdd") + dt.DayOfWeek + rtfExtison;
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
