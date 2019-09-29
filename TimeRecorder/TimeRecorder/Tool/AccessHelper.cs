using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeRecorder
{
    class AccessHelper
    {
        #region 数据定义

        string dataTableName = GlobalData.dataTableName, LabelTableName = GlobalData.labelTabelName;
        string firstLabelColumnName = GlobalData.firstLabelColumnName, secondLabelColumnName = GlobalData.secondLabelColumnName;
        string dateColumnName = GlobalData.dateColumnName, beginTimeColumnName = GlobalData.beginTimeColumnName,
            endTimeColumnName = GlobalData.endTimeColumnName, noteColumnName = GlobalData.noteColumnName;

        static string filePath = "Provider = Microsoft.ACE.OLEDB.12.0;  Data source = TimeRecorderData.accdb";

        OleDbConnection connection = new OleDbConnection(filePath);
        OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
        DataSet myDataSet = new DataSet("MyDataSet");

        string summaryDir = GlobalData.summaryDir;

        #endregion

        public AccessHelper()
        {
            myDataSet.Tables.Add(dataTableName);
            myDataSet.Tables.Add(LabelTableName);
        }

        public DataTable getLabelTable()
        {
            string sql = string.Format("select * from {0}", LabelTableName);
            connection.Open();
            OleDbCommand command = new OleDbCommand(sql, connection);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = command;
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.Fill(myDataSet, LabelTableName);
            connection.Close();
            return myDataSet.Tables[LabelTableName];
        }

        public DataTable getDaysTable(DateTime beginDate, DateTime endDate)
        {
            string sql = String.Format("select * from {0} where {1} >= #{2}# and {1} <= #{3}#",
                               dataTableName, dateColumnName, beginDate, endDate);
            connection.Open();
            OleDbCommand command = new OleDbCommand(sql, connection);
            dataAdapter.SelectCommand = command;
            OleDbCommandBuilder builder = new OleDbCommandBuilder(dataAdapter);


            myDataSet.Tables[dataTableName].Clear();//清空数据，否则会叠加数据
            dataAdapter.Fill(myDataSet, dataTableName);
            connection.Close();
            return myDataSet.Tables[dataTableName];

        }

        public DataTable getLabelTime(DateTime beginDate, DateTime endDate, string Label)
        {
            //获取指定标签的时间
            string sql = String.Format("select * from {0} where {1} >= #{2}# and {1} <= #{3}# and {4} = {5};",
                                               dataTableName, dateColumnName, beginDate, endDate, firstLabelColumnName, Label);

            connection.Open();
            OleDbCommand command = new OleDbCommand(sql, connection);
            dataAdapter.SelectCommand = command;
            OleDbCommandBuilder builder = new OleDbCommandBuilder(dataAdapter);

            DataTable temp = new DataTable();
            dataAdapter.Fill(temp, dataTableName);
            connection.Close();

            return temp;
        }


        #region 导出Excel数据

        public bool exportAllDataToExcel(string excelFimeName = "TimeRecorderData.xlsx")
        {
            //将全部数据导出到Excel，工作表分布：总表为全部数据的表，然后每个月的数据一张表
            //TODO:然后每个月的数据一张表
            //[excel名].[sheet名] 已有的excel的表要加$  

            string sql = string.Format(
                @"select * into [Excel 8.0; database={0}].[{1}] 
                from {1} ;", 
                excelFimeName, dataTableName);
            connection.Open();
            OleDbCommand command = new OleDbCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
            return true;
        }

        public bool exportDaysDataToExcel
            (DateTime beginDate2, DateTime endDate2, string excelFimeName = "TimeRecorderData.xlsx")
        {
            //将指定日期的数据导出到Excel
            //[excel名].[sheet名] 已有的excel的表要加$  

            string beginDate = beginDate2.ToShortDateString();
            string endDate = endDate2.ToShortDateString();

            string sql = string.Format(
                @"select * into [Excel 8.0;  database={0}].[{1}] 
                from {2} 
                where {3} >= #{4}#  and {3} <= #{5}# ;",
                 excelFimeName, beginDate,
                 dataTableName,
                 beginTimeColumnName, beginDate, endDate
                 );
            Console.WriteLine(sql);

            connection.Open();
            OleDbCommand command = new OleDbCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
            return true;
        }

        public bool exportDaysDataWithLabelToExcel
            (DateTime beginDate2, DateTime endDate2,string firstLabel, string secondLabel,
            string excelFimeName = "TimeRecorderData.xlsx")
        {
            string beginDate = beginDate2.ToShortDateString();
            string endDate = endDate2.ToShortDateString();

            string sql = string.Format(
                @"select * into [Excel 8.0;  database={0}].[{1}] 
                from {2} 
                where {3} >= #{4}#  and {3} <= #{5}# 
                and {6} = {7};",
                 excelFimeName, beginDate,
                 dataTableName,
                 beginTimeColumnName, beginDate, endDate,
                 firstLabelColumnName, firstLabel
                 );
            Console.WriteLine(sql);

            connection.Open();
            OleDbCommand command = new OleDbCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
            return true;
        }
        #endregion


        #region Word操作

        public bool exportDaysDataToWord()
        {
            //导出指定日期的Word数据
            //if(!Directry.Exits(summaryDir))
            //{
            //    return false;
            //}
            //else
            //{
            //    System.Windows.Forms.RichTextBox rtBox = new System.Windows.Forms.RichTextBox();
            //    string rtfText = System.IO.File.ReadAllText(path);
            //    rtBox.Rtf = rtfText;
            //    string plainText = rtBox.Text;
            //    System.Windows.Forms.MessageBox.Show(plainText);
            //}
            return true;
        }

        public bool exportAllDataToEWord()
        {
            //导出全部日期的Word数据
            return true;
        }



        #endregion

    }
}
