using Newtonsoft.Json;
using Productivity.Cache;
using Productivity.Models;
using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Productivity.Controllers
{
    internal class UserController
    {
        private static UserController _instance;
        private static readonly object _lock = new object();
        private HttpClient client;
        private string APIUrl = "http://localhost:8080/user";
        private string APIloginUrl = "http://localhost:8080/login";

        public UserController()
        {
            client = new HttpClient();
        }

        public static UserController Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new UserController();
                        }
                    }
                }
                return _instance;
            }
        }

        public async Task<bool> Login(string email, string password)
        {
            try
            {
                LoginModel login = new LoginModel(email, password);
                string jsonLogin = JsonConvert.SerializeObject(login);
                var loginRequestBody = new StringContent(jsonLogin, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync($"{APIloginUrl}", loginRequestBody);

                response.EnsureSuccessStatusCode();

                if (response.Headers.Contains("Authorization"))
                {
                    string token = response.Headers.GetValues("Authorization").FirstOrDefault();
                    string userId = response.Headers.GetValues("UserId").FirstOrDefault();

                    TokenCache.SetToken(token);
                    TokenCache.SetUserId(Convert.ToInt32(userId));
                }

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public async Task<User> Register(User user)
        {
            try
            {
                string jsonRegister = JsonConvert.SerializeObject(user);
                var registerRequestBody = new StringContent(jsonRegister, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync($"{APIUrl}", registerRequestBody);

                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();
                User registeredUser = JsonConvert.DeserializeObject<User>(responseJson);

                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

        public async Task<MonthStatistic> GetMonthStatistic(int userId, int month, int year)
        {
            try
            {
                var requestUri = new Uri($"{APIUrl}/statistic/{userId}?month={month}&year={year}");
                string token = TokenCache.GetToken();

                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = requestUri,
                    Headers =
                    {
                        { "Authorization", $"Bearer {token}" }
                    }
                };

                HttpResponseMessage response = await client.SendAsync(request);
                string responseContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Response Content: " + responseContent);

                response.EnsureSuccessStatusCode();

                MonthStatistic monthStatistic = JsonConvert.DeserializeObject<MonthStatistic>(responseContent);
                Console.WriteLine("Month Statistic: " + monthStatistic);


                return monthStatistic;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                return null;
            }
        }

        public async Task<User> GetLoggedUser()
        {
            try
            {
                string token = TokenCache.GetToken();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                HttpResponseMessage response = await client.GetAsync($"{APIUrl}/{TokenCache.GetUserId()}");
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();
                User user = JsonConvert.DeserializeObject<User>(responseJson);

                return user;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async void AddHoursToMonth(int userId, int monthh, int yearr, double hourss)
        {
            try
            {
                var requestUri = new Uri($"{APIUrl}/{userId}");
                string token = TokenCache.GetToken();

                var data = new
                {
                    month = monthh,
                    year = yearr,
                    hours = hourss
                };

                string jsonContent = JsonConvert.SerializeObject(data);

                var request = new HttpRequestMessage
                {
                    Method = new HttpMethod("PATCH"),
                    RequestUri = requestUri,
                    Headers =
                {
                    { "Authorization", $"Bearer {token}" }
                },
                    Content = new StringContent(jsonContent, Encoding.UTF8, "application/json")
                };

                HttpResponseMessage response = await client.SendAsync(request);
                string responseContent = await response.Content.ReadAsStringAsync();

                response.EnsureSuccessStatusCode();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
    }
}
