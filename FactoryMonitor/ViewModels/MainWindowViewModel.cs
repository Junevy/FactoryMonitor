using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FactoryMonitor.Client.Servies.Navigation;
using FactoryMonitor.Client.Views;
using FactoryMonitor.UserControls.Controls.Menu;
using System.Collections.ObjectModel;

namespace FactoryMonitor.Client.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        public ObservableCollection<MenuItem> Items { get; set; } = [];
        private readonly INavigation navigator;

        [ObservableProperty]
        private MenuItem selectedItem;

        public MainWindowViewModel(INavigation navigator)
        {
            Items.Add(new MenuItem() { Content = "Home", Icon = "\ue65d", NavigationKey = "HomePage", IsSelected = true });
            Items.Add(new MenuItem() { Content = "Trend", Icon = "\ue87b", NavigationKey = "TrendPage" });
            Items.Add(new MenuItem() { Content = "Settings", Icon = "\ue66b", NavigationKey = "SettingsPage" });
            Items.Add(new MenuItem() { Content = "User", Icon = "\ue7b2", NavigationKey = "UserPage" });
            this.navigator = navigator;
        }

        [RelayCommand]
        private void Navigate(MenuItem item)
        {
            if (item == null)
                return;
            var navigationKey = item.NavigationKey;

            switch (navigationKey)
            {
                case "HomePage":
                    navigator.NavigateTo<HomeView>();
                    break;
                default:
                    break;
            }
        }

        [RelayCommand]
        private void CloseTab(MenuItem item)
        {

        }

    }
}
