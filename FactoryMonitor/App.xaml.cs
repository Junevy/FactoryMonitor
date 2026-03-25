using Communication.ModBus.Common;
using Communication.ModBus.ModBusRTU;
using Communication.ModBus.Utils;
using FactoryMonitor.Client.Common.Adapter;
using FactoryMonitor.Client.ViewModels;
using FactoryMonitor.Client.Views;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using SimpleNavigation.Interface;
using SimpleNavigation.Services;
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

            InitialLogger();

            Provider = InitializeContainer()!;
            InitializeNavigation();

            MainWindow = Current.Provider.GetRequiredService<MainWindow>();
            MainWindow.Show();
        }

        private void InitialLogger()
        {
            Log.Logger = new LoggerConfiguration()
                .Destructure.ByTransforming<byte[]>(b => b.ToHex())
                .Enrich.WithThreadId()
                .MinimumLevel.Debug()
                .WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day,
                    outputTemplate:
                    "[{Timestamp:HH:mm:ss.fff}] [{ThreadId}] [{Level:u3}] {Message} {NewLine}{Exception}")
                .CreateLogger();
        }

        private void InitializeNavigation()
        {
            var navigationService = Provider.GetRequiredService<INavigationService>();

            navigationService.RegisterRoute<HomeView>("HomeView", Provider.GetRequiredService<HomeView>, new SimpleNavigation.Common.NavigationOptions() { AllowMulti = SimpleNavigation.Common.NavigationOptions.PageMode.Singleton });
            navigationService.RegisterRoute<HomePage>(typeof(HomePage).FullName!, Provider.GetRequiredService<HomePage>);

        }

        private IServiceProvider? InitializeContainer()
        {
            var container = new ServiceCollection();

            container.AddSingleton<ISerilog, SerilogAdapter>();
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
