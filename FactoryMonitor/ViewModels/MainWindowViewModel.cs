using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FactoryMonitor.UserControls.Controls.Menu;
using SimpleNavigation;
using System.Collections.ObjectModel;
using System.Windows;

namespace FactoryMonitor.Client.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject, INavigationAware
    {
        public ObservableCollection<MenuItem> Items { get; set; } = [];
        private readonly INavigationService navigationService;

        //[ObservableProperty]
        //private MenuItem selectedItem;

        public MainWindowViewModel(INavigationService navigationService)
        {
            Items.Add(new MenuItem() { Title = "Home", Icon = "\ue65d", NavigationKey = "Home", IsSelected = true });
            Items.Add(new MenuItem() { Title = "Trend", Icon = "\ue87b", NavigationKey = "TrendPage" });
            Items.Add(new MenuItem() { Title = "Settings", Icon = "\ue66b", NavigationKey = "SettingsPage" });
            Items.Add(new MenuItem() { Title = "User", Icon = "\ue7b2", NavigationKey = "UserPage" });
            this.navigationService = navigationService;
        }

        [RelayCommand]
        private void Navigate(MenuItem item)
        {
            var key = item.NavigationKey;

            if (key == null) return;

            switch (key)
            {
                case "Home":
                    navigationService.Navigate("MainWindowRegion", "HomeView");
                    break;
                default:
                    break;
            }
        }

        [RelayCommand]
        private void CloseTab(MenuItem item)
        {

        }

        public void OnNavigating(NavigationParameter? parameters)
        {
            if (parameters != null)
            {
                // 处理导航参数
                // 例如：int id = parameters.Get<int>("id");
                var test = parameters.Get<string>("1");
                MessageBox.Show(test);
            }
        }

        public void OnNavigated(NavigationParameter? parameters)
        {
        }
    }
}
