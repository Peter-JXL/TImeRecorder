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
        string yearAndMonthTableName = DateTime.Now.ToString("yyyyMM");
        string LabelTableName = "标签表", firstLabelColumnName = "一级标签", secondLabelColumnName = "二级标签";
        string dateColumnName = "日期", beginTimeColumnName = "开始时间", endTimeColumnName = "结束时间", noteColumnName = "备注";
        string filePath = "Provider = Microsoft.ACE.OLEDB.12.0;  Data source = userData.accdb";


        OleDbConnection connection;
        OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
        DataSet myDataSet = new DataSet("MyDataSet");



        public DataTable getLabelTable()
        {
            string sql = string.Format("select * from {0}", LabelTableName);
            connection = new OleDbConnection(filePath);
            connection.Open();
            OleDbCommand command = new OleDbCommand(sql, connection);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = command;
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.Fill(myDataSet, LabelTableName);
            connection.Close();
            return myDataSet.Tables[LabelTableName];
        }


        public DataTable getDaysTable(DateTime beginTime, DateTime endTime)
        {
            DataTable daysTable = new DataTable();
            string sql = string.Format("select * from {0} where {1} and {2}", beginTime.ToShortDateString(), endTime.ToShortDateString());


            return daysTable;
        }
    }
}
