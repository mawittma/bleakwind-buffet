using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class SmokehouseSkeleton
    {
        private bool sausageLink = true;
        private bool egg = true;
        private bool hashbrowns = true;
        private bool pancake = true;
        public bool SausageLink
        {
            get { return sausageLink; }
            set { sausageLink = value; }
        }
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }
        public bool Hashbrowns
        {
            get { return hashbrowns; }
            set { hashbrowns = value; }
        }
        public bool Pancake
        {
            get { return pancake; }
            set { pancake = value; }
        }
        public double Price
        {
            get { return 5.62; }
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
                if (!SausageLink) instructions.Add("Hold Sausage Link, ");
                if (!Egg) instructions.Add("Hold Egg, ");
                if (!Hashbrowns) instructions.Add("Hold Hashbrowns, ");
                if (!Pancake) instructions.Add("Hold Pancake, ");
                return instructions;
            }
        }
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
