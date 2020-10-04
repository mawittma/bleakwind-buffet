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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderOptions.xaml
    /// </summary>
    public partial class OrderOptions : UserControl
    {
        Border b;
        /// <summary>
        /// The constuctor of the order options user control
        /// </summary>
        /// <param name="bo"></param>
        public OrderOptions(Border bo)
        {
            InitializeComponent();
            b = bo;
            
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Vokun(Object sender, RoutedEventArgs e)
        {
            var vs = new VokunSaladUC(b);
            vs.DataContext = new VokunSalad();
            b.Child = vs;
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Grits(Object sender, RoutedEventArgs e)
        {
            var mog = new MadOtarGritsUC(b);
            mog.DataContext = new MadOtarGrits();
            b.Child = mog;
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Miraak(Object sender, RoutedEventArgs e)
        {
            var fm = new FriedMiraakUC(b);
            fm.DataContext = new FriedMiraak();
            b.Child = fm;
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Fries(Object sender, RoutedEventArgs e)
        {
            var dbw = new DragonBornWaffleFriesUC(b);
            dbw.DataContext = new DragonbornWaffleFries();
            b.Child = dbw;
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void AppleJuice(Object sender, RoutedEventArgs e)
        {
            var aa = new ArentinoAppleJuiceUC(b);
            aa.DataContext = new ArentinoAppleJuice();
            b.Child = aa;
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Coffee(Object sender, RoutedEventArgs e)
        {
            var cc = new CandlehearthCoffeeUC(b);
            cc.DataContext = new CandlehearthCoffee();
            b.Child = cc;
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Milk(Object sender, RoutedEventArgs e)
        {
            var mm = new MarkarthMilkUC(b);
            mm.DataContext = new MarkarthMilk();
            b.Child = mm;
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Soda(Object sender, RoutedEventArgs e)
        {
            var ss = new SailorSodaUC(b);
            ss.DataContext = new SailorSoda();
            b.Child = ss;
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Warrior(Object sender, RoutedEventArgs e)
        {
            var ww = new WarriorWaterUC(b);
            ww.DataContext = new WarriorWater();
            b.Child = ww;
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Briarheart(Object sender,RoutedEventArgs e)
        {
            
            var bb = new BriarheartBurgerUC(b);
            bb.DataContext = new BriarheartBurger();
            b.Child = bb;
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Draugr(Object sender, RoutedEventArgs e)
        {
            var dd = new DoubleDraugrUC(b);
            dd.DataContext = new DoubleDraugr();
            b.Child = dd;
            
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Thalmor(Object sender, RoutedEventArgs e)
        {
            var tt = new ThalmorTripleUC(b);
            tt.DataContext = new ThalmorTriple();
            b.Child = tt;
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Philly(Object sender, RoutedEventArgs e)
        {
            var pp = new PhillyPoacherUC(b);
            pp.DataContext = new PhillyPoacher();
            b.Child = pp;
            
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Garden(Object sender, RoutedEventArgs e)
        {
            var goo = new GardenOrcOmeletteUC(b);
            goo.DataContext = new GardenOrcOmelette();
            b.Child = goo;
            
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Smokehouse(Object sender, RoutedEventArgs e)
        {
            var ss = new SmokehouseSkeletonUC(b);
            ss.DataContext = new SmokehouseSkeleton();
            b.Child = ss;
            
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Thugs(Object sender,RoutedEventArgs e)
        {
            var tt = new ThugsTBoneUC(b);
            tt.DataContext = new ThugsTBone();
            b.Child = tt;
        }
    }
}
