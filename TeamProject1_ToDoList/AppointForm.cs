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
    }
}
