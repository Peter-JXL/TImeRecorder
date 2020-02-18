using System;
using System.Collections.Generic;
using System.Data;
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
        DataSet myDataSet;
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

            accessHelper = new AccessHelper();
            myDataSet = new DataSet();

            LoadLabelTable();
            fillcboFirstLbl();

            diaSavaFile = new SaveFileDialog();        
            diaSavaFile.Filter = ("Excel 文件(*.xls)|*.xlsx|Word 文件(*.doc*)|*.docx*");//后缀名。  
            diaSavaFile.AddExtension = true;
            diaSavaFile.RestoreDirectory = true;
            diaSavaFile.Title = "选择要导出的位置";

        }

        private void LoadLabelTable()
        {
            DataTable LabelTableName = accessHelper.getLabelTable().Copy();
            myDataSet.Tables.Add(LabelTableName);
        }

        private void fillcboFirstLbl()
        {
            cboShowFirstLabel.Items.Clear();
            HashSet<string> firstLblSet = new HashSet<string>();   //定义集合是为了避免重复
            foreach (DataRow item in myDataSet.Tables[LabelTableName].Rows)
            {
                firstLblSet.Add(item[firstLabelColumnName].ToString());
            }
            foreach (var n in firstLblSet)
            {
                cboShowFirstLabel.Items.Add(n);
            }

        }

        private void cboShowFirstLabel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //选择某个一级标签后，用一级标签的子标签 填充二级标签下拉框
            cboShowSecondLabel.Items.Clear();
            HashSet<string> secondLblSet = new HashSet<string>();
            foreach (DataRow item in myDataSet.Tables[LabelTableName].Rows)
            {
                if (item[firstLabelColumnName].ToString() == cboShowFirstLabel.Text)
                {
                    cboShowSecondLabel.Items.Add(item[secondLabelColumnName]);
                }
            }

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
            DataTable d = accessHelper.getDaysTable(dtpEveryBeginTime.Value, dtpEveryEndTime.Value);
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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string sql = String.Format("select * from {0} where {1} >#{2}# and {3} < #{4}#", 
                dataTableName, beginTimeColumnName, dtpShowBeginTIme.Value, endTimeColumnName, dtpShowSecondTIme.Value);

            if (! String.IsNullOrEmpty(cboShowFirstLabel.Text))
            {
                sql = string.Format("{0} and where {1} = {2}", sql, firstLabelColumnName, cboShowFirstLabel.Text);                
            }
            if(!String.IsNullOrEmpty(cboShowSecondLabel.Text))
            {
                sql = string.Format("{0} and where {1} = {2}", sql, secondLabelColumnName, cboShowSecondLabel.Text);
            }
            if (!String.IsNullOrEmpty(txtShowNote.Text))
            {
                sql = string.Format("{0} and where {1} like \'{2}\'", sql, noteColumnName, txtShowNote.Text);
            }
            Console.WriteLine(sql);
            DataTable t = accessHelper.GetDataTableWithSql(sql);
            dgvShow.DataSource = t;
        }

        private void btnIOExcelLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void btnExportToJPG_Click(object sender, EventArgs e)
        {
            //SaveFileDialog saveImgFileName = new SaveFileDialog();
            //saveImgFileName.Filter = "文本文件(*.png)|*.png|所有文件|*.*";//设置文件类型
            //string GR_Path = @"D:";
            //string fullFileName = GR_Path + "\\" + fileName + ".png";
            //sfd.FileName = "保存";//设置默认文件名
            //sfd.DefaultExt = "txt";//设置默认格式（可以不设）
            //sfd.AddExtension = true;//设置自动在文件名中添加扩展名
            //if (sfd.ShowDialog() == DialogResult.OK)
            //{
            //    txtPath.Text = "FileName:" + sfd.FileName + "\r\n";
            //    using (StreamWriter sw = new StreamWriter(sfd.FileName))
            //    {
            //        sw.WriteLineAsync("今天是个好天气");
            //    }
            //}

            //chart1.SaveImage(fullFileName, ChartImageFormat.Png);
            
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
            //txtIOFileDir.Text = filename;
        }


        private void btnIOExcelDaysAll_Click(object sender, EventArgs e)
        {
            //将全部数据导出到Excel，工作表分布：总表为全部数据的表，然后每个月的数据一张表
            //try
            //{
            //    bool isSuccess = false;
            //    if (string.IsNullOrEmpty(txtIOFileDir.Text))
            //        isSuccess = accessHelper.exportAllDataToExcel();
                
            //    else
            //        isSuccess = accessHelper.exportAllDataToExcel(filename);
  

            //    if (isSuccess)
            //        MessageBox.Show("导出数据成功", "导出成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "导出失败！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    throw;
            //}

        }

        private void btnIOExcelDays_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string beginDate = dtpIOBeginDate.Value.ToShortDateString();
            //    string endDate = dtpIOEndDate.Value.ToShortDateString();

            //    bool isSuccess = false;
            //    if (string.IsNullOrEmpty(txtIOFileDir.Text))
            //        isSuccess = accessHelper.exportDaysDataToExcel(dtpIOBeginDate.Value, dtpIOEndDate.Value);
                
            //    else
            //        isSuccess = accessHelper.exportDaysDataToExcel(dtpIOBeginDate.Value, dtpIOEndDate.Value, filename);
                
            //    if (isSuccess)
            //        MessageBox.Show("导出数据成功", "导出成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "导出失败！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }


        private void btnIOExcelLabel_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    bool isSuccess = false;
            //    if (string.IsNullOrEmpty(txtIOFileDir.Text))
            //        ;

            //    else
            //        ;
                

            //    if (isSuccess)
            //        MessageBox.Show("导出数据成功", "导出成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "导出失败！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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


