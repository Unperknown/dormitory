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
    class RoomRepository : RelationRepository
    {
        public RoomRepository(string tableName) : base(tableName) { }

        public void SelectData(string room_number, string people_num, string last_roll_call, string last_clean_up)
        {
            try
            {
                _connection.Open();

                string selectCommand = $"select * from {TableName}";
                List<string> extraCommand = new List<string>();

                if (room_number != "")
                {
                    extraCommand.Add($"room_number = \'{room_number}\'");
                }

                if (people_num != "")
                {
                    extraCommand.Add($"people_num = \'{people_num}\'");
                }

                if (last_roll_call != "")
                {
                    extraCommand.Add($"last_roll_call = \'{last_roll_call.ToString().Substring(0, 11)}\'");
                }
                
                if (last_clean_up != "")
                {
                    extraCommand.Add($"last_clean_up = \'{last_clean_up.ToString().Substring(0, 11)}\'");
                }
                
                if (extraCommand.Count() != 0)
                {
                    string whereQuery = " where " + string.Join("and", from command in extraCommand select command);

                    selectCommand += whereQuery;
                }

                _adapter.SelectCommand = new MySqlCommand(selectCommand, _connection);
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

        protected override void _insertQuery(dynamic data)
        {
            _adapter.InsertCommand = new MySqlCommand(SQLCommand.InsertCommand(TableName, ColumnCount), _connection);

            for (int i = 0; i < ColumnCount; i++)
            {
                if (i == 2 || i == 3)
                {
                    _adapter.InsertCommand.Parameters.AddWithValue("@" + i.ToString(), data.Cells[i].Value.ToString().Substring(0, 11));
                    continue;
                }

                _adapter.InsertCommand.Parameters.AddWithValue("@" + i.ToString(), data.Cells[i].Value.ToString());
            }

            _adapter.InsertCommand.ExecuteNonQuery();
        }

        protected override void _updateQuery(dynamic data)
        {
            _adapter.UpdateCommand = new MySqlCommand(SQLCommand.UpdateCommand(TableName, DataGridView.Columns[data.ColumnIndex].Name, DataGridView.Columns[0].Name), _connection);

            if (DataGridView.Columns[data.ColumnIndex].Name == "last_roll_call" || DataGridView.Columns[data.ColumnIndex].Name == "last_clean_up")
            {
                _adapter.UpdateCommand.Parameters.AddWithValue("@updatedValue", DataGridView.Rows[data.RowIndex].Cells[data.ColumnIndex].Value.ToString().Substring(0, 11));
            }
            else
            {
                _adapter.UpdateCommand.Parameters.AddWithValue("@updatedValue", DataGridView.Rows[data.RowIndex].Cells[data.ColumnIndex].Value.ToString());
            }

            _adapter.UpdateCommand.Parameters.AddWithValue("@primeValue", DataGridView.Rows[data.RowIndex].Cells[0].Value.ToString());
            _adapter.UpdateCommand.ExecuteNonQuery();
        }

        protected override void _deleteQuery(dynamic data)
        {
            _adapter.DeleteCommand = new MySqlCommand(SQLCommand.DeleteCommand(TableName, DataGridView.Columns[0].Name), _connection);
            _adapter.DeleteCommand.Parameters.AddWithValue("@primeValue", data.Cells[0].Value.ToString());
            _adapter.DeleteCommand.ExecuteNonQuery();
        }
    }
}
