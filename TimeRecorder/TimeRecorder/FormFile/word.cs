using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using MSWord = Microsoft.Office.Interop.Word;

namespace TimeRecorder
{
    public partial class word : Form
    {
        string wordExtison = ".docx";
        object wordFilePath;
        static string exeFilePath = System.Windows.Forms.Application.StartupPath + '\\';  //路径是TimeRecorder\bin\debug，后面没有\
        string summaryDir = exeFilePath + @"summary/";  //summary存放的目录

        MSWord.Application wordApp;  //Word应用程序变量
        MSWord.Document wordDoc;     //Word文档变量

        public word()
        {
            InitializeComponent();
        }

        private void word_Load(object sender, EventArgs e)
        {

            CreateWord(DateTime.Now);
            Object missing = Type.Missing;
            //webBrowserWord.Navigate((string)wordFilePath);
            //axWebBrowserWord.Navigate(@"D:\ATime\时间管理笔记.docx");
            //axWebBrowserWord.Navigate("www.baidu.com");

            object filePath = @"D:\ATime\时间管理笔记.docx";
            axWebBrowserWord.Navigate2(ref filePath , ref missing, ref missing, ref missing, ref missing);
        }


        private void createDir()
        {
            if (!Directory.Exists(summaryDir))
            {
                Directory.CreateDirectory(summaryDir);
            }
        }

        private void CreateWord(DateTime dt)
        {

            wordFilePath = summaryDir + dt.ToString("yyyyMMdd") + wordExtison;
            //object path = dt.ToString("yyyy") + wordExtison; //文件路径  默认是C：//user//用户名//documents

            wordApp = new MSWord.Application();//初始化
            if (File.Exists((string)wordFilePath))
            {
                Console.WriteLine("file exist!");
                return;
            }
            //由于使用的是COM 库，因此有许多变量需要用Missing.Value 代替
            Object Nothing = Missing.Value;

            //新建一个word对象
            wordDoc = wordApp.Documents.Add(ref Nothing, ref Nothing, ref Nothing, ref Nothing);

            //WdSaveDocument为Word2003文档的保存格式(文档后缀.doc)
            //wdFormatDocumentDefault为Word2007的保存格式(文档后缀.docx)
            object format = MSWord.WdSaveFormat.wdFormatDocumentDefault;

            //将wordDoc 文档对象的内容保存为DOC 文档,并保存到path指定的路径
            wordDoc.SaveAs(ref wordFilePath, ref format, ref Nothing, ref Nothing,
            ref Nothing, ref Nothing, ref Nothing, ref Nothing,
            ref Nothing, ref Nothing, ref Nothing, ref Nothing,
            ref Nothing, ref Nothing, ref Nothing, ref Nothing);

            //关闭wordDoc文档
            wordDoc.Close(ref Nothing, ref Nothing, ref Nothing);

            //关闭wordApp组件对象
            wordApp.Quit(ref Nothing, ref Nothing, ref Nothing);

        }


    }
}
