using System.Windows;

namespace FactoryMonitor.UserControls.Controls.Text
{
    public class TextBox : System.Windows.Controls.TextBox
    {
        public bool ShowClear
        {
            get { return (bool)GetValue(ShowClearProperty); }
            set { SetValue(ShowClearProperty, value); }
        }
        public static readonly DependencyProperty ShowClearProperty =
            DependencyProperty.Register("ShowClear", typeof(bool), typeof(TextBox), new PropertyMetadata(true));


        public Visibility CloseButton
        {
            get { return (Visibility)GetValue(CloseButtonProperty); }
            set { SetValue(CloseButtonProperty, value); }
        }
        public static readonly DependencyProperty CloseButtonProperty =
            DependencyProperty.Register("CloseButton", typeof(Visibility), typeof(TextBox), new PropertyMetadata(Visibility.Collapsed));

    }
}
