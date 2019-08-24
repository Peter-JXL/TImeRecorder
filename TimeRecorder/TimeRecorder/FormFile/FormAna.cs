using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TimeRecorder
{
    public partial class FormAna : Form
    {
        #region 数据定义
        
        #endregion

        private void btnAna_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtpBeginTime.Value;
            DateTime endDate = dtpEndTime.Value;
        }



        public FormAna()
        {
            InitializeComponent();
        }

        private void FormAna_Load(object sender, EventArgs e)
        {
            
           

        }


   
      
    }
}


