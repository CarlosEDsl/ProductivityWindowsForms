using Productivity.Cache;
using Productivity.Controllers;
using Productivity.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Productivity
{
    public partial class Estatísticas : Form
    {

        private UserController userController;
        private List<MonthStatistic> monthStatisticList;
        private TaskController taskController;
        public Estatísticas()
        {
            InitializeComponent();
            this.userController = new UserController();
            this.monthStatisticList = new List<MonthStatistic>();
            this.taskController = TaskController.GetInstance();
        }

        private async void ShowStatisticsInScreen()
        {
            DateTime today = DateTime.Now;

            for (int i = 0; i < 12; i++)
            {
                DateTime previousMonth = today.AddMonths(-i);

                int month = previousMonth.Month;
                int year = previousMonth.Year;

                MonthStatistic statistic = await this.userController.GetMonthStatistic(TokenCache.GetUserId(), month, year);
                if (statistic != null)
                    monthStatisticList.Add(statistic);
            }

            this.MakeHoursGraph();
            this.MakeTasksGraph();
            this.InsertTotalTasks();
            this.InsertPercentualFinished();
        }

        private void MakeHoursGraph()
        {
            DateTime today = DateTime.Now;
            DateTime minDate = today.AddMonths(-12);

            hourPerMonth.ChartAreas.Add("HoursGraph");

            hourPerMonth.ChartAreas["HoursGraph"].AxisX.LabelStyle.Format = "MMM yyyy";
            hourPerMonth.ChartAreas["HoursGraph"].AxisX.Minimum = minDate.ToOADate();
            hourPerMonth.ChartAreas["HoursGraph"].AxisX.Maximum = today.ToOADate();
            hourPerMonth.ChartAreas["HoursGraph"].AxisX.IntervalType = DateTimeIntervalType.Months;

            hourPerMonth.ChartAreas["HoursGraph"].AxisY.Title = "Horas";

            Series series = new Series
            {
                Name = "Horas por Mês",
                ChartType = SeriesChartType.Column
            };

            for (int i = 1; i <= 12; i++)
            {
                DateTime date = minDate.AddMonths(i);
                double hours = 0;

                MonthStatistic statistic = monthStatisticList.Find(month => month.GetMonthNumber() == date.Month && month.Year == date.Year);
                if (statistic != null)
                {
                    Console.WriteLine(statistic);
                    hours = statistic.TotalHours;
                }

                series.Points.AddXY(date, hours);
            }
            series.ChartType = SeriesChartType.Column;

            hourPerMonth.Series.Add(series);

        }

        private async void MakeTasksGraph()
        {
            DateTime today = DateTime.Now;
            DateTime minDate = today.AddMonths(-12);

            tasksPerMonth.ChartAreas.Add("TasksGraph");

            tasksPerMonth.ChartAreas["TasksGraph"].AxisX.LabelStyle.Format = "MMM yyyy";
            tasksPerMonth.ChartAreas["TasksGraph"].AxisX.Minimum = minDate.ToOADate();
            tasksPerMonth.ChartAreas["TasksGraph"].AxisX.Maximum = today.ToOADate();
            tasksPerMonth.ChartAreas["TasksGraph"].AxisX.IntervalType = DateTimeIntervalType.Months;

            tasksPerMonth.ChartAreas["TasksGraph"].AxisY.Title = "Tarefas";

            Series series = new Series
            {
                Name = "Tarefas por mês",
                ChartType = SeriesChartType.Column
            };

            List<TaskModel> tasks = await taskController.GetAllTasksFromUser(TokenCache.GetUserId());

            for (int i = 1; i <= 12; i++)
            {
                DateTime date = minDate.AddMonths(i);
                int totalTasks = 0;

                foreach (TaskModel task in tasks)
                {
                    if (DateTime.TryParse(task.Term, out DateTime taskDate))
                    {
                        if (taskDate.Month == date.Month && taskDate.Year == date.Year && task.Finished != null)
                        {
                            totalTasks++;
                        }
                    }
                }


                series.Points.AddXY(date, totalTasks);
            }
            series.ChartType = SeriesChartType.Column;

            tasksPerMonth.Series.Add(series);
        }

        private async void InsertTotalTasks()
        {
            List<TaskModel> tasks = await taskController.GetAllTasksFromUser(TokenCache.GetUserId());
            totalTasks.Text = tasks.Count.ToString();
        }

        private void InsertPercentualFinished()
        {
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;

            double percentual = 0;

            MonthStatistic statistic = monthStatisticList.Find(s => s.GetMonthNumber() == month && s.Year == year);
            if (statistic != null)
            {
                percentual = statistic.AvgConclusions * 100;
            }
            percentualFinished.Text = $"{percentual:F2}%";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Estatísticas_Load(object sender, EventArgs e)
        {

            ShowStatisticsInScreen();
        }

        private void hourPerMonth_Click(object sender, EventArgs e)
        {

        }
    }
}
