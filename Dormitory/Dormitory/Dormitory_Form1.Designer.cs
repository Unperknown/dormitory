namespace Dormitory
{
    partial class Dormitory_Form1
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.student_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.Room_dataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.student_table.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Room_dataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // student_table
            // 
            this.student_table.Controls.Add(this.tabPage1);
            this.student_table.Controls.Add(this.tabPage2);
            this.student_table.Controls.Add(this.tabPage3);
            this.student_table.Font = new System.Drawing.Font("12롯데마트드림Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.student_table.Location = new System.Drawing.Point(6, 83);
            this.student_table.Name = "student_table";
            this.student_table.SelectedIndex = 0;
            this.student_table.Size = new System.Drawing.Size(1063, 586);
            this.student_table.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Stu_clear_btn);
            this.tabPage1.Controls.Add(this.Stu_update_btn);
            this.tabPage1.Controls.Add(this.Stu_Delete_btn);
            this.tabPage1.Controls.Add(this.Stu_Search_btn);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.student_dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1055, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Stu_clear_btn
            // 
            this.Stu_clear_btn.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Stu_clear_btn.Location = new System.Drawing.Point(701, 498);
            this.Stu_clear_btn.Name = "Stu_clear_btn";
            this.Stu_clear_btn.Size = new System.Drawing.Size(338, 40);
            this.Stu_clear_btn.TabIndex = 6;
            this.Stu_clear_btn.Text = "검색 조건 초기화";
            this.Stu_clear_btn.UseVisualStyleBackColor = true;
            // 
            // Stu_update_btn
            // 
            this.Stu_update_btn.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Stu_update_btn.Location = new System.Drawing.Point(930, 452);
            this.Stu_update_btn.Name = "Stu_update_btn";
            this.Stu_update_btn.Size = new System.Drawing.Size(109, 40);
            this.Stu_update_btn.TabIndex = 5;
            this.Stu_update_btn.Text = "수정";
            this.Stu_update_btn.UseVisualStyleBackColor = true;
            // 
            // Stu_Delete_btn
            // 
            this.Stu_Delete_btn.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Stu_Delete_btn.Location = new System.Drawing.Point(819, 452);
            this.Stu_Delete_btn.Name = "Stu_Delete_btn";
            this.Stu_Delete_btn.Size = new System.Drawing.Size(105, 40);
            this.Stu_Delete_btn.TabIndex = 4;
            this.Stu_Delete_btn.Text = "삭제";
            this.Stu_Delete_btn.UseVisualStyleBackColor = true;
            // 
            // Stu_Search_btn
            // 
            this.Stu_Search_btn.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Stu_Search_btn.Location = new System.Drawing.Point(701, 452);
            this.Stu_Search_btn.Name = "Stu_Search_btn";
            this.Stu_Search_btn.Size = new System.Drawing.Size(112, 40);
            this.Stu_Search_btn.TabIndex = 3;
            this.Stu_Search_btn.Text = "검색";
            this.Stu_Search_btn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("12롯데마트드림Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(868, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
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
            this.groupBox1.Location = new System.Drawing.Point(701, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 382);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색조건";
            // 
            // minus_point
            // 
            this.minus_point.Location = new System.Drawing.Point(98, 288);
            this.minus_point.Name = "minus_point";
            this.minus_point.Size = new System.Drawing.Size(66, 23);
            this.minus_point.TabIndex = 11;
            // 
            // plus_point
            // 
            this.plus_point.Location = new System.Drawing.Point(98, 246);
            this.plus_point.Name = "plus_point";
            this.plus_point.Size = new System.Drawing.Size(66, 23);
            this.plus_point.TabIndex = 10;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(132, 206);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(179, 23);
            this.address.TabIndex = 9;
            // 
            // Stu_room_number
            // 
            this.Stu_room_number.Location = new System.Drawing.Point(132, 166);
            this.Stu_room_number.Name = "Stu_room_number";
            this.Stu_room_number.Size = new System.Drawing.Size(101, 23);
            this.Stu_room_number.TabIndex = 8;
            // 
            // Student_name
            // 
            this.Student_name.Location = new System.Drawing.Point(98, 125);
            this.Student_name.Name = "Student_name";
            this.Student_name.Size = new System.Drawing.Size(101, 23);
            this.Student_name.TabIndex = 7;
            // 
            // Student_num
            // 
            this.Student_num.Location = new System.Drawing.Point(98, 86);
            this.Student_num.Name = "Student_num";
            this.Student_num.Size = new System.Drawing.Size(101, 23);
            this.Student_num.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(38, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "벌점 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(38, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "상점 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(38, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "거주지역 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(38, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "소속호실 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(38, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "이름 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(38, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "학번 :";
            // 
            // student_dataGridView1
            // 
            this.student_dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.student_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.student_dataGridView1.Location = new System.Drawing.Point(20, 26);
            this.student_dataGridView1.Name = "student_dataGridView1";
            this.student_dataGridView1.RowTemplate.Height = 23;
            this.student_dataGridView1.Size = new System.Drawing.Size(670, 512);
            this.student_dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Room_clear_btn);
            this.tabPage2.Controls.Add(this.Room_update_btn);
            this.tabPage2.Controls.Add(this.Room_delete_btn);
            this.tabPage2.Controls.Add(this.Room_search_btn);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.Room_dataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1055, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Room_clear_btn
            // 
            this.Room_clear_btn.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Room_clear_btn.Location = new System.Drawing.Point(705, 496);
            this.Room_clear_btn.Name = "Room_clear_btn";
            this.Room_clear_btn.Size = new System.Drawing.Size(338, 40);
            this.Room_clear_btn.TabIndex = 10;
            this.Room_clear_btn.Text = "검색 조건 초기화";
            this.Room_clear_btn.UseVisualStyleBackColor = true;
            // 
            // Room_update_btn
            // 
            this.Room_update_btn.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Room_update_btn.Location = new System.Drawing.Point(934, 450);
            this.Room_update_btn.Name = "Room_update_btn";
            this.Room_update_btn.Size = new System.Drawing.Size(109, 40);
            this.Room_update_btn.TabIndex = 9;
            this.Room_update_btn.Text = "수정";
            this.Room_update_btn.UseVisualStyleBackColor = true;
            // 
            // Room_delete_btn
            // 
            this.Room_delete_btn.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Room_delete_btn.Location = new System.Drawing.Point(822, 450);
            this.Room_delete_btn.Name = "Room_delete_btn";
            this.Room_delete_btn.Size = new System.Drawing.Size(105, 40);
            this.Room_delete_btn.TabIndex = 8;
            this.Room_delete_btn.Text = "삭제";
            this.Room_delete_btn.UseVisualStyleBackColor = true;
            // 
            // Room_search_btn
            // 
            this.Room_search_btn.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Room_search_btn.Location = new System.Drawing.Point(704, 450);
            this.Room_search_btn.Name = "Room_search_btn";
            this.Room_search_btn.Size = new System.Drawing.Size(112, 40);
            this.Room_search_btn.TabIndex = 7;
            this.Room_search_btn.Text = "검색";
            this.Room_search_btn.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("12롯데마트드림Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(871, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(171, 24);
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
            this.groupBox2.Location = new System.Drawing.Point(704, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 382);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "검색조건";
            // 
            // last_clean_up
            // 
            this.last_clean_up.Location = new System.Drawing.Point(192, 235);
            this.last_clean_up.Name = "last_clean_up";
            this.last_clean_up.Size = new System.Drawing.Size(116, 23);
            this.last_clean_up.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(35, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "마지막 청소 날짜 :";
            // 
            // last_roll_call
            // 
            this.last_roll_call.Location = new System.Drawing.Point(192, 196);
            this.last_roll_call.Name = "last_roll_call";
            this.last_roll_call.Size = new System.Drawing.Size(116, 23);
            this.last_roll_call.TabIndex = 8;
            // 
            // people_num
            // 
            this.people_num.Location = new System.Drawing.Point(129, 155);
            this.people_num.Name = "people_num";
            this.people_num.Size = new System.Drawing.Size(57, 23);
            this.people_num.TabIndex = 7;
            // 
            // room_number
            // 
            this.room_number.Location = new System.Drawing.Point(129, 116);
            this.room_number.Name = "room_number";
            this.room_number.Size = new System.Drawing.Size(67, 23);
            this.room_number.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(35, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 19);
            this.label12.TabIndex = 2;
            this.label12.Text = "마지막 점호 날짜 :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(35, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 19);
            this.label13.TabIndex = 1;
            this.label13.Text = "소속인원 :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(35, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "호실번호 :";
            // 
            // Room_dataGridView
            // 
            this.Room_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Room_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Room_dataGridView.GridColor = System.Drawing.Color.Gray;
            this.Room_dataGridView.Location = new System.Drawing.Point(20, 26);
            this.Room_dataGridView.Name = "Room_dataGridView";
            this.Room_dataGridView.RowTemplate.Height = 23;
            this.Room_dataGridView.Size = new System.Drawing.Size(670, 512);
            this.Room_dataGridView.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Laptop_clear_btn);
            this.tabPage3.Controls.Add(this.Laptop_update_btn);
            this.tabPage3.Controls.Add(this.Laptop_delete_btn);
            this.tabPage3.Controls.Add(this.Laptop_search_btn);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1055, 559);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Laptop_clear_btn
            // 
            this.Laptop_clear_btn.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Laptop_clear_btn.Location = new System.Drawing.Point(703, 497);
            this.Laptop_clear_btn.Name = "Laptop_clear_btn";
            this.Laptop_clear_btn.Size = new System.Drawing.Size(338, 40);
            this.Laptop_clear_btn.TabIndex = 14;
            this.Laptop_clear_btn.Text = "검색 조건 초기화";
            this.Laptop_clear_btn.UseVisualStyleBackColor = true;
            // 
            // Laptop_update_btn
            // 
            this.Laptop_update_btn.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Laptop_update_btn.Location = new System.Drawing.Point(932, 451);
            this.Laptop_update_btn.Name = "Laptop_update_btn";
            this.Laptop_update_btn.Size = new System.Drawing.Size(109, 40);
            this.Laptop_update_btn.TabIndex = 13;
            this.Laptop_update_btn.Text = "수정";
            this.Laptop_update_btn.UseVisualStyleBackColor = true;
            // 
            // Laptop_delete_btn
            // 
            this.Laptop_delete_btn.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Laptop_delete_btn.Location = new System.Drawing.Point(820, 451);
            this.Laptop_delete_btn.Name = "Laptop_delete_btn";
            this.Laptop_delete_btn.Size = new System.Drawing.Size(105, 40);
            this.Laptop_delete_btn.TabIndex = 12;
            this.Laptop_delete_btn.Text = "삭제";
            this.Laptop_delete_btn.UseVisualStyleBackColor = true;
            // 
            // Laptop_search_btn
            // 
            this.Laptop_search_btn.Font = new System.Drawing.Font("12롯데마트드림Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Laptop_search_btn.Location = new System.Drawing.Point(702, 451);
            this.Laptop_search_btn.Name = "Laptop_search_btn";
            this.Laptop_search_btn.Size = new System.Drawing.Size(112, 40);
            this.Laptop_search_btn.TabIndex = 11;
            this.Laptop_search_btn.Text = "검색";
            this.Laptop_search_btn.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("12롯데마트드림Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(801, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(241, 24);
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
            this.groupBox3.Location = new System.Drawing.Point(704, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 382);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "검색조건";
            // 
            // laptop_comboBox
            // 
            this.laptop_comboBox.FormattingEnabled = true;
            this.laptop_comboBox.Items.AddRange(new object[] {
            "Lap1실",
            "Lap2실",
            "창업동아리1실",
            "창업동아리2실"});
            this.laptop_comboBox.Location = new System.Drawing.Point(128, 253);
            this.laptop_comboBox.Name = "laptop_comboBox";
            this.laptop_comboBox.Size = new System.Drawing.Size(121, 24);
            this.laptop_comboBox.TabIndex = 16;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(34, 254);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 19);
            this.label19.TabIndex = 14;
            this.label19.Text = "사용장소 :";
            // 
            // check_Yes
            // 
            this.check_Yes.AutoSize = true;
            this.check_Yes.Location = new System.Drawing.Point(197, 220);
            this.check_Yes.Name = "check_Yes";
            this.check_Yes.Size = new System.Drawing.Size(15, 14);
            this.check_Yes.TabIndex = 12;
            this.check_Yes.UseVisualStyleBackColor = true;
            // 
            // last_rental_date
            // 
            this.last_rental_date.Location = new System.Drawing.Point(191, 176);
            this.last_rental_date.Name = "last_rental_date";
            this.last_rental_date.Size = new System.Drawing.Size(116, 23);
            this.last_rental_date.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(34, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "대여가 금지된 학생";
            // 
            // Laptop_num
            // 
            this.Laptop_num.Location = new System.Drawing.Point(151, 135);
            this.Laptop_num.Name = "Laptop_num";
            this.Laptop_num.Size = new System.Drawing.Size(57, 23);
            this.Laptop_num.TabIndex = 7;
            // 
            // Laptop_stu_num
            // 
            this.Laptop_stu_num.Location = new System.Drawing.Point(174, 96);
            this.Laptop_stu_num.Name = "Laptop_stu_num";
            this.Laptop_stu_num.Size = new System.Drawing.Size(67, 23);
            this.Laptop_stu_num.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(34, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "마지막 대여 날짜 :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(34, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 19);
            this.label16.TabIndex = 1;
            this.label16.Text = "노트북 번호 :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("12롯데마트드림Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(34, 97);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 19);
            this.label17.TabIndex = 0;
            this.label17.Text = "소유 학생 학번 :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(20, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(670, 512);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("12롯데마트드림Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(459, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dormitory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dormitory.Properties.Resources.csharp_gsm;
            this.pictureBox1.Location = new System.Drawing.Point(277, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 91);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Dormitory_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 669);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.student_table);
            this.Name = "Dormitory_Form1";
            this.Text = "Form1";
            this.student_table.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Room_dataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl student_table;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView student_dataGridView1;
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
        private System.Windows.Forms.DataGridView Room_dataGridView;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox laptop_comboBox;
    }
}

