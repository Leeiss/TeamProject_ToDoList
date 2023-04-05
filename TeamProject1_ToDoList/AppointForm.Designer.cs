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
            this.AppointTask_lbl = new System.Windows.Forms.Label();
            this.MyGroups_list = new System.Windows.Forms.ListBox();
            this.Members_list = new System.Windows.Forms.ListBox();
            this.lbl_task = new System.Windows.Forms.Label();
            this.Entered_Text = new System.Windows.Forms.TextBox();
            this.Appoint_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MyGroups_list2 = new System.Windows.Forms.ListBox();
            this.Members_list2 = new System.Windows.Forms.ListBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.show_listGroup_button = new System.Windows.Forms.Button();
            this.show_listGroup_button2 = new System.Windows.Forms.Button();
            this.show_listMembers_button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.show_group_delete_btn = new System.Windows.Forms.Button();
            this.show_members_delete_btn = new System.Windows.Forms.Button();
            this.listBox_delete_group = new System.Windows.Forms.ListBox();
            this.listBox_delete_members = new System.Windows.Forms.ListBox();
            this.delete_member_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AppointTask_lbl
            // 
            this.AppointTask_lbl.AutoSize = true;
            this.AppointTask_lbl.Font = new System.Drawing.Font("Sitka Banner", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AppointTask_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.AppointTask_lbl.Location = new System.Drawing.Point(9, 16);
            this.AppointTask_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AppointTask_lbl.Name = "AppointTask_lbl";
            this.AppointTask_lbl.Size = new System.Drawing.Size(276, 48);
            this.AppointTask_lbl.TabIndex = 4;
            this.AppointTask_lbl.Text = "Назначить задачу";
            // 
            // MyGroups_list
            // 
            this.MyGroups_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MyGroups_list.FormattingEnabled = true;
            this.MyGroups_list.ItemHeight = 22;
            this.MyGroups_list.Location = new System.Drawing.Point(9, 118);
            this.MyGroups_list.Margin = new System.Windows.Forms.Padding(2);
            this.MyGroups_list.Name = "MyGroups_list";
            this.MyGroups_list.Size = new System.Drawing.Size(246, 180);
            this.MyGroups_list.TabIndex = 5;
            this.MyGroups_list.SelectedIndexChanged += new System.EventHandler(this.MyGroups_list_SelectedIndexChanged);
            // 
            // Members_list
            // 
            this.Members_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Members_list.FormattingEnabled = true;
            this.Members_list.ItemHeight = 22;
            this.Members_list.Location = new System.Drawing.Point(277, 118);
            this.Members_list.Margin = new System.Windows.Forms.Padding(2);
            this.Members_list.Name = "Members_list";
            this.Members_list.Size = new System.Drawing.Size(246, 180);
            this.Members_list.TabIndex = 58;
            // 
            // lbl_task
            // 
            this.lbl_task.AutoSize = true;
            this.lbl_task.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_task.ForeColor = System.Drawing.Color.Gray;
            this.lbl_task.Location = new System.Drawing.Point(562, 83);
            this.lbl_task.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_task.Name = "lbl_task";
            this.lbl_task.Size = new System.Drawing.Size(63, 23);
            this.lbl_task.TabIndex = 60;
            this.lbl_task.Text = "Задача";
            // 
            // Entered_Text
            // 
            this.Entered_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Entered_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Entered_Text.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Entered_Text.Location = new System.Drawing.Point(562, 118);
            this.Entered_Text.Margin = new System.Windows.Forms.Padding(2);
            this.Entered_Text.Name = "Entered_Text";
            this.Entered_Text.Size = new System.Drawing.Size(194, 28);
            this.Entered_Text.TabIndex = 62;
            this.Entered_Text.TabStop = false;
            // 
            // Appoint_btn
            // 
            this.Appoint_btn.Font = new System.Drawing.Font("Sylfaen", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Appoint_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.Appoint_btn.Location = new System.Drawing.Point(635, 277);
            this.Appoint_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Appoint_btn.Name = "Appoint_btn";
            this.Appoint_btn.Size = new System.Drawing.Size(133, 34);
            this.Appoint_btn.TabIndex = 63;
            this.Appoint_btn.Text = "Назначить";
            this.Appoint_btn.UseVisualStyleBackColor = true;
            this.Appoint_btn.Click += new System.EventHandler(this.Appoint_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(20, 324);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 48);
            this.label1.TabIndex = 64;
            this.label1.Text = "Удалить задачу";
            // 
            // MyGroups_list2
            // 
            this.MyGroups_list2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MyGroups_list2.FormattingEnabled = true;
            this.MyGroups_list2.ItemHeight = 22;
            this.MyGroups_list2.Location = new System.Drawing.Point(9, 416);
            this.MyGroups_list2.Margin = new System.Windows.Forms.Padding(2);
            this.MyGroups_list2.Name = "MyGroups_list2";
            this.MyGroups_list2.Size = new System.Drawing.Size(246, 114);
            this.MyGroups_list2.TabIndex = 65;
            // 
            // Members_list2
            // 
            this.Members_list2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Members_list2.FormattingEnabled = true;
            this.Members_list2.ItemHeight = 22;
            this.Members_list2.Location = new System.Drawing.Point(291, 416);
            this.Members_list2.Margin = new System.Windows.Forms.Padding(2);
            this.Members_list2.Name = "Members_list2";
            this.Members_list2.Size = new System.Drawing.Size(246, 114);
            this.Members_list2.TabIndex = 67;
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Sylfaen", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.delete_btn.Location = new System.Drawing.Point(635, 511);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(133, 34);
            this.delete_btn.TabIndex = 69;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(277, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 71;
            this.button2.Text = "Участники";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // show_listGroup_button
            // 
            this.show_listGroup_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.show_listGroup_button.Location = new System.Drawing.Point(12, 72);
            this.show_listGroup_button.Name = "show_listGroup_button";
            this.show_listGroup_button.Size = new System.Drawing.Size(112, 34);
            this.show_listGroup_button.TabIndex = 72;
            this.show_listGroup_button.Text = "Группы";
            this.show_listGroup_button.UseVisualStyleBackColor = true;
            this.show_listGroup_button.Click += new System.EventHandler(this.show_listGroup_button_Click);
            // 
            // show_listGroup_button2
            // 
            this.show_listGroup_button2.Location = new System.Drawing.Point(9, 375);
            this.show_listGroup_button2.Name = "show_listGroup_button2";
            this.show_listGroup_button2.Size = new System.Drawing.Size(112, 34);
            this.show_listGroup_button2.TabIndex = 73;
            this.show_listGroup_button2.Text = "Группы";
            this.show_listGroup_button2.UseVisualStyleBackColor = true;
            this.show_listGroup_button2.Click += new System.EventHandler(this.show_listGroup_button2_Click);
            // 
            // show_listMembers_button2
            // 
            this.show_listMembers_button2.Location = new System.Drawing.Point(291, 375);
            this.show_listMembers_button2.Name = "show_listMembers_button2";
            this.show_listMembers_button2.Size = new System.Drawing.Size(112, 34);
            this.show_listMembers_button2.TabIndex = 74;
            this.show_listMembers_button2.Text = "Участники";
            this.show_listMembers_button2.UseVisualStyleBackColor = true;
            this.show_listMembers_button2.Click += new System.EventHandler(this.show_listMembers_button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(9, 562);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 48);
            this.label2.TabIndex = 75;
            this.label2.Text = "Удалить участника";
            // 
            // show_group_delete_btn
            // 
            this.show_group_delete_btn.Location = new System.Drawing.Point(9, 613);
            this.show_group_delete_btn.Name = "show_group_delete_btn";
            this.show_group_delete_btn.Size = new System.Drawing.Size(112, 34);
            this.show_group_delete_btn.TabIndex = 76;
            this.show_group_delete_btn.Text = "Группы";
            this.show_group_delete_btn.UseVisualStyleBackColor = true;
            this.show_group_delete_btn.Click += new System.EventHandler(this.show_group_delete_btn_Click);
            // 
            // show_members_delete_btn
            // 
            this.show_members_delete_btn.Location = new System.Drawing.Point(291, 613);
            this.show_members_delete_btn.Name = "show_members_delete_btn";
            this.show_members_delete_btn.Size = new System.Drawing.Size(112, 34);
            this.show_members_delete_btn.TabIndex = 77;
            this.show_members_delete_btn.Text = "Участники";
            this.show_members_delete_btn.UseVisualStyleBackColor = true;
            this.show_members_delete_btn.Click += new System.EventHandler(this.show_members_delete_btn_Click);
            // 
            // listBox_delete_group
            // 
            this.listBox_delete_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox_delete_group.FormattingEnabled = true;
            this.listBox_delete_group.ItemHeight = 22;
            this.listBox_delete_group.Location = new System.Drawing.Point(9, 652);
            this.listBox_delete_group.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_delete_group.Name = "listBox_delete_group";
            this.listBox_delete_group.Size = new System.Drawing.Size(246, 114);
            this.listBox_delete_group.TabIndex = 78;
            // 
            // listBox_delete_members
            // 
            this.listBox_delete_members.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox_delete_members.FormattingEnabled = true;
            this.listBox_delete_members.ItemHeight = 22;
            this.listBox_delete_members.Location = new System.Drawing.Point(291, 652);
            this.listBox_delete_members.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_delete_members.Name = "listBox_delete_members";
            this.listBox_delete_members.Size = new System.Drawing.Size(246, 114);
            this.listBox_delete_members.TabIndex = 79;
            // 
            // delete_member_btn
            // 
            this.delete_member_btn.Font = new System.Drawing.Font("Sylfaen", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete_member_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.delete_member_btn.Location = new System.Drawing.Point(635, 732);
            this.delete_member_btn.Margin = new System.Windows.Forms.Padding(2);
            this.delete_member_btn.Name = "delete_member_btn";
            this.delete_member_btn.Size = new System.Drawing.Size(133, 34);
            this.delete_member_btn.TabIndex = 80;
            this.delete_member_btn.Text = "Удалить";
            this.delete_member_btn.UseVisualStyleBackColor = true;
            this.delete_member_btn.Click += new System.EventHandler(this.delete_member_btn_Click);
            // 
            // AppointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(785, 802);
            this.Controls.Add(this.delete_member_btn);
            this.Controls.Add(this.listBox_delete_members);
            this.Controls.Add(this.listBox_delete_group);
            this.Controls.Add(this.show_members_delete_btn);
            this.Controls.Add(this.show_group_delete_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.show_listMembers_button2);
            this.Controls.Add(this.show_listGroup_button2);
            this.Controls.Add(this.show_listGroup_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.Members_list2);
            this.Controls.Add(this.MyGroups_list2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Appoint_btn);
            this.Controls.Add(this.Entered_Text);
            this.Controls.Add(this.lbl_task);
            this.Controls.Add(this.Members_list);
            this.Controls.Add(this.MyGroups_list);
            this.Controls.Add(this.AppointTask_lbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AppointForm";
            this.Text = "Управление моими группами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AppointTask_lbl;
        private ListBox MyGroups_list;
        private ListBox Members_list;
        private Label lbl_task;
        private TextBox Entered_Text;
        private Button Appoint_btn;
        private Label label1;
        private ListBox MyGroups_list2;
        private ListBox Members_list2;
        private Button delete_btn;
        private Button button2;
        private Button show_listGroup_button;
        private Button show_listGroup_button2;
        private Button show_listMembers_button2;
        private Label label2;
        private Button show_group_delete_btn;
        private Button show_members_delete_btn;
        private ListBox listBox_delete_group;
        private ListBox listBox_delete_members;
        private Button delete_member_btn;
    }
}