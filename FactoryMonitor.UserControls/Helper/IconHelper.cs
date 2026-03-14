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



        public static int GetIconSize(DependencyObject obj)
        {
            return (int)obj.GetValue(IconSizeProperty);
        }

        public static void SetIconSize(DependencyObject obj, int value)
        {
            obj.SetValue(IconSizeProperty, value);
        }
        public static readonly DependencyProperty IconSizeProperty =
            DependencyProperty.RegisterAttached("IconSize", typeof(int), typeof(IconHelper), new PropertyMetadata(30));



        public static SolidColorBrush GetIconForeground(DependencyObject obj)
        {
            return (SolidColorBrush)obj.GetValue(IconForegroundProperty);
        }

        public static void SetIconForeground(DependencyObject obj, SolidColorBrush value)
        {
            obj.SetValue(IconForegroundProperty, value);
        }
        public static readonly DependencyProperty IconForegroundProperty =
            DependencyProperty.RegisterAttached("IconForeground", typeof(SolidColorBrush), typeof(IconHelper), new PropertyMetadata(Brushes.Black));



        public static Thickness GetIconMargin(DependencyObject obj)
        {
            return (Thickness)obj.GetValue(IconMarginProperty);
        }

        public static void SetIconMargin(DependencyObject obj, Thickness value)
        {
            obj.SetValue(IconMarginProperty, value);
        }
        public static readonly DependencyProperty IconMarginProperty =
            DependencyProperty.RegisterAttached("IconMargin", typeof(Thickness), typeof(IconHelper), new PropertyMetadata(new Thickness(0)));


        public static FontFamily GetIconFontFamily(DependencyObject obj)
        {
            return (FontFamily)obj.GetValue(IconFontFamilyProperty);
        }

        public static void SetIconFontFamily(DependencyObject obj, FontFamily value)
        {
            obj.SetValue(IconFontFamilyProperty, value);
        }
        public static readonly DependencyProperty IconFontFamilyProperty =
            DependencyProperty.RegisterAttached("IconFontFamily", typeof(FontFamily), typeof(IconHelper), 
                new PropertyMetadata(new FontFamily(
                        new Uri("pack://application:,,,/"),
                            "/FactoryMonitor.UserControls;component/Resources/Font/#iconfont")));

    }
}
