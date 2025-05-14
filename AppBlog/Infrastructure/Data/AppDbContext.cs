
using AppBlog.Domain.Entities;
using SQLite;

namespace AppBlog.Infrastructure.Data;

public class AppDbContext
{
    private readonly SQLiteAsyncConnection _db;

    public AppDbContext(string dbPath)
    {
        _db = new SQLiteAsyncConnection(dbPath);
        _db.CreateTableAsync<Post>().Wait();
        _db.CreateTableAsync<User>().Wait();
    }

    public Task<List<Post>> GetPostsAsync() => _db.Table<Post>().ToListAsync();
    public Task<List<User>> GetUsersAsync() => _db.Table<User>().ToListAsync();
    public Task InsertPostsAsync(List<Post> posts) => _db.InsertAllAsync(posts, true);
    public Task InsertUsersAsync(List<User> users) => _db.InsertAllAsync(users, true);
}
