using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Productivity.Models;

namespace Productivity.Controllers
{
    internal class TaskController
    {
        private readonly HttpClient client;
        private readonly string APIUrl = "https://api.example.com/tasks"; // Substitua pelo endpoint correto

        public TaskController()
        {
            client = new HttpClient();
        }

        public async Task<TaskModel> CreateTask(TaskModel task)
        {
            try
            {
                string jsonTask = JsonConvert.SerializeObject(task);
                var taskRequestBody = new StringContent(jsonTask, Encoding.UTF8, "application/json");

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
                task.Finished = DateTime.Now;

                string jsonTask = JsonConvert.SerializeObject(task);
                var taskRequestBody = new StringContent(jsonTask, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PutAsync($"{APIUrl}/{task.Id}", taskRequestBody);
                response.EnsureSuccessStatusCode();

                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }
    }
}
