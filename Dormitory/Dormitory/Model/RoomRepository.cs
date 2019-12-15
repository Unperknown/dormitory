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
    }
}
