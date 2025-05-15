
namespace AppBlog;

using AppBlog.Presentation.Views;


public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
