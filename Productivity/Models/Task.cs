using Newtonsoft.Json;
using System;
using System.Globalization;

namespace Productivity.Models
{
    internal class TaskModel
    {
        private int id;
        private int userId;
        private string name;
        private string description;
        private string finished;
        private string term;

        public TaskModel() { }

        public TaskModel(int id, int userId, string name, string description, string finished, string term)
        {
            this.id = id;
            this.userId = userId;
            this.name = name;
            this.description = description;
            this.finished = finished;
            this.term = term;
        }

        [JsonProperty("id")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty("user_id")]
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        [JsonProperty("name")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [JsonProperty("description")]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        [JsonProperty("finishDate")]
        public string Finished
        {
            get { return finished; }
            set { finished = value; }
        }

        [JsonProperty("term")]
        public string Term
        {
            get { return term; }
            set { term = value; }
        }

        public string getFormattedTerm()
        {
            DateTime dateTime = DateTime.ParseExact(term, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            return dateTime.ToString("dd/MM/yyyy");

        }

        public string getFormattedFinish()
        {
            DateTime dateTime = DateTime.ParseExact(finished, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            return dateTime.ToString("dd/MM/yyyy");
        }
    }
}
