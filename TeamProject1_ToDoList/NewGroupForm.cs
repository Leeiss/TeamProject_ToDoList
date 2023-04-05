using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamProject1_ToDoList.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TeamProject1_ToDoList
{
    public partial class NewGroupForm : Form
    {
        public NewGroupForm()
        {
            InitializeComponent();
        }

        private void Members_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }



        private string login;

        public string GetLogin
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        private void lbl_meembers_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT * FROM users", db.GetConnection());
            db.OpenConnection();
            DbDataReader reader = command.ExecuteReader();
            string statement = "";

            if (reader.Read())
            {
                statement = reader.GetString(0);
            }


            while (reader.Read())
            {
                Members_list.Items.Add((string)reader[1]);
                
            }


        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            String groupname = entered_name.Text;

            MySqlCommand command = new MySqlCommand("INSERT INTO `groups` (`namegroup`) VALUES (@gn)", db.GetConnection());

            command.Parameters.Add("@gn", MySqlDbType.VarChar).Value = groupname;

            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Группа успешно создана");
                





            }
            else
            {
                MessageBox.Show("Ошибка!Попробуйте позже!");
            }


            db.CloseConnection();

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            db.OpenConnection();

            String groupname = entered_name.Text;
            String userlog = Members_list.SelectedItem.ToString();


            MySqlCommand command = new MySqlCommand("SELECT * FROM groups WHERE adminstatus = @Admstat AND namegroup = @ng ", db.GetConnection()); // создаем объект и передаем команду для вытягивания из бд логина и пароля из бд
            command.Parameters.Add("@Admstat", MySqlDbType.VarChar).Value = 1;
            command.Parameters.Add("@ng", MySqlDbType.VarChar).Value = groupname;

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command; // выполняем команду


            DataTable table = new DataTable();

            adapter.Fill(table);// записываем данные в объект класса DataTable



            if (table.Rows.Count == 0)
            {

                MySqlCommand command1 = new MySqlCommand("INSERT INTO `groups` (`namegroup`, `userlogin`,`adminstatus`) VALUES (@gn, @ulog, 1)", db.GetConnection());

                command1.Parameters.Add("@gn", MySqlDbType.VarChar).Value = groupname;
                command1.Parameters.Add("@ulog", MySqlDbType.VarChar).Value = login;

                command1.ExecuteNonQuery();

            }


            MySqlCommand command2 = new MySqlCommand("INSERT INTO `groups` (`namegroup`, `userlogin`) VALUES (@gn, @ulog)", db.GetConnection());

            command2.Parameters.Add("@gn", MySqlDbType.VarChar).Value = groupname;
            command2.Parameters.Add("@ulog", MySqlDbType.VarChar).Value = userlog;

            if (command2.ExecuteNonQuery() == 1)
            {

                MessageBox.Show("Пользователь добавлен");


            }
            else
            {
                MessageBox.Show("Ошибка!Попробуйте позже!");
            }


           




            db.CloseConnection();

        }
    }
}
