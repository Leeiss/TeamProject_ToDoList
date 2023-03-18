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
    }
}
