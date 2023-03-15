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
            MyGroups_list = new ListBox();
            lbl_mygroups2 = new Label();
            Members_list = new ListBox();
            lbl_members2 = new Label();
            lbl_task = new Label();
            Entered_Text = new TextBox();
            Appoint_btn = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
            lbl_mygroups3 = new Label();
            group_tasks_lbl = new Label();
            tasks_collection = new ListBox();
            delete_btn = new Button();
            controls_members_lbl = new Label();
            upper_panel = new Panel();
            lbl_mygroups1 = new Label();
            listBox2 = new ListBox();
            lbl_persons = new Label();
            listBox3 = new ListBox();
            add_btn = new Button();
            delete_member_btn = new Button();
            lbl_members1 = new Label();
            listBox4 = new ListBox();
            middle_panel = new Panel();
            lower_panel = new Panel();
            monthCalendar = new MonthCalendar();
            label7 = new Label();
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
            // MyGroups_list
            // 
            MyGroups_list.Font = new Font("XO Courser", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MyGroups_list.FormattingEnabled = true;
            MyGroups_list.ItemHeight = 27;
            MyGroups_list.Items.AddRange(new object[] { "Группа 1", "Группа 2" });
            MyGroups_list.Location = new Point(30, 597);
            MyGroups_list.Name = "MyGroups_list";
            MyGroups_list.Size = new Size(318, 247);
            MyGroups_list.TabIndex = 5;
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
            Entered_Text.Size = new Size(251, 35);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(159, 108, 80);
            label1.Location = new Point(36, 941);
            label1.Name = "label1";
            label1.Size = new Size(317, 62);
            label1.TabIndex = 64;
            label1.Text = "Удалить задачу";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("XO Courser", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 27;
            listBox1.Items.AddRange(new object[] { "Группа 1", "Группа 2" });
            listBox1.Location = new Point(36, 1047);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(318, 166);
            listBox1.TabIndex = 65;
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
            // listBox2
            // 
            listBox2.Font = new Font("XO Courser", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 27;
            listBox2.Items.AddRange(new object[] { "Группа 1", "Группа 2" });
            listBox2.Location = new Point(26, 156);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(318, 166);
            listBox2.TabIndex = 72;
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
            // listBox3
            // 
            listBox3.Font = new Font("XO Courser", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 27;
            listBox3.Items.AddRange(new object[] { "Задача 1", "Задача 2" });
            listBox3.Location = new Point(374, 156);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(318, 166);
            listBox3.TabIndex = 74;
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
            // listBox4
            // 
            listBox4.Font = new Font("XO Courser", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 27;
            listBox4.Items.AddRange(new object[] { "Задача 1", "Задача 2" });
            listBox4.Location = new Point(757, 156);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(318, 166);
            listBox4.TabIndex = 77;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(761, 487);
            label7.Name = "label7";
            label7.Size = new Size(86, 31);
            label7.TabIndex = 81;
            label7.Text = "Задача";
            // 
            // AppointForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1102, 1243);
            Controls.Add(label7);
            Controls.Add(monthCalendar);
            Controls.Add(lower_panel);
            Controls.Add(middle_panel);
            Controls.Add(delete_member_btn);
            Controls.Add(lbl_members1);
            Controls.Add(listBox4);
            Controls.Add(add_btn);
            Controls.Add(lbl_persons);
            Controls.Add(listBox3);
            Controls.Add(lbl_mygroups1);
            Controls.Add(listBox2);
            Controls.Add(upper_panel);
            Controls.Add(controls_members_lbl);
            Controls.Add(delete_btn);
            Controls.Add(group_tasks_lbl);
            Controls.Add(tasks_collection);
            Controls.Add(lbl_mygroups3);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(Appoint_btn);
            Controls.Add(Entered_Text);
            Controls.Add(lbl_task);
            Controls.Add(lbl_members2);
            Controls.Add(Members_list);
            Controls.Add(lbl_mygroups2);
            Controls.Add(MyGroups_list);
            Controls.Add(AppointTask_lbl);
            Name = "AppointForm";
            Text = "Управление моими группами";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AppointTask_lbl;
        private ListBox MyGroups_list;
        private Label lbl_mygroups;
        private ListBox Members_list;
        private Label lbl_members;
        private Label lbl_task;
        private TextBox Entered_Text;
        private Button Appoint_btn;
        private Label label1;
        private ListBox listBox1;
        private Label label3;
        private Label group_tasks_lbl;
        private ListBox tasks_collection;
        private Button delete_btn;
        private Label label2;
        private Panel upper_panel;
        private Label label4;
        private ListBox listBox2;
        private Label label5;
        private ListBox listBox3;
        private Button button1;
        private Button button2;
        private Label label6;
        private ListBox listBox4;
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
        private Label label7;
    }
}