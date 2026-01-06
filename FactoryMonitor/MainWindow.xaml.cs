using FactoryMonitor.UserControls.SideMenu.ViewModels;
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
        public MainWindow(MainWindowViewModel vm, SideMenuViewModel svm)
        {
            InitializeComponent();
            this.DataContext = vm;
            this.MainContentControl = App.Current.Provider.GetRequiredService<Frame>()!;
            this.SideMenuControl.DataContext = svm;
        }

        private void Window_StateChanged(object sender, EventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                var workArea = SystemParameters.WorkArea;

                MaxWidth = workArea.Width;
                MaxHeight = workArea.Height;

                Left = workArea.Left;
                Top = workArea.Top;
            }
            else
            {
                MaxWidth = double.PositiveInfinity;
                MaxHeight = double.PositiveInfinity;
            }
        }

        private void SideMenuControl_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {

        }

        private void SideMenuControl_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

        }
    }
}