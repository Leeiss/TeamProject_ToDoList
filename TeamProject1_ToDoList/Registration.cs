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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btn_registration_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы успешно зарегестрированы! Можете войти в систему");
            Close();
        }
    }
}
