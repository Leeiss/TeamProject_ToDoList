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
            this.btn_registration = new System.Windows.Forms.Button();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.invented_password = new System.Windows.Forms.TextBox();
            this.invented_login = new System.Windows.Forms.TextBox();
            this.Greetings_lbl = new System.Windows.Forms.Label();
            this.upper_panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_registration
            // 
            this.btn_registration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_registration.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_registration.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_registration.Location = new System.Drawing.Point(277, 431);
            this.btn_registration.Margin = new System.Windows.Forms.Padding(2);
            this.btn_registration.Name = "btn_registration";
            this.btn_registration.Size = new System.Drawing.Size(209, 36);
            this.btn_registration.TabIndex = 32;
            this.btn_registration.Text = "Зарегистрироваться";
            this.btn_registration.UseVisualStyleBackColor = true;
            this.btn_registration.Click += new System.EventHandler(this.btn_registration_Click_1);
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_password.ForeColor = System.Drawing.Color.Gray;
            this.lbl_password.Location = new System.Drawing.Point(64, 291);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(67, 23);
            this.lbl_password.TabIndex = 31;
            this.lbl_password.Text = "Пароль";
            // 
            // lbl_login
            // 
            this.lbl_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_login.ForeColor = System.Drawing.Color.Gray;
            this.lbl_login.Location = new System.Drawing.Point(64, 193);
            this.lbl_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(57, 23);
            this.lbl_login.TabIndex = 30;
            this.lbl_login.Text = "Логин";
            // 
            // invented_password
            // 
            this.invented_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.invented_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.invented_password.Location = new System.Drawing.Point(64, 248);
            this.invented_password.Margin = new System.Windows.Forms.Padding(2);
            this.invented_password.Name = "invented_password";
            this.invented_password.Size = new System.Drawing.Size(353, 30);
            this.invented_password.TabIndex = 29;
            // 
            // invented_login
            // 
            this.invented_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.invented_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.invented_login.Location = new System.Drawing.Point(64, 161);
            this.invented_login.Margin = new System.Windows.Forms.Padding(2);
            this.invented_login.Name = "invented_login";
            this.invented_login.Size = new System.Drawing.Size(353, 30);
            this.invented_login.TabIndex = 28;
            // 
            // Greetings_lbl
            // 
            this.Greetings_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Greetings_lbl.AutoSize = true;
            this.Greetings_lbl.Font = new System.Drawing.Font("Sitka Banner", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Greetings_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Greetings_lbl.Location = new System.Drawing.Point(48, 60);
            this.Greetings_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Greetings_lbl.Name = "Greetings_lbl";
            this.Greetings_lbl.Size = new System.Drawing.Size(403, 48);
            this.Greetings_lbl.TabIndex = 33;
            this.Greetings_lbl.Text = "Регистриция пользователя";
            // 
            // upper_panel
            // 
            this.upper_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upper_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.upper_panel.Location = new System.Drawing.Point(-30, 24);
            this.upper_panel.Margin = new System.Windows.Forms.Padding(2);
            this.upper_panel.Name = "upper_panel";
            this.upper_panel.Size = new System.Drawing.Size(558, 18);
            this.upper_panel.TabIndex = 35;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(495, 477);
            this.Controls.Add(this.upper_panel);
            this.Controls.Add(this.Greetings_lbl);
            this.Controls.Add(this.btn_registration);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.invented_password);
            this.Controls.Add(this.invented_login);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Registration";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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