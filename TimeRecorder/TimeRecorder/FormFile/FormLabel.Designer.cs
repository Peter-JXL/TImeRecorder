namespace TimeRecorder
{
    partial class FormLabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLabel));
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvLabel = new System.Windows.Forms.DataGridView();
            this.statusStripFormLabel = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(22, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 34);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "保存更新";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvLabel
            // 
            this.dgvLabel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvLabel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvLabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLabel.Location = new System.Drawing.Point(22, 71);
            this.dgvLabel.Name = "dgvLabel";
            this.dgvLabel.RowTemplate.Height = 23;
            this.dgvLabel.Size = new System.Drawing.Size(532, 662);
            this.dgvLabel.TabIndex = 8;
            // 
            // statusStripFormLabel
            // 
            this.statusStripFormLabel.Location = new System.Drawing.Point(0, 751);
            this.statusStripFormLabel.Name = "statusStripFormLabel";
            this.statusStripFormLabel.Size = new System.Drawing.Size(566, 22);
            this.statusStripFormLabel.TabIndex = 13;
            this.statusStripFormLabel.Text = "statusStrip1";
            // 
            // FormLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 773);
            this.Controls.Add(this.statusStripFormLabel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvLabel);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormLabel";
            this.Text = "标签管理窗口";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLabel_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvLabel;
        private System.Windows.Forms.StatusStrip statusStripFormLabel;
    }
}