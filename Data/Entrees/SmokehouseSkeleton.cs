using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class to represent Smokehouse Skeleton
    /// </summary>
    public class SmokehouseSkeleton : Entree, IOrderItem, INotifyPropertyChanged
    {
        // private variables for smokehouse
        private bool sausageLink = true;
        private bool egg = true;
        private bool hashbrowns = true;
        private bool pancake = true;
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// If a sausage link comes with the smokehouse
        /// </summary>
        public bool SausageLink
        {
            get { return sausageLink; }
            set {
                if (value == true && sausageLink == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));

                }
                else if (value == false && sausageLink == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));
                }

                sausageLink = value;
            }
        }
        /// <summary>
        /// If a egg comes with the smokehouse
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set {
                if (value == true && egg == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));

                }
                else if (value == false && egg == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
                }

                egg = value;
            }
        }
        /// <summary>
        /// if there is hashbrowns with the smokehouse
        /// </summary>
        public bool Hashbrowns
        {
            get { return hashbrowns; }
            set {
                if (value == true && hashbrowns == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hashbrowns"));

                }
                else if (value == false && hashbrowns == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hashbrowns"));
                }

                hashbrowns = value;
            }
        }
        /// <summary>
        /// if there is pancakes with the smokehouse
        /// </summary>
        public bool Pancake
        {
            get { return pancake; }
            set {
                if (value == true && pancake == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));

                }
                else if (value == false && pancake == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
                }

                pancake = value;
            }
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
                if (!SausageLink)
                {
                    instructions.Add("Hold sausage");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                if (!Egg)
                {
                    instructions.Add("Hold eggs");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                if (!Hashbrowns)
                {
                    instructions.Add("Hold hash browns");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                if (!Pancake)
                {
                    instructions.Add("Hold pancakes");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
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
