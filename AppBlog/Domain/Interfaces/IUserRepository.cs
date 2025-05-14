
using AppBlog.Domain.Entities;

namespace AppBlog.Domain.Interfaces;

public interface IUserRepository
{
    Task<List<User>> GetAllUsersAsync();
}
