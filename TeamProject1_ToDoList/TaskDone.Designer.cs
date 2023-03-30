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
            this.TaskDone_lbl = new System.Windows.Forms.Label();
            this.lbl_comment = new System.Windows.Forms.Label();
            this.Entered_Comment = new System.Windows.Forms.TextBox();
            this.CloseTask_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TaskDone_lbl
            // 
            this.TaskDone_lbl.AutoSize = true;
            this.TaskDone_lbl.Font = new System.Drawing.Font("Sitka Banner", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TaskDone_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.TaskDone_lbl.Location = new System.Drawing.Point(9, 14);
            this.TaskDone_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TaskDone_lbl.Name = "TaskDone_lbl";
            this.TaskDone_lbl.Size = new System.Drawing.Size(252, 40);
            this.TaskDone_lbl.TabIndex = 5;
            this.TaskDone_lbl.Text = "Задача выполнена!\r\n";
            // 
            // lbl_comment
            // 
            this.lbl_comment.AutoSize = true;
            this.lbl_comment.Font = new System.Drawing.Font("Sylfaen", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_comment.ForeColor = System.Drawing.Color.Gray;
            this.lbl_comment.Location = new System.Drawing.Point(18, 81);
            this.lbl_comment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_comment.Name = "lbl_comment";
            this.lbl_comment.Size = new System.Drawing.Size(146, 27);
            this.lbl_comment.TabIndex = 58;
            this.lbl_comment.Text = "Комментарий ";
            // 
            // Entered_Comment
            // 
            this.Entered_Comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Entered_Comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Entered_Comment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Entered_Comment.Location = new System.Drawing.Point(26, 111);
            this.Entered_Comment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Entered_Comment.Name = "Entered_Comment";
            this.Entered_Comment.Size = new System.Drawing.Size(385, 30);
            this.Entered_Comment.TabIndex = 63;
            this.Entered_Comment.TabStop = false;
            // 
            // CloseTask_btn
            // 
            this.CloseTask_btn.Font = new System.Drawing.Font("Sylfaen", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseTask_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.CloseTask_btn.Location = new System.Drawing.Point(292, 238);
            this.CloseTask_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CloseTask_btn.Name = "CloseTask_btn";
            this.CloseTask_btn.Size = new System.Drawing.Size(181, 34);
            this.CloseTask_btn.TabIndex = 64;
            this.CloseTask_btn.Text = "Закрыть задание";
            this.CloseTask_btn.UseVisualStyleBackColor = true;
            this.CloseTask_btn.Click += new System.EventHandler(this.CloseTask_btn_Click);
            // 
            // TaskDone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 281);
            this.Controls.Add(this.CloseTask_btn);
            this.Controls.Add(this.Entered_Comment);
            this.Controls.Add(this.lbl_comment);
            this.Controls.Add(this.TaskDone_lbl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TaskDone";
            this.Text = "Архивация выполненой задачи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TaskDone_lbl;
        private Label lbl_comment;
        private TextBox Entered_Comment;
        private Button CloseTask_btn;
    }
}