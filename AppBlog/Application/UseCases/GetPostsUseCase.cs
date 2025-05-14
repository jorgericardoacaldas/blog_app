
using AppBlog.Domain.Entities;
using AppBlog.Domain.Interfaces;

namespace AppBlog.Application.UseCases;

public class GetPostsUseCase
{
    private readonly IPostRepository _postRepo;
    private readonly IUserRepository _userRepo;

    public GetPostsUseCase(IPostRepository postRepo, IUserRepository userRepo)
    {
        _postRepo = postRepo;
        _userRepo = userRepo;
    }

    public async Task<List<(Post post, string username)>> ExecuteAsync()
    {
        var posts = await _postRepo.GetAllPostsAsync();
        var users = await _userRepo.GetAllUsersAsync();
        return posts.Select(p => (p, users.FirstOrDefault(u => u.Id == p.UserId)?.Username ?? "Unknown")).ToList();
    }
}
