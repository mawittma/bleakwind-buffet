using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing a Philly Poacher
    /// </summary>
    public class PhillyPoacher
    {
        // private variables for the philly poacher
        private bool sirloin = true;
        private bool onion = true;
        private bool roll = true;
        /// <summary>
        /// If there is sirloin in the philly
        /// </summary>
        public bool Sirloin
        {
            get { return sirloin; }
            set { sirloin = value; }
        }
        /// <summary>
        /// If there is onion in your philly
        /// </summary>
        public bool Onion
        {
            get { return onion; }
            set { onion = value; }
        }
        /// <summary>
        /// If there is a roll with philly
        /// </summary>
        public bool Roll
        {
            get { return roll; }
            set { roll = value; }
        }
        /// <summary>
        /// The price of the philly
        /// </summary>
        public double Price
        {
            get { return 7.23; }
        }
        /// <summary>
        /// The calories of the philly
        /// </summary>
        public uint Calories
        {
            get { return 784; }
        }
        /// <summary>
        /// A list of special instructions for the philly
        /// </summary>
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
        /// <summary>
        /// Returns a description of the philly
        /// </summary>
        /// <returns>a string to describe the philly</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
