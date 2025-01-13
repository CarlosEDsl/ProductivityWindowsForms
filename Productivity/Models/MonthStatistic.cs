using System;

namespace Productivity.Models
{
    internal class MonthStatistic
    {
        private int id;
        private int userId;
        private int month;
        private int year;
        private double avgConclusions;
        private double totalHours;

        public MonthStatistic() { }

        public MonthStatistic(int id, int userId, int month, int year, double avgConclusions, double totalHours)
        {
            this.id = id;
            this.userId = userId;
            this.month = month;
            this.year = year;
            this.avgConclusions = avgConclusions;
            this.totalHours = totalHours;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double AvgConclusions
        {
            get { return avgConclusions; }
            set { avgConclusions = value; }
        }

        public double TotalHours
        {
            get { return totalHours; }
            set { totalHours = value; }
        }
    }
}
