using Dormitory.Model;
using Dormitory.View;

namespace Dormitory.Presenter
{
    public class RoomPresenter : DatabasePresenter
    {
        public RoomPresenter(IDatabaseView view, IRelationRepository repository) : base(view, repository)
        {
            _view.RoomPresenter = this;
            _repository.DataGridView = _view.RoomViewSection;
        }

        public override void RefreshDatabaseView()
        {
            _view.RoomDataSet.Clear();
            _view.RoomViewSection.Refresh();
            _repository.FetchDataSet(_view.RoomDataSet);
            _view.RoomViewSection.DataSource = _view.RoomDataSet.Tables[_repository.TableName];
        }

        public void SelectDataToDatabase(string room_number, string people_num, string last_roll_call, string last_clean_up)
        {
            ((RoomRepository)_repository).SelectData(room_number, people_num, last_roll_call, last_clean_up);
        }

        public override void InsertDataToDatabase()
        {
            _repository.InsertData(_view.RoomViewSection.SelectedRows);
        }

        public override void UpdateDataToDatabase()
        {
            _repository.UpdateData(_view.RoomViewSection.SelectedCells);
        }

        public override void DeleteDataToDatabase()
        {
            _repository.DeleteData(_view.RoomViewSection.SelectedRows);
        }

        public override void ExportToText()
        {
            _repository.ExportToText();
        }
        public override void ExportToExcel()
        {
            _repository.ExportToExcel();
        }
    }
}