using Microsoft.Extensions.DependencyInjection;
using System.Windows.Controls;

namespace FactoryMonitor.Client.Servies.Navigation
{
    public class NavigationService(Frame mainFrame) : INavigation
    {
        private readonly Frame mainFrame = mainFrame;

        /// <summary>
        /// Navigate to the specified Page.
        /// </summary>
        /// <typeparam name="T"> 需要导航的Page Type </typeparam>
        public void NavigateTo<TPage>() where TPage : Page
        {
            var page = App.Current.Provider.GetRequiredService<TPage>();
            if (page != null)
                mainFrame.Navigate(page);
        }
    }
}
