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
using BleakwindBuffet.Data.Entrees;

namespace PointOfSale
{
    
    /// <summary>
    /// Interaction logic for ComboEntreeUC.xaml
    /// </summary>
    public partial class ComboEntreeUC : UserControl
    {
        Border b, sb;
        CurrentOrder co;
        Order o;
        Combo com;
        public ComboEntreeUC(Border bo, Order ord, CurrentOrder curOrd, Border small)
        {
            InitializeComponent();
            b = bo;
            co = curOrd;
            o = ord;
            sb = small;
            com = new Combo();
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Briarheart(Object sender, RoutedEventArgs e)
        {

            var bb = new BriarheartBurgerUC(b, o, co, sb);
            bb.DataContext = new BriarheartBurger();
            b.Child = bb;
            bb.InitCombo(com);
            com.Entree = (Entree)(bb.DataContext);

        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Draugr(Object sender, RoutedEventArgs e)
        {
            var dd = new DoubleDraugrUC(b, o, co, sb);
            dd.DataContext = new DoubleDraugr();
            b.Child = dd;
            dd.InitCombo(com);
            com.Entree = (Entree)(dd.DataContext);

        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Thalmor(Object sender, RoutedEventArgs e)
        {
            var tt = new ThalmorTripleUC(b, o, co, sb);
            tt.DataContext = new ThalmorTriple();
            b.Child = tt;
            tt.InitCombo(com);
            com.Entree = (Entree)(tt.DataContext);

        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Philly(Object sender, RoutedEventArgs e)
        {
            var pp = new PhillyPoacherUC(b, o, co, sb);
            pp.DataContext = new PhillyPoacher();
            b.Child = pp;
            pp.InitCombo(com);
            com.Entree = (Entree)(pp.DataContext);


        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Garden(Object sender, RoutedEventArgs e)
        {
            var goo = new GardenOrcOmeletteUC(b, o, co, sb);
            goo.DataContext = new GardenOrcOmelette();
            b.Child = goo;
            goo.InitCombo(com);
            com.Entree = (Entree)(goo.DataContext);


        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Smokehouse(Object sender, RoutedEventArgs e)
        {
            var ss = new SmokehouseSkeletonUC(b, o, co, sb);
            ss.DataContext = new SmokehouseSkeleton();
            b.Child = ss;
            ss.InitCombo(com);
            com.Entree = (Entree)(ss.DataContext);


        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void Thugs(Object sender, RoutedEventArgs e)
        {
            var tt = new ThugsTBoneUC(b, o, co, sb);
            tt.DataContext = new ThugsTBone();
            b.Child = tt;
            tt.InitCombo(com);
            com.Entree = (Entree)(tt.DataContext);

        }
    }
}
