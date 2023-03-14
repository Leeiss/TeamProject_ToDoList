namespace TeamProject1_ToDoList
{
    partial class TaskDone
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
            TaskDone_lbl = new Label();
            lbl_comment = new Label();
            Entered_Comment = new TextBox();
            CloseTask_btn = new Button();
            SuspendLayout();
            // 
            // TaskDone_lbl
            // 
            TaskDone_lbl.AutoSize = true;
            TaskDone_lbl.Font = new Font("Sitka Banner", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            TaskDone_lbl.ForeColor = Color.FromArgb(159, 108, 80);
            TaskDone_lbl.Location = new Point(12, 18);
            TaskDone_lbl.Name = "TaskDone_lbl";
            TaskDone_lbl.Size = new Size(332, 53);
            TaskDone_lbl.TabIndex = 5;
            TaskDone_lbl.Text = "Задача выполнена!\r\n";
            // 
            // lbl_comment
            // 
            lbl_comment.AutoSize = true;
            lbl_comment.Font = new Font("Sylfaen", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_comment.ForeColor = Color.Gray;
            lbl_comment.Location = new Point(24, 104);
            lbl_comment.Name = "lbl_comment";
            lbl_comment.Size = new Size(186, 35);
            lbl_comment.TabIndex = 58;
            lbl_comment.Text = "Комментарий ";
            lbl_comment.Click += lbl_mygroups_Click;
            // 
            // Entered_Comment
            // 
            Entered_Comment.BorderStyle = BorderStyle.FixedSingle;
            Entered_Comment.Font = new Font("XO Courser", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            Entered_Comment.ForeColor = SystemColors.ActiveCaptionText;
            Entered_Comment.Location = new Point(34, 142);
            Entered_Comment.Name = "Entered_Comment";
            Entered_Comment.Size = new Size(500, 38);
            Entered_Comment.TabIndex = 63;
            Entered_Comment.TabStop = false;
            // 
            // CloseTask_btn
            // 
            CloseTask_btn.Font = new Font("Sylfaen", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            CloseTask_btn.ForeColor = Color.FromArgb(159, 108, 80);
            CloseTask_btn.Location = new Point(380, 304);
            CloseTask_btn.Name = "CloseTask_btn";
            CloseTask_btn.Size = new Size(235, 44);
            CloseTask_btn.TabIndex = 64;
            CloseTask_btn.Text = "Закрыть задание";
            CloseTask_btn.UseVisualStyleBackColor = true;
            // 
            // TaskDone
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(627, 360);
            Controls.Add(CloseTask_btn);
            Controls.Add(Entered_Comment);
            Controls.Add(lbl_comment);
            Controls.Add(TaskDone_lbl);
            Name = "TaskDone";
            Text = "Архивация выполненой задачи";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TaskDone_lbl;
        private Label lbl_comment;
        private TextBox Entered_Comment;
        private Button CloseTask_btn;
    }
}