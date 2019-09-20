namespace TimeRecorder
{
    partial class FormTomato
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTomato));
            this.panelF = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpCountdownBegin = new System.Windows.Forms.DateTimePicker();
            this.dtpCountdownEnd = new System.Windows.Forms.DateTimePicker();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblBeginTime = new System.Windows.Forms.Label();
            this.lblCountdownLeft = new System.Windows.Forms.Label();
            this.lblleftTime = new System.Windows.Forms.Label();
            this.btnBeginCountDown = new System.Windows.Forms.Button();
            this.btnStopCountdown = new System.Windows.Forms.Button();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelF.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panelF
            // 
            this.panelF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelF.Controls.Add(this.tableLayoutPanel1);
            this.panelF.Controls.Add(this.lblCountdownLeft);
            this.panelF.Controls.Add(this.lblleftTime);
            this.panelF.Controls.Add(this.btnBeginCountDown);
            this.panelF.Controls.Add(this.btnStopCountdown);
            this.panelF.Controls.Add(this.numUpDown);
            this.panelF.Controls.Add(this.lblCountDown);
            this.panelF.Location = new System.Drawing.Point(63, 54);
            this.panelF.Name = "panelF";
            this.panelF.Size = new System.Drawing.Size(610, 352);
            this.panelF.TabIndex = 24;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.38869F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.61131F));
            this.tableLayoutPanel1.Controls.Add(this.dtpCountdownBegin, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpCountdownEnd, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEndTime, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBeginTime, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 130);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.52475F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.47525F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(283, 101);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // dtpCountdownBegin
            // 
            this.dtpCountdownBegin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCountdownBegin.Location = new System.Drawing.Point(88, 3);
            this.dtpCountdownBegin.Name = "dtpCountdownBegin";
            this.dtpCountdownBegin.Size = new System.Drawing.Size(116, 29);
            this.dtpCountdownBegin.TabIndex = 29;
            // 
            // dtpCountdownEnd
            // 
            this.dtpCountdownEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCountdownEnd.Location = new System.Drawing.Point(88, 50);
            this.dtpCountdownEnd.Name = "dtpCountdownEnd";
            this.dtpCountdownEnd.Size = new System.Drawing.Size(116, 29);
            this.dtpCountdownEnd.TabIndex = 31;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(3, 47);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(78, 21);
            this.lblEndTime.TabIndex = 25;
            this.lblEndTime.Text = "结束时间:";
            // 
            // lblBeginTime
            // 
            this.lblBeginTime.AutoSize = true;
            this.lblBeginTime.Location = new System.Drawing.Point(3, 0);
            this.lblBeginTime.Name = "lblBeginTime";
            this.lblBeginTime.Size = new System.Drawing.Size(78, 21);
            this.lblBeginTime.TabIndex = 23;
            this.lblBeginTime.Text = "开始时间:";
            // 
            // lblCountdownLeft
            // 
            this.lblCountdownLeft.AutoSize = true;
            this.lblCountdownLeft.Location = new System.Drawing.Point(124, 259);
            this.lblCountdownLeft.Name = "lblCountdownLeft";
            this.lblCountdownLeft.Size = new System.Drawing.Size(50, 21);
            this.lblCountdownLeft.TabIndex = 32;
            this.lblCountdownLeft.Text = "x分钟";
            // 
            // lblleftTime
            // 
            this.lblleftTime.AutoSize = true;
            this.lblleftTime.Location = new System.Drawing.Point(33, 259);
            this.lblleftTime.Name = "lblleftTime";
            this.lblleftTime.Size = new System.Drawing.Size(78, 21);
            this.lblleftTime.TabIndex = 27;
            this.lblleftTime.Text = "剩余分钟:";
            // 
            // btnBeginCountDown
            // 
            this.btnBeginCountDown.Location = new System.Drawing.Point(3, 49);
            this.btnBeginCountDown.Name = "btnBeginCountDown";
            this.btnBeginCountDown.Size = new System.Drawing.Size(98, 35);
            this.btnBeginCountDown.TabIndex = 21;
            this.btnBeginCountDown.Text = "开始倒计时";
            this.btnBeginCountDown.UseVisualStyleBackColor = true;
            // 
            // btnStopCountdown
            // 
            this.btnStopCountdown.Location = new System.Drawing.Point(136, 49);
            this.btnStopCountdown.Name = "btnStopCountdown";
            this.btnStopCountdown.Size = new System.Drawing.Size(54, 35);
            this.btnStopCountdown.TabIndex = 22;
            this.btnStopCountdown.Text = "结束";
            this.btnStopCountdown.UseVisualStyleBackColor = true;
            // 
            // numUpDown
            // 
            this.numUpDown.Location = new System.Drawing.Point(67, 3);
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.Size = new System.Drawing.Size(59, 29);
            this.numUpDown.TabIndex = 19;
            // 
            // lblCountDown
            // 
            this.lblCountDown.AutoSize = true;
            this.lblCountDown.Location = new System.Drawing.Point(132, 11);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(42, 21);
            this.lblCountDown.TabIndex = 20;
            this.lblCountDown.Text = "分钟";
            // 
            // FormTomato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 449);
            this.Controls.Add(this.panelF);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormTomato";
            this.Text = "FormTomato";
            this.panelF.ResumeLayout(false);
            this.panelF.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelF;
        private System.Windows.Forms.Label lblCountdownLeft;
        private System.Windows.Forms.DateTimePicker dtpCountdownEnd;
        private System.Windows.Forms.DateTimePicker dtpCountdownBegin;
        private System.Windows.Forms.Label lblleftTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblBeginTime;
        private System.Windows.Forms.Button btnBeginCountDown;
        private System.Windows.Forms.Button btnStopCountdown;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
    }
}