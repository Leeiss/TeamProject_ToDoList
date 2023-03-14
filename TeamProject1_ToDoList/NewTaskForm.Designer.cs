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
            Create_lbl = new Label();
            lbl_instruction = new Label();
            lbl_date = new Label();
            lbl_discription = new Label();
            entered_describtion = new TextBox();
            selected_date = new MonthCalendar();
            Create_btn = new Button();
            SuspendLayout();
            // 
            // Create_lbl
            // 
            Create_lbl.AutoSize = true;
            Create_lbl.Font = new Font("Sitka Banner", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            Create_lbl.ForeColor = Color.FromArgb(159, 108, 80);
            Create_lbl.Location = new Point(12, 28);
            Create_lbl.Name = "Create_lbl";
            Create_lbl.Size = new Size(464, 62);
            Create_lbl.TabIndex = 4;
            Create_lbl.Text = "Создание новой задачи";
            // 
            // lbl_instruction
            // 
            lbl_instruction.AutoSize = true;
            lbl_instruction.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_instruction.ForeColor = Color.Gray;
            lbl_instruction.Location = new Point(27, 660);
            lbl_instruction.Name = "lbl_instruction";
            lbl_instruction.Size = new Size(420, 62);
            lbl_instruction.TabIndex = 58;
            lbl_instruction.Text = "*Для создания новой задачи в группе, \r\nвы должны создать свою группу";
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Font = new Font("XO Courser", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_date.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_date.Location = new Point(27, 302);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(82, 32);
            lbl_date.TabIndex = 61;
            lbl_date.Text = "Дата";
            // 
            // lbl_discription
            // 
            lbl_discription.AutoSize = true;
            lbl_discription.Font = new Font("XO Courser", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_discription.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_discription.Location = new Point(27, 184);
            lbl_discription.Name = "lbl_discription";
            lbl_discription.Size = new Size(150, 32);
            lbl_discription.TabIndex = 59;
            lbl_discription.Text = "Описание";
            // 
            // entered_describtion
            // 
            entered_describtion.BorderStyle = BorderStyle.FixedSingle;
            entered_describtion.Font = new Font("XO Courser", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            entered_describtion.Location = new Point(344, 184);
            entered_describtion.Name = "entered_describtion";
            entered_describtion.Size = new Size(285, 40);
            entered_describtion.TabIndex = 65;
            // 
            // selected_date
            // 
            selected_date.Location = new Point(344, 288);
            selected_date.Name = "selected_date";
            selected_date.TabIndex = 67;
            // 
            // Create_btn
            // 
            Create_btn.Font = new Font("Sylfaen", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            Create_btn.ForeColor = Color.FromArgb(159, 108, 80);
            Create_btn.Location = new Point(491, 660);
            Create_btn.Name = "Create_btn";
            Create_btn.Size = new Size(138, 51);
            Create_btn.TabIndex = 68;
            Create_btn.Text = "Создать";
            Create_btn.UseVisualStyleBackColor = true;
            // 
            // NewTaskForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(658, 731);
            Controls.Add(Create_btn);
            Controls.Add(selected_date);
            Controls.Add(entered_describtion);
            Controls.Add(lbl_date);
            Controls.Add(lbl_discription);
            Controls.Add(lbl_instruction);
            Controls.Add(Create_lbl);
            Name = "NewTaskForm";
            Text = "Новое задание";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Create_lbl;
        private Label lbl_instruction;
        private Label lbl_date;
        private Label lbl_discription;
        private TextBox entered_describtion;
        private MonthCalendar selected_date;
        private Button Create_btn;
    }
}