using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class representing a Candle Heart Coffee
    /// </summary>
    public class CandlehearthCoffee
    {
        //Private variables for the Candle Heart Coffee
        private bool ice = false;
        private bool decaf = false;
        private bool roomForCream = false;
        private Size size = Size.Small;
        /// <summary>
        /// If this coffee has ice in it
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
        /// <summary>
        /// The size of this coffee
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// If this coffee is decaf
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }
        /// <summary>
        /// If there should be room for cream in the coffee
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
        }
        /// <summary>
        /// The price of the coffee based on size
        /// </summary>
        public double Price
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
        public uint Calories
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
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add Ice, ");
                if (RoomForCream) instructions.Add("Add Cream, ");

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
