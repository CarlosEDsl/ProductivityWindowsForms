using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Productivity.Models;

namespace Productivity.Controllers
{
    internal class UserController
    {
        private HttpClient client;
        private string APIUrl = "teste"; 

        public UserController()
        {
            client = new HttpClient();
        }

        public async Task<User> Login(string email, string password)
        {
            try
            {
                LoginModel login = new LoginModel(email, password);
                string jsonLogin = JsonConvert.SerializeObject(login);
                var loginRequestBody = new StringContent(jsonLogin, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync($"{APIUrl}", loginRequestBody);

                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();
                User user = JsonConvert.DeserializeObject<User>(responseJson);

                return user;
            }
            catch (Exception ex) 
            {
                return null;
            }
        }

        public async Task<User> Register(User user)
        {
            try
            {
                string jsonRegister = JsonConvert.SerializeObject(user);
                var registerRequestBody = new StringContent(jsonRegister, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync($"{APIUrl}/register", registerRequestBody);

                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();
                User registeredUser = JsonConvert.DeserializeObject<User>(responseJson);

                return user;
            }
            catch (Exception ex) { 
                return null;
            }

        }

        public async Task<MonthStatistic> GetMonthStatistic(int userId, int monthr, int yearr)
        {
            try
            {
                var requestMonthBody = new
                {
                    month = monthr,
                    year = yearr
                };

                string jsonMonth = JsonConvert.SerializeObject(requestMonthBody);
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"{APIUrl}/{userId}"),
                    Content = new StringContent(jsonMonth, Encoding.UTF8, "application/json")
                };

                HttpResponseMessage response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                string responseContent = await response.Content.ReadAsStringAsync();
                MonthStatistic monthStatistic = JsonConvert.DeserializeObject<MonthStatistic>(responseContent);

                return monthStatistic;
            }
            catch (Exception ex) { 
                return null;
            }
        }
    }
}
