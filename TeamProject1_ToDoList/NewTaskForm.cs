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
    }
}
