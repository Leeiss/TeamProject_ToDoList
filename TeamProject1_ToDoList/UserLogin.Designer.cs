namespace TeamProject1_ToDoList
{
    partial class UserLogin
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
            this.Greetings = new System.Windows.Forms.Label();
            this.lbl_instruction = new System.Windows.Forms.Label();
            this.entered_login = new System.Windows.Forms.TextBox();
            this.entered_password = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.to_come_in_button = new System.Windows.Forms.Button();
            this.register_button = new System.Windows.Forms.Button();
            this.upper_panel2 = new System.Windows.Forms.Panel();
            this.upper_panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Greetings
            // 
            this.Greetings.AutoSize = true;
            this.Greetings.Font = new System.Drawing.Font("Sitka Banner", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Greetings.ForeColor = System.Drawing.Color.Black;
            this.Greetings.Location = new System.Drawing.Point(88, 40);
            this.Greetings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Greetings.Name = "Greetings";
            this.Greetings.Size = new System.Drawing.Size(514, 48);
            this.Greetings.TabIndex = 20;
            this.Greetings.Text = "Добро пожаловать в \"Список дел\"!\r\n";
            // 
            // lbl_instruction
            // 
            this.lbl_instruction.AutoSize = true;
            this.lbl_instruction.Font = new System.Drawing.Font("Sitka Display", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_instruction.ForeColor = System.Drawing.Color.Black;
            this.lbl_instruction.Location = new System.Drawing.Point(121, 109);
            this.lbl_instruction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_instruction.Name = "lbl_instruction";
            this.lbl_instruction.Size = new System.Drawing.Size(427, 32);
            this.lbl_instruction.TabIndex = 21;
            this.lbl_instruction.Text = "Войдите в учетную запись для продолжения";
            // 
            // entered_login
            // 
            this.entered_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entered_login.Location = new System.Drawing.Point(158, 211);
            this.entered_login.Margin = new System.Windows.Forms.Padding(2);
            this.entered_login.Name = "entered_login";
            this.entered_login.Size = new System.Drawing.Size(353, 30);
            this.entered_login.TabIndex = 22;
            // 
            // entered_password
            // 
            this.entered_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entered_password.Location = new System.Drawing.Point(158, 298);
            this.entered_password.Margin = new System.Windows.Forms.Padding(2);
            this.entered_password.Name = "entered_password";
            this.entered_password.Size = new System.Drawing.Size(353, 30);
            this.entered_password.TabIndex = 23;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_login.ForeColor = System.Drawing.Color.Gray;
            this.lbl_login.Location = new System.Drawing.Point(158, 243);
            this.lbl_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(57, 23);
            this.lbl_login.TabIndex = 24;
            this.lbl_login.Text = "Логин";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_password.ForeColor = System.Drawing.Color.Gray;
            this.lbl_password.Location = new System.Drawing.Point(158, 341);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(67, 23);
            this.lbl_password.TabIndex = 25;
            this.lbl_password.Text = "Пароль";
            // 
            // to_come_in_button
            // 
            this.to_come_in_button.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.to_come_in_button.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.to_come_in_button.Location = new System.Drawing.Point(553, 408);
            this.to_come_in_button.Margin = new System.Windows.Forms.Padding(2);
            this.to_come_in_button.Name = "to_come_in_button";
            this.to_come_in_button.Size = new System.Drawing.Size(115, 36);
            this.to_come_in_button.TabIndex = 26;
            this.to_come_in_button.Text = "Войти";
            this.to_come_in_button.UseVisualStyleBackColor = true;
            this.to_come_in_button.Click += new System.EventHandler(this.to_come_in_button_Click);
            // 
            // register_button
            // 
            this.register_button.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.register_button.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.register_button.Location = new System.Drawing.Point(323, 408);
            this.register_button.Margin = new System.Windows.Forms.Padding(2);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(209, 36);
            this.register_button.TabIndex = 27;
            this.register_button.Text = "Зарегистрироваться";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click_1);
            // 
            // upper_panel2
            // 
            this.upper_panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.upper_panel2.Location = new System.Drawing.Point(-10, 91);
            this.upper_panel2.Margin = new System.Windows.Forms.Padding(2);
            this.upper_panel2.Name = "upper_panel2";
            this.upper_panel2.Size = new System.Drawing.Size(725, 16);
            this.upper_panel2.TabIndex = 28;
            // 
            // upper_panel1
            // 
            this.upper_panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.upper_panel1.Location = new System.Drawing.Point(-28, 1);
            this.upper_panel1.Margin = new System.Windows.Forms.Padding(2);
            this.upper_panel1.Name = "upper_panel1";
            this.upper_panel1.Size = new System.Drawing.Size(755, 19);
            this.upper_panel1.TabIndex = 29;
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(678, 453);
            this.Controls.Add(this.upper_panel1);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.to_come_in_button);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.entered_password);
            this.Controls.Add(this.entered_login);
            this.Controls.Add(this.lbl_instruction);
            this.Controls.Add(this.Greetings);
            this.Controls.Add(this.upper_panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserLogin";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_instruction;
        private Label Greetings;
        private TextBox entered_login;
        private TextBox entered_password;
        private Label lbl_login;
        private Label lbl_password;
        private Button to_come_in_button;
        private Button register_button;
        private Panel upper_panel2;
        private Panel upper_panel1;
    }
}