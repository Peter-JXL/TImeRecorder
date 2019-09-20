namespace TimeRecorder
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.btnVisitPage = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCheckUpdate = new System.Windows.Forms.Button();
            this.tPage = new System.Windows.Forms.TabControl();
            this.tPageAbout = new System.Windows.Forms.TabPage();
            this.tPageOpenSource = new System.Windows.Forms.TabPage();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.tPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVisitPage
            // 
            this.btnVisitPage.Location = new System.Drawing.Point(395, 387);
            this.btnVisitPage.Name = "btnVisitPage";
            this.btnVisitPage.Size = new System.Drawing.Size(124, 41);
            this.btnVisitPage.TabIndex = 0;
            this.btnVisitPage.Text = "访问项目主页";
            this.btnVisitPage.UseVisualStyleBackColor = true;
            this.btnVisitPage.Click += new System.EventHandler(this.btnVisitPage_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(560, 387);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(58, 41);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCheckUpdate
            // 
            this.btnCheckUpdate.Location = new System.Drawing.Point(23, 387);
            this.btnCheckUpdate.Name = "btnCheckUpdate";
            this.btnCheckUpdate.Size = new System.Drawing.Size(107, 41);
            this.btnCheckUpdate.TabIndex = 4;
            this.btnCheckUpdate.Text = "检查更新";
            this.btnCheckUpdate.UseVisualStyleBackColor = true;
            this.btnCheckUpdate.Click += new System.EventHandler(this.btnCheckUpdate_Click);
            // 
            // tPage
            // 
            this.tPage.Controls.Add(this.tPageAbout);
            this.tPage.Controls.Add(this.tPageOpenSource);
            this.tPage.Location = new System.Drawing.Point(23, 26);
            this.tPage.Name = "tPage";
            this.tPage.SelectedIndex = 0;
            this.tPage.Size = new System.Drawing.Size(595, 341);
            this.tPage.TabIndex = 5;
            // 
            // tPageAbout
            // 
            this.tPageAbout.Location = new System.Drawing.Point(4, 30);
            this.tPageAbout.Name = "tPageAbout";
            this.tPageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tPageAbout.Size = new System.Drawing.Size(587, 307);
            this.tPageAbout.TabIndex = 0;
            this.tPageAbout.Text = "关于TimeRecorder";
            this.tPageAbout.UseVisualStyleBackColor = true;
            // 
            // tPageOpenSource
            // 
            this.tPageOpenSource.Location = new System.Drawing.Point(4, 30);
            this.tPageOpenSource.Name = "tPageOpenSource";
            this.tPageOpenSource.Padding = new System.Windows.Forms.Padding(3);
            this.tPageOpenSource.Size = new System.Drawing.Size(587, 307);
            this.tPageOpenSource.TabIndex = 1;
            this.tPageOpenSource.Text = "Open Source License";
            this.tPageOpenSource.UseVisualStyleBackColor = true;
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Location = new System.Drawing.Point(159, 401);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(55, 21);
            this.lblCopyRight.TabIndex = 6;
            this.lblCopyRight.Text = "label1";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 465);
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.tPage);
            this.Controls.Add(this.btnCheckUpdate);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnVisitPage);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormAbout";
            this.Text = "FormAbout";
            this.tPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVisitPage;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCheckUpdate;
        private System.Windows.Forms.TabControl tPage;
        private System.Windows.Forms.TabPage tPageAbout;
        private System.Windows.Forms.TabPage tPageOpenSource;
        private System.Windows.Forms.Label lblCopyRight;
    }
}