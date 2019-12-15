using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dormitory.Model
{
    class RelationRepository : IRelationRepository
    {
        protected MySqlConnection _connection;
        protected MySqlDataAdapter _adapter;
        private readonly string connectionString = "server=localhost;port=3306;database=dormitory;uid=root;pwd=@$#578IOPju;allow user variables=true;";

        public string TableName { get; set; }
        public int ColumnCount { get => DataGridView.ColumnCount; }
        public DataGridView DataGridView { get; set; }

        private delegate void QueryDelegate(dynamic data);

        public RelationRepository(string tableName)
        {
            TableName = tableName;
            _connection = new MySqlConnection(connectionString);
            _adapter = new MySqlDataAdapter($"select * from {TableName};", _connection);
        }

        public void FetchDataSet(DataSet dataSet)
        {
            _adapter.Fill(dataSet, TableName);
        }

        public void SelectData(IList datas)
        {
            AccessAndProcessQuery(datas, new QueryDelegate(_selectQuery));
        }

        public void InsertData(IList datas)
        {
            AccessAndProcessQuery(datas, new QueryDelegate(_insertQuery));
        }

        public void UpdateData(IList datas)
        {
            AccessAndProcessQuery(datas, new QueryDelegate(_updateQuery));
        }

        public void DeleteData(IList datas)
        {
            AccessAndProcessQuery(datas, new QueryDelegate(_deleteQuery));
        }

        public void ExportToText()
        {
            try
            {
                _connection.Open();

                _adapter.SelectCommand = new MySqlCommand(SQLCommand.ExportTextCommand(TableName), _connection);
                _adapter.SelectCommand.ExecuteNonQuery();
            }
            catch (MySqlException databaseEx)
            {
                MessageBox.Show(databaseEx.Message, "데이터베이스 오류");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "기타 오류");
            }
            finally
            {
                _connection.Close();
            }
        }

        public void ExportToExcel()
        {
            try
            {
                _connection.Open();

                _adapter.SelectCommand = new MySqlCommand(SQLCommand.ExportExcelCommand(TableName), _connection);
                _adapter.SelectCommand.ExecuteNonQuery();
            }
            catch (MySqlException databaseEx)
            {
                MessageBox.Show(databaseEx.Message, "데이터베이스 오류");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "기타 오류");
            }
            finally
            {
                _connection.Close();
            }
        }

        protected virtual void _selectQuery(dynamic data)
        {
            _adapter.SelectCommand = new MySqlCommand(SQLCommand.SelectCommand(TableName, DataGridView.Columns[data.ColumnIndex].Name, DataGridView.Columns[0].Name), _connection);
            _adapter.SelectCommand.Parameters.AddWithValue("@selectValue", DataGridView.Rows[data.RowIndex].Cells[data.ColumnIndex].Value.ToString());
            _adapter.SelectCommand.Parameters.AddWithValue("@primeValue", DataGridView.Rows[data.RowIndex].Cells[0].Value.ToString());
            _adapter.SelectCommand.ExecuteNonQuery();
        }

        protected virtual void _insertQuery(dynamic data)
        {
            _adapter.InsertCommand = new MySqlCommand(SQLCommand.InsertCommand(TableName, ColumnCount), _connection);

            for (int i = 0; i < ColumnCount; i++)
            {
                _adapter.InsertCommand.Parameters.AddWithValue("@" + i.ToString(), data.Cells[i].Value.ToString());
            }

            _adapter.InsertCommand.ExecuteNonQuery();
        }

        protected virtual void _updateQuery(dynamic data)
        {
            _adapter.UpdateCommand = new MySqlCommand(SQLCommand.UpdateCommand(TableName, DataGridView.Columns[data.ColumnIndex].Name, DataGridView.Columns[0].Name), _connection);
            _adapter.UpdateCommand.Parameters.AddWithValue("@updatedValue", DataGridView.Rows[data.RowIndex].Cells[data.ColumnIndex].Value.ToString());
            _adapter.UpdateCommand.Parameters.AddWithValue("@primeValue", DataGridView.Rows[data.RowIndex].Cells[0].Value.ToString());
            _adapter.UpdateCommand.ExecuteNonQuery();
        }

        protected virtual void _deleteQuery(dynamic data)
        {
            _adapter.DeleteCommand = new MySqlCommand(SQLCommand.DeleteCommand(TableName, DataGridView.Columns[0].Name), _connection);
            _adapter.DeleteCommand.Parameters.AddWithValue("@primeValue", data.Cells[0].Value.ToString());
            _adapter.DeleteCommand.ExecuteNonQuery();
        }

        private void AccessAndProcessQuery(dynamic datas, QueryDelegate queryDelegate)
        {
            try
            {
                _connection.Open();

                foreach (var data in datas)
                {
                    queryDelegate(data);
                }
            }
            catch (MySqlException databaseEx)
            {
                MessageBox.Show(databaseEx.Message, "데이터베이스 오류");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "기타 오류");
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}

