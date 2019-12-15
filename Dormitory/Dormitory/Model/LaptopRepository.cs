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
    class LaptopRepository : RelationRepository
    {
        public LaptopRepository(string tableName) : base(tableName) { }

        protected new void _insertQuery(dynamic data)
        {
            _adapter.InsertCommand = new MySqlCommand(SQLCommand.InsertCommand(TableName, ColumnCount), _connection);

            for (int i = 0; i < ColumnCount; i++)
            {
                if (i == 3)
                {
                    _adapter.InsertCommand.Parameters.AddWithValue("@" + i.ToString(), Convert.ToDateTime(data.Cells[i].Value));
                }
                _adapter.InsertCommand.Parameters.AddWithValue("@" + i.ToString(), data.Cells[i].Value.ToString());
            }

            _adapter.InsertCommand.ExecuteNonQuery();
        }
        protected new void _updateQuery(dynamic data)
        {
            _adapter.UpdateCommand = new MySqlCommand(SQLCommand.UpdateCommand(TableName, DataGridView.Columns[data.ColumnIndex].Name, DataGridView.Columns[0].Name), _connection);
            _adapter.UpdateCommand.Parameters.AddWithValue("@updatedValue", Convert.ToDateTime(DataGridView.Rows[data.RowIndex].Cells[data.ColumnIndex].Value).ToString("yyyy-MM-dd HH:mm:ss"));
            _adapter.UpdateCommand.Parameters.AddWithValue("@primeValue", DataGridView.Rows[data.RowIndex].Cells[0].Value.ToString());
            _adapter.UpdateCommand.ExecuteNonQuery();
        }
    }
}
