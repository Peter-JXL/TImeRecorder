using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace TimeRecorder
{
    public partial class FormLabel : Form
    {
        OleDbConnection connection;
        OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
        DataSet dataSet = new DataSet("MyDataSet");

        public FormLabel()
        {
            InitializeComponent();
            string filePath = "Provider = Microsoft.ACE.OLEDB.12.0;Data source = userData.accdb";
            string sql = "select * from 标签表";

            connection = new OleDbConnection(filePath);
            connection.Open();
            OleDbCommand command = new OleDbCommand(sql, connection);
            dataAdapter.SelectCommand = command;
            OleDbCommandBuilder builder = new OleDbCommandBuilder(dataAdapter);


            dataAdapter.Fill(dataSet, "Lable");
            dgvLabel.DataSource = dataSet.Tables["Lable"];
            dgvLabel.Columns[0].Visible = false;
            connection.Close();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                dataAdapter.Update(dataSet.Tables["Lable"]);
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
            if (e.KeyCode == Keys.S && e.Control)
            {
                btnSave.PerformClick();
            }
        }
    }
}
