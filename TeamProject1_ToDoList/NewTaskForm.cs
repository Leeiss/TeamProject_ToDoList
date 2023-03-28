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
    public partial class NewTaskForm : Form
    {
        public NewTaskForm()
        {
            InitializeComponent();
        }

        private string login;
        public void Getlogin(string log)
        {

            login = log;
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            selected_date.MaxSelectionCount = 1;
          
            String task = entered_describtion.Text;
            string date = selected_date.SelectionRange.Start.ToShortDateString();


            
            DataBase db = new DataBase();
            if (entered_date_interval.Text == "")
            {

                MySqlCommand command = new MySqlCommand("INSERT INTO persontask (`namegroup`,`date`, `userlogin`,`task`) VALUES(@name, @date, @log, @tsk)", db.GetConnection());
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = "Нет";
                command.Parameters.Add("@date", MySqlDbType.VarChar).Value = date;
                command.Parameters.Add("@log", MySqlDbType.VarChar).Value = login;
                command.Parameters.Add("@tsk", MySqlDbType.VarChar).Value = task;


                db.OpenConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Задача создана успешно!");

                }
                else
                {
                    MessageBox.Show("Ошибка!Попробуйте еще раз!");
                }
            }
            else 
            {
                try
                {
                    int interval = Convert.ToInt32(entered_date_interval.Text);
                     if(interval > 0)
                    {
                        MessageBox.Show("Повторяющаяся задача назначена успешно!");
                        Countdown(task,interval);
                    }


                }

                catch
                {
                    MessageBox.Show("Ошибка!Введите число!");

                }
                db.CloseConnection();
            }


        }


        private async void Countdown(string task,int interval)
        {
            var start = DateTime.UtcNow;
            var end = start.AddDays(Convert.ToInt32(entered_date_interval.Text));
            var diff = TimeSpan.FromDays(Convert.ToInt32(entered_date_interval.Text));
            string date = DateTime.UtcNow.ToString("yyyy-dd-MM");

            DataBase db = new DataBase();

            MySqlCommand command = new MySqlCommand("INSERT INTO persontask (`namegroup`,`date`, `userlogin`,`task`,`interval_value`) VALUES(@name, @date, @log, @tsk,@inter)", db.GetConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = "Нет";
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = date;
            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@tsk", MySqlDbType.VarChar).Value = task;
            command.Parameters.Add("@inter", MySqlDbType.VarChar).Value = interval;
            db.OpenConnection();


            if (command.ExecuteNonQuery() == 1)
            {

            }
            else
            {
            }


            while ((DateTime.UtcNow - start) < diff)
            {
                await Task.Delay(1000);
            }

            MySqlCommand command1 = new MySqlCommand("DELETE  FROM persontask WHERE userlogin = @log AND task = @tsk AND interval_value = @inter", db.GetConnection());
            command1.Parameters.Add("@log", MySqlDbType.VarChar).Value = login;
            command1.Parameters.Add("@tsk", MySqlDbType.VarChar).Value = task;
            command1.Parameters.Add("@inter", MySqlDbType.VarChar).Value = interval;

            command1.ExecuteNonQuery();



            Countdown(task, interval);
           
            db.CloseConnection();
        }
    }
}
