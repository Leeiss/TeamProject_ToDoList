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
    public partial class TaskArchive : Form
    {
        public TaskArchive()
        {
            InitializeComponent();
        }

        private void PersonalTasks_radio_btn_CheckedChanged(object sender, EventArgs e)
        {

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM archivetasks WHERE userlogin = @log AND parametr = 'Общая' ", db.GetConnection());
            command1.Parameters.Add("@log", MySqlDbType.VarChar).Value = login;


            db.OpenConnection();
            DbDataReader reader = command1.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[5]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();


            }
            reader.Close();
            db.CloseConnection();

            InfoTabel.Rows.Clear();

            foreach (string[] s in data)
            {
                InfoTabel.Rows.Add(s);
            }



           

           


        }

        private string login;

        public void GetInfo(string log)
        {
            login = log;

        }

        private void button1_Click(object sender, EventArgs e)
        {          
            DataBase db = new DataBase();

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM archivetasks WHERE userlogin = @log AND parametr = 'Личная' ", db.GetConnection());
            command1.Parameters.Add("@log", MySqlDbType.VarChar).Value = login;


            db.OpenConnection();
            DbDataReader reader = command1.ExecuteReader();
            List<string[]> data = new List<string[]>();
            

            while (reader.Read())
            {
                data.Add(new string[5]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();

            }
            reader.Close();

            db.CloseConnection();

            InfoTabel.Rows.Clear();

            foreach (string[] s in data)
            {
                InfoTabel.Rows.Add(s);
            }


            TimeSpan time = DateTime.UtcNow.Subtract(Convert.ToDateTime(data[InfoTabel.CurrentCell.RowIndex][2]));
            string comment = data[InfoTabel.CurrentCell.RowIndex][4];

            int i = InfoTabel.CurrentCell.RowIndex;

            textbox_description.Text = InfoTabel[0, i].Value.ToString();
            textbox_parametr.Text = InfoTabel[1, i].Value.ToString();
            textbox_date.Text = InfoTabel[2, i].Value.ToString();
            textbox_group.Text = InfoTabel[3, i].Value.ToString();
            textbox_comment.Text = comment;
            textbox_time.Text = time.Days.ToString() + " дней";
            textbox_user.Text = login;

        }

        private void TaskArchive_Load(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM groups WHERE  userlogin = @L", db.GetConnection());
            command1.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;


            db.OpenConnection();
            DbDataReader reader = command1.ExecuteReader();
            string statement = "";

            if (reader.Read())
            {
                statement = reader.GetString(0);
            }


            Groups_list.Items.Clear();
            while (reader.Read())
            {
                Groups_list.Items.Add((string)reader[0]);

            }
        }

        private void Groups_list_MouseClick(object sender, MouseEventArgs e)
        {
            DataBase db = new DataBase();

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM archivetasks WHERE userlogin = @log AND namegroup = @ng", db.GetConnection());
            command1.Parameters.Add("@log", MySqlDbType.VarChar).Value = login;
            command1.Parameters.Add("@ng", MySqlDbType.VarChar).Value = Groups_list.SelectedItem.ToString();

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

        

        private void InfoTabel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            {
                for (int i = 0; i < InfoTabel.RowCount; i++)
                {
                    InfoTabel.Rows[i].Selected = false;
                    for (int j = 0; j < InfoTabel.ColumnCount; j++)
                        if (InfoTabel.Rows[i].Cells[j].Value != null)
                            if (InfoTabel.Rows[i].Cells[j].Value.ToString().Contains(Entered_Text.Text))

                            {
                                InfoTabel.Rows[i].Selected = true;

                                break;
                            }
                }
            }
        }

        private void Entered_Text_Click(object sender, EventArgs e)
        {
            Entered_Text.Clear();
        }
    }
}
