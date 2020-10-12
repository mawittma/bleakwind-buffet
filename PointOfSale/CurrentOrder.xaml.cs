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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CurrentOrder.xaml
    /// </summary>
    public partial class CurrentOrder : UserControl
    {
        List<IOrderItem> order = new List<IOrderItem>();
        public Order o;
        /// <summary>
        /// Constructor for the current order user control
        /// </summary>
        public CurrentOrder(Order ord)
        {
            
            InitializeComponent();

            o = ord;
            DataContext = o;
            
            //SetOrder();
        }

        public void SetOrder()
        {
            
            string tempStr = "";
            
            for(int i = 0; i < o.order.Count;i++)
            {
                tempStr += ((i+1)+". "+o.order[i].ToString() + "\t$"+o.order[i].Price +"\n");
                for (int j = 0; j < o.order[i].SpecialInstructions.Count; j++)
                {
                    tempStr += "  - "+ (o.order[i].SpecialInstructions[j] + "\n");
                }
                
            }
            Console.WriteLine(o.Subtotal);
            Console.WriteLine(o.Tax);
            Console.WriteLine(o.Total);
            ordStr.Text = tempStr;
        }
    }
}
