using FactoryMonitor.Client.ViewModels;
using System.Windows.Controls;

namespace FactoryMonitor.Client.Views
{
    /// <summary>
    /// HomeView.xaml 的交互逻辑
    /// </summary>
    public partial class HomeView : Page
    {
        public HomeView(HomeViewModel vm)
        {
            InitializeComponent();
            this.DataContext = vm;
        }
    }
}
