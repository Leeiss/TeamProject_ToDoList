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

namespace TeamProject1_ToDoList
{
    public partial class AppointForm : Form
    {
        public AppointForm()
        {
            InitializeComponent();

        }


        private void MyGroups_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {

        }
        private string login;
        public void Getlogin(string log)
        {

            login = log;
        }

        public void show_listGroup_button_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM groups WHERE  userlogin = @L ", db.GetConnection());
            command1.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;



            db.OpenConnection();
            DbDataReader reader = command1.ExecuteReader();
            string statement = "";

            if (reader.Read())
            {
                statement = reader.GetString(0);
            }

            MyGroups_list.Items.Clear();
            while (reader.Read())
            {
                MyGroups_list.Items.Add((string)reader[0]);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataBase db = new DataBase();

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM groups WHERE  namegroup = @G ", db.GetConnection());
            command1.Parameters.Add("@G", MySqlDbType.VarChar).Value = MyGroups_list.SelectedItem.ToString();



            db.OpenConnection();
            DbDataReader reader = command1.ExecuteReader();
            string statement = "";

            if (reader.Read())
            {
                statement = reader.GetString(0);
            }

            Members_list.Items.Clear();
            while (reader.Read())
            { 
                Members_list.Items.Add((string)reader[1]);

            }


        }

        private void Appoint_btn_Click(object sender, EventArgs e)
        {
            String namegroup = MyGroups_list.SelectedItem.ToString();
            String login = Members_list.SelectedItem.ToString();
            String task = Entered_Text.Text;
            string date = DateTime.UtcNow.ToString("yyyy-dd-");



            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `tasks` (`namegroup`,`date`, `userlogin`,`task`) VALUES(@name,@date, @log, @tsk)", db.GetConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = namegroup;
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = date;
            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@tsk", MySqlDbType.VarChar).Value = task;


            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Задача присвоена успешно!");





            }
            else
            {
                MessageBox.Show("Ошибка!Попробуйте еще раз!");
            }
        }

        private void show_listGroup_button2_Click(object sender, EventArgs e)
        {

            DataBase db = new DataBase();

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM groups WHERE  userlogin = @L ", db.GetConnection());
            command1.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;



            db.OpenConnection();
            DbDataReader reader = command1.ExecuteReader();
            string statement = "";

            if (reader.Read())
            {
                statement = reader.GetString(0);
            }

            MyGroups_list2.Items.Clear();
            while (reader.Read())
            {
                MyGroups_list2.Items.Add((string)reader[0]);

            }

        }

        private void show_listMembers_button2_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM groups WHERE  namegroup = @G ", db.GetConnection());
            command1.Parameters.Add("@G", MySqlDbType.VarChar).Value = MyGroups_list2.SelectedItem.ToString();



            db.OpenConnection();
            DbDataReader reader = command1.ExecuteReader();
            string statement = "";

            if (reader.Read())
            {
                statement = reader.GetString(0);
            }

            Members_list2.Items.Clear();
            while (reader.Read())
            {
                Members_list2.Items.Add((string)reader[1]);

            }

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            String namegroup = MyGroups_list2.SelectedItem.ToString();
            String login = Members_list2.SelectedItem.ToString();


            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("DELETE FROM `tasks`  WHERE `namegroup` = @name AND `userlogin` = @log", db.GetConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = namegroup;
            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = login;

            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Задача удалена успешно!");





            }
            else
            {
                MessageBox.Show("Ошибка!Попробуйте еще раз!");
            }

        }
    }
}
