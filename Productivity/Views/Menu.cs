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
        private static Menu instance;

        public static Menu Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new Menu();
                }
                return instance;
            }
        }

        private UserController userController;

        private List<Image> images;
        private int currentImageIndex;

        private Menu()
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

            profilePic.Image = Resources.ImagemPerfil1;

            FormClosed += (s, e) => instance = null;
        }

        private void taskOption_Click(object sender, EventArgs e)
        {
            var taskPage = Productivity.Tarefas.Instance;
            taskPage.ShowDialog();
        }

        private void Estatísticas_Click(object sender, EventArgs e)
        {
            var estatisticsPage = Productivity.Estatísticas.Instance;
            estatisticsPage.ShowDialog();
        }

        private void pomodoroOption_Click(object sender, EventArgs e)
        {
            var pomodoro = Productivity.Pomodoro.Instance;
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
