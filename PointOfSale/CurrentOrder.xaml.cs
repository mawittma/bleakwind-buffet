using System;
using System.Collections.Generic;
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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CurrentOrder.xaml
    /// </summary>
    public partial class CurrentOrder : UserControl
    {
        List<IOrderItem> order = new List<IOrderItem>();
        public CurrentOrder()
        {
            InitializeComponent();
            order.Add(new BriarheartBurger());
            order.Add(new VokunSalad());
            order.Add(new MarkarthMilk());
            listBox.ItemsSource = order;
        }
    }
}
