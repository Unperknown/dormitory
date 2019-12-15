using Dormitory.View;
using Dormitory.Presenter;
using Dormitory.Model;
using System;
using System.Windows.Forms;

namespace Dormitory
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var studentRepository = new StudentRepository("student");
            var roomRepository = new RoomRepository("room");
            var laptopRepository = new LaptopRepository("laptop");

            var view = new DormitoryForm();

            var studentPresenter = new StudentPresenter(view, studentRepository);
            var roomPresenter = new RoomPresenter(view, roomRepository);
            var laptopPresenter = new LaptopPresenter(view, laptopRepository);

            Application.Run(view);
        }
    }
}
