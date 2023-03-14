using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
