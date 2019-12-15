using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory.Model
{
    class SQLCommand
    {
        public static string SelectCommand(string tableName, string selectColumn, string primeColumn)
        {
            return string.Format("select * from {0} where {1}=@selectValue where {2}=@primeValue", tableName, selectColumn, primeColumn);
        }
        public static string InsertCommand(string tableName, int columnCount)
        {
            string command = string.Join(",", from number in Enumerable.Range(0, columnCount) select "@" + number.ToString());

            return $"insert into {tableName} values({command})";
        }
        public static string UpdateCommand(string tableName, string updatedColumn, string primeColumn)
        {
            return string.Format("update {0} set {1}=@updatedValue where {2}=@primeValue", tableName, updatedColumn, primeColumn);
        }
        public static string DeleteCommand(string tableName, string primeColumn)
        {
            return string.Format("delete from {0} where {1}=@primeValue", tableName, primeColumn);
        }

        public static string ExportTextCommand(string tableName)
        {
            return $"select * into outfile \'C:/ProgramData/MySQL/MySQL Server 5.7/Uploads/{tableName}-output.txt\' fields terminated by \',\' enclosed by \'\"\' escaped by \'\\\\\' lines terminated by \'\\n\' from {tableName}";
        }
        public static string ExportExcelCommand(string tableName)
        {
            return $"select * into outfile \'C:/ProgramData/MySQL/MySQL Server 5.7/Uploads/{tableName}-output.csv\' fields terminated by \',\' enclosed by \'\"\' escaped by \'\\\\\' lines terminated by \'\\n\' from {tableName}";
        }
    }
}
