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
            this.中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.英文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            resources.ApplyResources(this.btnAddTodgv, "btnAddTodgv");
            this.helpProviderMain.SetHelpKeyword(this.btnAddTodgv, resources.GetString("btnAddTodgv.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.btnAddTodgv, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("btnAddTodgv.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.btnAddTodgv, resources.GetString("btnAddTodgv.HelpString"));
            this.btnAddTodgv.Name = "btnAddTodgv";
            this.helpProviderMain.SetShowHelp(this.btnAddTodgv, ((bool)(resources.GetObject("btnAddTodgv.ShowHelp"))));
            this.btnAddTodgv.UseVisualStyleBackColor = true;
            this.btnAddTodgv.Click += new System.EventHandler(this.btnAddTodgv_Click);
            // 
            // lblBeginTime
            // 
            resources.ApplyResources(this.lblBeginTime, "lblBeginTime");
            this.helpProviderMain.SetHelpKeyword(this.lblBeginTime, resources.GetString("lblBeginTime.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.lblBeginTime, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("lblBeginTime.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.lblBeginTime, resources.GetString("lblBeginTime.HelpString"));
            this.lblBeginTime.Name = "lblBeginTime";
            this.helpProviderMain.SetShowHelp(this.lblBeginTime, ((bool)(resources.GetObject("lblBeginTime.ShowHelp"))));
            // 
            // helpProviderMain
            // 
            resources.ApplyResources(this.helpProviderMain, "helpProviderMain");
            // 
            // mcMain
            // 
            resources.ApplyResources(this.mcMain, "mcMain");
            this.helpProviderMain.SetHelpKeyword(this.mcMain, resources.GetString("mcMain.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.mcMain, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("mcMain.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.mcMain, resources.GetString("mcMain.HelpString"));
            this.mcMain.Name = "mcMain";
            this.helpProviderMain.SetShowHelp(this.mcMain, ((bool)(resources.GetObject("mcMain.ShowHelp"))));
            this.mcMain.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcMain_DateChanged);
            // 
            // lblEndTime
            // 
            resources.ApplyResources(this.lblEndTime, "lblEndTime");
            this.helpProviderMain.SetHelpKeyword(this.lblEndTime, resources.GetString("lblEndTime.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.lblEndTime, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("lblEndTime.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.lblEndTime, resources.GetString("lblEndTime.HelpString"));
            this.lblEndTime.Name = "lblEndTime";
            this.helpProviderMain.SetShowHelp(this.lblEndTime, ((bool)(resources.GetObject("lblEndTime.ShowHelp"))));
            // 
            // lblFirstLabel
            // 
            resources.ApplyResources(this.lblFirstLabel, "lblFirstLabel");
            this.helpProviderMain.SetHelpKeyword(this.lblFirstLabel, resources.GetString("lblFirstLabel.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.lblFirstLabel, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("lblFirstLabel.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.lblFirstLabel, resources.GetString("lblFirstLabel.HelpString"));
            this.lblFirstLabel.Name = "lblFirstLabel";
            this.helpProviderMain.SetShowHelp(this.lblFirstLabel, ((bool)(resources.GetObject("lblFirstLabel.ShowHelp"))));
            // 
            // lblSecondLabel
            // 
            resources.ApplyResources(this.lblSecondLabel, "lblSecondLabel");
            this.helpProviderMain.SetHelpKeyword(this.lblSecondLabel, resources.GetString("lblSecondLabel.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.lblSecondLabel, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("lblSecondLabel.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.lblSecondLabel, resources.GetString("lblSecondLabel.HelpString"));
            this.lblSecondLabel.Name = "lblSecondLabel";
            this.helpProviderMain.SetShowHelp(this.lblSecondLabel, ((bool)(resources.GetObject("lblSecondLabel.ShowHelp"))));
            // 
            // lblNote
            // 
            resources.ApplyResources(this.lblNote, "lblNote");
            this.helpProviderMain.SetHelpKeyword(this.lblNote, resources.GetString("lblNote.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.lblNote, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("lblNote.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.lblNote, resources.GetString("lblNote.HelpString"));
            this.lblNote.Name = "lblNote";
            this.helpProviderMain.SetShowHelp(this.lblNote, ((bool)(resources.GetObject("lblNote.ShowHelp"))));
            // 
            // txtNote
            // 
            resources.ApplyResources(this.txtNote, "txtNote");
            this.helpProviderMain.SetHelpKeyword(this.txtNote, resources.GetString("txtNote.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.txtNote, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("txtNote.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.txtNote, resources.GetString("txtNote.HelpString"));
            this.txtNote.Name = "txtNote";
            this.helpProviderMain.SetShowHelp(this.txtNote, ((bool)(resources.GetObject("txtNote.ShowHelp"))));
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_TextChanged);
            this.txtNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter_KeyDown);
            // 
            // menuStripMain
            // 
            resources.ApplyResources(this.menuStripMain, "menuStripMain");
            this.helpProviderMain.SetHelpKeyword(this.menuStripMain, resources.GetString("menuStripMain.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.menuStripMain, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("menuStripMain.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.menuStripMain, resources.GetString("menuStripMain.HelpString"));
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmLabel,
            this.帮助ToolStripMenuItem});
            this.menuStripMain.Name = "menuStripMain";
            this.helpProviderMain.SetShowHelp(this.menuStripMain, ((bool)(resources.GetObject("menuStripMain.ShowHelp"))));
            // 
            // tsmFile
            // 
            resources.ApplyResources(this.tsmFile, "tsmFile");
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowSummary,
            this.tsmAnalysis});
            this.tsmFile.Name = "tsmFile";
            // 
            // tsmShowSummary
            // 
            resources.ApplyResources(this.tsmShowSummary, "tsmShowSummary");
            this.tsmShowSummary.Name = "tsmShowSummary";
            this.tsmShowSummary.Click += new System.EventHandler(this.tsmShowSummary_Click);
            // 
            // tsmAnalysis
            // 
            resources.ApplyResources(this.tsmAnalysis, "tsmAnalysis");
            this.tsmAnalysis.Name = "tsmAnalysis";
            this.tsmAnalysis.Click += new System.EventHandler(this.tsmAnalysis_Click);
            // 
            // tsmLabel
            // 
            resources.ApplyResources(this.tsmLabel, "tsmLabel");
            this.tsmLabel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLabelModify});
            this.tsmLabel.Name = "tsmLabel";
            // 
            // tsmLabelModify
            // 
            resources.ApplyResources(this.tsmLabelModify, "tsmLabelModify");
            this.tsmLabelModify.Name = "tsmLabelModify";
            this.tsmLabelModify.Click += new System.EventHandler(this.tsmLabelModify_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            resources.ApplyResources(this.帮助ToolStripMenuItem, "帮助ToolStripMenuItem");
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAbout,
            this.tsmAboutLanguage});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            // 
            // tsmAbout
            // 
            resources.ApplyResources(this.tsmAbout, "tsmAbout");
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Click += new System.EventHandler(this.tsmAbout_Click);
            // 
            // tsmAboutLanguage
            // 
            resources.ApplyResources(this.tsmAboutLanguage, "tsmAboutLanguage");
            this.tsmAboutLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.中文ToolStripMenuItem,
            this.英文ToolStripMenuItem});
            this.tsmAboutLanguage.Name = "tsmAboutLanguage";
            // 
            // 中文ToolStripMenuItem
            // 
            resources.ApplyResources(this.中文ToolStripMenuItem, "中文ToolStripMenuItem");
            this.中文ToolStripMenuItem.Name = "中文ToolStripMenuItem";
            // 
            // cboFirstLbl
            // 
            resources.ApplyResources(this.cboFirstLbl, "cboFirstLbl");
            this.cboFirstLbl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboFirstLbl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboFirstLbl.FormattingEnabled = true;
            this.helpProviderMain.SetHelpKeyword(this.cboFirstLbl, resources.GetString("cboFirstLbl.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.cboFirstLbl, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("cboFirstLbl.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.cboFirstLbl, resources.GetString("cboFirstLbl.HelpString"));
            this.cboFirstLbl.Name = "cboFirstLbl";
            this.helpProviderMain.SetShowHelp(this.cboFirstLbl, ((bool)(resources.GetObject("cboFirstLbl.ShowHelp"))));
            this.cboFirstLbl.SelectedIndexChanged += new System.EventHandler(this.cboFirstLbl_SelectedIndexChanged);
            this.cboFirstLbl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter_KeyDown);
            // 
            // cboSecondLbl
            // 
            resources.ApplyResources(this.cboSecondLbl, "cboSecondLbl");
            this.cboSecondLbl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSecondLbl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSecondLbl.FormattingEnabled = true;
            this.helpProviderMain.SetHelpKeyword(this.cboSecondLbl, resources.GetString("cboSecondLbl.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.cboSecondLbl, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("cboSecondLbl.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.cboSecondLbl, resources.GetString("cboSecondLbl.HelpString"));
            this.cboSecondLbl.Name = "cboSecondLbl";
            this.helpProviderMain.SetShowHelp(this.cboSecondLbl, ((bool)(resources.GetObject("cboSecondLbl.ShowHelp"))));
            this.cboSecondLbl.TextChanged += new System.EventHandler(this.cboSecondLbl_TextChanged);
            this.cboSecondLbl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter_KeyDown);
            // 
            // dgvShow
            // 
            resources.ApplyResources(this.dgvShow, "dgvShow");
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.helpProviderMain.SetHelpKeyword(this.dgvShow, resources.GetString("dgvShow.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.dgvShow, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("dgvShow.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.dgvShow, resources.GetString("dgvShow.HelpString"));
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowTemplate.Height = 23;
            this.helpProviderMain.SetShowHelp(this.dgvShow, ((bool)(resources.GetObject("dgvShow.ShowHelp"))));
            this.dgvShow.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShow_CellEndEdit);
            // 
            // statusStripMain
            // 
            resources.ApplyResources(this.statusStripMain, "statusStripMain");
            this.helpProviderMain.SetHelpKeyword(this.statusStripMain, resources.GetString("statusStripMain.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.statusStripMain, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("statusStripMain.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.statusStripMain, resources.GetString("statusStripMain.HelpString"));
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStripMain.Name = "statusStripMain";
            this.helpProviderMain.SetShowHelp(this.statusStripMain, ((bool)(resources.GetObject("statusStripMain.ShowHelp"))));
            // 
            // toolStripStatusLabel1
            // 
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            // 
            // panelRecord
            // 
            resources.ApplyResources(this.panelRecord, "panelRecord");
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
            this.helpProviderMain.SetHelpKeyword(this.panelRecord, resources.GetString("panelRecord.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.panelRecord, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("panelRecord.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.panelRecord, resources.GetString("panelRecord.HelpString"));
            this.panelRecord.Name = "panelRecord";
            this.helpProviderMain.SetShowHelp(this.panelRecord, ((bool)(resources.GetObject("panelRecord.ShowHelp"))));
            // 
            // btnAddUnRecord
            // 
            resources.ApplyResources(this.btnAddUnRecord, "btnAddUnRecord");
            this.helpProviderMain.SetHelpKeyword(this.btnAddUnRecord, resources.GetString("btnAddUnRecord.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.btnAddUnRecord, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("btnAddUnRecord.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.btnAddUnRecord, resources.GetString("btnAddUnRecord.HelpString"));
            this.btnAddUnRecord.Name = "btnAddUnRecord";
            this.helpProviderMain.SetShowHelp(this.btnAddUnRecord, ((bool)(resources.GetObject("btnAddUnRecord.ShowHelp"))));
            this.btnAddUnRecord.UseVisualStyleBackColor = true;
            this.btnAddUnRecord.Click += new System.EventHandler(this.btnAddUnRecord_Click);
            // 
            // dTPEndTime
            // 
            resources.ApplyResources(this.dTPEndTime, "dTPEndTime");
            this.dTPEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.helpProviderMain.SetHelpKeyword(this.dTPEndTime, resources.GetString("dTPEndTime.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.dTPEndTime, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("dTPEndTime.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.dTPEndTime, resources.GetString("dTPEndTime.HelpString"));
            this.dTPEndTime.Name = "dTPEndTime";
            this.helpProviderMain.SetShowHelp(this.dTPEndTime, ((bool)(resources.GetObject("dTPEndTime.ShowHelp"))));
            this.dTPEndTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter_KeyDown);
            // 
            // dTPBeginTime
            // 
            resources.ApplyResources(this.dTPBeginTime, "dTPBeginTime");
            this.dTPBeginTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.helpProviderMain.SetHelpKeyword(this.dTPBeginTime, resources.GetString("dTPBeginTime.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.dTPBeginTime, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("dTPBeginTime.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.dTPBeginTime, resources.GetString("dTPBeginTime.HelpString"));
            this.dTPBeginTime.Name = "dTPBeginTime";
            this.helpProviderMain.SetShowHelp(this.dTPBeginTime, ((bool)(resources.GetObject("dTPBeginTime.ShowHelp"))));
            this.dTPBeginTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter_KeyDown);
            // 
            // numericUpDownCountDown
            // 
            resources.ApplyResources(this.numericUpDownCountDown, "numericUpDownCountDown");
            this.helpProviderMain.SetHelpKeyword(this.numericUpDownCountDown, resources.GetString("numericUpDownCountDown.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.numericUpDownCountDown, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("numericUpDownCountDown.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.numericUpDownCountDown, resources.GetString("numericUpDownCountDown.HelpString"));
            this.numericUpDownCountDown.Name = "numericUpDownCountDown";
            this.helpProviderMain.SetShowHelp(this.numericUpDownCountDown, ((bool)(resources.GetObject("numericUpDownCountDown.ShowHelp"))));
            // 
            // lblCountDown
            // 
            resources.ApplyResources(this.lblCountDown, "lblCountDown");
            this.helpProviderMain.SetHelpKeyword(this.lblCountDown, resources.GetString("lblCountDown.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.lblCountDown, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("lblCountDown.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.lblCountDown, resources.GetString("lblCountDown.HelpString"));
            this.lblCountDown.Name = "lblCountDown";
            this.helpProviderMain.SetShowHelp(this.lblCountDown, ((bool)(resources.GetObject("lblCountDown.ShowHelp"))));
            // 
            // btnCountDown
            // 
            resources.ApplyResources(this.btnCountDown, "btnCountDown");
            this.helpProviderMain.SetHelpKeyword(this.btnCountDown, resources.GetString("btnCountDown.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.btnCountDown, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("btnCountDown.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.btnCountDown, resources.GetString("btnCountDown.HelpString"));
            this.btnCountDown.Name = "btnCountDown";
            this.helpProviderMain.SetShowHelp(this.btnCountDown, ((bool)(resources.GetObject("btnCountDown.ShowHelp"))));
            this.btnCountDown.UseVisualStyleBackColor = true;
            this.btnCountDown.Click += new System.EventHandler(this.btnCountDown_Click);
            // 
            // btnStopCountdown
            // 
            resources.ApplyResources(this.btnStopCountdown, "btnStopCountdown");
            this.helpProviderMain.SetHelpKeyword(this.btnStopCountdown, resources.GetString("btnStopCountdown.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.btnStopCountdown, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("btnStopCountdown.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.btnStopCountdown, resources.GetString("btnStopCountdown.HelpString"));
            this.btnStopCountdown.Name = "btnStopCountdown";
            this.helpProviderMain.SetShowHelp(this.btnStopCountdown, ((bool)(resources.GetObject("btnStopCountdown.ShowHelp"))));
            this.btnStopCountdown.UseVisualStyleBackColor = true;
            this.btnStopCountdown.Click += new System.EventHandler(this.btnStopCountdown_Click);
            // 
            // contextMenuStripIcon
            // 
            resources.ApplyResources(this.contextMenuStripIcon, "contextMenuStripIcon");
            this.helpProviderMain.SetHelpKeyword(this.contextMenuStripIcon, resources.GetString("contextMenuStripIcon.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.contextMenuStripIcon, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("contextMenuStripIcon.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.contextMenuStripIcon, resources.GetString("contextMenuStripIcon.HelpString"));
            this.contextMenuStripIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOpenRecordForm,
            this.tsmBeginCountdown,
            this.tsmEndCountdown,
            this.tsmExit});
            this.contextMenuStripIcon.Name = "contextMenuStripIcon";
            this.helpProviderMain.SetShowHelp(this.contextMenuStripIcon, ((bool)(resources.GetObject("contextMenuStripIcon.ShowHelp"))));
            // 
            // tsmOpenRecordForm
            // 
            resources.ApplyResources(this.tsmOpenRecordForm, "tsmOpenRecordForm");
            this.tsmOpenRecordForm.Name = "tsmOpenRecordForm";
            this.tsmOpenRecordForm.Click += new System.EventHandler(this.tsmOpenRecordForm_Click);
            // 
            // tsmBeginCountdown
            // 
            resources.ApplyResources(this.tsmBeginCountdown, "tsmBeginCountdown");
            this.tsmBeginCountdown.Name = "tsmBeginCountdown";
            this.tsmBeginCountdown.Click += new System.EventHandler(this.tsmBeginCountdown_Click);
            // 
            // tsmEndCountdown
            // 
            resources.ApplyResources(this.tsmEndCountdown, "tsmEndCountdown");
            this.tsmEndCountdown.Name = "tsmEndCountdown";
            this.tsmEndCountdown.Click += new System.EventHandler(this.tsmEndCountdown_Click);
            // 
            // tsmExit
            // 
            resources.ApplyResources(this.tsmExit, "tsmExit");
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // panelF
            // 
            resources.ApplyResources(this.panelF, "panelF");
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
            this.helpProviderMain.SetHelpKeyword(this.panelF, resources.GetString("panelF.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.panelF, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("panelF.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.panelF, resources.GetString("panelF.HelpString"));
            this.panelF.Name = "panelF";
            this.helpProviderMain.SetShowHelp(this.panelF, ((bool)(resources.GetObject("panelF.ShowHelp"))));
            // 
            // lblCountdownLeft
            // 
            resources.ApplyResources(this.lblCountdownLeft, "lblCountdownLeft");
            this.helpProviderMain.SetHelpKeyword(this.lblCountdownLeft, resources.GetString("lblCountdownLeft.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.lblCountdownLeft, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("lblCountdownLeft.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.lblCountdownLeft, resources.GetString("lblCountdownLeft.HelpString"));
            this.lblCountdownLeft.Name = "lblCountdownLeft";
            this.helpProviderMain.SetShowHelp(this.lblCountdownLeft, ((bool)(resources.GetObject("lblCountdownLeft.ShowHelp"))));
            // 
            // dtpCountdownEnd
            // 
            resources.ApplyResources(this.dtpCountdownEnd, "dtpCountdownEnd");
            this.dtpCountdownEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.helpProviderMain.SetHelpKeyword(this.dtpCountdownEnd, resources.GetString("dtpCountdownEnd.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.dtpCountdownEnd, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("dtpCountdownEnd.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.dtpCountdownEnd, resources.GetString("dtpCountdownEnd.HelpString"));
            this.dtpCountdownEnd.Name = "dtpCountdownEnd";
            this.helpProviderMain.SetShowHelp(this.dtpCountdownEnd, ((bool)(resources.GetObject("dtpCountdownEnd.ShowHelp"))));
            // 
            // dtpCountdownBegin
            // 
            resources.ApplyResources(this.dtpCountdownBegin, "dtpCountdownBegin");
            this.dtpCountdownBegin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.helpProviderMain.SetHelpKeyword(this.dtpCountdownBegin, resources.GetString("dtpCountdownBegin.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.dtpCountdownBegin, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("dtpCountdownBegin.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.dtpCountdownBegin, resources.GetString("dtpCountdownBegin.HelpString"));
            this.dtpCountdownBegin.Name = "dtpCountdownBegin";
            this.helpProviderMain.SetShowHelp(this.dtpCountdownBegin, ((bool)(resources.GetObject("dtpCountdownBegin.ShowHelp"))));
            // 
            // lblExplainCountdownLeft
            // 
            resources.ApplyResources(this.lblExplainCountdownLeft, "lblExplainCountdownLeft");
            this.helpProviderMain.SetHelpKeyword(this.lblExplainCountdownLeft, resources.GetString("lblExplainCountdownLeft.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.lblExplainCountdownLeft, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("lblExplainCountdownLeft.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.lblExplainCountdownLeft, resources.GetString("lblExplainCountdownLeft.HelpString"));
            this.lblExplainCountdownLeft.Name = "lblExplainCountdownLeft";
            this.helpProviderMain.SetShowHelp(this.lblExplainCountdownLeft, ((bool)(resources.GetObject("lblExplainCountdownLeft.ShowHelp"))));
            // 
            // lblExplainCountdownEnd
            // 
            resources.ApplyResources(this.lblExplainCountdownEnd, "lblExplainCountdownEnd");
            this.helpProviderMain.SetHelpKeyword(this.lblExplainCountdownEnd, resources.GetString("lblExplainCountdownEnd.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.lblExplainCountdownEnd, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("lblExplainCountdownEnd.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.lblExplainCountdownEnd, resources.GetString("lblExplainCountdownEnd.HelpString"));
            this.lblExplainCountdownEnd.Name = "lblExplainCountdownEnd";
            this.helpProviderMain.SetShowHelp(this.lblExplainCountdownEnd, ((bool)(resources.GetObject("lblExplainCountdownEnd.ShowHelp"))));
            // 
            // lblExplainCountdownBegin
            // 
            resources.ApplyResources(this.lblExplainCountdownBegin, "lblExplainCountdownBegin");
            this.helpProviderMain.SetHelpKeyword(this.lblExplainCountdownBegin, resources.GetString("lblExplainCountdownBegin.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.lblExplainCountdownBegin, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("lblExplainCountdownBegin.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.lblExplainCountdownBegin, resources.GetString("lblExplainCountdownBegin.HelpString"));
            this.lblExplainCountdownBegin.Name = "lblExplainCountdownBegin";
            this.helpProviderMain.SetShowHelp(this.lblExplainCountdownBegin, ((bool)(resources.GetObject("lblExplainCountdownBegin.ShowHelp"))));
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.mcMain);
            this.panel1.Controls.Add(this.btnYesterday);
            this.panel1.Controls.Add(this.btnToday);
            this.panel1.Controls.Add(this.btnTomorrow);
            this.helpProviderMain.SetHelpKeyword(this.panel1, resources.GetString("panel1.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.panel1, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("panel1.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.panel1, resources.GetString("panel1.HelpString"));
            this.panel1.Name = "panel1";
            this.helpProviderMain.SetShowHelp(this.panel1, ((bool)(resources.GetObject("panel1.ShowHelp"))));
            // 
            // btnYesterday
            // 
            resources.ApplyResources(this.btnYesterday, "btnYesterday");
            this.helpProviderMain.SetHelpKeyword(this.btnYesterday, resources.GetString("btnYesterday.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.btnYesterday, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("btnYesterday.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.btnYesterday, resources.GetString("btnYesterday.HelpString"));
            this.btnYesterday.Image = global::TimeRecorder.Properties.Resources.back_26px;
            this.btnYesterday.Name = "btnYesterday";
            this.helpProviderMain.SetShowHelp(this.btnYesterday, ((bool)(resources.GetObject("btnYesterday.ShowHelp"))));
            this.btnYesterday.UseVisualStyleBackColor = true;
            this.btnYesterday.Click += new System.EventHandler(this.btnYesterday_Click);
            this.btnYesterday.MouseHover += new System.EventHandler(this.btnDateChanged_MouseHover);
            // 
            // btnToday
            // 
            resources.ApplyResources(this.btnToday, "btnToday");
            this.helpProviderMain.SetHelpKeyword(this.btnToday, resources.GetString("btnToday.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.btnToday, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("btnToday.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.btnToday, resources.GetString("btnToday.HelpString"));
            this.btnToday.Image = global::TimeRecorder.Properties.Resources.today_26px;
            this.btnToday.Name = "btnToday";
            this.helpProviderMain.SetShowHelp(this.btnToday, ((bool)(resources.GetObject("btnToday.ShowHelp"))));
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            this.btnToday.MouseHover += new System.EventHandler(this.btnDateChanged_MouseHover);
            // 
            // btnTomorrow
            // 
            resources.ApplyResources(this.btnTomorrow, "btnTomorrow");
            this.helpProviderMain.SetHelpKeyword(this.btnTomorrow, resources.GetString("btnTomorrow.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.btnTomorrow, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("btnTomorrow.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.btnTomorrow, resources.GetString("btnTomorrow.HelpString"));
            this.btnTomorrow.Image = global::TimeRecorder.Properties.Resources.forward_26px;
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
            resources.ApplyResources(this.notifyIconMain, "notifyIconMain");
            this.notifyIconMain.ContextMenuStrip = this.contextMenuStripIcon;
            // 
            // 英文ToolStripMenuItem
            // 
            resources.ApplyResources(this.英文ToolStripMenuItem, "英文ToolStripMenuItem");
            this.英文ToolStripMenuItem.Name = "英文ToolStripMenuItem";
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelF);
            this.Controls.Add(this.panelRecord);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.HelpButton = true;
            this.helpProviderMain.SetHelpKeyword(this, resources.GetString("$this.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("$this.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this, resources.GetString("$this.HelpString"));
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
        private System.Windows.Forms.ToolStripMenuItem 中文ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 英文ToolStripMenuItem;
    }
}

