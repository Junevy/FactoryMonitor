using FactoryMonitor.UserControls.Controls.ItemsControl;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FactoryMonitor.UserControls.Controls.Base
{
    public class ContentBase : Control
    {
        public string Content
        {
            get { return (string)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }
        public static readonly DependencyProperty ContentProperty =
            DependencyProperty.Register("Content", typeof(string), typeof(SideMenu), new PropertyMetadata(null));

        /// <summary>
        /// The content text size of each menu item
        /// </summary>
        public int ContentSize
        {
            get { return (int)GetValue(ContentSizeProperty); }
            set { SetValue(ContentSizeProperty, value); }
        }
        public static readonly DependencyProperty ContentSizeProperty =
            DependencyProperty.Register("ContentSize", typeof(int), typeof(SideMenu), new PropertyMetadata(10));

        /// <summary>
        /// The content text <see cref="Brushes"/> of each menu item
        /// </summary>
        public SolidColorBrush ContentForeground
        {
            get { return (SolidColorBrush)GetValue(ContentForegroundProperty); }
            set { SetValue(ContentForegroundProperty, value); }
        }
        public static readonly DependencyProperty ContentForegroundProperty =
            DependencyProperty.Register("ContentForeground", typeof(SolidColorBrush), typeof(SideMenu), new PropertyMetadata(Brushes.Black));

        /// <summary>
        /// The content text <see cref="Visibility"/> of each menu item
        /// </summary>
        public Visibility ContentVisibility
        {
            get { return (Visibility)GetValue(ContentVisibilityProperty); }
            set { SetValue(ContentVisibilityProperty, value); }
        }
        public static readonly DependencyProperty ContentVisibilityProperty =
            DependencyProperty.Register("ContentVisibility", typeof(Visibility), typeof(SideMenu), new PropertyMetadata(Visibility.Collapsed));

        /// <summary>
        /// The content text type or style of each menu item, see <see cref="FontFamily"/>
        /// </summary>
        public FontFamily ContentFontFamily
        {
            get { return (FontFamily)GetValue(ContentFontFamilyProperty); }
            set { SetValue(ContentFontFamilyProperty, value); }
        }
        public static readonly DependencyProperty ContentFontFamilyProperty =
            DependencyProperty.Register("ContentFontFamily", typeof(FontFamily), typeof(SideMenu), new PropertyMetadata(new FontFamily("Consolas")));

        public Thickness ContentMargin
        {
            get { return (Thickness)GetValue(ContentMarginProperty); }
            set { SetValue(ContentMarginProperty, value); }
        }
        public static readonly DependencyProperty ContentMarginProperty =
            DependencyProperty.Register("ContentMargin", typeof(Thickness), typeof(SideMenu), new PropertyMetadata(new Thickness(0)));
    }
}
