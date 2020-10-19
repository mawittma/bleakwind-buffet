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
using BleakwindBuffet.Data.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSideUC.xaml
    /// </summary>
    public partial class ComboSideUC : UserControl
    {

        Border b, sb;
        CurrentOrder co;
        Order o;
        Combo com;
        public ComboSideUC(Border bo, Order ord, CurrentOrder curOrd, Border small, Combo c)
        {
            InitializeComponent();
            b = bo;
            co = curOrd;
            o = ord;
            sb = small;
            com =c;
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Vokun(Object sender, RoutedEventArgs e)
        {
            var vs = new VokunSaladUC(b, o, co, sb);
            vs.DataContext = new VokunSalad();
            b.Child = vs;
            vs.InitCombo(com);
            com.Side = (Side)(vs.DataContext);


        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Grits(Object sender, RoutedEventArgs e)
        {
            var mog = new MadOtarGritsUC(b, o, co, sb);
            mog.DataContext = new MadOtarGrits();
            b.Child = mog;
            mog.InitCombo(com);
            com.Side = (Side)(mog.DataContext);

        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Miraak(Object sender, RoutedEventArgs e)
        {
            var fm = new FriedMiraakUC(b, o, co, sb);
            fm.DataContext = new FriedMiraak();
            b.Child = fm;
            fm.InitCombo(com);
            com.Side = (Side)(fm.DataContext);

        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Fries(Object sender, RoutedEventArgs e)
        {
            var dbw = new DragonBornWaffleFriesUC(b, o, co, sb);
            dbw.DataContext = new DragonbornWaffleFries();
            b.Child = dbw;
            dbw.InitCombo(com);
            com.Side = (Side)(dbw.DataContext);

        }
    }
}
