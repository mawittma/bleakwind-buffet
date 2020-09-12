using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class representing Markarth Milk
    /// </summary>
    public class MarkarthMilk : Drink, IOrderItem
    {
        //Private variables for Markarth Milk
        private bool ice = false;
        private Size size = Size.Small;
        /// <summary>
        /// If ice is in the milk
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
        /// <summary>
        /// The size of the milk
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set { size = value; }
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
                if (Ice) instructions.Add("Add ice");

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
