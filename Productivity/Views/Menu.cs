using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productivity
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
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
    }
}
