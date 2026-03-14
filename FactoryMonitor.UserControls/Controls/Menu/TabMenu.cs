using System.Windows;
using System.Windows.Input;

namespace FactoryMonitor.UserControls.Controls.Menu
{
    public class TabMenu : MenuBase
    {

        public ICommand CloseCommand
        {
            get { return (ICommand)GetValue(CloseCommandProperty); }
            set { SetValue(CloseCommandProperty, value); }
        }
        public static readonly DependencyProperty CloseCommandProperty =
            DependencyProperty.Register("CloseCommand", typeof(ICommand), typeof(TabMenu));


        public ICommand CloseAllCommand
        {
            get { return (ICommand)GetValue(CloseAllCommandProperty); }
            set { SetValue(CloseAllCommandProperty, value); }
        }
        public static readonly DependencyProperty CloseAllCommandProperty =
            DependencyProperty.Register("CloseAllCommand", typeof(ICommand), typeof(TabMenu));


        public ICommand AddCommand
        {
            get { return (ICommand)GetValue(AddCommandProperty); }
            set { SetValue(AddCommandProperty, value); }
        }
        public static readonly DependencyProperty AddCommandProperty =
            DependencyProperty.Register("AddCommand", typeof(ICommand), typeof(TabMenu));

        public ICommand RenameCommand
        {
            get { return (ICommand)GetValue(RenameCommandProperty); }
            set { SetValue(RenameCommandProperty, value); }
        }
        public static readonly DependencyProperty RenameCommandProperty =
            DependencyProperty.Register("RenameCommand", typeof(ICommand), typeof(TabMenu));
    }
}
