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
        string summaryDir = @"summary/";  //summary存放的目录
        string rtfExtison = ".rtf";

        string filename;
        SaveFileDialog diaSavaFile;
        AccessHelper accessHelper;
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

            rdoPie.Checked = true; // 默认是饼状图

            diaSavaFile = new SaveFileDialog();
            accessHelper = new AccessHelper();

            diaSavaFile.Filter = ("Excel 文件(*.xls)|*.xlsx|Word 文件(*.doc*)|*.docx*");//后缀名。  
            diaSavaFile.AddExtension = true;
            diaSavaFile.RestoreDirectory = true;
            diaSavaFile.Title = "选择要导出的位置";

            cboShowType.ImeMode = ImeMode.On;
            String[] chartType = { "饼图", "条形图", "柱状图", "圆环图", "漏斗图", "棱锥图" }; 
            cboShowType.Items.AddRange(chartType);
        }



        #region 数据汇总选项卡

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            DataTable d = accessHelper.getDaysTable(dtpBeginTime.Value, dtpEndTime.Value);
            LoadChartPie(d);
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

        private void radioButton_Click(object sender, EventArgs e)
        {
            //TODO: 待优化
            RadioButton temp = (RadioButton)sender;
            var series = chartAnalysis.Series[chartPieName];
            switch (temp.Name)
            {
                case "rdoBar": series.ChartType = SeriesChartType.Bar; break;
                case "rdoColumn": series.ChartType = SeriesChartType.Column; break;
                case "rdoPie": series.ChartType = SeriesChartType.Pie; break;
                case "rdoDoughnut": series.ChartType = SeriesChartType.Doughnut; break;
                case "rdoFunnel": series.ChartType = SeriesChartType.Funnel; break;
                case "rdoPyramid": series.ChartType = SeriesChartType.Pyramid; break;
                default:
                    break;
            }
        }

        #endregion




        #region 每日分布选项卡

        private void btnEveryAnalysis_Click(object sender, EventArgs e)
        {
            DataTable d = accessHelper.getLabelTime(dtpEveryBeginTime.Value, dtpEveryEndTime.Value, "");
            LoadEveryChart(d);
        }

        public void LoadEveryChart(DataTable tableOfDay)
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

        private void checkBoxShowLegend_Click(object sender, EventArgs e)
        {
            bool temp = chartAnalysis.Legends[0].Enabled;
            chartAnalysis.Legends[0].Enabled = !temp;
        }

        private void checkBoxShow3D_Click(object sender, EventArgs e)
        {
            bool temp = chartAnalysis.ChartAreas[0].Area3DStyle.Enable3D;
            chartAnalysis.ChartAreas[0].Area3DStyle.Enable3D = !temp;
        }

        private void cboShowType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: 待优化
            var series = chartAnalysis.Series[chartPieName];
            String[] chartType = { "饼图", "条形图", "柱状图", "圆环图", "漏斗图", "棱锥图" };

            switch (cboShowType.Text)
            {
                case "饼图": series.ChartType = SeriesChartType.Pie; break;
                case "条形图": series.ChartType = SeriesChartType.Bar; break;
                case "柱状图": series.ChartType = SeriesChartType.Column; break;
                case "圆环图": series.ChartType = SeriesChartType.Doughnut; break;
                case "漏斗图": series.ChartType = SeriesChartType.Funnel; break;
                case "棱锥图": series.ChartType = SeriesChartType.Pyramid; break;
                case "ryramid": series.ChartType = SeriesChartType.Pyramid; break;
                case "rdyramid": series.ChartType = SeriesChartType.Pyramid; break;
                case "rdd": series.ChartType = SeriesChartType.Pyramid; break;
                default:
                    break;
            }
        }



        #endregion

        #region 数据导入导出选项卡


        #region 导出Excel数据

        private void btnIOFileDir_Click(object sender, EventArgs e)
        {
            if (diaSavaFile.ShowDialog() == DialogResult.OK)
            {
                filename = diaSavaFile.FileName;
            }
            txtIOFileDir.Text = filename;
        }


        private void btnIOExcelDaysAll_Click(object sender, EventArgs e)
        {
            //将全部数据导出到Excel，工作表分布：总表为全部数据的表，然后每个月的数据一张表
            try
            {
                bool isSuccess = false;
                if (string.IsNullOrEmpty(txtIOFileDir.Text))
                    isSuccess = accessHelper.exportAllDataToExcel();
                
                else
                    isSuccess = accessHelper.exportAllDataToExcel(filename);
  

                if (isSuccess)
                    MessageBox.Show("导出数据成功", "导出成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "导出失败！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        private void btnIOExcelDays_Click(object sender, EventArgs e)
        {
            try
            {
                string beginDate = dtpIOBeginDate.Value.ToShortDateString();
                string endDate = dtpIOEndDate.Value.ToShortDateString();

                bool isSuccess = false;
                if (string.IsNullOrEmpty(txtIOFileDir.Text))
                    isSuccess = accessHelper.exportDaysDataToExcel(dtpIOBeginDate.Value, dtpIOEndDate.Value);
                
                else
                    isSuccess = accessHelper.exportDaysDataToExcel(dtpIOBeginDate.Value, dtpIOEndDate.Value, filename);
                
                if (isSuccess)
                    MessageBox.Show("导出数据成功", "导出成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "导出失败！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnIOExcelLabel_Click(object sender, EventArgs e)
        {
            try
            {
                bool isSuccess = false;
                if (string.IsNullOrEmpty(txtIOFileDir.Text))
                    ;

                else
                    ;
                

                if (isSuccess)
                    MessageBox.Show("导出数据成功", "导出成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "导出失败！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion





        #region 导出Word日志

        private void btnIOWordDays_Click(object sender, EventArgs e)
        {
            //将指定日期的数据导出到word里，同时将每份总结的日期设为标题1

        }

        private void btnIOWordDaysAll_Click(object sender, EventArgs e)
        {
            //将全部总结导出到一个word文档里，同时将每份总结的日期设为标题1

        }

 


        #endregion


        #endregion




    }
}


