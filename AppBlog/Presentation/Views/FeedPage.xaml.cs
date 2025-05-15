using AppBlog.Cases.UseCases;
using AppBlog.Infrastructure.Data;
using AppBlog.Infrastructure.Repositories;
using AppBlog.Infrastructure.Services;
using AppBlog.Presentation.ViewModels;

namespace AppBlog.Presentation.Views;

public partial class FeedPage : ContentPage
{
    public FeedPage(FeedViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
