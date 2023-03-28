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
using System.Windows.Forms.VisualStyles;
using TeamProject1_ToDoList.Classes;

namespace TeamProject1_ToDoList
{
    public partial class CalendarForm : Form
    {
        public CalendarForm()
        {
            InitializeComponent();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            lbl_date.Text = monthCalendar.SelectionRange.End.ToString("dd.MM.yyyy");
        }

        private void ArchiveShow_btn_Click(object sender, EventArgs e)
        {
            TaskArchive taskArchive = new TaskArchive();
            taskArchive.Show();
        }

        private void TaskDone_btn_Click(object sender, EventArgs e)
        {
            TaskDone taskDoneForm = new TaskDone();
            taskDoneForm.Show();
        }

        private void TastDelete_btn_Click(object sender, EventArgs e)
        {
            //удалить из базы данных выбранную задачу
            MessageBox.Show("Задача успешно удалена");
        }

        private void TaskAdd_btn_Click(object sender, EventArgs e)
        {
            NewTaskForm newTaskForm = new NewTaskForm();
            newTaskForm.Show();
        }


        private string login;
        public void Getlogin(string log)
        {

            login = log;
        }

        private void showt_asks_button_Click(object sender, EventArgs e)
        {
            
        }

        private void info_task_button_Click(object sender, EventArgs e)
        {
            int i = InfoTabel.CurrentCell.RowIndex;


            textbox_group.Text = InfoTabel[0, i].Value.ToString();
            textbox_date.Text = InfoTabel[1, i].Value.ToString();
            textbox_description.Text = InfoTabel[2, i].Value.ToString();
            textbox_parametr.Text = InfoTabel[3, i].Value.ToString();
        }

        private void TaskAdd_btn_Click_1(object sender, EventArgs e)
        {
            NewTaskForm newTaskForm = new NewTaskForm();
            newTaskForm.Getlogin(login);
            newTaskForm.ShowDialog();
        }

        private void personal_affairs_btn_Click(object sender, EventArgs e)
        {

            DataBase db = new DataBase();

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM persontask WHERE userlogin = @log", db.GetConnection());
            command1.Parameters.Add("@log", MySqlDbType.VarChar).Value = login;


            db.OpenConnection();
            DbDataReader reader = command1.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();


            }
            reader.Close();
            db.CloseConnection();

            InfoTabel.Rows.Clear();

            foreach (string[] s in data)
            {
                InfoTabel.Rows.Add(s);
            }

        }

        private void common_afairs_btn_Click(object sender, EventArgs e)
        {


            DataBase db = new DataBase();

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM tasks WHERE userlogin = @log", db.GetConnection());
            command1.Parameters.Add("@log", MySqlDbType.VarChar).Value = login;


            db.OpenConnection();
            DbDataReader reader = command1.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();


            }
            reader.Close();
            db.CloseConnection();

            InfoTabel.Rows.Clear();

            foreach (string[] s in data)
            {
                InfoTabel.Rows.Add(s);
            }

        }
    }
}
