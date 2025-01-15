using Newtonsoft.Json;

namespace Productivity.Models
{
    internal class MonthStatistic
    {
        private int id;
        private User user;
        private string month;
        private int year;
        private double avgConclusions;
        private double totalHours;

        public MonthStatistic() { }

        public MonthStatistic(int id, User user, string month, int year, double avgConclusions, double totalHours)
        {
            this.id = id;
            this.user = user;
            this.month = month;
            this.year = year;
            this.avgConclusions = avgConclusions;
            this.totalHours = totalHours;
        }

        [JsonProperty("id")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty("user")]
        public User User
        {
            get { return user; }
            set { user = value; }
        }

        [JsonProperty("month")]
        public string Month
        {
            get { return month; }
            set { month = value; }
        }

        public int GetMonthNumber()
        {
            switch (this.Month)
            {
                case "JAN": return 1;
                case "FEB": return 2;
                case "MAR": return 3;
                case "APR": return 4;
                case "MAY": return 5;
                case "JUN": return 6;
                case "JUL": return 7;
                case "AUG": return 8;
                case "SEP": return 9;
                case "OCT": return 10;
                case "NOV": return 11;
                case "DEC": return 12;
                default: return -1;
            }
        }

        [JsonProperty("year")]
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        [JsonProperty("avgConclusions")]
        public double AvgConclusions
        {
            get { return avgConclusions; }
            set { avgConclusions = value; }
        }

        [JsonProperty("totalHours")]
        public double TotalHours
        {
            get { return totalHours; }
            set { totalHours = value; }
        }
    }
}
