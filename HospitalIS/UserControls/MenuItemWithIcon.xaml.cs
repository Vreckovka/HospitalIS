using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PropertyChanged;

namespace HospitalIS.UserControls
{
    /// <summary>
    /// Interaction logic for MenuItem.xaml
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    public partial class MenuItemWithIcon : ListViewItem
    {
        private static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("IconProperty", typeof(Path), typeof(MenuItemWithIcon));

        public Path Icon
        {
            get { return (Path)this.GetValue(IconProperty); }
            set
            {
                this.SetValue(IconProperty, value);
            }
        }

        private static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("TextProperty", typeof(string), typeof(MenuItemWithIcon));

        public string Text
        {
            get { return (string)this.GetValue(TextProperty); }
            set
            {
                this.SetValue(TextProperty, value);
            }
        }

        private static readonly DependencyProperty MenuEnumProperty =
            DependencyProperty.Register("MenuEnumProperty", typeof(Enum), typeof(MenuItemWithIcon));

        public Enum MenuEnum
        {
            get { return (Enum)this.GetValue(MenuEnumProperty); }
            set{ this.SetValue(MenuEnumProperty, value); }
        }


        public SolidColorBrush IconColor
        {
            get { return (SolidColorBrush)this.GetValue(IconColorProperty); }
            set { this.SetValue(IconColorProperty, value); }
        }
        public static readonly DependencyProperty IconColorProperty = DependencyProperty.RegisterAttached(
            "IconColor", typeof(SolidColorBrush), typeof(MenuItemWithIcon), new PropertyMetadata(Brushes.Black));


        public MenuItemWithIcon()
        {
            InitializeComponent();
        }
    }
}
