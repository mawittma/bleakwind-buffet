using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the Briarheart Burger
    /// </summary>
    public class BriarheartBurger : Entree, IOrderItem, INotifyPropertyChanged
    {
        // private variables for the burger
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// If there is a bun with the burger
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set {
                if (value == true && bun == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));

                }
                else if (value == false && bun == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                }

                bun = value;
            }
        }
        /// <summary>
        /// If there is ketchup on the burger
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set {
                if (value == true && ketchup == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));

                }
                else if (value == false && ketchup == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                }

                ketchup = value;
            }
        }
        /// <summary>
        /// If there is mustard on the burger
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set {
                if (value == true && mustard == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));

                }
                else if (value == false && mustard == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                }

                mustard = value;
            }
        }
        /// <summary>
        /// if there is pickle on the burger
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set {
                if (value == true && pickle == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));

                }
                else if (value == false && pickle == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                }

                pickle = value;
            }
        }
        /// <summary>
        /// If there is cheese on the burger
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set {
                if (value == true && cheese == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));

                }
                else if (value == false && cheese == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                }

                cheese = value;
            }
        }

        public string Description
        {
            get { return "Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese."; }
        }

        /// <summary>
        /// The price of the burger
        /// </summary>
        public override double Price
        {
            get { return 6.32; }
        }
        /// <summary>
        /// The calories of the burger
        /// </summary>
        public override uint Calories
        {
            get { return 743; }
        }
        /// <summary>
        /// A list of special instructions for the burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun)
                {
                    instructions.Add("Hold bun");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                if (!Ketchup)
                {
                    instructions.Add("Hold ketchup");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                if (!Mustard)
                {
                    instructions.Add("Hold mustard");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                if (!Pickle)
                {
                    instructions.Add("Hold pickle");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                if (!Cheese)
                {
                    instructions.Add("Hold cheese");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
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
