using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FactoryMonitor.UserControls.Controls.Menu;
using SimpleNavigation;
using System.Collections.ObjectModel;
using System.Windows;

namespace FactoryMonitor.Client.ViewModels
{
    public partial class HomeViewModel : ObservableObject, INavigationAware
    {

        private readonly INavigationService navigationService;
        // 侧边栏菜单项集合
        public ObservableCollection<MenuItem> Items { get; set; } = [];

        public HomeViewModel(INavigationService navigationService)
        {
            Items.Add(new MenuItem() { Title = "Home", Icon = "\ue65d", NavigationKey = "HomePage", IsSelected = true });
            Items.Add(new MenuItem() { Title = "Trend", Icon = "\ue87b", NavigationKey = "TrendPage" });
            Items.Add(new MenuItem() { Title = "Settings", Icon = "\ue66b", NavigationKey = "SettingsPage" });
            Items.Add(new MenuItem() { Title = "User", Icon = "\ue7b2", NavigationKey = "UserPage" });

            this.navigationService = navigationService;
        }

        [RelayCommand]
        private void CloseTab(MenuItem item)
        {

            /*
             * 需要接口，强制释放资源，待完成
             * 
             */
            Items.Remove(item);
        }

        [RelayCommand]
        private void Navigate(MenuItem item)
        {
            var key = item.NavigationKey;

            if (key == null) return;

            //if (item.IsSelected) return;

            switch (key)
            {
                case "HomePage":
                    navigationService.Navigate("HomeViewRegion", "HomePage");
                    break;
                default:
                    break;
            }
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
            if (parameters != null)
            {
                // 处理导航参数
                // 例如：int id = parameters.Get<int>("id");
                var test = parameters.Get<int>("1");
                MessageBox.Show(test + "");
            }
        }
    }
}
