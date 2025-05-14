
using AppBlog.Domain.Entities;
using System.Text.Json;

namespace AppBlog.Infrastructure.Services;

public class ApiService
{
    private readonly HttpClient _client = new();

    public async Task<List<User>> GetUsersAsync() =>
        JsonSerializer.Deserialize<List<User>>(await _client.GetStringAsync("https://jsonplaceholder.typicode.com/users"));

    public async Task<List<Post>> GetPostsAsync() =>
        JsonSerializer.Deserialize<List<Post>>(await _client.GetStringAsync("https://jsonplaceholder.typicode.com/posts"));
}
