namespace TeamProject1_ToDoList
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            upper_panel = new Panel();
            search_btn = new Button();
            MainPicture = new PictureBox();
            Entered_Text = new TextBox();
            lbl_name = new Label();
            lbl_account = new Label();
            ArchiveShow_btn = new Button();
            left_panel = new Panel();
            AppointTask_lbl = new Button();
            MyGroups_btn = new Button();
            substrate = new Panel();
            group_tasks_lbl = new Label();
            PersonGroups_list = new ListBox();
            lbl_mygroups = new Label();
            frame2 = new Panel();
            Calendar_lbl = new Label();
            personal_affairs_btn = new Button();
            frame = new Panel();
            my_tasks_lbl = new Label();
            TypeOfTask_lbl = new Label();
            InfoTabel = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Group = new DataGridViewTextBoxColumn();
            right_panel = new Panel();
            TaskAdd_btn = new Button();
            TaskDelete_btn = new Button();
            TaskDone_btn = new Button();
            frame5 = new Panel();
            task_group = new Label();
            frame4 = new Panel();
            task_date = new Label();
            frame3 = new Panel();
            task_parameter = new Label();
            frame1 = new Panel();
            task_discription = new Label();
            lbl_date = new Label();
            lbl_group = new Label();
            lbl_parameter = new Label();
            lbl_discription = new Label();
            lbl_information = new Label();
            upper_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainPicture).BeginInit();
            left_panel.SuspendLayout();
            substrate.SuspendLayout();
            frame2.SuspendLayout();
            frame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InfoTabel).BeginInit();
            frame5.SuspendLayout();
            frame4.SuspendLayout();
            frame3.SuspendLayout();
            frame1.SuspendLayout();
            SuspendLayout();
            // 
            // upper_panel
            // 
            upper_panel.BackColor = Color.FromArgb(248, 241, 237);
            upper_panel.BorderStyle = BorderStyle.FixedSingle;
            upper_panel.Controls.Add(search_btn);
            upper_panel.Controls.Add(MainPicture);
            upper_panel.Controls.Add(Entered_Text);
            upper_panel.Controls.Add(lbl_name);
            upper_panel.Controls.Add(lbl_account);
            upper_panel.Location = new Point(-13, 0);
            upper_panel.Name = "upper_panel";
            upper_panel.Size = new Size(1691, 82);
            upper_panel.TabIndex = 0;
            // 
            // search_btn
            // 
            search_btn.BackgroundImage = Properties.Resources.SearchPicture1;
            search_btn.Location = new Point(1627, 28);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(38, 35);
            search_btn.TabIndex = 62;
            search_btn.UseVisualStyleBackColor = true;
            // 
            // MainPicture
            // 
            MainPicture.Image = Properties.Resources.MainIcon;
            MainPicture.Location = new Point(24, 5);
            MainPicture.Name = "MainPicture";
            MainPicture.Size = new Size(72, 72);
            MainPicture.TabIndex = 16;
            MainPicture.TabStop = false;
            // 
            // Entered_Text
            // 
            Entered_Text.BorderStyle = BorderStyle.FixedSingle;
            Entered_Text.Font = new Font("XO Courser", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Entered_Text.ForeColor = SystemColors.ControlDark;
            Entered_Text.Location = new Point(1318, 28);
            Entered_Text.Name = "Entered_Text";
            Entered_Text.Size = new Size(321, 35);
            Entered_Text.TabIndex = 61;
            Entered_Text.TabStop = false;
            Entered_Text.Text = "Поиск по таблице..";
            Entered_Text.Click += window_clear;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_name.ForeColor = Color.FromArgb(159, 108, 80);
            lbl_name.Location = new Point(112, 8);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(127, 40);
            lbl_name.TabIndex = 18;
            lbl_name.Text = "Namee_";
            lbl_name.Click += lbl_name_Click_1;
            // 
            // lbl_account
            // 
            lbl_account.AutoSize = true;
            lbl_account.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_account.ForeColor = Color.Gray;
            lbl_account.Location = new Point(116, 43);
            lbl_account.Name = "lbl_account";
            lbl_account.Size = new Size(179, 31);
            lbl_account.TabIndex = 17;
            lbl_account.Text = "Учетная запись";
            // 
            // ArchiveShow_btn
            // 
            ArchiveShow_btn.Font = new Font("XO Courser", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ArchiveShow_btn.ForeColor = Color.FromArgb(159, 108, 80);
            ArchiveShow_btn.Location = new Point(1295, 1062);
            ArchiveShow_btn.Name = "ArchiveShow_btn";
            ArchiveShow_btn.Size = new Size(370, 35);
            ArchiveShow_btn.TabIndex = 51;
            ArchiveShow_btn.Text = "Архив выполненных задач";
            ArchiveShow_btn.UseVisualStyleBackColor = true;
            ArchiveShow_btn.Click += ArchiveShow_btn_Click;
            // 
            // left_panel
            // 
            left_panel.BackColor = Color.FromArgb(248, 241, 237);
            left_panel.Controls.Add(AppointTask_lbl);
            left_panel.Controls.Add(MyGroups_btn);
            left_panel.Controls.Add(substrate);
            left_panel.Controls.Add(PersonGroups_list);
            left_panel.Controls.Add(lbl_mygroups);
            left_panel.Controls.Add(frame2);
            left_panel.Controls.Add(personal_affairs_btn);
            left_panel.Controls.Add(frame);
            left_panel.Location = new Point(-3, 71);
            left_panel.Name = "left_panel";
            left_panel.Size = new Size(390, 1042);
            left_panel.TabIndex = 1;
            // 
            // AppointTask_lbl
            // 
            AppointTask_lbl.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AppointTask_lbl.ForeColor = Color.Gray;
            AppointTask_lbl.Location = new Point(197, 462);
            AppointTask_lbl.Name = "AppointTask_lbl";
            AppointTask_lbl.Size = new Size(154, 80);
            AppointTask_lbl.TabIndex = 61;
            AppointTask_lbl.Text = "Управление группами";
            AppointTask_lbl.TextAlign = ContentAlignment.MiddleLeft;
            AppointTask_lbl.UseVisualStyleBackColor = true;
            AppointTask_lbl.Click += AppointTask_lbl_Click;
            // 
            // MyGroups_btn
            // 
            MyGroups_btn.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MyGroups_btn.ForeColor = Color.Gray;
            MyGroups_btn.Location = new Point(11, 462);
            MyGroups_btn.Name = "MyGroups_btn";
            MyGroups_btn.Size = new Size(180, 80);
            MyGroups_btn.TabIndex = 60;
            MyGroups_btn.Text = "Создать новую группу";
            MyGroups_btn.TextAlign = ContentAlignment.MiddleLeft;
            MyGroups_btn.UseVisualStyleBackColor = true;
            MyGroups_btn.Click += NewGroup_btn_Click;
            // 
            // substrate
            // 
            substrate.BackColor = Color.White;
            substrate.Controls.Add(group_tasks_lbl);
            substrate.Location = new Point(15, 241);
            substrate.Name = "substrate";
            substrate.Size = new Size(336, 46);
            substrate.TabIndex = 58;
            // 
            // group_tasks_lbl
            // 
            group_tasks_lbl.AutoSize = true;
            group_tasks_lbl.Font = new Font("XO Courser", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            group_tasks_lbl.Location = new Point(8, 8);
            group_tasks_lbl.Name = "group_tasks_lbl";
            group_tasks_lbl.Size = new Size(184, 32);
            group_tasks_lbl.TabIndex = 0;
            group_tasks_lbl.Text = "Общие дела";
            // 
            // PersonGroups_list
            // 
            PersonGroups_list.Font = new Font("XO Courser", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            PersonGroups_list.FormattingEnabled = true;
            PersonGroups_list.ItemHeight = 32;
            PersonGroups_list.Items.AddRange(new object[] { "Programmers" });
            PersonGroups_list.Location = new Point(15, 324);
            PersonGroups_list.Name = "PersonGroups_list";
            PersonGroups_list.Size = new Size(336, 132);
            PersonGroups_list.TabIndex = 57;
            PersonGroups_list.SelectedIndexChanged += PersonGroups_list_SelectedIndexChanged;
            // 
            // lbl_mygroups
            // 
            lbl_mygroups.AutoSize = true;
            lbl_mygroups.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_mygroups.ForeColor = Color.Gray;
            lbl_mygroups.Location = new Point(15, 290);
            lbl_mygroups.Name = "lbl_mygroups";
            lbl_mygroups.Size = new Size(96, 31);
            lbl_mygroups.TabIndex = 56;
            lbl_mygroups.Text = "Группы";
            // 
            // frame2
            // 
            frame2.BorderStyle = BorderStyle.FixedSingle;
            frame2.Controls.Add(Calendar_lbl);
            frame2.Location = new Point(15, 569);
            frame2.Name = "frame2";
            frame2.Size = new Size(336, 115);
            frame2.TabIndex = 22;
            // 
            // Calendar_lbl
            // 
            Calendar_lbl.AutoSize = true;
            Calendar_lbl.Font = new Font("Sitka Banner", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            Calendar_lbl.ForeColor = Color.FromArgb(159, 108, 80);
            Calendar_lbl.Location = new Point(-5, 20);
            Calendar_lbl.Name = "Calendar_lbl";
            Calendar_lbl.Size = new Size(225, 62);
            Calendar_lbl.TabIndex = 3;
            Calendar_lbl.Text = "Календарь";
            Calendar_lbl.Click += lbl_name_Click_1;
            Calendar_lbl.MouseLeave += CalendarLeave;
            Calendar_lbl.MouseMove += CalendarMove;
            // 
            // personal_affairs_btn
            // 
            personal_affairs_btn.BackColor = Color.White;
            personal_affairs_btn.Font = new Font("XO Courser", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            personal_affairs_btn.Location = new Point(15, 180);
            personal_affairs_btn.Name = "personal_affairs_btn";
            personal_affairs_btn.Size = new Size(336, 46);
            personal_affairs_btn.TabIndex = 20;
            personal_affairs_btn.Text = "Личные дела";
            personal_affairs_btn.TextAlign = ContentAlignment.MiddleLeft;
            personal_affairs_btn.UseVisualStyleBackColor = false;
            personal_affairs_btn.Click += personal_affairs_btn_Click;
            // 
            // frame
            // 
            frame.BorderStyle = BorderStyle.FixedSingle;
            frame.Controls.Add(my_tasks_lbl);
            frame.Location = new Point(15, 36);
            frame.Name = "frame";
            frame.Size = new Size(336, 115);
            frame.TabIndex = 21;
            // 
            // my_tasks_lbl
            // 
            my_tasks_lbl.AutoSize = true;
            my_tasks_lbl.Font = new Font("Sitka Banner", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            my_tasks_lbl.ForeColor = Color.FromArgb(159, 108, 80);
            my_tasks_lbl.Location = new Point(-5, 21);
            my_tasks_lbl.Name = "my_tasks_lbl";
            my_tasks_lbl.Size = new Size(248, 62);
            my_tasks_lbl.TabIndex = 3;
            my_tasks_lbl.Text = "Мои задачи";
            // 
            // TypeOfTask_lbl
            // 
            TypeOfTask_lbl.AutoSize = true;
            TypeOfTask_lbl.Font = new Font("Sitka Banner", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            TypeOfTask_lbl.ForeColor = Color.FromArgb(159, 108, 80);
            TypeOfTask_lbl.Location = new Point(417, 129);
            TypeOfTask_lbl.Name = "TypeOfTask_lbl";
            TypeOfTask_lbl.Size = new Size(273, 62);
            TypeOfTask_lbl.TabIndex = 19;
            TypeOfTask_lbl.Text = "Личные дела";
            // 
            // InfoTabel
            // 
            InfoTabel.AllowUserToDeleteRows = false;
            InfoTabel.BackgroundColor = Color.White;
            InfoTabel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InfoTabel.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, Date, Group });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Sitka Small", 9.124999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            InfoTabel.DefaultCellStyle = dataGridViewCellStyle5;
            InfoTabel.Location = new Point(405, 224);
            InfoTabel.Name = "InfoTabel";
            InfoTabel.RowHeadersWidth = 82;
            InfoTabel.RowTemplate.Height = 41;
            InfoTabel.Size = new Size(688, 766);
            InfoTabel.TabIndex = 44;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 241, 237);
            dataGridViewCellStyle1.Font = new Font("Sitka Heading", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTextBoxColumn2.HeaderText = "Описание ";
            dataGridViewTextBoxColumn2.MinimumWidth = 10;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 176;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Font = new Font("Sitka Heading", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTextBoxColumn3.HeaderText = "Параметр";
            dataGridViewTextBoxColumn3.MinimumWidth = 10;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 168;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Font = new Font("Sitka Heading", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            Date.DefaultCellStyle = dataGridViewCellStyle3;
            Date.HeaderText = "Дата ";
            Date.MinimumWidth = 10;
            Date.Name = "Date";
            Date.Width = 117;
            // 
            // Group
            // 
            Group.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Font = new Font("Sitka Heading", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            Group.DefaultCellStyle = dataGridViewCellStyle4;
            Group.HeaderText = "Группа";
            Group.MinimumWidth = 10;
            Group.Name = "Group";
            Group.Width = 136;
            // 
            // right_panel
            // 
            right_panel.BackColor = Color.FromArgb(248, 241, 237);
            right_panel.Location = new Point(1108, 71);
            right_panel.Name = "right_panel";
            right_panel.Size = new Size(14, 1042);
            right_panel.TabIndex = 47;
            // 
            // TaskAdd_btn
            // 
            TaskAdd_btn.Font = new Font("Sylfaen", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            TaskAdd_btn.ForeColor = Color.FromArgb(159, 108, 80);
            TaskAdd_btn.Location = new Point(917, 1010);
            TaskAdd_btn.Name = "TaskAdd_btn";
            TaskAdd_btn.Size = new Size(173, 86);
            TaskAdd_btn.TabIndex = 48;
            TaskAdd_btn.Text = "Добавить\r\nзадачу";
            TaskAdd_btn.UseVisualStyleBackColor = true;
            TaskAdd_btn.Click += TaskAdd_btn_Click;
            // 
            // TaskDelete_btn
            // 
            TaskDelete_btn.Font = new Font("Sylfaen", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            TaskDelete_btn.ForeColor = Color.FromArgb(159, 108, 80);
            TaskDelete_btn.Location = new Point(728, 1010);
            TaskDelete_btn.Name = "TaskDelete_btn";
            TaskDelete_btn.Size = new Size(173, 86);
            TaskDelete_btn.TabIndex = 49;
            TaskDelete_btn.Text = "Удалить\r\nзадачу";
            TaskDelete_btn.UseVisualStyleBackColor = true;
            TaskDelete_btn.Click += TaskDelete_btn_Click;
            // 
            // TaskDone_btn
            // 
            TaskDone_btn.Font = new Font("Sylfaen", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            TaskDone_btn.ForeColor = Color.FromArgb(159, 108, 80);
            TaskDone_btn.Location = new Point(534, 1010);
            TaskDone_btn.Name = "TaskDone_btn";
            TaskDone_btn.Size = new Size(173, 86);
            TaskDone_btn.TabIndex = 50;
            TaskDone_btn.Text = "Выполнить\r\nзадачу";
            TaskDone_btn.UseVisualStyleBackColor = true;
            TaskDone_btn.Click += TaskDone_btn_Click;
            // 
            // frame5
            // 
            frame5.BorderStyle = BorderStyle.FixedSingle;
            frame5.Controls.Add(task_group);
            frame5.Location = new Point(1380, 768);
            frame5.Name = "frame5";
            frame5.Size = new Size(251, 84);
            frame5.TabIndex = 59;
            // 
            // task_group
            // 
            task_group.AutoSize = true;
            task_group.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point);
            task_group.ForeColor = Color.FromArgb(159, 108, 80);
            task_group.Location = new Point(0, 12);
            task_group.Name = "task_group";
            task_group.Size = new Size(201, 47);
            task_group.TabIndex = 3;
            task_group.Text = "Programmers";
            // 
            // frame4
            // 
            frame4.BorderStyle = BorderStyle.FixedSingle;
            frame4.Controls.Add(task_date);
            frame4.Location = new Point(1379, 598);
            frame4.Name = "frame4";
            frame4.Size = new Size(251, 84);
            frame4.TabIndex = 58;
            frame4.TabStop = true;
            // 
            // task_date
            // 
            task_date.AutoSize = true;
            task_date.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point);
            task_date.ForeColor = Color.FromArgb(159, 108, 80);
            task_date.Location = new Point(0, 12);
            task_date.Name = "task_date";
            task_date.Size = new Size(162, 47);
            task_date.TabIndex = 3;
            task_date.Text = "13.03.2023";
            // 
            // frame3
            // 
            frame3.BorderStyle = BorderStyle.FixedSingle;
            frame3.Controls.Add(task_parameter);
            frame3.Location = new Point(1376, 434);
            frame3.Name = "frame3";
            frame3.Size = new Size(251, 84);
            frame3.TabIndex = 57;
            // 
            // task_parameter
            // 
            task_parameter.AutoSize = true;
            task_parameter.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point);
            task_parameter.ForeColor = Color.FromArgb(159, 108, 80);
            task_parameter.Location = new Point(0, 12);
            task_parameter.Name = "task_parameter";
            task_parameter.Size = new Size(113, 47);
            task_parameter.TabIndex = 3;
            task_parameter.Text = "Общая";
            // 
            // frame1
            // 
            frame1.BorderStyle = BorderStyle.FixedSingle;
            frame1.Controls.Add(task_discription);
            frame1.Location = new Point(1376, 251);
            frame1.Name = "frame1";
            frame1.Size = new Size(251, 84);
            frame1.TabIndex = 56;
            // 
            // task_discription
            // 
            task_discription.AutoSize = true;
            task_discription.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point);
            task_discription.ForeColor = Color.FromArgb(159, 108, 80);
            task_discription.Location = new Point(0, 12);
            task_discription.Name = "task_discription";
            task_discription.Size = new Size(233, 47);
            task_discription.TabIndex = 3;
            task_discription.Text = "Сделать проект";
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Font = new Font("XO Courser", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_date.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_date.Location = new Point(1146, 611);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(82, 32);
            lbl_date.TabIndex = 55;
            lbl_date.Text = "Дата";
            // 
            // lbl_group
            // 
            lbl_group.AutoSize = true;
            lbl_group.Font = new Font("XO Courser", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_group.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_group.Location = new Point(1146, 794);
            lbl_group.Name = "lbl_group";
            lbl_group.Size = new Size(116, 32);
            lbl_group.TabIndex = 54;
            lbl_group.Text = "Группа";
            // 
            // lbl_parameter
            // 
            lbl_parameter.AutoSize = true;
            lbl_parameter.Font = new Font("XO Courser", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_parameter.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_parameter.Location = new Point(1146, 447);
            lbl_parameter.Name = "lbl_parameter";
            lbl_parameter.Size = new Size(150, 32);
            lbl_parameter.TabIndex = 53;
            lbl_parameter.Text = "Параметр";
            // 
            // lbl_discription
            // 
            lbl_discription.AutoSize = true;
            lbl_discription.Font = new Font("XO Courser", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_discription.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_discription.Location = new Point(1146, 279);
            lbl_discription.Name = "lbl_discription";
            lbl_discription.Size = new Size(150, 32);
            lbl_discription.TabIndex = 52;
            lbl_discription.Text = "Описание";
            // 
            // lbl_information
            // 
            lbl_information.AutoSize = true;
            lbl_information.Font = new Font("Sitka Banner", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_information.ForeColor = Color.FromArgb(159, 108, 80);
            lbl_information.Location = new Point(1128, 129);
            lbl_information.Name = "lbl_information";
            lbl_information.Size = new Size(395, 62);
            lbl_information.TabIndex = 19;
            lbl_information.Text = "Информация о деле";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1677, 1109);
            Controls.Add(lbl_information);
            Controls.Add(TypeOfTask_lbl);
            Controls.Add(frame5);
            Controls.Add(frame4);
            Controls.Add(frame3);
            Controls.Add(frame1);
            Controls.Add(ArchiveShow_btn);
            Controls.Add(lbl_date);
            Controls.Add(lbl_group);
            Controls.Add(lbl_parameter);
            Controls.Add(lbl_discription);
            Controls.Add(upper_panel);
            Controls.Add(TaskDone_btn);
            Controls.Add(TaskDelete_btn);
            Controls.Add(TaskAdd_btn);
            Controls.Add(right_panel);
            Controls.Add(InfoTabel);
            Controls.Add(left_panel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Список дел";
            upper_panel.ResumeLayout(false);
            upper_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MainPicture).EndInit();
            left_panel.ResumeLayout(false);
            left_panel.PerformLayout();
            substrate.ResumeLayout(false);
            substrate.PerformLayout();
            frame2.ResumeLayout(false);
            frame2.PerformLayout();
            frame.ResumeLayout(false);
            frame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InfoTabel).EndInit();
            frame5.ResumeLayout(false);
            frame5.PerformLayout();
            frame4.ResumeLayout(false);
            frame4.PerformLayout();
            frame3.ResumeLayout(false);
            frame3.PerformLayout();
            frame1.ResumeLayout(false);
            frame1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel upper_panel;
        private Panel left_panel;
        private PictureBox MainPicture;
        private Label TypeOfTask_lbl;
        private Button personal_affairs_btn;
        private Panel frame;
        private Label my_tasks_lbl;
        private Label lbl_account;
        private Label lbl_name;
        private Panel frame2;
        private Label Calendar_lbl;
        private DataGridView InfoTabel;
        private Panel right_panel;
        private Button TaskAdd_btn;
        private Button TaskDelete_btn;
        private Button TaskDone_btn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Group;
        private Label lbl_mygroups;
        private ListBox PersonGroups_list;
        private Panel substrate;
        private Label group_tasks_lbl;
        private Button ArchiveShow_btn;
        private Panel frame5;
        private Label task_group;
        private Panel frame4;
        private Label task_date;
        private Panel frame3;
        private Label task_parameter;
        private Panel frame1;
        private Label task_discription;
        private Label lbl_date;
        private Label lbl_group;
        private Label lbl_parameter;
        private Label lbl_discription;
        private Label lbl_information;
        private Button search_btn;
        private TextBox Entered_Text;
        private Button MyGroups_btn;
        private Button AppointTask_lbl;
    }
}