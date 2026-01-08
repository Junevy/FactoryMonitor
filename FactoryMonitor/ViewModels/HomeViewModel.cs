using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FactoryMonitor.UserControls.Controls.ItemsControl;
using System.Collections.ObjectModel;

namespace FactoryMonitor.Client.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {

        public ObservableCollection<SideMenuItem> Items { get; set; } = [];

        public HomeViewModel()
        {
            Items.Add(new SideMenuItem() { Content = "Home", Icon = "\ue65d", NavigationKey = "HomePage", IsSelected = true });
            Items.Add(new SideMenuItem() { Content = "Trend", Icon = "\ue87b", NavigationKey = "TrendPage" });
            Items.Add(new SideMenuItem() { Content = "Settings", Icon = "\ue66b", NavigationKey = "SettingsPage" });
            Items.Add(new SideMenuItem() { Content = "User", Icon = "\ue7b2", NavigationKey = "UserPage" });
        }

        [RelayCommand]
        private void CloseTab(SideMenuItem item)
        {

        }

        [RelayCommand]
        private void Navigate(SideMenuItem item)
        {

        }
    }
}
