using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace FactoryMonitor.UserControls.Controls.Menu
{
    public class MenuBase : System.Windows.Controls.ItemsControl
    {
        #region primary

        public ICommand NavigateCommand
        {
            get { return (ICommand)GetValue(NavigateCommandProperty); }
            set { SetValue(NavigateCommandProperty, value); }
        }
        public static readonly DependencyProperty NavigateCommandProperty =
            DependencyProperty.Register("NavigateCommand", typeof(ICommand), typeof(MenuBase));


        /// <summary>
        /// The orientation of the side menu (Vertical or Horizontal)
        /// </summary>
        public Orientation Orientation
        {
            get { return (Orientation)GetValue(OrientationProperty); }
            set { SetValue(OrientationProperty, value); }
        }
        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register("Orientation", typeof(Orientation), typeof(MenuBase), new PropertyMetadata(Orientation.Horizontal));



        public Orientation ElementOrientation
        {
            get { return (Orientation)GetValue(ElementOrientationProperty); }
            set { SetValue(ElementOrientationProperty, value); }
        }
        public static readonly DependencyProperty ElementOrientationProperty =
            DependencyProperty.Register("ElementOrientation", typeof(Orientation), typeof(MenuBase), new PropertyMetadata(Orientation.Vertical));


        #endregion


        #region select item handling
        public MenuBase()
        {
            AddHandler(MouseLeftButtonUpEvent,
                new MouseButtonEventHandler(OnItemClick), true);
        }

        private void OnItemClick(object sender, MouseButtonEventArgs e)
        {
            if (e.OriginalSource is FrameworkElement fe &&
                fe.DataContext is MenuItem item)
            {
                SelectedItem = item;
            }
        }

        public MenuItem SelectedItem
        {
            get => (MenuItem)GetValue(SelectedItemProperty);
            set => SetValue(SelectedItemProperty, value);
        }

        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register(nameof(SelectedItem), typeof(MenuItem), typeof(MenuBase), new PropertyMetadata(null, OnSelectedItemChanged));

        private static void OnSelectedItemChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not MenuBase menu) return;

            foreach (MenuItem item in menu.ItemsSource)
            {
                item.IsSelected = item == e.NewValue;
            }

            menu.RaiseEvent(new RoutedEventArgs(SelectionChangedEvent));
        }

        public static readonly RoutedEvent SelectionChangedEvent =
            EventManager.RegisterRoutedEvent(nameof(SelectionChanged), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(SideMenu));

        public event RoutedEventHandler SelectionChanged
        {
            add => AddHandler(SelectionChangedEvent, value);
            remove => RemoveHandler(SelectionChangedEvent, value);
        }
        #endregion


        #region Indicator properties
        /// <summary>
        /// The width of the selection indicator
        /// </summary>
        public int IndicatorWidth
        {
            get { return (int)GetValue(IndicatorWidthProperty); }
            set { SetValue(IndicatorWidthProperty, value); }
        }
        public static readonly DependencyProperty IndicatorWidthProperty =
            DependencyProperty.Register("IndicatorWidth", typeof(int), typeof(MenuBase), new PropertyMetadata(3));

        /// <summary>
        /// The height of the selection indicator
        /// </summary>
        public int IndicatorHeight
        {
            get { return (int)GetValue(IndicatorHeightProperty); }
            set { SetValue(IndicatorHeightProperty, value); }
        }
        public static readonly DependencyProperty IndicatorHeightProperty =
            DependencyProperty.Register("IndicatorHeight", typeof(int), typeof(MenuBase), new PropertyMetadata(20));

        /// <summary>
        /// The background of the selection indicator
        /// </summary>
        public SolidColorBrush IndicatorBackground
        {
            get { return (SolidColorBrush)GetValue(IndicatorBackgroundProperty); }
            set { SetValue(IndicatorBackgroundProperty, value); }
        }
        public static readonly DependencyProperty IndicatorBackgroundProperty =
            DependencyProperty.Register("IndicatorBackground", typeof(SolidColorBrush), typeof(MenuBase), new PropertyMetadata(Brushes.Purple));

        /// <summary>
        /// The corner radius of the selection indicator
        /// </summary>
        public CornerRadius IndicatorCornerRadius
        {
            get { return (CornerRadius)GetValue(IndicatorCornerRadiusProperty); }
            set { SetValue(IndicatorCornerRadiusProperty, value); }
        }
        public static readonly DependencyProperty IndicatorCornerRadiusProperty =
            DependencyProperty.Register("IndicatorCornerRadius", typeof(CornerRadius), typeof(MenuBase), new PropertyMetadata(new CornerRadius(5.0)));
        #endregion


        #region Content Region Properties
        public string Content
        {
            get { return (string)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }
        public static readonly DependencyProperty ContentProperty =
            DependencyProperty.Register("Content", typeof(string), typeof(MenuBase), new PropertyMetadata(null));

        /// <summary>
        /// The content text size of each menu item
        /// </summary>
        public int ContentSize
        {
            get { return (int)GetValue(ContentSizeProperty); }
            set { SetValue(ContentSizeProperty, value); }
        }
        public static readonly DependencyProperty ContentSizeProperty =
            DependencyProperty.Register("ContentSize", typeof(int), typeof(MenuBase), new PropertyMetadata(10));

        /// <summary>
        /// The content text <see cref="Brushes"/> of each menu item
        /// </summary>
        public SolidColorBrush ContentForeground
        {
            get { return (SolidColorBrush)GetValue(ContentForegroundProperty); }
            set { SetValue(ContentForegroundProperty, value); }
        }
        public static readonly DependencyProperty ContentForegroundProperty =
            DependencyProperty.Register("ContentForeground", typeof(SolidColorBrush), typeof(MenuBase), new PropertyMetadata(Brushes.Black));

        /// <summary>
        /// The content text <see cref="Visibility"/> of each menu item
        /// </summary>
        public Visibility ContentVisibility
        {
            get { return (Visibility)GetValue(ContentVisibilityProperty); }
            set { SetValue(ContentVisibilityProperty, value); }
        }
        public static readonly DependencyProperty ContentVisibilityProperty =
            DependencyProperty.Register("ContentVisibility", typeof(Visibility), typeof(MenuBase), new PropertyMetadata(Visibility.Collapsed));

        /// <summary>
        /// The content text type or style of each menu item, see <see cref="FontFamily"/>
        /// </summary>
        public FontFamily ContentFontFamily
        {
            get { return (FontFamily)GetValue(ContentFontFamilyProperty); }
            set { SetValue(ContentFontFamilyProperty, value); }
        }
        public static readonly DependencyProperty ContentFontFamilyProperty =
            DependencyProperty.Register("ContentFontFamily", typeof(FontFamily), typeof(MenuBase), new PropertyMetadata(new FontFamily("Consolas")));

        public Thickness ContentMargin
        {
            get { return (Thickness)GetValue(ContentMarginProperty); }
            set { SetValue(ContentMarginProperty, value); }
        }
        public static readonly DependencyProperty ContentMarginProperty =
            DependencyProperty.Register("ContentMargin", typeof(Thickness), typeof(MenuBase), new PropertyMetadata(new Thickness(0)));

        #endregion


        #region menu item properties
        /// <summary>
        /// The background of each menu item
        /// </summary>
        public SolidColorBrush MenuItemBackground
        {
            get { return (SolidColorBrush)GetValue(MenuItemBackgroundProperty); }
            set { SetValue(MenuItemBackgroundProperty, value); }
        }
        public static readonly DependencyProperty MenuItemBackgroundProperty =
            DependencyProperty.Register("MenuItemBackground", typeof(SolidColorBrush), typeof(MenuBase), new PropertyMetadata(Brushes.White));

        /// <summary>
        /// The corner radius of each menu item
        /// </summary>
        public CornerRadius MenuItemCornerRadius
        {
            get { return (CornerRadius)GetValue(MenuItemCornerRadiusProperty); }
            set { SetValue(MenuItemCornerRadiusProperty, value); }
        }
        public static readonly DependencyProperty MenuItemCornerRadiusProperty =
            DependencyProperty.Register("MenuItemCornerRadius", typeof(CornerRadius), typeof(MenuBase), new PropertyMetadata(new CornerRadius(5.0)));

        /// <summary>
        /// The width of each menu item
        /// </summary>
        public int MenuItemWidth
        {
            get { return (int)GetValue(MenuItemWidthProperty); }
            set { SetValue(MenuItemWidthProperty, value); }
        }
        public static readonly DependencyProperty MenuItemWidthProperty =
            DependencyProperty.Register("MenuItemWidth", typeof(int), typeof(MenuBase), new PropertyMetadata(50));

        /// <summary>
        /// The height of each menu item
        /// </summary>
        public int MenuItemHeight
        {
            get { return (int)GetValue(MenuItemHeightProperty); }
            set { SetValue(MenuItemHeightProperty, value); }
        }
        public static readonly DependencyProperty MenuItemHeightProperty =
            DependencyProperty.Register("MenuItemHeight", typeof(int), typeof(MenuBase), new PropertyMetadata(50));

        /// <summary>
        /// The margin of each menu item
        /// </summary>
        public Thickness MenuItemMargin
        {
            get { return (Thickness)GetValue(MenuItemMarginProperty); }
            set { SetValue(MenuItemMarginProperty, value); }
        }
        public static readonly DependencyProperty MenuItemMarginProperty =
            DependencyProperty.Register("MenuItemMargin", typeof(Thickness), typeof(MenuBase), new PropertyMetadata(new Thickness(5.0)));
        #endregion


        public Visibility CloseButtonVisibility
        {
            get { return (Visibility)GetValue(CloseButtonVisibilityProperty); }
            set { SetValue(CloseButtonVisibilityProperty, value); }
        }
        public static readonly DependencyProperty CloseButtonVisibilityProperty =
            DependencyProperty.Register("CloseButtonVisibility", typeof(Visibility), typeof(MenuBase), new PropertyMetadata(Visibility.Hidden));
    }
}
