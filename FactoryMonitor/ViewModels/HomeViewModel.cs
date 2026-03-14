using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FactoryMonitor.UserControls.Controls.Menu;
using System.Collections.ObjectModel;

namespace FactoryMonitor.Client.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        // 侧边栏菜单项集合
        public ObservableCollection<MenuItem> Items { get; set; } = [];

        public HomeViewModel()
        {
            Items.Add(new MenuItem() { Content = "Home", Icon = "\ue65d", NavigationKey = "HomePage", IsSelected = true });
            Items.Add(new MenuItem() { Content = "Trend", Icon = "\ue87b", NavigationKey = "TrendPage" });
            Items.Add(new MenuItem() { Content = "Settings", Icon = "\ue66b", NavigationKey = "SettingsPage" });
            Items.Add(new MenuItem() { Content = "User", Icon = "\ue7b2", NavigationKey = "UserPage" });
        }

        [RelayCommand]
        private void CloseTab(MenuItem item)
        {
            /*
             * 需要接口，强制释放资源，待完成
             * 
             */
            if (Items.Contains(item))
            {
                Items.Remove(item);
            }
        }

        [RelayCommand]
        private void Navigate(MenuItem item)
        {
            //MessageBox.Show($"导航到 {item.NavigationKey}");
        }
    }
}
