using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    class ArentinoAppleJuice
    {
        private bool ice = false;
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
        public double Price
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
        public uint Calories
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
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add Ice, ");
                
                return instructions;
            }
        }
        public override string ToString()
        {
           
            return size +" Arentino Apple Juice";
 
        }
    }
}
