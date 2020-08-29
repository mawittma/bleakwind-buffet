using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class PhillyPoacher
    {
        private bool sirloin = true;
        private bool onion = true;
        private bool roll = true;
        public bool Sirloin
        {
            get { return sirloin; }
            set { sirloin = value; }
        }
        public bool Onion
        {
            get { return onion; }
            set { onion = value; }
        }
        public bool Roll
        {
            get { return roll; }
            set { roll = value; }
        }
        public double Price
        {
            get { return 7.23; }
        }
        public uint Calories
        {
            get { return 784; }
        }
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold Sirloin, ");
                if (!Onion) instructions.Add("Hold Onion, ");
                if (!Roll) instructions.Add("Hold Roll, ");
                return instructions;
            }
        }
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
