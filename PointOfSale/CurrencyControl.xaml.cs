using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CurrencyControl.xaml
    /// </summary>
    public partial class CurrencyControl : UserControl
    {
        static FrameworkPropertyMetadata metaData = new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | FrameworkPropertyMetadataOptions.AffectsRender);
        public static DependencyProperty CustomerNumberProperty = DependencyProperty.Register("CustomerNumber", typeof(int), typeof(CurrencyControl), metaData);
        
        public int CustomerNumber
        {
            get => (int)GetValue(CustomerNumberProperty);
            set => SetValue(CustomerNumberProperty, value);
        }
        public CurrencyControl()
        {
            InitializeComponent();
                
        }
        void up(Object sender,RoutedEventArgs e)
        {
            CustomerNumber = CustomerNumber + 1;
        }
        void down(Object sender, RoutedEventArgs e)
        {
            CustomerNumber = CustomerNumber - 1;
        }
    }
}
