using System.Security.Policy;

namespace TeamProject1_ToDoList
{
    partial class CalendarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarForm));
            monthCalendar = new MonthCalendar();
            Calendar_lbl = new Label();
            picture_calendar = new PictureBox();
            upper_panel = new Panel();
            left_pannel = new Panel();
            lbl_date = new Label();
            InfoTabel = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Group = new DataGridViewTextBoxColumn();
            left_panel = new Panel();
            frame5 = new Panel();
            task_group = new Label();
            frame3 = new Panel();
            task_date = new Label();
            frame1 = new Panel();
            task_parameter = new Label();
            frame = new Panel();
            task_description = new Label();
            lbl_data = new Label();
            lbl_group = new Label();
            lbl_parameter = new Label();
            lbl_discription = new Label();
            lbl_information = new Label();
            Id = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            Parameter = new DataGridViewTextBoxColumn();
            PersonalTasks_radio_btn = new RadioButton();
            lbl_filtration = new Label();
            GroupTasks_radio_btn = new RadioButton();
            TaskDone_btn = new Button();
            TastDelete_btn = new Button();
            TaskAdd_btn = new Button();
            ArchiveShow_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)picture_calendar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InfoTabel).BeginInit();
            left_panel.SuspendLayout();
            frame5.SuspendLayout();
            frame3.SuspendLayout();
            frame1.SuspendLayout();
            frame.SuspendLayout();
            SuspendLayout();
            // 
            // monthCalendar
            // 
            monthCalendar.BackColor = SystemColors.Control;
            monthCalendar.Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            monthCalendar.Location = new Point(18, 184);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 24;
            monthCalendar.DateChanged += monthCalendar_DateChanged;
            // 
            // Calendar_lbl
            // 
            Calendar_lbl.AutoSize = true;
            Calendar_lbl.Font = new Font("Sitka Banner", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            Calendar_lbl.ForeColor = Color.FromArgb(159, 108, 80);
            Calendar_lbl.Location = new Point(124, 77);
            Calendar_lbl.Name = "Calendar_lbl";
            Calendar_lbl.Size = new Size(225, 62);
            Calendar_lbl.TabIndex = 3;
            Calendar_lbl.Text = "Календарь";
            // 
            // picture_calendar
            // 
            picture_calendar.Image = Properties.Resources.CalendarPicture;
            picture_calendar.Location = new Point(10, 42);
            picture_calendar.Name = "picture_calendar";
            picture_calendar.Size = new Size(108, 115);
            picture_calendar.TabIndex = 26;
            picture_calendar.TabStop = false;
            // 
            // upper_panel
            // 
            upper_panel.BackColor = Color.FromArgb(159, 108, 80);
            upper_panel.ForeColor = Color.FromArgb(159, 108, 80);
            upper_panel.Location = new Point(-25, 13);
            upper_panel.Name = "upper_panel";
            upper_panel.Size = new Size(1524, 23);
            upper_panel.TabIndex = 36;
            // 
            // left_pannel
            // 
            left_pannel.BackColor = Color.FromArgb(159, 108, 80);
            left_pannel.ForeColor = Color.FromArgb(159, 108, 80);
            left_pannel.Location = new Point(350, 34);
            left_pannel.Name = "left_pannel";
            left_pannel.Size = new Size(12, 1022);
            left_pannel.TabIndex = 37;
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Font = new Font("Sitka Small", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_date.ForeColor = SystemColors.ControlDarkDark;
            lbl_date.Location = new Point(389, 77);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(169, 39);
            lbl_date.TabIndex = 39;
            lbl_date.Text = "13.03.2023";
            // 
            // InfoTabel
            // 
            InfoTabel.AllowUserToDeleteRows = false;
            InfoTabel.BackgroundColor = Color.FromArgb(248, 241, 237);
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
            InfoTabel.Location = new Point(389, 140);
            InfoTabel.Name = "InfoTabel";
            InfoTabel.RowHeadersWidth = 82;
            InfoTabel.RowTemplate.Height = 41;
            InfoTabel.Size = new Size(677, 776);
            InfoTabel.TabIndex = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Font = new Font("Sitka Heading", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(159, 108, 80);
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
            // left_panel
            // 
            left_panel.BackColor = Color.FromArgb(248, 241, 237);
            left_panel.Controls.Add(frame5);
            left_panel.Controls.Add(frame3);
            left_panel.Controls.Add(frame1);
            left_panel.Controls.Add(frame);
            left_panel.Controls.Add(lbl_data);
            left_panel.Controls.Add(lbl_group);
            left_panel.Controls.Add(lbl_parameter);
            left_panel.Controls.Add(lbl_discription);
            left_panel.Location = new Point(1095, 140);
            left_panel.Name = "left_panel";
            left_panel.Size = new Size(490, 884);
            left_panel.TabIndex = 41;
            // 
            // frame5
            // 
            frame5.BorderStyle = BorderStyle.FixedSingle;
            frame5.Controls.Add(task_group);
            frame5.Location = new Point(222, 682);
            frame5.Name = "frame5";
            frame5.Size = new Size(251, 84);
            frame5.TabIndex = 26;
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
            // frame3
            // 
            frame3.BorderStyle = BorderStyle.FixedSingle;
            frame3.Controls.Add(task_date);
            frame3.Location = new Point(221, 454);
            frame3.Name = "frame3";
            frame3.Size = new Size(251, 84);
            frame3.TabIndex = 25;
            frame3.TabStop = true;
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
            // frame1
            // 
            frame1.BorderStyle = BorderStyle.FixedSingle;
            frame1.Controls.Add(task_parameter);
            frame1.Location = new Point(220, 228);
            frame1.Name = "frame1";
            frame1.Size = new Size(251, 84);
            frame1.TabIndex = 23;
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
            // frame
            // 
            frame.BorderStyle = BorderStyle.FixedSingle;
            frame.Controls.Add(task_description);
            frame.Location = new Point(220, 45);
            frame.Name = "frame";
            frame.Size = new Size(251, 84);
            frame.TabIndex = 22;
            // 
            // task_description
            // 
            task_description.AutoSize = true;
            task_description.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point);
            task_description.ForeColor = Color.FromArgb(159, 108, 80);
            task_description.Location = new Point(0, 12);
            task_description.Name = "task_description";
            task_description.Size = new Size(233, 47);
            task_description.TabIndex = 3;
            task_description.Text = "Сделать проект";
            // 
            // lbl_data
            // 
            lbl_data.AutoSize = true;
            lbl_data.Font = new Font("Sitka Banner", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_data.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_data.Location = new Point(22, 472);
            lbl_data.Name = "lbl_data";
            lbl_data.Size = new Size(76, 42);
            lbl_data.TabIndex = 4;
            lbl_data.Text = "Дата";
            // 
            // lbl_group
            // 
            lbl_group.AutoSize = true;
            lbl_group.Font = new Font("Sitka Banner", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_group.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_group.Location = new Point(22, 699);
            lbl_group.Name = "lbl_group";
            lbl_group.Size = new Size(106, 42);
            lbl_group.TabIndex = 3;
            lbl_group.Text = "Группа";
            // 
            // lbl_parameter
            // 
            lbl_parameter.AutoSize = true;
            lbl_parameter.Font = new Font("Sitka Banner", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_parameter.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_parameter.Location = new Point(22, 253);
            lbl_parameter.Name = "lbl_parameter";
            lbl_parameter.Size = new Size(139, 42);
            lbl_parameter.TabIndex = 1;
            lbl_parameter.Text = "Параметр";
            // 
            // lbl_discription
            // 
            lbl_discription.AutoSize = true;
            lbl_discription.Font = new Font("Sitka Banner", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_discription.ForeColor = Color.Black;
            lbl_discription.Location = new Point(12, 62);
            lbl_discription.Name = "lbl_discription";
            lbl_discription.Size = new Size(141, 42);
            lbl_discription.TabIndex = 0;
            lbl_discription.Text = "Описание";
            // 
            // lbl_information
            // 
            lbl_information.AutoSize = true;
            lbl_information.Font = new Font("Sitka Small", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_information.ForeColor = SystemColors.ControlDarkDark;
            lbl_information.Location = new Point(1095, 77);
            lbl_information.Name = "lbl_information";
            lbl_information.Size = new Size(351, 39);
            lbl_information.TabIndex = 42;
            lbl_information.Text = "Информация по задаче";
            lbl_information.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 10;
            Id.Name = "Id";
            Id.Width = 200;
            // 
            // description
            // 
            description.HeaderText = "Описание задачи";
            description.MinimumWidth = 10;
            description.Name = "description";
            description.Width = 200;
            // 
            // Parameter
            // 
            Parameter.HeaderText = "Параметр";
            Parameter.MinimumWidth = 10;
            Parameter.Name = "Parameter";
            Parameter.Width = 200;
            // 
            // PersonalTasks_radio_btn
            // 
            PersonalTasks_radio_btn.AutoSize = true;
            PersonalTasks_radio_btn.Font = new Font("Sitka Banner", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            PersonalTasks_radio_btn.ForeColor = Color.FromArgb(159, 108, 80);
            PersonalTasks_radio_btn.Location = new Point(18, 601);
            PersonalTasks_radio_btn.Name = "PersonalTasks_radio_btn";
            PersonalTasks_radio_btn.Size = new Size(215, 46);
            PersonalTasks_radio_btn.TabIndex = 43;
            PersonalTasks_radio_btn.TabStop = true;
            PersonalTasks_radio_btn.Text = "Личные дела";
            PersonalTasks_radio_btn.UseVisualStyleBackColor = true;
            // 
            // lbl_filtration
            // 
            lbl_filtration.AutoSize = true;
            lbl_filtration.Font = new Font("Sitka Small", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_filtration.ForeColor = SystemColors.ControlDarkDark;
            lbl_filtration.Location = new Point(18, 544);
            lbl_filtration.Name = "lbl_filtration";
            lbl_filtration.Size = new Size(194, 39);
            lbl_filtration.TabIndex = 44;
            lbl_filtration.Text = "Фильтрация";
            // 
            // GroupTasks_radio_btn
            // 
            GroupTasks_radio_btn.AutoSize = true;
            GroupTasks_radio_btn.Font = new Font("Sitka Banner", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            GroupTasks_radio_btn.ForeColor = Color.FromArgb(159, 108, 80);
            GroupTasks_radio_btn.Location = new Point(18, 663);
            GroupTasks_radio_btn.Name = "GroupTasks_radio_btn";
            GroupTasks_radio_btn.Size = new Size(198, 46);
            GroupTasks_radio_btn.TabIndex = 45;
            GroupTasks_radio_btn.TabStop = true;
            GroupTasks_radio_btn.Text = "Общие дела";
            GroupTasks_radio_btn.UseVisualStyleBackColor = true;
            // 
            // TaskDone_btn
            // 
            TaskDone_btn.Font = new Font("Sylfaen", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            TaskDone_btn.ForeColor = Color.FromArgb(159, 108, 80);
            TaskDone_btn.Location = new Point(510, 938);
            TaskDone_btn.Name = "TaskDone_btn";
            TaskDone_btn.Size = new Size(173, 86);
            TaskDone_btn.TabIndex = 53;
            TaskDone_btn.Text = "Выполнить\r\nзадачу";
            TaskDone_btn.UseVisualStyleBackColor = true;
            TaskDone_btn.Click += TaskDone_btn_Click;
            // 
            // TastDelete_btn
            // 
            TastDelete_btn.Font = new Font("Sylfaen", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            TastDelete_btn.ForeColor = Color.FromArgb(159, 108, 80);
            TastDelete_btn.Location = new Point(701, 938);
            TastDelete_btn.Name = "TastDelete_btn";
            TastDelete_btn.Size = new Size(173, 86);
            TastDelete_btn.TabIndex = 52;
            TastDelete_btn.Text = "Удалить\r\nзадачу";
            TastDelete_btn.UseVisualStyleBackColor = true;
            TastDelete_btn.Click += TastDelete_btn_Click;
            // 
            // TaskAdd_btn
            // 
            TaskAdd_btn.Font = new Font("Sylfaen", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            TaskAdd_btn.ForeColor = Color.FromArgb(159, 108, 80);
            TaskAdd_btn.Location = new Point(893, 938);
            TaskAdd_btn.Name = "TaskAdd_btn";
            TaskAdd_btn.Size = new Size(173, 86);
            TaskAdd_btn.TabIndex = 51;
            TaskAdd_btn.Text = "Добавить\r\nзадачу";
            TaskAdd_btn.UseVisualStyleBackColor = true;
            TaskAdd_btn.Click += TaskAdd_btn_Click;
            // 
            // ArchiveShow_btn
            // 
            ArchiveShow_btn.Font = new Font("Sylfaen", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            ArchiveShow_btn.ForeColor = Color.FromArgb(159, 108, 80);
            ArchiveShow_btn.Location = new Point(12, 951);
            ArchiveShow_btn.Name = "ArchiveShow_btn";
            ArchiveShow_btn.Size = new Size(314, 86);
            ArchiveShow_btn.TabIndex = 54;
            ArchiveShow_btn.Text = "Архив выполненных задач";
            ArchiveShow_btn.UseVisualStyleBackColor = true;
            ArchiveShow_btn.Click += ArchiveShow_btn_Click;
            // 
            // CalendarForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1602, 1049);
            Controls.Add(ArchiveShow_btn);
            Controls.Add(TaskDone_btn);
            Controls.Add(TastDelete_btn);
            Controls.Add(TaskAdd_btn);
            Controls.Add(GroupTasks_radio_btn);
            Controls.Add(lbl_filtration);
            Controls.Add(PersonalTasks_radio_btn);
            Controls.Add(lbl_information);
            Controls.Add(left_panel);
            Controls.Add(InfoTabel);
            Controls.Add(lbl_date);
            Controls.Add(left_pannel);
            Controls.Add(upper_panel);
            Controls.Add(Calendar_lbl);
            Controls.Add(picture_calendar);
            Controls.Add(monthCalendar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CalendarForm";
            Text = "Календарь";
            ((System.ComponentModel.ISupportInitialize)picture_calendar).EndInit();
            ((System.ComponentModel.ISupportInitialize)InfoTabel).EndInit();
            left_panel.ResumeLayout(false);
            left_panel.PerformLayout();
            frame5.ResumeLayout(false);
            frame5.PerformLayout();
            frame3.ResumeLayout(false);
            frame3.PerformLayout();
            frame1.ResumeLayout(false);
            frame1.PerformLayout();
            frame.ResumeLayout(false);
            frame.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar;
        private Label Calendar_lbl;
        private PictureBox picture_calendar;
        private Panel upper_panel;
        private Panel left_pannel;
        private Label lbl_date;
        private DataGridView InfoTabel;
        private Panel left_panel;
        private Label lbl_information;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn Parameter;
        private RadioButton PersonalTasks_radio_btn;
        private Label lbl_filtration;
        private RadioButton GroupTasks_radio_btn;
        private Label lbl_data;
        private Label lbl_group;
        private Label lbl_parameter;
        private Label lbl_discription;
        private Panel frame5;
        private Label task_group;
        private Panel frame3;
        private Label task_date;
        private Panel frame1;
        private Label task_parameter;
        private Panel frame;
        private Label task_description;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Group;
        private Button TaskDone_btn;
        private Button TastDelete_btn;
        private Button TaskAdd_btn;
        private Button ArchiveShow_btn;
    }
}