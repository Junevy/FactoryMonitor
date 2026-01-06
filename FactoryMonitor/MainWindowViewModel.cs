using FactoryMonitor.Client.Views;
using FactoryMonitor.UserControls.SideMenu.ViewModels;

namespace FactoryMonitor.Client
{
    public class MainWindowViewModel
    {
        //private object Current => sideMenu.SelectedMenuItem;

        private readonly SideMenuViewModel sideMenu;
        public MainWindowViewModel(SideMenuViewModel sideMenu)
        {
            this.sideMenu = sideMenu;

            InitialSideMenu();
        }

        private void InitialSideMenu()
        {
            sideMenu.AddMenuItem(new() { Title = "HOME", Icon = "\uE691", PageType = typeof(HomeView)});
        }
    }
}
