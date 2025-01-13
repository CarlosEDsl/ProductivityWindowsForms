using System;

namespace Productivity.Models
{
    internal class TaskModel
    {
        private int id;
        private string userId;
        private string name;
        private string description;
        private DateTime created;
        private DateTime finished;
        private DateTime term;

        public TaskModel() { }

        public TaskModel(int id, string userId, string name, string description, DateTime created, DateTime finished, DateTime term)
        {
            this.id = id;
            this.userId = userId;
            this.name = name;
            this.description = description;
            this.created = created;
            this.finished = finished;
            this.term = term;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public DateTime Created
        {
            get { return created; }
            set { created = value; }
        }

        public DateTime Finished
        {
            get { return finished; }
            set { finished = value; }
        }

        public DateTime Term
        {
            get { return term; }
            set { term = value; }
        }
    }
}

