using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Collections;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// The current order that the user is adding to
    /// </summary>
    public class Order: ICollection<IOrderItem>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        public List<IOrderItem> order = new List<IOrderItem>();
        private double salesTaxRate = .12;
        private static int nextOrderNumber = 1;
        private uint calories = 0;
        private double subtotal = 0;
        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        /// <summary>
        /// sales tax rate as a double
        /// </summary>
        public double SalesTaxRate
        {
            get { return salesTaxRate; }
            set
            {
                if (salesTaxRate != value)
                {
                    salesTaxRate = value;
                }
            }
        }
        /// <summary>
        /// the subtotal of the order
        /// </summary>
        public double Subtotal
        {
            get 
            {
                double temp = 0;
                foreach(IOrderItem item in order)
                {
                    temp += item.Price;
                }
                if(temp != subtotal)
                {
                    subtotal = temp;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                }
                return subtotal;
            
            }
        }
        /// <summary>
        /// the tax of the order
        /// </summary>
        public double Tax
        {
            get { return SalesTaxRate * Subtotal; }
        }
        /// <summary>
        /// the total of the order
        /// </summary>
        public double Total
        {
            get { return Tax + Subtotal; }
        }
        /// <summary>
        /// total calories of the order
        /// </summary>
        public uint Calories
        {
            get 
            {
                uint temp = 0;
                foreach (IOrderItem item in order)
                {
                    temp += item.Calories;
                }
                if(temp != calories)
                {
                    calories = temp;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    
                }
                return calories;
            }
        }
        /// <summary>
        /// Overall number of the order
        /// </summary>
        public int Number
        {
            get
            {
                int temp = nextOrderNumber;
                nextOrderNumber++;
                return temp;
            }
        }

        public int Count => order.Count;

        public bool IsReadOnly => throw new NotImplementedException();

        /// <summary>
        /// A method to add an item to the order
        /// </summary>
        /// <param name="item">item being added to order</param>
        public void Add(IOrderItem item)
        {
            order.Add(item);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            
        }
        /// <summary>
        /// A method removing a item from the order collection
        /// </summary>
        /// <param name="item">item being removed from the order</param>
        public void Remove(IOrderItem item)
        {
            order.Remove(item);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            

        }

        
        public void Clear()
        {
            order.Clear();
        }

        public bool Contains(IOrderItem item)
        {
            foreach(IOrderItem i in order)
            {
                if(i == item)
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(IOrderItem[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        bool ICollection<IOrderItem>.Remove(IOrderItem item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<IOrderItem> GetEnumerator()
        {
            return order.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)order).GetEnumerator();
        }
    }
}
