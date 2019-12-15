using Dormitory.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dormitory.View
{
    public partial class DormitoryForm : Form, IDatabaseView
    {
        public DormitoryForm()
        {
            InitializeComponent();
        }

        public StudentPresenter StudentPresenter { private get; set; }
        public RoomPresenter RoomPresenter { private get; set; }
        public LaptopPresenter LaptopPresenter { private get; set; }

        public DataGridView StudentViewSection { get => StudentView; set => StudentView = value; }
        public DataGridView RoomViewSection { get => RoomView; set => RoomView = value; }
        public DataGridView LaptopViewSection { get => LaptopView; set => LaptopView = value; }

        public DataSet StudentDataSet { get; set; } = new DataSet();
        public DataSet RoomDataSet { get; set; } = new DataSet();
        public DataSet LaptopDataSet { get; set; } = new DataSet();

        private void DormitoryForm_Load(object sender, EventArgs e)
        {
            StudentPresenter.RefreshDatabaseView();
            RoomPresenter.RefreshDatabaseView();
            LaptopPresenter.RefreshDatabaseView();
        }

        private void Stu_Search_btn_Click(object sender, EventArgs e)
        {
            StudentPresenter.SelectDataToDatabase(Student_name.Text, Student_num.Text, Stu_room_number.Text, IsGwangjuCheckBox.Checked, plus_point.Text, minus_point.Text);
            StudentPresenter.RefreshDatabaseView();
        }

        private void Stu_insert_btn_Click(object sender, EventArgs e)
        {
            StudentPresenter.InsertDataToDatabase();
            StudentPresenter.RefreshDatabaseView();
        }

        private void Stu_update_btn_Click(object sender, EventArgs e)
        {
            StudentPresenter.UpdateDataToDatabase();
            StudentPresenter.RefreshDatabaseView();
        }

        private void Stu_Delete_btn_Click(object sender, EventArgs e)
        {
            StudentPresenter.DeleteDataToDatabase();
            StudentPresenter.RefreshDatabaseView();
        }

        private void Stu_clear_btn_Click(object sender, EventArgs e)
        {
            Student_name.ResetText();
            Student_num.ResetText();
            Stu_room_number.ResetText();
            IsGwangjuCheckBox.Checked = false;
            plus_point.ResetText();
            minus_point.ResetText();

            StudentPresenter.SelectDataToDatabase(Student_name.Text, Student_num.Text, Stu_room_number.Text, IsGwangjuCheckBox.Checked, plus_point.Text, minus_point.Text);
            StudentPresenter.RefreshDatabaseView();
        }

        private void Room_search_btn_Click(object sender, EventArgs e)
        {
            RoomPresenter.SelectDataToDatabase();
        }

        private void Room_insert_btn_Click(object sender, EventArgs e)
        {
            RoomPresenter.InsertDataToDatabase();
            RoomPresenter.RefreshDatabaseView();
        }

        private void Room_update_btn_Click(object sender, EventArgs e)
        {
            RoomPresenter.UpdateDataToDatabase();
            RoomPresenter.RefreshDatabaseView();
        }

        private void Room_delete_btn_Click(object sender, EventArgs e)
        {
            RoomPresenter.DeleteDataToDatabase();
            RoomPresenter.RefreshDatabaseView();
        }

        private void Room_clear_btn_Click(object sender, EventArgs e)
        {
            room_number.ResetText();
            people_num.ResetText();
            last_roll_call.ResetText();
            last_clean_up.ResetText();
        }

        private void Laptop_search_btn_Click(object sender, EventArgs e)
        {
            LaptopPresenter.SelectDataToDatabase(Laptop_stu_num.Text, Laptop_num.Text, laptop_comboBox.Text, last_rental_date.Text, check_Yes.Checked);
            LaptopPresenter.RefreshDatabaseView();
        }

        private void Laptop_insert_btn_Click(object sender, EventArgs e)
        {
            LaptopPresenter.InsertDataToDatabase();
            LaptopPresenter.RefreshDatabaseView();
        }

        private void Laptop_update_btn_Click(object sender, EventArgs e)
        {
            LaptopPresenter.UpdateDataToDatabase();
            LaptopPresenter.RefreshDatabaseView();
        }

        private void Laptop_delete_btn_Click(object sender, EventArgs e)
        {
            LaptopPresenter.DeleteDataToDatabase();
            LaptopPresenter.RefreshDatabaseView();
        }

        private void Laptop_clear_btn_Click(object sender, EventArgs e)
        {
            Laptop_num.ResetText();
            Laptop_stu_num.ResetText();
            last_rental_date.ResetText();
            check_Yes.Checked = false;
            laptop_comboBox.ResetText();

            LaptopPresenter.SelectDataToDatabase(Laptop_stu_num.Text, Laptop_num.Text, laptop_comboBox.SelectedText, last_rental_date.Text, check_Yes.Checked);
            LaptopPresenter.RefreshDatabaseView();
        }

        private void StudentDatabaseToTXT_Click(object sender, EventArgs e)
        {
            StudentPresenter.ExportToText();
        }

        private void StudentDatabaseToCSV_Click(object sender, EventArgs e)
        {
            StudentPresenter.ExportToExcel();
        }

        private void RoomDatabaseToTxt_Click(object sender, EventArgs e)
        {
            RoomPresenter.ExportToText();
        }

        private void RoomDatabaseToExcel_Click(object sender, EventArgs e)
        {
            RoomPresenter.ExportToExcel();
        }

        private void LaptopDatabaseToTxt_Click(object sender, EventArgs e)
        {
            LaptopPresenter.ExportToText();
        }

        private void LaptopDatabaseToExcel_Click(object sender, EventArgs e)
        {
            LaptopPresenter.ExportToExcel();
        }
    }
}
