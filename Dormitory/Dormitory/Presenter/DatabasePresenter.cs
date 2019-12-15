using Dormitory.Model;
using Dormitory.View;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Dormitory.Presenter
{
    public class DatabasePresenter
    {
        public IDatabaseView _view;
        public IRelationRepository _repository;

        public DatabasePresenter(IDatabaseView view, IRelationRepository repository)
        {
            _view = view;
            _repository = repository;
        }
        
        public virtual void RefreshDatabaseView() { }
        public virtual void SelectDataToDatabase() { }
        public virtual void InsertDataToDatabase() { }
        public virtual void UpdateDataToDatabase() { }
        public virtual void DeleteDataToDatabase() { }
        public virtual void ExportToText() { }
        public virtual void ExportToExcel() { }
    }
}