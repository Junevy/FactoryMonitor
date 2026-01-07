using FactoryMonitor.UserControls.Controls;
using System.CodeDom;
using System.Collections.ObjectModel;

namespace FactoryMonitor.Client.ViewModels
{
    public class HomeViewModel
    {

        public ObservableCollection<SideMenuItem> Items { get; set; } = [];

        public HomeViewModel()
        {
            Items.Add(new SideMenuItem() { Content = "Home", Icon = "\ue69a", NavigationKey = "HomePage" , IsSelected = true});
            Items.Add(new SideMenuItem() { Content = "Trend", Icon = "\ue87b", NavigationKey = "TrendPage" });
            Items.Add(new SideMenuItem() { Content = "Settings", Icon = "\ue66b", NavigationKey = "SettingsPage" });
        }
    }
}
