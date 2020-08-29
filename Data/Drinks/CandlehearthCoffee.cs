using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    class CandlehearthCoffee
    {
        private bool ice = false;
        private bool decaf = false;
        private bool roomForCream = false;
        private Size size = Size.Small;
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }
        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
        }
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
