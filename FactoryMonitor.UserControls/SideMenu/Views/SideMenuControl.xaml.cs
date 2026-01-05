using System.Windows.Controls;

namespace FactoryMonitor.UserControls.SideMenu.Views
{
    /// <summary>
    /// SideMenuControl.xaml 的交互逻辑
    /// </summary>
    public partial class SideMenuControl : UserControl
    {
        public SideMenuControl()
        {
            InitializeComponent();
            DataContext = new ViewModels.SideMenuViewModel();
        }
    }
}
