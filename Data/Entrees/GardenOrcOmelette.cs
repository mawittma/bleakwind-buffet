using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class GardenOrcOmelette
    {
        private bool broccoli = true;
        private bool mushrooms = true;
        private bool tomato = true;
        private bool cheddar = true;
        
        public bool Broccoli
        {
            get { return broccoli; }
            set 
            {
                broccoli = value; 
            }
        }
        public bool Mushrooms
        {
            get { return mushrooms; }
            set 
            { 
                mushrooms = value; 
            }
        }
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }
        public bool Cheddar
        {
            get { return cheddar; }
            set { cheddar = value; }
        }
        public double Price
        {
            get { return 4.57; }
        }
        public uint Calories
        {
            get { return 602; }
        }
        
        public List<string> SpecialInstructions
        {
            get 
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold Broccoli, ");
                if (!Mushrooms) instructions.Add("Hold Mushrooms, ");
                if (!Tomato) instructions.Add("Hold Tomato, ");
                if (!Cheddar) instructions.Add("Hold Cheddar, ");
                return instructions; 
            }
        }
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
