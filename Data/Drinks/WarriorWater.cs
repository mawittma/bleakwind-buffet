using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    class WarriorWater
    {
        private bool ice = true;
        private bool lemon = true;
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
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }
        public double Price
        {
            get
            {
                return 0;
            }
        }
        public uint Calories
        {
            get
            {
                return 0;
            }
        }
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Hold Ice, ");
                if (Lemon) instructions.Add("Add Lemon, ");
                return instructions;
            }
        }
        public override string ToString()
        {
            return size + " Warrior Water";
        }
    }
}