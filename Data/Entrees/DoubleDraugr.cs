using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class to represent the Double Draugr
    /// </summary>
    public class DoubleDraugr
    {
        // private variables for the draugr
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;
        /// <summary>
        /// If there is a bun with the draugr
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }
        /// <summary>
        /// If there is ketchup on draugr
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }
        /// <summary>
        /// if there is mustard on draugr
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }
        /// <summary>
        /// If there pickle on the draugr
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }
        /// <summary>
        /// If there is cheese on the draugr
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }
        /// <summary>
        /// If there is tomato on the draugr
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }
        /// <summary>
        /// If there is a lettuce on the draugr
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }
        /// <summary>
        /// If there is mayo on the draugr
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }
        /// <summary>
        /// The price of the draugr
        /// </summary>
        public double Price
        {
            get { return 7.32; }
        }
        /// <summary>
        /// The calories of the draugr
        /// </summary>
        public uint Calories
        {
            get { return 743; }
        }
        /// <summary>
        /// A list of special instructions for the draugr
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                return instructions;
            }
        }
        /// <summary>
        /// Returns a description of the draugr
        /// </summary>
        /// <returns>string to describe the draugr</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
