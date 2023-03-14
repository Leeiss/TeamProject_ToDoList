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
            Greetings = new Label();
            lbl_instruction = new Label();
            entered_login = new TextBox();
            entered_password = new TextBox();
            lbl_login = new Label();
            lbl_password = new Label();
            to_come_in_button = new Button();
            register_button = new Button();
            upper_panel2 = new Panel();
            upper_panel1 = new Panel();
            SuspendLayout();
            // 
            // Greetings
            // 
            Greetings.AutoSize = true;
            Greetings.Font = new Font("Sitka Banner", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            Greetings.ForeColor = Color.Black;
            Greetings.Location = new Point(115, 51);
            Greetings.Name = "Greetings";
            Greetings.Size = new Size(668, 62);
            Greetings.TabIndex = 20;
            Greetings.Text = "Добро пожаловать в \"Список дел\"!\r\n";
            // 
            // lbl_instruction
            // 
            lbl_instruction.AutoSize = true;
            lbl_instruction.Font = new Font("Sitka Display", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_instruction.ForeColor = Color.Black;
            lbl_instruction.Location = new Point(157, 140);
            lbl_instruction.Name = "lbl_instruction";
            lbl_instruction.Size = new Size(567, 42);
            lbl_instruction.TabIndex = 21;
            lbl_instruction.Text = "Войдите в учетную запись для продолжения";
            // 
            // entered_login
            // 
            entered_login.Font = new Font("XO Courser", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            entered_login.Location = new Point(206, 270);
            entered_login.Name = "entered_login";
            entered_login.Size = new Size(458, 38);
            entered_login.TabIndex = 22;
            // 
            // entered_password
            // 
            entered_password.Font = new Font("XO Courser", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            entered_password.Location = new Point(206, 381);
            entered_password.Name = "entered_password";
            entered_password.Size = new Size(458, 38);
            entered_password.TabIndex = 23;
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_login.ForeColor = Color.Gray;
            lbl_login.Location = new Point(206, 311);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(81, 31);
            lbl_login.TabIndex = 24;
            lbl_login.Text = "Логин";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_password.ForeColor = Color.Gray;
            lbl_password.Location = new Point(206, 436);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(92, 31);
            lbl_password.TabIndex = 25;
            lbl_password.Text = "Пароль";
            // 
            // to_come_in_button
            // 
            to_come_in_button.Font = new Font("Sylfaen", 10F, FontStyle.Regular, GraphicsUnit.Point);
            to_come_in_button.ForeColor = SystemColors.ControlDarkDark;
            to_come_in_button.Location = new Point(719, 522);
            to_come_in_button.Name = "to_come_in_button";
            to_come_in_button.Size = new Size(150, 46);
            to_come_in_button.TabIndex = 26;
            to_come_in_button.Text = "Войти";
            to_come_in_button.UseVisualStyleBackColor = true;
            to_come_in_button.Click += to_come_in_Click;
            // 
            // register_button
            // 
            register_button.Font = new Font("Sylfaen", 10F, FontStyle.Regular, GraphicsUnit.Point);
            register_button.ForeColor = SystemColors.ControlDarkDark;
            register_button.Location = new Point(420, 522);
            register_button.Name = "register_button";
            register_button.Size = new Size(272, 46);
            register_button.TabIndex = 27;
            register_button.Text = "Зарегистрироваться";
            register_button.UseVisualStyleBackColor = true;
            register_button.Click += register_button_Click;
            // 
            // upper_panel2
            // 
            upper_panel2.BackColor = SystemColors.ActiveCaption;
            upper_panel2.Location = new Point(-13, 116);
            upper_panel2.Name = "upper_panel2";
            upper_panel2.Size = new Size(942, 21);
            upper_panel2.TabIndex = 28;
            // 
            // upper_panel1
            // 
            upper_panel1.BackColor = SystemColors.ActiveCaption;
            upper_panel1.Location = new Point(-36, 1);
            upper_panel1.Name = "upper_panel1";
            upper_panel1.Size = new Size(981, 24);
            upper_panel1.TabIndex = 29;
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(881, 580);
            Controls.Add(upper_panel1);
            Controls.Add(register_button);
            Controls.Add(to_come_in_button);
            Controls.Add(lbl_password);
            Controls.Add(lbl_login);
            Controls.Add(entered_password);
            Controls.Add(entered_login);
            Controls.Add(lbl_instruction);
            Controls.Add(Greetings);
            Controls.Add(upper_panel2);
            Name = "UserLogin";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
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