using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class representing fried miraak
    /// </summary>
    public class FriedMiraak : Side , IOrderItem, INotifyPropertyChanged
    {
        // private variables for miraak
        private Size size = Size.Small;
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The size of the miraak
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
        /// The price of the miraak based on size
        /// </summary>
        public override double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 1.78;
                }
                else if (size == Size.Medium)
                {
                    return 2.01;
                }
                else
                {
                    return 2.88;
                }
            }
        }
        /// <summary>
        /// The calories of miraak based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 151;
                }
                else if (size == Size.Medium)
                {
                    return 236;
                }
                else
                {
                    return 306;
                }
            }
        }
        /// <summary>
        /// A list of special instructions for the miraak
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }
        /// <summary>
        /// Returns a description of the miraak
        /// </summary>
        /// <returns>a string to describe the miraak</returns>
        public override string ToString()
        {
            return size + " Fried Miraak";
        }
    }
}

