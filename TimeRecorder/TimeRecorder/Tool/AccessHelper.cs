﻿using System;
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

        string filePath = "Provider = Microsoft.ACE.OLEDB.12.0;  Data source = TimeRecorderData.accdb";

        OleDbConnection connection;
        OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
        DataSet myDataSet = new DataSet("MyDataSet");     

        #endregion

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

        public DataTable getDaysTable(DateTime beginDate, DateTime endDate)
        {
            string sql = String.Format("select * from {0} where {1} >= #{2}# and {1} <= #{3}#",
                               dataTableName, dateColumnName, beginDate, endDate);

            connection = new OleDbConnection(filePath);
            connection.Open();
            OleDbCommand command = new OleDbCommand(sql, connection);
            dataAdapter.SelectCommand = command;
            OleDbCommandBuilder builder = new OleDbCommandBuilder(dataAdapter);

            myDataSet.Tables.Add(dataTableName);
            myDataSet.Tables[dataTableName].Clear();//清空数据，否则会叠加数据
            dataAdapter.Fill(myDataSet, dataTableName);
            connection.Close();
            return myDataSet.Tables[dataTableName];

        }
    }
}
