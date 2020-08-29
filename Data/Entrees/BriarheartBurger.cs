using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class BriarheartBurger
    {
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
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
            set { mustard = value; }
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
        public double Price
        {
            get { return 6.32; }
        }
        public uint Calories
        {
            get { return 743; }
        }
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
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
