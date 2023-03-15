namespace TeamProject1_ToDoList
{
    partial class AppointForm
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
            AppointTask_lbl = new Label();
            MyGroups_list2 = new ListBox();
            lbl_mygroups2 = new Label();
            Members_list = new ListBox();
            lbl_members2 = new Label();
            lbl_task = new Label();
            Entered_Text = new TextBox();
            Appoint_btn = new Button();
            delete_task_lbl = new Label();
            MyGroups_list3 = new ListBox();
            lbl_mygroups3 = new Label();
            group_tasks_lbl = new Label();
            tasks_collection = new ListBox();
            delete_btn = new Button();
            controls_members_lbl = new Label();
            upper_panel = new Panel();
            lbl_mygroups1 = new Label();
            MyGroups_list1 = new ListBox();
            lbl_persons = new Label();
            persons_list = new ListBox();
            add_btn = new Button();
            delete_member_btn = new Button();
            lbl_members1 = new Label();
            Member_list1 = new ListBox();
            middle_panel = new Panel();
            lower_panel = new Panel();
            monthCalendar = new MonthCalendar();
            lbl_date = new Label();
            lbl_days = new Label();
            entered_date_interval = new TextBox();
            lbl_repeat = new Label();
            SuspendLayout();
            // 
            // AppointTask_lbl
            // 
            AppointTask_lbl.AutoSize = true;
            AppointTask_lbl.Font = new Font("Sitka Banner", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            AppointTask_lbl.ForeColor = Color.FromArgb(159, 108, 80);
            AppointTask_lbl.Location = new Point(16, 390);
            AppointTask_lbl.Name = "AppointTask_lbl";
            AppointTask_lbl.Size = new Size(365, 62);
            AppointTask_lbl.TabIndex = 4;
            AppointTask_lbl.Text = "Назначить задачу";
            // 
            // MyGroups_list2
            // 
            MyGroups_list2.Font = new Font("XO Courser", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MyGroups_list2.FormattingEnabled = true;
            MyGroups_list2.ItemHeight = 27;
            MyGroups_list2.Items.AddRange(new object[] { "Группа 1", "Группа 2" });
            MyGroups_list2.Location = new Point(30, 597);
            MyGroups_list2.Name = "MyGroups_list2";
            MyGroups_list2.Size = new Size(318, 247);
            MyGroups_list2.TabIndex = 5;
            // 
            // lbl_mygroups2
            // 
            lbl_mygroups2.AutoSize = true;
            lbl_mygroups2.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_mygroups2.ForeColor = Color.Gray;
            lbl_mygroups2.Location = new Point(30, 563);
            lbl_mygroups2.Name = "lbl_mygroups2";
            lbl_mygroups2.Size = new Size(147, 31);
            lbl_mygroups2.TabIndex = 57;
            lbl_mygroups2.Text = "Мои группы";
            // 
            // Members_list
            // 
            Members_list.Font = new Font("XO Courser", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Members_list.FormattingEnabled = true;
            Members_list.ItemHeight = 27;
            Members_list.Items.AddRange(new object[] { "Person1", "Person2" });
            Members_list.Location = new Point(387, 597);
            Members_list.Name = "Members_list";
            Members_list.Size = new Size(318, 247);
            Members_list.TabIndex = 58;
            // 
            // lbl_members2
            // 
            lbl_members2.AutoSize = true;
            lbl_members2.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_members2.ForeColor = Color.Gray;
            lbl_members2.Location = new Point(382, 563);
            lbl_members2.Name = "lbl_members2";
            lbl_members2.Size = new Size(216, 31);
            lbl_members2.TabIndex = 59;
            lbl_members2.Text = "Участники группы";
            // 
            // lbl_task
            // 
            lbl_task.AutoSize = true;
            lbl_task.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_task.ForeColor = Color.Gray;
            lbl_task.Location = new Point(30, 483);
            lbl_task.Name = "lbl_task";
            lbl_task.Size = new Size(86, 31);
            lbl_task.TabIndex = 60;
            lbl_task.Text = "Задача";
            // 
            // Entered_Text
            // 
            Entered_Text.BorderStyle = BorderStyle.FixedSingle;
            Entered_Text.Font = new Font("XO Courser", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Entered_Text.ForeColor = SystemColors.ActiveCaptionText;
            Entered_Text.Location = new Point(173, 483);
            Entered_Text.Name = "Entered_Text";
            Entered_Text.Size = new Size(532, 35);
            Entered_Text.TabIndex = 62;
            Entered_Text.TabStop = false;
            Entered_Text.TextChanged += Entered_Text_TextChanged;
            // 
            // Appoint_btn
            // 
            Appoint_btn.Font = new Font("Sylfaen", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            Appoint_btn.ForeColor = Color.FromArgb(159, 108, 80);
            Appoint_btn.Location = new Point(818, 871);
            Appoint_btn.Name = "Appoint_btn";
            Appoint_btn.Size = new Size(247, 44);
            Appoint_btn.TabIndex = 63;
            Appoint_btn.Text = "Назначить задачу";
            Appoint_btn.UseVisualStyleBackColor = true;
            // 
            // delete_task_lbl
            // 
            delete_task_lbl.AutoSize = true;
            delete_task_lbl.Font = new Font("Sitka Banner", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            delete_task_lbl.ForeColor = Color.FromArgb(159, 108, 80);
            delete_task_lbl.Location = new Point(36, 941);
            delete_task_lbl.Name = "delete_task_lbl";
            delete_task_lbl.Size = new Size(317, 62);
            delete_task_lbl.TabIndex = 64;
            delete_task_lbl.Text = "Удалить задачу";
            // 
            // MyGroups_list3
            // 
            MyGroups_list3.Font = new Font("XO Courser", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MyGroups_list3.FormattingEnabled = true;
            MyGroups_list3.ItemHeight = 27;
            MyGroups_list3.Items.AddRange(new object[] { "Группа 1", "Группа 2" });
            MyGroups_list3.Location = new Point(36, 1047);
            MyGroups_list3.Name = "MyGroups_list3";
            MyGroups_list3.Size = new Size(318, 166);
            MyGroups_list3.TabIndex = 65;
            // 
            // lbl_mygroups3
            // 
            lbl_mygroups3.AutoSize = true;
            lbl_mygroups3.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_mygroups3.ForeColor = Color.Gray;
            lbl_mygroups3.Location = new Point(36, 1013);
            lbl_mygroups3.Name = "lbl_mygroups3";
            lbl_mygroups3.Size = new Size(147, 31);
            lbl_mygroups3.TabIndex = 66;
            lbl_mygroups3.Text = "Мои группы";
            // 
            // group_tasks_lbl
            // 
            group_tasks_lbl.AutoSize = true;
            group_tasks_lbl.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            group_tasks_lbl.ForeColor = Color.Gray;
            group_tasks_lbl.Location = new Point(402, 1013);
            group_tasks_lbl.Name = "group_tasks_lbl";
            group_tasks_lbl.Size = new Size(89, 31);
            group_tasks_lbl.TabIndex = 68;
            group_tasks_lbl.Text = "Задачи";
            // 
            // tasks_collection
            // 
            tasks_collection.Font = new Font("XO Courser", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tasks_collection.FormattingEnabled = true;
            tasks_collection.ItemHeight = 27;
            tasks_collection.Items.AddRange(new object[] { "Задача 1", "Задача 2" });
            tasks_collection.Location = new Point(402, 1047);
            tasks_collection.Name = "tasks_collection";
            tasks_collection.Size = new Size(318, 166);
            tasks_collection.TabIndex = 67;
            // 
            // delete_btn
            // 
            delete_btn.Font = new Font("Sylfaen", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            delete_btn.ForeColor = Color.FromArgb(159, 108, 80);
            delete_btn.Location = new Point(820, 1183);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(232, 44);
            delete_btn.TabIndex = 69;
            delete_btn.Text = "Удалить задачу";
            delete_btn.UseVisualStyleBackColor = true;
            // 
            // controls_members_lbl
            // 
            controls_members_lbl.AutoSize = true;
            controls_members_lbl.Font = new Font("Sitka Banner", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            controls_members_lbl.ForeColor = Color.FromArgb(159, 108, 80);
            controls_members_lbl.Location = new Point(26, 38);
            controls_members_lbl.Name = "controls_members_lbl";
            controls_members_lbl.Size = new Size(619, 62);
            controls_members_lbl.TabIndex = 70;
            controls_members_lbl.Text = "Управление участниками групп";
            // 
            // upper_panel
            // 
            upper_panel.BackColor = Color.FromArgb(159, 108, 80);
            upper_panel.ForeColor = Color.FromArgb(159, 108, 80);
            upper_panel.Location = new Point(26, 25);
            upper_panel.Name = "upper_panel";
            upper_panel.Size = new Size(1076, 10);
            upper_panel.TabIndex = 71;
            // 
            // lbl_mygroups1
            // 
            lbl_mygroups1.AutoSize = true;
            lbl_mygroups1.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_mygroups1.ForeColor = Color.Gray;
            lbl_mygroups1.Location = new Point(26, 111);
            lbl_mygroups1.Name = "lbl_mygroups1";
            lbl_mygroups1.Size = new Size(147, 31);
            lbl_mygroups1.TabIndex = 73;
            lbl_mygroups1.Text = "Мои группы";
            // 
            // MyGroups_list1
            // 
            MyGroups_list1.Font = new Font("XO Courser", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MyGroups_list1.FormattingEnabled = true;
            MyGroups_list1.ItemHeight = 27;
            MyGroups_list1.Items.AddRange(new object[] { "Группа 1", "Группа 2" });
            MyGroups_list1.Location = new Point(26, 156);
            MyGroups_list1.Name = "MyGroups_list1";
            MyGroups_list1.Size = new Size(318, 166);
            MyGroups_list1.TabIndex = 72;
            // 
            // lbl_persons
            // 
            lbl_persons.AutoSize = true;
            lbl_persons.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_persons.ForeColor = Color.Gray;
            lbl_persons.Location = new Point(374, 111);
            lbl_persons.Name = "lbl_persons";
            lbl_persons.Size = new Size(160, 31);
            lbl_persons.TabIndex = 75;
            lbl_persons.Text = "Пользователи";
            // 
            // persons_list
            // 
            persons_list.Font = new Font("XO Courser", 9F, FontStyle.Regular, GraphicsUnit.Point);
            persons_list.FormattingEnabled = true;
            persons_list.ItemHeight = 27;
            persons_list.Items.AddRange(new object[] { "Person1", "Person2" });
            persons_list.Location = new Point(374, 156);
            persons_list.Name = "persons_list";
            persons_list.Size = new Size(318, 166);
            persons_list.TabIndex = 74;
            // 
            // add_btn
            // 
            add_btn.Font = new Font("Sylfaen", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            add_btn.ForeColor = Color.FromArgb(159, 108, 80);
            add_btn.Location = new Point(402, 328);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(290, 44);
            add_btn.TabIndex = 76;
            add_btn.Text = "Добавить участника";
            add_btn.UseVisualStyleBackColor = true;
            // 
            // delete_member_btn
            // 
            delete_member_btn.Font = new Font("Sylfaen", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            delete_member_btn.ForeColor = Color.FromArgb(159, 108, 80);
            delete_member_btn.Location = new Point(820, 328);
            delete_member_btn.Name = "delete_member_btn";
            delete_member_btn.Size = new Size(255, 44);
            delete_member_btn.TabIndex = 79;
            delete_member_btn.Text = "Удалить участника";
            delete_member_btn.UseVisualStyleBackColor = true;
            // 
            // lbl_members1
            // 
            lbl_members1.AutoSize = true;
            lbl_members1.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_members1.ForeColor = Color.Gray;
            lbl_members1.Location = new Point(757, 111);
            lbl_members1.Name = "lbl_members1";
            lbl_members1.Size = new Size(216, 31);
            lbl_members1.TabIndex = 78;
            lbl_members1.Text = "Участники группы";
            // 
            // Member_list1
            // 
            Member_list1.Font = new Font("XO Courser", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Member_list1.FormattingEnabled = true;
            Member_list1.ItemHeight = 27;
            Member_list1.Items.AddRange(new object[] { "Person3", "Person4" });
            Member_list1.Location = new Point(757, 156);
            Member_list1.Name = "Member_list1";
            Member_list1.Size = new Size(318, 166);
            Member_list1.TabIndex = 77;
            // 
            // middle_panel
            // 
            middle_panel.BackColor = Color.FromArgb(159, 108, 80);
            middle_panel.ForeColor = Color.FromArgb(159, 108, 80);
            middle_panel.Location = new Point(30, 390);
            middle_panel.Name = "middle_panel";
            middle_panel.Size = new Size(1076, 10);
            middle_panel.TabIndex = 72;
            // 
            // lower_panel
            // 
            lower_panel.BackColor = Color.FromArgb(159, 108, 80);
            lower_panel.ForeColor = Color.FromArgb(159, 108, 80);
            lower_panel.Location = new Point(35, 928);
            lower_panel.Name = "lower_panel";
            lower_panel.Size = new Size(1076, 10);
            lower_panel.TabIndex = 73;
            // 
            // monthCalendar
            // 
            monthCalendar.BackColor = SystemColors.Control;
            monthCalendar.Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            monthCalendar.Location = new Point(761, 527);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 80;
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_date.ForeColor = Color.Gray;
            lbl_date.Location = new Point(761, 487);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(86, 31);
            lbl_date.TabIndex = 81;
            lbl_date.Text = "Задача";
            // 
            // lbl_days
            // 
            lbl_days.AutoSize = true;
            lbl_days.Font = new Font("XO Courser", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_days.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_days.Location = new Point(499, 862);
            lbl_days.Name = "lbl_days";
            lbl_days.Size = new Size(68, 27);
            lbl_days.TabIndex = 84;
            lbl_days.Text = "дней";
            // 
            // entered_date_interval
            // 
            entered_date_interval.BorderStyle = BorderStyle.FixedSingle;
            entered_date_interval.Font = new Font("XO Courser", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            entered_date_interval.Location = new Point(374, 859);
            entered_date_interval.Name = "entered_date_interval";
            entered_date_interval.Size = new Size(107, 40);
            entered_date_interval.TabIndex = 83;
            // 
            // lbl_repeat
            // 
            lbl_repeat.AutoSize = true;
            lbl_repeat.Font = new Font("XO Courser", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_repeat.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_repeat.Location = new Point(32, 855);
            lbl_repeat.Name = "lbl_repeat";
            lbl_repeat.Size = new Size(320, 54);
            lbl_repeat.TabIndex = 82;
            lbl_repeat.Text = "*сделать повторяющейся\r\n каждые";
            // 
            // AppointForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1102, 1243);
            Controls.Add(lbl_days);
            Controls.Add(entered_date_interval);
            Controls.Add(lbl_repeat);
            Controls.Add(lbl_date);
            Controls.Add(monthCalendar);
            Controls.Add(lower_panel);
            Controls.Add(middle_panel);
            Controls.Add(delete_member_btn);
            Controls.Add(lbl_members1);
            Controls.Add(Member_list1);
            Controls.Add(add_btn);
            Controls.Add(lbl_persons);
            Controls.Add(persons_list);
            Controls.Add(lbl_mygroups1);
            Controls.Add(MyGroups_list1);
            Controls.Add(upper_panel);
            Controls.Add(controls_members_lbl);
            Controls.Add(delete_btn);
            Controls.Add(group_tasks_lbl);
            Controls.Add(tasks_collection);
            Controls.Add(lbl_mygroups3);
            Controls.Add(MyGroups_list3);
            Controls.Add(delete_task_lbl);
            Controls.Add(Appoint_btn);
            Controls.Add(Entered_Text);
            Controls.Add(lbl_task);
            Controls.Add(lbl_members2);
            Controls.Add(Members_list);
            Controls.Add(lbl_mygroups2);
            Controls.Add(MyGroups_list2);
            Controls.Add(AppointTask_lbl);
            Name = "AppointForm";
            Text = "Управление моими группами";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AppointTask_lbl;
        private ListBox MyGroups_list2;
        private Label lbl_mygroups;
        private ListBox Members_list;
        private Label lbl_members;
        private Label lbl_task;
        private TextBox Entered_Text;
        private Button Appoint_btn;
        private Label delete_task_lbl;
        private ListBox MyGroups_list3;
        private Label label3;
        private Label group_tasks_lbl;
        private ListBox tasks_collection;
        private Button delete_btn;
        private Label label2;
        private Panel upper_panel;
        private Label label4;
        private ListBox MyGroups_list1;
        private Label label5;
        private ListBox persons_list;
        private Button button1;
        private Button button2;
        private Label label6;
        private ListBox Member_list1;
        private Panel panel1;
        private Panel panel2;
        private Label lbl_mygroups2;
        private Label lbl_members2;
        private Label lbl_mygroups3;
        private Label controls_members_lbl;
        private Label lbl_mygroups1;
        private Label lbl_persons;
        private Button add_btn;
        private Button delete_member_btn;
        private Label lbl_members1;
        private Panel middle_panel;
        private Panel lower_panel;
        private MonthCalendar monthCalendar;
        private Label lbl_date;
        private Label lbl_days;
        private TextBox entered_date_interval;
        private Label lbl_repeat;
    }
}