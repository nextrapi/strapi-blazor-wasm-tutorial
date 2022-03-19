using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
namespace AppServices
{
    public class Helpers
    {
        public static async Task<T> HandleError<T>(HttpResponseMessage Request)
        {
            var result = await Request.Content.ReadFromJsonAsync<T>();
            if (Request.IsSuccessStatusCode && result != null)
            {
                return result;
            }
            else
            {
                throw new HttpRequestException(await Request.Content.ReadAsStringAsync());
            }
        }
    }
    public class AuthApi
    {
        private readonly HttpClient ApiClient;
        public AuthApi(IHttpClientFactory clientFactory)
        {
            ApiClient = clientFactory.CreateClient("Strapi");
        }
        public async Task<UserState> Login(LoginFormState data) =>
        await Helpers.HandleError<UserState>
        (await ApiClient.PostAsJsonAsync("auth/local", data));
        public async Task<UserState> Register(RegisterFormState data) =>
        await Helpers.HandleError<UserState>
        (await ApiClient.PostAsJsonAsync("auth/local/register", data));
    }
    public class TasksApi
    {
        private readonly HttpClient _ApiClient;
        public TasksApi(IHttpClientFactory clientFactory)
        {
            _ApiClient = clientFactory.CreateClient("Strapi");
        }
        private HttpClient ApiClient(string token)
        {
            _ApiClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            return _ApiClient;
        }

        public async Task<TaskList> FindAll(string token) =>
        await Helpers.HandleError<TaskList>
        (await ApiClient(token).GetAsync("tasks"));
        public async Task<TaskItem> Find(string token, int id) =>
        await Helpers.HandleError<TaskItem>
        (await ApiClient(token).GetAsync($"tasks/{id}"));
        public async Task<TaskItem> Update(string token, int id, TaskRequest data) =>
        await Helpers.HandleError<TaskItem>
        (await ApiClient(token).PutAsJsonAsync($"tasks/{id}", data));
        public async Task<TaskItem> Create(string token, TaskRequest data) =>
        await Helpers.HandleError<TaskItem>
        (await ApiClient(token).PostAsJsonAsync($"tasks", data));
        public async Task<TaskItem> Delete(string token, int id) =>
        await Helpers.HandleError<TaskItem>
        (await ApiClient(token).DeleteAsync($"tasks/{id}"));
    }


}