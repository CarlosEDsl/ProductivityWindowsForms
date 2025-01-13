using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productivity.Models
{
    internal class User
    {
        private string email;
        private string password;
        private string name;
        private string phone;

        private string token;
        private int id;

        public User(string email, string password, string name, string phone) {
            this.email = email;
            this.password = password;
            this.name = name;
            this.phone = phone;
        }

        public string Token
        {
            get { return this.token; }
            set { this.token = value; }
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
    }
}
