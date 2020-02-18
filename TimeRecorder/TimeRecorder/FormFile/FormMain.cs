using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using System.ComponentModel;
using System.IO;
using System.Media;
using System.Drawing;

namespace TimeRecorder
{
    public partial class FormMain : Form
    {
        #region 数据定义

        string  dataTableName = GlobalData.dataTableName, 
                labelTableName = GlobalData.labelTabelName,
                firstLabelColumnName = GlobalData.firstLabelColumnName, 
                secondLabelColumnName = GlobalData.secondLabelColumnName,
                dateColumnName = GlobalData.dateColumnName, 
                beginTimeColumnName = GlobalData.beginTimeColumnName,
                endTimeColumnName = GlobalData.endTimeColumnName, 
                noteColumnName = GlobalData.noteColumnName;

        static string filePath = "Provider = Microsoft.ACE.OLEDB.12.0;  Data source = TimeRecorderData.accdb";

        static OleDbConnection connection = new OleDbConnection(filePath);
        static OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
        OleDbCommand command;
        OleDbCommandBuilder builder = new OleDbCommandBuilder(dataAdapter);
        DataSet myDataSet = new DataSet("MyDataSet");

        int secondsOfMinutes;

        #endregion



        #region 日期变化相关

        public FormMain()
        {
            InitializeComponent();
            InitFormControlsProperties();
            LoadDgvShow(DateTime.Now);
            setDtpBeginTime();
            setDateTimePicker_MaxAndMin();
            LoadLabelTable();
            fillcboFirstLbl();
            refreshFormSummary();

        }

        private void InitFormControlsProperties()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            myDataSet.Tables.Add(dataTableName);
            //builder.ConflictOption = ConflictOption.OverwriteChanges;
            //builder.SetAllValues = false;

            dgvShow.AllowUserToResizeRows = false;
            dgvShow.ImeMode = ImeMode.On;

            mcMain.MaxDate = mcMain.TodayDate;
            mcMain.MaxSelectionCount = 1;

            dTPBeginTime.Format = DateTimePickerFormat.Custom;
            dTPBeginTime.CustomFormat = "MM月dd日  HH:mm";
            dTPBeginTime.MaxDate = mcMain.SelectionStart.AddDays(1);  //为了能录入所有当天的时间
            dTPBeginTime.MinDate = new DateTime();
            dTPBeginTime.ShowUpDown = true;

            dTPEndTime.Format = DateTimePickerFormat.Custom;
            dTPEndTime.CustomFormat = "MM月dd日  HH:mm";
            dTPEndTime.MaxDate = mcMain.SelectionStart.AddDays(1);
            dTPBeginTime.MinDate = new DateTime();
            dTPEndTime.ShowUpDown = true;
            dTPBeginTime.MouseWheel += new MouseEventHandler(this.dateTimePicker_MouseWheel);
            dTPEndTime.MouseWheel += new MouseEventHandler(this.dateTimePicker_MouseWheel);

            cboFirstLbl.ImeMode = ImeMode.On;
            cboSecondLbl.ImeMode = ImeMode.On;
            cboFirstLbl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboSecondLbl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            txtNote.ImeMode = ImeMode.On;

            timerTomato.Interval = 1000;  //timer以毫秒为单位  秒，毫秒，微妙，纳秒
            timerTomato.Enabled = false;
            numericUpDownCountDown.Minimum = 1;
            numericUpDownCountDown.Maximum = 30;
            numericUpDownCountDown.Value = 25;
            numericUpDownCountDown.TextAlign = HorizontalAlignment.Center;
            dtpCountdownBegin.Format = DateTimePickerFormat.Custom;
            dtpCountdownEnd.Format = DateTimePickerFormat.Custom;

            dtpCountdownEnd.CustomFormat = "HH:mm";
            dtpCountdownBegin.CustomFormat = "HH:mm";


        }

        private void SetHelpProvider()
        {
            helpProviderMain.SetShowHelp(btnYesterday, true);
            helpProviderMain.SetHelpString(btnYesterday, "后退一日");
            helpProviderMain.SetHelpString(btnToday, "回到今日");
            helpProviderMain.SetHelpString(btnTomorrow, "前进一日");
        }

        private void setDateTimePicker_MaxAndMin()
        {
            //设置最大和最小值，为了避免出现 MinDate > MaxDate 或者 MinDate < MaxDate的情况，分开设置
            if (mcMain.SelectionStart < dTPBeginTime.Value)
            {
                dTPBeginTime.MinDate = mcMain.SelectionStart;
                dTPBeginTime.MaxDate = mcMain.SelectionStart.AddDays(1);

                dTPEndTime.MinDate = mcMain.SelectionStart;
                dTPEndTime.MaxDate = mcMain.SelectionStart.AddDays(1);

            }
            else
            {
                dTPBeginTime.MaxDate = mcMain.SelectionStart.AddDays(1);
                dTPBeginTime.MinDate = mcMain.SelectionStart;

                dTPEndTime.MaxDate = mcMain.SelectionStart.AddDays(1);
                dTPEndTime.MinDate = mcMain.SelectionStart;
            }
        }

        private void LoadDgvShow(DateTime dt)
        {
            string sql = String.Format("select * from {0} where {1} = #{2}#", dataTableName, dateColumnName, dt.ToString("yyyy/MM/dd"));
            // 日期类型的两边要加#
            connection.Open();
            command = new OleDbCommand(sql, connection);
            dataAdapter.SelectCommand = command;

            myDataSet.Tables[dataTableName].Clear();//清空数据，否则会叠加数据
            dataAdapter.Fill(myDataSet, dataTableName);
            connection.Close();

            dgvShow.DataSource = myDataSet.Tables[dataTableName];
            dgvShow.Columns[0].Visible = false;  //ID列隐藏
            dgvShow.Columns[dateColumnName].Visible = false;  //日期列隐藏
            dgvShow.Columns[beginTimeColumnName].DefaultCellStyle.Format = "HH:mm";  //开始时间列  小写的hh会将13:00显示为 1:00，即12小时制
            dgvShow.Columns[beginTimeColumnName].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvShow.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;//开始时间4个字变成一列字了
            dgvShow.Columns[beginTimeColumnName].Width = 75;  //两行两列

            dgvShow.Columns[endTimeColumnName].DefaultCellStyle.Format = "HH:mm";  //结束时间列
            dgvShow.Columns[endTimeColumnName].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvShow.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvShow.Columns[endTimeColumnName].Width = 75;


            dgvShow.Columns[firstLabelColumnName].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; //一级标签列
            dgvShow.Columns[secondLabelColumnName].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; //二级标签列

            dgvShow.Columns[dgvShow.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvShow.Sort(dgvShow.Columns[2], ListSortDirection.Ascending); //按开始时间的升序排序

            //TODO：根据一级标签设置颜色


        }

        private void setDtpBeginTime()
        {
            int num = myDataSet.Tables[dataTableName].Rows.Count;
            if (num > 0)
            {
                dTPBeginTime.Value = DateTime.Parse(myDataSet.Tables[dataTableName].Rows[num - 1][endTimeColumnName].ToString());
                dTPEndTime.Value = dTPBeginTime.Value;
                dTPEndTime.Focus();
            }
            else
            {
                dTPBeginTime.Value = mcMain.SelectionStart;
            }
        }

        private void LoadLabelTable()
        {
            string sql = string.Format("select * from {0}", labelTableName);
            connection.Open();
            command = new OleDbCommand(sql, connection);
            OleDbDataAdapter labelDatapter = new OleDbDataAdapter();
            labelDatapter.SelectCommand = command;
            OleDbCommandBuilder labelBuilder = new OleDbCommandBuilder(labelDatapter);
            labelDatapter.Fill(myDataSet, labelTableName);
            connection.Close();
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.A: saveToDataBase(); break;
                    case Keys.Left: btnYesterday.PerformClick(); break;
                    case Keys.Right: btnTomorrow.PerformClick(); break;

                    default:
                        break;
                }
            }

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            refreshFormSummary();
        }

        private void mcMain_DateChanged(object sender, DateRangeEventArgs e)
        {
            setDateTimePicker_MaxAndMin();
            LoadDgvShow(mcMain.SelectionStart);
            setDtpBeginTime();
            refreshFormSummary();

        }

        private void btnYesterday_Click(object sender, EventArgs e)
        {
            mcMain.SelectionStart = mcMain.SelectionStart.AddDays(-1);
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            mcMain.SelectionStart = mcMain.TodayDate;
        }

        private void btnTomorrow_Click(object sender, EventArgs e)
        {
            if (mcMain.SelectionStart < mcMain.MaxDate)
            {
                mcMain.SelectionStart = mcMain.SelectionStart.AddDays(1);
            }
        }


        #endregion



        #region 录入相关

        private void dateTimePicker_MouseWheel(object sender, MouseEventArgs e)
        {

            //当 e.Delta > 0 时鼠标滚轮是向上滚动，e.Delta < 0 时鼠标滚轮向下滚动。
            if (e.Delta < 0)//鼠标滚动轴往下滚
            {
                SendKeys.Send("{Down}");
            }
            else // 鼠标滚动轴 往上滚
            {
                SendKeys.Send("{Up}");
            }

        }

        private void fillcboFirstLbl()
        {
            cboFirstLbl.Items.Clear();
            HashSet<string> firstLblSet = new HashSet<string>();   //定义集合是为了避免重复
            foreach (DataRow item in myDataSet.Tables[labelTableName].Rows)
            {
                firstLblSet.Add(item[firstLabelColumnName].ToString());
            }
            foreach (var n in firstLblSet)
            {
                cboFirstLbl.Items.Add(n);
            }

        }

        private void cboFirstLbl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //选择某个一级标签后，用一级标签的子标签 填充二级标签下拉框
            cboSecondLbl.Items.Clear();
            HashSet<string> secondLblSet = new HashSet<string>();
            foreach (DataRow item in myDataSet.Tables[labelTableName].Rows)
            {
                if (item[firstLabelColumnName].ToString() == cboFirstLbl.Text)
                {
                    cboSecondLbl.Items.Add(item[secondLabelColumnName]);
                }
            }
            cboSecondLbl.SelectedIndex = 0; //改变一级标签后，默认选中第二项
        }

        private void cboSecondLbl_TextChanged(object sender, EventArgs e)
        {
            string fatherLabel = null;  //必须要设置成null，否则在FindString过程 index返回0（原因不明
            string secondLabelText = cboSecondLbl.Text;
            //根据二级标签选定一级标签
            foreach (DataRow item in myDataSet.Tables[labelTableName].Rows)
            {
                if (item[secondLabelColumnName].ToString() == cboSecondLbl.Text)
                {
                    fatherLabel = item[firstLabelColumnName].ToString();
                    break;
                }
            }

            int index = cboFirstLbl.FindString(fatherLabel);
            if (index > -1)
            {
                cboFirstLbl.SelectedIndex = index;
                cboSecondLbl.Text = secondLabelText;
            }
        }

        private void btnAddTodgv_Click(object sender, EventArgs e)
        {
            DataRow newDataRow = myDataSet.Tables[dataTableName].NewRow();
            newDataRow[dateColumnName] = mcMain.SelectionStart.ToString("yyyy-MM-dd");
            //建议不要用.Text，会将00:00 变成后一天的开始时间

            newDataRow[beginTimeColumnName] = deleteSeconds(dTPBeginTime.Value);  
            newDataRow[endTimeColumnName] = deleteSeconds(dTPEndTime.Value);
            newDataRow[firstLabelColumnName] = cboFirstLbl.Text;
            newDataRow[secondLabelColumnName] = cboSecondLbl.Text;
            newDataRow[noteColumnName] = txtNote.Text;
            myDataSet.Tables[dataTableName].Rows.Add(newDataRow);

            saveToDataBase();
            dTPBeginTime.Value = dTPEndTime.Value;
            txtNote.Clear();
            dTPEndTime.Focus();

        }

        private DateTime deleteSeconds(DateTime dt) {
            return DateTime.Parse(dt.ToString("yyyy-MM-dd HH:mm"));
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            //功能：根据备注来选定一级标签和二级标签
            //原理：将备注分割成单词，然后循环在标签表的备注里匹配
            if (string.IsNullOrWhiteSpace(txtNote.Text))
            {
                return;  //防止删除文本后，标签设置为空
            }
            string[] wordsOfNote = txtNote.Text.ToLower().Split(' '); //将备注的单词分割，不能用双引号，因为参数是char类型，而“”是string类型

            foreach (DataRow item in myDataSet.Tables[labelTableName].Rows)
            {
                string[] wordsOfDescribe = item[noteColumnName].ToString().ToLower().Split(' ');  //标签每行的备注的单词集合
                foreach (string n in wordsOfNote)
                {
                    foreach (string d in wordsOfDescribe)
                    {
                        if (n == d)  //匹配成功，开始选择一级和二级标签
                        {
                            string first = item[firstLabelColumnName].ToString();
                            int indexOfFirstLabel = cboFirstLbl.FindString(first);
                            cboFirstLbl.SelectedIndex = indexOfFirstLabel;

                            string second = item[secondLabelColumnName].ToString();
                            int indexOfSecondLabel = cboSecondLbl.FindString(second);
                            cboSecondLbl.SelectedIndex = indexOfSecondLabel;
                        }
                    }
                }

            }

        }

        private void enter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void dTPEndTime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNote.Focus();
            }
        }


        private void btnAddUnRecord_Click(object sender, EventArgs e)
        {

        }

        private void dgvShow_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            //saveToDataBase();
            try
            {
                dgvShow.EndEdit();
                myDataSet.GetChanges();
                dataAdapter.Update(myDataSet.Tables[dataTableName]);

            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show(ex.ToString(), "原始数据已更改，请重做更新", MessageBoxButtons.OK);
                dataAdapter.Fill(myDataSet);
            }
        }

        private void saveToDataBase()
        {
            try
            {
                dataAdapter.Update(myDataSet.Tables[dataTableName]);
                refreshFormSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "保存失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion



        #region 菜单栏点击事件

        private void tsmAbout_Click(object sender, EventArgs e)
        {
            FormAbout aboutForm = new FormAbout();
            aboutForm.ShowDialog();
        }

        private void tsmLabelModify_Click(object sender, EventArgs e)
        {
            FormLabel labelForm = new FormLabel();
            labelForm.Owner = this;

            if (labelForm.ShowDialog() == DialogResult.Cancel)
            {
                LoadLabelTable();
                fillcboFirstLbl();
            }
        }

        #endregion



        #region 番茄钟

        private void timerTomato_Tick(object sender, EventArgs e)
        {
            if (secondsOfMinutes > 0)
            {
                secondsOfMinutes--;
                lblCountdownLeft.Text = (secondsOfMinutes / 60).ToString();
            }
            else
            {
                btnStopCountdown.PerformClick();
            }
        }

        private void btnCountDown_Click(object sender, EventArgs e)
        {
            dtpCountdownBegin.Value = DateTime.Now;
            dtpCountdownEnd.Value = DateTime.Now.AddMinutes((int)numericUpDownCountDown.Value);
            dtpCountdownBegin.Enabled = false;
            dtpCountdownEnd.Enabled = false;
            lblCountdownLeft.Text = numericUpDownCountDown.Value.ToString();

            timerTomato.Enabled = true;
            timerTomato.Start();
            btnCountDown.Enabled = false;
            secondsOfMinutes = (int)numericUpDownCountDown.Value * 60;

        }



        private void tsmAnalysis_Click(object sender, EventArgs e)
        {
            FormAna formAna = new FormAna();
            formAna.ShowDialog();
        }

        private void btnDateChanged_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;//提示信息的可见时间
            toolTip1.InitialDelay = 500;//事件触发多久后出现提示
            toolTip1.ReshowDelay = 500;//指针从一个控件移向另一个控件时，经过多久才会显示下一个提示框
            toolTip1.ShowAlways = true;//是否显示提示框



            Button btnTemp = (Button)sender;
            switch (btnTemp.Name)
            {
                case "btnYesterday": toolTip1.SetToolTip(btnTemp, "后退一天"); break;  //设置提示按钮和提示内容 
                case "btnToday": toolTip1.SetToolTip(btnTemp, "回到今天"); break;
                case "btnTomorrow": toolTip1.SetToolTip(btnTemp, "前进一天"); break;

            }


        }



        private void btnStopCountdown_Click(object sender, EventArgs e)
        {
            if (secondsOfMinutes == 0)
            {
                SystemSounds.Beep.Play();  //Windows声音
                MessageBox.Show("倒计时结束了！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                timerTomato.Stop();
                btnCountDown.Enabled = true;
                timerTomato.Enabled = false;
                dTPBeginTime.Value = dtpCountdownBegin.Value;
                dTPEndTime.Value = dtpCountdownEnd.Value;
                btnAddTodgv.PerformClick();
            }
            else
            {
                SystemSounds.Beep.Play();  //Windows声音
                MessageBox.Show("倒计时结束了！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                timerTomato.Stop();
                btnCountDown.Enabled = true;
                timerTomato.Enabled = false;
            }

        }


        #endregion



        #region 任务栏事件
        private void tsmOpenRecordForm_Click(object sender, EventArgs e)
        {

        }


        private void tsmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmBeginCountdown_Click(object sender, EventArgs e)
        {
            btnCountDown.PerformClick();
        }

        private void tsmEndCountdown_Click(object sender, EventArgs e)
        {
            btnStopCountdown.PerformClick();
        }

        #endregion




        #region 今日总结-文档保存与加载

        string summaryDir = @"summary/";  //summary存放的目录
        string rtfExtison = ".rtf";
        string summaryFileName = String.Empty;
        string chartPieName = "饼状图", legendPieName = "饼状图图例";


        //以下是字体大小下拉框用的数据  设置数组保存下拉菜单上要显示的字号的大小,
        string[] fontSizeName = { "8", "9", "10", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72", "初号", "小初", "一号", "小一", "二号", "小二", "三号", "小三", "四号", "小四", "五号", "小五", "六号", "小六", "七号", "八号" };

        //利用榜和字号的关系定义一个字体大小的数组
        float[] fontSize = { 8, 9, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72, 42, 36, 26, 24, 22, 18, 16, 15, 14, 12, 10.5F, 9, 7.5F, 6.5F, 5.5F, 5 };

        public void FormTodaySummaryLoad()
        {
            fillCboFont();
            fillCboFontSize();
            rTxtTodaySummary.ImeMode = ImeMode.On;
            rTxtTodaySummary.AcceptsTab = true; //按下tab键则增加空格而不是切换到下一个控件
            rTxtTodaySummary.AutoWordSelection = true;

            //用来决定当焦点离开文本框后，选中的文本是否还以选中的方式显示
            //最好设置为false，否则改变字体、大小时不会显示选中的文本
            rTxtTodaySummary.HideSelection = false;

            chartAnalysis.AntiAliasing = AntiAliasingStyles.All; //文本和图形抗锯齿

            refreshFormSummary();
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

        private void refreshFormSummary()
        {
            LoadChartPie(myDataSet.Tables[dataTableName]);
            LoadSummary(mcMain.SelectionStart);
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
            Console.WriteLine(summaryFileName); 
            rTxtTodaySummary.SaveFile(summaryFileName);
            //如果是在TextChanged事件里用SaveFile方法，会报错：有另一个进程在使用
        }

        #endregion


        #region 富文本编辑

        private void rTxtTodaySummary_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("rtxtkeydown" + e.KeyCode);
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
    }

}




