using Productivity.Cache;
using Productivity.Controllers;
using Productivity.Models;
using Productivity.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productivity
{
    public partial class Tarefas : Form
    {
        private TaskController taskController;
        private List<TaskModel> tasks;

        private static Tarefas instance;

        public static Tarefas Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new Tarefas();
                }
                return instance;
            }
        }

        public Tarefas()
        {
            InitializeComponent();
            tasks = new List<TaskModel>();
            taskController = TaskController.GetInstance();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaskCreation taskCreation = new TaskCreation(this);
            taskCreation.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        internal async void AddTaskToList(TaskModel task)
        {
            tasks.Add(task);

            this.addElementInFlow(task);

        }

        private async void Tarefas_Load(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(TokenCache.GetUserId());

            List<TaskModel> tasksFromDB = await this.taskController.GetAllTasksFromUser(userId);

            if (tasksFromDB != null && tasksFromDB.Count > 0)
            {
                flowPanel.Controls.Clear();

                foreach (var task in tasksFromDB)
                {
                    this.tasks.Add(task);
                    this.addElementInFlow(task);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma tarefa encontrada.");
            }
        }


        private async void addElementInFlow(TaskModel task)
        {
            int flowPanelWidth = 520;
            Panel taskPanel = new Panel
            {
                Width = flowPanelWidth,
                Height = 80,
                Padding = new Padding(5),
                Margin = new Padding(5),
                BorderStyle = BorderStyle.FixedSingle
            };

            Label taskLabel = new Label
            {
                Text = task.Finished == null ?
                    $"{task.Name} - {task.getFormattedTerm()}" :
                    $"{task.Name} - Finalizada em {task.Finished}",
                AutoSize = false,
                Location = new Point(10, 10),
                Size = new Size(taskPanel.ClientSize.Width - 200, 20),
                TextAlign = ContentAlignment.MiddleLeft
            };
            taskPanel.Controls.Add(taskLabel);

            if (task.Finished == null)
            {
                Button finishButton = await createFinishButton(task.Id, taskPanel);
                finishButton.Left = taskPanel.Width - finishButton.Width - 100;
                taskPanel.Controls.Add(finishButton);
            }

            Button deleteButton = createDeleteButton(task.Id, taskPanel);
            deleteButton.Left = taskPanel.Width - deleteButton.Width - 10;
            taskPanel.Controls.Add(deleteButton);

            Label taskDescription = new Label
            {
                Text = task.Description,
                AutoSize = false,
                Location = new Point(10, 40),
                Size = new Size(taskPanel.ClientSize.Width - 20, 30),
                TextAlign = ContentAlignment.MiddleLeft
            };
            taskPanel.Controls.Add(taskDescription);

            flowPanel.Controls.Add(taskPanel);
            this.setTotalTasks();
        }


        private Button createDeleteButton(int taskId, Panel taskPanel)
        {
            Button taskButton = new Button
            {
                Text = "Deletar",
                Tag = taskId,
                Width = 80,
                Height = 25,
                Top = (taskPanel.Height - 25) / 2
            };

            taskButton.Click += (sender, e) =>
            {
                Button clickedButton = (Button)sender;
                int taskIdToDelete = (int)clickedButton.Tag;
                MessageBox.Show($"Deletando tarefa com ID: {taskIdToDelete}");
                taskPanel.Hide();

                TaskModel taskToRemove = this.tasks.Find(task => task.Id == taskId);
                this.tasks.Remove(taskToRemove);

                this.taskController.DeleteTask(taskIdToDelete);
                setTotalTasks();
            };

            return taskButton;
        }

        private async Task<Button> createFinishButton(int taskId, Panel taskPanel)
        {
            Button taskButton = new Button
            {
                Text = "Finalizar",
                Tag = taskId,
                Width = 80,
                Height = 25,
                Top = (taskPanel.Height - 25) / 2
            };

            taskButton.Click += async (sender, e) =>
            {
                Button clickedButton = (Button)sender;
                int taskToFinish = (int)clickedButton.Tag;

                MessageBox.Show($"Finalizando tarefa com ID: {taskToFinish}");

                TaskModel taskFinished = await this.taskController.GetTaskById(taskToFinish);
                if (taskFinished != null)
                {
                    taskFinished.Finished = new DateTime().ToString("yyyy-MM-ddTHH:mm:ss");

                    this.taskController.FinishTask(taskFinished);

                    Label taskLabel = taskPanel.Controls.OfType<Label>().FirstOrDefault();
                    if (taskLabel != null)
                    {
                        taskLabel.Text = $"{taskFinished.Name} - Finalizada em {taskFinished.Finished}";
                        clickedButton.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Tarefa não encontrada.");
                }
            };

            return taskButton;
        }

        private void setTotalTasks()
        {
            int totalTasks = this.tasks.Count;
            total.Text = $"Total de {totalTasks} Tasks";
        }

    }
}
