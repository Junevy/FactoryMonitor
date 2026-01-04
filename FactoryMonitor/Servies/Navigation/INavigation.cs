using System.Windows.Controls;

namespace FactoryMonitor.Client.Servies.Navigation
{
    interface INavigation
    {
        public void NavigateTo<T>() where T : Page;
    }
}
