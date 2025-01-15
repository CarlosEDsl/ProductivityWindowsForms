using Newtonsoft.Json;

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

        [JsonProperty("email")]
        public string Email { get { return email; } }
        [JsonProperty("password")]
        public string Password { get { return password; } }

    }
}
