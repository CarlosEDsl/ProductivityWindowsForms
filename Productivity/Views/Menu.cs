using Productivity.Controllers;
using Productivity.Models;
using Productivity.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using Productivity.Properties;

namespace Productivity
{
    public partial class Menu : Form
    {
        UserController userController;

        private List<Image> images;
        private int currentImageIndex;
        public Menu()
        {
            InitializeComponent();
            userController = UserController.Instance;

            images = new List<Image>
            {
                Properties.Resources.ImagemPerfil1,
                Properties.Resources.ImagemPerfil2,
                Properties.Resources.ImagemPerfil3,
                Properties.Resources.ImagemPerfil4,
                Properties.Resources.ImagemPerfil5
            };
            int currentImageIndex = 0;

            profilePic.Image = Resources.ImagemPerfil1;
        }

        private void taskOption_Click(object sender, EventArgs e)
        {
            var taskPage = new Tarefas();
            taskPage.ShowDialog();
        }

        private void Estatísticas_Click(object sender, EventArgs e)
        {
            var estatisticsPage = new Estatísticas();
            estatisticsPage.ShowDialog();
        }

        private void pomodoroOption_Click(object sender, EventArgs e)
        {
            var pomodoro = new Pomodoro();
            pomodoro.ShowDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {
            currentImageIndex = (currentImageIndex + 1) % images.Count;
            profilePic.Image = images[currentImageIndex];
        }

        private void profilePic_Click(object sender, EventArgs e)
        {

        }
    }
}