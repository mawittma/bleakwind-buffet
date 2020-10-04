using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class representing a Candle Heart Coffee
    /// </summary>
    public class CandlehearthCoffee : Drink, IOrderItem, INotifyPropertyChanged
    {
        //Private variables for the Candle Heart Coffee
        private bool ice = false;
        private bool decaf = false;
        private bool roomForCream = false;
        private Size size = Size.Small;
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// If this coffee has ice in it
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set {
                if (value == true && ice == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));

                }
                else if (value == false && ice == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                }

                ice = value;
            }
        }
        /// <summary>
        /// The size of this coffee
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set {
                if (value == Size.Small && size != Size.Small)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                }
                else if (value == Size.Medium && size != Size.Medium)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                }
                else if (value == Size.Large && size != Size.Large)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                }
                size = value;
            }
        }

        /// <summary>
        /// If this coffee is decaf
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set {
                if (value == true && decaf == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));

                }
                else if (value == false && decaf == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
                }

                decaf = value;
            }
        }
        /// <summary>
        /// If there should be room for cream in the coffee
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set {
                if (value == true && roomForCream == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));

                }
                else if (value == false && roomForCream == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
                }

                roomForCream = value;
            }
        }
        /// <summary>
        /// The price of the coffee based on size
        /// </summary>
        public override double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return .75;
                }
                else if (size == Size.Medium)
                {
                    return 1.25;
                }
                else
                {
                    return 1.75;
                }
            }
        }
        /// <summary>
        /// The calories in the coffee based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 7;
                }
                else if (size == Size.Medium)
                {
                    return 10;
                }
                else
                {
                    return 20;
                }
            }
        }
        /// <summary>
        /// Returns a list of special instructions for the coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");

                return instructions;
            }
        }
        /// <summary>
        /// Returns the description of the coffee
        /// </summary>
        /// <returns>a string to describe the coffee</returns>
        public override string ToString()
        {
            if (decaf)
            {
                return size+" Decaf Candlehearth Coffee";
                
            }
            else
            {
                return size+ " Candlehearth Coffee";
                
            }
        }
    }
}
