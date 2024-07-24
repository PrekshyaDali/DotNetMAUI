using MauiApp1.Models;

using MauiApp1.Views;

namespace MauiApp1
{
    public partial class App : Application
    {

        //public static IServiceProvider? Services { get; private set; }
        public static PersonRepository PersonRepo { get; private set; }

        public App(PersonRepository repo)
        {
            InitializeComponent();

            //var services = new ServiceCollection();
            //ConfigureServices(services);

            //Services = services.BuildServiceProvider();

            PersonRepo = repo;

            MainPage = new AppShell();
        }

        //private void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddSingleton<LocalDbServices>();
        //    services.AddTransient<DatabaseDemoPage>();
        //}
    }
}
