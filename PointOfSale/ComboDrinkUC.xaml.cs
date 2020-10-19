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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboDrinkUC.xaml
    /// </summary>
    public partial class ComboDrinkUC : UserControl
    {
        Border b, sb;
        CurrentOrder co;
        Order o;
        Combo com;
        public ComboDrinkUC(Border bo, Order ord, CurrentOrder curOrd, Border small, Combo c)
        {
            InitializeComponent();
            b = bo;
            co = curOrd;
            o = ord;
            sb = small;
            com = c;
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void AppleJuice(Object sender, RoutedEventArgs e)
        {
            var aa = new ArentinoAppleJuiceUC(b, o, co, sb);
            aa.DataContext = new ArentinoAppleJuice();
            b.Child = aa;
            com.Drink = (Drink)(aa.DataContext);
            o.order.Add(com);


        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Coffee(Object sender, RoutedEventArgs e)
        {
            var cc = new CandlehearthCoffeeUC(b, o, co, sb);
            cc.DataContext = new CandlehearthCoffee();
            b.Child = cc;
            
            com.Drink = (Drink)(cc.DataContext);
            o.order.Add(com);

        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Milk(Object sender, RoutedEventArgs e)
        {
            var mm = new MarkarthMilkUC(b, o, co, sb);
            mm.DataContext = new MarkarthMilk();
            b.Child = mm;
            com.Drink = (Drink)(mm.DataContext);
            o.order.Add(com);

        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Soda(Object sender, RoutedEventArgs e)
        {
            var ss = new SailorSodaUC(b, o, co, sb);
            ss.DataContext = new SailorSoda();
            b.Child = ss;
            com.Drink = (Drink)(ss.DataContext);
            o.order.Add(com);

        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Warrior(Object sender, RoutedEventArgs e)
        {
            var ww = new WarriorWaterUC(b, o, co, sb);
            ww.DataContext = new WarriorWater();
            b.Child = ww;
            com.Drink = (Drink)(ww.DataContext);
            o.order.Add(com);

        }
    }
}
