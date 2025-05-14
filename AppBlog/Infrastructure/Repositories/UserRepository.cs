
using AppBlog.Domain.Entities;
using AppBlog.Domain.Interfaces;
using AppBlog.Infrastructure.Data;
using AppBlog.Infrastructure.Services;

namespace AppBlog.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApiService _api;
    private readonly AppDbContext _db;

    public UserRepository(ApiService api, AppDbContext db)
    {
        _api = api;
        _db = db;
    }

    public async Task<List<User>> GetAllUsersAsync()
    {
        try
        {
            var users = await _api.GetUsersAsync();
            await _db.InsertUsersAsync(users);
            return users;
        }
        catch
        {
            return await _db.GetUsersAsync();
        }
    }
}
