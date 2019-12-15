namespace Dormitory.View
{
    partial class DormitoryForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.student_table = new System.Windows.Forms.TabControl();
            this.stu_tab = new System.Windows.Forms.TabPage();
            this.StudentDatabaseToCSV = new System.Windows.Forms.Button();
            this.StudentDatabaseToTXT = new System.Windows.Forms.Button();
            this.Stu_insert_btn = new System.Windows.Forms.Button();
            this.Stu_clear_btn = new System.Windows.Forms.Button();
            this.Stu_update_btn = new System.Windows.Forms.Button();
            this.Stu_Delete_btn = new System.Windows.Forms.Button();
            this.Stu_Search_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.minus_point = new System.Windows.Forms.TextBox();
            this.plus_point = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.Stu_room_number = new System.Windows.Forms.TextBox();
            this.Student_name = new System.Windows.Forms.TextBox();
            this.Student_num = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentView = new System.Windows.Forms.DataGridView();
            this.room_tab = new System.Windows.Forms.TabPage();
            this.RoomDatabaseToExcel = new System.Windows.Forms.Button();
            this.RoomDatabaseToTxt = new System.Windows.Forms.Button();
            this.Room_insert_btn = new System.Windows.Forms.Button();
            this.Room_clear_btn = new System.Windows.Forms.Button();
            this.Room_update_btn = new System.Windows.Forms.Button();
            this.Room_delete_btn = new System.Windows.Forms.Button();
            this.Room_search_btn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.last_clean_up = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.last_roll_call = new System.Windows.Forms.TextBox();
            this.people_num = new System.Windows.Forms.TextBox();
            this.room_number = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.RoomView = new System.Windows.Forms.DataGridView();
            this.laptop_tab = new System.Windows.Forms.TabPage();
            this.Laptop_insert_btn = new System.Windows.Forms.Button();
            this.Laptop_clear_btn = new System.Windows.Forms.Button();
            this.Laptop_update_btn = new System.Windows.Forms.Button();
            this.Laptop_delete_btn = new System.Windows.Forms.Button();
            this.Laptop_search_btn = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.laptop_comboBox = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.check_Yes = new System.Windows.Forms.CheckBox();
            this.last_rental_date = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Laptop_num = new System.Windows.Forms.TextBox();
            this.Laptop_stu_num = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.LaptopView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LaptopDatabaseToTxt = new System.Windows.Forms.Button();
            this.LaptopDatabaseToExcel = new System.Windows.Forms.Button();
            this.student_table.SuspendLayout();
            this.stu_tab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentView)).BeginInit();
            this.room_tab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomView)).BeginInit();
            this.laptop_tab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LaptopView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // student_table
            // 
            this.student_table.Controls.Add(this.stu_tab);
            this.student_table.Controls.Add(this.room_tab);
            this.student_table.Controls.Add(this.laptop_tab);
            this.student_table.Font = new System.Drawing.Font("12롯데마트드림Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.student_table.Location = new System.Drawing.Point(15, 166);
            this.student_table.Margin = new System.Windows.Forms.Padding(6);
            this.student_table.Name = "student_table";
            this.student_table.SelectedIndex = 0;
            this.student_table.Size = new System.Drawing.Size(1974, 1172);
            this.student_table.TabIndex = 0;
            // 
            // stu_tab
            // 
            this.stu_tab.Controls.Add(this.StudentDatabaseToCSV);
            this.stu_tab.Controls.Add(this.StudentDatabaseToTXT);
            this.stu_tab.Controls.Add(this.Stu_insert_btn);
            this.stu_tab.Controls.Add(this.Stu_clear_btn);
            this.stu_tab.Controls.Add(this.Stu_update_btn);
            this.stu_tab.Controls.Add(this.Stu_Delete_btn);
            this.stu_tab.Controls.Add(this.Stu_Search_btn);
            this.stu_tab.Controls.Add(this.label2);
            this.stu_tab.Controls.Add(this.groupBox1);
            this.stu_tab.Controls.Add(this.StudentView);
            this.stu_tab.Location = new System.Drawing.Point(8, 41);
            this.stu_tab.Margin = new System.Windows.Forms.Padding(6);
            this.stu_tab.Name = "stu_tab";
            this.stu_tab.Padding = new System.Windows.Forms.Padding(6);
            this.stu_tab.Size = new System.Drawing.Size(1958, 1123);
            this.stu_tab.TabIndex = 0;
            this.stu_tab.Text = "학생";
            this.stu_tab.UseVisualStyleBackColor = true;
            // 
            // StudentDatabaseToCSV
            // 
            this.StudentDatabaseToCSV.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StudentDatabaseToCSV.Location = new System.Drawing.Point(1620, 812);
            this.StudentDatabaseToCSV.Margin = new System.Windows.Forms.Padding(6);
            this.StudentDatabaseToCSV.Name = "StudentDatabaseToCSV";
            this.StudentDatabaseToCSV.Size = new System.Drawing.Size(309, 80);
            this.StudentDatabaseToCSV.TabIndex = 9;
            this.StudentDatabaseToCSV.Text = "엑셀 파일로 추출";
            this.StudentDatabaseToCSV.UseVisualStyleBackColor = true;
            this.StudentDatabaseToCSV.Click += new System.EventHandler(this.StudentDatabaseToCSV_Click);
            // 
            // StudentDatabaseToTXT
            // 
            this.StudentDatabaseToTXT.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StudentDatabaseToTXT.Location = new System.Drawing.Point(1302, 812);
            this.StudentDatabaseToTXT.Margin = new System.Windows.Forms.Padding(6);
            this.StudentDatabaseToTXT.Name = "StudentDatabaseToTXT";
            this.StudentDatabaseToTXT.Size = new System.Drawing.Size(309, 80);
            this.StudentDatabaseToTXT.TabIndex = 8;
            this.StudentDatabaseToTXT.Text = ".txt로 추출";
            this.StudentDatabaseToTXT.UseVisualStyleBackColor = true;
            this.StudentDatabaseToTXT.Click += new System.EventHandler(this.StudentDatabaseToTXT_Click);
            // 
            // Stu_insert_btn
            // 
            this.Stu_insert_btn.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Stu_insert_btn.Location = new System.Drawing.Point(1461, 904);
            this.Stu_insert_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Stu_insert_btn.Name = "Stu_insert_btn";
            this.Stu_insert_btn.Size = new System.Drawing.Size(150, 80);
            this.Stu_insert_btn.TabIndex = 7;
            this.Stu_insert_btn.Text = "삽입";
            this.Stu_insert_btn.UseVisualStyleBackColor = true;
            this.Stu_insert_btn.Click += new System.EventHandler(this.Stu_insert_btn_Click);
            // 
            // Stu_clear_btn
            // 
            this.Stu_clear_btn.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Stu_clear_btn.Location = new System.Drawing.Point(1302, 996);
            this.Stu_clear_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Stu_clear_btn.Name = "Stu_clear_btn";
            this.Stu_clear_btn.Size = new System.Drawing.Size(628, 80);
            this.Stu_clear_btn.TabIndex = 6;
            this.Stu_clear_btn.Text = "검색 조건 초기화";
            this.Stu_clear_btn.UseVisualStyleBackColor = true;
            this.Stu_clear_btn.Click += new System.EventHandler(this.Stu_clear_btn_Click);
            // 
            // Stu_update_btn
            // 
            this.Stu_update_btn.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Stu_update_btn.Location = new System.Drawing.Point(1620, 904);
            this.Stu_update_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Stu_update_btn.Name = "Stu_update_btn";
            this.Stu_update_btn.Size = new System.Drawing.Size(150, 80);
            this.Stu_update_btn.TabIndex = 5;
            this.Stu_update_btn.Text = "수정";
            this.Stu_update_btn.UseVisualStyleBackColor = true;
            this.Stu_update_btn.Click += new System.EventHandler(this.Stu_update_btn_Click);
            // 
            // Stu_Delete_btn
            // 
            this.Stu_Delete_btn.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Stu_Delete_btn.Location = new System.Drawing.Point(1780, 904);
            this.Stu_Delete_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Stu_Delete_btn.Name = "Stu_Delete_btn";
            this.Stu_Delete_btn.Size = new System.Drawing.Size(150, 80);
            this.Stu_Delete_btn.TabIndex = 4;
            this.Stu_Delete_btn.Text = "삭제";
            this.Stu_Delete_btn.UseVisualStyleBackColor = true;
            this.Stu_Delete_btn.Click += new System.EventHandler(this.Stu_Delete_btn_Click);
            // 
            // Stu_Search_btn
            // 
            this.Stu_Search_btn.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Stu_Search_btn.Location = new System.Drawing.Point(1302, 904);
            this.Stu_Search_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Stu_Search_btn.Name = "Stu_Search_btn";
            this.Stu_Search_btn.Size = new System.Drawing.Size(150, 80);
            this.Stu_Search_btn.TabIndex = 3;
            this.Stu_Search_btn.Text = "검색";
            this.Stu_Search_btn.UseVisualStyleBackColor = true;
            this.Stu_Search_btn.Click += new System.EventHandler(this.Stu_Search_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("12롯데마트드림Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(1612, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "학생 정보 테이블";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.minus_point);
            this.groupBox1.Controls.Add(this.plus_point);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.Stu_room_number);
            this.groupBox1.Controls.Add(this.Student_name);
            this.groupBox1.Controls.Add(this.Student_num);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(1302, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(628, 694);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색조건";
            // 
            // minus_point
            // 
            this.minus_point.Location = new System.Drawing.Point(182, 576);
            this.minus_point.Margin = new System.Windows.Forms.Padding(6);
            this.minus_point.Name = "minus_point";
            this.minus_point.Size = new System.Drawing.Size(119, 39);
            this.minus_point.TabIndex = 11;
            // 
            // plus_point
            // 
            this.plus_point.Location = new System.Drawing.Point(182, 495);
            this.plus_point.Margin = new System.Windows.Forms.Padding(6);
            this.plus_point.Name = "plus_point";
            this.plus_point.Size = new System.Drawing.Size(119, 39);
            this.plus_point.TabIndex = 10;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(245, 412);
            this.address.Margin = new System.Windows.Forms.Padding(6);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(329, 39);
            this.address.TabIndex = 9;
            // 
            // Stu_room_number
            // 
            this.Stu_room_number.Location = new System.Drawing.Point(245, 332);
            this.Stu_room_number.Margin = new System.Windows.Forms.Padding(6);
            this.Stu_room_number.Name = "Stu_room_number";
            this.Stu_room_number.Size = new System.Drawing.Size(184, 39);
            this.Stu_room_number.TabIndex = 8;
            // 
            // Student_name
            // 
            this.Student_name.Location = new System.Drawing.Point(182, 250);
            this.Student_name.Margin = new System.Windows.Forms.Padding(6);
            this.Student_name.Name = "Student_name";
            this.Student_name.Size = new System.Drawing.Size(184, 39);
            this.Student_name.TabIndex = 7;
            // 
            // Student_num
            // 
            this.Student_num.Location = new System.Drawing.Point(182, 172);
            this.Student_num.Margin = new System.Windows.Forms.Padding(6);
            this.Student_num.Name = "Student_num";
            this.Student_num.Size = new System.Drawing.Size(184, 39);
            this.Student_num.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(71, 578);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 38);
            this.label8.TabIndex = 5;
            this.label8.Text = "벌점 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(71, 494);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 38);
            this.label7.TabIndex = 4;
            this.label7.Text = "상점 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(71, 414);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 38);
            this.label6.TabIndex = 3;
            this.label6.Text = "거주지역 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(71, 334);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 38);
            this.label5.TabIndex = 2;
            this.label5.Text = "소속호실 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(71, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 38);
            this.label4.TabIndex = 1;
            this.label4.Text = "이름 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(71, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "학번 :";
            // 
            // StudentView
            // 
            this.StudentView.AllowDrop = true;
            this.StudentView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StudentView.BackgroundColor = System.Drawing.Color.White;
            this.StudentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentView.GridColor = System.Drawing.Color.Gray;
            this.StudentView.Location = new System.Drawing.Point(37, 52);
            this.StudentView.Margin = new System.Windows.Forms.Padding(6);
            this.StudentView.Name = "StudentView";
            this.StudentView.RowTemplate.Height = 23;
            this.StudentView.Size = new System.Drawing.Size(1244, 1024);
            this.StudentView.TabIndex = 0;
            // 
            // room_tab
            // 
            this.room_tab.Controls.Add(this.RoomDatabaseToExcel);
            this.room_tab.Controls.Add(this.RoomDatabaseToTxt);
            this.room_tab.Controls.Add(this.Room_insert_btn);
            this.room_tab.Controls.Add(this.Room_clear_btn);
            this.room_tab.Controls.Add(this.Room_update_btn);
            this.room_tab.Controls.Add(this.Room_delete_btn);
            this.room_tab.Controls.Add(this.Room_search_btn);
            this.room_tab.Controls.Add(this.label15);
            this.room_tab.Controls.Add(this.groupBox2);
            this.room_tab.Controls.Add(this.RoomView);
            this.room_tab.Location = new System.Drawing.Point(8, 41);
            this.room_tab.Margin = new System.Windows.Forms.Padding(6);
            this.room_tab.Name = "room_tab";
            this.room_tab.Padding = new System.Windows.Forms.Padding(6);
            this.room_tab.Size = new System.Drawing.Size(1958, 1123);
            this.room_tab.TabIndex = 1;
            this.room_tab.Text = "호실";
            this.room_tab.UseVisualStyleBackColor = true;
            // 
            // RoomDatabaseToExcel
            // 
            this.RoomDatabaseToExcel.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RoomDatabaseToExcel.Location = new System.Drawing.Point(1628, 808);
            this.RoomDatabaseToExcel.Margin = new System.Windows.Forms.Padding(6);
            this.RoomDatabaseToExcel.Name = "RoomDatabaseToExcel";
            this.RoomDatabaseToExcel.Size = new System.Drawing.Size(309, 80);
            this.RoomDatabaseToExcel.TabIndex = 13;
            this.RoomDatabaseToExcel.Text = "엑셀 파일로 추출";
            this.RoomDatabaseToExcel.UseVisualStyleBackColor = true;
            this.RoomDatabaseToExcel.Click += new System.EventHandler(this.RoomDatabaseToExcel_Click);
            // 
            // RoomDatabaseToTxt
            // 
            this.RoomDatabaseToTxt.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RoomDatabaseToTxt.Location = new System.Drawing.Point(1307, 808);
            this.RoomDatabaseToTxt.Margin = new System.Windows.Forms.Padding(6);
            this.RoomDatabaseToTxt.Name = "RoomDatabaseToTxt";
            this.RoomDatabaseToTxt.Size = new System.Drawing.Size(309, 80);
            this.RoomDatabaseToTxt.TabIndex = 12;
            this.RoomDatabaseToTxt.Text = ".txt로 추출";
            this.RoomDatabaseToTxt.UseVisualStyleBackColor = true;
            this.RoomDatabaseToTxt.Click += new System.EventHandler(this.RoomDatabaseToTxt_Click);
            // 
            // Room_insert_btn
            // 
            this.Room_insert_btn.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Room_insert_btn.Location = new System.Drawing.Point(1466, 900);
            this.Room_insert_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Room_insert_btn.Name = "Room_insert_btn";
            this.Room_insert_btn.Size = new System.Drawing.Size(150, 80);
            this.Room_insert_btn.TabIndex = 11;
            this.Room_insert_btn.Text = "삽입";
            this.Room_insert_btn.UseVisualStyleBackColor = true;
            this.Room_insert_btn.Click += new System.EventHandler(this.Room_insert_btn_Click);
            // 
            // Room_clear_btn
            // 
            this.Room_clear_btn.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Room_clear_btn.Location = new System.Drawing.Point(1309, 992);
            this.Room_clear_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Room_clear_btn.Name = "Room_clear_btn";
            this.Room_clear_btn.Size = new System.Drawing.Size(628, 80);
            this.Room_clear_btn.TabIndex = 10;
            this.Room_clear_btn.Text = "검색 조건 초기화";
            this.Room_clear_btn.UseVisualStyleBackColor = true;
            this.Room_clear_btn.Click += new System.EventHandler(this.Room_clear_btn_Click);
            // 
            // Room_update_btn
            // 
            this.Room_update_btn.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Room_update_btn.Location = new System.Drawing.Point(1626, 900);
            this.Room_update_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Room_update_btn.Name = "Room_update_btn";
            this.Room_update_btn.Size = new System.Drawing.Size(150, 80);
            this.Room_update_btn.TabIndex = 9;
            this.Room_update_btn.Text = "수정";
            this.Room_update_btn.UseVisualStyleBackColor = true;
            this.Room_update_btn.Click += new System.EventHandler(this.Room_update_btn_Click);
            // 
            // Room_delete_btn
            // 
            this.Room_delete_btn.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Room_delete_btn.Location = new System.Drawing.Point(1785, 900);
            this.Room_delete_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Room_delete_btn.Name = "Room_delete_btn";
            this.Room_delete_btn.Size = new System.Drawing.Size(150, 80);
            this.Room_delete_btn.TabIndex = 8;
            this.Room_delete_btn.Text = "삭제";
            this.Room_delete_btn.UseVisualStyleBackColor = true;
            this.Room_delete_btn.Click += new System.EventHandler(this.Room_delete_btn_Click);
            // 
            // Room_search_btn
            // 
            this.Room_search_btn.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Room_search_btn.Location = new System.Drawing.Point(1307, 900);
            this.Room_search_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Room_search_btn.Name = "Room_search_btn";
            this.Room_search_btn.Size = new System.Drawing.Size(150, 80);
            this.Room_search_btn.TabIndex = 7;
            this.Room_search_btn.Text = "검색";
            this.Room_search_btn.UseVisualStyleBackColor = true;
            this.Room_search_btn.Click += new System.EventHandler(this.Room_search_btn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("12롯데마트드림Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(1618, 52);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(342, 48);
            this.label15.TabIndex = 3;
            this.label15.Text = "호실 정보 테이블";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.last_clean_up);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.last_roll_call);
            this.groupBox2.Controls.Add(this.people_num);
            this.groupBox2.Controls.Add(this.room_number);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(1307, 106);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(628, 690);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "검색조건";
            // 
            // last_clean_up
            // 
            this.last_clean_up.Location = new System.Drawing.Point(357, 470);
            this.last_clean_up.Margin = new System.Windows.Forms.Padding(6);
            this.last_clean_up.Name = "last_clean_up";
            this.last_clean_up.Size = new System.Drawing.Size(212, 39);
            this.last_clean_up.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(65, 472);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(291, 38);
            this.label9.TabIndex = 9;
            this.label9.Text = "마지막 청소 날짜 :";
            // 
            // last_roll_call
            // 
            this.last_roll_call.Location = new System.Drawing.Point(357, 392);
            this.last_roll_call.Margin = new System.Windows.Forms.Padding(6);
            this.last_roll_call.Name = "last_roll_call";
            this.last_roll_call.Size = new System.Drawing.Size(212, 39);
            this.last_roll_call.TabIndex = 8;
            // 
            // people_num
            // 
            this.people_num.Location = new System.Drawing.Point(240, 310);
            this.people_num.Margin = new System.Windows.Forms.Padding(6);
            this.people_num.Name = "people_num";
            this.people_num.Size = new System.Drawing.Size(102, 39);
            this.people_num.TabIndex = 7;
            // 
            // room_number
            // 
            this.room_number.Location = new System.Drawing.Point(240, 232);
            this.room_number.Margin = new System.Windows.Forms.Padding(6);
            this.room_number.Name = "room_number";
            this.room_number.Size = new System.Drawing.Size(121, 39);
            this.room_number.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(65, 394);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(291, 38);
            this.label12.TabIndex = 2;
            this.label12.Text = "마지막 점호 날짜 :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(65, 312);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(170, 38);
            this.label13.TabIndex = 1;
            this.label13.Text = "소속인원 :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(65, 234);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 38);
            this.label14.TabIndex = 0;
            this.label14.Text = "호실번호 :";
            // 
            // RoomView
            // 
            this.RoomView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RoomView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RoomView.BackgroundColor = System.Drawing.Color.White;
            this.RoomView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomView.GridColor = System.Drawing.Color.Gray;
            this.RoomView.Location = new System.Drawing.Point(37, 52);
            this.RoomView.Margin = new System.Windows.Forms.Padding(6);
            this.RoomView.Name = "RoomView";
            this.RoomView.RowTemplate.Height = 23;
            this.RoomView.Size = new System.Drawing.Size(1244, 1024);
            this.RoomView.TabIndex = 1;
            // 
            // laptop_tab
            // 
            this.laptop_tab.Controls.Add(this.LaptopDatabaseToExcel);
            this.laptop_tab.Controls.Add(this.LaptopDatabaseToTxt);
            this.laptop_tab.Controls.Add(this.Laptop_insert_btn);
            this.laptop_tab.Controls.Add(this.Laptop_clear_btn);
            this.laptop_tab.Controls.Add(this.Laptop_update_btn);
            this.laptop_tab.Controls.Add(this.Laptop_delete_btn);
            this.laptop_tab.Controls.Add(this.Laptop_search_btn);
            this.laptop_tab.Controls.Add(this.label18);
            this.laptop_tab.Controls.Add(this.groupBox3);
            this.laptop_tab.Controls.Add(this.LaptopView);
            this.laptop_tab.Location = new System.Drawing.Point(8, 41);
            this.laptop_tab.Margin = new System.Windows.Forms.Padding(6);
            this.laptop_tab.Name = "laptop_tab";
            this.laptop_tab.Padding = new System.Windows.Forms.Padding(6);
            this.laptop_tab.Size = new System.Drawing.Size(1958, 1123);
            this.laptop_tab.TabIndex = 2;
            this.laptop_tab.Text = "노트북";
            this.laptop_tab.UseVisualStyleBackColor = true;
            // 
            // Laptop_insert_btn
            // 
            this.Laptop_insert_btn.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Laptop_insert_btn.Location = new System.Drawing.Point(1463, 902);
            this.Laptop_insert_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Laptop_insert_btn.Name = "Laptop_insert_btn";
            this.Laptop_insert_btn.Size = new System.Drawing.Size(150, 80);
            this.Laptop_insert_btn.TabIndex = 15;
            this.Laptop_insert_btn.Text = "삽입";
            this.Laptop_insert_btn.UseVisualStyleBackColor = true;
            this.Laptop_insert_btn.Click += new System.EventHandler(this.Laptop_insert_btn_Click);
            // 
            // Laptop_clear_btn
            // 
            this.Laptop_clear_btn.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Laptop_clear_btn.Location = new System.Drawing.Point(1306, 994);
            this.Laptop_clear_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Laptop_clear_btn.Name = "Laptop_clear_btn";
            this.Laptop_clear_btn.Size = new System.Drawing.Size(628, 80);
            this.Laptop_clear_btn.TabIndex = 14;
            this.Laptop_clear_btn.Text = "검색 조건 초기화";
            this.Laptop_clear_btn.UseVisualStyleBackColor = true;
            this.Laptop_clear_btn.Click += new System.EventHandler(this.Laptop_clear_btn_Click);
            // 
            // Laptop_update_btn
            // 
            this.Laptop_update_btn.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Laptop_update_btn.Location = new System.Drawing.Point(1623, 902);
            this.Laptop_update_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Laptop_update_btn.Name = "Laptop_update_btn";
            this.Laptop_update_btn.Size = new System.Drawing.Size(150, 80);
            this.Laptop_update_btn.TabIndex = 13;
            this.Laptop_update_btn.Text = "수정";
            this.Laptop_update_btn.UseVisualStyleBackColor = true;
            this.Laptop_update_btn.Click += new System.EventHandler(this.Laptop_update_btn_Click);
            // 
            // Laptop_delete_btn
            // 
            this.Laptop_delete_btn.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Laptop_delete_btn.Location = new System.Drawing.Point(1785, 902);
            this.Laptop_delete_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Laptop_delete_btn.Name = "Laptop_delete_btn";
            this.Laptop_delete_btn.Size = new System.Drawing.Size(150, 80);
            this.Laptop_delete_btn.TabIndex = 12;
            this.Laptop_delete_btn.Text = "삭제";
            this.Laptop_delete_btn.UseVisualStyleBackColor = true;
            this.Laptop_delete_btn.Click += new System.EventHandler(this.Laptop_delete_btn_Click);
            // 
            // Laptop_search_btn
            // 
            this.Laptop_search_btn.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Laptop_search_btn.Location = new System.Drawing.Point(1304, 902);
            this.Laptop_search_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Laptop_search_btn.Name = "Laptop_search_btn";
            this.Laptop_search_btn.Size = new System.Drawing.Size(150, 80);
            this.Laptop_search_btn.TabIndex = 11;
            this.Laptop_search_btn.Text = "검색";
            this.Laptop_search_btn.UseVisualStyleBackColor = true;
            this.Laptop_search_btn.Click += new System.EventHandler(this.Laptop_search_btn_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("12롯데마트드림Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(1488, 52);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(482, 48);
            this.label18.TabIndex = 4;
            this.label18.Text = "노트북 대여 정보 테이블";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.laptop_comboBox);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.check_Yes);
            this.groupBox3.Controls.Add(this.last_rental_date);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.Laptop_num);
            this.groupBox3.Controls.Add(this.Laptop_stu_num);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(1307, 106);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(628, 684);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "검색조건";
            // 
            // laptop_comboBox
            // 
            this.laptop_comboBox.FormattingEnabled = true;
            this.laptop_comboBox.Items.AddRange(new object[] {
            "랩1실",
            "랩2실",
            "창업동아리1실",
            "창업동아리2실"});
            this.laptop_comboBox.Location = new System.Drawing.Point(238, 506);
            this.laptop_comboBox.Margin = new System.Windows.Forms.Padding(6);
            this.laptop_comboBox.Name = "laptop_comboBox";
            this.laptop_comboBox.Size = new System.Drawing.Size(221, 40);
            this.laptop_comboBox.TabIndex = 16;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(63, 508);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(170, 38);
            this.label19.TabIndex = 14;
            this.label19.Text = "사용장소 :";
            // 
            // check_Yes
            // 
            this.check_Yes.AutoSize = true;
            this.check_Yes.Location = new System.Drawing.Point(366, 440);
            this.check_Yes.Margin = new System.Windows.Forms.Padding(6);
            this.check_Yes.Name = "check_Yes";
            this.check_Yes.Size = new System.Drawing.Size(28, 27);
            this.check_Yes.TabIndex = 12;
            this.check_Yes.UseVisualStyleBackColor = true;
            // 
            // last_rental_date
            // 
            this.last_rental_date.Location = new System.Drawing.Point(355, 352);
            this.last_rental_date.Margin = new System.Windows.Forms.Padding(6);
            this.last_rental_date.Name = "last_rental_date";
            this.last_rental_date.Size = new System.Drawing.Size(212, 39);
            this.last_rental_date.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(63, 432);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(303, 38);
            this.label10.TabIndex = 9;
            this.label10.Text = "대여가 금지된 학생";
            // 
            // Laptop_num
            // 
            this.Laptop_num.Location = new System.Drawing.Point(280, 270);
            this.Laptop_num.Margin = new System.Windows.Forms.Padding(6);
            this.Laptop_num.Name = "Laptop_num";
            this.Laptop_num.Size = new System.Drawing.Size(102, 39);
            this.Laptop_num.TabIndex = 7;
            // 
            // Laptop_stu_num
            // 
            this.Laptop_stu_num.Location = new System.Drawing.Point(323, 192);
            this.Laptop_stu_num.Margin = new System.Windows.Forms.Padding(6);
            this.Laptop_stu_num.Name = "Laptop_stu_num";
            this.Laptop_stu_num.Size = new System.Drawing.Size(121, 39);
            this.Laptop_stu_num.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(63, 354);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(291, 38);
            this.label11.TabIndex = 2;
            this.label11.Text = "마지막 대여 날짜 :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(63, 272);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(214, 38);
            this.label16.TabIndex = 1;
            this.label16.Text = "노트북 번호 :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(63, 194);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(258, 38);
            this.label17.TabIndex = 0;
            this.label17.Text = "소유 학생 학번 :";
            // 
            // LaptopView
            // 
            this.LaptopView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LaptopView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.LaptopView.BackgroundColor = System.Drawing.Color.White;
            this.LaptopView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LaptopView.GridColor = System.Drawing.Color.Gray;
            this.LaptopView.Location = new System.Drawing.Point(37, 52);
            this.LaptopView.Margin = new System.Windows.Forms.Padding(6);
            this.LaptopView.Name = "LaptopView";
            this.LaptopView.RowTemplate.Height = 23;
            this.LaptopView.Size = new System.Drawing.Size(1244, 1024);
            this.LaptopView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("12롯데마트드림Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(852, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 96);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dormitory";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dormitory.Properties.Resources.csharp_gsm;
            this.pictureBox1.Location = new System.Drawing.Point(514, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 182);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LaptopDatabaseToTxt
            // 
            this.LaptopDatabaseToTxt.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LaptopDatabaseToTxt.Location = new System.Drawing.Point(1306, 810);
            this.LaptopDatabaseToTxt.Margin = new System.Windows.Forms.Padding(6);
            this.LaptopDatabaseToTxt.Name = "LaptopDatabaseToTxt";
            this.LaptopDatabaseToTxt.Size = new System.Drawing.Size(307, 80);
            this.LaptopDatabaseToTxt.TabIndex = 16;
            this.LaptopDatabaseToTxt.Text = ".txt로 추출";
            this.LaptopDatabaseToTxt.UseVisualStyleBackColor = true;
            this.LaptopDatabaseToTxt.Click += new System.EventHandler(this.LaptopDatabaseToTxt_Click);
            // 
            // LaptopDatabaseToExcel
            // 
            this.LaptopDatabaseToExcel.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LaptopDatabaseToExcel.Location = new System.Drawing.Point(1623, 810);
            this.LaptopDatabaseToExcel.Margin = new System.Windows.Forms.Padding(6);
            this.LaptopDatabaseToExcel.Name = "LaptopDatabaseToExcel";
            this.LaptopDatabaseToExcel.Size = new System.Drawing.Size(309, 80);
            this.LaptopDatabaseToExcel.TabIndex = 17;
            this.LaptopDatabaseToExcel.Text = "엑셀 파일로 추출";
            this.LaptopDatabaseToExcel.UseVisualStyleBackColor = true;
            this.LaptopDatabaseToExcel.Click += new System.EventHandler(this.LaptopDatabaseToExcel_Click);
            // 
            // DormitoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1983, 1338);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.student_table);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(2009, 1409);
            this.MinimumSize = new System.Drawing.Size(2009, 1409);
            this.Name = "DormitoryForm";
            this.Text = "기숙사 관리 시스템";
            this.Load += new System.EventHandler(this.DormitoryForm_Load);
            this.student_table.ResumeLayout(false);
            this.stu_tab.ResumeLayout(false);
            this.stu_tab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentView)).EndInit();
            this.room_tab.ResumeLayout(false);
            this.room_tab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomView)).EndInit();
            this.laptop_tab.ResumeLayout(false);
            this.laptop_tab.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LaptopView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl student_table;
        private System.Windows.Forms.TabPage stu_tab;
        private System.Windows.Forms.TabPage room_tab;
        private System.Windows.Forms.TabPage laptop_tab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView StudentView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Stu_room_number;
        private System.Windows.Forms.TextBox Student_name;
        private System.Windows.Forms.TextBox Student_num;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Button Stu_clear_btn;
        private System.Windows.Forms.Button Stu_update_btn;
        private System.Windows.Forms.Button Stu_Delete_btn;
        private System.Windows.Forms.Button Stu_Search_btn;
        private System.Windows.Forms.TextBox minus_point;
        private System.Windows.Forms.TextBox plus_point;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox last_roll_call;
        private System.Windows.Forms.TextBox people_num;
        private System.Windows.Forms.TextBox room_number;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView RoomView;
        private System.Windows.Forms.Button Room_clear_btn;
        private System.Windows.Forms.Button Room_update_btn;
        private System.Windows.Forms.Button Room_delete_btn;
        private System.Windows.Forms.Button Room_search_btn;
        private System.Windows.Forms.TextBox last_clean_up;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Laptop_clear_btn;
        private System.Windows.Forms.Button Laptop_update_btn;
        private System.Windows.Forms.Button Laptop_delete_btn;
        private System.Windows.Forms.Button Laptop_search_btn;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox check_Yes;
        private System.Windows.Forms.TextBox last_rental_date;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Laptop_num;
        private System.Windows.Forms.TextBox Laptop_stu_num;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView LaptopView;
        private System.Windows.Forms.ComboBox laptop_comboBox;
        private System.Windows.Forms.Button Stu_insert_btn;
        private System.Windows.Forms.Button Room_insert_btn;
        private System.Windows.Forms.Button Laptop_insert_btn;
        private System.Windows.Forms.Button StudentDatabaseToCSV;
        private System.Windows.Forms.Button StudentDatabaseToTXT;
        private System.Windows.Forms.Button RoomDatabaseToExcel;
        private System.Windows.Forms.Button RoomDatabaseToTxt;
        private System.Windows.Forms.Button LaptopDatabaseToExcel;
        private System.Windows.Forms.Button LaptopDatabaseToTxt;
    }
}

