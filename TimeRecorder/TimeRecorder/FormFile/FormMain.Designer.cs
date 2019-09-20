namespace TimeRecorder
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnAddTodgv = new System.Windows.Forms.Button();
            this.lblBeginTime = new System.Windows.Forms.Label();
            this.helpProviderMain = new System.Windows.Forms.HelpProvider();
            this.mcMain = new System.Windows.Forms.MonthCalendar();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblFirstLabel = new System.Windows.Forms.Label();
            this.lblSecondLabel = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowSummary = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLabelModify = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAboutLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.cboFirstLbl = new System.Windows.Forms.ComboBox();
            this.cboSecondLbl = new System.Windows.Forms.ComboBox();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelRecord = new System.Windows.Forms.Panel();
            this.btnAddUnRecord = new System.Windows.Forms.Button();
            this.dTPEndTime = new System.Windows.Forms.DateTimePicker();
            this.dTPBeginTime = new System.Windows.Forms.DateTimePicker();
            this.timerTomato = new System.Windows.Forms.Timer(this.components);
            this.numericUpDownCountDown = new System.Windows.Forms.NumericUpDown();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.btnCountDown = new System.Windows.Forms.Button();
            this.btnStopCountdown = new System.Windows.Forms.Button();
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmOpenRecordForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBeginCountdown = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEndCountdown = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panelF = new System.Windows.Forms.Panel();
            this.lblCountdownLeft = new System.Windows.Forms.Label();
            this.dtpCountdownEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpCountdownBegin = new System.Windows.Forms.DateTimePicker();
            this.lblExplainCountdownLeft = new System.Windows.Forms.Label();
            this.lblExplainCountdownEnd = new System.Windows.Forms.Label();
            this.lblExplainCountdownBegin = new System.Windows.Forms.Label();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnTomorrow = new System.Windows.Forms.Button();
            this.btnYesterday = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.statusStripMain.SuspendLayout();
            this.panelRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountDown)).BeginInit();
            this.contextMenuStripIcon.SuspendLayout();
            this.panelF.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddTodgv
            // 
            this.btnAddTodgv.Location = new System.Drawing.Point(27, 265);
            this.btnAddTodgv.Name = "btnAddTodgv";
            this.btnAddTodgv.Size = new System.Drawing.Size(74, 35);
            this.btnAddTodgv.TabIndex = 5;
            this.btnAddTodgv.Text = "添加";
            this.btnAddTodgv.UseVisualStyleBackColor = true;
            this.btnAddTodgv.Click += new System.EventHandler(this.btnAddTodgv_Click);
            // 
            // lblBeginTime
            // 
            this.lblBeginTime.AutoSize = true;
            this.lblBeginTime.Location = new System.Drawing.Point(3, 26);
            this.lblBeginTime.Name = "lblBeginTime";
            this.lblBeginTime.Size = new System.Drawing.Size(83, 21);
            this.lblBeginTime.TabIndex = 4;
            this.lblBeginTime.Text = "开始时间 :";
            // 
            // mcMain
            // 
            this.mcMain.Location = new System.Drawing.Point(8, 14);
            this.mcMain.Name = "mcMain";
            this.mcMain.TabIndex = 6;
            this.mcMain.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcMain_DateChanged);
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(3, 74);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(83, 21);
            this.lblEndTime.TabIndex = 8;
            this.lblEndTime.Text = "结束时间 :";
            // 
            // lblFirstLabel
            // 
            this.lblFirstLabel.AutoSize = true;
            this.lblFirstLabel.Location = new System.Drawing.Point(3, 121);
            this.lblFirstLabel.Name = "lblFirstLabel";
            this.lblFirstLabel.Size = new System.Drawing.Size(83, 21);
            this.lblFirstLabel.TabIndex = 10;
            this.lblFirstLabel.Text = "一级标签 :";
            // 
            // lblSecondLabel
            // 
            this.lblSecondLabel.AutoSize = true;
            this.lblSecondLabel.Location = new System.Drawing.Point(3, 168);
            this.lblSecondLabel.Name = "lblSecondLabel";
            this.lblSecondLabel.Size = new System.Drawing.Size(83, 21);
            this.lblSecondLabel.TabIndex = 12;
            this.lblSecondLabel.Text = "二级标签 :";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(3, 217);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(51, 21);
            this.lblNote.TabIndex = 14;
            this.lblNote.Text = "备注 :";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(70, 214);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(250, 29);
            this.txtNote.TabIndex = 4;
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_TextChanged);
            this.txtNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter_KeyDown);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmLabel,
            this.帮助ToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1227, 25);
            this.menuStripMain.TabIndex = 16;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowSummary,
            this.tsmAnalysis});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.tsmFile.Size = new System.Drawing.Size(58, 21);
            this.tsmFile.Text = "文件(&F)";
            // 
            // tsmShowSummary
            // 
            this.tsmShowSummary.Name = "tsmShowSummary";
            this.tsmShowSummary.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.tsmShowSummary.Size = new System.Drawing.Size(157, 22);
            this.tsmShowSummary.Text = "每日总结表";
            this.tsmShowSummary.Click += new System.EventHandler(this.tsmShowSummary_Click);
            // 
            // tsmAnalysis
            // 
            this.tsmAnalysis.Name = "tsmAnalysis";
            this.tsmAnalysis.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.tsmAnalysis.Size = new System.Drawing.Size(157, 22);
            this.tsmAnalysis.Text = "分析窗口";
            this.tsmAnalysis.Click += new System.EventHandler(this.tsmAnalysis_Click);
            // 
            // tsmLabel
            // 
            this.tsmLabel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLabelModify});
            this.tsmLabel.Name = "tsmLabel";
            this.tsmLabel.Size = new System.Drawing.Size(82, 21);
            this.tsmLabel.Text = "标签管理(&L)";
            // 
            // tsmLabelModify
            // 
            this.tsmLabelModify.Name = "tsmLabelModify";
            this.tsmLabelModify.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.tsmLabelModify.Size = new System.Drawing.Size(145, 22);
            this.tsmLabelModify.Text = "标签修改";
            this.tsmLabelModify.Click += new System.EventHandler(this.tsmLabelModify_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAbout,
            this.tsmAboutLanguage});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // tsmAbout
            // 
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(138, 22);
            this.tsmAbout.Text = "关于(&A)...";
            this.tsmAbout.Click += new System.EventHandler(this.tsmAbout_Click);
            // 
            // tsmAboutLanguage
            // 
            this.tsmAboutLanguage.Name = "tsmAboutLanguage";
            this.tsmAboutLanguage.Size = new System.Drawing.Size(138, 22);
            this.tsmAboutLanguage.Text = "关于语言(&L)";
            // 
            // cboFirstLbl
            // 
            this.cboFirstLbl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboFirstLbl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboFirstLbl.FormattingEnabled = true;
            this.cboFirstLbl.Location = new System.Drawing.Point(97, 118);
            this.cboFirstLbl.Name = "cboFirstLbl";
            this.cboFirstLbl.Size = new System.Drawing.Size(121, 29);
            this.cboFirstLbl.TabIndex = 3;
            this.cboFirstLbl.SelectedIndexChanged += new System.EventHandler(this.cboFirstLbl_SelectedIndexChanged);
            this.cboFirstLbl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter_KeyDown);
            // 
            // cboSecondLbl
            // 
            this.cboSecondLbl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSecondLbl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSecondLbl.FormattingEnabled = true;
            this.cboSecondLbl.Location = new System.Drawing.Point(97, 168);
            this.cboSecondLbl.Name = "cboSecondLbl";
            this.cboSecondLbl.Size = new System.Drawing.Size(121, 29);
            this.cboSecondLbl.TabIndex = 4;
            this.cboSecondLbl.TextChanged += new System.EventHandler(this.cboSecondLbl_TextChanged);
            this.cboSecondLbl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter_KeyDown);
            // 
            // dgvShow
            // 
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Location = new System.Drawing.Point(12, 60);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowTemplate.Height = 23;
            this.dgvShow.Size = new System.Drawing.Size(608, 530);
            this.dgvShow.TabIndex = 17;
            this.dgvShow.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShow_CellEndEdit);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStripMain.Location = new System.Drawing.Point(0, 628);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1227, 25);
            this.statusStripMain.TabIndex = 18;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 20);
            this.toolStripStatusLabel1.Text = "当前操作:";
            // 
            // panelRecord
            // 
            this.panelRecord.Controls.Add(this.btnAddUnRecord);
            this.panelRecord.Controls.Add(this.dTPEndTime);
            this.panelRecord.Controls.Add(this.dTPBeginTime);
            this.panelRecord.Controls.Add(this.cboSecondLbl);
            this.panelRecord.Controls.Add(this.btnAddTodgv);
            this.panelRecord.Controls.Add(this.lblBeginTime);
            this.panelRecord.Controls.Add(this.lblEndTime);
            this.panelRecord.Controls.Add(this.lblFirstLabel);
            this.panelRecord.Controls.Add(this.cboFirstLbl);
            this.panelRecord.Controls.Add(this.lblSecondLabel);
            this.panelRecord.Controls.Add(this.txtNote);
            this.panelRecord.Controls.Add(this.lblNote);
            this.panelRecord.Location = new System.Drawing.Point(634, 259);
            this.panelRecord.Name = "panelRecord";
            this.panelRecord.Size = new System.Drawing.Size(323, 332);
            this.panelRecord.TabIndex = 0;
            // 
            // btnAddUnRecord
            // 
            this.btnAddUnRecord.Location = new System.Drawing.Point(186, 265);
            this.btnAddUnRecord.Name = "btnAddUnRecord";
            this.btnAddUnRecord.Size = new System.Drawing.Size(134, 35);
            this.btnAddUnRecord.TabIndex = 20;
            this.btnAddUnRecord.Text = "添加未记录时间";
            this.btnAddUnRecord.UseVisualStyleBackColor = true;
            this.btnAddUnRecord.Click += new System.EventHandler(this.btnAddUnRecord_Click);
            // 
            // dTPEndTime
            // 
            this.dTPEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPEndTime.Location = new System.Drawing.Point(97, 68);
            this.dTPEndTime.Name = "dTPEndTime";
            this.dTPEndTime.Size = new System.Drawing.Size(150, 29);
            this.dTPEndTime.TabIndex = 2;
            this.dTPEndTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter_KeyDown);
            // 
            // dTPBeginTime
            // 
            this.dTPBeginTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPBeginTime.Location = new System.Drawing.Point(97, 20);
            this.dTPBeginTime.Name = "dTPBeginTime";
            this.dTPBeginTime.Size = new System.Drawing.Size(150, 29);
            this.dTPBeginTime.TabIndex = 1;
            this.dTPBeginTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter_KeyDown);
            // 
            // timerTomato
            // 
            this.timerTomato.Tick += new System.EventHandler(this.timerTomato_Tick);
            // 
            // numericUpDownCountDown
            // 
            this.numericUpDownCountDown.Location = new System.Drawing.Point(19, 61);
            this.numericUpDownCountDown.Name = "numericUpDownCountDown";
            this.numericUpDownCountDown.Size = new System.Drawing.Size(107, 29);
            this.numericUpDownCountDown.TabIndex = 19;
            // 
            // lblCountDown
            // 
            this.lblCountDown.AutoSize = true;
            this.lblCountDown.Location = new System.Drawing.Point(132, 63);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(42, 21);
            this.lblCountDown.TabIndex = 20;
            this.lblCountDown.Text = "分钟";
            // 
            // btnCountDown
            // 
            this.btnCountDown.Location = new System.Drawing.Point(19, 3);
            this.btnCountDown.Name = "btnCountDown";
            this.btnCountDown.Size = new System.Drawing.Size(98, 35);
            this.btnCountDown.TabIndex = 21;
            this.btnCountDown.Text = "开始倒计时";
            this.btnCountDown.UseVisualStyleBackColor = true;
            this.btnCountDown.Click += new System.EventHandler(this.btnCountDown_Click);
            // 
            // btnStopCountdown
            // 
            this.btnStopCountdown.Location = new System.Drawing.Point(136, 3);
            this.btnStopCountdown.Name = "btnStopCountdown";
            this.btnStopCountdown.Size = new System.Drawing.Size(54, 35);
            this.btnStopCountdown.TabIndex = 22;
            this.btnStopCountdown.Text = "结束";
            this.btnStopCountdown.UseVisualStyleBackColor = true;
            this.btnStopCountdown.Click += new System.EventHandler(this.btnStopCountdown_Click);
            // 
            // notifyIconMain
            // 
            this.notifyIconMain.ContextMenuStrip = this.contextMenuStripIcon;
            this.notifyIconMain.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMain.Icon")));
            this.notifyIconMain.Text = "TimeRecorder";
            this.notifyIconMain.Visible = true;
            // 
            // contextMenuStripIcon
            // 
            this.contextMenuStripIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOpenRecordForm,
            this.tsmBeginCountdown,
            this.tsmEndCountdown,
            this.tsmExit});
            this.contextMenuStripIcon.Name = "contextMenuStripIcon";
            this.contextMenuStripIcon.Size = new System.Drawing.Size(149, 92);
            // 
            // tsmOpenRecordForm
            // 
            this.tsmOpenRecordForm.Name = "tsmOpenRecordForm";
            this.tsmOpenRecordForm.Size = new System.Drawing.Size(148, 22);
            this.tsmOpenRecordForm.Text = "打开记录页面";
            this.tsmOpenRecordForm.Click += new System.EventHandler(this.tsmOpenRecordForm_Click);
            // 
            // tsmBeginCountdown
            // 
            this.tsmBeginCountdown.Name = "tsmBeginCountdown";
            this.tsmBeginCountdown.Size = new System.Drawing.Size(148, 22);
            this.tsmBeginCountdown.Text = "开始倒计时";
            this.tsmBeginCountdown.Click += new System.EventHandler(this.tsmBeginCountdown_Click);
            // 
            // tsmEndCountdown
            // 
            this.tsmEndCountdown.Name = "tsmEndCountdown";
            this.tsmEndCountdown.Size = new System.Drawing.Size(148, 22);
            this.tsmEndCountdown.Text = "结束倒计时";
            this.tsmEndCountdown.Click += new System.EventHandler(this.tsmEndCountdown_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(148, 22);
            this.tsmExit.Text = "退出";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // panelF
            // 
            this.panelF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelF.Controls.Add(this.lblCountdownLeft);
            this.panelF.Controls.Add(this.dtpCountdownEnd);
            this.panelF.Controls.Add(this.dtpCountdownBegin);
            this.panelF.Controls.Add(this.lblExplainCountdownLeft);
            this.panelF.Controls.Add(this.lblExplainCountdownEnd);
            this.panelF.Controls.Add(this.lblExplainCountdownBegin);
            this.panelF.Controls.Add(this.btnCountDown);
            this.panelF.Controls.Add(this.btnStopCountdown);
            this.panelF.Controls.Add(this.numericUpDownCountDown);
            this.panelF.Controls.Add(this.lblCountDown);
            this.panelF.Location = new System.Drawing.Point(949, 60);
            this.panelF.Name = "panelF";
            this.panelF.Size = new System.Drawing.Size(266, 234);
            this.panelF.TabIndex = 23;
            // 
            // lblCountdownLeft
            // 
            this.lblCountdownLeft.AutoSize = true;
            this.lblCountdownLeft.Location = new System.Drawing.Point(112, 185);
            this.lblCountdownLeft.Name = "lblCountdownLeft";
            this.lblCountdownLeft.Size = new System.Drawing.Size(50, 21);
            this.lblCountdownLeft.TabIndex = 32;
            this.lblCountdownLeft.Text = "x分钟";
            // 
            // dtpCountdownEnd
            // 
            this.dtpCountdownEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCountdownEnd.Location = new System.Drawing.Point(116, 142);
            this.dtpCountdownEnd.Name = "dtpCountdownEnd";
            this.dtpCountdownEnd.Size = new System.Drawing.Size(116, 29);
            this.dtpCountdownEnd.TabIndex = 31;
            // 
            // dtpCountdownBegin
            // 
            this.dtpCountdownBegin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCountdownBegin.Location = new System.Drawing.Point(116, 106);
            this.dtpCountdownBegin.Name = "dtpCountdownBegin";
            this.dtpCountdownBegin.Size = new System.Drawing.Size(116, 29);
            this.dtpCountdownBegin.TabIndex = 29;
            // 
            // lblExplainCountdownLeft
            // 
            this.lblExplainCountdownLeft.AutoSize = true;
            this.lblExplainCountdownLeft.Location = new System.Drawing.Point(19, 185);
            this.lblExplainCountdownLeft.Name = "lblExplainCountdownLeft";
            this.lblExplainCountdownLeft.Size = new System.Drawing.Size(78, 21);
            this.lblExplainCountdownLeft.TabIndex = 27;
            this.lblExplainCountdownLeft.Text = "剩余分钟:";
            // 
            // lblExplainCountdownEnd
            // 
            this.lblExplainCountdownEnd.AutoSize = true;
            this.lblExplainCountdownEnd.Location = new System.Drawing.Point(15, 148);
            this.lblExplainCountdownEnd.Name = "lblExplainCountdownEnd";
            this.lblExplainCountdownEnd.Size = new System.Drawing.Size(78, 21);
            this.lblExplainCountdownEnd.TabIndex = 25;
            this.lblExplainCountdownEnd.Text = "结束时间:";
            // 
            // lblExplainCountdownBegin
            // 
            this.lblExplainCountdownBegin.AutoSize = true;
            this.lblExplainCountdownBegin.Location = new System.Drawing.Point(19, 106);
            this.lblExplainCountdownBegin.Name = "lblExplainCountdownBegin";
            this.lblExplainCountdownBegin.Size = new System.Drawing.Size(78, 21);
            this.lblExplainCountdownBegin.TabIndex = 23;
            this.lblExplainCountdownBegin.Text = "开始时间:";
            // 
            // btnToday
            // 
            this.btnToday.Image = global::TimeRecorder.Properties.Resources.today_26px;
            this.btnToday.Location = new System.Drawing.Point(240, 92);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(31, 32);
            this.btnToday.TabIndex = 26;
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            this.btnToday.MouseHover += new System.EventHandler(this.btnDateChanged_MouseHover);
            // 
            // btnTomorrow
            // 
            this.btnTomorrow.Image = global::TimeRecorder.Properties.Resources.forward_26px;
            this.btnTomorrow.Location = new System.Drawing.Point(240, 130);
            this.btnTomorrow.Name = "btnTomorrow";
            this.btnTomorrow.Size = new System.Drawing.Size(31, 32);
            this.btnTomorrow.TabIndex = 25;
            this.btnTomorrow.UseVisualStyleBackColor = true;
            this.btnTomorrow.Click += new System.EventHandler(this.btnTomorrow_Click);
            this.btnTomorrow.MouseHover += new System.EventHandler(this.btnDateChanged_MouseHover);
            // 
            // btnYesterday
            // 
            this.btnYesterday.Image = global::TimeRecorder.Properties.Resources.back_26px;
            this.btnYesterday.Location = new System.Drawing.Point(240, 54);
            this.btnYesterday.Name = "btnYesterday";
            this.btnYesterday.Size = new System.Drawing.Size(31, 32);
            this.btnYesterday.TabIndex = 24;
            this.btnYesterday.UseVisualStyleBackColor = true;
            this.btnYesterday.Click += new System.EventHandler(this.btnYesterday_Click);
            this.btnYesterday.MouseHover += new System.EventHandler(this.btnDateChanged_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mcMain);
            this.panel1.Controls.Add(this.btnYesterday);
            this.panel1.Controls.Add(this.btnToday);
            this.panel1.Controls.Add(this.btnTomorrow);
            this.panel1.Location = new System.Drawing.Point(634, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 203);
            this.panel1.TabIndex = 27;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelF);
            this.Controls.Add(this.panelRecord);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMain";
            this.helpProviderMain.SetShowHelp(this, false);
            this.Text = "主程序";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.panelRecord.ResumeLayout(false);
            this.panelRecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountDown)).EndInit();
            this.contextMenuStripIcon.ResumeLayout(false);
            this.panelF.ResumeLayout(false);
            this.panelF.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddTodgv;
        private System.Windows.Forms.Label lblBeginTime;
        private System.Windows.Forms.HelpProvider helpProviderMain;
        private System.Windows.Forms.MonthCalendar mcMain;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblFirstLabel;
        private System.Windows.Forms.Label lblSecondLabel;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ComboBox cboFirstLbl;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.ToolStripMenuItem tsmLabel;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripMenuItem tsmLabelModify;
        private System.Windows.Forms.ToolStripMenuItem tsmAboutLanguage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panelRecord;
        private System.Windows.Forms.ComboBox cboSecondLbl;
        private System.Windows.Forms.DateTimePicker dTPEndTime;
        private System.Windows.Forms.DateTimePicker dTPBeginTime;
        private System.Windows.Forms.ToolStripMenuItem tsmShowSummary;
        private System.Windows.Forms.Timer timerTomato;
        private System.Windows.Forms.NumericUpDown numericUpDownCountDown;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Button btnCountDown;
        private System.Windows.Forms.Button btnStopCountdown;
        private System.Windows.Forms.NotifyIcon notifyIconMain;
        private System.Windows.Forms.Panel panelF;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripIcon;
        private System.Windows.Forms.ToolStripMenuItem tsmOpenRecordForm;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tsmBeginCountdown;
        private System.Windows.Forms.ToolStripMenuItem tsmEndCountdown;
        private System.Windows.Forms.Label lblExplainCountdownBegin;
        private System.Windows.Forms.Label lblExplainCountdownLeft;
        private System.Windows.Forms.Label lblExplainCountdownEnd;
        private System.Windows.Forms.DateTimePicker dtpCountdownEnd;
        private System.Windows.Forms.DateTimePicker dtpCountdownBegin;
        private System.Windows.Forms.Label lblCountdownLeft;
        private System.Windows.Forms.ToolStripMenuItem tsmAnalysis;
        private System.Windows.Forms.Button btnYesterday;
        private System.Windows.Forms.Button btnTomorrow;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddUnRecord;
    }
}

