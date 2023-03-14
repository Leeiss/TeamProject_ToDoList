namespace TeamProject1_ToDoList
{
    partial class Registration
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
            btn_registration = new Button();
            lbl_password = new Label();
            lbl_login = new Label();
            invented_password = new TextBox();
            invented_login = new TextBox();
            Greetings_lbl = new Label();
            upper_panel = new Panel();
            SuspendLayout();
            // 
            // btn_registration
            // 
            btn_registration.Font = new Font("Sylfaen", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_registration.ForeColor = SystemColors.ControlDarkDark;
            btn_registration.Location = new Point(360, 552);
            btn_registration.Name = "btn_registration";
            btn_registration.Size = new Size(272, 46);
            btn_registration.TabIndex = 32;
            btn_registration.Text = "Зарегистрироваться";
            btn_registration.UseVisualStyleBackColor = true;
            btn_registration.Click += btn_registration_Click;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_password.ForeColor = Color.Gray;
            lbl_password.Location = new Point(83, 372);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(92, 31);
            lbl_password.TabIndex = 31;
            lbl_password.Text = "Пароль";
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_login.ForeColor = Color.Gray;
            lbl_login.Location = new Point(83, 247);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(81, 31);
            lbl_login.TabIndex = 30;
            lbl_login.Text = "Логин";
            // 
            // invented_password
            // 
            invented_password.Font = new Font("XO Courser", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            invented_password.Location = new Point(83, 317);
            invented_password.Name = "invented_password";
            invented_password.Size = new Size(458, 38);
            invented_password.TabIndex = 29;
            // 
            // invented_login
            // 
            invented_login.Font = new Font("XO Courser", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            invented_login.Location = new Point(83, 206);
            invented_login.Name = "invented_login";
            invented_login.Size = new Size(458, 38);
            invented_login.TabIndex = 28;
            // 
            // Greetings_lbl
            // 
            Greetings_lbl.AutoSize = true;
            Greetings_lbl.Font = new Font("Sitka Banner", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            Greetings_lbl.ForeColor = SystemColors.ActiveCaptionText;
            Greetings_lbl.Location = new Point(12, 76);
            Greetings_lbl.Name = "Greetings_lbl";
            Greetings_lbl.Size = new Size(529, 62);
            Greetings_lbl.TabIndex = 33;
            Greetings_lbl.Text = "Регистриция пользователя";
            // 
            // upper_panel
            // 
            upper_panel.BackColor = SystemColors.ActiveCaption;
            upper_panel.Location = new Point(-39, 31);
            upper_panel.Name = "upper_panel";
            upper_panel.Size = new Size(726, 23);
            upper_panel.TabIndex = 35;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(644, 610);
            Controls.Add(upper_panel);
            Controls.Add(Greetings_lbl);
            Controls.Add(btn_registration);
            Controls.Add(lbl_password);
            Controls.Add(lbl_login);
            Controls.Add(invented_password);
            Controls.Add(invented_login);
            Name = "Registration";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_registration;
        private Label lbl_password;
        private Label lbl_login;
        private TextBox invented_password;
        private TextBox invented_login;
        private Label Greetings_lbl;
        private Panel upper_panel;
    }
}