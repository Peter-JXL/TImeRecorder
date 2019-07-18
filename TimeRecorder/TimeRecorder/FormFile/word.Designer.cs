namespace TimeRecorder
{
    partial class word
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(word));
            this.label1 = new System.Windows.Forms.Label();
            this.axWebBrowserWord = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowserWord)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // axWebBrowserWord
            // 
            this.axWebBrowserWord.Enabled = true;
            this.axWebBrowserWord.Location = new System.Drawing.Point(141, 55);
            this.axWebBrowserWord.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowserWord.OcxState")));
            this.axWebBrowserWord.Size = new System.Drawing.Size(389, 345);
            this.axWebBrowserWord.TabIndex = 2;
            // 
            // word
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 465);
            this.Controls.Add(this.axWebBrowserWord);
            this.Controls.Add(this.label1);
            this.Name = "word";
            this.Text = "word";
            this.Load += new System.EventHandler(this.word_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowserWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private AxSHDocVw.AxWebBrowser axWebBrowserWord;
    }
}