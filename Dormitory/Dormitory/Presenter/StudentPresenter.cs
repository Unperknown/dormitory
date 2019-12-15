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

        public void SelectDataToDatabase(string student_name, string student_num, string room_number, bool isGwangju, string plus_point, string minus_point)
        {
            ((StudentRepository)_repository).SelectData(student_name, student_num, room_number, isGwangju, plus_point, minus_point);
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