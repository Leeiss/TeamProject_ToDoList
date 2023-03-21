namespace TeamProject1_ToDoList
{
    partial class NewGroupForm
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
            this.upper_panel = new System.Windows.Forms.Panel();
            this.frame = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.entered_name = new System.Windows.Forms.TextBox();
            this.lbl_members = new System.Windows.Forms.Panel();
            this.lbl_meembers = new System.Windows.Forms.Label();
            this.Create_btn = new System.Windows.Forms.Button();
            this.NewGroup_lbl = new System.Windows.Forms.Label();
            this.Members_list = new System.Windows.Forms.ListBox();
            this.add_button = new System.Windows.Forms.Button();
            this.frame.SuspendLayout();
            this.lbl_members.SuspendLayout();
            this.SuspendLayout();
            // 
            // upper_panel
            // 
            this.upper_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.upper_panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.upper_panel.Location = new System.Drawing.Point(-35, 16);
            this.upper_panel.Margin = new System.Windows.Forms.Padding(2);
            this.upper_panel.Name = "upper_panel";
            this.upper_panel.Size = new System.Drawing.Size(643, 21);
            this.upper_panel.TabIndex = 38;
            // 
            // frame
            // 
            this.frame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frame.Controls.Add(this.lbl_name);
            this.frame.Location = new System.Drawing.Point(9, 145);
            this.frame.Margin = new System.Windows.Forms.Padding(2);
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(220, 53);
            this.frame.TabIndex = 39;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.lbl_name.Location = new System.Drawing.Point(-1, 7);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(198, 35);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Название группы";
            // 
            // entered_name
            // 
            this.entered_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entered_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entered_name.Location = new System.Drawing.Point(265, 159);
            this.entered_name.Margin = new System.Windows.Forms.Padding(2);
            this.entered_name.Name = "entered_name";
            this.entered_name.Size = new System.Drawing.Size(209, 32);
            this.entered_name.TabIndex = 40;
            // 
            // lbl_members
            // 
            this.lbl_members.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_members.Controls.Add(this.lbl_meembers);
            this.lbl_members.Location = new System.Drawing.Point(10, 251);
            this.lbl_members.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_members.Name = "lbl_members";
            this.lbl_members.Size = new System.Drawing.Size(220, 53);
            this.lbl_members.TabIndex = 40;
            // 
            // lbl_meembers
            // 
            this.lbl_meembers.AutoSize = true;
            this.lbl_meembers.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_meembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.lbl_meembers.Location = new System.Drawing.Point(0, 9);
            this.lbl_meembers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_meembers.Name = "lbl_meembers";
            this.lbl_meembers.Size = new System.Drawing.Size(214, 35);
            this.lbl_meembers.TabIndex = 3;
            this.lbl_meembers.Text = "Выбрать участника";
            this.lbl_meembers.Click += new System.EventHandler(this.lbl_meembers_Click);
            // 
            // Create_btn
            // 
            this.Create_btn.Font = new System.Drawing.Font("Sylfaen", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Create_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.Create_btn.Location = new System.Drawing.Point(492, 534);
            this.Create_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.Size = new System.Drawing.Size(106, 40);
            this.Create_btn.TabIndex = 54;
            this.Create_btn.Text = "Создать";
            this.Create_btn.UseVisualStyleBackColor = true;
            this.Create_btn.Click += new System.EventHandler(this.Create_btn_Click);
            // 
            // NewGroup_lbl
            // 
            this.NewGroup_lbl.AutoSize = true;
            this.NewGroup_lbl.Font = new System.Drawing.Font("Sitka Banner", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewGroup_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NewGroup_lbl.Location = new System.Drawing.Point(9, 63);
            this.NewGroup_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NewGroup_lbl.Name = "NewGroup_lbl";
            this.NewGroup_lbl.Size = new System.Drawing.Size(214, 48);
            this.NewGroup_lbl.TabIndex = 55;
            this.NewGroup_lbl.Text = "Новая группа";
            // 
            // Members_list
            // 
            this.Members_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Members_list.FormattingEnabled = true;
            this.Members_list.ItemHeight = 22;
            this.Members_list.Location = new System.Drawing.Point(265, 251);
            this.Members_list.Margin = new System.Windows.Forms.Padding(2);
            this.Members_list.Name = "Members_list";
            this.Members_list.Size = new System.Drawing.Size(209, 224);
            this.Members_list.TabIndex = 60;
            this.Members_list.SelectedIndexChanged += new System.EventHandler(this.Members_list_SelectedIndexChanged);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.add_button.Location = new System.Drawing.Point(483, 251);
            this.add_button.Margin = new System.Windows.Forms.Padding(2);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(106, 40);
            this.add_button.TabIndex = 61;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // NewGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(608, 583);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.Members_list);
            this.Controls.Add(this.NewGroup_lbl);
            this.Controls.Add(this.Create_btn);
            this.Controls.Add(this.lbl_members);
            this.Controls.Add(this.entered_name);
            this.Controls.Add(this.frame);
            this.Controls.Add(this.upper_panel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewGroupForm";
            this.Text = "Создание новой группы";
            this.frame.ResumeLayout(false);
            this.frame.PerformLayout();
            this.lbl_members.ResumeLayout(false);
            this.lbl_members.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel upper_panel;
        private Panel frame;
        private Label lbl_name;
        private TextBox entered_name;
        private Panel lbl_members;
        private Label lbl_meembers;
        private Button Create_btn;
        private Label NewGroup_lbl;
        public ListBox Members_list;
        private Button add_button;
    }
}