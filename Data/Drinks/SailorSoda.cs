using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class representing Sailor Soda
    /// </summary>
    public class SailorSoda
    {
        //private variables for Sailor Soda
        private bool ice = true;
        private Size size = Size.Small;
        private SodaFlavor flavor = SodaFlavor.Cherry;
        /// <summary>
        /// If there is ice in the Sailor Soda
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
        /// <summary>
        /// The size of the soda
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }
        /// <summary>
        /// The flavor of the sailor soda
        /// </summary>
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }
        /// <summary>
        /// The price of the soda based on size
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 1.42;
                }
                else if (size == Size.Medium)
                {
                    return 1.74;
                }
                else
                {
                    return 2.07;
                }
            }
        }
        /// <summary>
        /// The calories of the soda based on size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 117;
                }
                else if (size == Size.Medium)
                {
                    return 153;
                }
                else
                {
                    return 205;
                }
            }
        }
        /// <summary>
        /// A list of special instructions for the soda
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Hold ice");

                return instructions;
            }
        }
        /// <summary>
        /// returns a description of the soda
        /// </summary>
        /// <returns>a string to describe the soda</returns>
        public override string ToString()
        {

            return size + " " + flavor + " Sailor Soda";
            
            
        }
    }
}
