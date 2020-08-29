using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class ThalmorTriple
    {
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
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value;}
        }
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }
        public bool Bacon
        {
            get { return bacon; }
            set { bacon = value; }
        }
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }
        public double Price
        {
            get { return 8.32; }
        }
        public uint Calories
        {
            get { return 943; }
        }
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bacon) instructions.Add("Hold Bacon, ");
                if (!Egg) instructions.Add("Hold Egg, ");
                return instructions;
            }
        }
        public override string ToString()
        {
            return "Thalmor Triple";
;
        }
    }
}
