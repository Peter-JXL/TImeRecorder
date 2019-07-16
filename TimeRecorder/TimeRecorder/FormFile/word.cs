using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace TimeRecorder.FormFile
{
    public partial class word : Form
    {
        string summaryDir = @"summary/";  //summary存放的目录
        string wordExtison = ".word";
        string fileName;
        public word()
        {
            InitializeComponent();
        }

        private void word_Load(object sender, EventArgs e)
        {
            fileName = summaryDir + DateTime.Now.ToString("yyyyMMdd") + wordExtison;
            if (!File.Exists(fileName))
            {

            }
            //webBrowser1.Navigate();
        }
    }
}
