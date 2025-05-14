
using AppBlog.Domain.Entities;
using AppBlog.Domain.Interfaces;
using AppBlog.Infrastructure.Data;
using AppBlog.Infrastructure.Services;

namespace AppBlog.Infrastructure.Repositories;

public class PostRepository : IPostRepository
{
    private readonly ApiService _api;
    private readonly AppDbContext _db;

    public PostRepository(ApiService api, AppDbContext db)
    {
        _api = api;
        _db = db;
    }

    public async Task<List<Post>> GetAllPostsAsync()
    {
        try
        {
            var posts = await _api.GetPostsAsync();
            await _db.InsertPostsAsync(posts);
            return posts;
        }
        catch
        {
            return await _db.GetPostsAsync();
        }
    }
}
