using Dormitory.Model;
using Dormitory.View;

namespace Dormitory.Presenter
{
    public class LaptopPresenter : DatabasePresenter
    {
        public LaptopPresenter(IDatabaseView view, IRelationRepository repository) : base(view, repository)
        {
            _view.LaptopPresenter = this;
            _repository.DataGridView = _view.LaptopViewSection;
        }

        public override void RefreshDatabaseView()
        {
            _view.LaptopDataSet.Clear();
            _view.LaptopViewSection.Refresh();
            _repository.FetchDataSet(_view.LaptopDataSet);
            _view.LaptopViewSection.DataSource = _view.LaptopDataSet.Tables[_repository.TableName];
        }

        public void SelectDataToDatabase(string stu_num, string laptop_num, string use_location, string last_rental_date, bool isBanned)
        {
            ((LaptopRepository)_repository).SelectData(stu_num, laptop_num, use_location, last_rental_date, isBanned);
        }

        public override void InsertDataToDatabase()
        {
            _repository.InsertData(_view.LaptopViewSection.SelectedRows);
        }

        public override void UpdateDataToDatabase()
        {
            _repository.UpdateData(_view.LaptopViewSection.SelectedCells);
        }

        public override void DeleteDataToDatabase()
        {
            _repository.DeleteData(_view.LaptopViewSection.SelectedRows);
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