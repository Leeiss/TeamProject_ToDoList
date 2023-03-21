using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamProject1_ToDoList.Classes;

namespace TeamProject1_ToDoList
{
    public partial class UserLogin : Form
    {

        
        public UserLogin()
        {
            InitializeComponent();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        


        public void to_come_in_button_Click(object sender, EventArgs e)
        {
            String loginUser = entered_login.Text;// помещаем данные введеные пользователем в переменную
            String passUser = entered_password.Text;

            DataBase db = new DataBase();


            


            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE  login = @uL AND password = @uP ",db.GetConnection()); // создаем объект и передаем команду для вытягивания из бд логина и пароля из бд
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command; // выполняем команду


            DataTable table = new DataTable();

            adapter.Fill(table);// записываем данные в объект класса DataTable



            if (table.Rows.Count > 0)
            {

                MainForm mainForm = new MainForm();

                mainForm.GetLogin = loginUser;


                


                mainForm.ShowDialog();
                

            }

            else
            {
                MessageBox.Show("Пользователь с такими данными не найден!");
            }
           
        }

        private void register_button_Click_1(object sender, EventArgs e)
            
        {
           // NewGroupForm newGroupForm = new NewGroupForm();

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`) VALUES(@login, @password)",db.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = entered_login.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = entered_password.Text;

            db.OpenConnection();
            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!");
                
                
                
                
                
            }
            else
            {
                MessageBox.Show("Ошибка!Попробуйте позже!");
            }


            db.CloseConnection();
        }
    }
    
}
