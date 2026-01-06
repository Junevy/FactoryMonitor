using FactoryMonitor.UserControls.Controls;
using System.Collections.ObjectModel;

namespace FactoryMonitor.Client
{
    public class MainWindowViewModel
    {
        public ObservableCollection<SideMenuItem> Items { get; set; } = [];

        public MainWindowViewModel()
        {

            Items.Add(new SideMenuItem() { Content = "Dashboard123123123123123123", Icon = "Icons", NavigationKey = "DashboardPage" });
            Items.Add(new SideMenuItem() { Content = "Dashboard", Icon = "Icons", NavigationKey = "DashboardPage" });
            Items.Add(new SideMenuItem() { Content = "Dashboard", Icon = "Icons", NavigationKey = "DashboardPage" });
            Items.Add(new SideMenuItem() { Content = "Dashboard", Icon = "Icons", NavigationKey = "DashboardPage" });
            Items.Add(new SideMenuItem() { Content = "Dashboard", Icon = "Icons", NavigationKey = "DashboardPage" });
            Items.Add(new SideMenuItem() { Content = "Dashboard", Icon = "Icons", NavigationKey = "DashboardPage" });
        }

    }
}
