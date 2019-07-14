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

namespace TimeRecorder
{
    public partial class FormAna : Form
    {
        Dictionary<string, TimeSpan> dic = new Dictionary<string, TimeSpan>();
        string yearAndMonthTableName = "201907";
        string LabelTableName = "标签表", firstLabelColumnName = "一级标签", secondLabelColumnName = "二级标签", describeColumnName = "描述";
        string filePath = "Provider = Microsoft.ACE.OLEDB.12.0;Data source = userData.accdb";

        OleDbConnection connection;
        OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
        DataSet dataSet = new DataSet("MyDataSet");


        public FormAna()
        {
            InitializeComponent();
        }

        private void FormAna_Load(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            string sql = String.Format("select * from {0} where {1} = #{2}#", yearAndMonthTableName, "日期", dt.ToString("yyyy/MM/dd"));
            //日期类型的两边要加#
            connection = new OleDbConnection(filePath);
            connection.Open();
            OleDbCommand command = new OleDbCommand(sql, connection);
            dataAdapter.SelectCommand = command;
            OleDbCommandBuilder builder = new OleDbCommandBuilder(dataAdapter);


        }
    }
}
