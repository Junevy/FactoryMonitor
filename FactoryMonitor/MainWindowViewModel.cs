using System.Windows;
using System.Windows.Controls;

namespace FactoryMonitor.Client
{
    public class MainWindowViewModel
    {
        public List<ListBoxItem> MenuItems { get; } =
        [
            new ListBoxItem { Content = "&#xe639;", Style = App.Current.LoadResource<Style>("MenuBar"), Width = 50, Height = 50 },
            new ListBoxItem { Content = "&#xe639;", Style = App.Current.LoadResource<Style>("MenuBar"), Width = 50, Height = 50 },
            new ListBoxItem { Content = "&#xe639;", Style = App.Current.LoadResource<Style>("MenuBar"), Width = 50, Height = 50 },
            new ListBoxItem { Content = "&#xe639;", Style = App.Current.LoadResource<Style>("MenuBar"), Width = 50, Height = 50 },
        ];
    }
}
