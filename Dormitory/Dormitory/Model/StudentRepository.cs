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
    class StudentRepository : RelationRepository
    {
        public StudentRepository(string tableName) : base(tableName) { }

        public void SelectData(string student_name, string student_num, string room_number, bool isGwangju, string plus_point, string minus_point)
        {
            try
            {
                _connection.Open();

                string selectCommand = $"select * from {TableName}";
                List<string> extraCommand = new List<string>();

                if (student_name != "")
                {
                    extraCommand.Add($"name = \'{student_name}\'");
                }

                if (student_num != "")
                {
                    extraCommand.Add($"stu_num = \'{student_num}\'");
                }

                if (room_number != "")
                {
                    extraCommand.Add($"room_number = \'{room_number}\'");
                }

                if (isGwangju == true)
                {
                    extraCommand.Add($"address != \'Gwangju\'");
                }

                if (plus_point != "")
                {
                    extraCommand.Add($"plus_point = {plus_point}");
                }

                if (minus_point != "")
                {
                    extraCommand.Add($"minus_point = {minus_point}");
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
    }
}

