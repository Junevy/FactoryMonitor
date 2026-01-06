using FactoryMonitor.UserControls.SideMenu.Models;
using System.Collections.ObjectModel;

namespace FactoryMonitor.UserControls.SideMenu.ViewModels
{
    public class SideMenuViewModel
    {
        public ObservableCollection<SideMenuModel> MenuItems { get; } = [];

        private SideMenuModel? selectedMenuItem;
        public SideMenuModel? SelectedMenuItem
        {
            get => selectedMenuItem;
            set
            {
                if (value != null)
                    selectedMenuItem = value;
                // 后面可以在这里处理导航
            }
        }

        public SideMenuViewModel()
        {
            
        }

        public void AddMenuItem(SideMenuModel menuItem)
        {
            MenuItems.Add(menuItem);
        }
    }
}
