
using AppBlog.Domain.Entities;

namespace AppBlog.Domain.Interfaces;

public interface IPostRepository
{
    Task<List<Post>> GetAllPostsAsync();
}
