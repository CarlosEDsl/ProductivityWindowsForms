﻿using Productivity.Cache;
using Productivity.Controllers;
using Productivity.Models;
using System;
using System.Windows.Forms;

namespace Productivity.Views
{
    public partial class TaskCreation : Form
    {
        private TaskController taskController;
        private Tarefas taskListForm;

        public TaskCreation(Tarefas taskListForm)
        {
            InitializeComponent();
            taskController = TaskController.GetInstance();
            this.taskListForm = taskListForm;
        }

        private async void create_Click(object sender, EventArgs e)
        {
            string title = titleBox.Text;
            string description = descriptionBox.Text;
            DateTime term = termPicker.Value;
            string termISO = term.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");

            TaskModel task = new TaskModel(0, TokenCache.GetUserId(), title, description, "", termISO);

            task = await taskController.CreateTask(task);

            if (task != null)
            {
                taskListForm.AddTaskToList(task);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao criar a tarefa.");
            }

        }

        private void termPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}