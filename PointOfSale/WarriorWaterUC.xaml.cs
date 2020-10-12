﻿using System;
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
    /// Interaction logic for WarriorWaterUC.xaml
    /// </summary>
    public partial class WarriorWaterUC : UserControl
    {
        Border b,sb;
        CurrentOrder co;
        Order o;
        /// <summary>
        /// Constructor for the warrior water user control
        /// </summary>
        /// <param name="bo"></param>
        public WarriorWaterUC(Border bo, Order ord, CurrentOrder curOrd, Border  small)
        {
            InitializeComponent();
            b = bo;
            co = curOrd;
            o = ord;
            sb = small;
        }
        /// <summary>
        /// Click event changing the screen to the user control that was cliked on
        /// </summary>
        /// <param name="sender">needed for click event</param>
        /// <param name="e">needed for click event</param>
        void DoneClick(Object sender, RoutedEventArgs e)
        {
            co.SetOrder();
            b.Child = new OrderOptions(b,o,co,sb);
        }
    }
}
