using System.Windows;
using System.Windows.Controls;

namespace FactoryMonitor.UserControls.Controls.Bar
{
    public class ControlBar : ItemsControl
    {
        public Image Icon
        {
            get { return (Image)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(Image), typeof(ControlBar), new PropertyMetadata(0));


    }
}
