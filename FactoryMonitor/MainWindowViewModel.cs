using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FactoryMonitor.Client.Servies.Navigation;
using FactoryMonitor.Client.Views;
using FactoryMonitor.UserControls.Controls;
using System.Collections.ObjectModel;

namespace FactoryMonitor.Client
{
    public partial class MainWindowViewModel : ObservableObject
    {
        public ObservableCollection<SideMenuItem> Items { get; set; } = [];
        private readonly INavigation navigator;

        [ObservableProperty]
        private SideMenuItem selectedItem;

        public MainWindowViewModel(INavigation navigator)
        {
            Items.Add(new SideMenuItem() { Content = "Dashboard123123123123123123", Icon = "Icons", NavigationKey = "DashboardPage" });
            Items.Add(new SideMenuItem() { Content = "Dashboard", Icon = "\uE691", NavigationKey = "DashboardPage" });
            Items.Add(new SideMenuItem() { Content = "Dashboard", Icon = "Icons", NavigationKey = "DashboardPage" });
            Items.Add(new SideMenuItem() { Content = "Dashboard", Icon = "Icons", NavigationKey = "DashboardPage" });
            Items.Add(new SideMenuItem() { Content = "Dashboard", Icon = "Icons", NavigationKey = "DashboardPage" });
            Items.Add(new SideMenuItem() { Content = "Dashboard", Icon = "Icons", NavigationKey = "DashboardPage" });
            this.navigator = navigator;
        }

        [RelayCommand]
        private void Navigate(SideMenuItem item)
        {
            if (item == null)
                return;
            var navigationKey = item.NavigationKey;

            switch (navigationKey)
            {
                case "DashboardPage":
                    navigator.NavigateTo<HomeView>();
                    break;
                default:
                    break;
            }
        }

    }
}
