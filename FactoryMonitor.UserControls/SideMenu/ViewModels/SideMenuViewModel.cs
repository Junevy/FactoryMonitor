using FactoryMonitor.UserControls.SideMenu.Models;
using System.Collections.ObjectModel;

namespace FactoryMonitor.UserControls.SideMenu.ViewModels
{
    public class SideMenuViewModel
    {
        public ObservableCollection<SideMenuModel> MenuItems { get; }

        private SideMenuModel? selectedMenuItem;
        public SideMenuModel? SelectedMenuItem
        {
            get => selectedMenuItem;
            set
            {
                selectedMenuItem = value;
                // 后面可以在这里处理导航
            }
        }

        public SideMenuViewModel()
        {
            MenuItems =
            [
                new() { Title = "HOME" },
                new() { Title = "HOME" },
                new() { Title = "HOME" },
                new() { Title = "HOME" },
                new() { Title = "HOME" },
            ];
        }
    }
}
