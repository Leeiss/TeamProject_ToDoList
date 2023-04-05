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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.upper_panel = new System.Windows.Forms.Panel();
            this.search_btn = new System.Windows.Forms.Button();
            this.MainPicture = new System.Windows.Forms.PictureBox();
            this.Entered_Text = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_account = new System.Windows.Forms.Label();
            this.left_panel = new System.Windows.Forms.Panel();
            this.archive_task_btn = new System.Windows.Forms.Button();
            this.Open_calendar_btn = new System.Windows.Forms.Button();
            this.common_afairs_btn = new System.Windows.Forms.Button();
            this.show_group_button = new System.Windows.Forms.Button();
            this.AppointTask_lbl = new System.Windows.Forms.Button();
            this.MyGroups_btn = new System.Windows.Forms.Button();
            this.PersonGroups_list = new System.Windows.Forms.ListBox();
            this.personal_affairs_btn = new System.Windows.Forms.Button();
            this.frame = new System.Windows.Forms.Panel();
            this.my_tasks_lbl = new System.Windows.Forms.Label();
            this.TypeOfTask_lbl = new System.Windows.Forms.Label();
            this.InfoTabel = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parametr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.right_panel = new System.Windows.Forms.Panel();
            this.TaskAdd_btn = new System.Windows.Forms.Button();
            this.TaskDelete_btn = new System.Windows.Forms.Button();
            this.TaskDone_btn = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_group = new System.Windows.Forms.Label();
            this.lbl_discription = new System.Windows.Forms.Label();
            this.parametr_lable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_group = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.label_parametr = new System.Windows.Forms.Label();
            this.upper_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPicture)).BeginInit();
            this.left_panel.SuspendLayout();
            this.frame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoTabel)).BeginInit();
            this.SuspendLayout();
            // 
            // upper_panel
            // 
            this.upper_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upper_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.upper_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upper_panel.Controls.Add(this.search_btn);
            this.upper_panel.Controls.Add(this.MainPicture);
            this.upper_panel.Controls.Add(this.Entered_Text);
            this.upper_panel.Controls.Add(this.lbl_name);
            this.upper_panel.Controls.Add(this.lbl_account);
            this.upper_panel.Location = new System.Drawing.Point(-10, 0);
            this.upper_panel.Margin = new System.Windows.Forms.Padding(2);
            this.upper_panel.Name = "upper_panel";
            this.upper_panel.Size = new System.Drawing.Size(1301, 64);
            this.upper_panel.TabIndex = 0;
            // 
            // search_btn
            // 
            this.search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_btn.BackgroundImage = global::TeamProject1_ToDoList.Properties.Resources.SearchPicture1;
            this.search_btn.Location = new System.Drawing.Point(1252, 22);
            this.search_btn.Margin = new System.Windows.Forms.Padding(2);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(45, 31);
            this.search_btn.TabIndex = 62;
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // MainPicture
            // 
            this.MainPicture.Image = global::TeamProject1_ToDoList.Properties.Resources.MainIcon;
            this.MainPicture.Location = new System.Drawing.Point(18, 4);
            this.MainPicture.Margin = new System.Windows.Forms.Padding(2);
            this.MainPicture.Name = "MainPicture";
            this.MainPicture.Size = new System.Drawing.Size(55, 56);
            this.MainPicture.TabIndex = 16;
            this.MainPicture.TabStop = false;
            // 
            // Entered_Text
            // 
            this.Entered_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Entered_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Entered_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Entered_Text.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Entered_Text.Location = new System.Drawing.Point(1014, 22);
            this.Entered_Text.Margin = new System.Windows.Forms.Padding(2);
            this.Entered_Text.Multiline = true;
            this.Entered_Text.Name = "Entered_Text";
            this.Entered_Text.Size = new System.Drawing.Size(247, 31);
            this.Entered_Text.TabIndex = 61;
            this.Entered_Text.TabStop = false;
            this.Entered_Text.Text = "Поиск по таблице..";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.lbl_name.Location = new System.Drawing.Point(86, 6);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(95, 30);
            this.lbl_name.TabIndex = 18;
            this.lbl_name.Text = "Namee_";
            // 
            // lbl_account
            // 
            this.lbl_account.AutoSize = true;
            this.lbl_account.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_account.ForeColor = System.Drawing.Color.Gray;
            this.lbl_account.Location = new System.Drawing.Point(89, 34);
            this.lbl_account.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_account.Name = "lbl_account";
            this.lbl_account.Size = new System.Drawing.Size(129, 23);
            this.lbl_account.TabIndex = 17;
            this.lbl_account.Text = "Учетная запись";
            // 
            // left_panel
            // 
            this.left_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.left_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.left_panel.Controls.Add(this.archive_task_btn);
            this.left_panel.Controls.Add(this.Open_calendar_btn);
            this.left_panel.Controls.Add(this.common_afairs_btn);
            this.left_panel.Controls.Add(this.show_group_button);
            this.left_panel.Controls.Add(this.AppointTask_lbl);
            this.left_panel.Controls.Add(this.MyGroups_btn);
            this.left_panel.Controls.Add(this.PersonGroups_list);
            this.left_panel.Controls.Add(this.personal_affairs_btn);
            this.left_panel.Controls.Add(this.frame);
            this.left_panel.Location = new System.Drawing.Point(-2, 55);
            this.left_panel.Margin = new System.Windows.Forms.Padding(2);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(300, 817);
            this.left_panel.TabIndex = 1;
            // 
            // archive_task_btn
            // 
            this.archive_task_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.archive_task_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("archive_task_btn.BackgroundImage")));
            this.archive_task_btn.Location = new System.Drawing.Point(8, 650);
            this.archive_task_btn.Name = "archive_task_btn";
            this.archive_task_btn.Size = new System.Drawing.Size(240, 57);
            this.archive_task_btn.TabIndex = 64;
            this.archive_task_btn.UseVisualStyleBackColor = true;
            this.archive_task_btn.Click += new System.EventHandler(this.archive_task_btn_Click);
            // 
            // Open_calendar_btn
            // 
            this.Open_calendar_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Open_calendar_btn.BackgroundImage")));
            this.Open_calendar_btn.Location = new System.Drawing.Point(11, 536);
            this.Open_calendar_btn.Name = "Open_calendar_btn";
            this.Open_calendar_btn.Size = new System.Drawing.Size(241, 52);
            this.Open_calendar_btn.TabIndex = 63;
            this.Open_calendar_btn.UseVisualStyleBackColor = true;
            this.Open_calendar_btn.Click += new System.EventHandler(this.Open_calendar_btn_Click);
            // 
            // common_afairs_btn
            // 
            this.common_afairs_btn.BackColor = System.Drawing.Color.White;
            this.common_afairs_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.common_afairs_btn.Location = new System.Drawing.Point(12, 202);
            this.common_afairs_btn.Margin = new System.Windows.Forms.Padding(2);
            this.common_afairs_btn.Name = "common_afairs_btn";
            this.common_afairs_btn.Size = new System.Drawing.Size(258, 36);
            this.common_afairs_btn.TabIndex = 62;
            this.common_afairs_btn.Text = "Общие дела";
            this.common_afairs_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.common_afairs_btn.UseVisualStyleBackColor = false;
            this.common_afairs_btn.Click += new System.EventHandler(this.common_afairs_btn_Click);
            // 
            // show_group_button
            // 
            this.show_group_button.Location = new System.Drawing.Point(12, 277);
            this.show_group_button.Name = "show_group_button";
            this.show_group_button.Size = new System.Drawing.Size(112, 34);
            this.show_group_button.TabIndex = 60;
            this.show_group_button.Text = "Группы";
            this.show_group_button.UseVisualStyleBackColor = true;
            this.show_group_button.Click += new System.EventHandler(this.show_group_button_Click);
            // 
            // AppointTask_lbl
            // 
            this.AppointTask_lbl.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AppointTask_lbl.ForeColor = System.Drawing.Color.Gray;
            this.AppointTask_lbl.Location = new System.Drawing.Point(153, 422);
            this.AppointTask_lbl.Margin = new System.Windows.Forms.Padding(2);
            this.AppointTask_lbl.Name = "AppointTask_lbl";
            this.AppointTask_lbl.Size = new System.Drawing.Size(118, 62);
            this.AppointTask_lbl.TabIndex = 61;
            this.AppointTask_lbl.Text = "Управление группами";
            this.AppointTask_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AppointTask_lbl.UseVisualStyleBackColor = true;
            this.AppointTask_lbl.Click += new System.EventHandler(this.AppointTask_lbl_Click_1);
            // 
            // MyGroups_btn
            // 
            this.MyGroups_btn.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MyGroups_btn.ForeColor = System.Drawing.Color.Gray;
            this.MyGroups_btn.Location = new System.Drawing.Point(8, 422);
            this.MyGroups_btn.Margin = new System.Windows.Forms.Padding(2);
            this.MyGroups_btn.Name = "MyGroups_btn";
            this.MyGroups_btn.Size = new System.Drawing.Size(138, 62);
            this.MyGroups_btn.TabIndex = 60;
            this.MyGroups_btn.Text = "Создать новую группу";
            this.MyGroups_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyGroups_btn.UseVisualStyleBackColor = true;
            this.MyGroups_btn.Click += new System.EventHandler(this.MyGroups_btn_Click);
            // 
            // PersonGroups_list
            // 
            this.PersonGroups_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PersonGroups_list.FormattingEnabled = true;
            this.PersonGroups_list.ItemHeight = 26;
            this.PersonGroups_list.Location = new System.Drawing.Point(11, 316);
            this.PersonGroups_list.Margin = new System.Windows.Forms.Padding(2);
            this.PersonGroups_list.Name = "PersonGroups_list";
            this.PersonGroups_list.Size = new System.Drawing.Size(259, 82);
            this.PersonGroups_list.TabIndex = 57;
            this.PersonGroups_list.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PersonGroups_list_MouseClick);
            // 
            // personal_affairs_btn
            // 
            this.personal_affairs_btn.BackColor = System.Drawing.Color.White;
            this.personal_affairs_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.personal_affairs_btn.Location = new System.Drawing.Point(12, 141);
            this.personal_affairs_btn.Margin = new System.Windows.Forms.Padding(2);
            this.personal_affairs_btn.Name = "personal_affairs_btn";
            this.personal_affairs_btn.Size = new System.Drawing.Size(258, 36);
            this.personal_affairs_btn.TabIndex = 20;
            this.personal_affairs_btn.Text = "Личные дела";
            this.personal_affairs_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personal_affairs_btn.UseVisualStyleBackColor = false;
            this.personal_affairs_btn.Click += new System.EventHandler(this.personal_affairs_btn_Click_1);
            // 
            // frame
            // 
            this.frame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frame.Controls.Add(this.my_tasks_lbl);
            this.frame.Location = new System.Drawing.Point(12, 28);
            this.frame.Margin = new System.Windows.Forms.Padding(2);
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(259, 90);
            this.frame.TabIndex = 21;
            // 
            // my_tasks_lbl
            // 
            this.my_tasks_lbl.AutoSize = true;
            this.my_tasks_lbl.Font = new System.Drawing.Font("Sitka Banner", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.my_tasks_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.my_tasks_lbl.Location = new System.Drawing.Point(-4, 16);
            this.my_tasks_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.my_tasks_lbl.Name = "my_tasks_lbl";
            this.my_tasks_lbl.Size = new System.Drawing.Size(188, 48);
            this.my_tasks_lbl.TabIndex = 3;
            this.my_tasks_lbl.Text = "Мои задачи";
            // 
            // TypeOfTask_lbl
            // 
            this.TypeOfTask_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TypeOfTask_lbl.AutoSize = true;
            this.TypeOfTask_lbl.Font = new System.Drawing.Font("Sitka Banner", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TypeOfTask_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.TypeOfTask_lbl.Location = new System.Drawing.Point(309, 83);
            this.TypeOfTask_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TypeOfTask_lbl.Name = "TypeOfTask_lbl";
            this.TypeOfTask_lbl.Size = new System.Drawing.Size(123, 48);
            this.TypeOfTask_lbl.TabIndex = 19;
            this.TypeOfTask_lbl.Text = "Задачи";
            // 
            // InfoTabel
            // 
            this.InfoTabel.AllowUserToDeleteRows = false;
            this.InfoTabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoTabel.BackgroundColor = System.Drawing.Color.White;
            this.InfoTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfoTabel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Date,
            this.Group,
            this.Parametr});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Sitka Small", 9.124999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InfoTabel.DefaultCellStyle = dataGridViewCellStyle4;
            this.InfoTabel.Location = new System.Drawing.Point(309, 151);
            this.InfoTabel.Margin = new System.Windows.Forms.Padding(2);
            this.InfoTabel.Name = "InfoTabel";
            this.InfoTabel.RowHeadersWidth = 82;
            this.InfoTabel.RowTemplate.Height = 41;
            this.InfoTabel.Size = new System.Drawing.Size(529, 587);
            this.InfoTabel.TabIndex = 44;
            this.InfoTabel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InfoTabel_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Heading", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.HeaderText = "Группа ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Heading", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Date.DefaultCellStyle = dataGridViewCellStyle2;
            this.Date.HeaderText = "Дата ";
            this.Date.MinimumWidth = 10;
            this.Date.Name = "Date";
            this.Date.Width = 90;
            // 
            // Group
            // 
            this.Group.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Heading", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Group.DefaultCellStyle = dataGridViewCellStyle3;
            this.Group.HeaderText = "Описание";
            this.Group.MinimumWidth = 10;
            this.Group.Name = "Group";
            this.Group.Width = 128;
            // 
            // Parametr
            // 
            this.Parametr.HeaderText = "Параметр";
            this.Parametr.MinimumWidth = 8;
            this.Parametr.Name = "Parametr";
            this.Parametr.Width = 150;
            // 
            // right_panel
            // 
            this.right_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.right_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.right_panel.Location = new System.Drawing.Point(852, 55);
            this.right_panel.Margin = new System.Windows.Forms.Padding(2);
            this.right_panel.Name = "right_panel";
            this.right_panel.Size = new System.Drawing.Size(11, 814);
            this.right_panel.TabIndex = 47;
            // 
            // TaskAdd_btn
            // 
            this.TaskAdd_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskAdd_btn.Font = new System.Drawing.Font("Sylfaen", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TaskAdd_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.TaskAdd_btn.Location = new System.Drawing.Point(705, 755);
            this.TaskAdd_btn.Margin = new System.Windows.Forms.Padding(2);
            this.TaskAdd_btn.Name = "TaskAdd_btn";
            this.TaskAdd_btn.Size = new System.Drawing.Size(133, 67);
            this.TaskAdd_btn.TabIndex = 48;
            this.TaskAdd_btn.Text = "Добавить\r\nзадачу";
            this.TaskAdd_btn.UseVisualStyleBackColor = true;
            this.TaskAdd_btn.Click += new System.EventHandler(this.TaskAdd_btn_Click_1);
            // 
            // TaskDelete_btn
            // 
            this.TaskDelete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskDelete_btn.Font = new System.Drawing.Font("Sylfaen", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TaskDelete_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.TaskDelete_btn.Location = new System.Drawing.Point(555, 755);
            this.TaskDelete_btn.Margin = new System.Windows.Forms.Padding(2);
            this.TaskDelete_btn.Name = "TaskDelete_btn";
            this.TaskDelete_btn.Size = new System.Drawing.Size(133, 67);
            this.TaskDelete_btn.TabIndex = 49;
            this.TaskDelete_btn.Text = "Удалить\r\nзадачу";
            this.TaskDelete_btn.UseVisualStyleBackColor = true;
            this.TaskDelete_btn.Click += new System.EventHandler(this.TaskDelete_btn_Click_1);
            // 
            // TaskDone_btn
            // 
            this.TaskDone_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskDone_btn.Font = new System.Drawing.Font("Sylfaen", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TaskDone_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.TaskDone_btn.Location = new System.Drawing.Point(408, 755);
            this.TaskDone_btn.Margin = new System.Windows.Forms.Padding(2);
            this.TaskDone_btn.Name = "TaskDone_btn";
            this.TaskDone_btn.Size = new System.Drawing.Size(133, 67);
            this.TaskDone_btn.TabIndex = 50;
            this.TaskDone_btn.Text = "Выполнить\r\nзадачу";
            this.TaskDone_btn.UseVisualStyleBackColor = true;
            this.TaskDone_btn.Click += new System.EventHandler(this.TaskDone_btn_Click_1);
            // 
            // lbl_date
            // 
            this.lbl_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_date.Location = new System.Drawing.Point(882, 405);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(63, 26);
            this.lbl_date.TabIndex = 55;
            this.lbl_date.Text = "Дата";
            // 
            // lbl_group
            // 
            this.lbl_group.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_group.AutoSize = true;
            this.lbl_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_group.Location = new System.Drawing.Point(882, 578);
            this.lbl_group.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_group.Name = "lbl_group";
            this.lbl_group.Size = new System.Drawing.Size(112, 26);
            this.lbl_group.TabIndex = 54;
            this.lbl_group.Text = "Описание";
            // 
            // lbl_discription
            // 
            this.lbl_discription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_discription.AutoSize = true;
            this.lbl_discription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_discription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_discription.Location = new System.Drawing.Point(882, 234);
            this.lbl_discription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_discription.Name = "lbl_discription";
            this.lbl_discription.Size = new System.Drawing.Size(83, 26);
            this.lbl_discription.TabIndex = 52;
            this.lbl_discription.Text = "Группа";
            // 
            // parametr_lable
            // 
            this.parametr_lable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.parametr_lable.AutoSize = true;
            this.parametr_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.parametr_lable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.parametr_lable.Location = new System.Drawing.Point(882, 740);
            this.parametr_lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.parametr_lable.Name = "parametr_lable";
            this.parametr_lable.Size = new System.Drawing.Size(114, 26);
            this.parametr_lable.TabIndex = 66;
            this.parametr_lable.Text = "Параметр";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(882, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 46);
            this.label1.TabIndex = 68;
            // 
            // label_group
            // 
            this.label_group.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_group.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label_group.Location = new System.Drawing.Point(1061, 213);
            this.label_group.Name = "label_group";
            this.label_group.Size = new System.Drawing.Size(191, 64);
            this.label_group.TabIndex = 69;
            // 
            // label_date
            // 
            this.label_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_date.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label_date.Location = new System.Drawing.Point(1061, 389);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(191, 64);
            this.label_date.TabIndex = 70;
            this.label_date.Click += new System.EventHandler(this.label_date_Click);
            // 
            // label_description
            // 
            this.label_description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_description.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label_description.Location = new System.Drawing.Point(1061, 563);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(191, 64);
            this.label_description.TabIndex = 71;
            // 
            // label_parametr
            // 
            this.label_parametr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_parametr.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label_parametr.Location = new System.Drawing.Point(1061, 721);
            this.label_parametr.Name = "label_parametr";
            this.label_parametr.Size = new System.Drawing.Size(191, 64);
            this.label_parametr.TabIndex = 72;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1290, 823);
            this.Controls.Add(this.label_parametr);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_group);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parametr_lable);
            this.Controls.Add(this.TypeOfTask_lbl);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_group);
            this.Controls.Add(this.lbl_discription);
            this.Controls.Add(this.upper_panel);
            this.Controls.Add(this.TaskDone_btn);
            this.Controls.Add(this.TaskDelete_btn);
            this.Controls.Add(this.TaskAdd_btn);
            this.Controls.Add(this.right_panel);
            this.Controls.Add(this.InfoTabel);
            this.Controls.Add(this.left_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Список дел";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.upper_panel.ResumeLayout(false);
            this.upper_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPicture)).EndInit();
            this.left_panel.ResumeLayout(false);
            this.frame.ResumeLayout(false);
            this.frame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoTabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        public DataGridView InfoTabel;
        private Panel right_panel;
        private Button TaskAdd_btn;
        private Button TaskDelete_btn;
        private Button TaskDone_btn;
        public ListBox PersonGroups_list;
        private Label lbl_date;
        private Label lbl_group;
        private Label lbl_discription;
        private Button search_btn;
        private TextBox Entered_Text;
        private Button MyGroups_btn;
        private Button AppointTask_lbl;
        private Button show_group_button;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Group;
        private Button common_afairs_btn;
        private DataGridViewTextBoxColumn Parametr;
        private Label parametr_lable;
        private Button Open_calendar_btn;
        private Button archive_task_btn;
        private Label label1;
        private Label label_group;
        private Label label_date;
        private Label label_description;
        private Label label_parametr;
    }
}