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
        int minutesOfDay = 60 * 24;
        string yearAndMonthTableName = DateTime.Now.ToString("yyyyMM");
        string LabelTableName = "标签表", firstLabelColumnName = "一级标签", secondLabelColumnName = "二级标签", describeColumnName = "描述";
        string dateColumnName = "日期", beginTimeColumnName = "开始时间", endTimeColumnName = "结束时间", noteColumnName = "备注";
        string chartPieName = "饼状图", legendPieName = "饼状图图例";
        string filePath = "Provider = Microsoft.ACE.OLEDB.12.0;Data source = userData.accdb";
        Dictionary<string, TimeSpan> dayDictionary = new Dictionary<string, TimeSpan>();

        public DataTable tableOfDay;

        OleDbConnection connection;
        OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
        DataSet myDataSet = new DataSet("MyDataSet");
        #endregion

        private void btnAna_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtpBeginTime.Value;
            DateTime endDate = dtpEndTime.Value;
        }



        public FormAna()
        {
            InitializeComponent();
        }

        private void FormAna_Load(object sender, EventArgs e)
        {
            myDataSet.Tables.Add(yearAndMonthTableName);
           

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

            int minutesOfUnRecord = minutesOfDay;
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
    }
}


