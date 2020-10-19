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
    /// Interaction logic for PaymentCash.xaml
    /// </summary>
    public partial class PaymentCash : UserControl
    {
        Border b, sb;
        public Order ord;
        public CurrentOrder co;
        public PaymentCash(Border bo, Order o, CurrentOrder curOrd, Border smallB)
        {
            InitializeComponent();
            b = bo;
            ord = o;
            co = curOrd;
            sb = smallB;
            DataContext = new ViewModel(o.Total);
        }
        void FinalizeOrder(Object sender, RoutedEventArgs e)
        {
            RoundRegister.CashDrawer.OpenDrawer();
            for(int i = 0; i < ord.order.Count; i++)
                {
                RoundRegister.RecieptPrinter.PrintLine(((i + 1) + ". " + ord.order[i].ToString() + "\t$" + ord.order[i].Price + "\n"));
                for (int j = 0; j < ord.order[i].SpecialInstructions.Count; j++)
                {
                    RoundRegister.RecieptPrinter.PrintLine("  - " + (ord.order[i].SpecialInstructions[j] + "\n"));
                }

            }
            RoundRegister.RecieptPrinter.CutTape();
            OrderOptions oo = new OrderOptions(b, ord, co, sb);
            b.Child = oo;
            oo.NewOrder(sender, e);
        }

        void ReturnToOrder(Object sender,RoutedEventArgs e)
        {
            b.Child = new OrderOptions(b, ord, co, sb);
        }
    }
}
