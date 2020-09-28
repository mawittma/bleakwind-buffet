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
            b.Child = new VokunSaladUC(b);
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Grits(Object sender, RoutedEventArgs e)
        {
            b.Child = new MadOtarGritsUC(b);
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Miraak(Object sender, RoutedEventArgs e)
        {
            b.Child = new FriedMiraakUC(b);
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Fries(Object sender, RoutedEventArgs e)
        {
            b.Child = new DragonBornWaffleFriesUC(b);
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void AppleJuice(Object sender, RoutedEventArgs e)
        {
            b.Child = new ArentinoAppleJuiceUC(b);
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Coffee(Object sender, RoutedEventArgs e)
        {
            b.Child = new CandlehearthCoffeeUC(b);
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Milk(Object sender, RoutedEventArgs e)
        {
            b.Child = new MarkarthMilkUC(b);
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Soda(Object sender, RoutedEventArgs e)
        {
            b.Child = new SailorSodaUC(b);
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Warrior(Object sender, RoutedEventArgs e)
        {
            b.Child = new WarriorWaterUC(b);
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Briarheart(Object sender,RoutedEventArgs e)
        {
            b.Child = new BriarheartBurgerUC(b);
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Draugr(Object sender, RoutedEventArgs e)
        {
            b.Child = new DoubleDraugrUC(b);
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Thalmor(Object sender, RoutedEventArgs e)
        {
            b.Child = new ThalmorTripleUC(b);
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Philly(Object sender, RoutedEventArgs e)
        {
            b.Child = new PhillyPoacherUC(b);
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Garden(Object sender, RoutedEventArgs e)
        {
            b.Child = new GardenOrcOmeletteUC(b);
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Smokehouse(Object sender, RoutedEventArgs e)
        {
            b.Child = new SmokehouseSkeletonUC(b);
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Thugs(Object sender,RoutedEventArgs e)
        {
            b.Child = new ThugsTBoneUC(b);
        }
    }
}
