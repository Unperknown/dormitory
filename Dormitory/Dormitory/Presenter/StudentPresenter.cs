using Dormitory.Model;
using Dormitory.View;

namespace Dormitory.Presenter
{
    public class StudentPresenter : DatabasePresenter
    {
        public StudentPresenter(IDatabaseView view, IRelationRepository repository) : base(view, repository)
        {
            _view.StudentPresenter = this;
            _repository.DataGridView = _view.StudentViewSection;
        }

        public override void RefreshDatabaseView()
        {
            _view.StudentDataSet.Clear();
            _view.StudentViewSection.Refresh();
            _repository.FetchDataSet(_view.StudentDataSet);
            _view.StudentViewSection.DataSource = _view.StudentDataSet.Tables[_repository.TableName];
        }

        public override void SelectDataToDatabase()
        {
        }

        public override void InsertDataToDatabase()
        {
            _repository.InsertData(_view.StudentViewSection.SelectedRows);
        }

        public override void UpdateDataToDatabase()
        {
            _repository.UpdateData(_view.StudentViewSection.SelectedCells);
        }

        public override void DeleteDataToDatabase()
        {
            _repository.DeleteData(_view.StudentViewSection.SelectedRows);
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