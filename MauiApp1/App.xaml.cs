using MauiApp1.Models;

using MauiApp1.Views;

namespace MauiApp1
{
    public partial class App : Application
    {
        public static PersonRepository PersonRepo { get; private set; }

        public static DependencyInjectionPage DependencyInjectionPage { get; private set; }

        public static UserService UserService { get; private set; }
        public static SettingsPage SettingsPage { get; private set; }
        public static ProfilePage ProfilePage { get; private set; }

        //public App(PersonRepository repo, DependencyInjectionPage _dependencyInjectionDemo)
        //{
        //    InitializeComponent();

        //    PersonRepo = repo;
        //    DependencyInjectionPage = _dependencyInjectionDemo;

        //    MainPage = new AppShell();
        //}

        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            // Resolve dependencies
            PersonRepo = serviceProvider.GetRequiredService<PersonRepository>();
            DependencyInjectionPage = serviceProvider.GetRequiredService<DependencyInjectionPage>();
            UserService = serviceProvider.GetRequiredService<UserService>();
            SettingsPage = serviceProvider.GetRequiredService<SettingsPage>();
            ProfilePage = serviceProvider.GetRequiredService<ProfilePage>();

            MainPage = new AppShell();
        }
    }
}
