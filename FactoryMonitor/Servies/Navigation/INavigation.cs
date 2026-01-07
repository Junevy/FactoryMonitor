using System.Windows.Controls;

namespace FactoryMonitor.Client.Servies.Navigation
{
    public interface INavigation
    {
        public void NavigateTo<T>() where T : Page;
    }
}
