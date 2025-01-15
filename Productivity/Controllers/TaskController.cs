using Newtonsoft.Json;
using Productivity.Cache;
using Productivity.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Productivity.Controllers
{
    internal class TaskController
    {
        private readonly HttpClient client;
        private readonly string APIUrl = "http://localhost:8080/task";
        private static TaskController _instance;

        public TaskController()
        {
            client = new HttpClient();
        }

        public static TaskController GetInstance()
        {
            if (_instance == null)
            {
                _instance = new TaskController();
            }
            return _instance;
        }


        public async Task<TaskModel> CreateTask(TaskModel task)
        {
            try
            {
                string jsonTask = JsonConvert.SerializeObject(task);
                var taskRequestBody = new StringContent(jsonTask, Encoding.UTF8, "application/json");

                string token = TokenCache.GetToken();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                HttpResponseMessage response = await client.PostAsync(APIUrl, taskRequestBody);

                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();
                TaskModel createdTask = JsonConvert.DeserializeObject<TaskModel>(responseJson);

                return createdTask;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar a tarefa: {ex.Message}");
                return null;
            }
        }

        public async void DeleteTask(int taskId)
        {
            try
            {
                string token = TokenCache.GetToken();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage response = await client.DeleteAsync($"{APIUrl}/{taskId}");

                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao deletar a tarefa: {ex.Message}");
            }

        }

        public async Task<bool> FinishTask(TaskModel task)
        {
            try
            {
                task.Finished = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");


                string jsonTask = JsonConvert.SerializeObject(task);
                var taskRequestBody = new StringContent(jsonTask, Encoding.UTF8, "application/json");


                string token = TokenCache.GetToken();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage response = await client.PutAsync($"{APIUrl}/{task.Id}", taskRequestBody);
                response.EnsureSuccessStatusCode();


                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public async Task<List<TaskModel>> GetAllTasksFromUser(int user_id)
        {
            try
            {
                string token = TokenCache.GetToken();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                HttpResponseMessage response = await client.GetAsync($"{APIUrl}/user/{user_id}");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();

                List<TaskModel> tasks = JsonConvert.DeserializeObject<List<TaskModel>>(responseJson);
                foreach (var task in tasks)
                {
                    task.UserId = user_id;
                }

                Console.WriteLine(tasks);
                return tasks;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<TaskModel> GetTaskById(int id)
        {
            try
            {
                string token = TokenCache.GetToken();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer ", token);

                HttpResponseMessage response = await client.GetAsync($"{APIUrl}/{id}");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();

                TaskModel task = JsonConvert.DeserializeObject<TaskModel>(responseJson);
                task.UserId = TokenCache.GetUserId();

                return task;
            }
            catch
            {
                return null;
            }
        }

    }
}
