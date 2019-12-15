using Dormitory.Presenter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dormitory.View
{
    public interface IDatabaseView
    {
        DataGridView StudentViewSection { get; set; }
        DataGridView LaptopViewSection { get; set; }
        DataGridView RoomViewSection { get; set; }
        DataSet StudentDataSet { get; set; }
        DataSet LaptopDataSet { get; set; }
        DataSet RoomDataSet { get; set; }
        StudentPresenter StudentPresenter { set; }
        RoomPresenter RoomPresenter { set; }
        LaptopPresenter LaptopPresenter { set; }
    }
}
