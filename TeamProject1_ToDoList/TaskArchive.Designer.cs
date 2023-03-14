namespace TeamProject1_ToDoList
{
    partial class TaskArchive
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            left_panel = new Panel();
            frame7 = new Panel();
            task_date = new Label();
            label5 = new Label();
            frame6 = new Panel();
            task_comment = new Label();
            frame8 = new Panel();
            task_member = new Label();
            lbl_comment = new Label();
            member_lbl = new Label();
            frame5 = new Panel();
            task_group = new Label();
            frame3 = new Panel();
            task_deadline = new Label();
            frame1 = new Panel();
            task_parameter = new Label();
            frame = new Panel();
            task_description = new Label();
            lbl_data = new Label();
            lbl_group = new Label();
            lbl_parameter = new Label();
            lbl_discription = new Label();
            InfoTabel = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Group = new DataGridViewTextBoxColumn();
            AppointTask_lbl = new Label();
            search_btn = new Button();
            Entered_Text = new TextBox();
            PersonalTasks_radio_btn = new RadioButton();
            Groups_list = new ListBox();
            lbl_mygroups = new Label();
            group_tasks_lbl = new Label();
            upper_panel = new Panel();
            left_panel.SuspendLayout();
            frame7.SuspendLayout();
            frame6.SuspendLayout();
            frame8.SuspendLayout();
            frame5.SuspendLayout();
            frame3.SuspendLayout();
            frame1.SuspendLayout();
            frame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InfoTabel).BeginInit();
            SuspendLayout();
            // 
            // left_panel
            // 
            left_panel.BackColor = Color.FromArgb(248, 241, 237);
            left_panel.Controls.Add(frame7);
            left_panel.Controls.Add(label5);
            left_panel.Controls.Add(frame6);
            left_panel.Controls.Add(frame8);
            left_panel.Controls.Add(lbl_comment);
            left_panel.Controls.Add(member_lbl);
            left_panel.Controls.Add(frame5);
            left_panel.Controls.Add(frame3);
            left_panel.Controls.Add(frame1);
            left_panel.Controls.Add(frame);
            left_panel.Controls.Add(lbl_data);
            left_panel.Controls.Add(lbl_group);
            left_panel.Controls.Add(lbl_parameter);
            left_panel.Controls.Add(lbl_discription);
            left_panel.Location = new Point(739, 247);
            left_panel.Name = "left_panel";
            left_panel.Size = new Size(559, 769);
            left_panel.TabIndex = 55;
            // 
            // frame7
            // 
            frame7.BorderStyle = BorderStyle.FixedSingle;
            frame7.Controls.Add(task_date);
            frame7.Location = new Point(226, 458);
            frame7.Name = "frame7";
            frame7.Size = new Size(306, 84);
            frame7.TabIndex = 63;
            frame7.TabStop = true;
            // 
            // task_date
            // 
            task_date.AutoSize = true;
            task_date.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point);
            task_date.ForeColor = Color.FromArgb(159, 108, 80);
            task_date.Location = new Point(0, 12);
            task_date.Name = "task_date";
            task_date.Size = new Size(128, 47);
            task_date.TabIndex = 3;
            task_date.Text = "30 дней";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(19, 458);
            label5.Name = "label5";
            label5.Size = new Size(176, 84);
            label5.TabIndex = 62;
            label5.Text = "Время \r\nвыполнения";
            // 
            // frame6
            // 
            frame6.BorderStyle = BorderStyle.FixedSingle;
            frame6.Controls.Add(task_comment);
            frame6.Location = new Point(229, 344);
            frame6.Name = "frame6";
            frame6.Size = new Size(303, 84);
            frame6.TabIndex = 61;
            frame6.TabStop = true;
            // 
            // task_comment
            // 
            task_comment.AutoSize = true;
            task_comment.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point);
            task_comment.ForeColor = Color.FromArgb(159, 108, 80);
            task_comment.Location = new Point(0, 12);
            task_comment.Name = "task_comment";
            task_comment.Size = new Size(130, 47);
            task_comment.TabIndex = 3;
            task_comment.Text = "сделано";
            // 
            // frame8
            // 
            frame8.BorderStyle = BorderStyle.FixedSingle;
            frame8.Controls.Add(task_member);
            frame8.Location = new Point(228, 680);
            frame8.Name = "frame8";
            frame8.Size = new Size(304, 74);
            frame8.TabIndex = 28;
            // 
            // task_member
            // 
            task_member.AutoSize = true;
            task_member.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point);
            task_member.ForeColor = Color.FromArgb(159, 108, 80);
            task_member.Location = new Point(3, 16);
            task_member.Name = "task_member";
            task_member.Size = new Size(121, 47);
            task_member.TabIndex = 3;
            task_member.Text = "Person1";
            // 
            // lbl_comment
            // 
            lbl_comment.AutoSize = true;
            lbl_comment.Font = new Font("Sitka Banner", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_comment.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_comment.Location = new Point(20, 361);
            lbl_comment.Name = "lbl_comment";
            lbl_comment.Size = new Size(193, 42);
            lbl_comment.TabIndex = 60;
            lbl_comment.Text = "Комментарий";
            // 
            // member_lbl
            // 
            member_lbl.AutoSize = true;
            member_lbl.Font = new Font("Sitka Banner", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            member_lbl.ForeColor = Color.FromArgb(64, 64, 64);
            member_lbl.Location = new Point(28, 697);
            member_lbl.Name = "member_lbl";
            member_lbl.Size = new Size(91, 42);
            member_lbl.TabIndex = 27;
            member_lbl.Text = "Автор";
            // 
            // frame5
            // 
            frame5.BorderStyle = BorderStyle.FixedSingle;
            frame5.Controls.Add(task_group);
            frame5.Location = new Point(228, 569);
            frame5.Name = "frame5";
            frame5.Size = new Size(304, 84);
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
            frame3.Controls.Add(task_deadline);
            frame3.Location = new Point(228, 232);
            frame3.Name = "frame3";
            frame3.Size = new Size(304, 84);
            frame3.TabIndex = 25;
            frame3.TabStop = true;
            // 
            // task_deadline
            // 
            task_deadline.AutoSize = true;
            task_deadline.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point);
            task_deadline.ForeColor = Color.FromArgb(159, 108, 80);
            task_deadline.Location = new Point(0, 12);
            task_deadline.Name = "task_deadline";
            task_deadline.Size = new Size(162, 47);
            task_deadline.TabIndex = 3;
            task_deadline.Text = "13.03.2023";
            // 
            // frame1
            // 
            frame1.BorderStyle = BorderStyle.FixedSingle;
            frame1.Controls.Add(task_parameter);
            frame1.Location = new Point(226, 127);
            frame1.Name = "frame1";
            frame1.Size = new Size(306, 84);
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
            frame.Location = new Point(226, 21);
            frame.Name = "frame";
            frame.Size = new Size(306, 84);
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
            lbl_data.Location = new Point(21, 250);
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
            lbl_group.Location = new Point(28, 586);
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
            lbl_parameter.Location = new Point(18, 145);
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
            lbl_discription.Location = new Point(18, 38);
            lbl_discription.Name = "lbl_discription";
            lbl_discription.Size = new Size(141, 42);
            lbl_discription.TabIndex = 0;
            lbl_discription.Text = "Описание";
            // 
            // InfoTabel
            // 
            InfoTabel.AllowUserToDeleteRows = false;
            InfoTabel.BackgroundColor = Color.FromArgb(248, 241, 237);
            InfoTabel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InfoTabel.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, Date, Group });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Sitka Small", 9.124999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            InfoTabel.DefaultCellStyle = dataGridViewCellStyle10;
            InfoTabel.Location = new Point(18, 142);
            InfoTabel.Name = "InfoTabel";
            InfoTabel.RowHeadersWidth = 82;
            InfoTabel.RowTemplate.Height = 41;
            InfoTabel.Size = new Size(707, 874);
            InfoTabel.TabIndex = 54;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Font = new Font("Sitka Heading", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(159, 108, 80);
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewTextBoxColumn2.HeaderText = "Описание ";
            dataGridViewTextBoxColumn2.MinimumWidth = 10;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 176;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Font = new Font("Sitka Heading", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewTextBoxColumn3.HeaderText = "Параметр";
            dataGridViewTextBoxColumn3.MinimumWidth = 10;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 168;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Font = new Font("Sitka Heading", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            Date.DefaultCellStyle = dataGridViewCellStyle8;
            Date.HeaderText = "Дата ";
            Date.MinimumWidth = 10;
            Date.Name = "Date";
            Date.Width = 117;
            // 
            // Group
            // 
            Group.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle9.Font = new Font("Sitka Heading", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            Group.DefaultCellStyle = dataGridViewCellStyle9;
            Group.HeaderText = "Группа";
            Group.MinimumWidth = 10;
            Group.Name = "Group";
            Group.Width = 136;
            // 
            // AppointTask_lbl
            // 
            AppointTask_lbl.AutoSize = true;
            AppointTask_lbl.Font = new Font("Sitka Banner", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            AppointTask_lbl.ForeColor = Color.FromArgb(159, 108, 80);
            AppointTask_lbl.Location = new Point(31, 9);
            AppointTask_lbl.Name = "AppointTask_lbl";
            AppointTask_lbl.Size = new Size(306, 62);
            AppointTask_lbl.TabIndex = 59;
            AppointTask_lbl.Text = "Архив заданий";
            // 
            // search_btn
            // 
            search_btn.BackgroundImage = Properties.Resources.SearchPicture1;
            search_btn.Location = new Point(299, 92);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(38, 35);
            search_btn.TabIndex = 64;
            search_btn.UseVisualStyleBackColor = true;
            // 
            // Entered_Text
            // 
            Entered_Text.BorderStyle = BorderStyle.FixedSingle;
            Entered_Text.Font = new Font("XO Courser", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Entered_Text.ForeColor = SystemColors.ControlDark;
            Entered_Text.Location = new Point(31, 92);
            Entered_Text.Name = "Entered_Text";
            Entered_Text.Size = new Size(269, 35);
            Entered_Text.TabIndex = 63;
            Entered_Text.TabStop = false;
            Entered_Text.Text = "Поиск по таблице..";
            // 
            // PersonalTasks_radio_btn
            // 
            PersonalTasks_radio_btn.AutoSize = true;
            PersonalTasks_radio_btn.Font = new Font("Sitka Heading", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            PersonalTasks_radio_btn.ForeColor = Color.FromArgb(64, 64, 64);
            PersonalTasks_radio_btn.Location = new Point(354, 79);
            PersonalTasks_radio_btn.Name = "PersonalTasks_radio_btn";
            PersonalTasks_radio_btn.Size = new Size(205, 43);
            PersonalTasks_radio_btn.TabIndex = 46;
            PersonalTasks_radio_btn.Text = "Личные дела";
            PersonalTasks_radio_btn.UseMnemonic = false;
            PersonalTasks_radio_btn.UseVisualStyleBackColor = true;
            PersonalTasks_radio_btn.CheckedChanged += PersonalTasks_radio_btn_CheckedChanged;
            // 
            // Groups_list
            // 
            Groups_list.Font = new Font("Sitka Heading", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            Groups_list.ForeColor = Color.FromArgb(64, 64, 64);
            Groups_list.FormattingEnabled = true;
            Groups_list.ItemHeight = 39;
            Groups_list.Items.AddRange(new object[] { "Programmers" });
            Groups_list.Location = new Point(739, 89);
            Groups_list.Name = "Groups_list";
            Groups_list.Size = new Size(555, 121);
            Groups_list.TabIndex = 67;
            // 
            // lbl_mygroups
            // 
            lbl_mygroups.AutoSize = true;
            lbl_mygroups.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_mygroups.ForeColor = Color.Gray;
            lbl_mygroups.Location = new Point(1199, 204);
            lbl_mygroups.Name = "lbl_mygroups";
            lbl_mygroups.Size = new Size(93, 31);
            lbl_mygroups.TabIndex = 66;
            lbl_mygroups.Text = "группы";
            // 
            // group_tasks_lbl
            // 
            group_tasks_lbl.AutoSize = true;
            group_tasks_lbl.Font = new Font("Sitka Heading", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            group_tasks_lbl.ForeColor = Color.FromArgb(64, 64, 64);
            group_tasks_lbl.Location = new Point(565, 83);
            group_tasks_lbl.Name = "group_tasks_lbl";
            group_tasks_lbl.Size = new Size(160, 39);
            group_tasks_lbl.TabIndex = 69;
            group_tasks_lbl.Text = "Общие дела";
            // 
            // upper_panel
            // 
            upper_panel.BackColor = Color.FromArgb(159, 108, 80);
            upper_panel.ForeColor = Color.FromArgb(159, 108, 80);
            upper_panel.Location = new Point(353, 61);
            upper_panel.Name = "upper_panel";
            upper_panel.Size = new Size(962, 10);
            upper_panel.TabIndex = 70;
            // 
            // TaskArchive
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1310, 1028);
            Controls.Add(upper_panel);
            Controls.Add(group_tasks_lbl);
            Controls.Add(Groups_list);
            Controls.Add(lbl_mygroups);
            Controls.Add(search_btn);
            Controls.Add(PersonalTasks_radio_btn);
            Controls.Add(Entered_Text);
            Controls.Add(AppointTask_lbl);
            Controls.Add(left_panel);
            Controls.Add(InfoTabel);
            Name = "TaskArchive";
            Text = "Архив выполненных заданий";
            left_panel.ResumeLayout(false);
            left_panel.PerformLayout();
            frame7.ResumeLayout(false);
            frame7.PerformLayout();
            frame6.ResumeLayout(false);
            frame6.PerformLayout();
            frame8.ResumeLayout(false);
            frame8.PerformLayout();
            frame5.ResumeLayout(false);
            frame5.PerformLayout();
            frame3.ResumeLayout(false);
            frame3.PerformLayout();
            frame1.ResumeLayout(false);
            frame1.PerformLayout();
            frame.ResumeLayout(false);
            frame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InfoTabel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel left_panel;
        private Panel frame5;
        private Label task_group;
        private Panel frame3;
        private Label task_deadline;
        private Panel frame1;
        private Label task_parameter;
        private Panel frame;
        private Label task_description;
        private Label lbl_data;
        private Label lbl_group;
        private Label lbl_parameter;
        private Label lbl_discription;
        private DataGridView InfoTabel;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Group;
        private Label AppointTask_lbl;
        private Panel frame7;
        private Label task_date;
        private Label label5;
        private Panel frame6;
        private Label task_comment;
        private Panel frame8;
        private Label task_member;
        private Label lbl_comment;
        private Label member_lbl;
        private Button search_btn;
        private TextBox Entered_Text;
        private RadioButton PersonalTasks_radio_btn;
        private ListBox Groups_list;
        private Label lbl_mygroups;
        private Label group_tasks_lbl;
        private Panel upper_panel;
    }
}