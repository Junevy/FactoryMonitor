using FactoryMonitor.Client.Servies.Navigation;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using System.Windows.Controls;

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

            InitializeContainer();
            MainWindow = Current.Provider.GetRequiredService<MainWindow>();
            MainWindow.Show();
        }

        private void InitializeContainer()
        {
            var container = new ServiceCollection();

            container.AddSingleton<Frame>((e) => new Frame() { NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden });
            container.AddSingleton<INavigation, Servies.Navigation.NavigationService>();
            container.AddSingleton<MainWindow>();
            container.AddSingleton<MainWindowViewModel>();

            Provider = container.BuildServiceProvider();
        }

        public T? LoadResource<T>(string? styleName = null) where T : class
        {
            var result =  Application.Current.Resources[styleName] as T;
            if (result == null)
            {
                throw new System.Exception($"Resource '{styleName}' not found or not of type {typeof(T).FullName}");
            }
            return result;
        }
    }
}
