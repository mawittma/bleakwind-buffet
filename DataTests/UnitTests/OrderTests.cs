using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;


namespace BleakwindBuffet.DataTests.UnitTests
{
    public class OrderTests
    {
        [Fact]
        public void IsAssignableFromINotifyPropertyChanged()
        {
            Order o = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(o);
        }
        [Fact]
        public void IsAssignableFromINotifyCollectionChanged()
        {
            Order o = new Order();
            Assert.IsAssignableFrom<INotifyCollectionChanged>(o);
        }
        [Fact]
        public void IsAssignableFromICollection()
        {
            Order o = new Order();
            Assert.IsAssignableFrom<ICollection<IOrderItem>>(o);
        }
        /*[Fact]
        public void ChangingEntreeNotifiesPrice()
        {
            Order o = new Order();
            Assert.PropertyChanged(o, "Subtotal", () =>
            {
                double temp = o.Subtotal;
            });
        } */
    }
}
