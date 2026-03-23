using FactoryMonitor.Client.ViewModels;
using System.Windows.Controls;

namespace FactoryMonitor.Client.Views
{
    /// <summary>
    /// HomePage.xaml 的交互逻辑
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage(HomePageViewModel vm)
        {
            InitializeComponent();
            this.DataContext = vm;
        }
    }
}
