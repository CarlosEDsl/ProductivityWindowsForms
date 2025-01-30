using Productivity.Cache;
using Productivity.Controllers;
using System;
using System.Windows.Forms;

namespace Productivity
{
    public partial class Pomodoro : Form
    {
        private static Pomodoro instance;
        private UserController userController;
        private static bool runningTimer = false;
        private int workDuration = 25;
        private int breakDuration = 5;
        private int secondsRemaining;
        private double secondsToSave;
        private Timer pomodoroTimer;

        private Pomodoro()
        {
            InitializeComponent();
            pomodoroTimer = new Timer();
            pomodoroTimer.Interval = 1000;
            pomodoroTimer.Tick += TimerTick;
            userController = UserController.Instance;

            FormClosed += (s, e) => {
                instance = null;
                pomodoroTimer.Stop();
            };
        }

        public static Pomodoro Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new Pomodoro();
                }
                return instance;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.startPomodoro();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.StopTimer();
        }

        private void startPomodoro()
        {
            runningTimer = true;
            int timerSeconds = this.ConvertToSeconds();
            secondsRemaining = timerSeconds == 0 ? workDuration * 60 : timerSeconds;
            pomodoroTimer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (secondsRemaining > 0 && runningTimer)
            {
                secondsRemaining--;
                secondsToSave++;

                if (secondsToSave >= 3)
                {
                    DateTime date = DateTime.Now;
                    userController.AddHoursToMonth(TokenCache.GetUserId(), date.Month, date.Year, secondsToSave);
                    secondsToSave = 0;
                }

                TimeSpan remainingTime = TimeSpan.FromSeconds(secondsRemaining);
                timer.Text = $"{remainingTime.Minutes:D2}:{remainingTime.Seconds:D2}";

                if (secondsRemaining == 0)
                {
                    pomodoroTimer.Stop();
                    startBreak();
                }
            }
        }

        private void StopTimer()
        {
            runningTimer = false;
            pomodoroTimer.Stop();
        }

        private void startBreak()
        {
            secondsRemaining = breakDuration * 60;
            pomodoroTimer.Start();
        }

        private int ConvertToSeconds()
        {
            try
            {
                string[] timeParts = timer.Text.Split(':');
                int minutes = int.Parse(timeParts[0]);
                int seconds = int.Parse(timeParts[1]);
                return minutes * 60 + seconds;
            }
            catch
            {
                return 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.startBreak();
        }

        private void Pomodoro_Load(object sender, EventArgs e)
        {
        }
    }
}
