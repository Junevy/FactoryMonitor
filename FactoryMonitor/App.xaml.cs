using Communication.ModBus.ModBusRTU;
using FactoryMonitor.Client.ViewModels;
using FactoryMonitor.Client.Views;
using Microsoft.Extensions.DependencyInjection;
using SimpleNavigation;
using System.Windows;

namespace FactoryMonitor.Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static new App Current => (App)Application.Current;
        public IServiceProvider Provider { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Provider = InitializeContainer();

            InitializeNavigation();

            MainWindow = Current.Provider.GetRequiredService<MainWindow>();
            MainWindow.Show();
        }

        private void InitializeNavigation()
        {
            var navigationService = Provider.GetRequiredService<INavigationService>();

            navigationService.RegisterRoute<HomeView>("HomeView", Provider.GetRequiredService<HomeView>);
            navigationService.RegisterRoute<HomePage>("HomePage", Provider.GetRequiredService<HomePage>);

        }

        private IServiceProvider? InitializeContainer()
        {
            var container = new ServiceCollection();

            container.AddSingleton<INavigationService, NavigationService>();
            container.AddSingleton<MainWindow>();
            container.AddSingleton<MainWindowViewModel>();
            container.AddSingleton<HomeView>();
            container.AddSingleton<HomeViewModel>();

            container.AddTransient<HomePage>();
            container.AddTransient<HomePageViewModel>();

            container.AddSingleton<ModBusRTUMaster>();
            container.AddTransient<ModBusRTUConfig>();

            return container.BuildServiceProvider();
        }

        public T? LoadResource<T>(string? styleName = null) where T : class
        {
            var result = Application.Current.Resources[styleName] as T;
            if (result == null)
            {
                throw new Exception($"Resource '{styleName}' not found or not of type {typeof(T).FullName}");
            }
            return result;
        }
    }
}
