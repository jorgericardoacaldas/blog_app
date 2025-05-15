using System.Net.Http.Json;
using AppBlog.Domain.Entities;

namespace AppBlog.Infrastructure.Services;

public class ApiService
{
    private readonly HttpClient _client;

    public ApiService(HttpClient client)
    {
        _client = client;
        _client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
    }

    public async Task<List<User>> GetUsersAsync()
    {
        var response = await _client.GetAsync("/users");

        if (!response.IsSuccessStatusCode)
            throw new Exception("Erro ao buscar usuários");

        var users = await response.Content.ReadFromJsonAsync<List<User>>();
        return users ?? new List<User>();
    }

    public async Task<List<Post>> GetPostsAsync()
    {
        var response = await _client.GetAsync("/posts");

        if (!response.IsSuccessStatusCode)
            throw new Exception("Erro ao buscar posts");

        var posts = await response.Content.ReadFromJsonAsync<List<Post>>();
        return posts ?? new List<Post>();
    }
}
