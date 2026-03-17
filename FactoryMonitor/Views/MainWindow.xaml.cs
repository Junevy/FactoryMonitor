using FactoryMonitor.Client.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace FactoryMonitor.Client.Views
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

            Frame frame = new();
            //this.MainContentControl.Content = navigator.RegisterRoute(nameof(MainWindow));
            //this.MainContentControl.Content = App.Current.Provider.GetRequiredService<ConcurrentDictionary<string, Frame>>()[nameof(MainWindow)];
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