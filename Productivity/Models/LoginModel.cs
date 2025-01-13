using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productivity.Models
{
    internal class LoginModel
    {
        private string email;
        private string password;

        public LoginModel(string email, string password)
        {
            this.email = email;
            this.password = password;
        }
    }
}
