using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class to represent Smokehouse Skeleton
    /// </summary>
    public class SmokehouseSkeleton : Entree, IOrderItem
    {
        // private variables for smokehouse
        private bool sausageLink = true;
        private bool egg = true;
        private bool hashbrowns = true;
        private bool pancake = true;
        /// <summary>
        /// If a sausage link comes with the smokehouse
        /// </summary>
        public bool SausageLink
        {
            get { return sausageLink; }
            set { sausageLink = value; }
        }
        /// <summary>
        /// If a egg comes with the smokehouse
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }
        /// <summary>
        /// if there is hashbrowns with the smokehouse
        /// </summary>
        public bool Hashbrowns
        {
            get { return hashbrowns; }
            set { hashbrowns = value; }
        }
        /// <summary>
        /// if there is pancakes with the smokehouse
        /// </summary>
        public bool Pancake
        {
            get { return pancake; }
            set { pancake = value; }
        }
        /// <summary>
        /// The price of the smokehosue
        /// </summary>
        public override double Price
        {
            get { return 5.62; }
        }
        /// <summary>
        /// The calories of the smokehouse
        /// </summary>
        public override uint Calories
        {
            get { return 602; }
        }
        // A list of special instructions for the smokehouse
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!Hashbrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }
        }
        /// <summary>
        /// Returns a description of the smokehouse
        /// </summary>
        /// <returns>a string to describe the smokehouse</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
