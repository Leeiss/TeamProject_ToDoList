using MySql.Data.MySqlClient;
using System.Data.Common;
using TeamProject1_ToDoList.Classes;


namespace TeamProject1_ToDoList
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void lbl_name_Click_1(object sender, EventArgs e)
        {
            CalendarForm neeew = new CalendarForm();
            neeew.ShowDialog();

        }

        private void CalendarMove(object sender, MouseEventArgs e)
        {
            Calendar_lbl.Font = new Font("Sitka Banner", 16.125F, FontStyle.Underline, GraphicsUnit.Point);
        }

        private void CalendarLeave(object sender, EventArgs e)
        {
            Calendar_lbl.Font = new Font("Sitka Banner", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
        }

        private void personal_affairs_btn_Click(object sender, EventArgs e)
        {
            TypeOfTask_lbl.Text = "Личные дела";
        }

        private void window_clear(object sender, EventArgs e)
        {
            Entered_Text.Text = "";
        }

        private void ArchiveShow_btn_Click(object sender, EventArgs e)
        {
            TaskArchive taskArchive = new TaskArchive();
            taskArchive.Show();
        }

        private void PersonGroups_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeOfTask_lbl.Text = "Общие дела";
        }

        private void MyGroups_btn_Click(object sender, EventArgs e)
        {
            NewGroupForm newGroupForm = new NewGroupForm();
            newGroupForm.Show();
        }

        private void TaskDelete_btn_Click(object sender, EventArgs e)
        {
            //удалить задачу из бд
            MessageBox.Show("Задача успешно удалена");
        }

        private void TaskAdd_btn_Click(object sender, EventArgs e)
        {
            NewTaskForm newTaskForm = new NewTaskForm();
            newTaskForm.Show();
        }

        private void TaskDone_btn_Click(object sender, EventArgs e)
        {
            TaskDone newTask = new TaskDone();
            newTask.Show();
        }

        private void AppointTask_lbl_Click_1(object sender, EventArgs e)
        {
            AppointForm appointForm = new AppointForm();
            appointForm.Getlogin(login);
            appointForm.Show();

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

        private void show_group_button_Click(object sender, EventArgs e)
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


            PersonGroups_list.Items.Clear();
            while (reader.Read())
            {
                PersonGroups_list.Items.Add((string)reader[0]);

            }
        }

       
    }
}