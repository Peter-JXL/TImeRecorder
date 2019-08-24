using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace TimeRecorder
{
    public partial class FormLabel : Form
    {
        #region 数据定义
        string labelTableName = GlobalData.labelTabelName;
        string firstLabelColumnName = GlobalData.firstLabelColumnName;
        string secondLabelColumnName = GlobalData.secondLabelColumnName;
        string noteColumnName = GlobalData.noteColumnName;
        string filePath = "Provider = Microsoft.ACE.OLEDB.12.0;  Data source = TimeRecorderData.accdb";

        OleDbConnection connection;
        OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
        DataSet myDataSet = new DataSet("MyDataSet");


        #endregion


        public FormLabel()
        {
            InitializeComponent();

            string sql = String.Format("select * from {0}", labelTableName);
            connection = new OleDbConnection(filePath);
            connection.Open();
            OleDbCommand command = new OleDbCommand(sql, connection);
            dataAdapter.SelectCommand = command;
            OleDbCommandBuilder builder = new OleDbCommandBuilder(dataAdapter);
            dataAdapter.Fill(myDataSet, labelTableName);
            connection.Close();


            dgvLabel.DataSource = myDataSet.Tables[labelTableName];
            dgvLabel.Columns[0].Visible = false;  //ID列隐藏
            dgvLabel.ImeMode = ImeMode.On;
           
            
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                dataAdapter.Update(myDataSet.Tables[labelTableName]);
                MessageBox.Show("更新成功!", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void FormLabel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.S: btnSave.PerformClick(); break;
                   
                    default: break;
                }
            }
        }
    }
}
