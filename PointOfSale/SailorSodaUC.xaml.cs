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
    /// Interaction logic for SailorSodaUC.xaml
    /// </summary>
    public partial class SailorSodaUC : UserControl
    {
        Border b;
        /// <summary>
        /// Constructor for the sailor soda user control
        /// </summary>
        /// <param name="bo"></param>
        public SailorSodaUC(Border bo)
        {
            InitializeComponent();
            b = bo;
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void DoneClick(Object sender, RoutedEventArgs e)
        {
            b.Child = new OrderOptions(b);
        }
    }
}
