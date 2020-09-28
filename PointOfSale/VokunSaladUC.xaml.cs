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
    /// Interaction logic for VokunSaladUC.xaml
    /// </summary>
    public partial class VokunSaladUC : UserControl
    {
        Border b;
        /// <summary>
        /// Constructor for the Vokun Salad user control
        /// </summary>
        /// <param name="bo">Border for the main window</param>
        public VokunSaladUC(Border bo)
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
