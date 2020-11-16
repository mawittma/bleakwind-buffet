using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class representing Markarth Milk
    /// </summary>
    public class MarkarthMilk : Drink, IOrderItem, INotifyPropertyChanged
    {
        //Private variables for Markarth Milk
        private bool ice = false;
        private Size size = Size.Small;
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// If ice is in the milk
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
        /// The size of the milk
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set {
                if (value == Size.Small && size != Size.Small)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
                else if (value == Size.Medium && size != Size.Medium)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
                else if (value == Size.Large && size != Size.Large)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
                size = value;
            }
        }
        public string Description
        {
            get { return "Hormone-free organic 2% milk."; }
        }
        /// <summary>
        /// The price of the milk based on size
        /// </summary>
        public override double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 1.05;
                }
                else if (size == Size.Medium)
                {
                    return 1.11;
                }
                else
                {
                    return 1.22;
                }
            }
        }
        /// <summary>
        /// The calories of the milk based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 56;
                }
                else if (size == Size.Medium)
                {
                    return 72;
                }
                else
                {
                    return 93;
                }
            }
        }
        /// <summary>
        /// A list of special instructions for the milk
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice)
                {
                    instructions.Add("Add ice");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }


                return instructions;
            }
        }
        /// <summary>
        /// Returns a string of the description of the milk
        /// </summary>
        /// <returns>a string to describe the milk</returns>
        public override string ToString()
        {
            
            return size + " Markarth Milk";
            
        }
    }
}
