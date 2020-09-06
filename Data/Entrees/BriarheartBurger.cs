using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the Briarheart Burger
    /// </summary>
    public class BriarheartBurger
    {
        // private variables for the burger
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        /// <summary>
        /// If there is a bun with the burger
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }
        /// <summary>
        /// If there is ketchup on the burger
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }
        /// <summary>
        /// If there is mustard on the burger
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }
        /// <summary>
        /// if there is pickle on the burger
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }
        /// <summary>
        /// If there is cheese on the burger
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }
        /// <summary>
        /// The price of the burger
        /// </summary>
        public double Price
        {
            get { return 6.32; }
        }
        /// <summary>
        /// The calories of the burger
        /// </summary>
        public uint Calories
        {
            get { return 743; }
        }
        /// <summary>
        /// A list of special instructions for the burger
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold Bun, ");
                if (!Ketchup) instructions.Add("Hold Ketchup, ");
                if (!Mustard) instructions.Add("Hold Mustard, ");
                if (!Pickle) instructions.Add("Hold Pickle, ");
                if (!Cheese) instructions.Add("Hold Cheese, ");
                return instructions;
            }
        }
        /// <summary>
        /// returns a description of the burger
        /// </summary>
        /// <returns>a string to describe the burger</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
