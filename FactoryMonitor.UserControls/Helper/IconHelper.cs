using System.Windows;
using System.Windows.Media;

namespace FactoryMonitor.UserControls.Helper
{
    public static class IconHelper
    {
        public static object GetIcon(DependencyObject obj)
        {
            return (object)obj.GetValue(IconProperty);
        }
        public static void SetIcon(DependencyObject obj, object value)
        {
            obj.SetValue(IconProperty, value);
        }
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.RegisterAttached("Icon", typeof(object), typeof(IconHelper));




        public static int GetSize(DependencyObject obj)
        {
            return (int)obj.GetValue(SizeProperty);
        }

        public static void SetSize(DependencyObject obj, int value)
        {
            obj.SetValue(SizeProperty, value);
        }
        public static readonly DependencyProperty SizeProperty =
            DependencyProperty.RegisterAttached("Size", typeof(int), typeof(IconHelper), new PropertyMetadata(16));




        public static SolidColorBrush GetForeground(DependencyObject obj)
        {
            return (SolidColorBrush)obj.GetValue(ForegroundProperty);
        }

        public static void SetForeground(DependencyObject obj, SolidColorBrush value)
        {
            obj.SetValue(ForegroundProperty, value);
        }
        public static readonly DependencyProperty ForegroundProperty =
            DependencyProperty.RegisterAttached("Foreground", typeof(SolidColorBrush), typeof(IconHelper), new PropertyMetadata(Brushes.Black));




        public static Thickness GetMargin(DependencyObject obj)
        {
            return (Thickness)obj.GetValue(MarginProperty);
        }

        public static void SetMargin(DependencyObject obj, Thickness value)
        {
            obj.SetValue(MarginProperty, value);
        }
        public static readonly DependencyProperty MarginProperty =
            DependencyProperty.RegisterAttached("Margin", typeof(Thickness), typeof(IconHelper), new PropertyMetadata(new Thickness(0,5,5,5)));




        public static FontFamily GetFontFamily(DependencyObject obj)
        {
            return (FontFamily)obj.GetValue(FontFamilyProperty);
        }

        public static void SetFontFamily(DependencyObject obj, FontFamily value)
        {
            obj.SetValue(FontFamilyProperty, value);
        }
        public static readonly DependencyProperty FontFamilyProperty =
            DependencyProperty.RegisterAttached("FontFamily", typeof(FontFamily), typeof(IconHelper), 
                new PropertyMetadata(
                    new FontFamily(
                        new Uri("pack://application:,,,/"),
                            "/FactoryMonitor.UserControls;component/Resources/Font/#iconfont")));

    }
}
