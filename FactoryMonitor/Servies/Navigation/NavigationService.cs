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
        public void NavigateTo<T>() where T : Page
        {
            //var page = App.Current.GetSingleton<Page>();
            //if (page != null)
            //    mainFrame.Navigate(page);
        }
    }
}
