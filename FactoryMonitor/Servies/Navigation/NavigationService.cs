using Microsoft.Extensions.DependencyInjection;
using System.Collections.Concurrent;
using System.Windows.Controls;

namespace FactoryMonitor.Client.Servies.Navigation
{
    public class NavigationService(ConcurrentDictionary<string, Frame> Frames) : INavigation
    {
        private readonly ConcurrentDictionary<string, Frame> frames = Frames;
        //private readonly Frame mainFrame = mainFrame;

        /// <summary>
        /// Navigate to the specified Page.
        /// </summary>
        /// <typeparam name="T"> 需要导航的Page Type </typeparam>
        public void NavigateTo<TPage>(string frameName) where TPage : Page
        {
            var page = App.Current.Provider.GetRequiredService<TPage>();
            if (page != null)
                frames[frameName].Navigate(page);
        }
    }
}
