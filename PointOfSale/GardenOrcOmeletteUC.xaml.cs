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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for GardenOrcOmeletteUC.xaml
    /// </summary>
    public partial class GardenOrcOmeletteUC : UserControl
    {
        Border b,sb;
        CurrentOrder co;
        Order o;
        Combo com;
        /// <summary>
        /// Constructor for the Garden Orc Omelette user control
        /// </summary>
        /// <param name="bo">Border for the main window</param>
        public GardenOrcOmeletteUC(Border bo,Order ord,CurrentOrder curOrd,Border small)
        {
            InitializeComponent();
            b = bo;
            co = curOrd;
            o = ord;
            sb = small;
            com = null;
        }
        public void InitCombo(Combo c)
        {
            com = c;
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void DoneClick(Object sender, RoutedEventArgs e)
        {
            if (com == null)
            {
                co.SetOrder();
                b.Child = new OrderOptions(b, o, co, sb);
            }
            else
            {
                b.Child = new ComboSideUC(b, o, co, sb, com);
            }
        }
    }
}
