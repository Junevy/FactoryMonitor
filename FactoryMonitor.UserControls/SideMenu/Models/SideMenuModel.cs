using System.Windows;
using System.Windows.Media;

namespace FactoryMonitor.UserControls.SideMenu.Models
{
    public class SideMenuModel
    {
        public string Icon { get; set; } = string.Empty;   // \uE691
        public string Title { get; set; } = string.Empty;  // HOME

        public Type? PageType { get; set; }

        public Visibility Visiable { get; set; } = Visibility.Collapsed;
        public int FontSize { get; set; } = 20;

        public SolidColorBrush Background { get; set; } = new SolidColorBrush(Colors.Transparent);
        public SolidColorBrush Foreground { get; set; } = new SolidColorBrush(Colors.Black);
        public SolidColorBrush ContainerBackground { get; set; } = new SolidColorBrush(Colors.Transparent);
        public SolidColorBrush IsMouseOverBackground { get; set; } = new SolidColorBrush(Colors.LightGray);
        public SolidColorBrush IsSelectedBackground { get; set; } = new SolidColorBrush(Colors.LightGray);
        public SolidColorBrush IsSelectedIdicatorBackground { get; set; } = new SolidColorBrush(Colors.MediumPurple);

        public int IndicatorWidth { get; set; } = 6;
        public int IndicatorHeight { get; set; } = 40;


    } 
}
