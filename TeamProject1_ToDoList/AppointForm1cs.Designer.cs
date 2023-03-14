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
            lbl_mygroups = new Label();
            Members_list = new ListBox();
            lbl_members = new Label();
            lbl_task = new Label();
            Entered_Text = new TextBox();
            Appoint_btn = new Button();
            SuspendLayout();
            // 
            // AppointTask_lbl
            // 
            AppointTask_lbl.AutoSize = true;
            AppointTask_lbl.Font = new Font("Sitka Banner", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            AppointTask_lbl.ForeColor = Color.FromArgb(159, 108, 80);
            AppointTask_lbl.Location = new Point(12, 20);
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
            MyGroups_list.Items.AddRange(new object[] { "Создание проекта", "Разработка приложений" });
            MyGroups_list.Location = new Point(12, 151);
            MyGroups_list.Name = "MyGroups_list";
            MyGroups_list.Size = new Size(318, 247);
            MyGroups_list.TabIndex = 5;
            // 
            // lbl_mygroups
            // 
            lbl_mygroups.AutoSize = true;
            lbl_mygroups.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_mygroups.ForeColor = Color.Gray;
            lbl_mygroups.Location = new Point(12, 106);
            lbl_mygroups.Name = "lbl_mygroups";
            lbl_mygroups.Size = new Size(147, 31);
            lbl_mygroups.TabIndex = 57;
            lbl_mygroups.Text = "Мои группы";
            // 
            // Members_list
            // 
            Members_list.Font = new Font("XO Courser", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Members_list.FormattingEnabled = true;
            Members_list.ItemHeight = 27;
            Members_list.Items.AddRange(new object[] { "Person1", "Person2" });
            Members_list.Location = new Point(360, 151);
            Members_list.Name = "Members_list";
            Members_list.Size = new Size(318, 247);
            Members_list.TabIndex = 58;
            // 
            // lbl_members
            // 
            lbl_members.AutoSize = true;
            lbl_members.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_members.ForeColor = Color.Gray;
            lbl_members.Location = new Point(360, 106);
            lbl_members.Name = "lbl_members";
            lbl_members.Size = new Size(216, 31);
            lbl_members.TabIndex = 59;
            lbl_members.Text = "Участники группы";
            // 
            // lbl_task
            // 
            lbl_task.AutoSize = true;
            lbl_task.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_task.ForeColor = Color.Gray;
            lbl_task.Location = new Point(730, 106);
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
            Entered_Text.Location = new Point(730, 151);
            Entered_Text.Name = "Entered_Text";
            Entered_Text.Size = new Size(251, 35);
            Entered_Text.TabIndex = 62;
            Entered_Text.TabStop = false;
            // 
            // Appoint_btn
            // 
            Appoint_btn.Font = new Font("Sylfaen", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            Appoint_btn.ForeColor = Color.FromArgb(159, 108, 80);
            Appoint_btn.Location = new Point(835, 429);
            Appoint_btn.Name = "Appoint_btn";
            Appoint_btn.Size = new Size(173, 44);
            Appoint_btn.TabIndex = 63;
            Appoint_btn.Text = "Назначить";
            Appoint_btn.UseVisualStyleBackColor = true;
            // 
            // AppointForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1020, 485);
            Controls.Add(Appoint_btn);
            Controls.Add(Entered_Text);
            Controls.Add(lbl_task);
            Controls.Add(lbl_members);
            Controls.Add(Members_list);
            Controls.Add(lbl_mygroups);
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
    }
}