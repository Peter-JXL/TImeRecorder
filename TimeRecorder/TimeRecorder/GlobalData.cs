﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeRecorder
{

    public static class GlobalData
    {
        public static string labelTabelName = "labelTable", dataTableName = "dataTable";  //The database only has two table, this is the table's name
        public static string firstLabelColumnName = "firstLabel", secondLabelColumnName = "secondLabel", dateColumnName = "recordDate",
                             beginTimeColumnName = "beginTime", endTimeColumnName = "endTime", noteColumnName = "note";
        public static void Deconstruct(out string labelTableName)
        {
            labelTableName = labelTabelName;
        }
    }

}