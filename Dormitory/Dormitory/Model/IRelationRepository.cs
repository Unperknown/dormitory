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
    public interface IRelationRepository
    {
        string TableName { get; set; }
        DataGridView DataGridView { get; set; }
        void FetchDataSet(DataSet dataSet);
        void InsertData(IList datas);
        void UpdateData(IList datas);
        void DeleteData(IList datas);
        void ExportToText();
        void ExportToExcel();
    }
}