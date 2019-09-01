using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TimeRecorder
{
    public partial class FormAna : Form
    {
        #region 数据定义
        string dataTableName = GlobalData.dataTableName, LabelTableName = GlobalData.labelTabelName;
        string firstLabelColumnName = GlobalData.firstLabelColumnName, secondLabelColumnName = GlobalData.secondLabelColumnName;
        string dateColumnName = GlobalData.dateColumnName, beginTimeColumnName = GlobalData.beginTimeColumnName,
            endTimeColumnName = GlobalData.endTimeColumnName, noteColumnName = GlobalData.noteColumnName;

        string chartPieName = "饼状图", legendPieName = "饼状图图例";
        #endregion



        public FormAna()
        {
            InitializeComponent();


            chartAnalysis.Legends[0].Name = legendPieName;
            chartAnalysis.Legends[0].Enabled = false;

            chartAnalysis.Series[0].Name = chartPieName;
            chartAnalysis.Series[chartPieName].ChartType = SeriesChartType.Pie;
            chartAnalysis.Series[chartPieName].IsValueShownAsLabel = false;   //设置为true则不会显示文字
            chartAnalysis.Series[chartPieName].Label = "#VALX: #VAL分钟";
            chartAnalysis.Series[chartPieName]["PieLabelStyle"] = "Outside";  //将文字移到外侧
            chartAnalysis.Series[chartPieName]["PieLineColor"] = "Blue";      //绘制黑色的连线

            rdoPie.Checked = true ; // 默认是饼状图
        }

       
        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            AccessHelper accessHelper = new AccessHelper();
            DataTable d = accessHelper.getDaysTable(dtpBeginTime.Value, dtpEndTime.Value);
            LoadChartPie(d);        
        }



        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rdoBar.Checked)
            {
                chartAnalysis.Series[chartPieName].ChartType = SeriesChartType.Bar;
            }
            else if (rdoColumn.Checked)
            {
                chartAnalysis.Series[chartPieName].ChartType = SeriesChartType.Column;

            }
            else if (rdoPie.Checked)
            {
                chartAnalysis.Series[chartPieName].ChartType = SeriesChartType.Pie;
            }
            else if (rdoDoughnut.Checked)
            {
                chartAnalysis.Series[chartPieName].ChartType = SeriesChartType.Doughnut;
            }
            else if (rdoFunnel.Checked)
            {
                chartAnalysis.Series[chartPieName].ChartType = SeriesChartType.Funnel;
            }
            else if (rdoPyramid.Checked)
            {
                chartAnalysis.Series[chartPieName].ChartType = SeriesChartType.Pyramid;
            }
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
                yTimeSpanData.Add((int)item.Value.TotalMinutes);
            }

            //TODO: 累计多少时间没被记录
            //int minutesOfUnRecord = 60 * 24;
            //if (minutesOfUnRecord != 0)
            //{
            //    xLbaelData.Add("未记录");
            //    yTimeSpanData.Add(minutesOfUnRecord);
            //}

            chartAnalysis.Series[chartPieName].Points.DataBindXY(xLbaelData, yTimeSpanData);
            chartAnalysis.Series[chartPieName].XValueType = ChartValueType.String;

        }
    }
}


