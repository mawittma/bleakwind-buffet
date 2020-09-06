using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class representing Vokun salad
    /// </summary>
    public class VokunSalad
    {
        //private variables for Vokun salad
        private Size size = Size.Small;
        /// <summary>
        /// The size of the salad
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }
        /// <summary>
        /// The price of the salad based on size
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return .93;
                }
                else if (size == Size.Medium)
                {
                    return 1.28;
                }
                else
                {
                    return 1.82;
                }
            }
        }
        /// <summary>
        /// The Calories of the salad based size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 41;
                }
                else if (size == Size.Medium)
                {
                    return 52;
                }
                else
                {
                    return 73;
                }
            }
        }
        /// <summary>
        /// A list of special instructions for the salad
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }
        /// <summary>
        /// Returns a description of the salad
        /// </summary>
        /// <returns>a string to describe the salad</returns>
        public override string ToString()
        {
            return size + " Vokun Salad";
        }

    }
}
