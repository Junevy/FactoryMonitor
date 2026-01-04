using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using System.Windows.Controls;

namespace FactoryMonitor.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(MainWindowViewModel vm)
        {
            InitializeComponent();
            this.DataContext = vm;
            this.MainContentControl = App.Current.Provider.GetRequiredService<Frame>()!;
        }
    }
}