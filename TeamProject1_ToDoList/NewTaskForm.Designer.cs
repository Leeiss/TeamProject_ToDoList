namespace TeamProject1_ToDoList
{
    partial class NewTaskForm
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
            this.Create_lbl = new System.Windows.Forms.Label();
            this.lbl_instruction = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_discription = new System.Windows.Forms.Label();
            this.entered_describtion = new System.Windows.Forms.TextBox();
            this.selected_date = new System.Windows.Forms.MonthCalendar();
            this.Create_btn = new System.Windows.Forms.Button();
            this.lbl_repeat = new System.Windows.Forms.Label();
            this.entered_date_interval = new System.Windows.Forms.TextBox();
            this.lbl_days = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Create_lbl
            // 
            this.Create_lbl.AutoSize = true;
            this.Create_lbl.Font = new System.Drawing.Font("Sitka Banner", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Create_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.Create_lbl.Location = new System.Drawing.Point(9, 22);
            this.Create_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Create_lbl.Name = "Create_lbl";
            this.Create_lbl.Size = new System.Drawing.Size(355, 48);
            this.Create_lbl.TabIndex = 4;
            this.Create_lbl.Text = "Создание новой задачи";
            // 
            // lbl_instruction
            // 
            this.lbl_instruction.AutoSize = true;
            this.lbl_instruction.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_instruction.ForeColor = System.Drawing.Color.Gray;
            this.lbl_instruction.Location = new System.Drawing.Point(9, 636);
            this.lbl_instruction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_instruction.Name = "lbl_instruction";
            this.lbl_instruction.Size = new System.Drawing.Size(306, 46);
            this.lbl_instruction.TabIndex = 58;
            this.lbl_instruction.Text = "*Для создания новой задачи в группе, \r\nвы должны создать свою группу";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_date.Location = new System.Drawing.Point(21, 158);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(63, 26);
            this.lbl_date.TabIndex = 61;
            this.lbl_date.Text = "Дата";
            // 
            // lbl_discription
            // 
            this.lbl_discription.AutoSize = true;
            this.lbl_discription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_discription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_discription.Location = new System.Drawing.Point(21, 87);
            this.lbl_discription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_discription.Name = "lbl_discription";
            this.lbl_discription.Size = new System.Drawing.Size(112, 26);
            this.lbl_discription.TabIndex = 59;
            this.lbl_discription.Text = "Описание";
            // 
            // entered_describtion
            // 
            this.entered_describtion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entered_describtion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entered_describtion.Location = new System.Drawing.Point(273, 87);
            this.entered_describtion.Margin = new System.Windows.Forms.Padding(2);
            this.entered_describtion.Name = "entered_describtion";
            this.entered_describtion.Size = new System.Drawing.Size(228, 32);
            this.entered_describtion.TabIndex = 65;
            // 
            // selected_date
            // 
            this.selected_date.Location = new System.Drawing.Point(273, 158);
            this.selected_date.Margin = new System.Windows.Forms.Padding(7);
            this.selected_date.Name = "selected_date";
            this.selected_date.TabIndex = 67;
            // 
            // Create_btn
            // 
            this.Create_btn.Font = new System.Drawing.Font("Sylfaen", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Create_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.Create_btn.Location = new System.Drawing.Point(402, 645);
            this.Create_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.Size = new System.Drawing.Size(106, 40);
            this.Create_btn.TabIndex = 68;
            this.Create_btn.Text = "Создать";
            this.Create_btn.UseVisualStyleBackColor = true;
            this.Create_btn.Click += new System.EventHandler(this.Create_btn_Click);
            // 
            // lbl_repeat
            // 
            this.lbl_repeat.AutoSize = true;
            this.lbl_repeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_repeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_repeat.Location = new System.Drawing.Point(21, 545);
            this.lbl_repeat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_repeat.Name = "lbl_repeat";
            this.lbl_repeat.Size = new System.Drawing.Size(261, 50);
            this.lbl_repeat.TabIndex = 69;
            this.lbl_repeat.Text = "Сделать повторяющейся\r\n каждые";
            // 
            // entered_date_interval
            // 
            this.entered_date_interval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entered_date_interval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entered_date_interval.Location = new System.Drawing.Point(322, 548);
            this.entered_date_interval.Margin = new System.Windows.Forms.Padding(2);
            this.entered_date_interval.Name = "entered_date_interval";
            this.entered_date_interval.Size = new System.Drawing.Size(83, 32);
            this.entered_date_interval.TabIndex = 70;
            // 
            // lbl_days
            // 
            this.lbl_days.AutoSize = true;
            this.lbl_days.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_days.Location = new System.Drawing.Point(417, 550);
            this.lbl_days.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_days.Name = "lbl_days";
            this.lbl_days.Size = new System.Drawing.Size(60, 25);
            this.lbl_days.TabIndex = 71;
            this.lbl_days.Text = "дней";
            // 
            // NewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(517, 694);
            this.Controls.Add(this.lbl_days);
            this.Controls.Add(this.entered_date_interval);
            this.Controls.Add(this.lbl_repeat);
            this.Controls.Add(this.Create_btn);
            this.Controls.Add(this.selected_date);
            this.Controls.Add(this.entered_describtion);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_discription);
            this.Controls.Add(this.lbl_instruction);
            this.Controls.Add(this.Create_lbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewTaskForm";
            this.Text = "Новое задание";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Create_lbl;
        private Label lbl_instruction;
        private Label lbl_date;
        private Label lbl_discription;
        private TextBox entered_describtion;
        private MonthCalendar selected_date;
        private Button Create_btn;
        private Label lbl_repeat;
        private TextBox entered_date_interval;
        private Label label1;
        private Label lbl_days;
    }
}