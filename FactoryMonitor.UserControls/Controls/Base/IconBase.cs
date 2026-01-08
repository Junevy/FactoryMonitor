using FactoryMonitor.UserControls.Controls.ItemsControl;
using System.Windows;
using System.Windows.Media;

namespace FactoryMonitor.UserControls.Controls.Base
{
    public class IconBase : ContentBase
    {
        public string Icon
        {
            get { return (string)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(string), typeof(SideMenu), new PropertyMetadata(""));

        public Visibility IconVisibility
        {
            get { return (Visibility)GetValue(IconVisibilityProperty); }
            set { SetValue(IconVisibilityProperty, value); }
        }
        public static readonly DependencyProperty IconVisibilityProperty =
            DependencyProperty.Register("IconVisibility", typeof(Visibility), typeof(SideMenu), new PropertyMetadata(Visibility.Visible));

        public int IconSize
        {
            get { return (int)GetValue(IconSizeProperty); }
            set { SetValue(IconSizeProperty, value); }
        }
        public static readonly DependencyProperty IconSizeProperty =
            DependencyProperty.Register("IconSize", typeof(int), typeof(SideMenu), new PropertyMetadata(24));

        public FontFamily IconFontFamily
        {
            get { return (FontFamily)GetValue(IconFontFamilyProperty); }
            set { SetValue(IconFontFamilyProperty, value); }
        }
        public static readonly DependencyProperty IconFontFamilyProperty =
            DependencyProperty.Register(nameof(IconFontFamily), typeof(FontFamily), typeof(SideMenu),
                new PropertyMetadata(
                    new FontFamily(
                        new Uri("pack://application:,,,/"),
                        "/FactoryMonitor.UserControls;component/Resources/Font/#iconfont")));

        public SolidColorBrush IconForeground
        {
            get { return (SolidColorBrush)GetValue(IconForegroundProperty); }
            set { SetValue(IconForegroundProperty, value); }
        }
        public static readonly DependencyProperty IconForegroundProperty =
            DependencyProperty.Register("IconForeground", typeof(SolidColorBrush), typeof(SideMenu), new PropertyMetadata(Brushes.Black));

        public Thickness IconMargin
        {
            get { return (Thickness)GetValue(IconMarginProperty); }
            set { SetValue(IconMarginProperty, value); }
        }
        public static readonly DependencyProperty IconMarginProperty =
            DependencyProperty.Register("IconMargin", typeof(Thickness), typeof(SideMenu), new PropertyMetadata(new Thickness(0)));

    }
}
