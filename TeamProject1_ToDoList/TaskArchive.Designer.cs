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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            left_panel = new Panel();
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
            frame8 = new Panel();
            task_member = new Label();
            member_lbl = new Label();
            frame6 = new Panel();
            task_comment = new Label();
            lbl_comment = new Label();
            frame7 = new Panel();
            task_date = new Label();
            label5 = new Label();
            search_btn = new Button();
            Entered_Text = new TextBox();
            GroupTasks_radio_btn = new RadioButton();
            PersonalTasks_radio_btn = new RadioButton();
            left_panel.SuspendLayout();
            frame5.SuspendLayout();
            frame3.SuspendLayout();
            frame1.SuspendLayout();
            frame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InfoTabel).BeginInit();
            frame8.SuspendLayout();
            frame6.SuspendLayout();
            frame7.SuspendLayout();
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
            left_panel.Location = new Point(808, 107);
            left_panel.Name = "left_panel";
            left_panel.Size = new Size(490, 896);
            left_panel.TabIndex = 55;
            // 
            // frame5
            // 
            frame5.BorderStyle = BorderStyle.FixedSingle;
            frame5.Controls.Add(task_group);
            frame5.Location = new Point(222, 670);
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
            frame3.Controls.Add(task_deadline);
            frame3.Location = new Point(221, 288);
            frame3.Name = "frame3";
            frame3.Size = new Size(251, 84);
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
            frame1.Location = new Point(220, 159);
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
            lbl_data.Location = new Point(14, 306);
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
            lbl_group.Location = new Point(22, 687);
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
            lbl_parameter.Location = new Point(12, 177);
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
            InfoTabel.Location = new Point(12, 152);
            InfoTabel.Name = "InfoTabel";
            InfoTabel.RowHeadersWidth = 82;
            InfoTabel.RowTemplate.Height = 41;
            InfoTabel.Size = new Size(725, 851);
            InfoTabel.TabIndex = 54;
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
            // frame8
            // 
            frame8.BorderStyle = BorderStyle.FixedSingle;
            frame8.Controls.Add(task_member);
            frame8.Location = new Point(222, 781);
            frame8.Name = "frame8";
            frame8.Size = new Size(251, 84);
            frame8.TabIndex = 28;
            // 
            // task_member
            // 
            task_member.AutoSize = true;
            task_member.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point);
            task_member.ForeColor = Color.FromArgb(159, 108, 80);
            task_member.Location = new Point(0, 12);
            task_member.Name = "task_member";
            task_member.Size = new Size(121, 47);
            task_member.TabIndex = 3;
            task_member.Text = "Person1";
            // 
            // member_lbl
            // 
            member_lbl.AutoSize = true;
            member_lbl.Font = new Font("Sitka Banner", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            member_lbl.ForeColor = Color.FromArgb(64, 64, 64);
            member_lbl.Location = new Point(22, 798);
            member_lbl.Name = "member_lbl";
            member_lbl.Size = new Size(91, 42);
            member_lbl.TabIndex = 27;
            member_lbl.Text = "Автор";
            // 
            // frame6
            // 
            frame6.BorderStyle = BorderStyle.FixedSingle;
            frame6.Controls.Add(task_comment);
            frame6.Location = new Point(221, 393);
            frame6.Name = "frame6";
            frame6.Size = new Size(251, 84);
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
            // lbl_comment
            // 
            lbl_comment.AutoSize = true;
            lbl_comment.Font = new Font("Sitka Banner", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_comment.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_comment.Location = new Point(12, 410);
            lbl_comment.Name = "lbl_comment";
            lbl_comment.Size = new Size(193, 42);
            lbl_comment.TabIndex = 60;
            lbl_comment.Text = "Комментарий";
            // 
            // frame7
            // 
            frame7.BorderStyle = BorderStyle.FixedSingle;
            frame7.Controls.Add(task_date);
            frame7.Location = new Point(220, 527);
            frame7.Name = "frame7";
            frame7.Size = new Size(251, 84);
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
            label5.Location = new Point(13, 527);
            label5.Name = "label5";
            label5.Size = new Size(176, 84);
            label5.TabIndex = 62;
            label5.Text = "Время \r\nвыполнения";
            // 
            // search_btn
            // 
            search_btn.BackgroundImage = Properties.Resources.SearchPicture1;
            search_btn.Location = new Point(278, 102);
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
            Entered_Text.Location = new Point(18, 102);
            Entered_Text.Name = "Entered_Text";
            Entered_Text.Size = new Size(269, 35);
            Entered_Text.TabIndex = 63;
            Entered_Text.TabStop = false;
            Entered_Text.Text = "Поиск по таблице..";
            // 
            // GroupTasks_radio_btn
            // 
            GroupTasks_radio_btn.AutoSize = true;
            GroupTasks_radio_btn.Font = new Font("Sitka Heading", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            GroupTasks_radio_btn.ForeColor = Color.FromArgb(64, 64, 64);
            GroupTasks_radio_btn.Location = new Point(546, 96);
            GroupTasks_radio_btn.Name = "GroupTasks_radio_btn";
            GroupTasks_radio_btn.Size = new Size(191, 43);
            GroupTasks_radio_btn.TabIndex = 47;
            GroupTasks_radio_btn.TabStop = true;
            GroupTasks_radio_btn.Text = "Общие дела";
            GroupTasks_radio_btn.UseVisualStyleBackColor = true;
            // 
            // PersonalTasks_radio_btn
            // 
            PersonalTasks_radio_btn.AutoSize = true;
            PersonalTasks_radio_btn.Font = new Font("Sitka Heading", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            PersonalTasks_radio_btn.ForeColor = Color.FromArgb(64, 64, 64);
            PersonalTasks_radio_btn.Location = new Point(335, 96);
            PersonalTasks_radio_btn.Name = "PersonalTasks_radio_btn";
            PersonalTasks_radio_btn.Size = new Size(205, 43);
            PersonalTasks_radio_btn.TabIndex = 46;
            PersonalTasks_radio_btn.TabStop = true;
            PersonalTasks_radio_btn.Text = "Личные дела";
            PersonalTasks_radio_btn.UseVisualStyleBackColor = true;
            // 
            // TaskArchive
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1310, 1028);
            Controls.Add(GroupTasks_radio_btn);
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
            frame5.ResumeLayout(false);
            frame5.PerformLayout();
            frame3.ResumeLayout(false);
            frame3.PerformLayout();
            frame1.ResumeLayout(false);
            frame1.PerformLayout();
            frame.ResumeLayout(false);
            frame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InfoTabel).EndInit();
            frame8.ResumeLayout(false);
            frame8.PerformLayout();
            frame6.ResumeLayout(false);
            frame6.PerformLayout();
            frame7.ResumeLayout(false);
            frame7.PerformLayout();
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
        private RadioButton GroupTasks_radio_btn;
        private RadioButton PersonalTasks_radio_btn;
    }
}