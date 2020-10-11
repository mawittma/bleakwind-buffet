using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Collections;
using System.Text;

namespace BleakwindBuffet.Data
{
    public class Order: ICollection<IOrderItem>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        private List<IOrderItem> order = new List<IOrderItem>();
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
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            CollectionChanged += CollectionChangedListener;
        }
        /// <summary>
        /// A method removing a item from the order collection
        /// </summary>
        /// <param name="item">item being removed from the order</param>
        public void Remove(IOrderItem item)
        {
            order.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            CollectionChanged += CollectionChangedListener;

        }

        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch(e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach(IOrderItem item in e.NewItems)
                    {
                        item.PropertyChanged += CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach(IOrderItem item in e.OldItems)
                    {
                        item.PropertyChanged -= CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException("NotifyCollectionChangedAction.Reset not supported");
            }
        }

        void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {

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
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
