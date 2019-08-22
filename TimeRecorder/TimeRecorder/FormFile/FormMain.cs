﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using System.ComponentModel;
using System.IO;
using System.Media;

namespace TimeRecorder
{
    public partial class FormMain : Form
    {
        #region 数据定义
        string yearAndMonthTableName = DateTime.Now.ToString("yyyyMM");
        string LabelTableName = "标签表", firstLabelColumnName = "一级标签", secondLabelColumnName = "二级标签";
        string dateColumnName = "日期", beginTimeColumnName = "开始时间", endTimeColumnName = "结束时间", noteColumnName = "备注";
        string filePath = "Provider = Microsoft.ACE.OLEDB.12.0;  Data source = userData.accdb";

        OleDbConnection connection;
        OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
        DataSet myDataSet = new DataSet("MyDataSet");

        FormTodaySummary formSummary;
        int secondsOfMinutes;

        #endregion


        public FormMain()
        {
            InitializeComponent();
            formSummary = new FormTodaySummary();
            InitFormControlsProperties();
            LoadDgvShow(DateTime.Now);
            LoadLabelTable();
            fillcboFirstLbl();

            formSummary.tableOfDay = myDataSet.Tables[yearAndMonthTableName];
            formSummary.LoadChartPie(mcMain.SelectionStart);
            formSummary.LoadSummary(mcMain.SelectionStart);

        }

        private void InitFormControlsProperties()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            myDataSet.Tables.Add(yearAndMonthTableName);

            dgvShow.AllowUserToResizeRows = false;
            dgvShow.ImeMode = ImeMode.On;

            mcMain.MaxDate = mcMain.TodayDate;
            mcMain.MaxSelectionCount = 1;

            dTPBeginTime.Format = DateTimePickerFormat.Custom;
            dTPBeginTime.CustomFormat = "dd日  HH:mm";
            dTPBeginTime.MaxDate = mcMain.SelectionStart.AddDays(1);  //为了能录入所有当天的时间
            dTPBeginTime.MinDate = new DateTime();
            dTPBeginTime.ShowUpDown = true;

            dTPEndTime.Format = DateTimePickerFormat.Custom;
            dTPEndTime.CustomFormat = "dd日  HH:mm";
            dTPEndTime.MaxDate = mcMain.SelectionStart.AddDays(1);
            dTPBeginTime.MinDate = new DateTime();
            dTPEndTime.ShowUpDown = true;

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


            txtNote.ImeMode = ImeMode.On;

            cboFirstLbl.ImeMode = ImeMode.On;
            cboFirstLbl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboSecondLbl.ImeMode = ImeMode.On;
            cboSecondLbl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

        }

        private void SetHelpProvider()
        {
            helpProviderMain.SetShowHelp(btnYesterday, true);
            helpProviderMain.SetHelpString(btnYesterday, "后退一日");
            helpProviderMain.SetHelpString(btnToday, "回到今日");
            helpProviderMain.SetHelpString(btnTomorrow, "前进一日");
        }

        private void LoadDgvShow(DateTime dt)
        {
            string sql = String.Format("select * from {0} where {1} = #{2}#", yearAndMonthTableName, dateColumnName, dt.ToString("yyyy/MM/dd"));
            // 日期类型的两边要加#
            connection = new OleDbConnection(filePath);
            connection.Open();
            OleDbCommand command = new OleDbCommand(sql, connection);
            dataAdapter.SelectCommand = command;
            OleDbCommandBuilder builder = new OleDbCommandBuilder(dataAdapter);

            myDataSet.Tables[yearAndMonthTableName].Clear();//清空数据，否则会叠加数据
            dataAdapter.Fill(myDataSet, yearAndMonthTableName);
            connection.Close();

            dgvShow.DataSource = myDataSet.Tables[yearAndMonthTableName];
            dgvShow.Columns[0].Visible = false;  //ID列隐藏
            dgvShow.Columns[1].Visible = false;  //日期列隐藏
            dgvShow.Columns[2].DefaultCellStyle.Format = "HH:mm";  //开始时间列  小写的hh会将13:00显示为 1:00，即12小时制
            dgvShow.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvShow.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;//开始时间4个字变成一列字了
            dgvShow.Columns[2].Width = 75;  //两行两列

            dgvShow.Columns[3].DefaultCellStyle.Format = "HH:mm";  //结束时间列
            dgvShow.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvShow.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvShow.Columns[3].Width = 75;


            dgvShow.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; //一级标签列
            dgvShow.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; //二级标签列

            dgvShow.Columns[dgvShow.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvShow.Sort(dgvShow.Columns[2], ListSortDirection.Ascending); //按开始时间的升序排序
                                                                           //foreach (DataRow item in dgvShow.Rows)
                                                                           //{
                                                                           //    //TODO：根据一级标签设置颜色
                                                                           //    //if(item.ha)
                                                                           //}


        }

        private void LoadLabelTable()
        {
            string sql = string.Format("select * from {0}", LabelTableName);
            connection = new OleDbConnection(filePath);
            connection.Open();
            OleDbCommand command = new OleDbCommand(sql, connection);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = command;
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.Fill(myDataSet, LabelTableName);
            connection.Close();
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.S: btnSave.PerformClick(); break;
                    case Keys.Left: btnYesterday.PerformClick(); break;
                    case Keys.Right: btnTomorrow.PerformClick(); break;

                    default:
                        break;
                }
            }

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void mcMain_DateChanged(object sender, DateRangeEventArgs e)
        {
            dTPBeginTime.MaxDate = mcMain.SelectionStart.AddDays(1);
            dTPBeginTime.Value = mcMain.SelectionStart;

            dTPEndTime.MaxDate = mcMain.SelectionStart.AddDays(1);
            dTPEndTime.Value = mcMain.SelectionStart;

            LoadDgvShow(mcMain.SelectionStart);

            formSummary.tableOfDay = myDataSet.Tables[yearAndMonthTableName];
            formSummary.LoadChartPie(mcMain.SelectionStart);
            formSummary.LoadSummary(mcMain.SelectionStart);

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

        #region 录入相关

        private void fillcboFirstLbl()
        {
            cboFirstLbl.Items.Clear();
            HashSet<string> firstLblSet = new HashSet<string>();   //定义集合是为了避免重复
            foreach (DataRow item in myDataSet.Tables[LabelTableName].Rows)
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
            foreach (DataRow item in myDataSet.Tables[LabelTableName].Rows)
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
            string fatherLabel = null;  //必须要设置成null，否则在FIndString过程 index返回0（原因不明
            //根据二级标签选定一级标签
            foreach (DataRow item in myDataSet.Tables[LabelTableName].Rows)
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
            }
        }

        private void btnAddTodgv_Click(object sender, EventArgs e)
        {
            DataRow newDataRow = myDataSet.Tables[yearAndMonthTableName].NewRow();
            newDataRow[dateColumnName] = mcMain.SelectionStart.ToString("yyyy-MM-dd");
            newDataRow[beginTimeColumnName] = dTPBeginTime.Value;  //建议不要用.Text，会将00:00 变成后一天的开始时间
            newDataRow[endTimeColumnName] = dTPEndTime.Value;
            newDataRow[firstLabelColumnName] = cboFirstLbl.Text;
            newDataRow[secondLabelColumnName] = cboSecondLbl.Text;
            newDataRow[noteColumnName] = txtNote.Text;
            myDataSet.Tables[yearAndMonthTableName].Rows.Add(newDataRow);

            btnSave.PerformClick();
            dTPBeginTime.Value = dTPEndTime.Value;
            txtNote.Clear();
            dTPEndTime.Focus();

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

            foreach (DataRow item in myDataSet.Tables[LabelTableName].Rows)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                dataAdapter.Update(myDataSet.Tables[yearAndMonthTableName]);

                //MessageBox.Show("保存成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "保存失败", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dgvShow_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.PerformClick();
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
            
            if(labelForm.ShowDialog() == DialogResult.Cancel)
            {
                LoadLabelTable();
                fillcboFirstLbl();
            }
        }

        private void tsmShowSummary_Click(object sender, EventArgs e)
        {
            formSummary.Show();
            formSummary.Focus();
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




    }

}
