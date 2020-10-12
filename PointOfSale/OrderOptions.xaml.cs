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
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderOptions.xaml
    /// </summary>
    public partial class OrderOptions : UserControl
    {
        Border b;
        public Order ord;
        public CurrentOrder co;
        Border sb;
        /// <summary>
        /// The constuctor of the order options user control
        /// </summary>
        /// <param name="bo"></param>
        public OrderOptions(Border bo, Order order, CurrentOrder c,Border smallb)
        {
            InitializeComponent();
            b = bo;
            ord = order;
            co = c;
            sb = smallb;
            //DataContext = new Order();
            //co.o = (Order)DataContext;
            DataContext = ord;
            
        }
        /// <summary>
        /// Creates a new order for the user
        /// </summary>
        /// <param name="sender">needed for event</param>
        /// <param name="e">needed for event</param>
        void NewOrder(Object sender, RoutedEventArgs e)
        {
            ord = new Order();
            co = new CurrentOrder(ord);
            DataContext = ord;
            sb.Child = co;
            
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Vokun(Object sender, RoutedEventArgs e)
        {
            var vs = new VokunSaladUC(b,ord,co,sb);
            vs.DataContext = new VokunSalad();
            b.Child = vs;
            ord.order.Add((IOrderItem)vs.DataContext);
            

        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Grits(Object sender, RoutedEventArgs e)
        {
            var mog = new MadOtarGritsUC(b,ord,co,sb);
            mog.DataContext = new MadOtarGrits();
            b.Child = mog;
            ord.order.Add((IOrderItem)mog.DataContext);
            
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Miraak(Object sender, RoutedEventArgs e)
        {
            var fm = new FriedMiraakUC(b,ord,co,sb);
            fm.DataContext = new FriedMiraak();
            b.Child = fm;
            ord.order.Add((IOrderItem)fm.DataContext);
            
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Fries(Object sender, RoutedEventArgs e)
        {
            var dbw = new DragonBornWaffleFriesUC(b,ord,co,sb);
            dbw.DataContext = new DragonbornWaffleFries();
            b.Child = dbw;
            ord.order.Add((IOrderItem)dbw.DataContext);
            
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void AppleJuice(Object sender, RoutedEventArgs e)
        {
            var aa = new ArentinoAppleJuiceUC(b,ord,co,sb);
            aa.DataContext = new ArentinoAppleJuice();
            b.Child = aa;
            ord.order.Add((IOrderItem)aa.DataContext);
            
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Coffee(Object sender, RoutedEventArgs e)
        {
            var cc = new CandlehearthCoffeeUC(b,ord,co,sb);
            cc.DataContext = new CandlehearthCoffee();
            b.Child = cc;
            ord.order.Add((IOrderItem)cc.DataContext);
            
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Milk(Object sender, RoutedEventArgs e)
        {
            var mm = new MarkarthMilkUC(b,ord,co,sb);
            mm.DataContext = new MarkarthMilk();
            b.Child = mm;
            ord.order.Add((IOrderItem)mm.DataContext);
            
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Soda(Object sender, RoutedEventArgs e)
        {
            var ss = new SailorSodaUC(b,ord,co,sb);
            ss.DataContext = new SailorSoda();
            b.Child = ss;
            ord.order.Add((IOrderItem)ss.DataContext);
            
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Warrior(Object sender, RoutedEventArgs e)
        {
            var ww = new WarriorWaterUC(b,ord,co,sb);
            ww.DataContext = new WarriorWater();
            b.Child = ww;
            ord.order.Add((IOrderItem)ww.DataContext);
            
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Briarheart(Object sender,RoutedEventArgs e)
        {
            
            var bb = new BriarheartBurgerUC(b,ord,co,sb);
            bb.DataContext = new BriarheartBurger();
            b.Child = bb;
            ord.order.Add((IOrderItem)bb.DataContext);
            
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Draugr(Object sender, RoutedEventArgs e)
        {
            var dd = new DoubleDraugrUC(b,ord,co,sb);
            dd.DataContext = new DoubleDraugr();
            b.Child = dd;
            ord.order.Add((IOrderItem)dd.DataContext);
            

        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Thalmor(Object sender, RoutedEventArgs e)
        {
            var tt = new ThalmorTripleUC(b,ord,co,sb);
            tt.DataContext = new ThalmorTriple();
            b.Child = tt;
            ord.order.Add((IOrderItem)tt.DataContext);
            
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Philly(Object sender, RoutedEventArgs e)
        {
            var pp = new PhillyPoacherUC(b,ord,co,sb);
            pp.DataContext = new PhillyPoacher();
            b.Child = pp;
            ord.order.Add((IOrderItem)pp.DataContext);
            

        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Garden(Object sender, RoutedEventArgs e)
        {
            var goo = new GardenOrcOmeletteUC(b,ord,co,sb);
            goo.DataContext = new GardenOrcOmelette();
            b.Child = goo;
            ord.order.Add((IOrderItem)goo.DataContext);
            

        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Smokehouse(Object sender, RoutedEventArgs e)
        {
            var ss = new SmokehouseSkeletonUC(b,ord,co,sb);
            ss.DataContext = new SmokehouseSkeleton();
            b.Child = ss;
            ord.order.Add((IOrderItem)ss.DataContext);
            

        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Thugs(Object sender,RoutedEventArgs e)
        {
            var tt = new ThugsTBoneUC(b,ord,co,sb);
            tt.DataContext = new ThugsTBone();
            b.Child = tt;
            ord.order.Add((IOrderItem)tt.DataContext);
            
        }
    }
}
