using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FactoryMonitor.UserControls.Helper
{
    public static class ScrollViewerHelper
    {
        public static readonly DependencyProperty EnableHorizontalMouseWheelProperty =
            DependencyProperty.RegisterAttached(
                "EnableHorizontalMouseWheel",
                typeof(bool),
                typeof(ScrollViewerHelper),
                new PropertyMetadata(false, OnChanged));

        public static void SetEnableHorizontalMouseWheel(DependencyObject obj, bool value)
            => obj.SetValue(EnableHorizontalMouseWheelProperty, value);

        public static bool GetEnableHorizontalMouseWheel(DependencyObject obj)
            => (bool)obj.GetValue(EnableHorizontalMouseWheelProperty);

        private static void OnChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ScrollViewer sv)
            {
                if ((bool)e.NewValue)
                    sv.PreviewMouseWheel += Sv_PreviewMouseWheel;
                else
                    sv.PreviewMouseWheel -= Sv_PreviewMouseWheel;
            }
        }

        private static void Sv_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            var sv = sender as ScrollViewer;
            sv.ScrollToHorizontalOffset(sv.HorizontalOffset - e.Delta / 3.0);
            e.Handled = true;
        }
    }
}
