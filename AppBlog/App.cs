using Microsoft.Maui.Controls;
using AppBlog.Presentation.Views;

namespace AppBlog
{
    public partial class App : Microsoft.Maui.Controls.Application
    {
        public App()
        {
            MainPage = new FeedPage();
        }
    }
}