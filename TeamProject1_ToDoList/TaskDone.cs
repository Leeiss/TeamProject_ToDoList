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
    public partial class TaskDone : Form
    {
        public TaskDone()
        {
            InitializeComponent();
        }

        private void lbl_mygroups_Click(object sender, EventArgs e)
        {

        }

        private string login;
        private string group;
        private string date;
        private string task;
        private string parametr;



        public void GetInfo(string login,string group, string date, string task, string parametr)
        {
            this.login = login;
            this.group = group;
            this.date = date; 
            this.task = task;
            this.parametr = parametr;

        }

        private void CloseTask_btn_Click(object sender, EventArgs e)

        {


            MainForm mainForm= new MainForm();

            


            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO archivetasks (`namegroup`, `date`,`task`,`userlogin`,`comment`,`parametr`) VALUES(@ng, @dt, @tsk,@uL,@com,@pr)", db.GetConnection());
            command.Parameters.Add("@ng", MySqlDbType.VarChar).Value = group;
            command.Parameters.Add("@dt", MySqlDbType.VarChar).Value = date;
            command.Parameters.Add("@tsk", MySqlDbType.VarChar).Value = task;
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@com", MySqlDbType.VarChar).Value = Entered_Comment.Text;
            command.Parameters.Add("@pr", MySqlDbType.VarChar).Value = parametr;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Задача добавлена в архив успешно!");





            }
            else
            {
                MessageBox.Show("Ошибка!Попробуйте позже!");
            }


            if (parametr == "Личная")
            {
                MySqlCommand command2 = new MySqlCommand("DELETE  FROM persontask WHERE userlogin = @del AND task = @tsk ", db.GetConnection());
                command2.Parameters.Add("@del", MySqlDbType.VarChar).Value = login;
                command2.Parameters.Add("@tsk", MySqlDbType.VarChar).Value = task;

                command2.ExecuteReader();

            }
            else
            {
                MySqlCommand command3 = new MySqlCommand("DELETE  FROM tasks WHERE userlogin = @del AND task = @tsk ", db.GetConnection());
                command3.Parameters.Add("@del", MySqlDbType.VarChar).Value = login;
                command3.Parameters.Add("@tsk", MySqlDbType.VarChar).Value = task;

                command3.ExecuteReader();
            }

           

            db.CloseConnection();

        }
    }
}
