using AppBlog;
using Microsoft.Extensions.DependencyInjection;
using AppBlog.Cases.UseCases;
using AppBlog.Domain.Interfaces;
using AppBlog.Infrastructure.Data;
using AppBlog.Infrastructure.Repositories;
using AppBlog.Infrastructure.Services;
using AppBlog.Presentation.ViewModels;
using AppBlog.Presentation.Views;

namespace AppBlog;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "app.db");

        builder.Services.AddSingleton(new AppDbContext(dbPath));
        builder.Services.AddSingleton<ApiService>();
        builder.Services.AddSingleton<IUserRepository, UserRepository>();
        builder.Services.AddSingleton<IPostRepository, PostRepository>();
        builder.Services.AddSingleton<GetPostsUseCase>();
        builder.Services.AddSingleton<FeedViewModel>();
        builder.Services.AddSingleton<FeedPage>();
        builder.Services.AddHttpClient<ApiService>(client =>
{
    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
});


        return builder.Build();
    }
}
