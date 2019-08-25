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
            this.panelF = new System.Windows.Forms.Panel();
            this.lblCountdownLeft = new System.Windows.Forms.Label();
            this.dtpCountdownEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpCountdownBegin = new System.Windows.Forms.DateTimePicker();
            this.lblExplainCountdownLeft = new System.Windows.Forms.Label();
            this.lblExplainCountdownEnd = new System.Windows.Forms.Label();
            this.lblExplainCountdownBegin = new System.Windows.Forms.Label();
            this.btnCountDown = new System.Windows.Forms.Button();
            this.btnStopCountdown = new System.Windows.Forms.Button();
            this.numericUpDownCountDown = new System.Windows.Forms.NumericUpDown();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.panelF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountDown)).BeginInit();
            this.SuspendLayout();
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
            this.panelF.Location = new System.Drawing.Point(245, 107);
            this.panelF.Name = "panelF";
            this.panelF.Size = new System.Drawing.Size(266, 234);
            this.panelF.TabIndex = 24;
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
            // btnCountDown
            // 
            this.btnCountDown.Location = new System.Drawing.Point(19, 3);
            this.btnCountDown.Name = "btnCountDown";
            this.btnCountDown.Size = new System.Drawing.Size(98, 35);
            this.btnCountDown.TabIndex = 21;
            this.btnCountDown.Text = "开始倒计时";
            this.btnCountDown.UseVisualStyleBackColor = true;
            // 
            // btnStopCountdown
            // 
            this.btnStopCountdown.Location = new System.Drawing.Point(136, 3);
            this.btnStopCountdown.Name = "btnStopCountdown";
            this.btnStopCountdown.Size = new System.Drawing.Size(54, 35);
            this.btnStopCountdown.TabIndex = 22;
            this.btnStopCountdown.Text = "结束";
            this.btnStopCountdown.UseVisualStyleBackColor = true;
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
            // FormTomato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 449);
            this.Controls.Add(this.panelF);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormTomato";
            this.Text = "FormTomato";
            this.panelF.ResumeLayout(false);
            this.panelF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelF;
        private System.Windows.Forms.Label lblCountdownLeft;
        private System.Windows.Forms.DateTimePicker dtpCountdownEnd;
        private System.Windows.Forms.DateTimePicker dtpCountdownBegin;
        private System.Windows.Forms.Label lblExplainCountdownLeft;
        private System.Windows.Forms.Label lblExplainCountdownEnd;
        private System.Windows.Forms.Label lblExplainCountdownBegin;
        private System.Windows.Forms.Button btnCountDown;
        private System.Windows.Forms.Button btnStopCountdown;
        private System.Windows.Forms.NumericUpDown numericUpDownCountDown;
        private System.Windows.Forms.Label lblCountDown;
    }
}