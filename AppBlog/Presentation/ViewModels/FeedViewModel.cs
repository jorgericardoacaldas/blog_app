
using AppBlog.Application.UseCases;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace AppBlog.Presentation.ViewModels;

public class PostViewModelItem(string title, string body, string username)
{
    public string Title { get; } = title;
    public string Body { get; } = body;
    public string Username { get; } = username;
}

public class FeedViewModel : INotifyPropertyChanged
{
    private readonly GetPostsUseCase _getPostsUseCase;
    public ObservableCollection<PostViewModelItem> Posts { get; } = new();

    public FeedViewModel(GetPostsUseCase useCase)
    {
        _getPostsUseCase = useCase;
        LoadPosts();
    }

    private async void LoadPosts()
    {
        var result = await _getPostsUseCase.ExecuteAsync();
        Posts.Clear();
        foreach (var (post, username) in result)
        {
            Posts.Add(new PostViewModelItem(post.Title, post.Body, username));
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
}
