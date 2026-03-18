using System.Windows;

namespace FactoryMonitor.UserControls.Controls.Menu
{
    public class MenuItem : DependencyObject
    {
        public string NavigationKey { get; set; }   // 关键：不依赖 Page
        public Guid Id { get; }

        public MenuItem()
        {
            Id = new Guid();
        }

        public string Icon
        {
            get => (string)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(nameof(Icon), typeof(string), typeof(MenuItem));

        public string Title       
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(nameof(Title), typeof(string), typeof(MenuItem));

        public bool IsSelected
        {
            get => (bool)GetValue(IsSelectedProperty);
            set => SetValue(IsSelectedProperty, value);
        }
        public static readonly DependencyProperty IsSelectedProperty =
            DependencyProperty.Register(nameof(IsSelected), typeof(bool), typeof(MenuItem), new PropertyMetadata(false));

    }
}
