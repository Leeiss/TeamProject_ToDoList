using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamProject1_ToDoList.Classes;

namespace TeamProject1_ToDoList
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        private void Registration_Load(object sender, EventArgs e)
        {
            invented_password.PasswordChar = '*';
        }



        private void btn_registration_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`) VALUES(@login, @password)", db.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = invented_login.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = invented_password.Text;

            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!");





            }
            else
            {
                MessageBox.Show("Ошибка!Попробуйте позже!");
            }


            db.CloseConnection();

            MessageBox.Show("Вы успешно зарегестрированы! Можете войти в систему");
            Close();
        }

        private void btn_registration_Click_1(object sender, EventArgs e)
        {

        }

     
    }
}
