using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class to represent the Double Draugr
    /// </summary>
    public class DoubleDraugr : Entree, IOrderItem, INotifyPropertyChanged
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
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// If there is a bun with the draugr
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
        /// If there is ketchup on draugr
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
        /// if there is mustard on draugr
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
        /// If there pickle on the draugr
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
        /// If there is cheese on the draugr
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
        /// <summary>
        /// If there is tomato on the draugr
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set {
                if (value == true && tomato == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));

                }
                else if (value == false && tomato == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                }

                tomato = value;
            }
        }
        /// <summary>
        /// If there is a lettuce on the draugr
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set {
                if (value == true && lettuce == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));

                }
                else if (value == false && lettuce == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                }

                lettuce = value;
            }
        }
        /// <summary>
        /// If there is mayo on the draugr
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set {
                if (value == true && mayo == false)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));

                }
                else if (value == false && mayo == true)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
                }

                mayo = value;
            }
        }
        public string Description
        {
            get
            {
                return "Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.";
            }
        }
        /// <summary>
        /// The price of the draugr
        /// </summary>
        public override double Price
        {
            get { return 7.32; }
        }
        /// <summary>
        /// The calories of the draugr
        /// </summary>
        public override uint Calories
        {
            get { return 743; }
        }
        /// <summary>
        /// A list of special instructions for the draugr
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
                if (!Tomato)
                {
                    instructions.Add("Hold tomato");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                if (!Lettuce)
                {
                    instructions.Add("Hold lettuce");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                if (!Mayo)
                {
                    instructions.Add("Hold mayo");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
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
