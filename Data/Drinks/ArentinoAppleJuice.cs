using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for representing a Arentino Apple Juice Drink
    /// </summary>
    public class ArentinoAppleJuice : Drink, IOrderItem
    {
        //private variables for Arentino Apple juice
        private bool ice = false;
        private Size size = Size.Small;
        /// <summary>
        /// If this apple juice has ice in it
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
        /// <summary>
        /// The size of the apple juice
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set { size = value; }
        }
        /// <summary>
        /// The price of the apple juice based on its size
        /// </summary>
        public override double Price
        {
            get
            {
                if(size == Size.Small)
                {
                    return .62;
                }else if(size == Size.Medium)
                {
                    return .87;
                }
                else
                {
                    return 1.01;
                }
            }
        }
        /// <summary>
        /// The calories of the apple juice based on the size
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 44;
                }
                else if (size == Size.Medium)
                {
                    return 88;
                }
                else
                {
                    return 132;
                }
            }
        }
        /// <summary>
        /// Returns a list of special instructions for the apple juice
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
        /// Returns a description of the apple juice
        /// </summary>
        /// <returns>a string describing the apple juice</returns>
        public override string ToString()
        {
           
            return size +" Arentino Apple Juice";
 
        }
    }
}
