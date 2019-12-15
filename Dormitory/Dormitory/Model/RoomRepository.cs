﻿using MySql.Data.MySqlClient;
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
