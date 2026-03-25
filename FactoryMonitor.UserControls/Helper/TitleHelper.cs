using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FactoryMonitor.UserControls.Helper
{
    public static class TitleHelper
    {
        public static Visibility GetRequired(DependencyObject obj)
        {
            return (Visibility)obj.GetValue(RequiredProperty);
        }

        public static void SetRequired(DependencyObject obj, Visibility value)
        {
            obj.SetValue(RequiredProperty, value);
        }
        public static readonly DependencyProperty RequiredProperty =
            DependencyProperty.RegisterAttached("Required", typeof(Visibility), typeof(TitleHelper), new PropertyMetadata(Visibility.Collapsed));



        public static Orientation GetDisplayMode(DependencyObject obj)
        {
            return (Orientation)obj.GetValue(DisplayModeProperty);
        }

        public static void SetDisplayMode(DependencyObject obj, Orientation value)
        {
            obj.SetValue(DisplayModeProperty, value);
        }
        public static readonly DependencyProperty DisplayModeProperty =
            DependencyProperty.RegisterAttached("DisplayMode", typeof(Orientation), typeof(TitleHelper), new PropertyMetadata(Orientation.Horizontal));


        public static object GetTitle(DependencyObject obj)
        {
            return (object)obj.GetValue(TitleProperty);
        }

        public static void SetTitle(DependencyObject obj, object value)
        {
            obj.SetValue(TitleProperty, value);
        }
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.RegisterAttached("Title", typeof(object), typeof(TitleHelper), new PropertyMetadata(0));


        public static int GetWidth(DependencyObject obj)
        {
            return (int)obj.GetValue(WidthProperty);
        }

        public static void SetWidth(DependencyObject obj, int value)
        {
            obj.SetValue(WidthProperty, value);
        }
        public static readonly DependencyProperty WidthProperty =
            DependencyProperty.RegisterAttached("Width", typeof(int), typeof(TitleHelper), new PropertyMetadata(50));


        public static int GetHeight(DependencyObject obj)
        {
            return (int)obj.GetValue(HeightProperty);
        }

        public static void SetHeight(DependencyObject obj, int value)
        {
            obj.SetValue(HeightProperty, value);
        }
        public static readonly DependencyProperty HeightProperty =
            DependencyProperty.RegisterAttached("Height", typeof(int), typeof(TitleHelper), new PropertyMetadata(20));




        public static int GetSize(DependencyObject obj)
        {
            return (int)obj.GetValue(SizeProperty);
        }

        public static void SetSize(DependencyObject obj, int value)
        {
            obj.SetValue(SizeProperty, value);
        }
        public static readonly DependencyProperty SizeProperty =
            DependencyProperty.RegisterAttached("Size", typeof(int), typeof(TitleHelper), new PropertyMetadata(16));



        public static SolidColorBrush GetForeground(DependencyObject obj)
        {
            return (SolidColorBrush)obj.GetValue(ForegroundProperty);
        }

        public static void SetForeground(DependencyObject obj, SolidColorBrush value)
        {
            obj.SetValue(ForegroundProperty, value);
        }
        public static readonly DependencyProperty ForegroundProperty =
            DependencyProperty.RegisterAttached("Foreground", typeof(SolidColorBrush), typeof(TitleHelper), new PropertyMetadata(Brushes.Black));




        public static Visibility GetVisibility(DependencyObject obj)
        {
            return (Visibility)obj.GetValue(VisibilityProperty);
        }

        public static void SetVisibility(DependencyObject obj, Visibility value)
        {
            obj.SetValue(VisibilityProperty, value);
        }
        public static readonly DependencyProperty VisibilityProperty =
            DependencyProperty.RegisterAttached("Visibility", typeof(Visibility), typeof(TitleHelper), new PropertyMetadata(Visibility.Collapsed));



        public static Thickness GetMargin(DependencyObject obj)
        {
            return (Thickness)obj.GetValue(MarginProperty);
        }

        public static void SetMargin(DependencyObject obj, Thickness value)
        {
            obj.SetValue(MarginProperty, value);
        }
        public static readonly DependencyProperty MarginProperty =
            DependencyProperty.RegisterAttached("Margin", typeof(Thickness), typeof(TitleHelper), new PropertyMetadata(new Thickness(0)));




        public static FontFamily GetFontFamily(DependencyObject obj)
        {
            return (FontFamily)obj.GetValue(FontFamilyProperty);
        }

        public static void SetFontFamily(DependencyObject obj, FontFamily value)
        {
            obj.SetValue(FontFamilyProperty, value);
        }
        public static readonly DependencyProperty FontFamilyProperty =
            DependencyProperty.RegisterAttached("FontFamily", typeof(FontFamily), typeof(TitleHelper), 
                new PropertyMetadata(new FontFamily("Arial")));


    }
}
