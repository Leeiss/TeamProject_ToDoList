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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.group_tasks_lbl = new System.Windows.Forms.Label();
            this.tasks_collection = new System.Windows.Forms.ListBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.show_listGroup_button = new System.Windows.Forms.Button();
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
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Items.AddRange(new object[] {
            "Группа 1",
            "Группа 2"});
            this.listBox1.Location = new System.Drawing.Point(9, 416);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(246, 114);
            this.listBox1.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(9, 380);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 66;
            this.label3.Text = "Мои группы";
            // 
            // group_tasks_lbl
            // 
            this.group_tasks_lbl.AutoSize = true;
            this.group_tasks_lbl.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group_tasks_lbl.ForeColor = System.Drawing.Color.Gray;
            this.group_tasks_lbl.Location = new System.Drawing.Point(291, 380);
            this.group_tasks_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.group_tasks_lbl.Name = "group_tasks_lbl";
            this.group_tasks_lbl.Size = new System.Drawing.Size(153, 23);
            this.group_tasks_lbl.TabIndex = 68;
            this.group_tasks_lbl.Text = "Участники группы";
            // 
            // tasks_collection
            // 
            this.tasks_collection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tasks_collection.FormattingEnabled = true;
            this.tasks_collection.ItemHeight = 22;
            this.tasks_collection.Items.AddRange(new object[] {
            "Задача 1",
            "Задача 2"});
            this.tasks_collection.Location = new System.Drawing.Point(291, 416);
            this.tasks_collection.Margin = new System.Windows.Forms.Padding(2);
            this.tasks_collection.Name = "tasks_collection";
            this.tasks_collection.Size = new System.Drawing.Size(246, 114);
            this.tasks_collection.TabIndex = 67;
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
            this.show_listGroup_button.Location = new System.Drawing.Point(12, 72);
            this.show_listGroup_button.Name = "show_listGroup_button";
            this.show_listGroup_button.Size = new System.Drawing.Size(112, 34);
            this.show_listGroup_button.TabIndex = 72;
            this.show_listGroup_button.Text = "Группы";
            this.show_listGroup_button.UseVisualStyleBackColor = true;
            this.show_listGroup_button.Click += new System.EventHandler(this.show_listGroup_button_Click);
            // 
            // AppointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(785, 575);
            this.Controls.Add(this.show_listGroup_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.group_tasks_lbl);
            this.Controls.Add(this.tasks_collection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
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
        private ListBox listBox1;
        private Label label3;
        private Label group_tasks_lbl;
        private ListBox tasks_collection;
        private Button delete_btn;
        private Button button2;
        private Button show_listGroup_button;
    }
}