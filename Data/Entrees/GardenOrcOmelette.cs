using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class to represent the garden orc omelette
    /// </summary>
    public class GardenOrcOmelette
    {
        // private variables for the garden orc omelette
        private bool broccoli = true;
        private bool mushrooms = true;
        private bool tomato = true;
        private bool cheddar = true;
        /// <summary>
        /// If there is broccoli in the omelette
        /// </summary>
        public bool Broccoli
        {
            get { return broccoli; }
            set 
            {
                broccoli = value; 
            }
        }
        /// <summary>
        /// If there is mushrooms in the omelette
        /// </summary>
        public bool Mushrooms
        {
            get { return mushrooms; }
            set 
            { 
                mushrooms = value; 
            }
        }
        /// <summary>
        /// If there is tomato in the omelette
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }
        /// <summary>
        /// If there is cheddar on the omelette
        /// </summary>
        public bool Cheddar
        {
            get { return cheddar; }
            set { cheddar = value; }
        }
        /// <summary>
        /// The price of the omelette
        /// </summary>
        public double Price
        {
            get { return 4.57; }
        }
        /// <summary>
        /// The calories of the omelette
        /// </summary>
        public uint Calories
        {
            get { return 404; }
        }
        /// <summary>
        /// A list of the special instructions for the omelette
        /// </summary>
        public List<string> SpecialInstructions
        {
            get 
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushroom");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions; 
            }
        }
        /// <summary>
        /// Returns the description of the omelette
        /// </summary>
        /// <returns>a string to describe the omelette</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
