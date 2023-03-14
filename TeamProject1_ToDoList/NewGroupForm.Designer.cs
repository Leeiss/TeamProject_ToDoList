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
            upper_panel = new Panel();
            frame = new Panel();
            lbl_name = new Label();
            entered_name = new TextBox();
            lbl_members = new Panel();
            lbl_meembers = new Label();
            Create_btn = new Button();
            NewGroup_lbl = new Label();
            Members_list = new ListBox();
            add_button = new Button();
            frame.SuspendLayout();
            lbl_members.SuspendLayout();
            SuspendLayout();
            // 
            // upper_panel
            // 
            upper_panel.BackColor = Color.FromArgb(159, 108, 80);
            upper_panel.ForeColor = Color.FromArgb(159, 108, 80);
            upper_panel.Location = new Point(-46, 20);
            upper_panel.Name = "upper_panel";
            upper_panel.Size = new Size(836, 27);
            upper_panel.TabIndex = 38;
            // 
            // frame
            // 
            frame.BorderStyle = BorderStyle.FixedSingle;
            frame.Controls.Add(lbl_name);
            frame.Location = new Point(12, 185);
            frame.Name = "frame";
            frame.Size = new Size(286, 67);
            frame.TabIndex = 39;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_name.ForeColor = Color.FromArgb(159, 108, 80);
            lbl_name.Location = new Point(-1, 9);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(263, 47);
            lbl_name.TabIndex = 3;
            lbl_name.Text = "Название группы";
            // 
            // entered_name
            // 
            entered_name.BorderStyle = BorderStyle.FixedSingle;
            entered_name.Font = new Font("XO Courser", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            entered_name.Location = new Point(344, 204);
            entered_name.Name = "entered_name";
            entered_name.Size = new Size(271, 40);
            entered_name.TabIndex = 40;
            // 
            // lbl_members
            // 
            lbl_members.BorderStyle = BorderStyle.FixedSingle;
            lbl_members.Controls.Add(lbl_meembers);
            lbl_members.Location = new Point(13, 321);
            lbl_members.Name = "lbl_members";
            lbl_members.Size = new Size(285, 67);
            lbl_members.TabIndex = 40;
            // 
            // lbl_meembers
            // 
            lbl_meembers.AutoSize = true;
            lbl_meembers.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_meembers.ForeColor = Color.FromArgb(159, 108, 80);
            lbl_meembers.Location = new Point(0, 12);
            lbl_meembers.Name = "lbl_meembers";
            lbl_meembers.Size = new Size(171, 47);
            lbl_meembers.TabIndex = 3;
            lbl_meembers.Text = "Участники";
            // 
            // Create_btn
            // 
            Create_btn.Font = new Font("Sylfaen", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            Create_btn.ForeColor = Color.FromArgb(159, 108, 80);
            Create_btn.Location = new Point(640, 683);
            Create_btn.Name = "Create_btn";
            Create_btn.Size = new Size(138, 51);
            Create_btn.TabIndex = 54;
            Create_btn.Text = "Создать";
            Create_btn.UseVisualStyleBackColor = true;
            // 
            // NewGroup_lbl
            // 
            NewGroup_lbl.AutoSize = true;
            NewGroup_lbl.Font = new Font("Sitka Banner", 16.1249981F, FontStyle.Bold, GraphicsUnit.Point);
            NewGroup_lbl.ForeColor = Color.FromArgb(64, 64, 64);
            NewGroup_lbl.Location = new Point(12, 81);
            NewGroup_lbl.Name = "NewGroup_lbl";
            NewGroup_lbl.Size = new Size(278, 62);
            NewGroup_lbl.TabIndex = 55;
            NewGroup_lbl.Text = "Новая группа";
            // 
            // Members_list
            // 
            Members_list.Font = new Font("XO Courser", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Members_list.FormattingEnabled = true;
            Members_list.ItemHeight = 27;
            Members_list.Items.AddRange(new object[] { "Person1", "Person2" });
            Members_list.Location = new Point(344, 321);
            Members_list.Name = "Members_list";
            Members_list.Size = new Size(271, 301);
            Members_list.TabIndex = 60;
            // 
            // add_button
            // 
            add_button.Font = new Font("XO Courser", 9F, FontStyle.Regular, GraphicsUnit.Point);
            add_button.ForeColor = Color.FromArgb(64, 64, 64);
            add_button.Location = new Point(628, 321);
            add_button.Name = "add_button";
            add_button.Size = new Size(138, 51);
            add_button.TabIndex = 61;
            add_button.Text = "Добавить";
            add_button.UseVisualStyleBackColor = true;
            // 
            // NewGroupForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(790, 746);
            Controls.Add(add_button);
            Controls.Add(Members_list);
            Controls.Add(NewGroup_lbl);
            Controls.Add(Create_btn);
            Controls.Add(lbl_members);
            Controls.Add(entered_name);
            Controls.Add(frame);
            Controls.Add(upper_panel);
            Name = "NewGroupForm";
            Text = "Создание новой группы";
            frame.ResumeLayout(false);
            frame.PerformLayout();
            lbl_members.ResumeLayout(false);
            lbl_members.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private ListBox Members_list;
        private Button add_button;
    }
}