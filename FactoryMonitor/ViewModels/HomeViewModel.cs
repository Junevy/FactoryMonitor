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
        // 侧边栏菜单项集合
        public ObservableCollection<MenuItem> Items { get; set; } = [];
        //private readonly INavigation navigator;
        //private readonly NavigationBuilder navigator;


        public HomeViewModel()
        {

            Items.Add(new MenuItem() { Title = "Home", Icon = "\ue65d", NavigationKey = "HomePage", IsSelected = true });
            Items.Add(new MenuItem() { Title = "Trend", Icon = "\ue87b", NavigationKey = "TrendPage" });
            Items.Add(new MenuItem() { Title = "Settings", Icon = "\ue66b", NavigationKey = "SettingsPage" });
            Items.Add(new MenuItem() { Title = "User", Icon = "\ue7b2", NavigationKey = "UserPage" });
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
            //if (item == null)
            //    return;
            //var navigationKey = item.NavigationKey;

            //switch (navigationKey)
            //{
            //    case "HomePage":
            //        //navigator.NavigateTo<HomePage>(nameof(HomeView));
            //        navigator.Navigate(nameof(HomeView), typeof(HomeView));
            //        break;
            //    default:
            //        break;
            //}
            ////MessageBox.Show($"导航到 {item.NavigationKey}");
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
