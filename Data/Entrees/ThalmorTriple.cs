using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class to represent Thalmor Triple
    /// </summary>
    public class ThalmorTriple
    {
        // private variables for thalmor triple
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;
        private bool bacon = true;
        private bool egg = true;
        /// <summary>
        /// if there is a bun with thalmor triple
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }
        /// <summary>
        /// if there is ketchup on the thalmor triple
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }
        /// <summary>
        /// if there is mustard in the thalmor triple
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value;}
        }
        /// <summary>
        /// if there is pickles in the triple
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }
        /// <summary>
        /// if there is cheese on the triple
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }
        /// <summary>
        /// if there is tomato on the triple
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }
        /// <summary>
        /// if there is lettuce on the triple
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }
        /// <summary>
        /// if there is mayo on the triple
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }
        /// <summary>
        /// if there is bacon on the triple
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set { bacon = value; }
        }
        /// <summary>
        /// if there is an egg on the triple
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }
        /// <summary>
        /// the price of the triple
        /// </summary>
        public double Price
        {
            get { return 8.32; }
        }
        /// <summary>
        /// the calories of the triple
        /// </summary>
        public uint Calories
        {
            get { return 943; }
        }
        /// <summary>
        /// a list of special instructions for the triple 
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
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
                return instructions;
            }
        }
        /// <summary>
        /// returns the description of the thalmor triple
        /// </summary>
        /// <returns>a string to describe thalmor triple</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
;
        }
    }
}
