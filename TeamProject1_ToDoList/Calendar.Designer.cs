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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarForm));
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.Calendar_lbl = new System.Windows.Forms.Label();
            this.picture_calendar = new System.Windows.Forms.PictureBox();
            this.upper_panel = new System.Windows.Forms.Panel();
            this.left_pannel = new System.Windows.Forms.Panel();
            this.lbl_date = new System.Windows.Forms.Label();
            this.InfoTabel = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.left_panel = new System.Windows.Forms.Panel();
            this.label_group = new System.Windows.Forms.Label();
            this.textbox_parametr = new System.Windows.Forms.TextBox();
            this.label_parametr = new System.Windows.Forms.Label();
            this.textbox_description = new System.Windows.Forms.TextBox();
            this.textbox_date = new System.Windows.Forms.TextBox();
            this.textbox_group = new System.Windows.Forms.TextBox();
            this.label_discription = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.lbl_group = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskDone_btn = new System.Windows.Forms.Button();
            this.TaskDelete_btn = new System.Windows.Forms.Button();
            this.TaskAdd_btn = new System.Windows.Forms.Button();
            this.ArchiveShow_btn = new System.Windows.Forms.Button();
            this.info_task_button = new System.Windows.Forms.Button();
            this.personal_affairs_btn = new System.Windows.Forms.Button();
            this.common_afairs_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_calendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoTabel)).BeginInit();
            this.left_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.SystemColors.Control;
            this.monthCalendar.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monthCalendar.Location = new System.Drawing.Point(23, 144);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 24;
            this.monthCalendar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.monthCalendar_MouseDown);
            // 
            // Calendar_lbl
            // 
            this.Calendar_lbl.AutoSize = true;
            this.Calendar_lbl.Font = new System.Drawing.Font("Sitka Banner", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Calendar_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.Calendar_lbl.Location = new System.Drawing.Point(95, 60);
            this.Calendar_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Calendar_lbl.Name = "Calendar_lbl";
            this.Calendar_lbl.Size = new System.Drawing.Size(172, 48);
            this.Calendar_lbl.TabIndex = 3;
            this.Calendar_lbl.Text = "Календарь";
            // 
            // picture_calendar
            // 
            this.picture_calendar.Image = global::TeamProject1_ToDoList.Properties.Resources.CalendarPicture;
            this.picture_calendar.Location = new System.Drawing.Point(8, 33);
            this.picture_calendar.Margin = new System.Windows.Forms.Padding(2);
            this.picture_calendar.Name = "picture_calendar";
            this.picture_calendar.Size = new System.Drawing.Size(83, 90);
            this.picture_calendar.TabIndex = 26;
            this.picture_calendar.TabStop = false;
            // 
            // upper_panel
            // 
            this.upper_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.upper_panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.upper_panel.Location = new System.Drawing.Point(-19, 10);
            this.upper_panel.Margin = new System.Windows.Forms.Padding(2);
            this.upper_panel.Name = "upper_panel";
            this.upper_panel.Size = new System.Drawing.Size(1172, 18);
            this.upper_panel.TabIndex = 36;
            // 
            // left_pannel
            // 
            this.left_pannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.left_pannel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.left_pannel.Location = new System.Drawing.Point(269, 27);
            this.left_pannel.Margin = new System.Windows.Forms.Padding(2);
            this.left_pannel.Name = "left_pannel";
            this.left_pannel.Size = new System.Drawing.Size(9, 798);
            this.left_pannel.TabIndex = 37;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Sitka Small", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_date.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_date.Location = new System.Drawing.Point(299, 60);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(134, 31);
            this.lbl_date.TabIndex = 39;
            this.lbl_date.Text = "13.03.2023";
            // 
            // InfoTabel
            // 
            this.InfoTabel.AllowUserToDeleteRows = false;
            this.InfoTabel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.InfoTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfoTabel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Date,
            this.Group});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Sitka Small", 9.124999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InfoTabel.DefaultCellStyle = dataGridViewCellStyle15;
            this.InfoTabel.Location = new System.Drawing.Point(299, 109);
            this.InfoTabel.Margin = new System.Windows.Forms.Padding(2);
            this.InfoTabel.Name = "InfoTabel";
            this.InfoTabel.RowHeadersWidth = 82;
            this.InfoTabel.RowTemplate.Height = 41;
            this.InfoTabel.Size = new System.Drawing.Size(521, 606);
            this.InfoTabel.TabIndex = 40;
            this.InfoTabel.Visible = false;
            this.InfoTabel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InfoTabel_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Sitka Heading", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn2.HeaderText = "Группа";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 105;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Sitka Heading", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 85;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Sitka Heading", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Date.DefaultCellStyle = dataGridViewCellStyle13;
            this.Date.HeaderText = "Описание";
            this.Date.MinimumWidth = 10;
            this.Date.Name = "Date";
            this.Date.Width = 128;
            // 
            // Group
            // 
            this.Group.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Sitka Heading", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Group.DefaultCellStyle = dataGridViewCellStyle14;
            this.Group.HeaderText = "Параметр";
            this.Group.MinimumWidth = 10;
            this.Group.Name = "Group";
            this.Group.Width = 130;
            // 
            // left_panel
            // 
            this.left_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.left_panel.Controls.Add(this.label_group);
            this.left_panel.Controls.Add(this.textbox_parametr);
            this.left_panel.Controls.Add(this.label_parametr);
            this.left_panel.Controls.Add(this.textbox_description);
            this.left_panel.Controls.Add(this.textbox_date);
            this.left_panel.Controls.Add(this.textbox_group);
            this.left_panel.Controls.Add(this.label_discription);
            this.left_panel.Controls.Add(this.label_date);
            this.left_panel.Controls.Add(this.lbl_group);
            this.left_panel.Location = new System.Drawing.Point(842, 109);
            this.left_panel.Margin = new System.Windows.Forms.Padding(2);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(377, 691);
            this.left_panel.TabIndex = 41;
            // 
            // label_group
            // 
            this.label_group.AutoSize = true;
            this.label_group.Font = new System.Drawing.Font("Sitka Banner", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_group.Location = new System.Drawing.Point(17, 57);
            this.label_group.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_group.Name = "label_group";
            this.label_group.Size = new System.Drawing.Size(80, 32);
            this.label_group.TabIndex = 32;
            this.label_group.Text = "Группа";
            // 
            // textbox_parametr
            // 
            this.textbox_parametr.Location = new System.Drawing.Point(169, 508);
            this.textbox_parametr.Multiline = true;
            this.textbox_parametr.Name = "textbox_parametr";
            this.textbox_parametr.Size = new System.Drawing.Size(192, 66);
            this.textbox_parametr.TabIndex = 31;
            // 
            // label_parametr
            // 
            this.label_parametr.AutoSize = true;
            this.label_parametr.Font = new System.Drawing.Font("Sitka Banner", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_parametr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_parametr.Location = new System.Drawing.Point(17, 523);
            this.label_parametr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_parametr.Name = "label_parametr";
            this.label_parametr.Size = new System.Drawing.Size(96, 32);
            this.label_parametr.TabIndex = 30;
            this.label_parametr.Text = "Парметр";
            // 
            // textbox_description
            // 
            this.textbox_description.Location = new System.Drawing.Point(169, 346);
            this.textbox_description.Multiline = true;
            this.textbox_description.Name = "textbox_description";
            this.textbox_description.Size = new System.Drawing.Size(192, 66);
            this.textbox_description.TabIndex = 29;
            // 
            // textbox_date
            // 
            this.textbox_date.Location = new System.Drawing.Point(169, 187);
            this.textbox_date.Multiline = true;
            this.textbox_date.Name = "textbox_date";
            this.textbox_date.Size = new System.Drawing.Size(192, 66);
            this.textbox_date.TabIndex = 28;
            // 
            // textbox_group
            // 
            this.textbox_group.Location = new System.Drawing.Point(169, 35);
            this.textbox_group.Multiline = true;
            this.textbox_group.Name = "textbox_group";
            this.textbox_group.Size = new System.Drawing.Size(192, 66);
            this.textbox_group.TabIndex = 27;
            // 
            // label_discription
            // 
            this.label_discription.AutoSize = true;
            this.label_discription.Font = new System.Drawing.Font("Sitka Banner", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_discription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_discription.Location = new System.Drawing.Point(17, 369);
            this.label_discription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_discription.Name = "label_discription";
            this.label_discription.Size = new System.Drawing.Size(108, 32);
            this.label_discription.TabIndex = 4;
            this.label_discription.Text = "Описание";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Sitka Banner", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_date.Location = new System.Drawing.Point(17, 198);
            this.label_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(58, 32);
            this.label_date.TabIndex = 1;
            this.label_date.Text = "Дата";
            // 
            // lbl_group
            // 
            this.lbl_group.AutoSize = true;
            this.lbl_group.Font = new System.Drawing.Font("Sitka Banner", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_group.ForeColor = System.Drawing.Color.Black;
            this.lbl_group.Location = new System.Drawing.Point(9, 48);
            this.lbl_group.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_group.Name = "lbl_group";
            this.lbl_group.Size = new System.Drawing.Size(0, 32);
            this.lbl_group.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 10;
            this.Id.Name = "Id";
            this.Id.Width = 200;
            // 
            // description
            // 
            this.description.HeaderText = "Описание задачи";
            this.description.MinimumWidth = 10;
            this.description.Name = "description";
            this.description.Width = 200;
            // 
            // Parameter
            // 
            this.Parameter.HeaderText = "Параметр";
            this.Parameter.MinimumWidth = 10;
            this.Parameter.Name = "Parameter";
            this.Parameter.Width = 200;
            // 
            // TaskDone_btn
            // 
            this.TaskDone_btn.Font = new System.Drawing.Font("Sylfaen", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TaskDone_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.TaskDone_btn.Location = new System.Drawing.Point(392, 733);
            this.TaskDone_btn.Margin = new System.Windows.Forms.Padding(2);
            this.TaskDone_btn.Name = "TaskDone_btn";
            this.TaskDone_btn.Size = new System.Drawing.Size(133, 67);
            this.TaskDone_btn.TabIndex = 53;
            this.TaskDone_btn.Text = "Выполнить\r\nзадачу";
            this.TaskDone_btn.UseVisualStyleBackColor = true;
            this.TaskDone_btn.Visible = false;
            this.TaskDone_btn.Click += new System.EventHandler(this.TaskDone_btn_Click_1);
            // 
            // TaskDelete_btn
            // 
            this.TaskDelete_btn.Font = new System.Drawing.Font("Sylfaen", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TaskDelete_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.TaskDelete_btn.Location = new System.Drawing.Point(539, 733);
            this.TaskDelete_btn.Margin = new System.Windows.Forms.Padding(2);
            this.TaskDelete_btn.Name = "TaskDelete_btn";
            this.TaskDelete_btn.Size = new System.Drawing.Size(133, 67);
            this.TaskDelete_btn.TabIndex = 52;
            this.TaskDelete_btn.Text = "Удалить\r\nзадачу";
            this.TaskDelete_btn.UseVisualStyleBackColor = true;
            this.TaskDelete_btn.Visible = false;
            this.TaskDelete_btn.Click += new System.EventHandler(this.TastDelete_btn_Click_1);
            // 
            // TaskAdd_btn
            // 
            this.TaskAdd_btn.Font = new System.Drawing.Font("Sylfaen", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TaskAdd_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.TaskAdd_btn.Location = new System.Drawing.Point(687, 733);
            this.TaskAdd_btn.Margin = new System.Windows.Forms.Padding(2);
            this.TaskAdd_btn.Name = "TaskAdd_btn";
            this.TaskAdd_btn.Size = new System.Drawing.Size(133, 67);
            this.TaskAdd_btn.TabIndex = 51;
            this.TaskAdd_btn.Text = "Добавить\r\nзадачу";
            this.TaskAdd_btn.UseVisualStyleBackColor = true;
            this.TaskAdd_btn.Click += new System.EventHandler(this.TaskAdd_btn_Click_1);
            // 
            // ArchiveShow_btn
            // 
            this.ArchiveShow_btn.Font = new System.Drawing.Font("Sylfaen", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ArchiveShow_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.ArchiveShow_btn.Location = new System.Drawing.Point(9, 743);
            this.ArchiveShow_btn.Margin = new System.Windows.Forms.Padding(2);
            this.ArchiveShow_btn.Name = "ArchiveShow_btn";
            this.ArchiveShow_btn.Size = new System.Drawing.Size(242, 67);
            this.ArchiveShow_btn.TabIndex = 54;
            this.ArchiveShow_btn.Text = "Архив выполненных задач";
            this.ArchiveShow_btn.UseVisualStyleBackColor = true;
            // 
            // info_task_button
            // 
            this.info_task_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("info_task_button.BackgroundImage")));
            this.info_task_button.Location = new System.Drawing.Point(842, 50);
            this.info_task_button.Name = "info_task_button";
            this.info_task_button.Size = new System.Drawing.Size(292, 50);
            this.info_task_button.TabIndex = 55;
            this.info_task_button.UseVisualStyleBackColor = true;
            this.info_task_button.Click += new System.EventHandler(this.info_task_button_Click);
            // 
            // personal_affairs_btn
            // 
            this.personal_affairs_btn.BackColor = System.Drawing.Color.White;
            this.personal_affairs_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.personal_affairs_btn.Location = new System.Drawing.Point(23, 419);
            this.personal_affairs_btn.Margin = new System.Windows.Forms.Padding(2);
            this.personal_affairs_btn.Name = "personal_affairs_btn";
            this.personal_affairs_btn.Size = new System.Drawing.Size(228, 36);
            this.personal_affairs_btn.TabIndex = 57;
            this.personal_affairs_btn.Text = "Личные дела";
            this.personal_affairs_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personal_affairs_btn.UseVisualStyleBackColor = false;
            this.personal_affairs_btn.Click += new System.EventHandler(this.personal_affairs_btn_Click);
            // 
            // common_afairs_btn
            // 
            this.common_afairs_btn.BackColor = System.Drawing.Color.White;
            this.common_afairs_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.common_afairs_btn.Location = new System.Drawing.Point(23, 478);
            this.common_afairs_btn.Margin = new System.Windows.Forms.Padding(2);
            this.common_afairs_btn.Name = "common_afairs_btn";
            this.common_afairs_btn.Size = new System.Drawing.Size(228, 36);
            this.common_afairs_btn.TabIndex = 63;
            this.common_afairs_btn.Text = "Общие дела";
            this.common_afairs_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.common_afairs_btn.UseVisualStyleBackColor = false;
            this.common_afairs_btn.Click += new System.EventHandler(this.common_afairs_btn_Click);
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1232, 820);
            this.Controls.Add(this.common_afairs_btn);
            this.Controls.Add(this.personal_affairs_btn);
            this.Controls.Add(this.info_task_button);
            this.Controls.Add(this.ArchiveShow_btn);
            this.Controls.Add(this.TaskDone_btn);
            this.Controls.Add(this.TaskDelete_btn);
            this.Controls.Add(this.TaskAdd_btn);
            this.Controls.Add(this.left_panel);
            this.Controls.Add(this.InfoTabel);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.left_pannel);
            this.Controls.Add(this.upper_panel);
            this.Controls.Add(this.Calendar_lbl);
            this.Controls.Add(this.picture_calendar);
            this.Controls.Add(this.monthCalendar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CalendarForm";
            this.Text = "Календарь";
            ((System.ComponentModel.ISupportInitialize)(this.picture_calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoTabel)).EndInit();
            this.left_panel.ResumeLayout(false);
            this.left_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn Parameter;
        private Label label_discription;
        private Label label_date;
        private Label lbl_group;
        private Button TaskDone_btn;
        private Button TaskDelete_btn;
        private Button TaskAdd_btn;
        private Button ArchiveShow_btn;
        private Button info_task_button;
        private TextBox textbox_description;
        private TextBox textbox_date;
        private TextBox textbox_group;
        private Button personal_affairs_btn;
        private Button common_afairs_btn;
        private TextBox textbox_parametr;
        private Label label_parametr;
        private Label label_group;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Group;
    }
}