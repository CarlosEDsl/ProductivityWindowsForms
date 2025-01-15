using Newtonsoft.Json;

namespace Productivity.Models
{
    internal class User
    {
        private string email;
        private string password;
        private string name;
        private string cell;

        private int id;

        [JsonProperty("email")]
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        [JsonProperty("password")]
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        [JsonProperty("name")]
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        [JsonProperty("cell")]
        public string Cell
        {
            get { return this.cell; }
            set { this.cell = value; }
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public User(string email, string password, string name, string cell)
        {
            this.email = email;
            this.password = password;
            this.name = name;
            this.cell = cell;
        }
    }
}
