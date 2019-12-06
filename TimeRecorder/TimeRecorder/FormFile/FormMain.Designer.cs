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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.tsmAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLabelModify = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAboutLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.英文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboFirstLbl = new System.Windows.Forms.ComboBox();
            this.cboSecondLbl = new System.Windows.Forms.ComboBox();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelRecord = new System.Windows.Forms.Panel();
            this.btnAddUnRecord = new System.Windows.Forms.Button();
            this.dTPEndTime = new System.Windows.Forms.DateTimePicker();
            this.dTPBeginTime = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownCountDown = new System.Windows.Forms.NumericUpDown();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.btnCountDown = new System.Windows.Forms.Button();
            this.btnStopCountdown = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnYesterday = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnTomorrow = new System.Windows.Forms.Button();
            this.timerTomato = new System.Windows.Forms.Timer(this.components);
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageRecord = new System.Windows.Forms.TabPage();
            this.tabPageTomato = new System.Windows.Forms.TabPage();
            this.tabPageSummary = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStripFormSummary = new System.Windows.Forms.ToolStrip();
            this.toolStripCboFont = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripCboFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripBtnColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnUnerLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnStrikeout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnOutdent = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnIndent = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnList = new System.Windows.Forms.ToolStripButton();
            this.rTxtTodaySummary = new System.Windows.Forms.RichTextBox();
            this.chartAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.statusStripMain.SuspendLayout();
            this.panelRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountDown)).BeginInit();
            this.contextMenuStripIcon.SuspendLayout();
            this.panelF.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageRecord.SuspendLayout();
            this.tabPageTomato.SuspendLayout();
            this.tabPageSummary.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStripFormSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddTodgv
            // 
            resources.ApplyResources(this.btnAddTodgv, "btnAddTodgv");
            this.btnAddTodgv.Name = "btnAddTodgv";
            this.helpProviderMain.SetShowHelp(this.btnAddTodgv, ((bool)(resources.GetObject("btnAddTodgv.ShowHelp"))));
            this.btnAddTodgv.UseVisualStyleBackColor = true;
            this.btnAddTodgv.Click += new System.EventHandler(this.btnAddTodgv_Click);
            // 
            // lblBeginTime
            // 
            resources.ApplyResources(this.lblBeginTime, "lblBeginTime");
            this.lblBeginTime.Name = "lblBeginTime";
            this.helpProviderMain.SetShowHelp(this.lblBeginTime, ((bool)(resources.GetObject("lblBeginTime.ShowHelp"))));
            // 
            // mcMain
            // 
            resources.ApplyResources(this.mcMain, "mcMain");
            this.mcMain.Name = "mcMain";
            this.helpProviderMain.SetShowHelp(this.mcMain, ((bool)(resources.GetObject("mcMain.ShowHelp"))));
            this.mcMain.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcMain_DateChanged);
            // 
            // lblEndTime
            // 
            resources.ApplyResources(this.lblEndTime, "lblEndTime");
            this.lblEndTime.Name = "lblEndTime";
            this.helpProviderMain.SetShowHelp(this.lblEndTime, ((bool)(resources.GetObject("lblEndTime.ShowHelp"))));
            // 
            // lblFirstLabel
            // 
            resources.ApplyResources(this.lblFirstLabel, "lblFirstLabel");
            this.lblFirstLabel.Name = "lblFirstLabel";
            this.helpProviderMain.SetShowHelp(this.lblFirstLabel, ((bool)(resources.GetObject("lblFirstLabel.ShowHelp"))));
            // 
            // lblSecondLabel
            // 
            resources.ApplyResources(this.lblSecondLabel, "lblSecondLabel");
            this.lblSecondLabel.Name = "lblSecondLabel";
            this.helpProviderMain.SetShowHelp(this.lblSecondLabel, ((bool)(resources.GetObject("lblSecondLabel.ShowHelp"))));
            // 
            // lblNote
            // 
            resources.ApplyResources(this.lblNote, "lblNote");
            this.lblNote.Name = "lblNote";
            this.helpProviderMain.SetShowHelp(this.lblNote, ((bool)(resources.GetObject("lblNote.ShowHelp"))));
            // 
            // txtNote
            // 
            resources.ApplyResources(this.txtNote, "txtNote");
            this.txtNote.Name = "txtNote";
            this.helpProviderMain.SetShowHelp(this.txtNote, ((bool)(resources.GetObject("txtNote.ShowHelp"))));
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_TextChanged);
            this.txtNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter_KeyDown);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmLabel,
            this.帮助ToolStripMenuItem});
            resources.ApplyResources(this.menuStripMain, "menuStripMain");
            this.menuStripMain.Name = "menuStripMain";
            this.helpProviderMain.SetShowHelp(this.menuStripMain, ((bool)(resources.GetObject("menuStripMain.ShowHelp"))));
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAnalysis});
            this.tsmFile.Name = "tsmFile";
            resources.ApplyResources(this.tsmFile, "tsmFile");
            // 
            // tsmAnalysis
            // 
            this.tsmAnalysis.Name = "tsmAnalysis";
            resources.ApplyResources(this.tsmAnalysis, "tsmAnalysis");
            this.tsmAnalysis.Click += new System.EventHandler(this.tsmAnalysis_Click);
            // 
            // tsmLabel
            // 
            this.tsmLabel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLabelModify});
            this.tsmLabel.Name = "tsmLabel";
            resources.ApplyResources(this.tsmLabel, "tsmLabel");
            // 
            // tsmLabelModify
            // 
            this.tsmLabelModify.Name = "tsmLabelModify";
            resources.ApplyResources(this.tsmLabelModify, "tsmLabelModify");
            this.tsmLabelModify.Click += new System.EventHandler(this.tsmLabelModify_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAbout,
            this.tsmAboutLanguage});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            resources.ApplyResources(this.帮助ToolStripMenuItem, "帮助ToolStripMenuItem");
            // 
            // tsmAbout
            // 
            this.tsmAbout.Name = "tsmAbout";
            resources.ApplyResources(this.tsmAbout, "tsmAbout");
            this.tsmAbout.Click += new System.EventHandler(this.tsmAbout_Click);
            // 
            // tsmAboutLanguage
            // 
            this.tsmAboutLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.中文ToolStripMenuItem,
            this.英文ToolStripMenuItem});
            this.tsmAboutLanguage.Name = "tsmAboutLanguage";
            resources.ApplyResources(this.tsmAboutLanguage, "tsmAboutLanguage");
            // 
            // 中文ToolStripMenuItem
            // 
            this.中文ToolStripMenuItem.Name = "中文ToolStripMenuItem";
            resources.ApplyResources(this.中文ToolStripMenuItem, "中文ToolStripMenuItem");
            // 
            // 英文ToolStripMenuItem
            // 
            this.英文ToolStripMenuItem.Name = "英文ToolStripMenuItem";
            resources.ApplyResources(this.英文ToolStripMenuItem, "英文ToolStripMenuItem");
            // 
            // cboFirstLbl
            // 
            this.cboFirstLbl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboFirstLbl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboFirstLbl.FormattingEnabled = true;
            resources.ApplyResources(this.cboFirstLbl, "cboFirstLbl");
            this.cboFirstLbl.Name = "cboFirstLbl";
            this.helpProviderMain.SetShowHelp(this.cboFirstLbl, ((bool)(resources.GetObject("cboFirstLbl.ShowHelp"))));
            this.cboFirstLbl.SelectedIndexChanged += new System.EventHandler(this.cboFirstLbl_SelectedIndexChanged);
            this.cboFirstLbl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter_KeyDown);
            // 
            // cboSecondLbl
            // 
            this.cboSecondLbl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSecondLbl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSecondLbl.FormattingEnabled = true;
            resources.ApplyResources(this.cboSecondLbl, "cboSecondLbl");
            this.cboSecondLbl.Name = "cboSecondLbl";
            this.helpProviderMain.SetShowHelp(this.cboSecondLbl, ((bool)(resources.GetObject("cboSecondLbl.ShowHelp"))));
            this.cboSecondLbl.TextChanged += new System.EventHandler(this.cboSecondLbl_TextChanged);
            this.cboSecondLbl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter_KeyDown);
            // 
            // dgvShow
            // 
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvShow, "dgvShow");
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowTemplate.Height = 23;
            this.helpProviderMain.SetShowHelp(this.dgvShow, ((bool)(resources.GetObject("dgvShow.ShowHelp"))));
            this.dgvShow.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShow_CellEndEdit);
            // 
            // statusStripMain
            // 
            resources.ApplyResources(this.statusStripMain, "statusStripMain");
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStripMain.Name = "statusStripMain";
            this.helpProviderMain.SetShowHelp(this.statusStripMain, ((bool)(resources.GetObject("statusStripMain.ShowHelp"))));
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
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
            resources.ApplyResources(this.panelRecord, "panelRecord");
            this.panelRecord.Name = "panelRecord";
            this.helpProviderMain.SetShowHelp(this.panelRecord, ((bool)(resources.GetObject("panelRecord.ShowHelp"))));
            // 
            // btnAddUnRecord
            // 
            resources.ApplyResources(this.btnAddUnRecord, "btnAddUnRecord");
            this.btnAddUnRecord.Name = "btnAddUnRecord";
            this.helpProviderMain.SetShowHelp(this.btnAddUnRecord, ((bool)(resources.GetObject("btnAddUnRecord.ShowHelp"))));
            this.btnAddUnRecord.UseVisualStyleBackColor = true;
            this.btnAddUnRecord.Click += new System.EventHandler(this.btnAddUnRecord_Click);
            // 
            // dTPEndTime
            // 
            this.dTPEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            resources.ApplyResources(this.dTPEndTime, "dTPEndTime");
            this.dTPEndTime.Name = "dTPEndTime";
            this.helpProviderMain.SetShowHelp(this.dTPEndTime, ((bool)(resources.GetObject("dTPEndTime.ShowHelp"))));
            this.dTPEndTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dTPEndTime_KeyDown);
            // 
            // dTPBeginTime
            // 
            this.dTPBeginTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            resources.ApplyResources(this.dTPBeginTime, "dTPBeginTime");
            this.dTPBeginTime.Name = "dTPBeginTime";
            this.helpProviderMain.SetShowHelp(this.dTPBeginTime, ((bool)(resources.GetObject("dTPBeginTime.ShowHelp"))));
            this.dTPBeginTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter_KeyDown);
            // 
            // numericUpDownCountDown
            // 
            resources.ApplyResources(this.numericUpDownCountDown, "numericUpDownCountDown");
            this.numericUpDownCountDown.Name = "numericUpDownCountDown";
            this.helpProviderMain.SetShowHelp(this.numericUpDownCountDown, ((bool)(resources.GetObject("numericUpDownCountDown.ShowHelp"))));
            // 
            // lblCountDown
            // 
            resources.ApplyResources(this.lblCountDown, "lblCountDown");
            this.lblCountDown.Name = "lblCountDown";
            this.helpProviderMain.SetShowHelp(this.lblCountDown, ((bool)(resources.GetObject("lblCountDown.ShowHelp"))));
            // 
            // btnCountDown
            // 
            resources.ApplyResources(this.btnCountDown, "btnCountDown");
            this.btnCountDown.Name = "btnCountDown";
            this.helpProviderMain.SetShowHelp(this.btnCountDown, ((bool)(resources.GetObject("btnCountDown.ShowHelp"))));
            this.btnCountDown.UseVisualStyleBackColor = true;
            this.btnCountDown.Click += new System.EventHandler(this.btnCountDown_Click);
            // 
            // btnStopCountdown
            // 
            resources.ApplyResources(this.btnStopCountdown, "btnStopCountdown");
            this.btnStopCountdown.Name = "btnStopCountdown";
            this.helpProviderMain.SetShowHelp(this.btnStopCountdown, ((bool)(resources.GetObject("btnStopCountdown.ShowHelp"))));
            this.btnStopCountdown.UseVisualStyleBackColor = true;
            this.btnStopCountdown.Click += new System.EventHandler(this.btnStopCountdown_Click);
            // 
            // contextMenuStripIcon
            // 
            this.contextMenuStripIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOpenRecordForm,
            this.tsmBeginCountdown,
            this.tsmEndCountdown,
            this.tsmExit});
            this.contextMenuStripIcon.Name = "contextMenuStripIcon";
            this.helpProviderMain.SetShowHelp(this.contextMenuStripIcon, ((bool)(resources.GetObject("contextMenuStripIcon.ShowHelp"))));
            resources.ApplyResources(this.contextMenuStripIcon, "contextMenuStripIcon");
            // 
            // tsmOpenRecordForm
            // 
            this.tsmOpenRecordForm.Name = "tsmOpenRecordForm";
            resources.ApplyResources(this.tsmOpenRecordForm, "tsmOpenRecordForm");
            this.tsmOpenRecordForm.Click += new System.EventHandler(this.tsmOpenRecordForm_Click);
            // 
            // tsmBeginCountdown
            // 
            this.tsmBeginCountdown.Name = "tsmBeginCountdown";
            resources.ApplyResources(this.tsmBeginCountdown, "tsmBeginCountdown");
            this.tsmBeginCountdown.Click += new System.EventHandler(this.tsmBeginCountdown_Click);
            // 
            // tsmEndCountdown
            // 
            this.tsmEndCountdown.Name = "tsmEndCountdown";
            resources.ApplyResources(this.tsmEndCountdown, "tsmEndCountdown");
            this.tsmEndCountdown.Click += new System.EventHandler(this.tsmEndCountdown_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            resources.ApplyResources(this.tsmExit, "tsmExit");
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
            resources.ApplyResources(this.panelF, "panelF");
            this.panelF.Name = "panelF";
            this.helpProviderMain.SetShowHelp(this.panelF, ((bool)(resources.GetObject("panelF.ShowHelp"))));
            // 
            // lblCountdownLeft
            // 
            resources.ApplyResources(this.lblCountdownLeft, "lblCountdownLeft");
            this.lblCountdownLeft.Name = "lblCountdownLeft";
            this.helpProviderMain.SetShowHelp(this.lblCountdownLeft, ((bool)(resources.GetObject("lblCountdownLeft.ShowHelp"))));
            // 
            // dtpCountdownEnd
            // 
            this.dtpCountdownEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            resources.ApplyResources(this.dtpCountdownEnd, "dtpCountdownEnd");
            this.dtpCountdownEnd.Name = "dtpCountdownEnd";
            this.helpProviderMain.SetShowHelp(this.dtpCountdownEnd, ((bool)(resources.GetObject("dtpCountdownEnd.ShowHelp"))));
            // 
            // dtpCountdownBegin
            // 
            this.dtpCountdownBegin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            resources.ApplyResources(this.dtpCountdownBegin, "dtpCountdownBegin");
            this.dtpCountdownBegin.Name = "dtpCountdownBegin";
            this.helpProviderMain.SetShowHelp(this.dtpCountdownBegin, ((bool)(resources.GetObject("dtpCountdownBegin.ShowHelp"))));
            // 
            // lblExplainCountdownLeft
            // 
            resources.ApplyResources(this.lblExplainCountdownLeft, "lblExplainCountdownLeft");
            this.lblExplainCountdownLeft.Name = "lblExplainCountdownLeft";
            this.helpProviderMain.SetShowHelp(this.lblExplainCountdownLeft, ((bool)(resources.GetObject("lblExplainCountdownLeft.ShowHelp"))));
            // 
            // lblExplainCountdownEnd
            // 
            resources.ApplyResources(this.lblExplainCountdownEnd, "lblExplainCountdownEnd");
            this.lblExplainCountdownEnd.Name = "lblExplainCountdownEnd";
            this.helpProviderMain.SetShowHelp(this.lblExplainCountdownEnd, ((bool)(resources.GetObject("lblExplainCountdownEnd.ShowHelp"))));
            // 
            // lblExplainCountdownBegin
            // 
            resources.ApplyResources(this.lblExplainCountdownBegin, "lblExplainCountdownBegin");
            this.lblExplainCountdownBegin.Name = "lblExplainCountdownBegin";
            this.helpProviderMain.SetShowHelp(this.lblExplainCountdownBegin, ((bool)(resources.GetObject("lblExplainCountdownBegin.ShowHelp"))));
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mcMain);
            this.panel1.Controls.Add(this.btnYesterday);
            this.panel1.Controls.Add(this.btnToday);
            this.panel1.Controls.Add(this.btnTomorrow);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.helpProviderMain.SetShowHelp(this.panel1, ((bool)(resources.GetObject("panel1.ShowHelp"))));
            // 
            // btnYesterday
            // 
            this.btnYesterday.Image = global::TimeRecorder.Properties.Resources.back_26px;
            resources.ApplyResources(this.btnYesterday, "btnYesterday");
            this.btnYesterday.Name = "btnYesterday";
            this.helpProviderMain.SetShowHelp(this.btnYesterday, ((bool)(resources.GetObject("btnYesterday.ShowHelp"))));
            this.btnYesterday.UseVisualStyleBackColor = true;
            this.btnYesterday.Click += new System.EventHandler(this.btnYesterday_Click);
            this.btnYesterday.MouseHover += new System.EventHandler(this.btnDateChanged_MouseHover);
            // 
            // btnToday
            // 
            this.btnToday.Image = global::TimeRecorder.Properties.Resources.today_26px;
            resources.ApplyResources(this.btnToday, "btnToday");
            this.btnToday.Name = "btnToday";
            this.helpProviderMain.SetShowHelp(this.btnToday, ((bool)(resources.GetObject("btnToday.ShowHelp"))));
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            this.btnToday.MouseHover += new System.EventHandler(this.btnDateChanged_MouseHover);
            // 
            // btnTomorrow
            // 
            this.btnTomorrow.Image = global::TimeRecorder.Properties.Resources.forward_26px;
            resources.ApplyResources(this.btnTomorrow, "btnTomorrow");
            this.btnTomorrow.Name = "btnTomorrow";
            this.helpProviderMain.SetShowHelp(this.btnTomorrow, ((bool)(resources.GetObject("btnTomorrow.ShowHelp"))));
            this.btnTomorrow.UseVisualStyleBackColor = true;
            this.btnTomorrow.Click += new System.EventHandler(this.btnTomorrow_Click);
            this.btnTomorrow.MouseHover += new System.EventHandler(this.btnDateChanged_MouseHover);
            // 
            // timerTomato
            // 
            this.timerTomato.Tick += new System.EventHandler(this.timerTomato_Tick);
            // 
            // notifyIconMain
            // 
            this.notifyIconMain.ContextMenuStrip = this.contextMenuStripIcon;
            resources.ApplyResources(this.notifyIconMain, "notifyIconMain");
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageRecord);
            this.tabControlMain.Controls.Add(this.tabPageTomato);
            this.tabControlMain.Controls.Add(this.tabPageSummary);
            resources.ApplyResources(this.tabControlMain, "tabControlMain");
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            // 
            // tabPageRecord
            // 
            this.tabPageRecord.Controls.Add(this.dgvShow);
            this.tabPageRecord.Controls.Add(this.panelRecord);
            this.tabPageRecord.Controls.Add(this.panel1);
            resources.ApplyResources(this.tabPageRecord, "tabPageRecord");
            this.tabPageRecord.Name = "tabPageRecord";
            this.tabPageRecord.UseVisualStyleBackColor = true;
            // 
            // tabPageTomato
            // 
            this.tabPageTomato.Controls.Add(this.panelF);
            resources.ApplyResources(this.tabPageTomato, "tabPageTomato");
            this.tabPageTomato.Name = "tabPageTomato";
            this.tabPageTomato.UseVisualStyleBackColor = true;
            // 
            // tabPageSummary
            // 
            this.tabPageSummary.Controls.Add(this.panel2);
            this.tabPageSummary.Controls.Add(this.chartAnalysis);
            resources.ApplyResources(this.tabPageSummary, "tabPageSummary");
            this.tabPageSummary.Name = "tabPageSummary";
            this.tabPageSummary.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStripFormSummary);
            this.panel2.Controls.Add(this.rTxtTodaySummary);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // toolStripFormSummary
            // 
            this.toolStripFormSummary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCboFont,
            this.toolStripCboFontSize,
            this.toolStripBtnColor,
            this.toolStripBtnBold,
            this.toolStripBtnItalic,
            this.toolStripBtnUnerLine,
            this.toolStripBtnStrikeout,
            this.toolStripSeparator1,
            this.toolStripBtnOutdent,
            this.toolStripBtnIndent,
            this.toolStripBtnList});
            resources.ApplyResources(this.toolStripFormSummary, "toolStripFormSummary");
            this.toolStripFormSummary.Name = "toolStripFormSummary";
            // 
            // toolStripCboFont
            // 
            this.toolStripCboFont.Name = "toolStripCboFont";
            resources.ApplyResources(this.toolStripCboFont, "toolStripCboFont");
            // 
            // toolStripCboFontSize
            // 
            this.toolStripCboFontSize.Name = "toolStripCboFontSize";
            resources.ApplyResources(this.toolStripCboFontSize, "toolStripCboFontSize");
            // 
            // toolStripBtnColor
            // 
            this.toolStripBtnColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnColor.Image = global::TimeRecorder.Properties.Resources.color;
            resources.ApplyResources(this.toolStripBtnColor, "toolStripBtnColor");
            this.toolStripBtnColor.Name = "toolStripBtnColor";
            // 
            // toolStripBtnBold
            // 
            this.toolStripBtnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnBold.Image = global::TimeRecorder.Properties.Resources.bold_48px;
            resources.ApplyResources(this.toolStripBtnBold, "toolStripBtnBold");
            this.toolStripBtnBold.Name = "toolStripBtnBold";
            // 
            // toolStripBtnItalic
            // 
            this.toolStripBtnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnItalic.Image = global::TimeRecorder.Properties.Resources.italic_48px;
            resources.ApplyResources(this.toolStripBtnItalic, "toolStripBtnItalic");
            this.toolStripBtnItalic.Name = "toolStripBtnItalic";
            // 
            // toolStripBtnUnerLine
            // 
            this.toolStripBtnUnerLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnUnerLine.Image = global::TimeRecorder.Properties.Resources.underline_48px;
            resources.ApplyResources(this.toolStripBtnUnerLine, "toolStripBtnUnerLine");
            this.toolStripBtnUnerLine.Name = "toolStripBtnUnerLine";
            // 
            // toolStripBtnStrikeout
            // 
            this.toolStripBtnStrikeout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnStrikeout.Image = global::TimeRecorder.Properties.Resources.text_48px;
            resources.ApplyResources(this.toolStripBtnStrikeout, "toolStripBtnStrikeout");
            this.toolStripBtnStrikeout.Name = "toolStripBtnStrikeout";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripBtnOutdent
            // 
            this.toolStripBtnOutdent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnOutdent.Image = global::TimeRecorder.Properties.Resources.indent_48px;
            resources.ApplyResources(this.toolStripBtnOutdent, "toolStripBtnOutdent");
            this.toolStripBtnOutdent.Name = "toolStripBtnOutdent";
            // 
            // toolStripBtnIndent
            // 
            this.toolStripBtnIndent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnIndent.Image = global::TimeRecorder.Properties.Resources.outdent_48px;
            resources.ApplyResources(this.toolStripBtnIndent, "toolStripBtnIndent");
            this.toolStripBtnIndent.Name = "toolStripBtnIndent";
            // 
            // toolStripBtnList
            // 
            this.toolStripBtnList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnList.Image = global::TimeRecorder.Properties.Resources.bulleted_list_48px;
            resources.ApplyResources(this.toolStripBtnList, "toolStripBtnList");
            this.toolStripBtnList.Name = "toolStripBtnList";
            // 
            // rTxtTodaySummary
            // 
            resources.ApplyResources(this.rTxtTodaySummary, "rTxtTodaySummary");
            this.rTxtTodaySummary.Name = "rTxtTodaySummary";
            this.rTxtTodaySummary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rTxtTodaySummary_KeyDown);
            // 
            // chartAnalysis
            // 
            this.chartAnalysis.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartAreaPie";
            this.chartAnalysis.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "LegendPie";
            this.chartAnalysis.Legends.Add(legend2);
            resources.ApplyResources(this.chartAnalysis, "chartAnalysis");
            this.chartAnalysis.Name = "chartAnalysis";
            this.chartAnalysis.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.ChartArea = "ChartAreaPie";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "LegendPie";
            series2.Name = "SeriesPie";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            series2.YValuesPerPoint = 2;
            this.chartAnalysis.Series.Add(series2);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.HelpButton = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.helpProviderMain.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
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
            this.tabControlMain.ResumeLayout(false);
            this.tabPageRecord.ResumeLayout(false);
            this.tabPageTomato.ResumeLayout(false);
            this.tabPageSummary.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStripFormSummary.ResumeLayout(false);
            this.toolStripFormSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalysis)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem 中文ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 英文ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageRecord;
        private System.Windows.Forms.TabPage tabPageTomato;
        private System.Windows.Forms.TabPage tabPageSummary;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStripFormSummary;
        private System.Windows.Forms.ToolStripComboBox toolStripCboFont;
        private System.Windows.Forms.ToolStripComboBox toolStripCboFontSize;
        private System.Windows.Forms.ToolStripButton toolStripBtnColor;
        private System.Windows.Forms.ToolStripButton toolStripBtnBold;
        private System.Windows.Forms.ToolStripButton toolStripBtnItalic;
        private System.Windows.Forms.ToolStripButton toolStripBtnUnerLine;
        private System.Windows.Forms.ToolStripButton toolStripBtnStrikeout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBtnOutdent;
        private System.Windows.Forms.ToolStripButton toolStripBtnIndent;
        private System.Windows.Forms.ToolStripButton toolStripBtnList;
        private System.Windows.Forms.RichTextBox rTxtTodaySummary;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAnalysis;
    }
}

