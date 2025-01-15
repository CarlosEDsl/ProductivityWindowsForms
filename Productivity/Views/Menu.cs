using Productivity.Controllers;
using Productivity.Models;
using System;
using System.Windows.Forms;

namespace Productivity
{
    public partial class Menu : Form
    {
        UserController userController;
        public Menu()
        {
            InitializeComponent();
            userController = UserController.Instance;
        }

        private void taskOption_Click(object sender, EventArgs e)
        {
            var taskPage = new Tarefas();
            taskPage.Show();
        }

        private void Estatísticas_Click(object sender, EventArgs e)
        {
            var estatisticsPage = new Estatísticas();
            estatisticsPage.Show();
        }

        private void pomodoroOption_Click(object sender, EventArgs e)
        {
            var pomodoro = new Pomodoro();
            pomodoro.Show();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Menu_Load(object sender, EventArgs e)
        {
            User user = await userController.GetLoggedUser();
            name.Text = user.Name;
        }
    }
}
